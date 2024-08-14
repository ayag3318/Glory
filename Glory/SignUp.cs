using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glory
{
    public partial class SignUp : Form

    {

        GloryDBTableAdapters.UserTableAdapter SignUpAdapter =
            new GloryDBTableAdapters.UserTableAdapter();
        GloryDB.UserDataTable SignUPDatatable = new GloryDB.UserDataTable();
        
        public SignUp()
        {
            InitializeComponent();
            SignUpAdapter.Fill(SignUPDatatable);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            GloryDB.UserRow signUpRow = SignUPDatatable.NewUserRow();

            signUpRow.UserName = textBox1.Text;
            signUpRow.UserPasword = textBox2.Text;
            GloryDB.UserRow CheckDublicateUser = SignUPDatatable.NewUserRow();
            CheckDublicateUser = SignUPDatatable.FindByUserName(textBox1.Text);
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please enter valid data");
                return;
            }

            else 
            {
                

                if (CheckDublicateUser.UserName != signUpRow.UserName)
                {
                    SignUPDatatable.Rows.Add(signUpRow);
                    SignUpAdapter.Update(SignUPDatatable);
                }
                else 
                {
                    MessageBox.Show("username already exists");
                }

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var back = new Main();
            back.Show();
            this.Hide();
        }
    }
}
