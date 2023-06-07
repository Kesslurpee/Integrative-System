using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ComputerizedVeterinaryAppointment
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(DataBase.con);
        SqlCommand command;
        SqlDataReader reader;
        
        public Form1()
        {
            InitializeComponent();
            LoadPasyente();
            LoadAppointment();
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }
        void LoadPasyente()
        {
            connection.Open();
            
            command = new SqlCommand("select count(*) from patient where patient_appointment='appointment'", connection);
            reader = command.ExecuteReader();
            PatientNo.Text = command.ExecuteScalar().ToString();
            connection.Close();

        }
       public void LoadAppointment()
        {
            connection.Open();

            command = new SqlCommand("select count(*) from patient", connection);
            reader = command.ExecuteReader();
            AppointmentNo.Text = command.ExecuteScalar().ToString();
            connection.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DATE.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pasyente p = new Pasyente(this);
            p.TopLevel = false;
            MainPanel.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pasyente p = new Pasyente(this);
            p.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Appointment a = new Appointment(this);
            
            a.BringToFront();
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DATE.Text = date.ToString();
            LoadPasyente();
            LoadAppointment();
        }
    }
}
