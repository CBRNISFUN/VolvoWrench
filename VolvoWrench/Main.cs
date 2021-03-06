﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using System.Windows.Input;
using VolvoWrench.Demo_stuff;

namespace VolvoWrench
{
    public sealed partial class Main : Form
    {
        public enum DemoType
        {
            None,
            GoldSource,
            Source
        }

        public static readonly string LogPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" +
                                       "VWLog.log";

        public SourceParser CurrentDemoFile;
        public DemoType CurrentDemoType;
        public string CurrentFile;
        readonly GlobalHotkeys _hotkey = new GlobalHotkeys();

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            switch (m.Msg)
            {
                case WM_HOTKEY:
                    {
                        if ((short)m.WParam == _hotkey.HotkeyID)
                        {
                            // do your thing
                            MessageBox.Show("ALT+D");
                        }
                        break;
                    }
                default:
                    {
                        base.WndProc(ref m);
                        break;
                    }
            }
        }

        public Main()
        {
            InitializeComponent();
            AllowDrop = true;
            HotkeyTimer.Start();
            goldSourceToolsToolStripMenuItem.Enabled = false;
            toolsToolStripMenuItem.Enabled = false;
            GlobalHotkeys.RegisterHotKey(Handle, _hotkey.HotkeyID, (int)global::GlobalHotkeys.MOD_ALT, (int)Keys.D);
            _hotkey.UnregisterGlobalHotKey();
            if (File.Exists(LogPath))
            {
                File.Delete(LogPath);
            }

            #region OpenedWithFile check
            var dropFile = (Environment.GetCommandLineArgs().Any(x => Path.GetExtension(x) == ".dem"))
                ? Environment.GetCommandLineArgs().First(x => Path.GetExtension(x) == ".dem")
                : null;
            if (dropFile == null)
            {
                toolsToolStripMenuItem.Enabled = false;
                richTextBox1.Text = "^ Use File->Open to open a correct \".dem\" file!" + "\n" +
                                    "No file dropped!";
            }
            else
            {
                if (Path.GetExtension(dropFile) == ".dem")
                {
                    CurrentFile = dropFile;
                    Stream cfs = File.Open(CurrentFile, FileMode.Open);
                    CurrentDemoFile = new SourceParser(cfs);
                    cfs.Close();
                    PrintSetails(CurrentDemoFile);
                    toolsToolStripMenuItem.Enabled = true;
                    Log(Path.GetFileName(CurrentFile + " opened"));
                }
                else
                {
                    toolsToolStripMenuItem.Enabled = false;
                    richTextBox1.Text = "^ Use File->Open to open a correct \".dem\" file!" + "\n" +
                                        "No file dropped!";
                }
            }
            #endregion

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Filter = "Demo files | *.dem";
                switch (of.ShowDialog())
                {
                    case DialogResult.OK:
                        CurrentFile = of.FileName;
                        if (CurrentFile != null && (File.Exists(CurrentFile) && Path.GetExtension(CurrentFile) == ".dem"))
                        {
                            Stream cfs = File.Open(CurrentFile, FileMode.Open);
                            CurrentDemoFile = new SourceParser(cfs);
                            cfs.Close();
                            PrintSetails(CurrentDemoFile);
                            toolsToolStripMenuItem.Enabled = true;
                            Log(Path.GetFileName(CurrentFile) + " opened!");
                        }
                        break;
                }
            }

        }

        #region Help Toolstrip Stuff
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var a = new About())
            {
                Log("About");
                a.ShowDialog();
            }
        }
        private void sourcerunsWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://wiki.sourceruns.org");
        }

        private void sourcerunsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://sourceruns.org");
        }
        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Github check
            using (var a = new Update())
            {
                a.ShowDialog();
                Log("Updatecheck");
            }
        }
        #endregion

        #region Context menu stuff Showlog,Export etc.
        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log("Copyall");
            Clipboard.SetText(richTextBox1.Text);
        }
        private void rescanFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentFile == null || (!File.Exists(CurrentFile) || Path.GetExtension(CurrentFile) != ".dem")) return;
            Stream cfs = File.Open(CurrentFile, FileMode.Open);
            CurrentDemoFile = new SourceParser(cfs);
            cfs.Close();
            PrintSetails(CurrentDemoFile);
            toolsToolStripMenuItem.Enabled = true;
            Log(Path.GetFileName(CurrentFile + " rescanned."));
        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log("Log opened");
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "VWLog.log");
        }

        private void exportDemoDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new SaveFileDialog();
            if (a.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(a.FileName, richTextBox1.Lines);
                //TODO: EXPORT AS XML
            }
        }

        private void renameDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentFile == null || !File.Exists(CurrentFile) || Path.GetExtension(CurrentFile) != ".dem") return;
            Stream cfs = File.Open(CurrentFile, FileMode.Open);
            CurrentDemoFile = new SourceParser(cfs);
            cfs.Close();

            var time = (CurrentDemoFile.Info.Flags.Count(x => x.Name == "#SAVE#") == 0)
                ? CurrentDemoFile.Info.Seconds.ToString("#,0.000")
                : CurrentDemoFile.Info.Flags.Last(x => x.Name == "#SAVE#").Time.ToString("#,0.000");
            File.Move(CurrentFile,
                Path.GetDirectoryName(CurrentFile) + "\\" +
                CurrentDemoFile.Info.MapName.Substring(3, CurrentDemoFile.Info.MapName.Length - 3) + "-" +
                $"{time}" + "-" + CurrentDemoFile.Info.ClientName + ".dem");
        }
        #endregion

        #region Source Tools
        private void netdecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentFile == null || (!File.Exists(CurrentFile) || Path.GetExtension(CurrentFile) != ".dem")) return;
            using (Stream cfs = File.Open(CurrentFile, FileMode.Open))
            using (var nd = new DemoDecoder(cfs))
            {
                Log("Netdecode opened");
                nd.ShowDialog();
            }
        }
        private void heatmapGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Settings
        private void hotkeysToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (var a = new Hotkey())
                a.ShowDialog();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fd = new FontDialog())
                {
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.Font = fd.Font;
                    }
                }
                if (CurrentFile == null || (!File.Exists(CurrentFile) || Path.GetExtension(CurrentFile) != ".dem")) return;
                Stream cfs = File.Open(CurrentFile, FileMode.Open);
                CurrentDemoFile = new SourceParser(cfs);
                cfs.Close();
                PrintSetails(CurrentDemoFile);
                toolsToolStripMenuItem.Enabled = true;
                Log(Path.GetFileName(CurrentFile + " rescanned for font change.")); //Terribble hack for recolor.
                Log("Font changed");
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }
        #endregion

        #region DragDrop file
        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            var dropfiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            var dropfile = (dropfiles.Any(x => Path.GetExtension(x) == ".dem"))
                 ? dropfiles.First(x => Path.GetExtension(x) == ".dem")
                 : null;
            if (dropfile != null) CurrentFile = dropfile;
            if (CurrentFile == null || (!File.Exists(CurrentFile) || Path.GetExtension(CurrentFile) != ".dem")) return;
            Stream cfs = File.Open(CurrentFile, FileMode.Open);
            CurrentDemoFile = new SourceParser(cfs);
            cfs.Close();
            PrintSetails(CurrentDemoFile);
            toolsToolStripMenuItem.Enabled = true;
            Log(Path.GetFileName(CurrentFile) + " opened!");
        }
        #endregion

        public static void Log(string s)
        {
            var ns = DateTime.Now.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + " " +
                     $"[{WindowsIdentity.GetCurrent()?.Name}]" + ": " + s;
            File.AppendAllLines(LogPath, new[] { ns });
        }

        public void PrintSetails(SourceParser d)
        {
            if (CurrentDemoFile == null) return;
            richTextBox1.Text = string.Format("Analyzed source engine demo file:" + "\n" + "----------------------------------------------------------{0}\n", $"\n{$"Demo protocol: {CurrentDemoFile.Info.DemoProtocol}\n"}{$"Net protocol: {CurrentDemoFile.Info.NetProtocol}\n"}{$"Server name: {CurrentDemoFile.Info.ServerName}\n"}{$"Client name: {CurrentDemoFile.Info.ClientName}\n"}{$"Map name: {CurrentDemoFile.Info.MapName}\n"}{$"Game directory: {CurrentDemoFile.Info.GameDirectory}\n"}{$"Length in seconds: {CurrentDemoFile.Info.Seconds}\n"}{$"Tick count: {CurrentDemoFile.Info.TickCount}\n"}{$"Frame count: {CurrentDemoFile.Info.FrameCount}\n"}----------------------------------------------------------");
            foreach (var f in CurrentDemoFile.Info.Flags)
                switch (f.Name)
                {
                    case "#SAVE#":
                        richTextBox1.Text += $"#SAVE# flag at Tick: {f.Tick} -> {f.Time}s" + "\n";
                        HighlightLastLine(richTextBox1, Color.Yellow);
                        break;
                    case "autosave":
                        richTextBox1.Text += $"Autosave at Tick: {f.Tick} -> {f.Time}s" + "\n";
                        HighlightLastLine(richTextBox1, Color.DarkOrange);
                        break;
                    default:
                        break;
                }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to close the program?","Confirm!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
               //TODO: Uncomment this when releasing but its annoying so I won't leave this in while testing. :p
            }
        }

        public void HighlightLastLine(RichTextBox textControl, Color highlightColor)
        {
            textControl.Text = textControl.Text.Trim();
            textControl.SelectionStart = 0;
            textControl.SelectionLength = 0;
            textControl.SelectionColor = Color.Black;
            var lastLineText = textControl.Lines[richTextBox1.Lines.Count() - 1];
            var lastLineStartIndex = richTextBox1.Text.LastIndexOf(lastLineText, StringComparison.Ordinal);
            textControl.SelectionStart = lastLineStartIndex;
            textControl.SelectionLength = textControl.Text.Length - 1;
            textControl.SelectionColor = highlightColor;
            textControl.DeselectAll();
            textControl.Select(textControl.Text.Length, 0);
        }

        private void HotkeyTimer_Tick(object sender, EventArgs e)
        {
            if (CurrentDemoFile == null) return;
            var keyInput = KeyInputApi.GetKeyState(0x70);
            if ((keyInput & 0x8000) != 0)
                MessageBox.Show("Demo protocol: " + CurrentDemoFile.Info.DemoProtocol + "\n"
                                + "Net protocol: " + CurrentDemoFile.Info.NetProtocol + "\n"
                                + "Server name: " + CurrentDemoFile.Info.ServerName + "\n"
                                + "Client name: " + CurrentDemoFile.Info.ClientName + "\n"
                                + "Map name: " + CurrentDemoFile.Info.MapName + "\n"
                                + "Game directory: " + CurrentDemoFile.Info.GameDirectory + "\n"
                                + "Length in seconds: " + CurrentDemoFile.Info.Seconds + "\n"
                                + "Tick count: " + CurrentDemoFile.Info.TickCount + "\n"
                                + "Frame count: " + CurrentDemoFile.Info.FrameCount);
        }

        private void openAsavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sa = new saveanalyzerform())
            {
                sa.ShowDialog();
            }
        }
    }
}