using SendKeyToApp.Enums;
using SendKeyToApp.Objects;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SendKeyToApp.Forms
{
    public partial class AddKeyShortcut : Form
    {
        public AddKeyShortcut()
        {
            InitializeComponent();
        }
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
            foreach (Keys key in SendKey.SendKeys)
            {
                InputComboBox.Items.Add(key);
                OutputComboBox.Items.Add(key);
            }
            SelectAppComboBox.SelectedIndex = 0;
            InputComboBox.SelectedIndex = 0;
            OutputComboBox.SelectedIndex = 0;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            String appName = SelectAppComboBox.SelectedItem.ToString().Split('-')[0];

            Keys inputKey = (Keys)InputComboBox.SelectedItem;
            bool inputIsCtrl = InputCtrlButton.BackColor == Color.Lime;
            bool inputIsShift = InputShiftButton.BackColor == Color.Lime;
            bool inputIsAlt = InputAltButton.BackColor == Color.Lime;

            Keys outputKey = (Keys)OutputComboBox.SelectedItem;
            bool outputIsCtrl = OutputCtrlButton.BackColor == Color.Lime;
            bool outputIsShift = OutputShiftButton.BackColor == Color.Lime;
            bool outputIsAlt = OutputAltButton.BackColor == Color.Lime;

            String methodName = (String)MethodComboBox.SelectedItem;
            Method method = Program.mainForm.Methods.First(x => x.Name == methodName);
            CombinedKey inputCombinedKey = new CombinedKey(inputKey, inputIsCtrl, inputIsShift, inputIsAlt);
            CombinedKey outputCombinedKey = new CombinedKey(outputKey, outputIsCtrl, outputIsShift, outputIsAlt);
            Objects.ShortcutKeys keyShortcut = new Objects.ShortcutKeys(appName, method, inputCombinedKey, outputCombinedKey);
            foreach (Objects.ShortcutKeys temp in Program.mainForm.ShortcutKeys)
            {
                if (keyShortcut.Equals(temp))
                {
                    MessageBox.Show("This KeyShortcut Already Exist");
                    return;
                }
            }
            Program.mainForm.ShortcutKeys.Add(keyShortcut);
            Program.mainForm.Update(ObjectType.ShortcutKeys);
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
    }
}
