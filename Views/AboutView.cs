using System;
using System.Windows.Forms;

namespace Minecraft_Launch_Script.Views
{
    public partial class AboutView : Form
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void AboutView_Load(object sender, EventArgs e)
        {
            MainPage.mainPage.colorTheme();
        }
    }
}
