using MySqlConnector;

namespace StudentMangement
{
    public class DisplayClass
    {
        public async void Display()
        {
            string contecting = "Server=127.0.0.1; Port=3306; Database=test; Uid=root@localhost;";
            using var connection = new MySqlConnection(contecting);
            try
            {

                connection.Open();
                string q = "SELECT * FROM `Admin` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(q, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // access your record colums by using reader
                        Console.WriteLine(reader["Username"]+" \t  "+reader["Email"]+"\t"+reader["Password"]+"\t",reader["Mobile"]);
                    }
                }
                // Console.WriteLine(reader.Read());
                //    while (reader.Read())
                //                 {
                //                       Console.WriteLine(reader["Email"]);
                //                 //    System.Console.Write(reader.GetValue(0).ToString());
                //                 // System.Console.Write("\t");
                //                 // System.Console.Write(reader.GetValue(1).ToString());
                //                 // System.Console.Write("\t");
                //                 // System.Console.Write(reader.GetValue(2).ToString());
                //                 // System.Console.Write("\t");
                //                 // System.Console.WriteLine(reader.GetValue(3).ToString());
                //                 // System.Console.Write("\t");

                //                 }

            }
            catch (Exception e)
            {


                Console.WriteLine(e);
            }

        }
    }



}