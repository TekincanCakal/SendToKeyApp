
namespace SendKeyToApp.Forms
{
    partial class SendKeyPress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputKeyComboBox = new System.Windows.Forms.ComboBox();
            this.InputAltButton = new System.Windows.Forms.Button();
            this.InputShiftButton = new System.Windows.Forms.Button();
            this.InputCtrlButton = new System.Windows.Forms.Button();
            this.InputMethodLabel = new System.Windows.Forms.Label();
            this.RefreshPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectAppComboBox = new System.Windows.Forms.ComboBox();
            this.AppClassLabel = new System.Windows.Forms.Label();
            this.AppClassTextBox = new System.Windows.Forms.TextBox();
            this.HandleMethodLabel = new System.Windows.Forms.Label();
            this.ProcessHandleButton = new System.Windows.Forms.Button();
            this.FindWindowButton = new System.Windows.Forms.Button();
            this.FindWindowExButton = new System.Windows.Forms.Button();
            this.MessageMethodLabel = new System.Windows.Forms.Label();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.PostMessageButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.AppLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InputKeyComboBox
            // 
            this.InputKeyComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InputKeyComboBox.FormattingEnabled = true;
            this.InputKeyComboBox.Location = new System.Drawing.Point(280, 70);
            this.InputKeyComboBox.Name = "InputKeyComboBox";
            this.InputKeyComboBox.Size = new System.Drawing.Size(230, 30);
            this.InputKeyComboBox.TabIndex = 50;
            // 
            // InputAltButton
            // 
            this.InputAltButton.BackColor = System.Drawing.Color.Red;
            this.InputAltButton.FlatAppearance.BorderSize = 0;
            this.InputAltButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputAltButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InputAltButton.Location = new System.Drawing.Point(680, 70);
            this.InputAltButton.Name = "InputAltButton";
            this.InputAltButton.Size = new System.Drawing.Size(70, 30);
            this.InputAltButton.TabIndex = 49;
            this.InputAltButton.Text = "ALT";
            this.InputAltButton.UseVisualStyleBackColor = false;
            // 
            // InputShiftButton
            // 
            this.InputShiftButton.BackColor = System.Drawing.Color.Red;
            this.InputShiftButton.FlatAppearance.BorderSize = 0;
            this.InputShiftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputShiftButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InputShiftButton.Location = new System.Drawing.Point(600, 70);
            this.InputShiftButton.Name = "InputShiftButton";
            this.InputShiftButton.Size = new System.Drawing.Size(70, 30);
            this.InputShiftButton.TabIndex = 48;
            this.InputShiftButton.Text = "SHIFT";
            this.InputShiftButton.UseVisualStyleBackColor = false;
            // 
            // InputCtrlButton
            // 
            this.InputCtrlButton.BackColor = System.Drawing.Color.Red;
            this.InputCtrlButton.FlatAppearance.BorderSize = 0;
            this.InputCtrlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputCtrlButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InputCtrlButton.Location = new System.Drawing.Point(520, 70);
            this.InputCtrlButton.Name = "InputCtrlButton";
            this.InputCtrlButton.Size = new System.Drawing.Size(70, 30);
            this.InputCtrlButton.TabIndex = 47;
            this.InputCtrlButton.Text = "CTRL";
            this.InputCtrlButton.UseVisualStyleBackColor = false;
            // 
            // InputMethodLabel
            // 
            this.InputMethodLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InputMethodLabel.Location = new System.Drawing.Point(20, 70);
            this.InputMethodLabel.Margin = new System.Windows.Forms.Padding(10);
            this.InputMethodLabel.Name = "InputMethodLabel";
            this.InputMethodLabel.Size = new System.Drawing.Size(250, 30);
            this.InputMethodLabel.TabIndex = 46;
            this.InputMethodLabel.Text = "Input Method";
            this.InputMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RefreshPictureBox
            // 
            this.RefreshPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshPictureBox.Image = global::SendKeyToApp.Properties.Resources.refresh;
            this.RefreshPictureBox.Location = new System.Drawing.Point(720, 20);
            this.RefreshPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.RefreshPictureBox.Name = "RefreshPictureBox";
            this.RefreshPictureBox.Size = new System.Drawing.Size(30, 30);
            this.RefreshPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RefreshPictureBox.TabIndex = 45;
            this.RefreshPictureBox.TabStop = false;
            this.RefreshPictureBox.Click += new System.EventHandler(this.RefreshPictureBox_Click);
            // 
            // SelectAppComboBox
            // 
            this.SelectAppComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SelectAppComboBox.FormattingEnabled = true;
            this.SelectAppComboBox.Location = new System.Drawing.Point(280, 20);
            this.SelectAppComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.SelectAppComboBox.Name = "SelectAppComboBox";
            this.SelectAppComboBox.Size = new System.Drawing.Size(440, 30);
            this.SelectAppComboBox.TabIndex = 44;
            // 
            // AppClassLabel
            // 
            this.AppClassLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AppClassLabel.Location = new System.Drawing.Point(20, 220);
            this.AppClassLabel.Margin = new System.Windows.Forms.Padding(10);
            this.AppClassLabel.Name = "AppClassLabel";
            this.AppClassLabel.Size = new System.Drawing.Size(250, 30);
            this.AppClassLabel.TabIndex = 43;
            this.AppClassLabel.Text = "App Class";
            this.AppClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppClassTextBox
            // 
            this.AppClassTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AppClassTextBox.ForeColor = System.Drawing.Color.Black;
            this.AppClassTextBox.Location = new System.Drawing.Point(280, 220);
            this.AppClassTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.AppClassTextBox.Multiline = true;
            this.AppClassTextBox.Name = "AppClassTextBox";
            this.AppClassTextBox.Size = new System.Drawing.Size(470, 30);
            this.AppClassTextBox.TabIndex = 42;
            // 
            // HandleMethodLabel
            // 
            this.HandleMethodLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HandleMethodLabel.Location = new System.Drawing.Point(20, 170);
            this.HandleMethodLabel.Margin = new System.Windows.Forms.Padding(10);
            this.HandleMethodLabel.Name = "HandleMethodLabel";
            this.HandleMethodLabel.Size = new System.Drawing.Size(250, 30);
            this.HandleMethodLabel.TabIndex = 41;
            this.HandleMethodLabel.Text = "Handle Method";
            this.HandleMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessHandleButton
            // 
            this.ProcessHandleButton.BackColor = System.Drawing.Color.Red;
            this.ProcessHandleButton.FlatAppearance.BorderSize = 0;
            this.ProcessHandleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessHandleButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProcessHandleButton.Location = new System.Drawing.Point(600, 170);
            this.ProcessHandleButton.Margin = new System.Windows.Forms.Padding(10);
            this.ProcessHandleButton.Name = "ProcessHandleButton";
            this.ProcessHandleButton.Size = new System.Drawing.Size(150, 30);
            this.ProcessHandleButton.TabIndex = 40;
            this.ProcessHandleButton.Text = "ProcessHandle";
            this.ProcessHandleButton.UseVisualStyleBackColor = false;
            this.ProcessHandleButton.Click += new System.EventHandler(this.ProcessHandleButton_Click);
            // 
            // FindWindowButton
            // 
            this.FindWindowButton.BackColor = System.Drawing.Color.Red;
            this.FindWindowButton.FlatAppearance.BorderSize = 0;
            this.FindWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindWindowButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FindWindowButton.Location = new System.Drawing.Point(440, 170);
            this.FindWindowButton.Margin = new System.Windows.Forms.Padding(10);
            this.FindWindowButton.Name = "FindWindowButton";
            this.FindWindowButton.Size = new System.Drawing.Size(150, 30);
            this.FindWindowButton.TabIndex = 39;
            this.FindWindowButton.Text = "FindWindow";
            this.FindWindowButton.UseVisualStyleBackColor = false;
            this.FindWindowButton.Click += new System.EventHandler(this.FindWindowButton_Click);
            // 
            // FindWindowExButton
            // 
            this.FindWindowExButton.BackColor = System.Drawing.Color.Lime;
            this.FindWindowExButton.Enabled = false;
            this.FindWindowExButton.FlatAppearance.BorderSize = 0;
            this.FindWindowExButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindWindowExButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FindWindowExButton.Location = new System.Drawing.Point(280, 170);
            this.FindWindowExButton.Margin = new System.Windows.Forms.Padding(10);
            this.FindWindowExButton.Name = "FindWindowExButton";
            this.FindWindowExButton.Size = new System.Drawing.Size(150, 30);
            this.FindWindowExButton.TabIndex = 38;
            this.FindWindowExButton.Text = "FindWindowEx";
            this.FindWindowExButton.UseVisualStyleBackColor = false;
            this.FindWindowExButton.Click += new System.EventHandler(this.FindWindowExButton_Click);
            // 
            // MessageMethodLabel
            // 
            this.MessageMethodLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MessageMethodLabel.Location = new System.Drawing.Point(20, 120);
            this.MessageMethodLabel.Margin = new System.Windows.Forms.Padding(10);
            this.MessageMethodLabel.Name = "MessageMethodLabel";
            this.MessageMethodLabel.Size = new System.Drawing.Size(250, 30);
            this.MessageMethodLabel.TabIndex = 37;
            this.MessageMethodLabel.Text = "Message Method";
            this.MessageMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.BackColor = System.Drawing.Color.Red;
            this.SendMessageButton.FlatAppearance.BorderSize = 0;
            this.SendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessageButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SendMessageButton.Location = new System.Drawing.Point(520, 120);
            this.SendMessageButton.Margin = new System.Windows.Forms.Padding(10);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(230, 30);
            this.SendMessageButton.TabIndex = 36;
            this.SendMessageButton.Text = "Send";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // PostMessageButton
            // 
            this.PostMessageButton.BackColor = System.Drawing.Color.Lime;
            this.PostMessageButton.Enabled = false;
            this.PostMessageButton.FlatAppearance.BorderSize = 0;
            this.PostMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostMessageButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PostMessageButton.Location = new System.Drawing.Point(280, 120);
            this.PostMessageButton.Margin = new System.Windows.Forms.Padding(10);
            this.PostMessageButton.Name = "PostMessageButton";
            this.PostMessageButton.Size = new System.Drawing.Size(230, 30);
            this.PostMessageButton.TabIndex = 35;
            this.PostMessageButton.Text = "Post";
            this.PostMessageButton.UseVisualStyleBackColor = false;
            this.PostMessageButton.Click += new System.EventHandler(this.PostMessageButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Orange;
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SendButton.Location = new System.Drawing.Point(280, 270);
            this.SendButton.Margin = new System.Windows.Forms.Padding(10);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(470, 30);
            this.SendButton.TabIndex = 34;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // AppLabel
            // 
            this.AppLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AppLabel.Location = new System.Drawing.Point(20, 20);
            this.AppLabel.Margin = new System.Windows.Forms.Padding(10);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(250, 30);
            this.AppLabel.TabIndex = 31;
            this.AppLabel.Text = "Select App";
            this.AppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendKeyPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 370);
            this.Controls.Add(this.InputKeyComboBox);
            this.Controls.Add(this.InputAltButton);
            this.Controls.Add(this.InputShiftButton);
            this.Controls.Add(this.InputCtrlButton);
            this.Controls.Add(this.InputMethodLabel);
            this.Controls.Add(this.RefreshPictureBox);
            this.Controls.Add(this.SelectAppComboBox);
            this.Controls.Add(this.AppClassLabel);
            this.Controls.Add(this.AppClassTextBox);
            this.Controls.Add(this.HandleMethodLabel);
            this.Controls.Add(this.ProcessHandleButton);
            this.Controls.Add(this.FindWindowButton);
            this.Controls.Add(this.FindWindowExButton);
            this.Controls.Add(this.MessageMethodLabel);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.PostMessageButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.AppLabel);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SendKeyPress";
            this.Text = "ManualSendKey";
            this.Load += new System.EventHandler(this.SendKeyPress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InputKeyComboBox;
        private System.Windows.Forms.Button InputAltButton;
        private System.Windows.Forms.Button InputShiftButton;
        private System.Windows.Forms.Button InputCtrlButton;
        private System.Windows.Forms.Label InputMethodLabel;
        private System.Windows.Forms.PictureBox RefreshPictureBox;
        private System.Windows.Forms.ComboBox SelectAppComboBox;
        private System.Windows.Forms.Label AppClassLabel;
        private System.Windows.Forms.TextBox AppClassTextBox;
        private System.Windows.Forms.Label HandleMethodLabel;
        private System.Windows.Forms.Button ProcessHandleButton;
        private System.Windows.Forms.Button FindWindowButton;
        private System.Windows.Forms.Button FindWindowExButton;
        private System.Windows.Forms.Label MessageMethodLabel;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Button PostMessageButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label AppLabel;
    }
}