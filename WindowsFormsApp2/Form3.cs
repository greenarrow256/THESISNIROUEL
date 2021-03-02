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
    public partial class Form3 : Form
    {
        string trace, lastname, firstname, middlename, ag, brdt, gen, add, connum, stat, interv, dtinterv, symp;

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            int i = 0;
            dataGridView1.Rows.Clear();
            sql = "select * from people where CONCAT (trace_no, lname, fname, mname, age, birthdate, gender, address, contactno, status, interviewer, date_interviewed, symptoms) like '%" + txtsearch.Text+ "%';";
            cmd = new NpgsqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayPeople();
        }

        private void logutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Dispose();
            fr1.ShowDialog();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private string connstring = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", "5432",
             "postgres", "grayback45", "login");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private NpgsqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
            displayPeople();
          



        }



        public void displayPeople()
        {

            conn = new NpgsqlConnection(connstring);
            conn.Open();
           
            int i = 0;
            dataGridView1.Rows.Clear();         
            sql = "select trace_no, lname,fname, mname, age, to_char(birthdate, 'dd-MM-yyyy'), gender, address, contactno, status, interviewer, to_char(date_interviewed, 'dd-MM-yyyy'), symptoms from people";
            cmd = new NpgsqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
               
                i += 1;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString());               

            }


            dr.Close();
            conn.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string colnanme = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colnanme == "edit")
            {
                Form4 fr4 = new Form4(this);
                fr4.button1.Enabled = false;
                fr4.button2.Enabled = true;
                fr4.button3.Enabled = true;
                fr4.trace.Enabled = false;
                fr4.trace.Text = trace;
                fr4.lname.Text = lastname;
                fr4.fname.Text = firstname;
                fr4.mname.Text = middlename;
                fr4.age.Text = ag;
                fr4.birthdate.Value = DateTime.Parse(brdt);
                fr4.genderbox.Text = gen;
                fr4.address.Text = add;
                fr4.contact.Text = connum;
                fr4.statusbox.Text = stat;
                fr4.interviewer.Text = interv;
                fr4.dateinterview.Value = DateTime.Parse(dtinterv);
                fr4.symptoms.Text = symp;
                fr4.label13.Text = "UPDATE PATIENT";
                fr4.ShowDialog();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4(this);
            fr4.label13.Text = "INSERT DATA";
            fr4.button2.Enabled = false;
            fr4.ShowDialog();
           

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int d = dataGridView1.CurrentRow.Index;
            trace = dataGridView1[1, d].Value.ToString();
            lastname = dataGridView1[2, d].Value.ToString();
            firstname = dataGridView1[3, d].Value.ToString();
            middlename = dataGridView1[4, d].Value.ToString();
            ag = dataGridView1[5, d].Value.ToString();
            brdt = dataGridView1[6, d].Value.ToString();
            gen = dataGridView1[7, d].Value.ToString();
            add = dataGridView1[8, d].Value.ToString();
            connum = dataGridView1[9, d].Value.ToString();
            stat = dataGridView1[10, d].Value.ToString();
            interv = dataGridView1[11, d].Value.ToString();
            dtinterv = dataGridView1[12, d].Value.ToString();
            symp = dataGridView1[13, d].Value.ToString();
        }
    }
}
