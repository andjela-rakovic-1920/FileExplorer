namespace FileExplorer {
    partial class Form1 {
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
            this.driveList = new System.Windows.Forms.ListBox();
            this.labelDriveName = new System.Windows.Forms.Label();
            this.labelFreeSpace = new System.Windows.Forms.Label();
            this.labelTotalSize = new System.Windows.Forms.Label();
            this.folders = new System.Windows.Forms.ListBox();
            this.files = new System.Windows.Forms.ListBox();
            this.folderName = new System.Windows.Forms.Label();
            this.numberOfFiles = new System.Windows.Forms.Label();
            this.folderAttributes = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.fileSize = new System.Windows.Forms.Label();
            this.fileAttributes = new System.Windows.Forms.Label();
            this.picturesButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.videosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driveList
            // 
            this.driveList.FormattingEnabled = true;
            this.driveList.Location = new System.Drawing.Point(23, 43);
            this.driveList.Name = "driveList";
            this.driveList.Size = new System.Drawing.Size(121, 173);
            this.driveList.TabIndex = 4;
            this.driveList.SelectedIndexChanged += new System.EventHandler(this.driveList_SelectedIndexChanged);
            // 
            // labelDriveName
            // 
            this.labelDriveName.AutoSize = true;
            this.labelDriveName.Location = new System.Drawing.Point(20, 219);
            this.labelDriveName.Name = "labelDriveName";
            this.labelDriveName.Size = new System.Drawing.Size(61, 13);
            this.labelDriveName.TabIndex = 6;
            this.labelDriveName.Text = "Drive name";
            // 
            // labelFreeSpace
            // 
            this.labelFreeSpace.AutoSize = true;
            this.labelFreeSpace.Location = new System.Drawing.Point(20, 244);
            this.labelFreeSpace.Name = "labelFreeSpace";
            this.labelFreeSpace.Size = new System.Drawing.Size(60, 13);
            this.labelFreeSpace.TabIndex = 7;
            this.labelFreeSpace.Text = "Free space";
            // 
            // labelTotalSize
            // 
            this.labelTotalSize.AutoSize = true;
            this.labelTotalSize.Location = new System.Drawing.Point(20, 268);
            this.labelTotalSize.Name = "labelTotalSize";
            this.labelTotalSize.Size = new System.Drawing.Size(52, 13);
            this.labelTotalSize.TabIndex = 8;
            this.labelTotalSize.Text = "Total size";
            // 
            // folders
            // 
            this.folders.FormattingEnabled = true;
            this.folders.Location = new System.Drawing.Point(150, 43);
            this.folders.Name = "folders";
            this.folders.Size = new System.Drawing.Size(265, 173);
            this.folders.TabIndex = 10;
            this.folders.SelectedIndexChanged += new System.EventHandler(this.folders_SelectedIndexChanged);
            this.folders.DoubleClick += new System.EventHandler(this.folders_DoubleClick);
            // 
            // files
            // 
            this.files.FormattingEnabled = true;
            this.files.Location = new System.Drawing.Point(424, 43);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(265, 173);
            this.files.TabIndex = 11;
            this.files.SelectedIndexChanged += new System.EventHandler(this.files_SelectedIndexChanged);
            this.files.DoubleClick += new System.EventHandler(this.files_DoubleClick);
            // 
            // folderName
            // 
            this.folderName.AutoSize = true;
            this.folderName.Location = new System.Drawing.Point(150, 219);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(65, 13);
            this.folderName.TabIndex = 12;
            this.folderName.Text = "Folder name";
            // 
            // numberOfFiles
            // 
            this.numberOfFiles.AutoSize = true;
            this.numberOfFiles.Location = new System.Drawing.Point(150, 244);
            this.numberOfFiles.Name = "numberOfFiles";
            this.numberOfFiles.Size = new System.Drawing.Size(77, 13);
            this.numberOfFiles.TabIndex = 13;
            this.numberOfFiles.Text = "Number of files";
            // 
            // folderAttributes
            // 
            this.folderAttributes.AutoSize = true;
            this.folderAttributes.Location = new System.Drawing.Point(150, 268);
            this.folderAttributes.Name = "folderAttributes";
            this.folderAttributes.Size = new System.Drawing.Size(82, 13);
            this.folderAttributes.TabIndex = 14;
            this.folderAttributes.Text = "Folder attributes";
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(421, 219);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(52, 13);
            this.fileName.TabIndex = 15;
            this.fileName.Text = "File name";
            // 
            // fileSize
            // 
            this.fileSize.AutoSize = true;
            this.fileSize.Location = new System.Drawing.Point(421, 244);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(44, 13);
            this.fileSize.TabIndex = 16;
            this.fileSize.Text = "File size";
            // 
            // fileAttributes
            // 
            this.fileAttributes.AutoSize = true;
            this.fileAttributes.Location = new System.Drawing.Point(421, 268);
            this.fileAttributes.Name = "fileAttributes";
            this.fileAttributes.Size = new System.Drawing.Size(69, 13);
            this.fileAttributes.TabIndex = 17;
            this.fileAttributes.Text = "File attributes";
            // 
            // picturesButton
            // 
            this.picturesButton.Location = new System.Drawing.Point(424, 14);
            this.picturesButton.Name = "picturesButton";
            this.picturesButton.Size = new System.Drawing.Size(75, 23);
            this.picturesButton.TabIndex = 18;
            this.picturesButton.Text = "Pictures";
            this.picturesButton.UseVisualStyleBackColor = true;
            this.picturesButton.Click += new System.EventHandler(this.picturesButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.Location = new System.Drawing.Point(520, 14);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(75, 23);
            this.musicButton.TabIndex = 19;
            this.musicButton.Text = "Music";
            this.musicButton.UseVisualStyleBackColor = true;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // videosButton
            // 
            this.videosButton.Location = new System.Drawing.Point(614, 14);
            this.videosButton.Name = "videosButton";
            this.videosButton.Size = new System.Drawing.Size(75, 23);
            this.videosButton.TabIndex = 20;
            this.videosButton.Text = "Videos";
            this.videosButton.UseVisualStyleBackColor = true;
            this.videosButton.Click += new System.EventHandler(this.videosButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 321);
            this.Controls.Add(this.videosButton);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.picturesButton);
            this.Controls.Add(this.fileAttributes);
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.folderAttributes);
            this.Controls.Add(this.numberOfFiles);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.files);
            this.Controls.Add(this.folders);
            this.Controls.Add(this.labelTotalSize);
            this.Controls.Add(this.labelFreeSpace);
            this.Controls.Add(this.labelDriveName);
            this.Controls.Add(this.driveList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox driveList;
        private System.Windows.Forms.Label labelDriveName;
        private System.Windows.Forms.Label labelFreeSpace;
        private System.Windows.Forms.Label labelTotalSize;
        private System.Windows.Forms.ListBox folders;
        private System.Windows.Forms.ListBox files;
        private System.Windows.Forms.Label folderName;
        private System.Windows.Forms.Label numberOfFiles;
        private System.Windows.Forms.Label folderAttributes;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label fileSize;
        private System.Windows.Forms.Label fileAttributes;
        private System.Windows.Forms.Button picturesButton;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.Button videosButton;
    }
}

