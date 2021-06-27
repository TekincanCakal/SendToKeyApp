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
            methodsPanel.Controls.Clear();
            if (Program.mainForm.Methods.Count > 0)
            {
                foreach (Method method in Program.mainForm.Methods)
                {
                    addMethod(method);
                }
            }
        }

        private void addMethod(Method method)
        {
            int i = methodsPanel.Controls.Count == 0 ? 1 : 1 + (methodsPanel.Controls.Count / 5);
            int y = 3 + (38 * (i - 1));
            Label methodsMethodNameLabelTemp = new Label
            {
                Name = "methodsMethodNameLabel" + i,
                AutoSize = false,
                Size = new Size(180, 32),
                Location = new Point(3, y),
                Text = method.Name,
                Font = new Font("Consolas", 9.75f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label methodsMessageMethodLabelTemp = new Label
            {
                Name = "methodsMessageMethodLabel" + i,
                AutoSize = false,
                Size = new Size(180, 32),
                Location = new Point(189, y),
                Text = method.MessageMethod,
                Font = new Font("Consolas", 9.75f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label methodsHandleMethodLabelTemp = new Label
            {
                Name = "methodsHandleMethodLabel" + i,
                AutoSize = false,
                Size = new Size(180, 32),
                Location = new Point(376, y),
                Text = method.HandleMethod,
                Font = new Font("Consolas", 9.75f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label methodsAppClassLabelTemp = new Label
            {
                Name = "methodsAppClassLabel" + i,
                AutoSize = false,
                Size = new Size(128, 32),
                Location = new Point(561, y),
                Text = method.AppClass,
                Font = new Font("Consolas", 9.75f),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            PictureBox methodsDeletePictureBoxTemp = new PictureBox
            {
                Name = "methodsDeletePictureBox" + i,
                Size = new Size(32, 32),
                Location = new Point(695, y),
                Image = Properties.Resources.delete,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            methodsDeletePictureBoxTemp.Click += MethodsDeletePictureBox;
            void MethodsDeletePictureBox(object sender, EventArgs e)
            {
                PictureBox pictureBox = (PictureBox)sender;
                int index = Convert.ToInt32(pictureBox.Name.Replace("methodsDeletePictureBox", ""));
                methodsPanel.Controls.Remove(methodsPanel.Controls["methodsMethodNameLabel" + index]);
                methodsPanel.Controls.Remove(methodsPanel.Controls["methodsMessageMethodLabel" + index]);
                methodsPanel.Controls.Remove(methodsPanel.Controls["methodsHandleMethodLabel" + index]);
                methodsPanel.Controls.Remove(methodsPanel.Controls["methodsAppClassLabel" + index]);
                methodsPanel.Controls.Remove(methodsPanel.Controls["methodsDeletePictureBox" + index]);
                Program.mainForm.Methods.RemoveAt(index - 1);
                Program.mainForm.Update(Enums.ObjectType.Methods);
            }
            methodsPanel.Controls.Add(methodsMethodNameLabelTemp);
            methodsPanel.Controls.Add(methodsMessageMethodLabelTemp);
            methodsPanel.Controls.Add(methodsHandleMethodLabelTemp);
            methodsPanel.Controls.Add(methodsAppClassLabelTemp);
            methodsPanel.Controls.Add(methodsDeletePictureBoxTemp);
        }
    }
}
