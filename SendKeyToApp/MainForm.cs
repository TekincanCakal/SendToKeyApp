using Newtonsoft.Json;
using SendKeyToApp.Enums;
using SendKeyToApp.Forms;
using SendKeyToApp.Objects;
using SendKeyToApp.Other;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static SendKeyToApp.Objects.WinApi;

namespace SendKeyToApp
{
    public partial class MainForm : Form
    {
        public Random random = new Random();
        public KeyListener KeyListener;
        public List<ShortcutKey> ShortcutKeys;
        public List<Method> Methods;
        public Objects.Settings Settings;

        public MainForm()
        {
            InitializeComponent();
            KeyListener = new KeyListener();
            initFiles();
        }
        private void initFiles()
        {
            foreach (ObjectType objectType in Enum.GetValues(typeof(ObjectType)))
            {
                Init(objectType);
            }
            foreach(ShortcutKey shortcutKey in ShortcutKeys)
            {
                Method method = GetMethod(shortcutKey.MethodName);
                if(method == null)
                {
                    DeleteShortcutKey(shortcutKey);
                }
                else
                {
                    if (shortcutKey.IsEnabled)
                    {
                        EnableShortcutKey(shortcutKey);
                    }
                }
            }
        }
        public void Init(ObjectType objectType)
        {
            String file = Application.StartupPath + "\\" + objectType + ".json";
            if (File.Exists(file))
            {
                String fileInput = File.ReadAllText(file);
                if (objectType == ObjectType.Methods)
                {
                    Methods = JsonConvert.DeserializeObject<List<Method>>(fileInput);
                }
                else if (objectType == ObjectType.Settings)
                {
                    Settings = JsonConvert.DeserializeObject<Objects.Settings>(File.ReadAllText(file));
                    if (Settings.RgbTopBar)
                    {
                        TopPanelRgbTimer.Start();
                    }
                }
                else if (objectType == ObjectType.ShortcutKeys)
                {
                    ShortcutKeys = JsonConvert.DeserializeObject<List<ShortcutKey>>(File.ReadAllText(file));
                }
            }
            else
            {
                if (objectType == ObjectType.Methods)
                {
                    Methods = new List<Method>();
                }
                else if (objectType == ObjectType.Settings)
                {
                    Settings = new Objects.Settings();
                    Settings.IconBase64 = Objects.Settings.DefaultIconBase64;
                    Settings.RgbTopBar = Objects.Settings.DefaultRgbTopBar;
                }
                else if (objectType == ObjectType.ShortcutKeys)
                {
                    ShortcutKeys = new List<Objects.ShortcutKey>();
                }
                Update(objectType);
            }
        }
        public void Update(ObjectType objectType)
        {
            var json = "";
            if (objectType == ObjectType.Methods)
            {
                json = JsonConvert.SerializeObject(Methods, Formatting.Indented);
            }
            else if (objectType == ObjectType.Settings)
            {
                json = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            }
            else if (objectType == ObjectType.ShortcutKeys)
            {
                json = JsonConvert.SerializeObject(ShortcutKeys, Formatting.Indented);
            }
            String file = Application.StartupPath + "\\" + objectType + ".json";
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(json);
            }
        }

        public Method GetMethod(String MethodName)
        {
            foreach(Method method in Methods)
            {
                if(method.Name == MethodName)
                {
                    return method;
                }
            }
            return null;
        }
        public void AddShortcutKey(ShortcutKey shortcutKey)
        {
            ShortcutKeys.Add(shortcutKey);
            
            Update(ObjectType.ShortcutKeys);
        }
        public void DeleteShortcutKey(ShortcutKey shortcutKey)
        {
            DisableShortcutKey(shortcutKey);
            ShortcutKeys.Remove(shortcutKey);
            Update(ObjectType.ShortcutKeys);
        }
        public void AddMethod(Method method)
        {
            Methods.Add(method);
            Update(ObjectType.Methods);
        }
        public void DeleteMethod(Method method)
        {
            foreach(ShortcutKey shortcutKey in ShortcutKeys)
            {
                if(shortcutKey.MethodName == method.Name)
                {
                    DeleteShortcutKey(shortcutKey);
                }
            }
            Methods.Remove(method);
            Update(ObjectType.Methods);
        }
        public void EnableShortcutKey(ShortcutKey shortcutKey)
        {
            Action onPress = new Action(delegate
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName == shortcutKey.AppName)
                    {
                        Method method = Program.mainForm.GetMethod(shortcutKey.MethodName);
                        Utils.SendKeyPressToApp(process, shortcutKey.OutputCombinedKey, method);
                        return;
                    }
                }
            });
            KeyListener.ListenCombinedKey(shortcutKey.InputCombinedKey, new KeyActions(onPress, null));
        }
        public void DisableShortcutKey(ShortcutKey shortcutKey)
        {
           KeyListener.UnListenCombinedKey(shortcutKey.InputCombinedKey);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            SetForegroundWindow(Handle);
            OpenForm(new SendKeyPress());
        }
        private void MainNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Show();
        }
        public void OpenForm(Form form)
        {
            MidPanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            MidPanel.Controls.Add(form);
            form.Show();
        }
        private void SendKeyPressButton_Click(object sender, EventArgs e)
        {
            OpenForm(new SendKeyPress());
        }
        private void AddShortcutKeyButton_Click(object sender, EventArgs e)
        {
            OpenForm(new AddShortcutKey());
        }
        private void ShortcutKeysButton_Click(object sender, EventArgs e)
        {
            OpenForm(new ShortcutKeys());
        }
        private void AddMethodButton_Click(object sender, EventArgs e)
        {
            OpenForm(new AddMethod());
        }
        private void MethodsButton_Click(object sender, EventArgs e)
        {
            OpenForm(new Methods());
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Settings());
        }
        #region TopPanel
        Point mousedownpoint = Point.Empty;
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mousedownpoint.IsEmpty)
            {
                Location = new Point(Location.X + (e.X - mousedownpoint.X), Location.Y + (e.Y - mousedownpoint.Y));
            }
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainNotifyIcon.Visible = true;
        }
        private void TopPanelRgbTime_Tick(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            TopPanel.BackColor = color;
            double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
            if (luminance > 0.5)
            {
                TopPanelLabel.ForeColor = Color.Black;
                HideButton.ForeColor = Color.Black;
                ExitButton.ForeColor = Color.Black;
            }
            else
            {
                TopPanelLabel.ForeColor = Color.White;
                HideButton.ForeColor = Color.White;
                ExitButton.ForeColor = Color.White;
            }
        }
        #endregion

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teqin");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
