namespace ElectricalApplianceStore
{
    partial class ProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.save_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password_CheckBox = new System.Windows.Forms.CheckBox();
            this.newPassword_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(66, 12);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(149, 20);
            this.name_TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Почта:";
            // 
            // email_TextBox
            // 
            this.email_TextBox.Location = new System.Drawing.Point(66, 43);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(149, 20);
            this.email_TextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(99, 100);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.PasswordChar = '●';
            this.password_TextBox.Size = new System.Drawing.Size(132, 20);
            this.password_TextBox.TabIndex = 5;
            this.password_TextBox.TextChanged += new System.EventHandler(this.password_TextBox_TextChanged);
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(12, 163);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(236, 45);
            this.save_Button.TabIndex = 6;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Изменение пароля:";
            // 
            // newPassword_TextBox
            // 
            this.newPassword_TextBox.Enabled = false;
            this.newPassword_TextBox.Location = new System.Drawing.Point(99, 126);
            this.newPassword_TextBox.Name = "newPassword_TextBox";
            this.newPassword_TextBox.PasswordChar = '●';
            this.newPassword_TextBox.Size = new System.Drawing.Size(132, 20);
            this.newPassword_TextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(10, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Новый пароль:";
            // 
            // password_CheckBox
            // 
            this.password_CheckBox.AutoSize = true;
            this.password_CheckBox.Location = new System.Drawing.Point(233, 103);
            this.password_CheckBox.Name = "password_CheckBox";
            this.password_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.password_CheckBox.TabIndex = 10;
            this.password_CheckBox.UseVisualStyleBackColor = true;
            this.password_CheckBox.CheckedChanged += new System.EventHandler(this.password_CheckBox_CheckedChanged);
            // 
            // newPassword_CheckBox
            // 
            this.newPassword_CheckBox.AutoSize = true;
            this.newPassword_CheckBox.Enabled = false;
            this.newPassword_CheckBox.Location = new System.Drawing.Point(233, 129);
            this.newPassword_CheckBox.Name = "newPassword_CheckBox";
            this.newPassword_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.newPassword_CheckBox.TabIndex = 11;
            this.newPassword_CheckBox.UseVisualStyleBackColor = true;
            this.newPassword_CheckBox.CheckedChanged += new System.EventHandler(this.newPassword_CheckBox_CheckedChanged);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 215);
            this.Controls.Add(this.newPassword_CheckBox);
            this.Controls.Add(this.password_CheckBox);
            this.Controls.Add(this.newPassword_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newPassword_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox password_CheckBox;
        private System.Windows.Forms.CheckBox newPassword_CheckBox;
    }
}