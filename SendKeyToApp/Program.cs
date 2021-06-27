using SendKeyToApp.Other;
using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace SendKeyToApp
{
    static class Program
    {
        public static MainForm mainForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            runAdmin();
        }
        public static void runAdmin()
        {
            var wi = WindowsIdentity.GetCurrent();
            var wp = new WindowsPrincipal(wi);
            bool runAsAdmin = wp.IsInRole(WindowsBuiltInRole.Administrator);
            if (!runAsAdmin)
            {
                MessageBox.Show("Admin Yetkisini Vermedin, Program Kapatılıyor");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                mainForm = new MainForm();
                loadIcon();
                Application.Run(mainForm);
            }
        }
        public static void loadIcon()
        {
            if (mainForm.Settings.IconBase64 != "")
            {
                mainForm.Icon = Utils.Base64ToBitmap(Objects.Settings.DefaultIconBase64);
            }
            else
            {
                mainForm.Icon = Properties.Resources.formicon;
            }
            mainForm.MainNotifyIcon.Icon = mainForm.Icon;
        }
    }
}
