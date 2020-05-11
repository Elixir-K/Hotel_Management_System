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
    public partial class ManageClients_Form : Form
    {
        public ManageClients_Form()
        {
            InitializeComponent();
        }

        CLIENT client = new CLIENT();

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string pnum = textBoxPhone.Text;
            string ctry = textBoxCountry.Text;

            bool insertClient = client.addClient(fname, lname, pnum, ctry);

            if (fname.Trim().Equals("") || lname.Trim().Equals("") || pnum.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields-First Name,Last Name & Phone Number", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (insertClient)
                {

                    MessageBox.Show("New Client Added Successfully", "New client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = client.getClient();
                }
                else
                {
                    MessageBox.Show("ERROR - Client Insertion Failed", "New client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            buttonClearFields.PerformClick();
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            int id;
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string pnum = textBoxPhone.Text;
            string ctry = textBoxCountry.Text;

            try
            {
                id = Convert.ToInt32(textBoxID.Text);
                if (fname.Trim().Equals("") || lname.Trim().Equals("") || pnum.Trim().Equals(""))
                {
                    MessageBox.Show("Required Fields-First Name,Last Name & Phone Number", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    bool editClient = client.editClient(id, fname, lname, pnum, ctry);

                    if (editClient)
                    {
                        MessageBox.Show("Client Updated Successfully", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = client.getClient();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Client Update Failed", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    buttonClearFields.PerformClick();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if (client.removeClient(id))
                {

                    MessageBox.Show("Client Deleted Successfully", "Delete client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = client.getClient();
                }
                else
                {
                    MessageBox.Show("ERROR - Client Deletion Failed", "Delete client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //method to automatically clear the fields after deleteing
            buttonClearFields.PerformClick();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxCountry.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxCountry.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void ManageClients_Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClient();
        }
    }



}
