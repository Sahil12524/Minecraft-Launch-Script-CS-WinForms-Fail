using Minecraft_Launch_Script.Views;
using System;
using System.Windows.Forms;

namespace Minecraft_Launch_Script
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

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
        }

        private void btnOldMethod_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            switchPanel(new OldMethodView());
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
    }
}
