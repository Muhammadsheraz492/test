namespace StudentMangement
{
    using MySqlConnector;
    public class Search
    {
        public void SearchData()
        {

            string connecting = "Server=127.0.0.1; Port=3306; Database=test; Uid=root@localhost;";
            using var Connection = new MySqlConnection(connecting);
            try
            {
                System.Console.Write("Enter Mobile Number:");
                String Mobile = System.Console.ReadLine();
                Connection.Open();
                System.Console.WriteLine("Connected to repository.", 4);
                //    string q="INSERT INTO `Admin`(`UserName`, `Email`, `Password`, `Mobile`) VALUES ('asif','asif@gmail.com','HaqBahoo@1','100')";
                // string q = "SELECT * FROM `Admin` WHERE 1";
                // var myNumber = 5;
                // var myText = "My number is " + myNumber + " but I can count way more";

                string q = $"SELECT * FROM Admin WHERE Mobile LIKE {Mobile};";
                MySqlCommand cmd = new MySqlCommand(q, Connection);

                // using var reader = cmd.ExecuteReaderAsync();
                // result = true;
                   using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // access your record colums by using reader
                        Console.WriteLine(reader["Username"]+" \t  "+reader["Email"]+"\t"+reader["Password"]+"\t",reader["Mobile"]);
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error occured while connecting to repository.", 3);
                System.Console.WriteLine("MySQL Exception: " + e, 5);
                // result = false;
            }


        }

    }


}