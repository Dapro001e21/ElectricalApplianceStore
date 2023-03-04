namespace ElectricalApplianceStore
{
    partial class ResetPasswordForm
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
            this.code_TextBox = new System.Windows.Forms.TextBox();
            this.newPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.twoNewPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save_Button = new System.Windows.Forms.Button();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resetPassword_Button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.confirm_Button = new System.Windows.Forms.Button();
            this.newPassword_CheckBox = new System.Windows.Forms.CheckBox();
            this.twoNewPassword_CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код подтверждения:";
            // 
            // code_TextBox
            // 
            this.code_TextBox.Location = new System.Drawing.Point(9, 32);
            this.code_TextBox.Name = "code_TextBox";
            this.code_TextBox.Size = new System.Drawing.Size(187, 20);
            this.code_TextBox.TabIndex = 1;
            // 
            // newPassword_TextBox
            // 
            this.newPassword_TextBox.Location = new System.Drawing.Point(6, 29);
            this.newPassword_TextBox.Name = "newPassword_TextBox";
            this.newPassword_TextBox.PasswordChar = '●';
            this.newPassword_TextBox.Size = new System.Drawing.Size(180, 20);
            this.newPassword_TextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новый пароль:";
            // 
            // twoNewPassword_TextBox
            // 
            this.twoNewPassword_TextBox.Location = new System.Drawing.Point(221, 29);
            this.twoNewPassword_TextBox.Name = "twoNewPassword_TextBox";
            this.twoNewPassword_TextBox.PasswordChar = '●';
            this.twoNewPassword_TextBox.Size = new System.Drawing.Size(185, 20);
            this.twoNewPassword_TextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Повторите пароль:";
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(113, 65);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(202, 50);
            this.save_Button.TabIndex = 6;
            this.save_Button.Text = "Сохранить";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // email_TextBox
            // 
            this.email_TextBox.Location = new System.Drawing.Point(6, 32);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(190, 20);
            this.email_TextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Почта:";
            // 
            // resetPassword_Button
            // 
            this.resetPassword_Button.Location = new System.Drawing.Point(6, 58);
            this.resetPassword_Button.Name = "resetPassword_Button";
            this.resetPassword_Button.Size = new System.Drawing.Size(190, 38);
            this.resetPassword_Button.TabIndex = 9;
            this.resetPassword_Button.Text = "Сбросить пароль";
            this.resetPassword_Button.UseVisualStyleBackColor = true;
            this.resetPassword_Button.Click += new System.EventHandler(this.resetPassword_Button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.twoNewPassword_CheckBox);
            this.groupBox3.Controls.Add(this.newPassword_CheckBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.newPassword_TextBox);
            this.groupBox3.Controls.Add(this.save_Button);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.twoNewPassword_TextBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 121);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.email_TextBox);
            this.groupBox1.Controls.Add(this.resetPassword_Button);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 104);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.confirm_Button);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.code_TextBox);
            this.groupBox2.Location = new System.Drawing.Point(233, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 104);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // confirm_Button
            // 
            this.confirm_Button.Location = new System.Drawing.Point(9, 58);
            this.confirm_Button.Name = "confirm_Button";
            this.confirm_Button.Size = new System.Drawing.Size(187, 38);
            this.confirm_Button.TabIndex = 7;
            this.confirm_Button.Text = "Подтвердить";
            this.confirm_Button.UseVisualStyleBackColor = true;
            this.confirm_Button.Click += new System.EventHandler(this.confirm_Button_Click);
            // 
            // newPassword_CheckBox
            // 
            this.newPassword_CheckBox.AutoSize = true;
            this.newPassword_CheckBox.Location = new System.Drawing.Point(190, 32);
            this.newPassword_CheckBox.Name = "newPassword_CheckBox";
            this.newPassword_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.newPassword_CheckBox.TabIndex = 7;
            this.newPassword_CheckBox.UseVisualStyleBackColor = true;
            this.newPassword_CheckBox.CheckedChanged += new System.EventHandler(this.newPassword_CheckBox_CheckedChanged);
            // 
            // twoNewPassword_CheckBox
            // 
            this.twoNewPassword_CheckBox.AutoSize = true;
            this.twoNewPassword_CheckBox.Location = new System.Drawing.Point(408, 32);
            this.twoNewPassword_CheckBox.Name = "twoNewPassword_CheckBox";
            this.twoNewPassword_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.twoNewPassword_CheckBox.TabIndex = 8;
            this.twoNewPassword_CheckBox.UseVisualStyleBackColor = true;
            this.twoNewPassword_CheckBox.CheckedChanged += new System.EventHandler(this.twoNewPassword_CheckBox_CheckedChanged);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPasswordForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox code_TextBox;
        private System.Windows.Forms.TextBox newPassword_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox twoNewPassword_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.TextBox email_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resetPassword_Button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button confirm_Button;
        private System.Windows.Forms.CheckBox twoNewPassword_CheckBox;
        private System.Windows.Forms.CheckBox newPassword_CheckBox;
    }
}