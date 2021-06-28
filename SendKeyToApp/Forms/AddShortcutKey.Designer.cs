
namespace SendKeyToApp.Forms
{
    partial class AddShortcutKey
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
            this.MethodComboBox = new System.Windows.Forms.ComboBox();
            this.MethodLabel = new System.Windows.Forms.Label();
            this.OutputAltButton = new System.Windows.Forms.Button();
            this.OutputShiftButton = new System.Windows.Forms.Button();
            this.OutputCtrlButton = new System.Windows.Forms.Button();
            this.OutputComboBox = new System.Windows.Forms.ComboBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.SelectAppLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.InputAltButton = new System.Windows.Forms.Button();
            this.InputShiftButton = new System.Windows.Forms.Button();
            this.InputCtrlButton = new System.Windows.Forms.Button();
            this.InputComboBox = new System.Windows.Forms.ComboBox();
            this.SelectAppComboBox = new System.Windows.Forms.ComboBox();
            this.RefreshPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.Location = new System.Drawing.Point(280, 170);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(470, 30);
            this.MethodComboBox.TabIndex = 52;
            // 
            // MethodLabel
            // 
            this.MethodLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MethodLabel.Location = new System.Drawing.Point(20, 170);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(250, 30);
            this.MethodLabel.TabIndex = 51;
            this.MethodLabel.Text = "Method";
            this.MethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputAltButton
            // 
            this.OutputAltButton.BackColor = System.Drawing.Color.Red;
            this.OutputAltButton.FlatAppearance.BorderSize = 0;
            this.OutputAltButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputAltButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OutputAltButton.Location = new System.Drawing.Point(460, 120);
            this.OutputAltButton.Name = "OutputAltButton";
            this.OutputAltButton.Size = new System.Drawing.Size(80, 30);
            this.OutputAltButton.TabIndex = 50;
            this.OutputAltButton.Text = "ALT";
            this.OutputAltButton.UseVisualStyleBackColor = false;
            this.OutputAltButton.Click += new System.EventHandler(this.ColorButton);
            // 
            // OutputShiftButton
            // 
            this.OutputShiftButton.BackColor = System.Drawing.Color.Red;
            this.OutputShiftButton.FlatAppearance.BorderSize = 0;
            this.OutputShiftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputShiftButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OutputShiftButton.Location = new System.Drawing.Point(370, 120);
            this.OutputShiftButton.Name = "OutputShiftButton";
            this.OutputShiftButton.Size = new System.Drawing.Size(80, 30);
            this.OutputShiftButton.TabIndex = 49;
            this.OutputShiftButton.Text = "SHIFT";
            this.OutputShiftButton.UseVisualStyleBackColor = false;
            this.OutputShiftButton.Click += new System.EventHandler(this.ColorButton);
            // 
            // OutputCtrlButton
            // 
            this.OutputCtrlButton.BackColor = System.Drawing.Color.Red;
            this.OutputCtrlButton.FlatAppearance.BorderSize = 0;
            this.OutputCtrlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputCtrlButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OutputCtrlButton.Location = new System.Drawing.Point(280, 120);
            this.OutputCtrlButton.Name = "OutputCtrlButton";
            this.OutputCtrlButton.Size = new System.Drawing.Size(80, 30);
            this.OutputCtrlButton.TabIndex = 48;
            this.OutputCtrlButton.Text = "CTRL";
            this.OutputCtrlButton.UseVisualStyleBackColor = false;
            this.OutputCtrlButton.Click += new System.EventHandler(this.ColorButton);
            // 
            // OutputComboBox
            // 
            this.OutputComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OutputComboBox.FormattingEnabled = true;
            this.OutputComboBox.Location = new System.Drawing.Point(550, 120);
            this.OutputComboBox.Name = "OutputComboBox";
            this.OutputComboBox.Size = new System.Drawing.Size(200, 30);
            this.OutputComboBox.TabIndex = 47;
            // 
            // OutputLabel
            // 
            this.OutputLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OutputLabel.Location = new System.Drawing.Point(20, 120);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(250, 30);
            this.OutputLabel.TabIndex = 46;
            this.OutputLabel.Text = "Output Key Combination";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputLabel
            // 
            this.InputLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InputLabel.Location = new System.Drawing.Point(20, 70);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(250, 30);
            this.InputLabel.TabIndex = 45;
            this.InputLabel.Text = "Input Key Combination";
            this.InputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectAppLabel
            // 
            this.SelectAppLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SelectAppLabel.Location = new System.Drawing.Point(20, 20);
            this.SelectAppLabel.Name = "SelectAppLabel";
            this.SelectAppLabel.Size = new System.Drawing.Size(250, 30);
            this.SelectAppLabel.TabIndex = 44;
            this.SelectAppLabel.Text = "Select App";
            this.SelectAppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Orange;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddButton.Location = new System.Drawing.Point(280, 220);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(470, 30);
            this.AddButton.TabIndex = 43;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // InputAltButton
            // 
            this.InputAltButton.BackColor = System.Drawing.Color.Red;
            this.InputAltButton.FlatAppearance.BorderSize = 0;
            this.InputAltButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputAltButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InputAltButton.Location = new System.Drawing.Point(460, 70);
            this.InputAltButton.Name = "InputAltButton";
            this.InputAltButton.Size = new System.Drawing.Size(80, 30);
            this.InputAltButton.TabIndex = 42;
            this.InputAltButton.Text = "ALT";
            this.InputAltButton.UseVisualStyleBackColor = false;
            this.InputAltButton.Click += new System.EventHandler(this.ColorButton);
            // 
            // InputShiftButton
            // 
            this.InputShiftButton.BackColor = System.Drawing.Color.Red;
            this.InputShiftButton.FlatAppearance.BorderSize = 0;
            this.InputShiftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputShiftButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InputShiftButton.Location = new System.Drawing.Point(370, 70);
            this.InputShiftButton.Name = "InputShiftButton";
            this.InputShiftButton.Size = new System.Drawing.Size(80, 30);
            this.InputShiftButton.TabIndex = 41;
            this.InputShiftButton.Text = "SHIFT";
            this.InputShiftButton.UseVisualStyleBackColor = false;
            this.InputShiftButton.Click += new System.EventHandler(this.ColorButton);
            // 
            // InputCtrlButton
            // 
            this.InputCtrlButton.BackColor = System.Drawing.Color.Red;
            this.InputCtrlButton.FlatAppearance.BorderSize = 0;
            this.InputCtrlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputCtrlButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InputCtrlButton.Location = new System.Drawing.Point(280, 70);
            this.InputCtrlButton.Name = "InputCtrlButton";
            this.InputCtrlButton.Size = new System.Drawing.Size(80, 30);
            this.InputCtrlButton.TabIndex = 40;
            this.InputCtrlButton.Text = "CTRL";
            this.InputCtrlButton.UseVisualStyleBackColor = false;
            this.InputCtrlButton.Click += new System.EventHandler(this.ColorButton);
            // 
            // InputComboBox
            // 
            this.InputComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InputComboBox.FormattingEnabled = true;
            this.InputComboBox.Location = new System.Drawing.Point(550, 70);
            this.InputComboBox.Name = "InputComboBox";
            this.InputComboBox.Size = new System.Drawing.Size(200, 30);
            this.InputComboBox.TabIndex = 39;
            // 
            // SelectAppComboBox
            // 
            this.SelectAppComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SelectAppComboBox.FormattingEnabled = true;
            this.SelectAppComboBox.Location = new System.Drawing.Point(280, 20);
            this.SelectAppComboBox.Name = "SelectAppComboBox";
            this.SelectAppComboBox.Size = new System.Drawing.Size(440, 30);
            this.SelectAppComboBox.TabIndex = 37;
            // 
            // RefreshPictureBox
            // 
            this.RefreshPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshPictureBox.Image = global::SendKeyToApp.Properties.Resources.refresh;
            this.RefreshPictureBox.Location = new System.Drawing.Point(720, 20);
            this.RefreshPictureBox.Name = "RefreshPictureBox";
            this.RefreshPictureBox.Size = new System.Drawing.Size(30, 30);
            this.RefreshPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RefreshPictureBox.TabIndex = 38;
            this.RefreshPictureBox.TabStop = false;
            this.RefreshPictureBox.Click += new System.EventHandler(this.RefreshPictureBox_Click);
            // 
            // AddKeyShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 370);
            this.Controls.Add(this.MethodComboBox);
            this.Controls.Add(this.MethodLabel);
            this.Controls.Add(this.OutputAltButton);
            this.Controls.Add(this.OutputShiftButton);
            this.Controls.Add(this.OutputCtrlButton);
            this.Controls.Add(this.OutputComboBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.SelectAppLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputAltButton);
            this.Controls.Add(this.InputShiftButton);
            this.Controls.Add(this.InputCtrlButton);
            this.Controls.Add(this.InputComboBox);
            this.Controls.Add(this.SelectAppComboBox);
            this.Controls.Add(this.RefreshPictureBox);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddKeyShortcut";
            this.Text = "AddNewShortcut";
            this.Load += new System.EventHandler(this.AddNewShortcut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox MethodComboBox;
        private System.Windows.Forms.Label MethodLabel;
        private System.Windows.Forms.Button OutputAltButton;
        private System.Windows.Forms.Button OutputShiftButton;
        private System.Windows.Forms.Button OutputCtrlButton;
        private System.Windows.Forms.ComboBox OutputComboBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label SelectAppLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button InputAltButton;
        private System.Windows.Forms.Button InputShiftButton;
        private System.Windows.Forms.Button InputCtrlButton;
        private System.Windows.Forms.ComboBox InputComboBox;
        private System.Windows.Forms.ComboBox SelectAppComboBox;
        private System.Windows.Forms.PictureBox RefreshPictureBox;
    }
}