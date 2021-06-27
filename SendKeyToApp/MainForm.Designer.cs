
namespace SendKeyToApp
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelLabel = new System.Windows.Forms.Label();
            this.HideButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TopPanelRgbTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.MethodsButton = new System.Windows.Forms.Button();
            this.AddMethodButton = new System.Windows.Forms.Button();
            this.ShortcutKeysButton = new System.Windows.Forms.Button();
            this.AddShortcutKeyButton = new System.Windows.Forms.Button();
            this.SendKeyPressButton = new System.Windows.Forms.Button();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TopPanel.Controls.Add(this.TopPanelLabel);
            this.TopPanel.Controls.Add(this.HideButton);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(970, 30);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // TopPanelLabel
            // 
            this.TopPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanelLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TopPanelLabel.ForeColor = System.Drawing.Color.White;
            this.TopPanelLabel.Location = new System.Drawing.Point(0, 0);
            this.TopPanelLabel.Name = "TopPanelLabel";
            this.TopPanelLabel.Size = new System.Drawing.Size(910, 30);
            this.TopPanelLabel.TabIndex = 4;
            this.TopPanelLabel.Text = "Send Key To App ";
            this.TopPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TopPanelLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanelLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanelLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // HideButton
            // 
            this.HideButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HideButton.ForeColor = System.Drawing.Color.White;
            this.HideButton.Location = new System.Drawing.Point(910, 0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(30, 30);
            this.HideButton.TabIndex = 3;
            this.HideButton.Text = "─";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(940, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "✘";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainNotifyIcon
            // 
            this.MainNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.MainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainNotifyIcon_MouseDoubleClick);
            // 
            // TopPanelRgbTimer
            // 
            this.TopPanelRgbTimer.Interval = 500;
            this.TopPanelRgbTimer.Tick += new System.EventHandler(this.TopPanelRgbTime_Tick);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LeftPanel.Controls.Add(this.SettingsButton);
            this.LeftPanel.Controls.Add(this.MethodsButton);
            this.LeftPanel.Controls.Add(this.AddMethodButton);
            this.LeftPanel.Controls.Add(this.ShortcutKeysButton);
            this.LeftPanel.Controls.Add(this.AddShortcutKeyButton);
            this.LeftPanel.Controls.Add(this.SendKeyPressButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 30);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 370);
            this.LeftPanel.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Location = new System.Drawing.Point(0, 150);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(200, 30);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MethodsButton
            // 
            this.MethodsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MethodsButton.FlatAppearance.BorderSize = 0;
            this.MethodsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MethodsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethodsButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MethodsButton.ForeColor = System.Drawing.Color.White;
            this.MethodsButton.Location = new System.Drawing.Point(0, 120);
            this.MethodsButton.Name = "MethodsButton";
            this.MethodsButton.Size = new System.Drawing.Size(200, 30);
            this.MethodsButton.TabIndex = 5;
            this.MethodsButton.Text = "Methods";
            this.MethodsButton.UseVisualStyleBackColor = true;
            this.MethodsButton.Click += new System.EventHandler(this.MethodsButton_Click);
            // 
            // AddMethodButton
            // 
            this.AddMethodButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddMethodButton.FlatAppearance.BorderSize = 0;
            this.AddMethodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.AddMethodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMethodButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddMethodButton.ForeColor = System.Drawing.Color.White;
            this.AddMethodButton.Location = new System.Drawing.Point(0, 90);
            this.AddMethodButton.Name = "AddMethodButton";
            this.AddMethodButton.Size = new System.Drawing.Size(200, 30);
            this.AddMethodButton.TabIndex = 4;
            this.AddMethodButton.Text = "Add Method";
            this.AddMethodButton.UseVisualStyleBackColor = true;
            this.AddMethodButton.Click += new System.EventHandler(this.AddMethodButton_Click);
            // 
            // ShortcutKeysButton
            // 
            this.ShortcutKeysButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShortcutKeysButton.FlatAppearance.BorderSize = 0;
            this.ShortcutKeysButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ShortcutKeysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShortcutKeysButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShortcutKeysButton.ForeColor = System.Drawing.Color.White;
            this.ShortcutKeysButton.Location = new System.Drawing.Point(0, 60);
            this.ShortcutKeysButton.Name = "ShortcutKeysButton";
            this.ShortcutKeysButton.Size = new System.Drawing.Size(200, 30);
            this.ShortcutKeysButton.TabIndex = 3;
            this.ShortcutKeysButton.Text = "Shortcut Keys";
            this.ShortcutKeysButton.UseVisualStyleBackColor = true;
            this.ShortcutKeysButton.Click += new System.EventHandler(this.ShortcutKeysButton_Click);
            // 
            // AddShortcutKeyButton
            // 
            this.AddShortcutKeyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddShortcutKeyButton.FlatAppearance.BorderSize = 0;
            this.AddShortcutKeyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.AddShortcutKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddShortcutKeyButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddShortcutKeyButton.ForeColor = System.Drawing.Color.White;
            this.AddShortcutKeyButton.Location = new System.Drawing.Point(0, 30);
            this.AddShortcutKeyButton.Name = "AddShortcutKeyButton";
            this.AddShortcutKeyButton.Size = new System.Drawing.Size(200, 30);
            this.AddShortcutKeyButton.TabIndex = 2;
            this.AddShortcutKeyButton.Text = "Add Shortcut Key";
            this.AddShortcutKeyButton.UseVisualStyleBackColor = true;
            this.AddShortcutKeyButton.Click += new System.EventHandler(this.AddShortcutKeyButton_Click);
            // 
            // SendKeyPressButton
            // 
            this.SendKeyPressButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SendKeyPressButton.FlatAppearance.BorderSize = 0;
            this.SendKeyPressButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SendKeyPressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendKeyPressButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SendKeyPressButton.ForeColor = System.Drawing.Color.White;
            this.SendKeyPressButton.Location = new System.Drawing.Point(0, 0);
            this.SendKeyPressButton.Name = "SendKeyPressButton";
            this.SendKeyPressButton.Size = new System.Drawing.Size(200, 30);
            this.SendKeyPressButton.TabIndex = 0;
            this.SendKeyPressButton.Text = "Send Key Press";
            this.SendKeyPressButton.UseVisualStyleBackColor = true;
            this.SendKeyPressButton.Click += new System.EventHandler(this.SendKeyPressButton_Click);
            // 
            // MidPanel
            // 
            this.MidPanel.BackColor = System.Drawing.Color.Red;
            this.MidPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidPanel.Location = new System.Drawing.Point(200, 30);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(770, 370);
            this.MidPanel.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 48);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 400);
            this.Controls.Add(this.MidPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "SendKeyToApp";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.TopPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.NotifyIcon MainNotifyIcon;
        public System.Windows.Forms.Timer TopPanelRgbTimer;
        public System.Windows.Forms.Panel TopPanel;
        public System.Windows.Forms.Button HideButton;
        public System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.Label TopPanelLabel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button SendKeyPressButton;
        private System.Windows.Forms.Panel MidPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button MethodsButton;
        private System.Windows.Forms.Button AddMethodButton;
        private System.Windows.Forms.Button ShortcutKeysButton;
        private System.Windows.Forms.Button AddShortcutKeyButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

