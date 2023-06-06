namespace ComputerizedVeterinaryAppointment
{
    partial class CreateNewPatient
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
            System.Windows.Forms.Label patient_nameLabel;
            System.Windows.Forms.Label patient_ownerLabel;
            System.Windows.Forms.Label patient_PhoneLabel;
            System.Windows.Forms.Label patient_imageLabel;
            this.button3 = new System.Windows.Forms.Button();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.PatientOwner = new System.Windows.Forms.TextBox();
            this.PatientPhone = new System.Windows.Forms.TextBox();
            this.PatientPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPatient = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            patient_nameLabel = new System.Windows.Forms.Label();
            patient_ownerLabel = new System.Windows.Forms.Label();
            patient_PhoneLabel = new System.Windows.Forms.Label();
            patient_imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patient_nameLabel
            // 
            patient_nameLabel.AutoSize = true;
            patient_nameLabel.ForeColor = System.Drawing.Color.White;
            patient_nameLabel.Location = new System.Drawing.Point(12, 52);
            patient_nameLabel.Name = "patient_nameLabel";
            patient_nameLabel.Size = new System.Drawing.Size(72, 13);
            patient_nameLabel.TabIndex = 13;
            patient_nameLabel.Text = "Patient name:";
            // 
            // patient_ownerLabel
            // 
            patient_ownerLabel.AutoSize = true;
            patient_ownerLabel.ForeColor = System.Drawing.Color.White;
            patient_ownerLabel.Location = new System.Drawing.Point(12, 78);
            patient_ownerLabel.Name = "patient_ownerLabel";
            patient_ownerLabel.Size = new System.Drawing.Size(75, 13);
            patient_ownerLabel.TabIndex = 15;
            patient_ownerLabel.Text = "Patient owner:";
            // 
            // patient_PhoneLabel
            // 
            patient_PhoneLabel.AutoSize = true;
            patient_PhoneLabel.ForeColor = System.Drawing.Color.White;
            patient_PhoneLabel.Location = new System.Drawing.Point(12, 104);
            patient_PhoneLabel.Name = "patient_PhoneLabel";
            patient_PhoneLabel.Size = new System.Drawing.Size(77, 13);
            patient_PhoneLabel.TabIndex = 17;
            patient_PhoneLabel.Text = "Patient Phone:";
            // 
            // patient_imageLabel
            // 
            patient_imageLabel.AutoSize = true;
            patient_imageLabel.ForeColor = System.Drawing.Color.White;
            patient_imageLabel.Location = new System.Drawing.Point(12, 197);
            patient_imageLabel.Name = "patient_imageLabel";
            patient_imageLabel.Size = new System.Drawing.Size(74, 13);
            patient_imageLabel.TabIndex = 19;
            patient_imageLabel.Text = "Patient image:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(167, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 38);
            this.button3.TabIndex = 21;
            this.button3.Text = "Browse Image";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(121, 49);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(269, 20);
            this.PatientName.TabIndex = 14;
            // 
            // PatientOwner
            // 
            this.PatientOwner.Location = new System.Drawing.Point(121, 75);
            this.PatientOwner.Name = "PatientOwner";
            this.PatientOwner.Size = new System.Drawing.Size(269, 20);
            this.PatientOwner.TabIndex = 16;
            // 
            // PatientPhone
            // 
            this.PatientPhone.Location = new System.Drawing.Point(121, 101);
            this.PatientPhone.Name = "PatientPhone";
            this.PatientPhone.Size = new System.Drawing.Size(269, 20);
            this.PatientPhone.TabIndex = 18;
            // 
            // PatientPic
            // 
            this.PatientPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatientPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.PatientPic.Location = new System.Drawing.Point(121, 197);
            this.PatientPic.Name = "PatientPic";
            this.PatientPic.Size = new System.Drawing.Size(269, 214);
            this.PatientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PatientPic.TabIndex = 20;
            this.PatientPic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.AddPatient);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 35);
            this.panel1.TabIndex = 22;
            // 
            // AddPatient
            // 
            this.AddPatient.AutoSize = true;
            this.AddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatient.ForeColor = System.Drawing.Color.White;
            this.AddPatient.Location = new System.Drawing.Point(3, 7);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Size = new System.Drawing.Size(134, 24);
            this.AddPatient.TabIndex = 9;
            this.AddPatient.Text = "ADD PATIENT";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(522, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(60, 461);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(179, 38);
            this.Add.TabIndex = 23;
            this.Add.Text = "Add New Patient";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(270, 461);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(179, 38);
            this.Update.TabIndex = 24;
            this.Update.Text = "Update Patient";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // CreateNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(560, 536);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(patient_nameLabel);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(patient_ownerLabel);
            this.Controls.Add(this.PatientOwner);
            this.Controls.Add(patient_PhoneLabel);
            this.Controls.Add(this.PatientPhone);
            this.Controls.Add(patient_imageLabel);
            this.Controls.Add(this.PatientPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateNewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewPatient";
            ((System.ComponentModel.ISupportInitialize)(this.PatientPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox PatientName;
        public System.Windows.Forms.TextBox PatientOwner;
        public System.Windows.Forms.TextBox PatientPhone;
        public System.Windows.Forms.PictureBox PatientPic;
        public System.Windows.Forms.Button Add;
        public new System.Windows.Forms.Button Update;
        public System.Windows.Forms.Label AddPatient;
    }
}