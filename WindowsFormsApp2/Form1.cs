using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        private string connstring = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", "5432",
             "postgres", "grayback45", "login");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private NpgsqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            try
            {
                if (username.Text != string.Empty || password.Text != string.Empty)
                {
                    sql = "select * from users where username ='" + username.Text + "' AND password ='" + password.Text + "';";
                    cmd = new NpgsqlCommand(sql, conn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        this.Hide();
                        dr.Close();
                       Form3 frm3 = new Form3();
                        frm3.ShowDialog();
                        
                    }
                    else
                    {
                        label4.Text = "The credentials that you entered is incorrect pls try again.";
                    }
                }
                else
                {
                    
                    label4.Text = "Please Fill up the required credentials";
                    
                }
            }catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("Please check your internet conenction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("you need to connect on internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }
    }
}
