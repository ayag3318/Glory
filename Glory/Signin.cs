using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glory;

namespace Glory
{
    public partial class Signin : Form
    {
        GloryDBTableAdapters.UserTableAdapter SigninAdapter = 
            new GloryDBTableAdapters.UserTableAdapter();
        GloryDB.UserDataTable SigninDatatable = new GloryDB.UserDataTable();
        GloryDB.UserRow signinRow;
       
        public Signin()
        {
            InitializeComponent();


            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SigninAdapter.Connection.Open();
            SigninAdapter.GetData();
            SigninAdapter.Fill(SigninDatatable);
            SigninAdapter.Connection.Close();

          


                
           
            if( textBox1.Text.Equals("") || textBox1.Text.Equals("")) {

                MessageBox.Show("please fill in your information ");
            }
            else 
            {

                
                
                {
                    signinRow =  SigninDatatable.FindByUserName(textBox1.Text);

                    
                    if (signinRow == null)
                    {
                        MessageBox.Show("Wrong User Name or Password");
                        return;
                    }
                    
                    else if (signinRow.UserPasword == textBox2.Text && signinRow.UserName == textBox1.Text )
                    {
                        var m = new Main();
                        m.StartPosition = FormStartPosition.CenterScreen;
                        m.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("please enter a valid password");
                };

            };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
