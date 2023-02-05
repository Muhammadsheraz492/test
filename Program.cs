// // // // See https://aka.ms/new-console-template for more information
// // // using MySqlConnector;
// // // Console.WriteLine("Hello, World!");

// // // using var connection = new MySqlConnection("Server={127.0.0.1};Port=3306;Database=test;Uid=root@localhost;");
// // // using var command = new MySqlCommand("INSERT INTO `Admin`(`UserName`, `Email`, `Password`, `Mobile`) VALUES ('[value-11]','[value-12]','[value-13]','[value-14]')", connection);
// // // using var reader = await command.ExecuteReaderAsync();
// // // while (await reader.ReadAsync())
// // // {
// // //     var value = reader.GetValue(0);
// // //     // do something with 'value'
// // // }

// // using MySqlConnector;

// // namespace vmcmod
// // {
// //     public class DBConnection
// //     {
// //         public DBConnection()
// //         {
// //         }

// //         public string Password { get; set; }
// //         private MySqlConnection connection = null;
// //         public MySqlConnection Connection
// //         {
// //             get { return connection; }
// //         }

// //          public bool IsConnect()
// //         {
// //             bool result = true;
// //             if (Connection == null)
// //             {

// //             }

// //             return result;
// //         }


// //     }



// // }

//   public static async Task Main(string[] args)
//     {
//         string connString = "Server=127.0.0.1; Port=3306; Database=test; Uid=root@localhost;";
//         using var connection = new MySqlConnection(connString);
//         try
//         {
//             System.Console.Write("Enter Mobile Number:");
//             String Mobile=System.Console.ReadLine();
//             connection.Open();
//             System.Console.WriteLine("Connected to repository.", 4);
//             //    string q="INSERT INTO `Admin`(`UserName`, `Email`, `Password`, `Mobile`) VALUES ('asif','asif@gmail.com','HaqBahoo@1','100')";
//             // string q = "SELECT * FROM `Admin` WHERE 1";
//             // var myNumber = 5;
// // var myText = "My number is " + myNumber + " but I can count way more";

//             string q = $"SELECT * FROM Admin WHERE Mobile LIKE {Mobile};";
//             MySqlCommand cmd = new MySqlCommand(q, connection); 
            
//             using var reader = await cmd.ExecuteReaderAsync();
//             // result = true;
//             // System.Console.WriteLine(reader.Read());
//             while (reader.Read())
//             {
//                 // System.Console.Write("\t");
//                 System.Console.Write(reader.GetValue(0).ToString());
//                 System.Console.Write("\t");
//                 System.Console.Write(reader.GetValue(1).ToString());
//                 System.Console.Write("\t");
//                 System.Console.Write(reader.GetValue(2).ToString());
//                 System.Console.Write("\t");
//                 System.Console.WriteLine(reader.GetValue(3).ToString());
//                 System.Console.Write("\t");
//             }
//         }
//         catch (Exception e)
//         {
//             System.Console.WriteLine("Error occured while connecting to repository.", 3);
//             System.Console.WriteLine("MySQL Exception: " + e, 5);
//             // result = false;
//         }
//     }


using MySqlConnector;
using StudentMangement;

public class MyClass
{
   public static void Main(string[] args)
   {
      // AddRecord Sheraz1=new AddRecord();
      // Sheraz1.AddData();
   //    DisplayClass Sheraz=new DisplayClass();
   //    Sheraz.Display();
   //    Search Sheraz2=new Search();
   //   Sheraz2.SearchData();
     Delet Sheraz3=new Delet();
     Sheraz3.AddData();



   }
  
}


// DELETE FROM `Admin` WHERE Mobile=987654321;
