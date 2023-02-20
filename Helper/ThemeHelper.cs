using Minecraft_Launch_Script.Views;
using System.Drawing;
using System.Windows.Forms;

namespace Minecraft_Launch_Script.Helper
{
    public class ThemeHelper
    {
        public static void DarkTheme()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form)
                {
                    form.BackColor = Color.FromArgb(18, 18, 18);
                    form.ForeColor = SystemColors.Control;

                }
            }
        }
        public static void DarkThemeButtons()
        {
            if (MainPage.mainPage != null)
            {
                MainPage.mainPage.buttonHome.FlatStyle = FlatStyle.Flat;
                MainPage.mainPage.buttonHome.FlatAppearance.MouseOverBackColor = Color.Gray;
                MainPage.mainPage.buttonHome.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                MainPage.mainPage.buttonHome.FlatAppearance.BorderColor = Color.Gray;
                MainPage.mainPage.buttonHome.ForeColor = SystemColors.Control;

                MainPage.mainPage.buttonNewMethodBypass.FlatStyle = FlatStyle.Flat;
                MainPage.mainPage.buttonNewMethodBypass.FlatAppearance.MouseOverBackColor = Color.Gray;
                MainPage.mainPage.buttonNewMethodBypass.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                MainPage.mainPage.buttonNewMethodBypass.FlatAppearance.BorderColor = Color.Gray;
                MainPage.mainPage.buttonNewMethodBypass.ForeColor = SystemColors.Control;

                MainPage.mainPage.buttonOldMethod.FlatStyle = FlatStyle.Flat;
                MainPage.mainPage.buttonOldMethod.FlatAppearance.MouseOverBackColor = Color.Gray;
                MainPage.mainPage.buttonOldMethod.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                MainPage.mainPage.buttonOldMethod.FlatAppearance.BorderColor = Color.Gray;
                MainPage.mainPage.buttonOldMethod.ForeColor = SystemColors.Control;

                MainPage.mainPage.buttonPerformanceTweak.FlatStyle = FlatStyle.Flat;
                MainPage.mainPage.buttonPerformanceTweak.FlatAppearance.MouseOverBackColor = Color.Gray;
                MainPage.mainPage.buttonPerformanceTweak.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                MainPage.mainPage.buttonPerformanceTweak.FlatAppearance.BorderColor = Color.Gray;
                MainPage.mainPage.buttonPerformanceTweak.ForeColor = SystemColors.Control;

                MainPage.mainPage.buttonAbout.FlatStyle = FlatStyle.Flat;
                MainPage.mainPage.buttonAbout.FlatAppearance.MouseOverBackColor = Color.Gray;
                MainPage.mainPage.buttonAbout.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                MainPage.mainPage.buttonAbout.FlatAppearance.BorderColor = Color.Gray;
                MainPage.mainPage.buttonAbout.ForeColor = SystemColors.Control;
            }


            if (NewMethodBypassView.newMethodBypassView != null)
            {
                NewMethodBypassView.newMethodBypassView.buttonBackupDLL.FlatStyle = FlatStyle.Flat;
                NewMethodBypassView.newMethodBypassView.buttonBackupDLL.FlatAppearance.MouseOverBackColor = Color.Gray;
                NewMethodBypassView.newMethodBypassView.buttonBackupDLL.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                NewMethodBypassView.newMethodBypassView.buttonBackupDLL.FlatAppearance.BorderColor = Color.Gray;
                NewMethodBypassView.newMethodBypassView.buttonBackupDLL.ForeColor = SystemColors.Control;

                NewMethodBypassView.newMethodBypassView.buttonLoadBypass.FlatStyle = FlatStyle.Flat;
                NewMethodBypassView.newMethodBypassView.buttonLoadBypass.FlatAppearance.MouseOverBackColor = Color.Gray;
                NewMethodBypassView.newMethodBypassView.buttonLoadBypass.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                NewMethodBypassView.newMethodBypassView.buttonLoadBypass.FlatAppearance.BorderColor = Color.Gray;
                NewMethodBypassView.newMethodBypassView.buttonLoadBypass.ForeColor = SystemColors.Control;

                NewMethodBypassView.newMethodBypassView.buttonRunMinecraft.FlatStyle = FlatStyle.Flat;
                NewMethodBypassView.newMethodBypassView.buttonRunMinecraft.FlatAppearance.MouseOverBackColor = Color.Gray;
                NewMethodBypassView.newMethodBypassView.buttonRunMinecraft.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                NewMethodBypassView.newMethodBypassView.buttonRunMinecraft.FlatAppearance.BorderColor = Color.Gray;
                NewMethodBypassView.newMethodBypassView.buttonRunMinecraft.ForeColor = SystemColors.Control;

                NewMethodBypassView.newMethodBypassView.buttonQuickRestartPC.FlatStyle = FlatStyle.Flat;
                NewMethodBypassView.newMethodBypassView.buttonQuickRestartPC.FlatAppearance.MouseOverBackColor = Color.Gray;
                NewMethodBypassView.newMethodBypassView.buttonQuickRestartPC.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                NewMethodBypassView.newMethodBypassView.buttonQuickRestartPC.FlatAppearance.BorderColor = Color.Gray;
                NewMethodBypassView.newMethodBypassView.buttonQuickRestartPC.ForeColor = SystemColors.Control;

                NewMethodBypassView.newMethodBypassView.buttonStopBypass.FlatStyle = FlatStyle.Flat;
                NewMethodBypassView.newMethodBypassView.buttonStopBypass.FlatAppearance.MouseOverBackColor = Color.Gray;
                NewMethodBypassView.newMethodBypassView.buttonStopBypass.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                NewMethodBypassView.newMethodBypassView.buttonStopBypass.FlatAppearance.BorderColor = Color.Gray;
                NewMethodBypassView.newMethodBypassView.buttonStopBypass.ForeColor = SystemColors.Control;

                NewMethodBypassView.newMethodBypassView.richText1.BackColor = Color.FromArgb(18, 18, 18);
                NewMethodBypassView.newMethodBypassView.richText1.ForeColor = SystemColors.Control;
                
                NewMethodBypassView.newMethodBypassView.richText2.BackColor = Color.FromArgb(18, 18, 18);
                NewMethodBypassView.newMethodBypassView.richText2.ForeColor = SystemColors.Control;
                
                NewMethodBypassView.newMethodBypassView.richText3.BackColor = Color.FromArgb(18, 18, 18);
                NewMethodBypassView.newMethodBypassView.richText3.ForeColor = SystemColors.Control;
                
                NewMethodBypassView.newMethodBypassView.richText4.BackColor = Color.FromArgb(18, 18, 18);
                NewMethodBypassView.newMethodBypassView.richText4.ForeColor = SystemColors.Control;
                
                NewMethodBypassView.newMethodBypassView.richText5.BackColor = Color.FromArgb(18, 18, 18);
                NewMethodBypassView.newMethodBypassView.richText5.ForeColor = SystemColors.Control;


            }

            if (OldMethodView.oldMethodView != null)
            {

            }

            if (PerformanceTweakView.performanceTweakView != null)
            {

            }

            if (AboutView.aboutView != null)
            {

            }

        }
        public static void LightTheme()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form)
                {
                    form.BackColor = SystemColors.Control;
                    form.ForeColor = SystemColors.ControlText;
                }
            }
        }

        public static void LightThemeButtons()
        {
            if (MainPage.mainPage != null)
            {
                MainPage.mainPage.buttonHome.FlatStyle = FlatStyle.Flat;
                MainPage.mainPage.buttonHome.FlatAppearance.MouseOverBackColor = Color.Gray;
                MainPage.mainPage.buttonHome.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                MainPage.mainPage.buttonHome.FlatAppearance.BorderColor = Color.Gray;
                MainPage.mainPage.buttonHome.ForeColor = SystemColors.ControlText;

                MainPage.mainPage.buttonNewMethodBypass.FlatStyle = FlatStyle.Flat;
                MainPage.mainPage.buttonNewMethodBypass.FlatAppearance.MouseOverBackColor = Color.Gray;
                MainPage.mainPage.buttonNewMethodBypass.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                MainPage.mainPage.buttonNewMethodBypass.FlatAppearance.BorderColor = Color.Gray;
                MainPage.mainPage.buttonNewMethodBypass.ForeColor = SystemColors.ControlText;

                MainPage.mainPage.buttonOldMethod.FlatStyle = FlatStyle.Flat;
                MainPage.mainPage.buttonOldMethod.FlatAppearance.MouseOverBackColor = Color.Gray;
                MainPage.mainPage.buttonOldMethod.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                MainPage.mainPage.buttonOldMethod.FlatAppearance.BorderColor = Color.Gray;
                MainPage.mainPage.buttonOldMethod.ForeColor = SystemColors.ControlText;

                MainPage.mainPage.buttonPerformanceTweak.FlatStyle = FlatStyle.Flat;
                MainPage.mainPage.buttonPerformanceTweak.FlatAppearance.MouseOverBackColor = Color.Gray;
                MainPage.mainPage.buttonPerformanceTweak.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                MainPage.mainPage.buttonPerformanceTweak.FlatAppearance.BorderColor = Color.Gray;
                MainPage.mainPage.buttonPerformanceTweak.ForeColor = SystemColors.ControlText;

                MainPage.mainPage.buttonAbout.FlatStyle = FlatStyle.Flat;
                MainPage.mainPage.buttonAbout.FlatAppearance.MouseOverBackColor = Color.Gray;
                MainPage.mainPage.buttonAbout.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                MainPage.mainPage.buttonAbout.FlatAppearance.BorderColor = Color.Gray;
                MainPage.mainPage.buttonAbout.ForeColor = SystemColors.ControlText;
            }

            if (OldMethodView.oldMethodView != null)
            {

            }

            if (PerformanceTweakView.performanceTweakView != null)
            {

            }

            if (AboutView.aboutView != null)
            {

            }

        }
    }
}
