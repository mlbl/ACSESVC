namespace Armory_Crate_SE_Startup_Video_Changer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            selectVideoBtn = new Button();
            videoSelectDialog = new OpenFileDialog();
            button2 = new Button();
            startupVideoFolder = new FolderBrowserDialog();
            selectDestinationFolderBtn = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog2 = new FolderBrowserDialog();
            destinationFolder = new FolderBrowserDialog();
            sourceLbl = new Label();
            copyBtn = new Button();
            destinationLbl = new Label();
            SuspendLayout();
            // 
            // selectVideoBtn
            // 
            selectVideoBtn.Image = Properties.Resources.video_folder_24x24;
            selectVideoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            selectVideoBtn.Location = new Point(24, 29);
            selectVideoBtn.Name = "selectVideoBtn";
            selectVideoBtn.Padding = new Padding(8, 0, 0, 0);
            selectVideoBtn.Size = new Size(160, 43);
            selectVideoBtn.TabIndex = 0;
            selectVideoBtn.Text = "   Select Video File";
            selectVideoBtn.UseVisualStyleBackColor = true;
            selectVideoBtn.Click += selectVideo_Click;
            // 
            // videoSelectDialog
            // 
            videoSelectDialog.DefaultExt = "mp4";
            videoSelectDialog.Filter = "MP4 Files|*.mp4";
            videoSelectDialog.InitialDirectory = "C:\\Users\\mlbl\\AppData\\Local\\Packages\\B9ECED6F.ArmouryCrateSE_qmba6cd70vzyy\\LocalState\\UserContent\\FC3045F0-0E85-404D-BD09-818D94661FB9\\ally_launch";
            videoSelectDialog.FileOk += openFileDialog1_FileOk;
            // 
            // button2
            // 
            button2.Location = new Point(108, 107);
            button2.Name = "button2";
            button2.Size = new Size(178, 23);
            button2.TabIndex = 2;
            button2.Text = "Select Startup Video Folder";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // startupVideoFolder
            // 
            startupVideoFolder.InitialDirectory = "c:\\startup";
            startupVideoFolder.HelpRequest += startupVideoFolder_HelpRequest;
            // 
            // selectDestinationFolderBtn
            // 
            selectDestinationFolderBtn.Image = Properties.Resources.normal_folder_24x24;
            selectDestinationFolderBtn.ImageAlign = ContentAlignment.MiddleLeft;
            selectDestinationFolderBtn.Location = new Point(239, 29);
            selectDestinationFolderBtn.Name = "selectDestinationFolderBtn";
            selectDestinationFolderBtn.Padding = new Padding(8, 0, 0, 0);
            selectDestinationFolderBtn.Size = new Size(160, 43);
            selectDestinationFolderBtn.TabIndex = 3;
            selectDestinationFolderBtn.Text = "      Select Destination   Folder";
            selectDestinationFolderBtn.UseVisualStyleBackColor = true;
            selectDestinationFolderBtn.Click += selectDestinationFolder_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.InitialDirectory = "c:\\startup";
            // 
            // folderBrowserDialog2
            // 
            folderBrowserDialog2.InitialDirectory = "c:\\startup";
            // 
            // destinationFolder
            // 
            destinationFolder.HelpRequest += destinationFolder_HelpRequest;
            // 
            // sourceLbl
            // 
            sourceLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sourceLbl.ForeColor = Color.White;
            sourceLbl.Location = new Point(24, 85);
            sourceLbl.MaximumSize = new Size(375, 20);
            sourceLbl.Name = "sourceLbl";
            sourceLbl.Size = new Size(375, 20);
            sourceLbl.TabIndex = 4;
            sourceLbl.Text = "Source: Select a file";
            // 
            // copyBtn
            // 
            copyBtn.Enabled = false;
            copyBtn.Image = Properties.Resources.files_24x24;
            copyBtn.ImageAlign = ContentAlignment.MiddleLeft;
            copyBtn.Location = new Point(142, 160);
            copyBtn.Name = "copyBtn";
            copyBtn.Padding = new Padding(8, 0, 0, 0);
            copyBtn.Size = new Size(123, 43);
            copyBtn.TabIndex = 5;
            copyBtn.Text = "   &Copy File";
            copyBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            copyBtn.UseVisualStyleBackColor = true;
            copyBtn.Click += copyBtn_Click;
            // 
            // destinationLbl
            // 
            destinationLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            destinationLbl.ForeColor = Color.White;
            destinationLbl.Location = new Point(24, 111);
            destinationLbl.MaximumSize = new Size(375, 20);
            destinationLbl.Name = "destinationLbl";
            destinationLbl.Size = new Size(375, 20);
            destinationLbl.TabIndex = 6;
            destinationLbl.Text = "Destination: Select a folder";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(424, 228);
            Controls.Add(destinationLbl);
            Controls.Add(copyBtn);
            Controls.Add(sourceLbl);
            Controls.Add(selectDestinationFolderBtn);
            Controls.Add(selectVideoBtn);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Armoury Crate SE Startup Video Changer";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button selectVideoBtn;
        private OpenFileDialog videoSelectDialog;
        private Button button2;
        private FolderBrowserDialog startupVideoFolder;
        private Button selectDestinationFolderBtn;
        private FolderBrowserDialog folderBrowserDialog1;
        private FolderBrowserDialog folderBrowserDialog2;
        private FolderBrowserDialog destinationFolder;
        private Label sourceLbl;
        private Button copyBtn;
        private Label destinationLbl;
    }
}
