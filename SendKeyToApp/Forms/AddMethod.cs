using SendKeyToApp.Enums;
using SendKeyToApp.Objects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SendKeyToApp.Forms
{
    public partial class AddMethod : Form
    {
        public AddMethod()
        {
            InitializeComponent();
        }
        MessageMethod addNewMethodSelectedMessageMethod = MessageMethod.Post;
        HandleMethod addNewMethodSelectedHandleMethod = HandleMethod.FindWindowEx;

        private void PostMessageButton_Click(object sender, EventArgs e)
        {
            PostMessageButton.Enabled = false;
            SendMessageButton.Enabled = true;

            PostMessageButton.BackColor = Color.Lime;
            SendMessageButton.BackColor = Color.Red;

            addNewMethodSelectedMessageMethod = MessageMethod.Post;
        }
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            PostMessageButton.Enabled = true;
            SendMessageButton.Enabled = false;

            PostMessageButton.BackColor = Color.Red;
            SendMessageButton.BackColor = Color.Lime;

            addNewMethodSelectedMessageMethod = MessageMethod.Send;
        }
        private void FindWindowExButton_Click(object sender, EventArgs e)
        {
            FindWindowExButton.Enabled = false;
            FindWindowButton.Enabled = true;
            ProcessHandleButton.Enabled = true;

            FindWindowExButton.BackColor = Color.Lime;
            FindWindowButton.BackColor = Color.Red;
            ProcessHandleButton.BackColor = Color.Red;

            addNewMethodSelectedHandleMethod = HandleMethod.FindWindowEx;

            AppClassTextBox.Enabled = true;
        }
        private void FindWindowButton_Click(object sender, EventArgs e)
        {
            FindWindowExButton.Enabled = true;
            FindWindowButton.Enabled = false;
            ProcessHandleButton.Enabled = true;

            FindWindowExButton.BackColor = Color.Red;
            FindWindowButton.BackColor = Color.Lime;
            ProcessHandleButton.BackColor = Color.Red;

            addNewMethodSelectedHandleMethod = HandleMethod.FindWindow;

            AppClassTextBox.Enabled = false;
        }
        private void ProcessHandleButton_Click(object sender, EventArgs e)
        {
            FindWindowExButton.Enabled = true;
            FindWindowButton.Enabled = true;
            ProcessHandleButton.Enabled = false;

            FindWindowExButton.BackColor = Color.Red;
            FindWindowButton.BackColor = Color.Red;
            ProcessHandleButton.BackColor = Color.Lime;

            addNewMethodSelectedHandleMethod = HandleMethod.ProcessHandle;

            AppClassTextBox.Enabled = false;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            String appClass = AppClassTextBox.Text;
            String methodName = NameTextBox.Text;

            if (methodName.Length == 0)
            {
                MessageBox.Show("Method Name Can't Be Empty");
                return;
            }
            if (addNewMethodSelectedHandleMethod == HandleMethod.FindWindowEx && appClass.Length == 0)
            {
                MessageBox.Show("App Class Can't Be Empty When FindWindowEx Selected");
                return;
            }
            Method method = new Method(addNewMethodSelectedMessageMethod, addNewMethodSelectedHandleMethod, appClass, methodName);
            foreach (Method temp in Program.mainForm.Methods)
            {
                if (temp.Name == method.Name)
                {
                    MessageBox.Show("This Method Name Already Exist");
                    return;
                }
                if (method.Equals(temp))
                {
                    MessageBox.Show("This Method Already Exist");
                    return;
                }
            }
            Program.mainForm.Methods.Add(method);
            Program.mainForm.Update(ObjectType.Methods);
        }
    }
}
