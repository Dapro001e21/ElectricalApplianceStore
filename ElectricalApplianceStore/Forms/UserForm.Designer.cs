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
            this.electricalAppliances_ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.type_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sort_ComboBox = new System.Windows.Forms.ComboBox();
            this.sort_Button = new System.Windows.Forms.Button();
            this.order_ComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateElectricalAppliance_Button = new System.Windows.Forms.Button();
            this.show_Button = new System.Windows.Forms.Button();
            this.buy_Button = new System.Windows.Forms.Button();
            this.pageTwo_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitAccount_Button
            // 
            this.exitAccount_Button.Location = new System.Drawing.Point(658, 12);
            this.exitAccount_Button.Name = "exitAccount_Button";
            this.exitAccount_Button.Size = new System.Drawing.Size(130, 50);
            this.exitAccount_Button.TabIndex = 0;
            this.exitAccount_Button.Text = "Выйти из аккаунта";
            this.exitAccount_Button.UseVisualStyleBackColor = true;
            this.exitAccount_Button.Click += new System.EventHandler(this.exitAccount_Button_Click);
            // 
            // electricalAppliances_ListBox
            // 
            this.electricalAppliances_ListBox.FormattingEnabled = true;
            this.electricalAppliances_ListBox.Location = new System.Drawing.Point(12, 29);
            this.electricalAppliances_ListBox.Name = "electricalAppliances_ListBox";
            this.electricalAppliances_ListBox.Size = new System.Drawing.Size(389, 342);
            this.electricalAppliances_ListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Электроприборы:";
            // 
            // type_ComboBox
            // 
            this.type_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_ComboBox.FormattingEnabled = true;
            this.type_ComboBox.Location = new System.Drawing.Point(407, 30);
            this.type_ComboBox.Name = "type_ComboBox";
            this.type_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.type_ComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите тип:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сортировать по:";
            // 
            // sort_ComboBox
            // 
            this.sort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sort_ComboBox.FormattingEnabled = true;
            this.sort_ComboBox.Items.AddRange(new object[] {
            "Дате выпуска",
            "Поставщику",
            "Весу",
            "Стоимости"});
            this.sort_ComboBox.Location = new System.Drawing.Point(407, 133);
            this.sort_ComboBox.Name = "sort_ComboBox";
            this.sort_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.sort_ComboBox.TabIndex = 5;
            // 
            // sort_Button
            // 
            this.sort_Button.Location = new System.Drawing.Point(407, 200);
            this.sort_Button.Name = "sort_Button";
            this.sort_Button.Size = new System.Drawing.Size(121, 40);
            this.sort_Button.TabIndex = 7;
            this.sort_Button.Text = "Сортировать";
            this.sort_Button.UseVisualStyleBackColor = true;
            this.sort_Button.Click += new System.EventHandler(this.sort_Button_Click);
            // 
            // order_ComboBox
            // 
            this.order_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.order_ComboBox.FormattingEnabled = true;
            this.order_ComboBox.Items.AddRange(new object[] {
            "Возрастания",
            "Убывания"});
            this.order_ComboBox.Location = new System.Drawing.Point(407, 173);
            this.order_ComboBox.Name = "order_ComboBox";
            this.order_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.order_ComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Порядок:";
            // 
            // updateElectricalAppliance_Button
            // 
            this.updateElectricalAppliance_Button.Location = new System.Drawing.Point(12, 377);
            this.updateElectricalAppliance_Button.Name = "updateElectricalAppliance_Button";
            this.updateElectricalAppliance_Button.Size = new System.Drawing.Size(185, 38);
            this.updateElectricalAppliance_Button.TabIndex = 10;
            this.updateElectricalAppliance_Button.Text = "Обновить лист";
            this.updateElectricalAppliance_Button.UseVisualStyleBackColor = true;
            this.updateElectricalAppliance_Button.Click += new System.EventHandler(this.updateElectricalAppliance_Button_Click);
            // 
            // show_Button
            // 
            this.show_Button.Location = new System.Drawing.Point(407, 58);
            this.show_Button.Name = "show_Button";
            this.show_Button.Size = new System.Drawing.Size(121, 36);
            this.show_Button.TabIndex = 11;
            this.show_Button.Text = "Показать";
            this.show_Button.UseVisualStyleBackColor = true;
            this.show_Button.Click += new System.EventHandler(this.show_Button_Click);
            // 
            // buy_Button
            // 
            this.buy_Button.Location = new System.Drawing.Point(203, 377);
            this.buy_Button.Name = "buy_Button";
            this.buy_Button.Size = new System.Drawing.Size(198, 38);
            this.buy_Button.TabIndex = 12;
            this.buy_Button.Text = "Купить";
            this.buy_Button.UseVisualStyleBackColor = true;
            this.buy_Button.Click += new System.EventHandler(this.buy_Button_Click);
            // 
            // pageTwo_Button
            // 
            this.pageTwo_Button.Location = new System.Drawing.Point(676, 403);
            this.pageTwo_Button.Name = "pageTwo_Button";
            this.pageTwo_Button.Size = new System.Drawing.Size(121, 46);
            this.pageTwo_Button.TabIndex = 13;
            this.pageTwo_Button.Text = "Страница 2";
            this.pageTwo_Button.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pageTwo_Button);
            this.Controls.Add(this.buy_Button);
            this.Controls.Add(this.show_Button);
            this.Controls.Add(this.updateElectricalAppliance_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.order_ComboBox);
            this.Controls.Add(this.sort_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sort_ComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.electricalAppliances_ListBox);
            this.Controls.Add(this.exitAccount_Button);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitAccount_Button;
        private System.Windows.Forms.ListBox electricalAppliances_ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sort_ComboBox;
        private System.Windows.Forms.Button sort_Button;
        private System.Windows.Forms.ComboBox order_ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateElectricalAppliance_Button;
        private System.Windows.Forms.Button show_Button;
        private System.Windows.Forms.Button buy_Button;
        private System.Windows.Forms.Button pageTwo_Button;
    }
}