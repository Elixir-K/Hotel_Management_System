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
using MySql.Data.MySqlClient;

namespace CSharp_HotelManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbutton_Click_1(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT(); //our connection
            DataTable table = new DataTable(); //creates our table in the dataset
            MySqlDataAdapter adapter = new MySqlDataAdapter(); //creates a link between the datasource and the dataset
            MySqlCommand command = new MySqlCommand();  //executes our sql queries etc.
            string query = "SELECT * FROM `users` WHERE `username`=@usn AND `password` = @pass"; //@pass and @usn are placeholders

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text; //it takes the input from the user and replace its respective placeholder of its type
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            command.CommandText = query;
            command.Connection = conn.GetConnection();

            adapter.SelectCommand = command; //the adapter here uses the selectcommand to retrieve data specified in the datasource i.e the database
            adapter.Fill(table); // if the value retrieved matches the one at the data source then it fills the table data in the dataset if the table hasn't been created then it creates one.

            //if the username and password exists
            if (table.Rows.Count > 0) //if the no of rows in the table in the dataset then execute the content within.
            {
                //show the main form
                this.Hide();
                Main_Form mForm = new Main_Form();
                mForm.Show();

            }
            else if (textBoxUsername.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter a valid username", "Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter a valid password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username or Password does not exist", "Incorrect data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
