namespace ElectricalApplianceStore
{
    partial class TwoUserForm
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
            this.leaveToUserForm_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.initial_TextBox = new System.Windows.Forms.TextBox();
            this.initial_Label = new System.Windows.Forms.Label();
            this.final_Label = new System.Windows.Forms.Label();
            this.final_TextBox = new System.Windows.Forms.TextBox();
            this.findPrice_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // leaveToUserForm_Button
            // 
            this.leaveToUserForm_Button.Location = new System.Drawing.Point(677, 402);
            this.leaveToUserForm_Button.Name = "leaveToUserForm_Button";
            this.leaveToUserForm_Button.Size = new System.Drawing.Size(121, 46);
            this.leaveToUserForm_Button.TabIndex = 14;
            this.leaveToUserForm_Button.Text = "Вернуться на главную";
            this.leaveToUserForm_Button.UseVisualStyleBackColor = true;
            this.leaveToUserForm_Button.Click += new System.EventHandler(this.leaveToUserForm_Button_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(556, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 209);
            this.label1.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(15, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 160);
            this.listBox1.TabIndex = 16;
            // 
            // initial_TextBox
            // 
            this.initial_TextBox.Location = new System.Drawing.Point(140, 43);
            this.initial_TextBox.Name = "initial_TextBox";
            this.initial_TextBox.Size = new System.Drawing.Size(158, 20);
            this.initial_TextBox.TabIndex = 17;
            // 
            // initial_Label
            // 
            this.initial_Label.AutoSize = true;
            this.initial_Label.Location = new System.Drawing.Point(12, 46);
            this.initial_Label.Name = "initial_Label";
            this.initial_Label.Size = new System.Drawing.Size(122, 13);
            this.initial_Label.TabIndex = 18;
            this.initial_Label.Text = "Начальная стоимость:";
            // 
            // final_Label
            // 
            this.final_Label.AutoSize = true;
            this.final_Label.Location = new System.Drawing.Point(12, 72);
            this.final_Label.Name = "final_Label";
            this.final_Label.Size = new System.Drawing.Size(115, 13);
            this.final_Label.TabIndex = 20;
            this.final_Label.Text = "Конечная стоимость:";
            // 
            // final_TextBox
            // 
            this.final_TextBox.Location = new System.Drawing.Point(140, 69);
            this.final_TextBox.Name = "final_TextBox";
            this.final_TextBox.Size = new System.Drawing.Size(158, 20);
            this.final_TextBox.TabIndex = 19;
            // 
            // findPrice_Button
            // 
            this.findPrice_Button.Location = new System.Drawing.Point(15, 262);
            this.findPrice_Button.Name = "findPrice_Button";
            this.findPrice_Button.Size = new System.Drawing.Size(283, 28);
            this.findPrice_Button.TabIndex = 21;
            this.findPrice_Button.Text = "Поиск";
            this.findPrice_Button.UseVisualStyleBackColor = true;
            this.findPrice_Button.Click += new System.EventHandler(this.findPrice_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Поиск:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "По цене",
            "По весу",
            "По дате",
            "По количеству"});
            this.comboBox1.Location = new System.Drawing.Point(62, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TwoUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.findPrice_Button);
            this.Controls.Add(this.final_Label);
            this.Controls.Add(this.final_TextBox);
            this.Controls.Add(this.initial_Label);
            this.Controls.Add(this.initial_TextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaveToUserForm_Button);
            this.Name = "TwoUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TwoUserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TwoUserForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leaveToUserForm_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox initial_TextBox;
        private System.Windows.Forms.Label initial_Label;
        private System.Windows.Forms.Label final_Label;
        private System.Windows.Forms.TextBox final_TextBox;
        private System.Windows.Forms.Button findPrice_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}