using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FileExplorer {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                driveList.Items.Add(driveInfo);
            }

        }

        private void driveList_SelectedIndexChanged(object sender, EventArgs e)
        {          
            folders.Items.Clear();

            try
            {
                string getInfo = driveList.SelectedItem.ToString();
                DriveInfo driveInfo = new DriveInfo(getInfo);

                string driveName = driveInfo.Name.ToString();
                string freeSpace = (driveInfo.AvailableFreeSpace / 1073741824).ToString();
                string totalSize = (driveInfo.TotalSize / 1073741824).ToString();

                labelDriveName.Text = "Drive name " + driveName;
                labelFreeSpace.Text = "Free space: " + freeSpace + " GB";
                labelTotalSize.Text = "Total size: " + totalSize + " GB";

                DriveInfo drive = (DriveInfo)driveList.SelectedItem;

                foreach (DirectoryInfo dirInfo in drive.RootDirectory.GetDirectories())               
                   folders.Items.Add(dirInfo);  
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void folders_SelectedIndexChanged(object sender, EventArgs e)
        {
            files.Items.Clear();

            try
            {
                DirectoryInfo directoryInfo = (DirectoryInfo)folders.SelectedItem;

                folderName.Text = "Folder name: " + directoryInfo.Name;
                folderAttributes.Text = "Folder attributes: " + directoryInfo.Attributes.ToString();

                foreach (FileInfo fi in directoryInfo.GetFiles())

                    files.Items.Add(fi);


                numberOfFiles.Text = "Numbers of files: " + files.Items.Count.ToString();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void files_SelectedIndexChanged(object sender, EventArgs e)
        {

            FileInfo fileInfo = (FileInfo)files.SelectedItem;

            fileName.Text = "File name: " + fileInfo.Name;
            fileSize.Text = "File size: " + fileInfo.Length + " B";
            fileAttributes.Text = "File attributes: " + fileInfo.Attributes.ToString();


        }

        private void folders_DoubleClick(object sender, EventArgs e)
        {
            string drive = driveList.SelectedItem.ToString();
            string folder = folders.SelectedItem.ToString();
            string folderPath = drive + folder;

            Process.Start(@folderPath);
        }

        private void files_DoubleClick(object sender, EventArgs e)
        {
            string drive = driveList.SelectedItem.ToString();
            string folder = folders.SelectedItem.ToString();
            string file = files.SelectedItem.ToString();
            string filePath = drive + folder + @"\" + file;

             Process.Start(@filePath);
        }

        private void picturesButton_Click(object sender, EventArgs e)
        {
            try
            {
                files.Items.Clear();

                DirectoryInfo directoryInfo = (DirectoryInfo)folders.SelectedItem;
                foreach (FileInfo fi in directoryInfo.GetFiles())
                    if (fi.Extension == ".jpg" || fi.Extension == ".bmp" || fi.Extension == ".jpeg" || fi.Extension == ".png" || fi.Extension == ".gif")
                    {
                        files.Items.Add(fi);
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a folder");
            }
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            try { 
            files.Items.Clear();

            DirectoryInfo directoryInfo = (DirectoryInfo)folders.SelectedItem;
            foreach (FileInfo fi in directoryInfo.GetFiles())
                if (fi.Extension == ".mp3" || fi.Extension == ".wav" || fi.Extension == ".flac" || fi.Extension == ".ogg")
                {
                    files.Items.Add(fi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a folder");
            }
        }

        private void videosButton_Click(object sender, EventArgs e)
        {
            try
            {
            files.Items.Clear();

            DirectoryInfo directoryInfo = (DirectoryInfo)folders.SelectedItem;
            foreach (FileInfo fi in directoryInfo.GetFiles())
                if (fi.Extension == ".mp4" || fi.Extension == ".mkv" || fi.Extension == ".mov" || fi.Extension == ".avi" || fi.Extension == ".wmv" || fi.Extension == ".flv" || fi.Extension == ".3gp")
                {
                    files.Items.Add(fi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a folder");
            }
        }
    }
 }

   
