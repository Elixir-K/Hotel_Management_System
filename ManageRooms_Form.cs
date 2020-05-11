/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLİŞİM SİSTEMLERİ  MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				PROJE NUMARASI: 1
**				ÖĞRENCİ ADI: YAYA USMAN ADAIZA
**				ÖĞRENCİ NUMARASI: B181200557
**              DERSİN ALINDIĞI GRUP: A
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HotelManagement
{
    public partial class ManageRooms_Form : Form
    {
        ROOM room = new ROOM();
        public ManageRooms_Form()
        {
            InitializeComponent();
        }

    
        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            int roomNum;
            int roomType = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            string phone = textBoxPhone.Text;
            string free = "";

            try
            {
                roomNum = Convert.ToInt32(textBoxRoomNum.Text);
                if (radioButtonYes.Checked)
                {
                    free = "Yes";
                }
                else
                {
                    free = "No";

                }



                if (room.addRoom(roomNum, roomType, phone, free))
                {
                    MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = room.getRoom();
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RoomNo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            buttonClearFields.PerformClick();

        }

        private void buttonClearFields_Click_1(object sender, EventArgs e)
        {
            textBoxRoomNum.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            textBoxPhone.Text = "";
            radioButtonYes.Checked = true;
        }

        private void buttonEditRoom_Click_1(object sender, EventArgs e)
        {
            int roomNum;
            int roomType = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            string phone = textBoxPhone.Text;
            string free = "";

            try
            {
                roomNum = Convert.ToInt32(textBoxRoomNum.Text);
                if (radioButtonYes.Checked)
                {
                    free = "Yes";
                }
                else
                {
                    free = "No";
                }

                if (room.editRoom(roomNum, roomType, phone, free))
                {
                    MessageBox.Show("Room Data Updated Successfully", "Update Room Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = room.getRoom();
                }
                else
                {
                    MessageBox.Show("Room Data Not Updated", "Update Room Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "RoomNo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonClearFields.PerformClick();

        }

        private void buttonRemoveRoom_Click_1(object sender, EventArgs e)
        {
            try
            {
                int roomNum = Convert.ToInt32(textBoxRoomNum.Text);

                if (room.removeRoom(roomNum))
                {

                    MessageBox.Show("Room's Data Deleted Successfully", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = room.getRoom();
                }
                else
                {
                    MessageBox.Show("ERROR - Room's Data Deletion Failed", "Delete Room Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "RoomNo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            buttonClearFields.PerformClick();
        }

        private void ManageRooms_Form_Load_1(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.getRoomType();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            dataGridView1.DataSource = room.getRoom();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxRoomNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomType.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string free = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (free.Equals("Yes"))
            {
                radioButtonYes.Checked = true;
            }
            else
            {
                radioButtonNo.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}



