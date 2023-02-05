using MySqlConnector;
using System;
namespace StudentMangement
{


    public class Delet
    {
        public async void AddData()
        {
            // String UserName='ds';
        
        //   string Mobile = "0";
            // UserName='hjbdc';
            string contecting = "Server=127.0.0.1; Port=3306; Database=test; Uid=root@localhost;";
            using var connection = new MySqlConnection(contecting);
            try
            {
                connection.Open();
                      System.Console.Write("Enter Mobile Number:");
                String Mobile = System.Console.ReadLine();
                // string q = $"INSERT INTO Admin(UserName,Email,Password,Mobile) VALUES ({UserName},{Email},{Password},{Mobile})";
                // string q=$"INSERT INTO `Admin`(`UserName`, `Email`, `Password`, `Mobile`) VALUES ({UserName},{Email},{Password},{Mobile})";
                // string q=$"INSERT INTO `Admin`(`UserName`, `Email`, `Password`, `Mobile`) VALUES ('{UserName}','{Email}','{Password}','{Mobile}')";
                string q=$"DELETE FROM `Admin` WHERE Mobile={Mobile};";
                MySqlCommand cmd = new MySqlCommand(q, connection);

                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

        }

    }
}