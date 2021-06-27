
namespace SendKeyToApp.Forms
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.RgbTopBarCheckBox = new System.Windows.Forms.CheckBox();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.settingsIconToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMostCheckBox
            // 
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TopMostCheckBox.Location = new System.Drawing.Point(155, 56);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.Size = new System.Drawing.Size(109, 26);
            this.TopMostCheckBox.TabIndex = 6;
            this.TopMostCheckBox.Text = "Top Most";
            this.TopMostCheckBox.UseVisualStyleBackColor = true;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMostCheckBox_CheckedChanged);
            // 
            // RgbTopBarCheckBox
            // 
            this.RgbTopBarCheckBox.AutoSize = true;
            this.RgbTopBarCheckBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RgbTopBarCheckBox.Location = new System.Drawing.Point(155, 20);
            this.RgbTopBarCheckBox.Name = "RgbTopBarCheckBox";
            this.RgbTopBarCheckBox.Size = new System.Drawing.Size(139, 26);
            this.RgbTopBarCheckBox.TabIndex = 5;
            this.RgbTopBarCheckBox.Text = "RGB Top Bar";
            this.RgbTopBarCheckBox.UseVisualStyleBackColor = true;
            this.RgbTopBarCheckBox.CheckedChanged += new System.EventHandler(this.RgbTopBarCheckBox_CheckedChanged);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackColor = System.Drawing.Color.White;
            this.IconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconPictureBox.Location = new System.Drawing.Point(20, 20);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(128, 128);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconPictureBox.TabIndex = 4;
            this.IconPictureBox.TabStop = false;
            this.IconPictureBox.Click += new System.EventHandler(this.IconPictureBox_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 370);
            this.Controls.Add(this.TopMostCheckBox);
            this.Controls.Add(this.RgbTopBarCheckBox);
            this.Controls.Add(this.IconPictureBox);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TopMostCheckBox;
        private System.Windows.Forms.CheckBox RgbTopBarCheckBox;
        public System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.ToolTip settingsIconToolTip;
    }
}