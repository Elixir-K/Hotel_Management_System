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
    public partial class ManageReservations_Form : Form
    {
        public ManageReservations_Form()
        {
            InitializeComponent();
        }

        RESERVATION reserv = new RESERVATION();
        ROOM room = new ROOM();

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {

            try
            {
                int roomNum = Convert.ToInt32(comboBoxRoomNum.SelectedValue.ToString());
                int clientId = Convert.ToInt32(textBoxClientID.Text);
                DateTime dtIn = dateTimePickerIN.Value;
                DateTime dtOut = dateTimePickerOUT.Value;

                //the dateIn selected has to > or = today's date
                //while the dateOut must be = or < dayIn's date

                if (DateTime.Compare(dtIn.Date, DateTime.Now.Date) < 0)   //method compare returns -1 if the first arg is < than the second arg and return 0 if it is = while returns 1 if it is >
                {
                    MessageBox.Show("Date must be > or = to Today's date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DateTime.Compare(dtOut.Date, dtIn.Date) < 0)
                {
                    MessageBox.Show("DateOut must be > or = to DateIn", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reserv.addReserv(roomNum, clientId, dtIn, dtOut))
                    {
                        room.SetRoomFreeStatus(roomNum, "No");
                        MessageBox.Show("New Reservation Added Successfully", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation Not Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dataGridView2.DataSource = reserv.getReserv();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            buttonClearFields.PerformClick();

        }

        private void buttonEditReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBoxReservID.Text);
                int roomNum = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString()); ;
                int clientId = Convert.ToInt32(textBoxClientID.Text);
                DateTime dtIn = dateTimePickerIN.Value;
                DateTime dtOut = dateTimePickerOUT.Value;

                //the dateIn selected has to > or = today's date
                //while the dateOut must be = or < dayIn's date

                if (dtIn < DateTime.Now)
                {
                    MessageBox.Show("Date must be > or = to Today's date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtOut < dtIn)
                {
                    MessageBox.Show("DateOut must be > or = to DateIn", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reserv.editReserv(reservId, roomNum, clientId, dtIn, dtOut))
                    {
                        room.SetRoomFreeStatus(roomNum, "Yes");
                        MessageBox.Show("Reservation Updated Successfully", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation Not Updated", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dataGridView2.DataSource = reserv.getReserv();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonClearFields.PerformClick();

        }

        private void buttonRemoveReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBoxReservID.Text);
                int roomNum = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());


                if (reserv.removeReserv(reservId))
                {
                    MessageBox.Show("Reservation Data Removed Successfully", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reservation Data Removal Failed", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                room.SetRoomFreeStatus(roomNum, "Yes");
                dataGridView2.DataSource = reserv.getReserv();
                buttonClearFields.PerformClick();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            //textBoxReservID.Text = "";
            textBoxClientID.Text = "";
            comboBoxRmType.SelectedIndex = 0;
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value = DateTime.Now;
        }

        private void ManageReservations_Form1_Load(object sender, EventArgs e)
        {
            comboBoxRmType.DataSource = room.getRoomType();
            comboBoxRmType.DisplayMember = "label";
            comboBoxRmType.ValueMember = "category_id";

            dataGridView2.DataSource = reserv.getReserv();

            //getting the room number based on the room type chosen
            int type = Convert.ToInt32(comboBoxRmType.SelectedValue.ToString());
            comboBoxRoomNum.DataSource = room.getRoomNoByType(type);
            comboBoxRoomNum.DisplayMember = "RoomNo";
            comboBoxRoomNum.ValueMember = "RoomNo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxReservID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            int roomNum = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            comboBoxRmType.SelectedValue = room.getRoomtypeByNum(roomNum);
            comboBoxRoomNum.SelectedValue = roomNum;

            textBoxClientID.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerIN.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[3].Value);
            dateTimePickerOUT.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[4].Value);

        }

        private void comboBoxRmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //getting the room number based on the room type chosen
                int type = Convert.ToInt32(comboBoxRmType.SelectedValue.ToString());
                comboBoxRoomNum.DataSource = room.getRoomNoByType(type);
                comboBoxRoomNum.DisplayMember = "RoomNo";
                comboBoxRoomNum.ValueMember = "RoomNo";

            }
            catch (Exception)
            {

                //
            }

        }
    }

}


//ALTER TABLE rooms ADD CONSTRAINT fk_rmtype FOREIGN KEY (RoomType) REFERENCES rooms_category(category_id) ON UPDATE CASCADE ON DELETE CASCADE;
//ALTER TABLE reservation ADD CONSTRAINT fk_rmNo FOREIGN KEY (RoomNo) REFERENCES rooms(RoomNo) ON UPDATE CASCADE ON DELETE CASCADE;
//ALTER TABLE reservation ADD CONSTRAINT fk_clientId FOREIGN KEY (ClientID) REFERENCES clients(id) ON UPDATE CASCADE ON DELETE CASCADE;