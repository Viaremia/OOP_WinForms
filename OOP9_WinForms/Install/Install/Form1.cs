using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.IO;

namespace Install
{
    public partial class Form1 : Form
    {
        private string distributionPath = null;
        private string installingPath = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Distribution_BtnClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                if (folder.ShowDialog() == DialogResult.Cancel)
                    return;
                distributionPath = folder.SelectedPath;
            }
        }

        private void InstFolder_BtnClick(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                if (folder.ShowDialog() == DialogResult.Cancel)
                    return;
                installingPath = folder.SelectedPath;
            }

            using (StreamWriter sw = new StreamWriter(installingPath + "//install.dat", false))
            {
                sw.WriteLine(distributionPath);
                sw.WriteLine(installingPath);
            }
        }

        private void Installing_BtnClick(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            if (!IsApplicationInstalled("HelloUser"))
            {
                currentUserKey = currentUserKey.CreateSubKey("HelloUser");
                currentUserKey.SetValue("Path", installingPath);
            }
                
            else
            {
                MessageBox.Show("This programm is on your PC", "Attention!");
                return;
            }
            DirectoryCopy(distributionPath, installingPath);
        }

        private void DirectoryCopy(string distributionPath, string installingPath)
        {
            DirectoryInfo dir = new DirectoryInfo(distributionPath);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + distributionPath);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(installingPath, file.Name);
                file.CopyTo(tempPath);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in dirs)
            {
                string tempPath = Path.Combine(installingPath, subDir.Name);
                DirectoryCopy(subDir.FullName, installingPath);
            }
        }

        private bool IsApplicationInstalled(string value)
        {
            RegistryKey key = Registry.CurrentUser;
            foreach (string keyName in key.GetSubKeyNames())
            {
                if(value == keyName)
                    return true;
            }
            return false;
        }

        private void Deleting_BtnClick(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            if (IsApplicationInstalled("HelloUser"))
                currentUserKey.DeleteSubKey("HelloUser");
            else
            {
                MessageBox.Show("Can't find registry key!", "Attention!");
                return;
            }
            DirectoryDelete(installingPath);
            Directory.Delete(installingPath);
        }

        private void DirectoryDelete(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + distributionPath);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                file.Delete();
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in dirs)
            {
                string tempPath = Path.Combine(path, subDir.Name);
                DirectoryDelete(tempPath);
            }
        }
    }
}
