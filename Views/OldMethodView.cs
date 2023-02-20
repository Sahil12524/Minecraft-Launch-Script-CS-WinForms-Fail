using System;
using System.Windows.Forms;

namespace Minecraft_Launch_Script.Views
{
    public partial class OldMethodView : Form
    {
        public static OldMethodView oldMethodView;
        public OldMethodView()
        {
            InitializeComponent();
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            oldMethodView = this;
        }

        private void OldMethodView_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            MainPage.mainPage.colorTheme();
        }
    }
}
