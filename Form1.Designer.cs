namespace Home_Accounting
{
    partial class Form1
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
            this.TableAccounting = new System.Windows.Forms.TableLayoutPanel();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DatePeriodTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DatePeriodTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SumComboBox = new System.Windows.Forms.ComboBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DateTimePickerSum = new System.Windows.Forms.DateTimePicker();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AddSumButton = new System.Windows.Forms.Button();
            this.AddSumNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddSumNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableAccounting
            // 
            this.TableAccounting.AutoSize = true;
            this.TableAccounting.ColumnCount = 2;
            this.TableAccounting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableAccounting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableAccounting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableAccounting.Location = new System.Drawing.Point(21, 17);
            this.TableAccounting.Name = "TableAccounting";
            this.TableAccounting.RowCount = 2;
            this.TableAccounting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableAccounting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableAccounting.Size = new System.Drawing.Size(171, 58);
            this.TableAccounting.TabIndex = 0;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(14, 78);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(140, 42);
            this.AddCategoryButton.TabIndex = 1;
            this.AddCategoryButton.Text = "Добавить категорию";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(166, 78);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(118, 42);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить категорию";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 24);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(3, 92);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(115, 42);
            this.SumButton.TabIndex = 5;
            this.SumButton.Text = "Сумма";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.AddCategoryButton);
            this.panel1.Location = new System.Drawing.Point(18, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 137);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DatePeriodTimePicker2);
            this.panel2.Controls.Add(this.DatePeriodTimePicker1);
            this.panel2.Controls.Add(this.SumComboBox);
            this.panel2.Controls.Add(this.SumLabel);
            this.panel2.Controls.Add(this.SumButton);
            this.panel2.Location = new System.Drawing.Point(342, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 137);
            this.panel2.TabIndex = 7;
            // 
            // DatePeriodTimePicker2
            // 
            this.DatePeriodTimePicker2.Location = new System.Drawing.Point(130, 54);
            this.DatePeriodTimePicker2.Name = "DatePeriodTimePicker2";
            this.DatePeriodTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.DatePeriodTimePicker2.TabIndex = 9;
            // 
            // DatePeriodTimePicker1
            // 
            this.DatePeriodTimePicker1.Location = new System.Drawing.Point(130, 28);
            this.DatePeriodTimePicker1.Name = "DatePeriodTimePicker1";
            this.DatePeriodTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DatePeriodTimePicker1.TabIndex = 8;
            // 
            // SumComboBox
            // 
            this.SumComboBox.FormattingEnabled = true;
            this.SumComboBox.Location = new System.Drawing.Point(3, 27);
            this.SumComboBox.Name = "SumComboBox";
            this.SumComboBox.Size = new System.Drawing.Size(121, 21);
            this.SumComboBox.TabIndex = 7;
            // 
            // SumLabel
            // 
            this.SumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SumLabel.Location = new System.Drawing.Point(124, 92);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(108, 38);
            this.SumLabel.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DateTimePickerSum);
            this.panel3.Controls.Add(this.CategoryComboBox);
            this.panel3.Controls.Add(this.AddSumButton);
            this.panel3.Controls.Add(this.AddSumNumericUpDown1);
            this.panel3.Location = new System.Drawing.Point(695, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 132);
            this.panel3.TabIndex = 8;
            // 
            // DateTimePickerSum
            // 
            this.DateTimePickerSum.Location = new System.Drawing.Point(14, 52);
            this.DateTimePickerSum.Name = "DateTimePickerSum";
            this.DateTimePickerSum.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerSum.TabIndex = 9;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(158, 17);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 2;
            // 
            // AddSumButton
            // 
            this.AddSumButton.Location = new System.Drawing.Point(14, 84);
            this.AddSumButton.Name = "AddSumButton";
            this.AddSumButton.Size = new System.Drawing.Size(103, 45);
            this.AddSumButton.TabIndex = 1;
            this.AddSumButton.Text = "Добавить сумму траты";
            this.AddSumButton.UseVisualStyleBackColor = true;
            this.AddSumButton.Click += new System.EventHandler(this.AddSumButton_Click);
            // 
            // AddSumNumericUpDown1
            // 
            this.AddSumNumericUpDown1.Location = new System.Drawing.Point(14, 18);
            this.AddSumNumericUpDown1.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.AddSumNumericUpDown1.Name = "AddSumNumericUpDown1";
            this.AddSumNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.AddSumNumericUpDown1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 637);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TableAccounting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddSumNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableAccounting;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DatePeriodTimePicker2;
        private System.Windows.Forms.DateTimePicker DatePeriodTimePicker1;
        private System.Windows.Forms.ComboBox SumComboBox;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker DateTimePickerSum;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button AddSumButton;
        private System.Windows.Forms.NumericUpDown AddSumNumericUpDown1;
    }
}

