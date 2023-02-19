using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Minecraft_Launch_Script.Views;

namespace Minecraft_Launch_Script.Helper
{
    public class ThemeHelper
    {
        static readonly MainPage mp = new MainPage();
        static readonly PerformanceTweakView pt = new PerformanceTweakView();
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
    }
}
