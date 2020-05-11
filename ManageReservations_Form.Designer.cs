namespace CSharp_HotelManagement
{
    partial class ManageReservations_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.buttonEditReserv = new System.Windows.Forms.Button();
            this.buttonRemoveReserv = new System.Windows.Forms.Button();
            this.buttonAddReservation = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxReservID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerIN = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOUT = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRmType = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomNum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(93, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "DateIn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label6.Location = new System.Drawing.Point(70, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 64;
            this.label6.Text = "Room No:";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(175, 116);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(89, 29);
            this.textBoxClientID.TabIndex = 63;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFields.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.ForeColor = System.Drawing.Color.White;
            this.buttonClearFields.Location = new System.Drawing.Point(13, 414);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(352, 45);
            this.buttonClearFields.TabIndex = 62;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = false;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // buttonEditReserv
            // 
            this.buttonEditReserv.BackColor = System.Drawing.Color.Green;
            this.buttonEditReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditReserv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditReserv.ForeColor = System.Drawing.Color.White;
            this.buttonEditReserv.Location = new System.Drawing.Point(185, 357);
            this.buttonEditReserv.Name = "buttonEditReserv";
            this.buttonEditReserv.Size = new System.Drawing.Size(96, 38);
            this.buttonEditReserv.TabIndex = 61;
            this.buttonEditReserv.Text = "Update";
            this.buttonEditReserv.UseVisualStyleBackColor = false;
            this.buttonEditReserv.Click += new System.EventHandler(this.buttonEditReserv_Click);
            // 
            // buttonRemoveReserv
            // 
            this.buttonRemoveReserv.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRemoveReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveReserv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveReserv.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveReserv.Location = new System.Drawing.Point(287, 357);
            this.buttonRemoveReserv.Name = "buttonRemoveReserv";
            this.buttonRemoveReserv.Size = new System.Drawing.Size(78, 38);
            this.buttonRemoveReserv.TabIndex = 60;
            this.buttonRemoveReserv.Text = "Delete";
            this.buttonRemoveReserv.UseVisualStyleBackColor = false;
            this.buttonRemoveReserv.Click += new System.EventHandler(this.buttonRemoveReserv_Click);
            // 
            // buttonAddReservation
            // 
            this.buttonAddReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.buttonAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddReservation.ForeColor = System.Drawing.Color.White;
            this.buttonAddReservation.Location = new System.Drawing.Point(13, 357);
            this.buttonAddReservation.Name = "buttonAddReservation";
            this.buttonAddReservation.Size = new System.Drawing.Size(157, 38);
            this.buttonAddReservation.TabIndex = 59;
            this.buttonAddReservation.Text = "Add Reservations";
            this.buttonAddReservation.UseVisualStyleBackColor = false;
            this.buttonAddReservation.Click += new System.EventHandler(this.buttonAddReservation_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(381, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(413, 377);
            this.dataGridView2.TabIndex = 58;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // textBoxReservID
            // 
            this.textBoxReservID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReservID.Location = new System.Drawing.Point(175, 74);
            this.textBoxReservID.Name = "textBoxReservID";
            this.textBoxReservID.ReadOnly = true;
            this.textBoxReservID.Size = new System.Drawing.Size(89, 29);
            this.textBoxReservID.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label5.Location = new System.Drawing.Point(81, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "ClientID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label4.Location = new System.Drawing.Point(57, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "Room Type:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Image = global::CSharp_HotelManagement.Properties.Resources.icons8_delete_35px;
            this.button2.Location = new System.Drawing.Point(737, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 42);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Reservations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(75, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "ReservID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 60);
            this.panel2.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSharp_HotelManagement.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label7.Location = new System.Drawing.Point(77, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "DateOut:";
            // 
            // dateTimePickerIN
            // 
            this.dateTimePickerIN.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIN.Location = new System.Drawing.Point(175, 249);
            this.dateTimePickerIN.Name = "dateTimePickerIN";
            this.dateTimePickerIN.Size = new System.Drawing.Size(152, 26);
            this.dateTimePickerIN.TabIndex = 68;
            // 
            // dateTimePickerOUT
            // 
            this.dateTimePickerOUT.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOUT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOUT.Location = new System.Drawing.Point(175, 287);
            this.dateTimePickerOUT.Name = "dateTimePickerOUT";
            this.dateTimePickerOUT.Size = new System.Drawing.Size(152, 26);
            this.dateTimePickerOUT.TabIndex = 69;
            // 
            // comboBoxRmType
            // 
            this.comboBoxRmType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRmType.FormattingEnabled = true;
            this.comboBoxRmType.Location = new System.Drawing.Point(175, 160);
            this.comboBoxRmType.Name = "comboBoxRmType";
            this.comboBoxRmType.Size = new System.Drawing.Size(152, 30);
            this.comboBoxRmType.TabIndex = 70;
            this.comboBoxRmType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRmType_SelectedIndexChanged);
            // 
            // comboBoxRoomNum
            // 
            this.comboBoxRoomNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomNum.FormattingEnabled = true;
            this.comboBoxRoomNum.Location = new System.Drawing.Point(175, 201);
            this.comboBoxRoomNum.Name = "comboBoxRoomNum";
            this.comboBoxRoomNum.Size = new System.Drawing.Size(152, 30);
            this.comboBoxRoomNum.TabIndex = 71;
            // 
            // ManageReservations_Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(806, 479);
            this.Controls.Add(this.comboBoxRoomNum);
            this.Controls.Add(this.comboBoxRmType);
            this.Controls.Add(this.dateTimePickerOUT);
            this.Controls.Add(this.dateTimePickerIN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonEditReserv);
            this.Controls.Add(this.buttonRemoveReserv);
            this.Controls.Add(this.buttonAddReservation);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBoxReservID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageReservations_Form1";
            this.Text = "ManageReservations_Form1";
            this.Load += new System.EventHandler(this.ManageReservations_Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Button buttonEditReserv;
        private System.Windows.Forms.Button buttonRemoveReserv;
        private System.Windows.Forms.Button buttonAddReservation;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxReservID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerIN;
        private System.Windows.Forms.DateTimePicker dateTimePickerOUT;
        private System.Windows.Forms.ComboBox comboBoxRmType;
        private System.Windows.Forms.ComboBox comboBoxRoomNum;
    }
}