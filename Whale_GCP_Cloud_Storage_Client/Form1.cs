using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using MimeMapping;
using File = System.IO.File;

namespace Whale_GCP_Cloud_Storage_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Global
        {
            public static string Uploadfilepath;
            public static string Dwnloadfilepath;
            public static string UploadObjFolder;
            public static string DwnloadAllfolderpath;
        }
        private const string credentials = "Path_of_credential.json";
        public StorageClient getStorageCredential()
        {
            GoogleCredential credential = null;
            using (var jsonStream = new FileStream(credentials, FileMode.Open,
                FileAccess.Read, FileShare.Read))
            {
                credential = GoogleCredential.FromStream(jsonStream);
            }
            var gcsStorage = StorageClient.Create(credential);
            return gcsStorage;
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            string bucketname = txtDownloadBucketName.Text;
            string objectfoldername = txtDownloadObjectName.Text;
            DownloadfileandFolder(bucketname, objectfoldername);
            MessageBox.Show("Process Completed");


        }

        private async void btnUploadObject_Click(object sender, EventArgs e)
        {

            try
            {
                if ((Global.Uploadfilepath != null) || (Global.UploadObjFolder != null))
                {
                    string bucketName = txtUploadObjectBucketName.Text;
                    if (Global.Uploadfilepath != null)
                    {
                        UploadObject(Global.Uploadfilepath, bucketName);
                    }
                    else
                    {
                        await Task.Run(() =>
                        {
                            foreach (string file in GetFiles(Global.UploadObjFolder))
                            {
                                UploadObject(file, bucketName);
                            }
                        });

                    }
                    MessageBox.Show("Process Completed");
                }
                else
                    MessageBox.Show("Uploder_Single_File  or  Upload_Folder");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            string bucketname = txtDeleteObjectBucketname.Text;
            string objectname = txtDeleteObjectobjectname.Text;
            DeleteObject(bucketname, objectname);
            MessageBox.Show("Process Completed");
        }
        private void btnCreateBucket_Click(object sender, EventArgs e)
        {
            string ProjectId = txtCreateBucketProjectId.Text;
            string bucketname = txtCreateBucketBucketName.Text;
            CreateBucket(ProjectId, bucketname);
            MessageBox.Show("Process Completed");
        }

        private void btnDeleteBucket_Click(object sender, EventArgs e)
        {
            string bucketname = txtDeleteBucketBucketName.Text;
            DeleteBucket(bucketname);
            MessageBox.Show("Process Completed");
        }
        private void btnDownloadAllObject_Click(object sender, EventArgs e)
        {
            string bucketname = txtDwnAllObjectBucketName.Text;
            DownloadAllObject(bucketname);
            MessageBox.Show("Process Completed");
        }

        private void btnUploadNavigation_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker1.IsBusy)
                {
                    MessageBox.Show("Please wait...the process is going on", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filepath = openFileDialog1.FileName;
                    Global.Uploadfilepath = filepath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDownloadPathNav_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker1.IsBusy)
                {
                    MessageBox.Show("Please wait...the process is going on", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Global.Dwnloadfilepath = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        IEnumerable<string> GetFiles(string path)
        {
            string bucketname = txtDownloadBucketName.Text;
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(path);
            while (queue.Count > 0)
            {
                path = queue.Dequeue();
                try
                {
                    foreach (string subDir in Directory.GetDirectories(path))
                    {
                        queue.Enqueue(subDir);

                        var dn = subDir.Substring(Path.GetPathRoot(subDir).Length);
                        dn = dn.Replace(@"\", "/");
                        CreateDir(dn, bucketname);

                        foreach (string subsubDir in Directory.GetDirectories(subDir))
                        {
                            queue.Enqueue(subsubDir);

                            var subdn = subsubDir.Substring(Path.GetPathRoot(subsubDir).Length);
                            subdn = subdn.Replace(@"\", "/");
                            CreateDir(subdn, bucketname);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        yield return files[i];
                    }
                }
            }
        }

        public async void CreateDir(string FolderName, string bucketName)
        {
            try
            {
                await Task.Run(() =>
                {
                    var gcsStorage = getStorageCredential();
                    //if (FolderName.Contains('\\'))
                    FolderName = FolderName.Substring(Path.GetPathRoot(FolderName).Length);
                    if (!FolderName.EndsWith("/"))
                        FolderName += "/";

                    var content = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(""));
                    gcsStorage.UploadObject(bucketName, FolderName, "application/x-directory", content);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void UploadObject(string localpath, string bucketName)
        {
            try
            {
                await Task.Run(() =>
                {
                    var gcsStorage = getStorageCredential();

                    var objectname = localpath.Substring(Path.GetPathRoot(localpath).Length);
                    objectname = objectname.Replace(@"\", "/");

                    var fileStream = File.OpenRead(localpath);
                    gcsStorage.UploadObject(bucketName, objectname, MimeUtility.GetMimeMapping(objectname), fileStream);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void UploadObjFolder(string localPath, string bucketName)
        {
            try
            {
                await Task.Run(() =>
                {
                    var gcsStorage = getStorageCredential();

                    DirectoryInfo d = new DirectoryInfo(localPath);
                    FileInfo[] Files = d.GetFiles();
                    foreach (FileInfo file in Files)
                    {
                        //creating objectname without disk name 
                        string Name = localPath;////.Substring(Path.GetPathRoot(localPath).Length);  //this saves directorys inside of directory but makes seperate directory on cloud 
                                                // string Name = localPath.Substring(Path.GetPathRoot(localPath).Length);
                        string objectName = Name + "/" + file.Name;

                        string localPathstream = localPath + "\\" + file.Name;
                        using var fileStream = File.OpenRead(localPathstream);
                        gcsStorage.UploadObject(bucketName, objectName, null, fileStream);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void DownloadAllObject(string bucketname)
        {
            try
            {
                await Task.Run(() =>
                {

                    var gcsStorage = getStorageCredential();

                    //create folder to store Cloud objects 
                    if (!System.IO.Directory.Exists(Global.DwnloadAllfolderpath + "\\GoogleBucketDownloads\\"))
                    {
                        System.IO.Directory.CreateDirectory(Global.DwnloadAllfolderpath + "\\GoogleBucketDownloads\\");
                    }

                    foreach (var obj in gcsStorage.ListObjects(bucketname, ""))
                    {
                        //string filepath_Withname = @"D:\GoogleBucketDownloads\" + obj.Name;
                        string filepath_Withname = Global.DwnloadAllfolderpath + "\\" + "GoogleBucketDownloads" + "\\" + obj.Name;
                        //To remove Object name and create folder
                        string removelastslash = filepath_Withname;
                        if (removelastslash.Contains('/'))
                        {
                            removelastslash = removelastslash.Substring(0, removelastslash.LastIndexOf('/'));
                            if (!System.IO.Directory.Exists(removelastslash))
                            {
                                System.IO.Directory.CreateDirectory(removelastslash);
                            }
                        }
                        DownloadObject(bucketname, obj.Name, filepath_Withname);
                    }
                });
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void DownloadObject(string bucketName, string buobjectName, string filePath)
        {

            try
            {
                await Task.Run(() =>
                {
                    var gcsStorage = getStorageCredential();
                    using var outputFile = File.OpenWrite(filePath);
                    gcsStorage.DownloadObject(bucketName, buobjectName, outputFile);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void DownloadfileandFolder(string bucketname, string objectfoldername)
        {
            try
            {
                await Task.Run(() =>
                {
                    //to download file and folder both
                    var gcsStorage = getStorageCredential();

                    foreach (var obj in gcsStorage.ListObjects(bucketname, objectfoldername))
                    {
                        string filepath_Withname = Global.Dwnloadfilepath + "\\" + obj.Name;
                        //To remove Object name and create folder
                        string removelastslash = filepath_Withname;
                        if (removelastslash.Contains('/'))
                        {
                            string removedstslash = removelastslash.Substring(0, removelastslash.LastIndexOf('/'));
                            if (!System.IO.Directory.Exists(removedstslash))
                            {
                                System.IO.Directory.CreateDirectory(removedstslash);
                            }
                            //to escape folder name to download from bucket
                            string comparefoldername = Global.Dwnloadfilepath + "\\" + objectfoldername + "/";
                            if (comparefoldername == filepath_Withname)
                            {
                                continue;
                            }
                        }
                        using var outputFile = File.OpenWrite(filepath_Withname);
                        gcsStorage.DownloadObject(bucketname, obj.Name, outputFile);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void DeleteObject(string bucketName, string objectName)
        {
            try
            {
                await Task.Run(() =>
                {
                    var gcsStorage = getStorageCredential();
                    gcsStorage.DeleteObject(bucketName, objectName);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void CreateBucket(string projectId, string bucket)
        {
            try
            {
                await Task.Run(() =>
                {
                    var gcsStorage = getStorageCredential();
                    gcsStorage.CreateBucket(projectId, bucket);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void DeleteBucket(string bucket)
        {
            try
            {
                await Task.Run(() =>
                {
                    var gcsStorage = getStorageCredential();
                    gcsStorage.DeleteBucket(bucket);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUploadBucketName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeleteObjectBucketname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnListBucketContents_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    var gcsStorage = getStorageCredential();
                    string bucketname = txtListBucketContentsBucketName.Text;
                    if (listBoxListBucketContents.InvokeRequired)
                    {
                        listBoxListBucketContents.Invoke((MethodInvoker)delegate ()
                        {
                            listBoxListBucketContents.Items.Clear();
                        });
                    }

                    foreach (var obj in gcsStorage.ListObjects(bucketname, ""))
                    {
                        if (listBoxListBucketContents.InvokeRequired)
                        {
                            listBoxListBucketContents.Invoke((MethodInvoker)delegate ()
                            {
                                string filepath_Withname = obj.Name;
                                listBoxListBucketContents.Items.Add(filepath_Withname.ToString());
                            });
                        }
                    }
                    //string startdash = "------------------------------------------";
                    //listBoxListBucketContents.Items.Add(startdash.ToString());
                    listBoxListBucketContents.EndUpdate();
                    MessageBox.Show("Process Completed");
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUploadObjFolderNav_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker1.IsBusy)
                {
                    MessageBox.Show("Please wait...the process is going on", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
                {
                    Global.UploadObjFolder = folderBrowserDialog2.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownloadAllObjFolderNav_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker1.IsBusy)
                {
                    MessageBox.Show("Please wait...the process is going on", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (folderBrowserDialog3.ShowDialog() == DialogResult.OK)
                {
                    Global.DwnloadAllfolderpath = folderBrowserDialog3.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDwnAllObjectBucketName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPubSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Functionality is in Development");


        }
    }
}