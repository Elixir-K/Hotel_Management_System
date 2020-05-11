namespace CSharp_HotelManagement
{
    partial class ManageClients_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonRemoveClient = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // buttonClearFields
            // 
            this.buttonClearFields.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFields.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.ForeColor = System.Drawing.Color.White;
            this.buttonClearFields.Location = new System.Drawing.Point(15, 398);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(354, 45);
            this.buttonClearFields.TabIndex = 46;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = false;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.BackColor = System.Drawing.Color.Green;
            this.buttonEditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditClient.ForeColor = System.Drawing.Color.White;
            this.buttonEditClient.Location = new System.Drawing.Point(183, 341);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(96, 38);
            this.buttonEditClient.TabIndex = 45;
            this.buttonEditClient.Text = "Update";
            this.buttonEditClient.UseVisualStyleBackColor = false;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonRemoveClient
            // 
            this.buttonRemoveClient.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRemoveClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveClient.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveClient.Location = new System.Drawing.Point(287, 341);
            this.buttonRemoveClient.Name = "buttonRemoveClient";
            this.buttonRemoveClient.Size = new System.Drawing.Size(82, 38);
            this.buttonRemoveClient.TabIndex = 44;
            this.buttonRemoveClient.Text = "Delete";
            this.buttonRemoveClient.UseVisualStyleBackColor = false;
            this.buttonRemoveClient.Click += new System.EventHandler(this.buttonRemoveClient_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.buttonAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClient.ForeColor = System.Drawing.Color.White;
            this.buttonAddClient.Location = new System.Drawing.Point(15, 341);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(158, 38);
            this.buttonAddClient.TabIndex = 43;
            this.buttonAddClient.Text = "Add New Clients";
            this.buttonAddClient.UseVisualStyleBackColor = false;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(381, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(471, 380);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(176, 173);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(152, 29);
            this.textBoxLastName.TabIndex = 38;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(179, 82);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(86, 29);
            this.textBoxID.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label5.Location = new System.Drawing.Point(61, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label4.Location = new System.Drawing.Point(65, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(133, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "ID:";
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
            this.button2.Location = new System.Drawing.Point(795, 9);
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
            this.label1.Location = new System.Drawing.Point(247, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Clients";
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
            this.panel2.Size = new System.Drawing.Size(864, 60);
            this.panel2.TabIndex = 32;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(176, 129);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(152, 29);
            this.textBoxFirstName.TabIndex = 47;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(176, 216);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(152, 29);
            this.textBoxPhone.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label6.Location = new System.Drawing.Point(102, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Phone:";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountry.Location = new System.Drawing.Point(176, 258);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(152, 29);
            this.textBoxCountry.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(89, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Country:";
            // 
            // ManageClients_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(864, 458);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.buttonRemoveClient);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageClients_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageClients_Form1";
            this.Load += new System.EventHandler(this.ManageClients_Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonRemoveClient;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label2;
    }
}