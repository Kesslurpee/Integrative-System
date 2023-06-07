using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ComputerizedVeterinaryAppointment
{
    public partial class Diagnose : Form
    {
        SqlConnection connection = new SqlConnection(DataBase.con);
        SqlCommand command;
        SqlDataReader reader;
        public Diagnose()
        {
            InitializeComponent();
            LoadPasyente();
        }
        public void LoadPasyente()
        {
            int i = 0;
            DiagnoseGrid.Rows.Clear();
            connection.Open();
            command = new SqlCommand("select * from Patient where patient_appointment='appointment'", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                DiagnoseGrid.Rows.Add(reader["id"], i, reader["Patient_name"], reader["Patient_owner"], reader["patient_Phone"], reader["Patient_image"], "Edit", "Delete");

            }
            connection.Close();

        }

        private void DiagnoseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Name.Text = DiagnoseGrid.CurrentRow.Cells[2].Value.ToString();
            Owner.Text = DiagnoseGrid.CurrentRow.Cells[3].Value.ToString();
            Phone.Text = DiagnoseGrid.CurrentRow.Cells[4].Value.ToString();
            byte[] img = (byte[])DiagnoseGrid.CurrentRow.Cells[5].Value;
            MemoryStream memory = new MemoryStream(img);
            PasyentePic.Image = Image.FromStream(memory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadPasyente();
        }
    }
}
