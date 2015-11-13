/*
 * Created by SharpDevelop.
 * User: Александр
 * Date: 19.07.2015
 * Time: 9:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace savepass
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
class Account{
	private string WebName;
	private string NameAccount;// and email its maybe
	private string Password;
	private string PasswordCr;
	private string email;
	

	public Account(string str1,string str2){
		this.WebName=str1;
		this.NameAccount=str2;	
		//this.PasswordCr=decrypt(this.password)
		//writeToFile();
		
	}
	public string readacc(){
	return NameAccount + "\n " + Password;
	}
	
	public void writeToFile(){
		//OleDbConnection oledb= new OleDbConnection(
	}
}

public class ConnectionMDB{
	OleDbConnection conn;
    OleDbDataAdapter adapter;
    DataTable dtMain;
    string DBPath;
    
    ConnectionMDB(){
     DBPath = "C:\\Users\\Александр\\Documents\\testt.mdb";
     
    }
    

};
