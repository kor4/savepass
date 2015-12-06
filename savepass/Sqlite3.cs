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
		private string dbName = Application.StartupPath + "\\SP.db3";
		private string NameNewDb;
		private string sql_query;
		
		
		public Sqlite3()
		{
			//string dbName = Application.StartupPath + "\\SP.db3";
			//Console.WriteLine(File.Exists(dbName) ? "File exists." : "File does not exist.");
			if (!File.Exists(dbName))
			{	
				this._createDb();
			}
			
		}
		private void _createDb()
		{
				this.NameNewDb = "SP.db3";
				SQLiteConnection.CreateFile(NameNewDb);
				SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", NameNewDb));
				SQLiteCommand cmd = new SQLiteCommand(@"CREATE TABLE [tbl_passwords] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [resource_name] char(100) NOT NULL,
                    [login] char(50) NOT NULL,
                    [email] char(50),
                    [password] char(250) NOT NULL,
                    [note] char(100) NOT NULL,
                    [del] integer NOT NULL
                    )", connection);
     			connection.Open();
        		cmd.ExecuteNonQuery();
        		connection.Close();	  									
		}
		
		public DataTable getRecords()
		{
			string dbName = Application.StartupPath + "\\SP.db3";
			DataSet ds = new DataSet();
			SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", dbName));
			string sql = "SELECT resource_name, login, email, password, note FROM tbl_passwords WHERE del=0";
			SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
			da.Fill(ds);
			DataTable dt = ds.Tables[0];
			return dt;
		}
		
		public void newRecord(Account Acc)//(string rn, string lg, string em, string pw, string nt)
		{
			SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", NameNewDb));
			SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO tbl_passwords (resource_name, login, email, password, note, del ) values (@rn, @lg, @em, @pw, @nt, 0)", connection);
			
			SQLiteParameter param = new SQLiteParameter();
            param.ParameterName = "@rn";
            param.Value = Acc.getWebName();
            cmd.Parameters.Add(param);
                     
            param = new SQLiteParameter();        
            param.ParameterName = "@lg";
            param.Value = Acc.getNameAccount();
            //param.SqlDbType = SqlDbType.Text;
            cmd.Parameters.Add(param);
            
            param = new SQLiteParameter();
            param.ParameterName = "@em";          
            param.Value = Acc.getEmail();
            //param.SqlDbType = SqlDbType.Text;      
            cmd.Parameters.Add(param);
			
            param = new SQLiteParameter();
            param.ParameterName = "@pw";          
            param.Value = Acc.getPasswordCr();
            //param.SqlDbType = SqlDbType.Text;      
            cmd.Parameters.Add(param);  

			param = new SQLiteParameter();
            param.ParameterName = "@nt";          
            param.Value = Acc.getNote();
            //param.SqlDbType = SqlDbType.Text;      
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
		public void editRecord()
		{
			SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", NameNewDb));
			SQLiteCommand cmd = new SQLiteCommand(@"UPDATE tBl_passwords SET resource_name = @rn, login = @lg, email = @em, password = @pw, note = @nt, del = 0", connection);
			SqlParameter param = new SqlParameter();
           
            param.ParameterName = "@rn";
            param.Value = "1" ;//arg1
            param.SqlDbType = SqlDbType.Text;
            cmd.Parameters.Add(param);
                      
            param = new SqlParameter();         
            param.ParameterName = "@lg";
            param.Value = "1" ;//arg2
            param.SqlDbType = SqlDbType.Text;
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
