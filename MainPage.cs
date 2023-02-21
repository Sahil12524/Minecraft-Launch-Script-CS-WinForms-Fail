using Microsoft.VisualBasic;
using Microsoft.Win32;
using Minecraft_Launch_Script.Helper;
using Minecraft_Launch_Script.Views;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Launch_Script
{
    public partial class MainPage : Form
    {
        public static MainPage mainPage;
        public Button buttonHome, buttonNewMethodBypass, buttonOldMethod, buttonPerformanceTweak, buttonAbout;
        public Panel pnl1;
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        private bool isLightTheme;
        private bool taskRunning = true;
        internal static class NativeWinAPI //Stops flickering
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }
        public void colorTheme()
        {
            int lightmode = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1");
            try
            {
                if (lightmode != 1) // its a dark mode
                {
                    if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                        DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
                    ThemeHelper.DarkThemeButtons();
                    isLightTheme = false;
                    ThemeHelper.DarkTheme();
                }
                else if (lightmode != 0) // its a light mode
                {
                    DwmSetWindowAttribute(Handle, 20, new[] { 0 }, 4);
                    ThemeHelper.LightThemeButtons();
                    isLightTheme = true;
                    ThemeHelper.LightTheme();
                }
            }

            catch (ObjectDisposedException)
            {
                Application.Exit();
            }
        }
        public async void updateTheme()
        {
            while (taskRunning)
            {
                await Task.Delay(500);
                colorTheme();
            }
        }
        string fileReader = Interaction.Environ("USERPROFILE") + @"\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftpe\options.txt";
        string root = @"C:\";
        dynamic appDefLoc = System.IO.Directory.GetParent(Application.ExecutablePath);
        public MainPage()
        {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE); //Stops flickering
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            mainPage = this;
            buttonHome = btnHome;
            buttonAbout = btnAbout;
            buttonNewMethodBypass = btnNewMethodBypass;
            buttonOldMethod = btnOldMethod;
            buttonPerformanceTweak = btnPerformanceTweak;
            pnl1 = panel1;
        }

        public void switchPanel(Form panel)
        {
            panel4.Controls.Clear();
            panel.TopLevel = false;
            panel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            panel4.Controls.Add(panel);
            panel.Show();
        }


        private void MainPage_Load(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new HomeView());
            colorTheme();
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            if (isLightTheme == true)
            {
                ThemeHelper.LightTheme();
                taskRunning = false;
            }
            else if (isLightTheme != true)
            {
                ThemeHelper.DarkTheme();
                taskRunning = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new HomeView());
        }

        private void btnNewMethodBypass_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new NewMethodBypassView());
            Interaction.Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt", AppWinStyle.Hide, true, 100);
            // Threading.Thread.Sleep(1000)

            if (HomeView.homeView.labelBackupReqStatus.Text == "Yes" | HomeView.homeView.labelBackupReqStatus.Text == "N/A" | HomeView.homeView.labelBackupSystem32DLLVersion.Text == "Backup not found" & HomeView.homeView.labelBackupSysWOW64DLLVersion.Text == "Backup not found")
            {
                NewMethodBypassView.newMethodBypassView.pnl3.Show();
                NewMethodBypassView.newMethodBypassView.pnl6.Hide();
                NewMethodBypassView.newMethodBypassView.pnl9.Hide();
                NewMethodBypassView.newMethodBypassView.pnl12.Hide();
                NewMethodBypassView.newMethodBypassView.pnl15.Hide();
            }
            else if (HomeView.homeView.labelBackupReqStatus.Text == "No")
            {
                NewMethodBypassView.newMethodBypassView.pnl3.Hide();
                NewMethodBypassView.newMethodBypassView.pnl6.Show();
                NewMethodBypassView.newMethodBypassView.pnl9.Show();
                NewMethodBypassView.newMethodBypassView.pnl12.Show();
                NewMethodBypassView.newMethodBypassView.pnl15.Show();
            }

            if (HomeView.homeView.labelBypassStatus.Text == "True")
            {
                taskRunning = true;
                taskRunning = false;
                NewMethodBypassView.newMethodBypassView.pnl15.Show();
                NewMethodBypassView.newMethodBypassView.pnl6.Hide();
                NewMethodBypassView.newMethodBypassView.pnl9.Show();
                NewMethodBypassView.newMethodBypassView.pnl12.Show();
                taskRunning = true;
                taskRunning = false;
            }
            else if (HomeView.homeView.labelBypassStatus.Text == "False" | HomeView.homeView.labelBypassStatus.Text == "N/A")
            {
                taskRunning = true;
                taskRunning = false;
                NewMethodBypassView.newMethodBypassView.pnl15.Hide();
                taskRunning = true;
                taskRunning = false;
            }
            if (HomeView.homeView.labelBypassStatus.Text == "False" & HomeView.homeView.labelBackupReqStatus.Text == "No")
            {
                taskRunning = true;
                taskRunning = false;
                NewMethodBypassView.newMethodBypassView.pnl6.Show();
                NewMethodBypassView.newMethodBypassView.pnl9.Hide();
                NewMethodBypassView.newMethodBypassView.pnl12.Hide();
                taskRunning = true;
                taskRunning = false;
            }
        }

        private void btnOldMethod_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new OldMethodView());
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Interaction.Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt", AppWinStyle.Hide, true, 100);
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnPerformanceTweak_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new PerformanceTweakView());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new AboutView());
        }

        private void MainPage_Activated(object sender, EventArgs e)
        {
            taskRunning = false;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void MainPage_Deactivate(object sender, EventArgs e)
        {
            taskRunning = true;
            updateTheme();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
