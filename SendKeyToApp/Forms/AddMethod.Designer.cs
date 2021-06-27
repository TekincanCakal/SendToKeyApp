
namespace SendKeyToApp.Forms
{
    partial class AddMethod
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AppClassLabel = new System.Windows.Forms.Label();
            this.AppClassTextBox = new System.Windows.Forms.TextBox();
            this.HandleMethodLabel = new System.Windows.Forms.Label();
            this.ProcessHandleButton = new System.Windows.Forms.Button();
            this.FindWindowButton = new System.Windows.Forms.Button();
            this.FindWindowExButton = new System.Windows.Forms.Button();
            this.MessageMethodLabel = new System.Windows.Forms.Label();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.PostMessageButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLabel.Location = new System.Drawing.Point(20, 170);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(10);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(250, 30);
            this.NameLabel.TabIndex = 38;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameTextBox.ForeColor = System.Drawing.Color.Black;
            this.NameTextBox.Location = new System.Drawing.Point(280, 170);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(470, 30);
            this.NameTextBox.TabIndex = 37;
            // 
            // AppClassLabel
            // 
            this.AppClassLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AppClassLabel.Location = new System.Drawing.Point(20, 120);
            this.AppClassLabel.Margin = new System.Windows.Forms.Padding(10);
            this.AppClassLabel.Name = "AppClassLabel";
            this.AppClassLabel.Size = new System.Drawing.Size(250, 30);
            this.AppClassLabel.TabIndex = 36;
            this.AppClassLabel.Text = "App Class";
            this.AppClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppClassTextBox
            // 
            this.AppClassTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AppClassTextBox.ForeColor = System.Drawing.Color.Black;
            this.AppClassTextBox.Location = new System.Drawing.Point(280, 120);
            this.AppClassTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.AppClassTextBox.Multiline = true;
            this.AppClassTextBox.Name = "AppClassTextBox";
            this.AppClassTextBox.Size = new System.Drawing.Size(470, 30);
            this.AppClassTextBox.TabIndex = 35;
            // 
            // HandleMethodLabel
            // 
            this.HandleMethodLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HandleMethodLabel.Location = new System.Drawing.Point(20, 70);
            this.HandleMethodLabel.Margin = new System.Windows.Forms.Padding(10);
            this.HandleMethodLabel.Name = "HandleMethodLabel";
            this.HandleMethodLabel.Size = new System.Drawing.Size(250, 30);
            this.HandleMethodLabel.TabIndex = 34;
            this.HandleMethodLabel.Text = "Handle Method";
            this.HandleMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessHandleButton
            // 
            this.ProcessHandleButton.BackColor = System.Drawing.Color.Red;
            this.ProcessHandleButton.FlatAppearance.BorderSize = 0;
            this.ProcessHandleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessHandleButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProcessHandleButton.Location = new System.Drawing.Point(600, 70);
            this.ProcessHandleButton.Margin = new System.Windows.Forms.Padding(10);
            this.ProcessHandleButton.Name = "ProcessHandleButton";
            this.ProcessHandleButton.Size = new System.Drawing.Size(150, 30);
            this.ProcessHandleButton.TabIndex = 33;
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
            this.FindWindowButton.Location = new System.Drawing.Point(440, 70);
            this.FindWindowButton.Margin = new System.Windows.Forms.Padding(10);
            this.FindWindowButton.Name = "FindWindowButton";
            this.FindWindowButton.Size = new System.Drawing.Size(150, 30);
            this.FindWindowButton.TabIndex = 32;
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
            this.FindWindowExButton.Location = new System.Drawing.Point(280, 70);
            this.FindWindowExButton.Margin = new System.Windows.Forms.Padding(10);
            this.FindWindowExButton.Name = "FindWindowExButton";
            this.FindWindowExButton.Size = new System.Drawing.Size(150, 30);
            this.FindWindowExButton.TabIndex = 31;
            this.FindWindowExButton.Text = "FindWindowEx";
            this.FindWindowExButton.UseVisualStyleBackColor = false;
            this.FindWindowExButton.Click += new System.EventHandler(this.FindWindowExButton_Click);
            // 
            // MessageMethodLabel
            // 
            this.MessageMethodLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MessageMethodLabel.Location = new System.Drawing.Point(20, 20);
            this.MessageMethodLabel.Margin = new System.Windows.Forms.Padding(10);
            this.MessageMethodLabel.Name = "MessageMethodLabel";
            this.MessageMethodLabel.Size = new System.Drawing.Size(250, 30);
            this.MessageMethodLabel.TabIndex = 30;
            this.MessageMethodLabel.Text = "Message Method";
            this.MessageMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.BackColor = System.Drawing.Color.Red;
            this.SendMessageButton.FlatAppearance.BorderSize = 0;
            this.SendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessageButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SendMessageButton.Location = new System.Drawing.Point(520, 20);
            this.SendMessageButton.Margin = new System.Windows.Forms.Padding(10);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(230, 30);
            this.SendMessageButton.TabIndex = 29;
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
            this.PostMessageButton.Location = new System.Drawing.Point(280, 20);
            this.PostMessageButton.Margin = new System.Windows.Forms.Padding(10);
            this.PostMessageButton.Name = "PostMessageButton";
            this.PostMessageButton.Size = new System.Drawing.Size(230, 30);
            this.PostMessageButton.TabIndex = 28;
            this.PostMessageButton.Text = "Post";
            this.PostMessageButton.UseVisualStyleBackColor = false;
            this.PostMessageButton.Click += new System.EventHandler(this.PostMessageButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Orange;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddButton.Location = new System.Drawing.Point(280, 220);
            this.AddButton.Margin = new System.Windows.Forms.Padding(10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(470, 30);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 370);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AppClassLabel);
            this.Controls.Add(this.AppClassTextBox);
            this.Controls.Add(this.HandleMethodLabel);
            this.Controls.Add(this.ProcessHandleButton);
            this.Controls.Add(this.FindWindowButton);
            this.Controls.Add(this.FindWindowExButton);
            this.Controls.Add(this.MessageMethodLabel);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.PostMessageButton);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddMethod";
            this.Text = "AddNewMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AppClassLabel;
        private System.Windows.Forms.TextBox AppClassTextBox;
        private System.Windows.Forms.Label HandleMethodLabel;
        private System.Windows.Forms.Button ProcessHandleButton;
        private System.Windows.Forms.Button FindWindowButton;
        private System.Windows.Forms.Button FindWindowExButton;
        private System.Windows.Forms.Label MessageMethodLabel;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Button PostMessageButton;
        private System.Windows.Forms.Button AddButton;
    }
}