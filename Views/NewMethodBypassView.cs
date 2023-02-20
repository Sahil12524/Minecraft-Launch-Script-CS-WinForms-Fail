using System;
using System.Windows.Forms;

namespace Minecraft_Launch_Script.Views
{
    public partial class NewMethodBypassView : Form
    {
        public static NewMethodBypassView newMethodBypassView;
        public NewMethodBypassView()
        {
            InitializeComponent();
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            newMethodBypassView = this;
        }

        private void NewMethodBypassView_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            MainPage.mainPage.colorTheme();
        }
    }
}
