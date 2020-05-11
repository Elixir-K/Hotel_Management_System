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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void buttonManageClients_Click(object sender, EventArgs e)
        {
            ManageClients_Form manageCF = new ManageClients_Form();
            manageCF.ShowDialog();
        }

        private void buttonManageRooms_Click(object sender, EventArgs e)
        {
            ManageRooms_Form manageRF = new ManageRooms_Form();
            manageRF.ShowDialog();
        }

        private void buttonManageReserv_Click(object sender, EventArgs e)
        {
            ManageReservations_Form manageRsf = new ManageReservations_Form();
            manageRsf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
