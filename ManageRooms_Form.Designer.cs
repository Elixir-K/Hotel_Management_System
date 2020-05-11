namespace CSharp_HotelManagement
{
    partial class ManageRooms_Form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRoomNum = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonRemoveRoom = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 1;
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(77, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Room No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(123, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Free:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label4.Location = new System.Drawing.Point(108, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.label5.Location = new System.Drawing.Point(64, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Room Type:";
            // 
            // textBoxRoomNum
            // 
            this.textBoxRoomNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNum.Location = new System.Drawing.Point(182, 100);
            this.textBoxRoomNum.Name = "textBoxRoomNum";
            this.textBoxRoomNum.Size = new System.Drawing.Size(86, 29);
            this.textBoxRoomNum.TabIndex = 22;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(182, 205);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(152, 29);
            this.textBoxPhone.TabIndex = 23;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(182, 153);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(152, 30);
            this.comboBoxRoomType.TabIndex = 24;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYes.ForeColor = System.Drawing.Color.Green;
            this.radioButtonYes.Location = new System.Drawing.Point(182, 263);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(56, 26);
            this.radioButtonYes.TabIndex = 25;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.ForeColor = System.Drawing.Color.Red;
            this.radioButtonNo.Location = new System.Drawing.Point(244, 263);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(52, 26);
            this.radioButtonNo.TabIndex = 26;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(407, 372);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(236)))));
            this.buttonAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoom.ForeColor = System.Drawing.Color.White;
            this.buttonAddRoom.Location = new System.Drawing.Point(12, 336);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(156, 38);
            this.buttonAddRoom.TabIndex = 28;
            this.buttonAddRoom.Text = "Add New Room";
            this.buttonAddRoom.UseVisualStyleBackColor = false;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonRemoveRoom
            // 
            this.buttonRemoveRoom.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRemoveRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveRoom.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveRoom.Location = new System.Drawing.Point(283, 336);
            this.buttonRemoveRoom.Name = "buttonRemoveRoom";
            this.buttonRemoveRoom.Size = new System.Drawing.Size(82, 38);
            this.buttonRemoveRoom.TabIndex = 29;
            this.buttonRemoveRoom.Text = "Delete";
            this.buttonRemoveRoom.UseVisualStyleBackColor = false;
            this.buttonRemoveRoom.Click += new System.EventHandler(this.buttonRemoveRoom_Click_1);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.BackColor = System.Drawing.Color.Green;
            this.buttonEditRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditRoom.ForeColor = System.Drawing.Color.White;
            this.buttonEditRoom.Location = new System.Drawing.Point(176, 336);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(96, 38);
            this.buttonEditRoom.TabIndex = 30;
            this.buttonEditRoom.Text = "Update";
            this.buttonEditRoom.UseVisualStyleBackColor = false;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click_1);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFields.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.ForeColor = System.Drawing.Color.White;
            this.buttonClearFields.Location = new System.Drawing.Point(12, 393);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(353, 45);
            this.buttonClearFields.TabIndex = 31;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = false;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click_1);
            // 
            // ManageRooms_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonEditRoom);
            this.Controls.Add(this.buttonRemoveRoom);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxRoomNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageRooms_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRooms_Form1";
            this.Load += new System.EventHandler(this.ManageRooms_Form_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRoomNum;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Button buttonRemoveRoom;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Button buttonClearFields;
    }
}