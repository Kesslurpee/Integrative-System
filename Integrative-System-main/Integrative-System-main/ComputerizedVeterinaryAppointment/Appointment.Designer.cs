namespace ComputerizedVeterinaryAppointment
{
    partial class Appointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.PasyentePic = new System.Windows.Forms.PictureBox();
            this.Name = new System.Windows.Forms.Label();
            this.Owner = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddAppointment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasyentePic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 34);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "APPOINTMENT";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(933, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 44;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 31;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Patient Appointment";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Patient Image";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Patient Phone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Patient Owner";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Patient Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // autoID
            // 
            this.autoID.HeaderText = "Column1";
            this.autoID.Name = "autoID";
            this.autoID.ReadOnly = true;
            this.autoID.Visible = false;
            // 
            // AppointmentGrid
            // 
            this.AppointmentGrid.AllowUserToAddRows = false;
            this.AppointmentGrid.AllowUserToDeleteRows = false;
            this.AppointmentGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Edit,
            this.Delete});
            this.AppointmentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointmentGrid.EnableHeadersVisualStyles = false;
            this.AppointmentGrid.Location = new System.Drawing.Point(191, 34);
            this.AppointmentGrid.Name = "AppointmentGrid";
            this.AppointmentGrid.ReadOnly = true;
            this.AppointmentGrid.RowHeadersVisible = false;
            this.AppointmentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentGrid.Size = new System.Drawing.Size(780, 522);
            this.AppointmentGrid.TabIndex = 5;
            this.AppointmentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentGrid_CellClick);
            this.AppointmentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGrid_CellContentClick);
            // 
            // PasyentePic
            // 
            this.PasyentePic.Location = new System.Drawing.Point(0, 80);
            this.PasyentePic.Name = "PasyentePic";
            this.PasyentePic.Size = new System.Drawing.Size(191, 209);
            this.PasyentePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasyentePic.TabIndex = 0;
            this.PasyentePic.TabStop = false;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(3, 324);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(57, 20);
            this.Name.TabIndex = 1;
            this.Name.Text = "label1";
            // 
            // Owner
            // 
            this.Owner.AutoSize = true;
            this.Owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Owner.ForeColor = System.Drawing.Color.White;
            this.Owner.Location = new System.Drawing.Point(3, 393);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(57, 20);
            this.Owner.TabIndex = 2;
            this.Owner.Text = "label1";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.White;
            this.Phone.Location = new System.Drawing.Point(3, 449);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(57, 20);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "OWNER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PHONE:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.AddAppointment);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Phone);
            this.panel2.Controls.Add(this.Owner);
            this.panel2.Controls.Add(this.Name);
            this.panel2.Controls.Add(this.PasyentePic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 522);
            this.panel2.TabIndex = 6;
            // 
            // AddAppointment
            // 
            this.AddAppointment.BackColor = System.Drawing.Color.SteelBlue;
            this.AddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.AddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAppointment.ForeColor = System.Drawing.Color.White;
            this.AddAppointment.Location = new System.Drawing.Point(0, 0);
            this.AddAppointment.Name = "AddAppointment";
            this.AddAppointment.Size = new System.Drawing.Size(191, 57);
            this.AddAppointment.TabIndex = 23;
            this.AddAppointment.Text = "Create New Appointment";
            this.AddAppointment.UseVisualStyleBackColor = false;
            this.AddAppointment.Click += new System.EventHandler(this.AddAppointment_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 556);
            this.Controls.Add(this.AppointmentGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasyentePic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoID;
        private System.Windows.Forms.DataGridView AppointmentGrid;
        private System.Windows.Forms.PictureBox PasyentePic;
        private new System.Windows.Forms.Label Name;
        private new System.Windows.Forms.Label Owner;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddAppointment;
    }
}