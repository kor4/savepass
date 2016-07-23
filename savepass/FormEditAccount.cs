/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 14.01.2016
 * Time: 17:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace savepass
{
	
	public partial class FormEditAccount : Form
	{
		public Sqlite3 sqlconn;
		public Account acc;
		public int modeForm; // mode 1 - to adding, mode 2 - to editing
		
		public FormEditAccount(int mode, Account accIn)
		{
			InitializeComponent();
			sqlconn = new Sqlite3();	
			acc = accIn;
			modeForm = mode;
			if (modeForm == 2)
				fillFields();
		
		}
		
		void fillFields()
		{
			this.tbWebRes.Text = acc.getWebName();
			this.tbLogin.Text = acc.getNameAccount();
			this.tbEmail.Text = acc.getEmail();
			this.tbNote.Text = acc.getNote();
			//this.tbPassw.Text = acc.getPasswordCr();
			
			//Locking fileds
			this.tbWebRes.Enabled = false;
		}
		void BtOkClick(object sender, EventArgs e)
		{
			acc.fillAccount(tbWebRes.Text, tbLogin.Text, tbEmail.Text, tbNote.Text, tbPassw.Text, tbPassw2.Text);
			if (modeForm ==1)
			{	
				sqlconn.newRecord(acc);
			}
			else if (modeForm == 2)
			{
				sqlconn.editRecord(acc);
			}
			
			this.Close();
			
		
		}
		
		void BtCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}	
}