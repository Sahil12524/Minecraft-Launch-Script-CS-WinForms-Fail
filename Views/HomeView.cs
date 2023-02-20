using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Minecraft_Launch_Script.Views
{
    public partial class HomeView : Form
    {
        public Label labelCurrentSystem32DLLVersion, labelCurrentSysWOW64DLLVersion, labelBackupSystem32DLLVersion, labelBackupSysWOW64DLLVersion, labelHackSystem32DllVersion, labelHackSysWOW64DLLVersion, labelBackupReqStatus, labelBypassStatus, labelLauncherHealthStatus;
        public static HomeView homeView;
        public void conditChk()
        {
            string fileReader;
            Interaction.Shell(@"cmd.exe /c wmic datafile where name=""C:\\Windows\\System32\\Windows.ApplicationModel.Store.dll"" Get Version /value > ""CurSystem32Ver.txt"" && wmic datafile where name=""C:\\Windows\\SysWOW64\\Windows.ApplicationModel.Store.dll"" Get Version /value > ""CurSysWOW64Ver.txt"" ", AppWinStyle.Hide, true, 400);
            // Threading.Thread.Sleep(1000)
            try
            {
                fileReader = File.ReadAllText("CurSystem32Ver.txt").Replace("Version=", "");
                lblCurrentSystem32DllVersion.Text = fileReader.Trim();
                fileReader = File.ReadAllText("CurSysWOW64Ver.txt").Replace("Version=", "");
                lblCurrentSysWOW64DllVersion.Text = fileReader.Trim();
            }
            catch (FileNotFoundException ex)
            {
                Interaction.MsgBox(ex.ToString());
                Interaction.Shell("Cmd.exe /c type nul > CurSystem32Ver.txt && type nul > CurSysWOW64Ver.txt", AppWinStyle.Hide, true, 100);
            }

            try
            {
                var backupSystem32Dll = FileVersionInfo.GetVersionInfo(@"bin\dlls\Original Dlls Backup\System32\Windows.ApplicationModel.Store.dll");
                lblBackupSystem32DllVersion.Text = backupSystem32Dll.ProductVersion.ToString();
                var backupSysWOW64Dll = FileVersionInfo.GetVersionInfo(@"bin\dlls\Original Dlls Backup\SysWOW64\Windows.ApplicationModel.Store.dll");
                lblBackupSysWOW64DllVersion.Text = backupSysWOW64Dll.ProductVersion.ToString();
            }
            catch (FileNotFoundException ex)
            {
                lblBackupSystem32DllVersion.Text = "Backup not found";
                lblBackupSysWOW64DllVersion.Text = "Backup not found";
                // If lblBackupSystem32DllVersion.Text = "Backup not found" And lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
                // Dim result As DialogResult = MessageBox.Show("Backup DLLs in both the folder not found, please make a backup of DLLs to avoid Windows Corruptions", "Backup Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                // End If
            }

            if (lblCurrentSystem32DllVersion.Text == lblHackSystem32DllVersion.Text & lblCurrentSysWOW64DllVersion.Text == lblHackSysWOW64DllVersion.Text | lblCurrentSystem32DllVersion.Text == lblHackSystem32DllVersion.Text | lblCurrentSysWOW64DllVersion.Text == lblHackSysWOW64DllVersion.Text)
            {
                lblBypassStatus.ForeColor = Color.Green;
                lblBypassStatus.Text = "True";
            }
            else
            {
                lblBypassStatus.ForeColor = Color.Red;
                lblBypassStatus.Text = "False";
            }

            if (lblCurrentSystem32DllVersion.Text == lblBackupSystem32DllVersion.Text & lblCurrentSysWOW64DllVersion.Text == lblBackupSysWOW64DllVersion.Text)
            {
                lblBackupReqStatus.ForeColor = Color.Green;
                lblBackupReqStatus.Text = "No";
            }
            else if (lblCurrentSystem32DllVersion.Text != lblBackupSystem32DllVersion.Text & lblCurrentSysWOW64DllVersion.Text != lblBackupSysWOW64DllVersion.Text & lblBypassStatus.Text == "True")
            {
                lblBackupReqStatus.ForeColor = Color.Green;
                lblBackupReqStatus.Text = "No";
            }
            else if (lblBypassStatus.Text == "True")
            {
                lblBackupReqStatus.ForeColor = Color.Green;
                lblBackupReqStatus.Text = "No";
            }
            else
            {
                lblBackupReqStatus.ForeColor = Color.Red;
                lblBackupReqStatus.Text = "Yes";
            }

            if (lblBackupSystem32DllVersion.Text == "Backup not found" & lblBackupSysWOW64DllVersion.Text == "Backup not found")
            {
                lblBackupReqStatus.Text = "N/A";
                lblBypassStatus.ForeColor = Color.Red;
                lblBypassStatus.Text = "False";
                lblLauncherHealthStatus.Text = "N/A";
            }

            // If lblBackupReqStatus.Text = "Yes" Then
            // Dim result As DialogResult = MessageBox.Show("Backup of the DLLs Needs to be Updated because the original DLLs are either updated via Windows Update or by Microsoft Store Update. Note: Update of Backup DLLs is compulsory to avoid Windows Corruptions or Microsoft Store not working issue!", "Backup Needs To Be Updated!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            // End If

            if (lblCurrentSystem32DllVersion.Text == lblBackupSystem32DllVersion.Text & lblCurrentSysWOW64DllVersion.Text == lblBackupSysWOW64DllVersion.Text & lblCurrentSystem32DllVersion.Text == lblCurrentSysWOW64DllVersion.Text & lblBackupSystem32DllVersion.Text == lblBackupSysWOW64DllVersion.Text & lblBackupSystem32DllVersion.Text != lblHackSystem32DllVersion.Text & lblBackupSysWOW64DllVersion.Text != lblHackSysWOW64DllVersion.Text)
            {
                lblLauncherHealthStatus.ForeColor = Color.Green;
                lblLauncherHealthStatus.Text = "Good";
            }
            else if (lblBypassStatus.Text == "True" & lblCurrentSystem32DllVersion.Text == lblHackSystem32DllVersion.Text & lblCurrentSysWOW64DllVersion.Text == lblHackSysWOW64DllVersion.Text)
            {
                lblLauncherHealthStatus.ForeColor = Color.Green;
                lblLauncherHealthStatus.Text = "Good";
            }
            else if (lblBackupSystem32DllVersion.Text == "Backup not found" & lblBackupSysWOW64DllVersion.Text == "Backup not found")
            {
                lblLauncherHealthStatus.Text = "N/A";
            }
            else
            {
                lblLauncherHealthStatus.ForeColor = Color.Red;
                lblLauncherHealthStatus.Text = "Bad";
            }
        }

        public HomeView()
        {
            InitializeComponent();
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            homeView = this;
            labelCurrentSystem32DLLVersion = lblCurrentSystem32DllVersion;
            labelCurrentSysWOW64DLLVersion = lblCurrentSysWOW64DllVersion;
            labelBackupSystem32DLLVersion = lblBackupSystem32DllVersion;
            labelBackupSysWOW64DLLVersion = lblBackupSysWOW64DllVersion;
            labelHackSystem32DllVersion = lblHackSystem32DllVersion;
            labelHackSysWOW64DLLVersion = lblHackSysWOW64DllVersion;
            labelBackupReqStatus = lblBackupReqStatus;
            labelBypassStatus = lblBypassStatus;
            labelLauncherHealthStatus = lblLauncherHealthStatus;

        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            //label1.Text = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); //Testing Only
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            MainPage.mainPage.colorTheme();
            conditChk(); // <- Function!
            if (lblBackupReqStatus.Text == "Yes")
            {
                DialogResult result = MessageBox.Show("Backup of the DLLs Needs to be Updated because the original DLLs are either got updated via Windows Update or by Microsoft Store Update. Note: Update of Backup DLLs is compulsory to avoid Windows Corruptions or Microsoft Store not working like issues!", "Backup of DLLs Needs To Be Updated!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (lblBackupSystem32DllVersion.Text == "Backup not found" & lblBackupSysWOW64DllVersion.Text == "Backup not found")
            {
                DialogResult result = MessageBox.Show("Backup DLLs in both the folder are not found, please make a backup of DLLs to avoid Windows Corruptions", "Backup DLLs Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (lblLauncherHealthStatus.Text == "Bad")
            {
                DialogResult result = MessageBox.Show("The Launcher has a Bad Health, Make sure that you fix the health first before you use the launcher.", "Launcher Bad Health Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HomeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Interaction.Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt", AppWinStyle.Hide, true, 100);
        }

        private void HomeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Interaction.Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt", AppWinStyle.Hide, true, 100);
        }
    }
}
