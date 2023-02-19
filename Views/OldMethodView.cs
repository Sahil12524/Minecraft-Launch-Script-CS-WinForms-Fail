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
            oldMethodView = this;
        }

        private void OldMethodView_Load(object sender, EventArgs e)
        {
            MainPage.mainPage.colorTheme();
        }
    }
}
