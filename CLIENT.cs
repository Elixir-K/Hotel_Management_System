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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CSharp_HotelManagement
{
    //this class helps to add,edit clients data,remove clients and gets clients data
    
    class CLIENT
    {
        CONNECT conn = new CONNECT();


        //function to add new clients
        public bool addClient(string fName, string lName,string phoneNum,string country)
        {
            MySqlCommand command = new MySqlCommand();
            string addQuery = "INSERT INTO `clients`(`first_name`, `last_name`, `phone`, `country`) VALUES (@fname,@lname,@pNum,@cnt)";

            
            command.CommandText = addQuery;
            command.Connection = conn.GetConnection();
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lName;
            command.Parameters.Add("@pNum", MySqlDbType.VarChar).Value = phoneNum;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

            conn.OpenConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                conn.CloseConnection();
                return true;
            }
            else
            {
                conn.CloseConnection();
                return false;
            }
           
           
        }
        

        //function to get clients data 
        public DataTable getClient()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //function to edit clients data

        public bool editClient(int id, string fName, string lName, string phoneNum, string country)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `clients` SET `first_name`=@fname,`last_name`=@lname,`phone`=@phn,`country`=@ctry WHERE `id`=@cid";


            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lName;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phoneNum;
            command.Parameters.Add("@ctry", MySqlDbType.VarChar).Value = country;

            conn.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseConnection();
                return true;
            }
            else
            {
                conn.CloseConnection();
                return false;
            }

        }

        //function to delete client data from the database
        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `clients` WHERE `id`= @cid",conn.GetConnection());
            
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            

            conn.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseConnection();
                return true;
            }
            else
            {
                conn.CloseConnection();
                return false;
            }

        }

    }
}
