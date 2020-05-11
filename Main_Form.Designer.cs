namespace CSharp_HotelManagement
{
    partial class Main_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonManageRooms = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonManageReserv = new System.Windows.Forms.Button();
            this.buttonManageClients = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonManageRooms);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonManageReserv);
            this.panel1.Controls.Add(this.buttonManageClients);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label4.Location = new System.Drawing.Point(530, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Manage Reservations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(319, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Manage Rooms";
            // 
            // buttonManageRooms
            // 
            this.buttonManageRooms.BackColor = System.Drawing.Color.Transparent;
            this.buttonManageRooms.FlatAppearance.BorderSize = 0;
            this.buttonManageRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageRooms.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageRooms.ForeColor = System.Drawing.Color.Transparent;
            this.buttonManageRooms.Image = global::CSharp_HotelManagement.Properties.Resources.icons8_room_70px;
            this.buttonManageRooms.Location = new System.Drawing.Point(335, 169);
            this.buttonManageRooms.Name = "buttonManageRooms";
            this.buttonManageRooms.Size = new System.Drawing.Size(88, 82);
            this.buttonManageRooms.TabIndex = 18;
            this.buttonManageRooms.UseVisualStyleBackColor = false;
            this.buttonManageRooms.Click += new System.EventHandler(this.buttonManageRooms_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(87, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Manage Clients";
            // 
            // buttonManageReserv
            // 
            this.buttonManageReserv.BackColor = System.Drawing.Color.Transparent;
            this.buttonManageReserv.FlatAppearance.BorderSize = 0;
            this.buttonManageReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageReserv.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageReserv.ForeColor = System.Drawing.Color.Transparent;
            this.buttonManageReserv.Image = global::CSharp_HotelManagement.Properties.Resources.icons8_reserve_70px;
            this.buttonManageReserv.Location = new System.Drawing.Point(557, 178);
            this.buttonManageReserv.Name = "buttonManageReserv";
            this.buttonManageReserv.Size = new System.Drawing.Size(88, 82);
            this.buttonManageReserv.TabIndex = 3;
            this.buttonManageReserv.UseVisualStyleBackColor = false;
            this.buttonManageReserv.Click += new System.EventHandler(this.buttonManageReserv_Click);
            // 
            // buttonManageClients
            // 
            this.buttonManageClients.BackColor = System.Drawing.Color.Transparent;
            this.buttonManageClients.FlatAppearance.BorderSize = 0;
            this.buttonManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageClients.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageClients.ForeColor = System.Drawing.Color.Transparent;
            this.buttonManageClients.Image = global::CSharp_HotelManagement.Properties.Resources.icons8_people_70px;
            this.buttonManageClients.Location = new System.Drawing.Point(111, 169);
            this.buttonManageClients.Name = "buttonManageClients";
            this.buttonManageClients.Size = new System.Drawing.Size(88, 82);
            this.buttonManageClients.TabIndex = 1;
            this.buttonManageClients.UseVisualStyleBackColor = false;
            this.buttonManageClients.Click += new System.EventHandler(this.buttonManageClients_Click);
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
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Image = global::CSharp_HotelManagement.Properties.Resources.icons8_delete_35px1;
            this.button2.Location = new System.Drawing.Point(731, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 42);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSharp_HotelManagement.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(19, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Spring Star Hotel";
            // 
            // Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main_Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonManageReserv;
        private System.Windows.Forms.Button buttonManageClients;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonManageRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}