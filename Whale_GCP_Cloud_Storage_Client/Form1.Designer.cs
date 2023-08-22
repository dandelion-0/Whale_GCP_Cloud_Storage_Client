namespace Whale_GCP_Cloud_Storage_Client
{
    partial class Form1
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
            btnDownloadObject = new Button();
            btnUploadObject = new Button();
            btnDeleteObject = new Button();
            btnCreateBucket = new Button();
            btnDeleteBucket = new Button();
            btnDownloadAllObject = new Button();
            btnUploadObjectNav = new Button();
            btnDownloadPathNav = new Button();
            txtUploadObjectBucketName = new TextBox();
            txtDownloadObjectName = new TextBox();
            txtDownloadBucketName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtDeleteObjectBucketname = new TextBox();
            txtDeleteObjectobjectname = new TextBox();
            txtDwnAllObjectBucketName = new TextBox();
            txtCreateBucketBucketName = new TextBox();
            txtCreateBucketProjectId = new TextBox();
            txtDeleteBucketBucketName = new TextBox();
            listBoxListBucketContents = new ListBox();
            label7 = new Label();
            txtListBucketContentsBucketName = new TextBox();
            btnListBucketContents = new Button();
            folderBrowserDialog2 = new FolderBrowserDialog();
            btnUploadObjFolderNav = new Button();
            folderBrowserDialog3 = new FolderBrowserDialog();
            btnDownloadAllObjFolderNav = new Button();
            btnPubSub = new Button();
            SuspendLayout();
            // 
            // btnDownloadObject
            // 
            btnDownloadObject.Location = new Point(728, 73);
            btnDownloadObject.Name = "btnDownloadObject";
            btnDownloadObject.Size = new Size(113, 23);
            btnDownloadObject.TabIndex = 0;
            btnDownloadObject.Text = "Process";
            btnDownloadObject.UseVisualStyleBackColor = true;
            btnDownloadObject.Click += btnDownload_Click;
            // 
            // btnUploadObject
            // 
            btnUploadObject.Location = new Point(728, 30);
            btnUploadObject.Name = "btnUploadObject";
            btnUploadObject.Size = new Size(113, 23);
            btnUploadObject.TabIndex = 1;
            btnUploadObject.Text = "Process";
            btnUploadObject.UseVisualStyleBackColor = true;
            btnUploadObject.Click += btnUploadObject_Click;
            // 
            // btnDeleteObject
            // 
            btnDeleteObject.Location = new Point(728, 119);
            btnDeleteObject.Name = "btnDeleteObject";
            btnDeleteObject.Size = new Size(113, 23);
            btnDeleteObject.TabIndex = 2;
            btnDeleteObject.Text = "Process";
            btnDeleteObject.UseVisualStyleBackColor = true;
            btnDeleteObject.Click += btnDeleteObject_Click;
            // 
            // btnCreateBucket
            // 
            btnCreateBucket.Location = new Point(728, 211);
            btnCreateBucket.Name = "btnCreateBucket";
            btnCreateBucket.Size = new Size(113, 23);
            btnCreateBucket.TabIndex = 3;
            btnCreateBucket.Text = "Process";
            btnCreateBucket.UseVisualStyleBackColor = true;
            btnCreateBucket.Click += btnCreateBucket_Click;
            // 
            // btnDeleteBucket
            // 
            btnDeleteBucket.Location = new Point(728, 260);
            btnDeleteBucket.Name = "btnDeleteBucket";
            btnDeleteBucket.Size = new Size(113, 23);
            btnDeleteBucket.TabIndex = 4;
            btnDeleteBucket.Text = "Process";
            btnDeleteBucket.UseVisualStyleBackColor = true;
            btnDeleteBucket.Click += btnDeleteBucket_Click;
            // 
            // btnDownloadAllObject
            // 
            btnDownloadAllObject.Location = new Point(728, 167);
            btnDownloadAllObject.Name = "btnDownloadAllObject";
            btnDownloadAllObject.Size = new Size(113, 23);
            btnDownloadAllObject.TabIndex = 5;
            btnDownloadAllObject.Text = "Process";
            btnDownloadAllObject.UseVisualStyleBackColor = true;
            btnDownloadAllObject.Click += btnDownloadAllObject_Click;
            // 
            // btnUploadObjectNav
            // 
            btnUploadObjectNav.Location = new Point(456, 29);
            btnUploadObjectNav.Name = "btnUploadObjectNav";
            btnUploadObjectNav.Size = new Size(120, 23);
            btnUploadObjectNav.TabIndex = 6;
            btnUploadObjectNav.Text = "Upload Single File ";
            btnUploadObjectNav.UseVisualStyleBackColor = true;
            btnUploadObjectNav.Click += btnUploadNavigation_Click;
            // 
            // btnDownloadPathNav
            // 
            btnDownloadPathNav.Location = new Point(456, 74);
            btnDownloadPathNav.Name = "btnDownloadPathNav";
            btnDownloadPathNav.Size = new Size(98, 23);
            btnDownloadPathNav.TabIndex = 7;
            btnDownloadPathNav.Text = "DownloadPath";
            btnDownloadPathNav.UseVisualStyleBackColor = true;
            btnDownloadPathNav.Click += btnDownloadPathNav_Click;
            // 
            // txtUploadObjectBucketName
            // 
            txtUploadObjectBucketName.Location = new Point(138, 30);
            txtUploadObjectBucketName.Name = "txtUploadObjectBucketName";
            txtUploadObjectBucketName.Size = new Size(298, 23);
            txtUploadObjectBucketName.TabIndex = 8;
            txtUploadObjectBucketName.Text = "bucketname";
            txtUploadObjectBucketName.TextChanged += txtUploadBucketName_TextChanged;
            // 
            // txtDownloadObjectName
            // 
            txtDownloadObjectName.Location = new Point(284, 74);
            txtDownloadObjectName.Name = "txtDownloadObjectName";
            txtDownloadObjectName.Size = new Size(152, 23);
            txtDownloadObjectName.TabIndex = 9;
            txtDownloadObjectName.Text = "objectname";
            // 
            // txtDownloadBucketName
            // 
            txtDownloadBucketName.Location = new Point(138, 74);
            txtDownloadBucketName.Name = "txtDownloadBucketName";
            txtDownloadBucketName.Size = new Size(140, 23);
            txtDownloadBucketName.TabIndex = 10;
            txtDownloadBucketName.Text = "bucketname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 11;
            label1.Text = "UploadObject :-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 13;
            label2.Text = "DownloadObject :-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 15;
            label3.Text = "DeleteObject :-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 17;
            label4.Text = "DownloadAllObject :-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 19;
            label5.Text = "CreateBucket :-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(13, 269);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 21;
            label6.Text = "DeleteBucket :-";
            // 
            // txtDeleteObjectBucketname
            // 
            txtDeleteObjectBucketname.Location = new Point(138, 119);
            txtDeleteObjectBucketname.Name = "txtDeleteObjectBucketname";
            txtDeleteObjectBucketname.Size = new Size(140, 23);
            txtDeleteObjectBucketname.TabIndex = 22;
            txtDeleteObjectBucketname.Text = "bucketname";
            txtDeleteObjectBucketname.TextChanged += txtDeleteObjectBucketname_TextChanged;
            // 
            // txtDeleteObjectobjectname
            // 
            txtDeleteObjectobjectname.Location = new Point(284, 119);
            txtDeleteObjectobjectname.Name = "txtDeleteObjectobjectname";
            txtDeleteObjectobjectname.Size = new Size(152, 23);
            txtDeleteObjectobjectname.TabIndex = 23;
            txtDeleteObjectobjectname.Text = "objectname";
            // 
            // txtDwnAllObjectBucketName
            // 
            txtDwnAllObjectBucketName.Location = new Point(138, 168);
            txtDwnAllObjectBucketName.Name = "txtDwnAllObjectBucketName";
            txtDwnAllObjectBucketName.Size = new Size(298, 23);
            txtDwnAllObjectBucketName.TabIndex = 24;
            txtDwnAllObjectBucketName.Text = "bucketname";
            txtDwnAllObjectBucketName.TextChanged += txtDwnAllObjectBucketName_TextChanged;
            // 
            // txtCreateBucketBucketName
            // 
            txtCreateBucketBucketName.Location = new Point(138, 212);
            txtCreateBucketBucketName.Name = "txtCreateBucketBucketName";
            txtCreateBucketBucketName.Size = new Size(140, 23);
            txtCreateBucketBucketName.TabIndex = 25;
            txtCreateBucketBucketName.Text = "bucketname";
            // 
            // txtCreateBucketProjectId
            // 
            txtCreateBucketProjectId.Location = new Point(284, 212);
            txtCreateBucketProjectId.Name = "txtCreateBucketProjectId";
            txtCreateBucketProjectId.Size = new Size(152, 23);
            txtCreateBucketProjectId.TabIndex = 26;
            txtCreateBucketProjectId.Text = "ProjectId";
            // 
            // txtDeleteBucketBucketName
            // 
            txtDeleteBucketBucketName.Location = new Point(138, 261);
            txtDeleteBucketBucketName.Name = "txtDeleteBucketBucketName";
            txtDeleteBucketBucketName.Size = new Size(298, 23);
            txtDeleteBucketBucketName.TabIndex = 27;
            txtDeleteBucketBucketName.Text = "bucketname";
            // 
            // listBoxListBucketContents
            // 
            listBoxListBucketContents.FormattingEnabled = true;
            listBoxListBucketContents.ItemHeight = 15;
            listBoxListBucketContents.Location = new Point(138, 334);
            listBoxListBucketContents.Name = "listBoxListBucketContents";
            listBoxListBucketContents.ScrollAlwaysVisible = true;
            listBoxListBucketContents.Size = new Size(444, 214);
            listBoxListBucketContents.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(13, 319);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 29;
            label7.Text = "ListBucketContents :-";
            // 
            // txtListBucketContentsBucketName
            // 
            txtListBucketContentsBucketName.Location = new Point(138, 311);
            txtListBucketContentsBucketName.Name = "txtListBucketContentsBucketName";
            txtListBucketContentsBucketName.Size = new Size(298, 23);
            txtListBucketContentsBucketName.TabIndex = 30;
            txtListBucketContentsBucketName.Text = "bucketname";
            // 
            // btnListBucketContents
            // 
            btnListBucketContents.Location = new Point(728, 310);
            btnListBucketContents.Name = "btnListBucketContents";
            btnListBucketContents.Size = new Size(113, 23);
            btnListBucketContents.TabIndex = 31;
            btnListBucketContents.Text = "Process";
            btnListBucketContents.UseVisualStyleBackColor = true;
            btnListBucketContents.Click += btnListBucketContents_Click;
            // 
            // btnUploadObjFolderNav
            // 
            btnUploadObjFolderNav.Location = new Point(582, 30);
            btnUploadObjFolderNav.Name = "btnUploadObjFolderNav";
            btnUploadObjFolderNav.Size = new Size(119, 23);
            btnUploadObjFolderNav.TabIndex = 32;
            btnUploadObjFolderNav.Text = "Upload Folder ";
            btnUploadObjFolderNav.UseVisualStyleBackColor = true;
            btnUploadObjFolderNav.Click += btnUploadObjFolderNav_Click;
            // 
            // btnDownloadAllObjFolderNav
            // 
            btnDownloadAllObjFolderNav.Location = new Point(456, 168);
            btnDownloadAllObjFolderNav.Name = "btnDownloadAllObjFolderNav";
            btnDownloadAllObjFolderNav.Size = new Size(98, 23);
            btnDownloadAllObjFolderNav.TabIndex = 33;
            btnDownloadAllObjFolderNav.Text = "DownloadPath";
            btnDownloadAllObjFolderNav.UseVisualStyleBackColor = true;
            btnDownloadAllObjFolderNav.Click += btnDownloadAllObjFolderNav_Click;
            // 
            // btnPubSub
            // 
            btnPubSub.Location = new Point(890, 30);
            btnPubSub.Name = "btnPubSub";
            btnPubSub.Size = new Size(164, 32);
            btnPubSub.TabIndex = 34;
            btnPubSub.Text = "Bucket_Notification";
            btnPubSub.UseVisualStyleBackColor = true;
            btnPubSub.Click += btnPubSub_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1156, 643);
            Controls.Add(btnPubSub);
            Controls.Add(btnDownloadAllObjFolderNav);
            Controls.Add(btnUploadObjFolderNav);
            Controls.Add(btnListBucketContents);
            Controls.Add(txtListBucketContentsBucketName);
            Controls.Add(label7);
            Controls.Add(listBoxListBucketContents);
            Controls.Add(txtDeleteBucketBucketName);
            Controls.Add(txtCreateBucketProjectId);
            Controls.Add(txtCreateBucketBucketName);
            Controls.Add(txtDwnAllObjectBucketName);
            Controls.Add(txtDeleteObjectobjectname);
            Controls.Add(txtDeleteObjectBucketname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDownloadBucketName);
            Controls.Add(txtDownloadObjectName);
            Controls.Add(txtUploadObjectBucketName);
            Controls.Add(btnDownloadPathNav);
            Controls.Add(btnUploadObjectNav);
            Controls.Add(btnDownloadAllObject);
            Controls.Add(btnDeleteBucket);
            Controls.Add(btnCreateBucket);
            Controls.Add(btnDeleteObject);
            Controls.Add(btnUploadObject);
            Controls.Add(btnDownloadObject);
            ForeColor = SystemColors.MenuHighlight;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cloud_Storage_client  v1.0.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownloadObject;
        private Button btnUploadObject;
        private Button btnDeleteObject;
        private Button btnCreateBucket;
        private Button btnDeleteBucket;
        private Button btnDownloadAllObject;
        private Button btnUploadObjectNav;
        private Button btnDownloadPathNav;
        private TextBox txtUploadObjectBucketName;
        private TextBox txtDownloadObjectName;
        private TextBox txtDownloadBucketName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtDeleteObjectBucketname;
        private TextBox txtDeleteObjectobjectname;
        private TextBox txtDwnAllObjectBucketName;
        private TextBox txtCreateBucketBucketName;
        private TextBox txtCreateBucketProjectId;
        private TextBox txtDeleteBucketBucketName;
        private ListBox listBoxListBucketContents;
        private Label label7;
        private TextBox txtListBucketContentsBucketName;
        private Button btnListBucketContents;
        private FolderBrowserDialog folderBrowserDialog2;
        private Button btnUploadObjFolderNav;
        private FolderBrowserDialog folderBrowserDialog3;
        private Button btnDownloadAllObjFolderNav;
        private Button btnPubSub;
    }
}