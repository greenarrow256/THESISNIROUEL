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
    public partial class Form4 : Form
    {
       

        private string connstring = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", "5432",
             "postgres", "grayback45", "login");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private NpgsqlDataReader dr;
        Form3 f3;
        public Form4(Form3 fr3)
        {

            InitializeComponent();
            f3 = fr3;
            
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            trace.Clear();
            lname.Clear();
            fname.Clear();
            mname.Clear();
            age.Clear();
            genderbox.Text = string.Empty;
            birthdate.Value = DateTime.Now;
            address.Clear();
            contact.Clear();
            statusbox.Text = string.Empty;
            interviewer.Clear();
            dateinterview.Value = DateTime.Now;
            symptoms.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new NpgsqlConnection(connstring);
                conn.Open();

               
               
                if (trace.Text == string.Empty || lname.Text == string.Empty ||  fname.Text == string.Empty || mname.Text == string.Empty || age.Text == string.Empty || genderbox.Text == string.Empty || address.Text == string.Empty || contact.Text == string.Empty || statusbox.Text == string.Empty || interviewer.Text == string.Empty || symptoms.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                  
                    int trace_no = int.Parse(trace.Text);
                    int age1 = int.Parse(age.Text);
                    cmd = new NpgsqlCommand("insert into people values(@trace_no, @lname, @fname, @mname, @age, @birthdate, @gender, @address, @contactno, @status, @interviewer, @date_interviewed, @symptoms)", conn);
                    cmd.Parameters.AddWithValue("@trace_no", trace_no);
                    cmd.Parameters.AddWithValue("@lname", lname.Text);
                    cmd.Parameters.AddWithValue("@fname", fname.Text);
                    cmd.Parameters.AddWithValue("@mname", mname.Text);
                    cmd.Parameters.AddWithValue("@age", age1);
                    cmd.Parameters.AddWithValue("@birthdate", birthdate.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", genderbox.Text);
                    cmd.Parameters.AddWithValue("@address", address.Text);
                    cmd.Parameters.AddWithValue("@contactno", contact.Text);
                    cmd.Parameters.AddWithValue("@status", statusbox.Text);
                    cmd.Parameters.AddWithValue("@interviewer", interviewer.Text);
                    cmd.Parameters.AddWithValue("@date_interviewed", dateinterview.Value.Date);
                    cmd.Parameters.AddWithValue("@symptoms", symptoms.Text);
                    cmd.ExecuteNonQuery();               
                    f3.displayPeople();
                    MessageBox.Show("Data added successfully", "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    conn.Close();
                   
                    
                }

            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {

            Char chr = e.KeyChar;
            if(!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("This input allows only numeric values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
           
        }

        private void contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("This input allows only numeric values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trace_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("This input allows only numeric values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void birthdate_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
