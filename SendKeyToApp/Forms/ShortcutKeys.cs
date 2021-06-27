using SendKeyToApp.Objects;
using System;
using System.Diagnostics;
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
            shortcutsPanel.Controls.Clear();
            if (Program.mainForm.ShortcutKeys.Count > 0)
            {
                foreach (Objects.ShortcutKeys keyShortcut in Program.mainForm.ShortcutKeys)
                {
                    addKeyShortcuts(keyShortcut);
                }
            }
        }
        private void addKeyShortcuts(Objects.ShortcutKeys keyShortcut)
        {
            int i = shortcutsPanel.Controls.Count == 0 ? 1 : 1 + (shortcutsPanel.Controls.Count / 7);
            int y = 3 + (38 * (i - 1));
            PictureBox shortcutsEnablePictureBoxTemp = new PictureBox
            {
                Name = "shortcutsEnablePictureBox" + i,
                Size = new Size(32, 32),
                Location = new Point(3, y),
                Image = Properties.Resources._unchecked,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Label shortcutsAppNameLabelTemp = new Label
            {
                Name = "shortcutsAppNameLabel" + i,
                AutoSize = false,
                Size = new Size(100, 32),
                Location = new Point(41, y),
                Text = keyShortcut.AppName,
                Font = new Font("Consolas", 8.25f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label shortcutsInputLabelTemp = new Label
            {
                Name = "shortcutsInputLabel" + i,
                AutoSize = false,
                Size = new Size(160, 32),
                Location = new Point(147, y),
                Text = keyShortcut.InputCombinedKey.ToString(),
                Font = new Font("Consolas", 8.25f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            PictureBox shortcutsRightArrowPictureBoxTemp = new PictureBox
            {
                Name = "shortcutsRightArrowPictureBox" + i,
                Size = new Size(64, 32),
                Location = new Point(313, y),
                Image = Properties.Resources.right_arrow,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Label shortcutsOutputLabelTemp = new Label
            {
                Name = "shortcutsOutputLabel" + i,
                AutoSize = false,
                Size = new Size(160, 32),
                Location = new Point(383, y),
                Text = keyShortcut.OutputCombinedKey.ToString(),
                Font = new Font("Consolas", 8.25f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label shortcutsMethodLabelTemp = new Label
            {
                Name = "shortcutsMethodLabel" + i,
                AutoSize = false,
                Size = new Size(140, 32),
                Location = new Point(549, y),
                Text = keyShortcut.Method.Name,
                Font = new Font("Consolas", 8.25f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            PictureBox shortcutsDeletePictureBoxTemp = new PictureBox
            {
                Name = "shortcutsDeletePictureBox" + i,
                Size = new Size(32, 32),
                Location = new Point(695, y),
                Image = Properties.Resources.delete,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            shortcutsEnablePictureBoxTemp.Click += ShortcutsEnablePictureBoxTemp;
            shortcutsDeletePictureBoxTemp.Click += ShortcutsDeletePictureBoxTemp_Click;
            void ShortcutsDeletePictureBoxTemp_Click(object sender, EventArgs e)
            {
                PictureBox pictureBox = (PictureBox)sender;
                int index = Convert.ToInt32(pictureBox.Name.Replace("shortcutsDeletePictureBox", ""));
                shortcutsPanel.Controls.Remove(shortcutsPanel.Controls["shortcutsEnablePictureBox" + index]);
                shortcutsPanel.Controls.Remove(shortcutsPanel.Controls["shortcutsAppNameLabel" + index]);
                shortcutsPanel.Controls.Remove(shortcutsPanel.Controls["shortcutsInputLabel" + index]);
                shortcutsPanel.Controls.Remove(shortcutsPanel.Controls["shortcutsRightArrowPictureBox" + index]);
                shortcutsPanel.Controls.Remove(shortcutsPanel.Controls["shortcutsOutputLabel" + index]);
                shortcutsPanel.Controls.Remove(shortcutsPanel.Controls["shortcutsMethodLabel" + index]);
                shortcutsPanel.Controls.Remove(shortcutsPanel.Controls["shortcutsDeletePictureBox" + index]);
                Program.mainForm.ShortcutKeys.RemoveAt(index - 1);
                Program.mainForm.Update(Enums.ObjectType.ShortcutKeys);
            }
            void ShortcutsEnablePictureBoxTemp(object sender, EventArgs e)
            {
                PictureBox pictureBox = (PictureBox)sender;
                int index = Convert.ToInt32(pictureBox.Name.Replace("shortcutsEnablePictureBox", ""));
                Objects.ShortcutKeys selectedKeyShortcut = Program.mainForm.ShortcutKeys[index - 1];
                if (pictureBox.BackColor == Color.Transparent)
                {
                    pictureBox.BackColor = Color.Lime;
                    pictureBox.Image = Properties.Resources._checked;
                    void onPress()
                    {
                        this.Invoke(new Action(delegate
                        {
                            foreach (Process process in Process.GetProcesses())
                            {
                                if (process.ProcessName == selectedKeyShortcut.AppName)
                                {
                                    SendKey.SendKeyPressToApp(process, selectedKeyShortcut.OutputCombinedKey, selectedKeyShortcut.Method);
                                    return;
                                }
                            }
                        }));
                    }
                    Program.mainForm.KeyListener.ListenCombinedKey(selectedKeyShortcut.InputCombinedKey, new KeyActions(onPress, null));
                    Program.mainForm.ShortcutKeys[index - 1].IsEnabled = true;
                }
                else
                {
                    pictureBox.BackColor = Color.Transparent;
                    pictureBox.Image = Properties.Resources._unchecked;
                    Program.mainForm.KeyListener.UnListenCombinedKey(selectedKeyShortcut.InputCombinedKey);
                    Program.mainForm.ShortcutKeys[index - 1].IsEnabled = false;
                }
                Program.mainForm.Update(Enums.ObjectType.ShortcutKeys);
            }
            shortcutsPanel.Controls.Add(shortcutsEnablePictureBoxTemp);
            shortcutsPanel.Controls.Add(shortcutsAppNameLabelTemp);
            shortcutsPanel.Controls.Add(shortcutsInputLabelTemp);
            shortcutsPanel.Controls.Add(shortcutsRightArrowPictureBoxTemp);
            shortcutsPanel.Controls.Add(shortcutsOutputLabelTemp);
            shortcutsPanel.Controls.Add(shortcutsMethodLabelTemp);
            shortcutsPanel.Controls.Add(shortcutsDeletePictureBoxTemp);
            if (keyShortcut.IsEnabled)
            {
                ShortcutsEnablePictureBoxTemp(shortcutsPanel.Controls["shortcutsEnablePictureBox" + i], new EventArgs());
            }
        }
    }
}
