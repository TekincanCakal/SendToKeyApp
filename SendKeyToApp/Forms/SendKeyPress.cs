using SendKeyToApp.Enums;
using SendKeyToApp.Objects;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SendKeyToApp.Forms
{
    public partial class SendKeyPress : Form
    {
        public SendKeyPress()
        {
            InitializeComponent();
        }

        private MessageMethod SelectedMessageMethod = MessageMethod.Post;
        private HandleMethod SelectedHandleMethod = HandleMethod.FindWindowEx;

        private void SendKeyPress_Load(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcesses())
            {
                SelectAppComboBox.Items.Add(String.Format("{0}-{1}", process.ProcessName, process.Id));
            }
            SelectAppComboBox.SelectedIndex = 0;

            foreach (Keys key in SendKey.SendKeys)
            {
                InputKeyComboBox.Items.Add(key);
            }
            InputKeyComboBox.SelectedIndex = 0;
        }
        private void PostMessageButton_Click(object sender, EventArgs e)
        {
            PostMessageButton.Enabled = false;
            SendMessageButton.Enabled = true;

            PostMessageButton.BackColor = Color.Lime;
            SendMessageButton.BackColor = Color.Red;

            SelectedMessageMethod = MessageMethod.Post;
        }
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            PostMessageButton.Enabled = true;
            SendMessageButton.Enabled = false;

            PostMessageButton.BackColor = Color.Red;
            SendMessageButton.BackColor = Color.Lime;

            SelectedMessageMethod = MessageMethod.Send;
        }
        private void FindWindowExButton_Click(object sender, EventArgs e)
        {
            FindWindowExButton.Enabled = false;
            FindWindowButton.Enabled = true;
            ProcessHandleButton.Enabled = true;

            FindWindowExButton.BackColor = Color.Lime;
            FindWindowButton.BackColor = Color.Red;
            ProcessHandleButton.BackColor = Color.Red;

            SelectedHandleMethod = HandleMethod.FindWindowEx;

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

            SelectedHandleMethod = HandleMethod.FindWindow;

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

            SelectedHandleMethod = HandleMethod.ProcessHandle;

            AppClassTextBox.Enabled = false;
        }
        private void RefreshPictureBox_Click(object sender, EventArgs e)
        {
            SelectAppComboBox.Items.Clear();
            foreach (Process process in Process.GetProcesses())
            {
                SelectAppComboBox.Items.Add(String.Format("{0}-{1}", process.ProcessName, process.Id));
            }
            SelectAppComboBox.SelectedIndex = 0;
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            String appClass = null;
            if (AppClassTextBox.Enabled)
            {
                appClass = AppClassTextBox.Text;
            }
            String appName = ((String)SelectAppComboBox.SelectedItem).Split('-')[0];
            Process proc = Process.GetProcesses().First(x => x.ProcessName == appName);
            if (proc == null)
            {
                MessageBox.Show("App Is Not Running");
                return;
            }
            Keys selectedKey = (Keys)InputKeyComboBox.SelectedItem;
            bool isCtrl = InputCtrlButton.BackColor == Color.Lime;
            bool isShift = InputShiftButton.BackColor == Color.Lime;
            bool isAlt = InputAltButton.BackColor == Color.Lime;
            if (selectedKey != Keys.None)
            {
                SendKey.SendKeyPressToApp(proc, new CombinedKey(selectedKey, isCtrl, isShift, isAlt), new Method(SelectedMessageMethod, SelectedHandleMethod, appClass, ""));
            }
            Enabled = true;
        }
    }
}
