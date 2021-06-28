using SendKeyToApp.Objects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SendKeyToApp.Forms
{
    public partial class ShortcutKeys : Form
    {
        public ShortcutKeys()
        {
            InitializeComponent();
        }

        private void Shortcuts_Load(object sender, EventArgs e)
        {
            loadShortcutKeys();
        }
        private void loadShortcutKeys()
        {
            shortcutsPanel.Controls.Clear();
            if (Program.mainForm.ShortcutKeys.Count > 0)
            {
                foreach (ShortcutKey keyShortcut in Program.mainForm.ShortcutKeys)
                {
                    addShortcutKey(keyShortcut);
                }
            }
        }
        private void DeletePictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int index = Convert.ToInt32(pictureBox.Name.Replace("shortcutsDeletePictureBox", ""));
            ShortcutKey shortcutKey = Program.mainForm.ShortcutKeys[index - 1];
            Program.mainForm.DeleteShortcutKey(shortcutKey);
            loadShortcutKeys();
        }
        private void EnablePictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int index = Convert.ToInt32(pictureBox.Name.Replace("shortcutsEnablePictureBox", ""));
            ShortcutKey shortcutKey = Program.mainForm.ShortcutKeys[index - 1];
            if (shortcutKey.IsEnabled)
            {
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Image = Properties.Resources._unchecked;
                Program.mainForm.DisableShortcutKey(shortcutKey);
            }
            else
            {
                pictureBox.BackColor = Color.Lime;
                pictureBox.Image = Properties.Resources._checked;
                Program.mainForm.EnableShortcutKey(shortcutKey);
            }
            shortcutKey.IsEnabled = !shortcutKey.IsEnabled;
            Program.mainForm.Update(Enums.ObjectType.ShortcutKeys);
        }
        private void addShortcutKey(ShortcutKey shortcutKey)
        {
            int index = shortcutsPanel.Controls.Count == 0 ? 1 : 1 + (shortcutsPanel.Controls.Count / 7);
            int y = 3 + (38 * (index - 1));
            PictureBox EnablePictureBox = new PictureBox
            {
                Name = "shortcutsEnablePictureBox" + index,
                Size = new Size(32, 32),
                Location = new Point(3, y),
                Image = Properties.Resources._unchecked,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Label AppNameLabel = new Label
            {
                Name = "shortcutsAppNameLabel" + index,
                AutoSize = false,
                Size = new Size(100, 32),
                Location = new Point(41, y),
                Text = shortcutKey.AppName,
                Font = new Font("Consolas", 8.25f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label InputLabel = new Label
            {
                Name = "shortcutsInputLabel" + index,
                AutoSize = false,
                Size = new Size(160, 32),
                Location = new Point(147, y),
                Text = shortcutKey.InputCombinedKey.ToString(),
                Font = new Font("Consolas", 8.25f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            PictureBox RightArrowPictureBox = new PictureBox
            {
                Name = "shortcutsRightArrowPictureBox" + index,
                Size = new Size(64, 32),
                Location = new Point(313, y),
                Image = Properties.Resources.right_arrow,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Label OutputLabel = new Label
            {
                Name = "shortcutsOutputLabel" + index,
                AutoSize = false,
                Size = new Size(160, 32),
                Location = new Point(383, y),
                Text = shortcutKey.OutputCombinedKey.ToString(),
                Font = new Font("Consolas", 8.25f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label MethodLabel = new Label
            {
                Name = "shortcutsMethodLabel" + index,
                AutoSize = false,
                Size = new Size(140, 32),
                Location = new Point(549, y),
                Text = shortcutKey.MethodName,
                Font = new Font("Consolas", 8.25f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            PictureBox DeletePictureBox = new PictureBox
            {
                Name = "shortcutsDeletePictureBox" + index,
                Size = new Size(32, 32),
                Location = new Point(695, y),
                Image = Properties.Resources.delete,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            EnablePictureBox.Click += EnablePictureBox_Click;
            DeletePictureBox.Click += DeletePictureBox_Click;
            shortcutsPanel.Controls.Add(EnablePictureBox);
            shortcutsPanel.Controls.Add(AppNameLabel);
            shortcutsPanel.Controls.Add(InputLabel);
            shortcutsPanel.Controls.Add(RightArrowPictureBox);
            shortcutsPanel.Controls.Add(OutputLabel);
            shortcutsPanel.Controls.Add(MethodLabel);
            shortcutsPanel.Controls.Add(DeletePictureBox);
            if (shortcutKey.IsEnabled)
            {
                EnablePictureBox.BackColor = Color.Lime;
                EnablePictureBox.Image = Properties.Resources._checked;
            }
        }
    }
}
