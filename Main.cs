using System.Configuration;
using System.Diagnostics;

namespace Armory_Crate_SE_Startup_Video_Changer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //InitializeUI("UIMode");
        }

        private void selectVideo_Click(object sender, EventArgs e)
        {
            // C:\Users\mlbl\AppData\Local\Packages\B9ECED6F.ArmouryCrateSE_qmba6cd70vzyy\LocalState\UserContent\FC3045F0-0E85-404D-BD09-818D94661FB9\ally_launch
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = videoSelectDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                sourceLbl.Text = "Source: " + videoSelectDialog.FileName;
                // Initialize the tooltip
                ToolTip toolTip = new ToolTip
                {
                    AutoPopDelay = 5000,
                    InitialDelay = 500,
                    ReshowDelay = 500,
                    ShowAlways = true
                };

                // Set the tooltip text for the label
                toolTip.SetToolTip(sourceLbl, sourceLbl.Text);
                sourceLbl.Paint += (sender, e) => DrawTextWithEllipsis(sourceLbl, e);
            }
        }
        private void DrawTextWithEllipsis(Label label, PaintEventArgs e)
        {
            // Define text format with ellipsis
            TextFormatFlags flags = TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine;

            // Draw the text with ellipsis
            TextRenderer.DrawText(e.Graphics, label.Text, label.Font, label.ClientRectangle, label.ForeColor, flags);
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MessageBox.Show(videoSelectDialog.FileName);
            //MessageBox.Show(getFileName(videoSelectDialog.FileName));
        }

        private String getFileName(String fullName)
        {
            FileInfo fi = new FileInfo(fullName);
            return fi.Name;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: select startup video folder
            startupVideoFolder.ShowDialog(this);
            MessageBox.Show(startupVideoFolder.SelectedPath.ToString());
        }

        private void selectDestinationFolder_Click(object sender, EventArgs e)
        {
            // destination folder select button
            DialogResult result = destinationFolder.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                copyBtn.Enabled = true;
                destinationLbl.Text = "Destination: " + destinationFolder.SelectedPath;
                // Initialize the tooltip
                ToolTip toolTip = new ToolTip
                {
                    AutoPopDelay = 5000,
                    InitialDelay = 500,
                    ReshowDelay = 500,
                    ShowAlways = true
                };

                // Set the tooltip text for the label
                toolTip.SetToolTip(destinationLbl, destinationLbl.Text);
                destinationLbl.Paint += (sender, e) => DrawTextWithEllipsis(destinationLbl, e);
            }
        }

        private void removeReadOnly(String fileName)
        {
            if (File.Exists(fileName))
            {
                // Get the file attributes for the destination file
                FileAttributes attributes = File.GetAttributes(fileName);

                // Check if the file is read-only
                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    // Remove the read-only attribute
                    File.SetAttributes(fileName, attributes & ~FileAttributes.ReadOnly);
                }
            }
        }
        private void destinationFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        private void startupVideoFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(videoSelectDialog.FileName);
            //MessageBox.Show(fi.Name);

            //removeReadOnly(destinationFolder.SelectedPath + "\\" + fi.Name);
            //fi.CopyTo(destinationFolder.SelectedPath + "\\" + fi.Name, true);
            //File.SetAttributes(destinationFolder.SelectedPath + "\\" + fi.Name, FileAttributes.ReadOnly);
            //
            DirectoryInfo folder = new DirectoryInfo(destinationFolder.SelectedPath);
            //            MessageBox.Show(folder.FullName + folder.Exists);
            if (folder.Exists) // else: Invalid folder!
            {
                FileInfo[] files = folder.GetFiles("*_backup.mp4");

                foreach (FileInfo file in files)
                {
                    //if (file.FullName.ToString().)
                    String backupFolder = destinationFolder.SelectedPath + "\\original";
                    if (!Directory.Exists(backupFolder))
                    {
                        Directory.CreateDirectory(backupFolder);
                    }
                    //                    MessageBox.Show(file.FullName);
                    // backup
                    if (!File.Exists(backupFolder + "\\" + file.Name))
                    {
                        //removeReadOnly(backupFolder + "\\" + file.Name);
                        File.Copy(file.FullName, backupFolder + "\\" + file.Name, true);
                    }
                    string fileName = Path.GetFileName(videoSelectDialog.FileName);
                    // real copy
                    // TODO: Fix backup of a backup - keep original safe, dont overwrite the 1st real backup
                    removeReadOnly(destinationFolder.SelectedPath + "\\" + file.Name);
                    File.Copy(videoSelectDialog.FileName, destinationFolder.SelectedPath + "\\" + file.Name, true);
                    File.SetAttributes(destinationFolder.SelectedPath + "\\" + file.Name, FileAttributes.ReadOnly);
                }
                MessageBox.Show("File copy process completed! Have Fun!","Copy process completed");
                //MessageBox.Show("Copied " + getFileName(videoSelectDialog.FileName) + " TO " + destinationFolder.SelectedPath);
            }
        }

        private String findDirectoryName(String baseDirectory)
        {
            try
            {
                // Get all directories in the base directory
                string[] allDirectories = Directory.GetDirectories(baseDirectory);

            // Filter directories based on the wildcard pattern
            var matchedDirectories = allDirectories
                .Where(dir =>
                {
                    string folderName = Path.GetFileName(dir);
                    return folderName.Contains("ArmouryCrateSE");
                });

                // Output the matched directories
                foreach (string dir in matchedDirectories)
                {
                    //Debug.WriteLine("Matched Folder: " + dir);
                    return dir;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return "";
        }
        private void Main_Load(object sender, EventArgs e)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Get the parent directory of the AppData path
            DirectoryInfo? parentDirectory = Directory.GetParent(appDataPath);

            // Check if the parent directory exists
            if (parentDirectory != null)
            {
                // Get the full name of the parent directory
                String appDataParentPath = parentDirectory.FullName;
                String ACSEPath = appDataParentPath + @"\local\packages";
                // C:\Users\mlbl\AppData\Local\Packages\B9ECED6F.ArmouryCrateSE_qmba6cd70vzyy\LocalState\UserContent\FC3045F0-0E85-404D-BD09-818D94661FB9\ally_launch
                destinationFolder.InitialDirectory = findDirectoryName(ACSEPath) + @"\LocalState\UserContent\";

                string? foundDirectory = FindDirectory(destinationFolder.InitialDirectory, "ally_launch");

                //if (foundDirectory != null)
                //{
                //    Debug.WriteLine("Found Directory: " + foundDirectory);
                //}
                //MessageBox.Show(foundDirectory);
                destinationFolder.InitialDirectory = foundDirectory;
            }
        }
        static string? FindDirectory(string currentDirectory, string directoryNameToFind)
        {
            try
            {
                // Get all directories in the current directory
                string[] directories = Directory.GetDirectories(currentDirectory);

                foreach (string dir in directories)
                {
                    string dirName = Path.GetFileName(dir);

                    // Check if the directory name matches
                    if (dirName.Equals(directoryNameToFind, StringComparison.OrdinalIgnoreCase))
                    {
                        return dir; // Return the full path of the found directory
                    }

                    // Recursively search in subdirectories
                    string? result = FindDirectory(dir, directoryNameToFind);
                    if (result != null)
                    {
                        return result; // Return the found directory from subdirectories
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return null; // Return null if no matching directory is found
        }
        /*
        private void InitializeUI(string key)
        {
            try
            {
                //var uiMode = ConfigurationManager.AppSettings[key]
            }
            catch (Exception ex) {
            {

            }
        }
        */

    }
}
