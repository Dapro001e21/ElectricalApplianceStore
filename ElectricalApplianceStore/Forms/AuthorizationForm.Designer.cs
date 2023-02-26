namespace ElectricalApplianceStore
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sign_Up_Button = new System.Windows.Forms.Button();
            this.Sign_In_Button = new System.Windows.Forms.Button();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Sign_Up_Button
            // 
            this.Sign_Up_Button.Location = new System.Drawing.Point(291, 213);
            this.Sign_Up_Button.Name = "Sign_Up_Button";
            this.Sign_Up_Button.Size = new System.Drawing.Size(151, 43);
            this.Sign_Up_Button.TabIndex = 17;
            this.Sign_Up_Button.Text = "Зарегестрироваться";
            this.Sign_Up_Button.UseVisualStyleBackColor = true;
            this.Sign_Up_Button.Click += new System.EventHandler(this.Sign_Up_Button_Click);
            // 
            // Sign_In_Button
            // 
            this.Sign_In_Button.Location = new System.Drawing.Point(133, 213);
            this.Sign_In_Button.Name = "Sign_In_Button";
            this.Sign_In_Button.Size = new System.Drawing.Size(152, 43);
            this.Sign_In_Button.TabIndex = 16;
            this.Sign_In_Button.Text = "Войти";
            this.Sign_In_Button.UseVisualStyleBackColor = true;
            this.Sign_In_Button.Click += new System.EventHandler(this.Sign_In_Button_Click);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(155, 145);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.PasswordChar = '●';
            this.password_TextBox.Size = new System.Drawing.Size(273, 20);
            this.password_TextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите пароль:";
            // 
            // email_TextBox
            // 
            this.email_TextBox.Location = new System.Drawing.Point(155, 96);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(273, 20);
            this.email_TextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите почту:";
            // 
            // showCheckBox
            // 
            this.showCheckBox.AutoSize = true;
            this.showCheckBox.Location = new System.Drawing.Point(155, 171);
            this.showCheckBox.Name = "showCheckBox";
            this.showCheckBox.Size = new System.Drawing.Size(75, 17);
            this.showCheckBox.TabIndex = 18;
            this.showCheckBox.Text = "Показать";
            this.showCheckBox.UseVisualStyleBackColor = true;
            this.showCheckBox.CheckedChanged += new System.EventHandler(this.showCheckBox_CheckedChanged);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.showCheckBox);
            this.Controls.Add(this.Sign_Up_Button);
            this.Controls.Add(this.Sign_In_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sign_Up_Button;
        private System.Windows.Forms.Button Sign_In_Button;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showCheckBox;
    }
}

