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
using System.Data.SQLite;


namespace savepass
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Sqlite3
	{
		//string databaseName =  @"C:\cyber.db";
		public Sqlite3()
		{
			string curDb = string.Concat(Path.GetFullPath("mydir") , @"\SP.db");
			Console.WriteLine(File.Exists("curDB") ? "File exists." : "File does not exist.");
			if (!File.Exists(curDb))
			{	
				createDB();
			}
		}
		private void createDB()
		{
			string databaseName = Path.GetFullPath("mydir") + "\\SP.db";
			
			SQLiteConnection.CreateFile(databaseName);
		}
		private void ConnectionDB()
		{
			
		}
	}
}
