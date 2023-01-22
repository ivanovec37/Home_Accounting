using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Accounting
{
    public partial class RegistrationForm : Form
    {
        private User newUser;
        public User NewUser
        {
            get
            {
                return newUser;
            }
        }
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            newUser = new User(Login_TextBox1.Text, Password_TextBox1.Text);
            this.DialogResult = DialogResult.OK;
        }
       

        private void cancel_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {

            Controller controller = new Controller();
           var res =  controller.Authorization(Login_TextBox1.Text,Password_TextBox1.Text);
            if(res == null)
            {
                Form1 form1 = new Form1(controller);
                
                form1.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(res);  
            }
        }

        private void Registration_Button_Click_1(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            var res = controller.Registration(LoginTextBox2.Text,PasswordTextBox2.Text);
            if (res == null)
            {
                Form1 form1 = new Form1(controller);

                form1.Show();
               
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(res);
            }
        }
    }
}
