using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home_Accounting
{
    public partial class Form1 : Form
    {
        Controller controller;
        const string AllCategories = "Все категории";

        public Form1(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;

            UpdateData();



        }

        private void UpdateData()//обновление данных
        {
            comboBox1.Items.Clear();
            SumComboBox.Items.Clear();
            CategoryComboBox.Items.Clear();
            

            comboBox1.Items.AddRange(controller.GetCategoryList().ToArray());
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";

            SumComboBox.Items.Add(AllCategories);
            SumComboBox.Items.AddRange(controller.GetCategoryList().ToArray());
            SumComboBox.SelectedIndex = 0;

            CategoryComboBox.Items.AddRange(controller.GetCategoryList().ToArray());
            CategoryComboBox.SelectedIndex = -1;
            CategoryComboBox.Text = "";
            UpdateTable();

        }
        
        private void UpdateTable()
        {

           var res = controller.GetAccountingTable(out AccountingTable accountingTable);
            if(res!= null )
            {
                //MessageBox.Show(res);
                return;
            }
           // MessageBox.Show($"{accountingTable.Categories.Length},{accountingTable.DateTimes.Length}");
            TableAccounting.Controls.Clear();
            TableAccounting.ColumnCount = accountingTable.Categories.Length + 1;
            TableAccounting.RowCount = accountingTable.DateTimes.Length + 1;
           // MessageBox.Show($"{TableAccounting.ColumnCount},{TableAccounting.RowCount}");
            for (int i = 0; i < accountingTable.Categories.Length; i++)
            {
                Label label = new Label();
                label.Text = accountingTable.Categories[i];
                TableAccounting.Controls.Add(label, i + 1, 0);
                TableAccounting.SetRow(label, 0);
                TableAccounting.SetColumn(label, i+1);
            }
            for(int i = 0; i < accountingTable.DateTimes.Length;i++)
            {
                Label label = new Label();
                label.Text = accountingTable.DateTimes[i].ToString();
                TableAccounting.Controls.Add(label,0,i+1);
                TableAccounting.SetRow(label, i+1);
                TableAccounting.SetColumn(label, 0);
            }
            for(int i = 0; i < accountingTable.Values.GetLength(0); i++)
            {
                for(int j = 0; j < accountingTable.Values.GetLength(1); j++)
                {
                    Label label = new Label();

                    label.Text = accountingTable.Values [i,j].ToString();
                    TableAccounting.Controls.Add (label,i+1,j+1);
                    TableAccounting.SetRow(label, j+1);
                    TableAccounting.SetColumn(label, i + 1);
                }

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.ChangeAccouting();
            Application.Exit();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null) return;
            string res = controller.AddCategory(textBox1.Text);
            textBox1.Text = "";
            if (res != null)
            {
                MessageBox.Show(res);
            }
            else
            {
                UpdateData();
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            string res = controller.DeleteCategory(comboBox1.SelectedItem.ToString());
            if (res != null)
            {
                MessageBox.Show(res);
            }
            else
            {
                UpdateData();
            }
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            if(SumComboBox.SelectedItem == null) return;
            DateTime dateTime = DatePeriodTimePicker1.Value.Date;
            DateTime dateTime2 = DatePeriodTimePicker2.Value.Date;
            int sum = 0;
            if (SumComboBox.SelectedItem.ToString() == AllCategories)
            {
                List<string> categories = controller.GetCategoryList();

                foreach (var category in categories)
                {
                    string res = controller.GetSum(category, dateTime, dateTime2, out int money);
                    if (res != null)
                    {
                        MessageBox.Show(res);
                        return;
                    }
                    else
                    {
                        sum += money;
                    }
                }

            }
            else
            {
                string res = controller.GetSum(SumComboBox.SelectedItem.ToString(), dateTime, dateTime2, out sum);
                if (res != null)
                {
                    MessageBox.Show(res);
                    return;
                }

            }
            SumLabel.Text = sum.ToString() + " руб";

        }

        private void AddSumButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem == null || DateTimePickerSum.Value == null
                || (int)AddSumNumericUpDown1.Value == 0)  return;
            DateTime dateTime = DateTimePickerSum.Value.Date;
           
            var res = controller.AddExpenseItem(CategoryComboBox.SelectedItem.ToString(), dateTime, (int)AddSumNumericUpDown1.Value);
            AddSumNumericUpDown1.Value = 0;
            if (res != null)
            {
                MessageBox.Show(res);
            }
            else
            {
                UpdateData();
            }

        }

        
    }
}
