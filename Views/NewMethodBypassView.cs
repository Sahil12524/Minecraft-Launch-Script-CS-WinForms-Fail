using System;
using System.Windows.Forms;

namespace Minecraft_Launch_Script.Views
{
    public partial class NewMethodBypassView : Form
    {
        public Button buttonBackupDLL, buttonLoadBypass, buttonRunMinecraft, buttonQuickRestartPC, buttonStopBypass;
        public RichTextBox richText1, richText2, richText3, richText4, richText5;
        public static NewMethodBypassView newMethodBypassView;
        public NewMethodBypassView()
        {
            InitializeComponent();
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            newMethodBypassView = this;
            buttonBackupDLL = btnBackupDLL;
            buttonLoadBypass = btnLoadBypass;
            buttonRunMinecraft = btnRunMinecraft;
            buttonQuickRestartPC = btnQuickRestartPC;
            buttonStopBypass = btnStopBypass;
            richText1 = richTextBox1;
            richText2 = richTextBox2;
            richText3 = richTextBox3;
            richText4 = richTextBox4;
            richText5 = richTextBox5;
        }

        private void NewMethodBypassView_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Stops flickering
            MainPage.mainPage.colorTheme();
        }
    }
}
