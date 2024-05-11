using DotNetTrainingBatch4.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
//ctrl + . ==> suggestion
//F10  ==> step over( one line by line run )
//F11 detail run
//F9 => break point 

// Ctrl + K Ctrl + D Reformat 





//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = "DESKTOP-FUGQNF4";  // Server Name
//stringBuilder.InitialCatalog = "DotNetTrainingBatch4"; // Database Name
//stringBuilder.UserID = "sa";  //username
//stringBuilder.Password = "sasa@123"; //password
//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
//connection.Open();
//Console.WriteLine("Connection Open . ");


//string query = "select * from Tbl_Blog";
//SqlCommand cmd=new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt= new DataTable();
//sqlDataAdapter.Fill(dt);

//connection.Close();
//Console.WriteLine("Connection Close . ");   //C# and DB Connection completed

////Data Set==> Data Table ==> Data row ==> Data Column
//foreach(DataRow dr in dt.Rows)
//{
//    Console.WriteLine("Blog Id => " + dr["BlogID"]);
//    Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
//    Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
//    Console.WriteLine("Blog Content => " + dr["BlogContent"]);
//    Console.WriteLine("-----------------------------------------");
//}

//ADO Read
//CRUD 


AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
// adoDotNetExample.Create("title","author","content");
//adoDotNetExample.Update(11, "test title", "test author", "test content");
//adoDotNetExample.Delete(11);
adoDotNetExample.Edit(1002);
adoDotNetExample.Edit(1);
Console.ReadKey();