
namespace SendKeyToApp.Forms
{
    partial class Methods
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
            this.methodsPanel = new System.Windows.Forms.Panel();
            this.methodsAppClassLabel = new System.Windows.Forms.Label();
            this.methodsHandleMethodLabel = new System.Windows.Forms.Label();
            this.methodsMessageMethodLabel = new System.Windows.Forms.Label();
            this.methodsMethodNameLabel = new System.Windows.Forms.Label();
            this.methodsDeletePictureBox = new System.Windows.Forms.PictureBox();
            this.methodsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.methodsDeletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // methodsPanel
            // 
            this.methodsPanel.Controls.Add(this.methodsAppClassLabel);
            this.methodsPanel.Controls.Add(this.methodsHandleMethodLabel);
            this.methodsPanel.Controls.Add(this.methodsMessageMethodLabel);
            this.methodsPanel.Controls.Add(this.methodsMethodNameLabel);
            this.methodsPanel.Controls.Add(this.methodsDeletePictureBox);
            this.methodsPanel.Location = new System.Drawing.Point(20, 20);
            this.methodsPanel.Name = "methodsPanel";
            this.methodsPanel.Size = new System.Drawing.Size(730, 330);
            this.methodsPanel.TabIndex = 0;
            // 
            // methodsAppClassLabel
            // 
            this.methodsAppClassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.methodsAppClassLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.methodsAppClassLabel.Location = new System.Drawing.Point(561, 3);
            this.methodsAppClassLabel.Name = "methodsAppClassLabel";
            this.methodsAppClassLabel.Size = new System.Drawing.Size(128, 32);
            this.methodsAppClassLabel.TabIndex = 16;
            this.methodsAppClassLabel.Text = "App Class";
            this.methodsAppClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // methodsHandleMethodLabel
            // 
            this.methodsHandleMethodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.methodsHandleMethodLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.methodsHandleMethodLabel.Location = new System.Drawing.Point(375, 3);
            this.methodsHandleMethodLabel.Name = "methodsHandleMethodLabel";
            this.methodsHandleMethodLabel.Size = new System.Drawing.Size(180, 32);
            this.methodsHandleMethodLabel.TabIndex = 15;
            this.methodsHandleMethodLabel.Text = "Handle Method";
            this.methodsHandleMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // methodsMessageMethodLabel
            // 
            this.methodsMessageMethodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.methodsMessageMethodLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.methodsMessageMethodLabel.Location = new System.Drawing.Point(189, 3);
            this.methodsMessageMethodLabel.Name = "methodsMessageMethodLabel";
            this.methodsMessageMethodLabel.Size = new System.Drawing.Size(180, 32);
            this.methodsMessageMethodLabel.TabIndex = 14;
            this.methodsMessageMethodLabel.Text = "Message Method";
            this.methodsMessageMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // methodsMethodNameLabel
            // 
            this.methodsMethodNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.methodsMethodNameLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.methodsMethodNameLabel.Location = new System.Drawing.Point(3, 3);
            this.methodsMethodNameLabel.Name = "methodsMethodNameLabel";
            this.methodsMethodNameLabel.Size = new System.Drawing.Size(180, 32);
            this.methodsMethodNameLabel.TabIndex = 13;
            this.methodsMethodNameLabel.Text = "Method Name";
            this.methodsMethodNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // methodsDeletePictureBox
            // 
            this.methodsDeletePictureBox.Image = global::SendKeyToApp.Properties.Resources.delete;
            this.methodsDeletePictureBox.Location = new System.Drawing.Point(695, 3);
            this.methodsDeletePictureBox.Name = "methodsDeletePictureBox";
            this.methodsDeletePictureBox.Size = new System.Drawing.Size(32, 32);
            this.methodsDeletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.methodsDeletePictureBox.TabIndex = 12;
            this.methodsDeletePictureBox.TabStop = false;
            // 
            // Methods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 370);
            this.Controls.Add(this.methodsPanel);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Methods";
            this.Text = "Methods";
            this.Load += new System.EventHandler(this.Methods_Load);
            this.methodsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.methodsDeletePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel methodsPanel;
        private System.Windows.Forms.Label methodsAppClassLabel;
        private System.Windows.Forms.Label methodsHandleMethodLabel;
        private System.Windows.Forms.Label methodsMessageMethodLabel;
        private System.Windows.Forms.Label methodsMethodNameLabel;
        private System.Windows.Forms.PictureBox methodsDeletePictureBox;
    }
}