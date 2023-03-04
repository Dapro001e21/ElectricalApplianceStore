namespace ElectricalApplianceStore
{
    partial class RegistrationForm
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
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.registration_Button = new System.Windows.Forms.Button();
            this.password_CheckBox = new System.Windows.Forms.CheckBox();
            this.twoPassword_CheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.twoPassword_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(12, 32);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(181, 20);
            this.name_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите почту:";
            // 
            // email_TextBox
            // 
            this.email_TextBox.Location = new System.Drawing.Point(12, 75);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(181, 20);
            this.email_TextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите пароль:";
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(12, 118);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.PasswordChar = '●';
            this.password_TextBox.Size = new System.Drawing.Size(160, 20);
            this.password_TextBox.TabIndex = 4;
            // 
            // registration_Button
            // 
            this.registration_Button.Location = new System.Drawing.Point(12, 196);
            this.registration_Button.Name = "registration_Button";
            this.registration_Button.Size = new System.Drawing.Size(180, 42);
            this.registration_Button.TabIndex = 6;
            this.registration_Button.Text = "Зарегестрироваться";
            this.registration_Button.UseVisualStyleBackColor = true;
            this.registration_Button.Click += new System.EventHandler(this.registration_Button_Click);
            // 
            // password_CheckBox
            // 
            this.password_CheckBox.AutoSize = true;
            this.password_CheckBox.Location = new System.Drawing.Point(178, 121);
            this.password_CheckBox.Name = "password_CheckBox";
            this.password_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.password_CheckBox.TabIndex = 7;
            this.password_CheckBox.UseVisualStyleBackColor = true;
            this.password_CheckBox.CheckedChanged += new System.EventHandler(this.password_CheckBox_CheckedChanged);
            // 
            // twoPassword_CheckBox
            // 
            this.twoPassword_CheckBox.AutoSize = true;
            this.twoPassword_CheckBox.Location = new System.Drawing.Point(178, 160);
            this.twoPassword_CheckBox.Name = "twoPassword_CheckBox";
            this.twoPassword_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.twoPassword_CheckBox.TabIndex = 10;
            this.twoPassword_CheckBox.UseVisualStyleBackColor = true;
            this.twoPassword_CheckBox.CheckedChanged += new System.EventHandler(this.twoPassword_CheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Подтвердите пароль:";
            // 
            // twoPassword_TextBox
            // 
            this.twoPassword_TextBox.Location = new System.Drawing.Point(12, 160);
            this.twoPassword_TextBox.Name = "twoPassword_TextBox";
            this.twoPassword_TextBox.PasswordChar = '●';
            this.twoPassword_TextBox.Size = new System.Drawing.Size(160, 20);
            this.twoPassword_TextBox.TabIndex = 8;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 244);
            this.Controls.Add(this.twoPassword_CheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.twoPassword_TextBox);
            this.Controls.Add(this.password_CheckBox);
            this.Controls.Add(this.registration_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_TextBox);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button registration_Button;
        private System.Windows.Forms.CheckBox password_CheckBox;
        private System.Windows.Forms.CheckBox twoPassword_CheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox twoPassword_TextBox;
    }
}