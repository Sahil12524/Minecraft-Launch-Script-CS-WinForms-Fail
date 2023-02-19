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
            newMethodBypassView = this;
        }

        private void NewMethodBypassView_Load(object sender, EventArgs e)
        {
            MainPage.mainPage.colorTheme();
        }
    }
}
