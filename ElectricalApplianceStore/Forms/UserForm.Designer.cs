namespace ElectricalApplianceStore
{
    partial class UserForm
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
            this.exitAccount_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitAccount_Button
            // 
            this.exitAccount_Button.Location = new System.Drawing.Point(662, 12);
            this.exitAccount_Button.Name = "exitAccount_Button";
            this.exitAccount_Button.Size = new System.Drawing.Size(126, 38);
            this.exitAccount_Button.TabIndex = 0;
            this.exitAccount_Button.Text = "Выйти из аккаунта";
            this.exitAccount_Button.UseVisualStyleBackColor = true;
            this.exitAccount_Button.Click += new System.EventHandler(this.exitAccount_Button_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitAccount_Button);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitAccount_Button;
    }
}