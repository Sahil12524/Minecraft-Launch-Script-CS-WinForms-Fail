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
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            performanceTweakView = this;
        }

        private void PerformanceTweakView_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            MainPage.mainPage.colorTheme();
        }
    }
}
