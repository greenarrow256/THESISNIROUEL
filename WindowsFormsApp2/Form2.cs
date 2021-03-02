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
    public partial class Form2 : Form
    {
        private string connstring = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", "5432",
             "postgres", "grayback45", "login");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private NpgsqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                if (tbID.Text != string.Empty || tbUser.Text != string.Empty || tbPass.Text != string.Empty)
                    {
                        sql = "select * from users where ct_id=" + tbID.Text + "AND username IS NULL;";
                        cmd = new NpgsqlCommand(sql, conn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            cmd = new NpgsqlCommand("update users set username=@username, password=@password where ct_id=" + tbID.Text + ";", conn);
                            cmd.Parameters.AddWithValue("@username", tbUser.Text);
                            cmd.Parameters.AddWithValue("@password", tbPass.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        }
                        else
                        {
                            MessageBox.Show("this ID already has a username or it Doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }

                    }
                    else
                    {
                        MessageBox.Show("You need to fill the following requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Please check your internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("Please check your internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("You're now allowed to put space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
