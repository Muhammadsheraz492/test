using MySqlConnector;
using System;
namespace StudentMangement
{


    public class AddRecord
    {
        public async void AddData()
        {
            // String UserName='ds';
            string UserName = "hdbc";
            string Email = "hdbc";
            string Password = "hdbc";
            string Mobile = null;
            System.Console.Write("Enter Username:");
            UserName = System.Console.ReadLine();
            System.Console.Write("Enter Email :");
            Email = System.Console.ReadLine();
            System.Console.Write("Enter Password:");
            Password = System.Console.ReadLine();
            System.Console.Write("Enter Password:");
            Mobile = System.Console.ReadLine();

        //   string Mobile = "0";
            // UserName='hjbdc';
            string contecting = "Server=127.0.0.1; Port=3306; Database=test; Uid=root@localhost;";
            using var connection = new MySqlConnection(contecting);
            try
            {
                connection.Open();
                // string q = $"INSERT INTO Admin(UserName,Email,Password,Mobile) VALUES ({UserName},{Email},{Password},{Mobile})";
                // string q=$"INSERT INTO `Admin`(`UserName`, `Email`, `Password`, `Mobile`) VALUES ({UserName},{Email},{Password},{Mobile})";
                string q=$"INSERT INTO `Admin`(`UserName`, `Email`, `Password`, `Mobile`) VALUES ('{UserName}','{Email}','{Password}','{Mobile}')";
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