using SendKeyToApp.Other;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SendKeyToApp.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            settingsIconToolTip.SetToolTip(IconPictureBox, "Click For Change");
            IconPictureBox.Image = Program.mainForm.Icon.ToBitmap();
            RgbTopBarCheckBox.Checked = Program.mainForm.Settings.RgbTopBar;
        }

        private void IconPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files | *ico;";
            openFileDialog.Title = "Select New Icon File";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap newIcon = new Bitmap(openFileDialog.FileName);
                Program.mainForm.Settings.IconBase64 = Utils.BitmapToBase64(newIcon);
                Program.mainForm.Update(Enums.ObjectType.Settings);
                Program.loadIcon();
            }
        }

        private void RgbTopBarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RgbTopBarCheckBox.Checked)
            {
                Program.mainForm.TopPanelRgbTimer.Start();
            }
            else
            {
                Program.mainForm.TopPanelRgbTimer.Stop();
                Program.mainForm.TopPanel.BackColor = Color.FromArgb(34, 34, 34);
                Program.mainForm.TopPanelLabel.ForeColor = Color.White;
                Program.mainForm.HideButton.ForeColor = Color.White;
                Program.mainForm.ExitButton.ForeColor = Color.White;
            }
            Program.mainForm.Settings.RgbTopBar = RgbTopBarCheckBox.Checked;
            Program.mainForm.Update(Enums.ObjectType.Settings);
        }

        private void TopMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Program.mainForm.TopMost = TopMostCheckBox.Checked;
        }
    }
}
