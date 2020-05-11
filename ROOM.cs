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

    //this class helps in managing the rooms 
    class ROOM
    {
        CONNECT conn = new CONNECT();
       
        //function to get the list of room type

        public DataTable getRoomType()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms_category`", conn.GetConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }


        //function to get the room number by the rooomtype, this function is needed for our reservation 
        public DataTable getRoomNoByType(int rmType)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms` WHERE `RoomType`=@rtyp and Available = 'Yes'", conn.GetConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            command.Parameters.Add("@rtyp", MySqlDbType.Int32).Value = rmType;
           
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //function to get room type by num
        public int getRoomtypeByNum(int rmNum)
        {
            MySqlCommand command = new MySqlCommand("SELECT `RoomType` FROM `rooms` WHERE `RoomNo`=@rn", conn.GetConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            command.Parameters.Add("@rn", MySqlDbType.Int32).Value = rmNum;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        //function to set the room available status 
        public bool SetRoomFreeStatus(int rmNum,string status)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `rooms` SET `Available`= @fr WHERE `RoomNo`= @rn";


            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@rn", MySqlDbType.Int32).Value = rmNum;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = status;
           
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

      
        //function to add the rooms
        public bool addRoom(int roomNo, int type, string phone, string free)
        {
            MySqlCommand command = new MySqlCommand();
            string addQuery = "INSERT INTO `rooms`(`RoomNo`,`RoomType`, `Phone`, `Available`) VALUES (@rn,@rt,@phn,@fr)";


            command.CommandText = addQuery;
            command.Connection = conn.GetConnection();
            command.Parameters.Add("@rn", MySqlDbType.Int32).Value = roomNo;
            command.Parameters.Add("@rt", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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


        //function to display all rooms

        public DataTable getRoom()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }


        //function to update/edit the selected room data
        public bool editRoom(int roomNum,int type, string phone, string free)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `rooms` SET `RoomType`=@rt,`Phone`=@phn,`Available`=@fr WHERE `RoomNo`= @rn";


            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@rn", MySqlDbType.Int32).Value = roomNum;
            command.Parameters.Add("@rt", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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


        //function to delete selected room data from the database
        public bool removeRoom(int roomNum)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `rooms` WHERE `RoomNo`= @rn", conn.GetConnection());

            command.Parameters.Add("@rn", MySqlDbType.Int32).Value = roomNum;


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
