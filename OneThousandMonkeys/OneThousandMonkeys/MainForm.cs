/********************************************************************************
File: MainForm.cs
@(#) Purpose: This is the main FORM for the One Thousand Monkeys.
@(#) I created this program as a result of watching Amanda Lang's
@(#)  Amanda Lang: Suing internet pirates harsh, but it's the right thing to do
@(#) See: https://blog.geekwisdom.org/2019/05/the-most-dangerous-software-on-internet.html
**********************************************************************************
Written By: Brad Detchevery
Created: May 5th, 2019
********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MarkovSharp.Components;
using MarkovSharp.TokenisationStrategies;
using MarkovSharp.Models;


namespace OneThousandMonkeys
{
    public partial class MainForm : Form
    {
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripStatusLabel statusTextLabel;
        private Random random1;
        private Random random3;
        private int PercentageComplete;
        System.Drawing.Image origImage;
        public MainForm()
        {
            toolStripProgressBar = new ToolStripProgressBar();
            statusTextLabel = new ToolStripStatusLabel();
            statusTextLabel.Text = "READY.";
            InitializeComponent();
            gwStatusStrip.Items.Add(statusTextLabel);
            gwStatusStrip.Items.Add(toolStripProgressBar);
            gwLink.Links.Add(0,gwLink.Text.Length,@"https://geekwisdom.org");
            string MarkovDefault = System.IO.Directory.GetCurrentDirectory() + @"\books\";
            if (Directory.Exists(MarkovDefault)) ChainDataRead.Text = MarkovDefault;
            quickPick.Items.Add("720 Kb");
            quickPick.Items.Add("1 MB");
            quickPick.Items.Add("100 MB");
            quickPick.Items.Add("1 GB");
            quickPick.Items.Add("4 GB");
            quickPick.Items.Add("8 GB");
            quickPick.SelectedIndexChanged += QuickPick_SelectedIndexChanged;
            random1 = new Random();
            random3 = new Random();

        }

        private void QuickPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedSize = (string) quickPick.SelectedItem;
            string[] parts = SelectedSize.Split(' ');
            long num = long.Parse(parts[0]);
            long factor = 0;
            if (parts[1] == "Kb") factor = 1024;
            if (parts[1] == "MB") factor = 1024 * 1024;
            if (parts[1] == "GB") factor = 1024 * 1024 * 1024;
            long TotalBytes = num * factor;
            actualBytes.Text = TotalBytes.ToString();
            //throw new NotImplementedException();
        }

        private string GetRandomLine()
        {
            //return a rendom line < 80 chars
            // generate a random file
            var chars = "TheQuickBrownFoxJumpsOverTheLazyDogItWasTheBestOfTimesItWasTheWorstBradisGreatGeekWisdomNerdsRuleNowIsTheHourOfOurDiscontentAvengersHulkCaptainAmerciaCathyTessaChloeMarcusDavidSheSellseeShellsByTheSeaShoreABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.!?,;:";
            var stringChars = new char[10];
            
            string FinalLine="";
            bool done = false;
            while (!done)
            {
                var WordSize = random3.Next(1, 10);
                for (int i = 0; i < WordSize; i++)
                {
                    var thespot = random1.Next(chars.Length);
                    stringChars[i] = chars[thespot];
                    
                }
                var currentWord = new String(stringChars);
                currentWord = currentWord.Substring(0, WordSize);
                currentWord = currentWord.Trim();
                FinalLine = FinalLine + " " + currentWord;
                if (FinalLine.Length > 79) return FinalLine.Substring(1, 79);
            }
            return FinalLine;
        }


        private void createRandomFile(object sender,string FileName,long MaxSize)
        {
            PercentageComplete = 0;
            long FileSize = 0;
            bool Done = false;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(FileName))
            {
                while (!Done)
                {
                    
                    String current_line = GetRandomLine();
                    FileSize = FileSize + current_line.Length;
                    double PerComplete = ((double) FileSize / (double) MaxSize) * 100;
                    int intPerComplete = (int)PerComplete;
                    if (intPerComplete != PercentageComplete)
                    {
                        ((BackgroundWorker)sender).ReportProgress((int)PerComplete);
                        PercentageComplete = intPerComplete;
                    }
                    
                    

                    if (FileSize > MaxSize)
                    {
                        long LeftBytes = FileSize - MaxSize;
                        long strlen = 79;
                        if (LeftBytes < 80) strlen = LeftBytes;
                        current_line = current_line.Substring(0, (int) strlen);
                        Done = true;
                    }
                       file.WriteLine(current_line);
                    
                    

                        
                    }
                }
            }

        private void createMarkovFile(object sender,string FileName,long MaxSize)
        {
            PercentageComplete = -2;
            ((BackgroundWorker)sender).ReportProgress(1);
            MarkovDataFromPath MarkovSet = new MarkovDataFromPath(ChainDataRead.Text);
            // Create a new model
            var model = new StringMarkov(1);

            // Train the model
            PercentageComplete++;
            ((BackgroundWorker)sender).ReportProgress(1);
            model.Learn(MarkovSet.GetLines());

            PercentageComplete = 0;
            long FileSize = 0;
            bool Done = false;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(FileName))
            {
                while (!Done)
                {
                    String current_line = "";
                    while (current_line.Length < 80)
                    {
                        string result = System.Text.RegularExpressions.Regex.Replace(model.Walk().First().Trim(), @"\r\n?|\n", "");
                        current_line = current_line + " " + result; 
                    }
                   current_line = current_line.Substring(0, 80);
                    FileSize = FileSize + current_line.Length;
                    double PerComplete = ((double)FileSize / (double)MaxSize) * 100;
                    int intPerComplete = (int)PerComplete;
                    if (intPerComplete != PercentageComplete)
                    {
                        ((BackgroundWorker)sender).ReportProgress((int)PerComplete);
                        PercentageComplete = intPerComplete;
                    }



                    if (FileSize > MaxSize)
                    {
                        long LeftBytes = FileSize - MaxSize;
                        long strlen = 79;
                        if (LeftBytes < 80) strlen = LeftBytes;
                        current_line = current_line.Substring(0, (int)strlen);
                        Done = true;
                    }
                    file.WriteLine(current_line);
                }
            }

        }
        private void createFile(object sender,string FileName,long MaxSize)
        {
            string[] filePaths = null;

            
            try { 
                if (ChainDataRead.Text != "") filePaths = Directory.GetFiles(ChainDataRead.Text, "*.txt");
            
            if (filePaths == null || filePaths.Length < 0)
            {
                createRandomFile(sender, FileName,MaxSize);
            }
            else
            {
                createMarkovFile(sender, FileName, MaxSize);
            }
            }
            catch (Exception e)
            {
                createRandomFile(sender, FileName, MaxSize);
            }
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (PercentageComplete == -2)
            {
                statusTextLabel.Text = "Reading Data...";
            }
            if (PercentageComplete == -1)
            {
                statusTextLabel.Text = "Learning...";
            }
            else if (PercentageComplete >=0)
            { 
                //toolStripProgressBar.PerformStep();
                //toolStripProgressBar.Value = e.ProgressPercentage;
                statusTextLabel.Text =e.ProgressPercentage + "% Complete";
            toolStripProgressBar.PerformStep();
            }



        }
        public String ValidateForm()
        {
            //Make sure everyting is set correctly before running, return any errors
            //Or empty string if everything OKIE DOOKIE
            if (actualBytes.Text == "") return "You need to tell my monkeys how large to make your file (in bytes)";
            try
            {
                long bytes = long.Parse(actualBytes.Text);
                if (bytes < 0) return "SORRY! - The Monkeys don't no how to create negative information. Please enter a NUMBER betwen 0 and " + long.MaxValue;
            }
            catch (Exception e) { return "The Monkeys don't understand this size. Please enter a NUMBER betwen 0 and " + long.MaxValue; }
            if (saveLocation.Text == "") return "You need to tell my monkeys how where to save your file (Please include the PATH and Name";
            try
            {
                File.Create(saveLocation.Text).Dispose();
                //Let's try creatinga zero bite flie
            }
            catch (Exception e) { return "My Monkeys do not have the power to create files in: " + saveLocation.Text + ".\nPlease try a different Location."; }
            //if no chain data generate random flag instead random bytes
            return "";
        }


        private void GoButton_Click(object sender, EventArgs e)
        {
            try { 
            origImage = MonkeysShow.Image;


            string AnimiatedLoc = System.IO.Directory.GetCurrentDirectory() + @"\..\assets\monkey_animated.gif";
            if (!(File.Exists(AnimiatedLoc))) AnimiatedLoc = @"c:\temp\projects\gw\prog\OneThousandMonkeys\assets\monkey_animated.gif";
            if (!(File.Exists(AnimiatedLoc))) MessageBox.Show("Are they on strike? " + AnimiatedLoc,"WARNING: CANNOT FIND ANY MONKEYS !!!");
            else MonkeysShow.ImageLocation = AnimiatedLoc;
            statusTextLabel.Text = "Loading Monkeys...";
            string Working = ValidateForm();
            if (Working != "")
            {
                MessageBox.Show(Working, "ERRORS FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusTextLabel.Text = "ERRORS FOUND!!!";
                return;
            }
            GoButton.Enabled = false;
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Maximum = 100;
            toolStripProgressBar.Minimum = 0;
            toolStripProgressBar.Step = 1;
            var bgw = new BackgroundWorker();
            bgw.ProgressChanged += bgw_ProgressChanged;
            bgw.DoWork += bgw_DoWork;
            bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Sorry an Error has occured. The monkeys are about to escape!");
                Console.WriteLine(e1.Message);
                Environment.Exit(1);
            }


        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusTextLabel.Text = "READY.";
            toolStripProgressBar.Value = 0;
            GoButton.Enabled = true;
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            // do your long running operation here
            createFile(sender, saveLocation.Text, long.Parse(actualBytes.Text));
            MonkeysShow.Image = origImage;
            MessageBox.Show("Monkey Generation Complete. Have a nice day", "All Done!");
            
        }
        private void gwLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void SaveBrowseButton_Click(object sender, EventArgs e)
        {
            gwSaveDialog.Title = "Where should monkeys save their work?";
            gwSaveDialog.ShowDialog();
            saveLocation.Text = gwSaveDialog.FileName;
        }

        private void BrowseFolder_Click(object sender, EventArgs e)
        {
            if (gwFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                ChainDataRead.Text = gwFolderBrowser.SelectedPath;
            }
        }

        private void MonkeysShow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Infinite_monkey_theorem");
        }
    }
}
