using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ComputerizedVeterinaryAppointment
{
    public partial class CreateNewPatient : Form
    {
        SqlConnection connect = new SqlConnection(DataBase.con);
        SqlCommand command;
        Pasyente p = new Pasyente();
        
        
        public CreateNewPatient(Pasyente p)
        {
            InitializeComponent();
            
            this.p = p;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose image |*.png;*.bmp;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK ) 
            {
                PatientPic.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            connect.Open();
            command = new SqlCommand("insert into patient (Patient_name, Patient_owner, Patient_phone, Patient_image) values (@Patient_name,@Patient_owner,@Patient_phone,@Patient_image)", connect);
            MemoryStream memory = new MemoryStream();
            if (PatientPic.Image != null)
            {


                PatientPic.Image.Save(memory, PatientPic.Image.RawFormat);
                byte[] img = memory.ToArray();
                command.Parameters.AddWithValue("@Patient_name", PatientName.Text);
                command.Parameters.AddWithValue("@Patient_owner", PatientOwner.Text);
                command.Parameters.AddWithValue("@Patient_phone", PatientPhone.Text);
                command.Parameters.AddWithValue("@Patient_image", img);
                command.ExecuteNonQuery();
                connect.Close();

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = "";
                    }
                }

                PatientPic.Image = new PictureBox().Image;
                Form1 form = new Form1();
                form.LoadPasyente();



                MessageBox.Show("Record has been saved successfully!");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            connect.Open();
            command = new SqlCommand("update patient set Patient_name=@Patient_name,Patient_owner=@Patient_owner,Patient_phone=@Patient_phone,Patient_image=@Patient_image where id=@id", connect);
            MemoryStream memory = new MemoryStream();
            PatientPic.Image.Save(memory, PatientPic.Image.RawFormat);
            byte[] img = memory.ToArray();
            command.Parameters.AddWithValue("@Patient_name", PatientName.Text);
            command.Parameters.AddWithValue("@Patient_owner", PatientOwner.Text);
            command.Parameters.AddWithValue("@Patient_phone", PatientPhone.Text);
            command.Parameters.AddWithValue("@Patient_image", img);
            command.Parameters.AddWithValue("@id", DataBase._id);
            command.ExecuteNonQuery();
            connect.Close();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }

            PatientPic.Image = new PictureBox().Image;

            MessageBox.Show("Record has been updated successfully!");
            this.Dispose();
        }

        private void PatientPic_Click(object sender, EventArgs e)
        {

        }
    }
}
