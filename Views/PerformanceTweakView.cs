using System;
using System.Windows.Forms;

namespace Minecraft_Launch_Script.Views
{
    public partial class PerformanceTweakView : Form
    {
        public static PerformanceTweakView performanceTweakView;
        public PerformanceTweakView()
        {
            InitializeComponent();
            performanceTweakView = this;
        }

        private void PerformanceTweakView_Load(object sender, EventArgs e)
        {
            MainPage.mainPage.colorTheme();
        }
    }
}
