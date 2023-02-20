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
        //public MainPage mainPage = new MainPage();
        public static void DarkThemeButtons()
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
    }
}
