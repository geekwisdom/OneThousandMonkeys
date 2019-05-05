namespace OneThousandMonkeys
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.sizeLabelQuestion = new System.Windows.Forms.Label();
            this.quickPick = new System.Windows.Forms.ComboBox();
            this.actualBytes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveLocationEmail = new System.Windows.Forms.Label();
            this.gwSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.SaveBrowseButton = new System.Windows.Forms.Button();
            this.BrowseFolder = new System.Windows.Forms.Button();
            this.ChainDataRead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gwFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.MonkeysShow = new System.Windows.Forms.PictureBox();
            this.gwStatusStrip = new System.Windows.Forms.StatusStrip();
            this.GoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gwLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MonkeysShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Infinite Monkey Theorem";
            // 
            // sizeLabelQuestion
            // 
            this.sizeLabelQuestion.AutoSize = true;
            this.sizeLabelQuestion.Location = new System.Drawing.Point(25, 120);
            this.sizeLabelQuestion.Name = "sizeLabelQuestion";
            this.sizeLabelQuestion.Size = new System.Drawing.Size(238, 17);
            this.sizeLabelQuestion.TabIndex = 1;
            this.sizeLabelQuestion.Text = "How big a file do you wish to create?";
            // 
            // quickPick
            // 
            this.quickPick.FormattingEnabled = true;
            this.quickPick.Location = new System.Drawing.Point(322, 120);
            this.quickPick.Name = "quickPick";
            this.quickPick.Size = new System.Drawing.Size(121, 24);
            this.quickPick.TabIndex = 2;
            // 
            // actualBytes
            // 
            this.actualBytes.Location = new System.Drawing.Point(449, 120);
            this.actualBytes.Name = "actualBytes";
            this.actualBytes.Size = new System.Drawing.Size(137, 22);
            this.actualBytes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bytes";
            // 
            // SaveLocationEmail
            // 
            this.SaveLocationEmail.AutoSize = true;
            this.SaveLocationEmail.Location = new System.Drawing.Point(25, 161);
            this.SaveLocationEmail.Name = "SaveLocationEmail";
            this.SaveLocationEmail.Size = new System.Drawing.Size(234, 17);
            this.SaveLocationEmail.TabIndex = 5;
            this.SaveLocationEmail.Text = "Where do you want to save the file?";
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(322, 161);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(264, 22);
            this.saveLocation.TabIndex = 6;
            // 
            // SaveBrowseButton
            // 
            this.SaveBrowseButton.Location = new System.Drawing.Point(592, 160);
            this.SaveBrowseButton.Name = "SaveBrowseButton";
            this.SaveBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.SaveBrowseButton.TabIndex = 7;
            this.SaveBrowseButton.Text = "Browse...";
            this.SaveBrowseButton.UseVisualStyleBackColor = true;
            this.SaveBrowseButton.Click += new System.EventHandler(this.SaveBrowseButton_Click);
            // 
            // BrowseFolder
            // 
            this.BrowseFolder.Location = new System.Drawing.Point(590, 201);
            this.BrowseFolder.Name = "BrowseFolder";
            this.BrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.BrowseFolder.TabIndex = 10;
            this.BrowseFolder.Text = "Browse...";
            this.BrowseFolder.UseVisualStyleBackColor = true;
            this.BrowseFolder.Click += new System.EventHandler(this.BrowseFolder_Click);
            // 
            // ChainDataRead
            // 
            this.ChainDataRead.Location = new System.Drawing.Point(320, 202);
            this.ChainDataRead.Name = "ChainDataRead";
            this.ChainDataRead.Size = new System.Drawing.Size(264, 22);
            this.ChainDataRead.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Location of Markov Source Data";
            // 
            // MonkeysShow
            // 
            this.MonkeysShow.Image = ((System.Drawing.Image)(resources.GetObject("MonkeysShow.Image")));
            this.MonkeysShow.Location = new System.Drawing.Point(26, 239);
            this.MonkeysShow.Name = "MonkeysShow";
            this.MonkeysShow.Size = new System.Drawing.Size(196, 177);
            this.MonkeysShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonkeysShow.TabIndex = 11;
            this.MonkeysShow.TabStop = false;
            this.MonkeysShow.Click += new System.EventHandler(this.MonkeysShow_Click);
            // 
            // gwStatusStrip
            // 
            this.gwStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gwStatusStrip.Location = new System.Drawing.Point(0, 431);
            this.gwStatusStrip.Name = "gwStatusStrip";
            this.gwStatusStrip.Size = new System.Drawing.Size(688, 22);
            this.gwStatusStrip.TabIndex = 12;
            this.gwStatusStrip.Text = "statusStrip1";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(402, 288);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 69);
            this.GoButton.TabIndex = 13;
            this.GoButton.Text = "LETS\' GO !";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Leave blank to simply generate random bytes";
            // 
            // gwLink
            // 
            this.gwLink.AutoSize = true;
            this.gwLink.Location = new System.Drawing.Point(551, 406);
            this.gwLink.Name = "gwLink";
            this.gwLink.Size = new System.Drawing.Size(125, 17);
            this.gwLink.TabIndex = 15;
            this.gwLink.TabStop = true;
            this.gwLink.Text = "#GeekWisdom.org";
            this.gwLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gwLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ver: 0.000001 ALPHA";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gwLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.gwStatusStrip);
            this.Controls.Add(this.MonkeysShow);
            this.Controls.Add(this.BrowseFolder);
            this.Controls.Add(this.ChainDataRead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveBrowseButton);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this.SaveLocationEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actualBytes);
            this.Controls.Add(this.quickPick);
            this.Controls.Add(this.sizeLabelQuestion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "One Thousand Monkeys";
            ((System.ComponentModel.ISupportInitialize)(this.MonkeysShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sizeLabelQuestion;
        private System.Windows.Forms.ComboBox quickPick;
        private System.Windows.Forms.TextBox actualBytes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SaveLocationEmail;
        private System.Windows.Forms.SaveFileDialog gwSaveDialog;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Button SaveBrowseButton;
        private System.Windows.Forms.Button BrowseFolder;
        private System.Windows.Forms.TextBox ChainDataRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog gwFolderBrowser;
        private System.Windows.Forms.PictureBox MonkeysShow;
        private System.Windows.Forms.StatusStrip gwStatusStrip;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel gwLink;
        private System.Windows.Forms.Label label5;
    }
}

