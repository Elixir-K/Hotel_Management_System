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
    //this class connects our app with mysql database
    //first i downloaded the connector and included it in the reference 
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=CSharp_HotelDB");
        
        //create a function to return our connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        //create a function to open our connection
        public void OpenConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //create a function to close
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
