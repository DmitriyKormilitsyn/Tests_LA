namespace Test
{
    partial class Choice_group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice_group));
            this.Exit_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TestName_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Part_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fam_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Group_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Exit_button.Location = new System.Drawing.Point(689, 341);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(131, 63);
            this.Exit_button.TabIndex = 2;
            this.Exit_button.Text = "Выход";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TestName_comboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Part_textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Name_textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Fam_textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Group_comboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(65, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 261);
            this.panel1.TabIndex = 3;
            // 
            // TestName_comboBox
            // 
            this.TestName_comboBox.FormattingEnabled = true;
            this.TestName_comboBox.Location = new System.Drawing.Point(182, 213);
            this.TestName_comboBox.Name = "TestName_comboBox";
            this.TestName_comboBox.Size = new System.Drawing.Size(524, 24);
            this.TestName_comboBox.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(16, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 40);
            this.label5.TabIndex = 37;
            this.label5.Text = "Название\r\nтеста";
            // 
            // Part_textBox
            // 
            this.Part_textBox.Location = new System.Drawing.Point(182, 157);
            this.Part_textBox.Name = "Part_textBox";
            this.Part_textBox.Size = new System.Drawing.Size(524, 22);
            this.Part_textBox.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(16, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Отчество";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(182, 107);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(524, 22);
            this.Name_textBox.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Имя";
            // 
            // Fam_textBox
            // 
            this.Fam_textBox.Location = new System.Drawing.Point(182, 61);
            this.Fam_textBox.Name = "Fam_textBox";
            this.Fam_textBox.Size = new System.Drawing.Size(524, 22);
            this.Fam_textBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Фамилия:";
            // 
            // Group_comboBox
            // 
            this.Group_comboBox.FormattingEnabled = true;
            this.Group_comboBox.Location = new System.Drawing.Point(182, 13);
            this.Group_comboBox.Name = "Group_comboBox";
            this.Group_comboBox.Size = new System.Drawing.Size(524, 24);
            this.Group_comboBox.TabIndex = 30;
            this.Group_comboBox.SelectedIndexChanged += new System.EventHandler(this.Group_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Группа:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(61, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Заполните поля:";
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NextButton.Location = new System.Drawing.Point(543, 341);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(131, 61);
            this.NextButton.TabIndex = 29;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Choice_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 425);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Choice_group";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Choice_group_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Group_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Part_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fam_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TestName_comboBox;
        private System.Windows.Forms.Button NextButton;
    }
}

