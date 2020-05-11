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
    class RESERVATION
    {
        CONNECT conn = new CONNECT();

        

        //function to add new reservation
        public bool addReserv(int roomNum, int clientId, DateTime dtIn, DateTime dtOut)
        {
            MySqlCommand command = new MySqlCommand();
            string addQuery = "INSERT INTO `reservation`(`RoomNo`, `ClientID`, `DateIN`, `DateOUT`) VALUES (@rn,@cid,@dtIN,@dtOUT)";

            //@rn,@cid,@dtIN,@dtOUT
            command.CommandText = addQuery;
            command.Connection = conn.GetConnection();
            command.Parameters.Add("@rn", MySqlDbType.Int32).Value = roomNum;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@dtIN", MySqlDbType.Date).Value = dtIn;
            command.Parameters.Add("@dtOUT", MySqlDbType.Date).Value = dtOut;

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


        //function to display all reservation

        public DataTable getReserv()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservation`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }


        //function to update/edit the selected reserv. data
        public bool editReserv(int reservId,int roomNum, int clientId, DateTime dtIn, DateTime dtOut)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `reservation` SET `RoomNo`=@rn,`ClientID`=@cid,`DateIN`=@dtIN,`DateOUT`=@dtOUT WHERE `ReservID`=@reservId";


            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            //@rn,@cid,@dtIN,@dtOUT
            command.Parameters.Add("@reservId", MySqlDbType.Int32).Value = reservId;
            command.Parameters.Add("@rn", MySqlDbType.Int32).Value = roomNum;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@dtIN", MySqlDbType.Date).Value = dtIn;
            command.Parameters.Add("@dtOUT", MySqlDbType.Date).Value = dtOut;

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


        //function to delete selected reservation data from the database
        public bool removeReserv(int reservId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `reservation` WHERE `ReservID`=@reservId", conn.GetConnection());

            command.Parameters.Add("@reservId", MySqlDbType.Int32).Value = reservId;


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

