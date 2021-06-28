using SendKeyToApp.Objects;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SendKeyToApp.Forms
{
    public partial class AddShortcutKey : Form
    {
        public AddShortcutKey()
        {
            InitializeComponent();
        }
        Keys InputKey = Keys.None;
        Keys OutputKey = Keys.None;
        private void AddNewShortcut_Load(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcesses())
            {
                SelectAppComboBox.Items.Add(String.Format("{0}-{1}", process.ProcessName, process.Id));
            }
            if (Program.mainForm.Methods.Count > 0)
            {
                foreach (Method method in Program.mainForm.Methods)
                {
                    MethodComboBox.Items.Add(method.Name);
                }
                MethodComboBox.SelectedIndex = 0;
            }
            SelectAppComboBox.SelectedIndex = 0;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            String appName = SelectAppComboBox.SelectedItem.ToString().Split('-')[0];

            if(InputKey == Keys.None)
            {
                MessageBox.Show("Input Key Can't Be Empty");
                return;
            }
           
            if (OutputKey == Keys.None)
            {
                MessageBox.Show("Output Key Can't Be Empty");
                return;
            }

            bool inputIsCtrl = InputCtrlButton.BackColor == Color.Lime;
            bool inputIsShift = InputShiftButton.BackColor == Color.Lime;
            bool inputIsAlt = InputAltButton.BackColor == Color.Lime;


            bool outputIsCtrl = OutputCtrlButton.BackColor == Color.Lime;
            bool outputIsShift = OutputShiftButton.BackColor == Color.Lime;
            bool outputIsAlt = OutputAltButton.BackColor == Color.Lime;

            if(MethodComboBox.SelectedItem == null)
            {
                MessageBox.Show("You Have To Select Method");
                return;
            }

            String methodName = (String)MethodComboBox.SelectedItem;
            CombinedKey inputCombinedKey = new CombinedKey(InputKey, inputIsCtrl, inputIsShift, inputIsAlt);
            CombinedKey outputCombinedKey = new CombinedKey(OutputKey, outputIsCtrl, outputIsShift, outputIsAlt);
            ShortcutKey keyShortcut = new ShortcutKey(appName, methodName, inputCombinedKey, outputCombinedKey);
            foreach (ShortcutKey shortcutKey in Program.mainForm.ShortcutKeys)
            {
                if (keyShortcut.Equals(shortcutKey))
                {
                    MessageBox.Show("This KeyShortcut Already Exist");
                    return;
                }
            }
            Program.mainForm.AddShortcutKey(keyShortcut);
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
        private void ColorButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = (button.BackColor == Color.Lime) ? Color.Red : Color.Lime;
        }

        private async void InputListenKeyButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            again:
            Keys pressedKey = await Program.mainForm.KeyListener.ListenKey();
            if(pressedKey == Keys.LShiftKey || pressedKey == Keys.RShiftKey || pressedKey == Keys.ShiftKey || pressedKey == Keys.Shift || pressedKey == Keys.LControlKey || pressedKey == Keys.RControlKey || pressedKey == Keys.ControlKey || pressedKey == Keys.Control || pressedKey == Keys.Alt)
            {
                goto again;
            }
            InputListenKeyButton.Text = pressedKey.ToString();
            InputKey = pressedKey;
            Enabled = true;
        }

        private async void OutputListenKeyButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            again:
            Keys pressedKey = await Program.mainForm.KeyListener.ListenKey();
            if (pressedKey == Keys.LShiftKey || pressedKey == Keys.RShiftKey || pressedKey == Keys.ShiftKey || pressedKey == Keys.Shift || pressedKey == Keys.LControlKey || pressedKey == Keys.RControlKey || pressedKey == Keys.ControlKey || pressedKey == Keys.Control || pressedKey == Keys.Alt)
            {
                goto again;
            }
            OutputListenKeyButton.Text = pressedKey.ToString();
            OutputKey = pressedKey;
            Enabled = true;
        }
    }
}
