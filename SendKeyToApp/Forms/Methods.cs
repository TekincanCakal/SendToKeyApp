using SendKeyToApp.Objects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SendKeyToApp.Forms
{
    public partial class Methods : Form
    {
        public Methods()
        {
            InitializeComponent();
        }

        private void Methods_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            methodsPanel.Controls.Clear();
            if (Program.mainForm.Methods.Count > 0)
            {
                foreach (Method method in Program.mainForm.Methods)
                {
                    addMethod(method);
                }
            }
        }
        void DeletePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "All Shortcut Keys attached To This Method Will Be Deleted", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PictureBox pictureBox = (PictureBox)sender;
                int index = Convert.ToInt32(pictureBox.Name.Replace("methodsDeletePictureBox", ""));
                Method method = Program.mainForm.Methods[index - 1];
                foreach (ShortcutKey shortcutKey in Program.mainForm.ShortcutKeys.ToArray())
                {
                    if (shortcutKey.MethodName == method.Name)
                    {
                        Program.mainForm.DeleteShortcutKey(shortcutKey);
                    }
                }
                Program.mainForm.DeleteMethod(method);
                load();
            }
        }
        private void addMethod(Method method)
        {
            int index = methodsPanel.Controls.Count == 0 ? 1 : 1 + (methodsPanel.Controls.Count / 5);
            int y = 3 + (38 * (index - 1));
            Label MethodNameLabel = new Label
            {
                Name = "methodsMethodNameLabel" + index,
                AutoSize = false,
                Size = new Size(180, 32),
                Location = new Point(3, y),
                Text = method.Name,
                Font = new Font("Consolas", 9.75f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label MessageMethodLabel = new Label
            {
                Name = "methodsMessageMethodLabel" + index,
                AutoSize = false,
                Size = new Size(180, 32),
                Location = new Point(189, y),
                Text = method.MessageMethod,
                Font = new Font("Consolas", 9.75f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label HandleMethodLabel = new Label
            {
                Name = "methodsHandleMethodLabel" + index,
                AutoSize = false,
                Size = new Size(180, 32),
                Location = new Point(376, y),
                Text = method.HandleMethod,
                Font = new Font("Consolas", 9.75f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label AppClassLabel = new Label
            {
                Name = "methodsAppClassLabel" + index,
                AutoSize = false,
                Size = new Size(128, 32),
                Location = new Point(561, y),
                Text = method.AppClass,
                Font = new Font("Consolas", 9.75f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            PictureBox DeletePictureBox = new PictureBox
            {
                Name = "methodsDeletePictureBox" + index,
                Size = new Size(32, 32),
                Location = new Point(695, y),
                Image = Properties.Resources.delete,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            DeletePictureBox.Click += DeletePictureBox_Click;
            methodsPanel.Controls.Add(MethodNameLabel);
            methodsPanel.Controls.Add(MessageMethodLabel);
            methodsPanel.Controls.Add(HandleMethodLabel);
            methodsPanel.Controls.Add(AppClassLabel);
            methodsPanel.Controls.Add(DeletePictureBox);
        }
    }
}
