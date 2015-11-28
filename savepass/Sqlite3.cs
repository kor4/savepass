/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 28.11.2015
 * Time: 15:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace savepass
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Sqlite3
	{
		private string dbName;
		private string NameNewDb;
		private string sql_query;
		
		public Sqlite3()
		{
			string dbName = Application.StartupPath + "\\SP.db3";
			//Console.WriteLine(File.Exists(dbName) ? "File exists." : "File does not exist.");
			if (!File.Exists(dbName))
			{	
				this.createDB();
			}
			
		}
		private void createDB()
		{
				this.NameNewDb = "SP.db3";
				SQLiteConnection.CreateFile(NameNewDb);
				SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", NameNewDb));
				SQLiteCommand cmd = new SQLiteCommand(@"CREATE TABLE [tBl_passwords] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [resource_name] char(100) NOT NULL,
                    [login] char(50) NOT NULL,
                    [email] char(50),
                    [password] char(250) NOT NULL,
                    [note] char(100) NOT NULL
                    );",connection);
     			connection.Open();
        		cmd.ExecuteNonQuery();
        		connection.Close();	  									
		}
		
		private void NewRecord()
		{
			SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", NameNewDb));
			SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO tBl_passwords (resource_name, login, email, password, note ) values (@rn, @lg, @em, @pw, @nt)", connection);
			SqlParameter param = new SqlParameter();
			
            param.ParameterName = "@rn";
            param.Value = "1" ;//arg1
            param.SqlDbType = SqlDbType.Char;
            cmd.Parameters.Add(param);
                      
            param = new SqlParameter();         
            param.ParameterName = "@lg";
            param.Value = "1" ;//arg2
            param.SqlDbType = SqlDbType.Char;
            cmd.Parameters.Add(param);
            
            param = new SqlParameter();
            param.ParameterName = "@em";          
            param.Value = "1" ;  //arg3      
            param.SqlDbType = SqlDbType.Text;      
            cmd.Parameters.Add(param);
			
            param = new SqlParameter();
            param.ParameterName = "@pw";          
            param.Value = "1"; //arg4        
            param.SqlDbType = SqlDbType.Text;      
            cmd.Parameters.Add(param);  

			param = new SqlParameter();
            param.ParameterName = "@nt";          
            param.Value = "1" ;  //arg5      
            param.SqlDbType = SqlDbType.Text;      
            cmd.Parameters.Add(param);
			
			try
                {
                    cmd.ExecuteNonQuery();
                }
            catch
            {
                Console.WriteLine("Ошибка, при выполнении запроса на добавление записи");
                return;
            }          
			
		}
	}
}
