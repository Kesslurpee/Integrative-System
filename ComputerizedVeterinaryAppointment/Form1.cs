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
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;  
            this.Width = width; 
            this.Height = height-40;
            Top = 0;
            Left = 0;
        }
        void LoadPasyente()
        {
            connection.Open();
            int i = 0;
            command = new SqlCommand("select * from patient", connection);
            reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                i++;
                
            }
            PatientNo.Text = i.ToString();
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
        }
    }
}
