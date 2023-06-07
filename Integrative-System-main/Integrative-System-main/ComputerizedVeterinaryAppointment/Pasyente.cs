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
using System.IO;

namespace ComputerizedVeterinaryAppointment
{
    public partial class Pasyente : Form
    {
        SqlConnection connection = new SqlConnection(DataBase.con);
        SqlCommand command;
        SqlDataReader read;
        
       
        public Pasyente(Form1 form1)
        {
            InitializeComponent();
               
            LoadPasyente();
        }

        public Pasyente()
        {
        }

        public void LoadPasyente()
        {
            int i = 0;
            PatientGrid.Rows.Clear();
            connection.Open();
            command = new SqlCommand("select * from Patient", connection);
            read = command.ExecuteReader();
            while(read.Read())
            {
                i++;
                PatientGrid.Rows.Add(read["id"], i, read["Patient_name"], read["Patient_owner"], read["patient_Phone"], read["Patient_image"],"Edit", "Delete");

            }
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Pasyente_Load(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateNewPatient c = new CreateNewPatient(this);
            c.ShowDialog();
        }

        private void PatientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PasyentePic_Click(object sender, EventArgs e)
        {

        }

        private void PatientGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBase._id = (int)PatientGrid.CurrentRow.Cells[0].Value;
            Name.Text = PatientGrid.CurrentRow.Cells[2].Value.ToString();
            Owner.Text = PatientGrid.CurrentRow.Cells[3].Value.ToString();
            Phone.Text = PatientGrid.CurrentRow.Cells[4].Value.ToString();
            byte[] img = (byte[])PatientGrid.CurrentRow.Cells[5].Value;
            MemoryStream memory = new MemoryStream(img);
            PasyentePic.Image = Image.FromStream(memory);
            string name = PatientGrid.Columns[e.ColumnIndex].Name;

            if (name == "Edit")
            {
                
                CreateNewPatient c = new CreateNewPatient(this);
                c.PatientName.Text = PatientGrid.CurrentRow.Cells[2].Value.ToString();
                c.PatientOwner.Text = PatientGrid.CurrentRow.Cells[3].Value.ToString(); 
                c.PatientPhone.Text = PatientGrid.CurrentRow.Cells[4].Value.ToString();
                byte[] image = (byte[])PatientGrid.CurrentRow.Cells[5].Value;
                MemoryStream mem = new MemoryStream(image);
                c.PatientPic.Image = Image.FromStream(mem);
                c.Add.Enabled = false;
                c.Update.Enabled = true;
                c.AddPatient.Text = "Edit Patient";
                c.ShowDialog();
            }
            if (name == "Delete")
            {

                command = new SqlCommand("Delete from patient where id=@id", connection);
                command.Parameters.AddWithValue("@id", DataBase._id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record has been deleted successfully!");
                LoadPasyente();
                }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Phone_Click(object sender, EventArgs e)
        {

        }

        private void Owner_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }
    }
}
