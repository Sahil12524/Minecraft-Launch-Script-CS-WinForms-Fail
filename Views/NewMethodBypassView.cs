using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Launch_Script.Views
{
    public partial class NewMethodBypassView : Form
    {
        public Button buttonBackupDLL, buttonLoadBypass, buttonRunMinecraft, buttonQuickRestartPC, buttonStopBypass;
        public RichTextBox richText1, richText2, richText3, richText4, richText5;
        public Panel pnl3, pnl6, pnl9, pnl12, pnl15;
        public static NewMethodBypassView newMethodBypassView;
        public async void updateForm()
        {
            bool taskRunning = true;
            while (taskRunning)
            {
                await Task.Delay(100);
                updateLbl();
                HomeView.homeView.Invalidate();
                HomeView.homeView.Update();
                this.Invalidate();
                this.Update();
                HomeView.homeView.Invalidate();
                HomeView.homeView.labelBackupReqStatus.Update();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                HomeView.homeView.Activate();
                HomeView.homeView.Refresh();
                this.Invalidate();
                this.Update();
                Application.DoEvents();
                if (HomeView.homeView.labelBackupReqStatus.Text == "No")
                {
                    taskRunning = false;
                    pnl3.Hide();
                    pnl6.Show();
                    pnl9.Show();
                    pnl12.Show();
                    pnl15.Show();
                }
                if (HomeView.homeView.labelBypassStatus.Text == "True")
                {
                    taskRunning = true;
                    taskRunning = false;
                }


                else if (HomeView.homeView.labelBypassStatus.Text == "False")
                {
                    taskRunning = false;
                }

                if (HomeView.homeView.labelBypassStatus.Text == "True")
                {
                    taskRunning = true;
                    taskRunning = false;
                    pnl15.Show();
                    pnl6.Hide();
                    pnl9.Show();
                    pnl12.Show();
                    taskRunning = true;
                    taskRunning = false;
                }
                else if (HomeView.homeView.labelBypassStatus.Text == "False" | HomeView.homeView.labelBypassStatus.Text == "N/A")
                {
                    taskRunning = true;
                    taskRunning = false;
                    pnl15.Hide();
                    taskRunning = true;
                    taskRunning = false;
                }
                if (HomeView.homeView.labelBypassStatus.Text == "False" & HomeView.homeView.labelBackupReqStatus.Text == "No")
                {
                    taskRunning = true;
                    taskRunning = false;
                    pnl6.Show();
                    pnl9.Hide();
                    pnl12.Hide();
                    taskRunning = true;
                    taskRunning = false;
                }
            }
        }
        private void updateLbl()
        {
            HomeView.homeView.conditChk();
        }
        public async void BypassStopStatus()
        {
            bool taskRunning = true;
            await Task.Delay(100);
            updateLbl();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            HomeView.homeView.Activate();
            HomeView.homeView.Refresh();
            if (HomeView.homeView.labelCurrentSystem32DLLVersion.Text == HomeView.homeView.labelBackupSystem32DLLVersion.Text & HomeView.homeView.labelCurrentSysWOW64DLLVersion.Text == HomeView.homeView.labelBackupSysWOW64DLLVersion.Text)
            {
                MessageBox.Show("Bypass Stopped Successfully ✔️");
                taskRunning = false;
            }
            else
            {
                MessageBox.Show("Bypass Stop Error ✖️");
                HomeView.homeView.labelBypassStatus.Text = "True";
                pnl15.Show();
                pnl12.Show();
                taskRunning = false;
            }
        }
        public async void BypassLoadStatus()
        {
            bool taskRunning = true;
            await Task.Delay(100);
            updateLbl();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            HomeView.homeView.Activate();
            HomeView.homeView.Refresh();
            if (HomeView.homeView.labelCurrentSystem32DLLVersion.Text == HomeView.homeView.labelHackSystem32DllVersion.Text & HomeView.homeView.labelCurrentSysWOW64DLLVersion.Text == HomeView.homeView.labelHackSysWOW64DLLVersion.Text)
            {
                MessageBox.Show("Bypass Loaded Successfully ✔️");
                taskRunning = false;
            }
            else
            {
                MessageBox.Show("Bypass Load Error ✖️");
                HomeView.homeView.labelBypassStatus.Text = "False";
                pnl9.Hide();
                pnl12.Hide();
                pnl15.Hide();
                taskRunning = false;
            }
        }

        public NewMethodBypassView()
        {
            InitializeComponent();
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            newMethodBypassView = this;
            buttonBackupDLL = btnBackupDLL;
            buttonLoadBypass = btnLoadBypass;
            buttonRunMinecraft = btnRunMinecraft;
            buttonQuickRestartPC = btnQuickRestartPC;
            buttonStopBypass = btnStopBypass;
            richText1 = richTextBox1;
            richText2 = richTextBox2;
            richText3 = richTextBox3;
            richText4 = richTextBox4;
            richText5 = richTextBox5;
            pnl3 = panel3;
            pnl6 = panel6;
            pnl9 = panel9;
            pnl12 = panel12;
            pnl15 = panel15;
        }

        private void NewMethodBypassView_Load(object sender, EventArgs e)
        {
            //label1.Text = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);  //Testing Only
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            MainPage.mainPage.colorTheme();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            // HomeView.Close()
            // Threading.Thread.Sleep(1000)
            if (HomeView.homeView.labelBackupReqStatus.Text == "Yes" | HomeView.homeView.labelBackupReqStatus.Text == "N/A" | HomeView.homeView.labelBackupSystem32DLLVersion.Text == "Backup not found" & HomeView.homeView.labelBackupSysWOW64DLLVersion.Text == "Backup not found" | HomeView.homeView.labelBackupSystem32DLLVersion.Text == "Backup not found" | HomeView.homeView.labelBackupSysWOW64DLLVersion.Text == "Backup not found")
            {
                pnl3.Show();
                pnl6.Hide();
                pnl9.Hide();
                pnl12.Hide();
                pnl15.Hide();
            }
            else if (HomeView.homeView.labelBackupReqStatus.Text == "No")
            {
                pnl3.Hide();
                pnl6.Show();
                pnl9.Show();
                pnl12.Show();
                pnl15.Show();
            }

            if (HomeView.homeView.labelBypassStatus.Text == "True")
            {
                pnl15.Show();
            }
            else if (HomeView.homeView.labelBypassStatus.Text == "False" | HomeView.homeView.labelBypassStatus.Text == "N/A")
            {
                pnl15.Hide();
            }

            if (HomeView.homeView.labelBypassStatus.Text == "True")
            {

                pnl15.Show();
                pnl6.Hide();
                pnl9.Show();
                pnl12.Show();
            }

            else if (HomeView.homeView.labelBypassStatus.Text == "False" | HomeView.homeView.labelBypassStatus.Text == "N/A")
            {

                pnl15.Hide();

            }
            if (HomeView.homeView.labelBypassStatus.Text == "False" & HomeView.homeView.labelBackupReqStatus.Text == "No")
            {

                pnl6.Show();
                pnl9.Hide();
                pnl12.Hide();
            }
        }

        private void btnBackupDLL_Click(object sender, EventArgs e)
        {
            Process backupDLL;
            DialogResult result = MessageBox.Show("Are You Sure That You Never Used This Button Before, Note: Backup Should Be Done Only One Time If You Are A New User?, Press Yes to Make a Backup If Not Made Before Or Press No To Cancel The Backup Process", "Backup DLL Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                updateForm();
                backupDLL = Process.Start(@"bin\backup_DLL.bat");
                backupDLL.WaitForExit();
                updateForm();
                Update();
            }
            else if (result == DialogResult.No)
            {
                buttonBackupDLL.Enabled = false;
            }
        }

        private void btnLoadBypass_Click(object sender, EventArgs e)
        {
            Process startProc;
            updateForm();
            // taskRunning = False
            startProc = Process.Start(@"bin\new_Start.bat");
            startProc.WaitForExit();
            updateForm();
            BypassLoadStatus();

        }

        private void btnRunMinecraft_Click(object sender, EventArgs e)
        {
            Interaction.Shell(@"explorer.exe shell:appsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App", AppWinStyle.Hide);
            System.Threading.Thread.Sleep(4000);
            Interaction.Shell("taskkill /F /IM \"RuntimeBroker.exe\"", AppWinStyle.Hide);
            Process[] proc;
            proc = Process.GetProcessesByName("Minecraft.Windows".ToLower()); // <- Do not use .exe in process name
            if (proc.Count() > 0)
            {

            }
            else
            {
                Process startProc;
                DialogResult result = MessageBox.Show("Minecraft Bedrock Edition is not installed in this computer, please make sure that you have to install the game first and then use this launcher.", "Minecraft Not Installed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                updateForm();
                startProc = Process.Start(@"bin\new_Stop.bat");
                startProc.WaitForExit();
                updateForm();
                BypassStopStatus();
            }
        }

        private void btnQuickRestartPC_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure That You Want To Quick Restart your PC?, Use This Button Only If The System32's DLL Says 'Sharing Violation' Error.", "Quick Restart Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Interaction.Shell("logoff", AppWinStyle.Hide, true, 100);
            }
        }

        private void btnStopBypass_Click(object sender, EventArgs e)
        {
            // taskRunning = True
            // taskRunning = False
            Process startProc;
            updateForm();
            startProc = Process.Start(@"bin\new_Stop.bat");
            startProc.WaitForExit();
            updateForm();
            BypassStopStatus();
            // taskRunning = True
            // taskRunning = False
        }
    }
}
