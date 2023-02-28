namespace ElectricalApplianceStore
{
    partial class SelectiveForm
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
            this.userForm_Button = new System.Windows.Forms.Button();
            this.adminForm_Button = new System.Windows.Forms.Button();
            this.exitAccount_Button = new System.Windows.Forms.Button();
            this.profileForm_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userForm_Button
            // 
            this.userForm_Button.Location = new System.Drawing.Point(12, 74);
            this.userForm_Button.Name = "userForm_Button";
            this.userForm_Button.Size = new System.Drawing.Size(164, 56);
            this.userForm_Button.TabIndex = 0;
            this.userForm_Button.Text = "Пользовательская форма";
            this.userForm_Button.UseVisualStyleBackColor = true;
            this.userForm_Button.Click += new System.EventHandler(this.userForm_Button_Click);
            // 
            // adminForm_Button
            // 
            this.adminForm_Button.Location = new System.Drawing.Point(12, 136);
            this.adminForm_Button.Name = "adminForm_Button";
            this.adminForm_Button.Size = new System.Drawing.Size(164, 56);
            this.adminForm_Button.TabIndex = 1;
            this.adminForm_Button.Text = "Админская форма";
            this.adminForm_Button.UseVisualStyleBackColor = true;
            this.adminForm_Button.Click += new System.EventHandler(this.adminForm_Button_Click);
            // 
            // exitAccount_Button
            // 
            this.exitAccount_Button.Location = new System.Drawing.Point(12, 198);
            this.exitAccount_Button.Name = "exitAccount_Button";
            this.exitAccount_Button.Size = new System.Drawing.Size(164, 56);
            this.exitAccount_Button.TabIndex = 2;
            this.exitAccount_Button.Text = "Выйти из аккаунта";
            this.exitAccount_Button.UseVisualStyleBackColor = true;
            this.exitAccount_Button.Click += new System.EventHandler(this.exitAccount_Button_Click);
            // 
            // profileForm_Button
            // 
            this.profileForm_Button.Location = new System.Drawing.Point(12, 12);
            this.profileForm_Button.Name = "profileForm_Button";
            this.profileForm_Button.Size = new System.Drawing.Size(164, 56);
            this.profileForm_Button.TabIndex = 3;
            this.profileForm_Button.Text = "Профиль";
            this.profileForm_Button.UseVisualStyleBackColor = true;
            this.profileForm_Button.Click += new System.EventHandler(this.profileForm_Button_Click);
            // 
            // SelectiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 266);
            this.Controls.Add(this.profileForm_Button);
            this.Controls.Add(this.exitAccount_Button);
            this.Controls.Add(this.adminForm_Button);
            this.Controls.Add(this.userForm_Button);
            this.Name = "SelectiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectiveForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userForm_Button;
        private System.Windows.Forms.Button adminForm_Button;
        private System.Windows.Forms.Button exitAccount_Button;
        private System.Windows.Forms.Button profileForm_Button;
    }
}