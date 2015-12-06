/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 06.12.2015
 * Time: 18:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace savepass
{
	/// <summary>
	/// Description of Account.
	/// </summary>
	public class Account
	{
		private string _webName;
		private string _nameAccount;
		private string _password;
		private string _password2;
		private string _passwordCr;
		private string _email;
		private string _note;
		private bool _isOk;
		

		public string getWebName()
		{
			return _webName;
		}
		
		public string getNameAccount()
		{
			return _nameAccount;
		}
		
		public string getEmail()
		{
			return _email;
		}
		
		public string getPasswordCr()
		{
			return _passwordCr;
		}
		
		public string getNote()
		{
			return _note;
		}
		
		public Account(string str1,string str2, string str3, string str4, string str5, string str6 )
		{
			this._webName=str1;
			this._nameAccount=str2;
			this._password = str3;
			this._password2 = str4;
			this._email = str5;
			this._note = str6 ;
			//writeToFile();	
		}
	//public string readacc(){
	//	return NameAccount + "\n " + Password;
	//}
	
		public bool checkCorrectAcc()
		{
			this.checkPasswEqual();
			return _isOk;
			
		}
		
		private void checkPasswEqual(){
			if (this._password == this._password2) 
			{
				this._isOk = true;
				this._passwordCr = encryptPassw();
				Console.WriteLine("passwords is equal");			
				
			}
			else
			{
				this._isOk = false;
				Console.WriteLine("passwords is unequal");
			}
		}
	
		private string encryptPassw()
		{
			string passw_encr = "1";
			// Add method of encryption
			return _password;
		}
		
		private string decrypt_passw()
		{
			string passw = "1";
			return passw;
		}
	}
}


