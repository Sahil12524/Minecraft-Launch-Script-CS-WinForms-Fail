using Microsoft.Win32;
using Minecraft_Launch_Script.Helper;
using Minecraft_Launch_Script.Views;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Launch_Script
{
    public partial class MainPage : Form
    {
        public static MainPage mainPage = new MainPage();
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        private bool isLightTheme;
        private bool taskRunning = true;
        public void colorTheme()
        {
            int lightmode = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1");
            try
            {
                if (lightmode != 1) // its a dark mode
                {
                    if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                        DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
                    //ThemeHelper.DarkThemeButtons();
                    isLightTheme = false;
                    ThemeHelper.DarkTheme();
                }
                else if (lightmode != 0) // its a light mode
                {
                    DwmSetWindowAttribute(Handle, 20, new[] { 0 }, 4);
                    //ThemeHelper.LightThemeButtons();
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
        public MainPage()
        {
            InitializeComponent();
            mainPage = this;
            
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
            colorTheme();
        }

        private void btnNewMethodBypass_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new NewMethodBypassView());
            colorTheme();
        }

        private void btnOldMethod_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new OldMethodView());
            colorTheme();
        }

        private void btnPerformanceTweak_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new PerformanceTweakView());
            colorTheme();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new AboutView());
            colorTheme();
        }

        private void MainPage_Activated(object sender, EventArgs e)
        {
            taskRunning = false;
        }

        private void MainPage_Deactivate(object sender, EventArgs e)
        {
            taskRunning = true;
            updateTheme();
        }
    }
}
