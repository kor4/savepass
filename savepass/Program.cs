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
	private string Password2;
	private string PasswordCr;
	private string email;
	private string note;
	private bool ok;
	

	public Account(string str1,string str2, string str3,string str4){
		this.WebName=str1;
		this.NameAccount=str2;
		this.Password = str3;
		this.Password2 = str4;
		//this.PasswordCr=encrypt_passw ();
		//writeToFile();
		
	}
	public string readacc(){
		return NameAccount + "\n " + Password;
	}
	
	public void WriteAccToDB(){
		this.CheckPasswEqual();
	}
	private void CheckPasswEqual(){
		if (this.Password == this.Password2) 
		{
			this.ok = true;
			Console.WriteLine("passwords is equal");			
			
		}
		else
		{
			this.ok = false;
			Console.WriteLine("passwords is unequal");
		}
	}
	private string encrypt_passw(){
		string passw_encr = "1";
		return passw_encr;
	}
	private string decrypt_passw(){
		string passw = "1";
		return passw;
	}
}


//public class 