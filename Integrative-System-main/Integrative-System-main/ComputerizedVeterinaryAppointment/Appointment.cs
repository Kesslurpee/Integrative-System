using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComputerizedVeterinaryAppointment
{
    public partial class Appointment : Form
    {
        Form1 form = new Form1();
        SqlConnection connection = new SqlConnection(DataBase.con);
        SqlCommand command;
        SqlDataReader reader;

        public Appointment(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            LoadPasyente();
        }
       public void LoadPasyente()
        {
            int i = 0;
            AppointmentGrid.Rows.Clear();
            connection.Open();
            command = new SqlCommand("select * from Patient", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                AppointmentGrid.Rows.Add(reader["id"], i, reader["Patient_name"], reader["Patient_owner"], reader["patient_Phone"], reader["Patient_image"], "Edit", "Delete");

            }
            connection.Close();

        }

        private void PatientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddAppointment_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand("update patient set patient_appointment='appointment' where id=@id", connection);
            command.Parameters.AddWithValue("@id", AppointmentGrid.CurrentRow.Cells[0].Value);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Appointment has been successfully added!");
        }

        private void AppointmentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Name.Text = AppointmentGrid.CurrentRow.Cells[2].Value.ToString();
            Owner.Text = AppointmentGrid.CurrentRow.Cells[3].Value.ToString();
            Phone.Text = AppointmentGrid.CurrentRow.Cells[4].Value.ToString();
            byte[] img = (byte[])AppointmentGrid.CurrentRow.Cells[5].Value;
            MemoryStream memory = new MemoryStream(img);
            PasyentePic.Image = Image.FromStream(memory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
