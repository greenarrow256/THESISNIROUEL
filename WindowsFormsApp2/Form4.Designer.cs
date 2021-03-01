
namespace WindowsFormsApp2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trace = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.address = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.statusbox = new System.Windows.Forms.ComboBox();
            this.interviewer = new System.Windows.Forms.TextBox();
            this.dateinterview = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.symptoms = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trace #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Birthdate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Contact #:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 567);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Interviewed by:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 620);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Date Interviewed:";
            // 
            // trace
            // 
            this.trace.Location = new System.Drawing.Point(159, 70);
            this.trace.Name = "trace";
            this.trace.Size = new System.Drawing.Size(363, 22);
            this.trace.TabIndex = 11;
            this.trace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trace_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Gender:";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(159, 110);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(363, 22);
            this.lname.TabIndex = 16;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(159, 154);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(363, 22);
            this.fname.TabIndex = 17;
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(159, 194);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(363, 22);
            this.mname.TabIndex = 18;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(159, 243);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(363, 22);
            this.age.TabIndex = 19;
            this.age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_KeyPress);
            // 
            // genderbox
            // 
            this.genderbox.DisplayMember = "Female";
            this.genderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderbox.Location = new System.Drawing.Point(159, 280);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(360, 24);
            this.genderbox.TabIndex = 20;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(159, 320);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(363, 22);
            this.birthdate.TabIndex = 21;
            
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(159, 366);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(365, 77);
            this.address.TabIndex = 22;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(156, 466);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(363, 22);
            this.contact.TabIndex = 23;
            this.contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contact_KeyPress);
            // 
            // statusbox
            // 
            this.statusbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusbox.FormattingEnabled = true;
            this.statusbox.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.statusbox.Location = new System.Drawing.Point(159, 514);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(360, 24);
            this.statusbox.TabIndex = 24;
            // 
            // interviewer
            // 
            this.interviewer.Location = new System.Drawing.Point(159, 564);
            this.interviewer.Name = "interviewer";
            this.interviewer.Size = new System.Drawing.Size(363, 22);
            this.interviewer.TabIndex = 25;
            // 
            // dateinterview
            // 
            this.dateinterview.Location = new System.Drawing.Point(159, 620);
            this.dateinterview.Name = "dateinterview";
            this.dateinterview.Size = new System.Drawing.Size(365, 22);
            this.dateinterview.TabIndex = 26;
            this.dateinterview.Value = new System.DateTime(2021, 2, 28, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 60);
            this.button1.TabIndex = 27;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 709);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 60);
            this.button2.TabIndex = 28;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(370, 709);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 60);
            this.button3.TabIndex = 29;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 29);
            this.label13.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 664);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Symptoms:";
            // 
            // symptoms
            // 
            this.symptoms.Location = new System.Drawing.Point(159, 664);
            this.symptoms.Name = "symptoms";
            this.symptoms.Size = new System.Drawing.Size(365, 22);
            this.symptoms.TabIndex = 33;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 812);
            this.ControlBox = false;
            this.Controls.Add(this.symptoms);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateinterview);
            this.Controls.Add(this.interviewer);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.address);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.age);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trace);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox trace;
        public System.Windows.Forms.TextBox lname;
        public System.Windows.Forms.TextBox fname;
        public System.Windows.Forms.TextBox mname;
        public System.Windows.Forms.TextBox age;
        public System.Windows.Forms.ComboBox genderbox;
        public System.Windows.Forms.DateTimePicker birthdate;
        public System.Windows.Forms.TextBox address;
        public System.Windows.Forms.TextBox contact;
        public System.Windows.Forms.ComboBox statusbox;
        public System.Windows.Forms.TextBox interviewer;
        public System.Windows.Forms.DateTimePicker dateinterview;
        public System.Windows.Forms.TextBox symptoms;
    }
}