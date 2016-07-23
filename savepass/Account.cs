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
		public bool isNull;

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
			//return _passwordCr;
			return _password;
		}
		
		public string getNote()
		{
			return _note;
		}
		
		public Account()
		{
			this.isNull = true;	
		}
		
		public void fillAccount(string res_name, string login, string email, string note, string pw, string pw2)
		{
			this.isNull = false;
			this._webName = res_name;
			this._nameAccount = login;
			this._password = pw;
			this._password2 = pw2;
			this._email = email;
			this._note = note ;
		}
	//public string readacc(){
	//	return NameAccount + "\n " + Password;
	//}
	
		public bool checkCorrectAcc()
		{
			this.checkPasswEqual();
			this.encryptPassw();
			return _isOk;
			
		}
		
		private void checkPasswEqual(){
			if (this._password == this._password2) 
			{
				this._isOk = true;
				Console.WriteLine("passwords is equal");			
				
			}
			else
			{
				this._isOk = false;
				Console.WriteLine("passwords is unequal");
			}
		}
		
		//simple way;
		private void encryptPassw()
		{
			char[] characters_passw = _password.ToCharArray();
			int[] code_characters = new int[_password.Length];
			char[] encr_characters = new char[_password.Length];
			int[] encr_code = new int [_password.Length];
			
			for (int i = 0; i < this._password.Length; i++)
			{
				code_characters[i] = ((int)characters_passw[i]);
				encr_code[i] = code_characters[i] + 3;// for example
				encr_characters[i] = ((char)encr_code[i]);
			}
			
			//string psw = new string(encr_characters);
			this._passwordCr = new string(encr_characters);
			// Add method of encryption
			//return _password;
		}
		
		private void encryptRsa()
		{
		}
		
		private string decrypt_passw()
		{
			string passw = "1";
			return passw;
		}
	}
}


