/*
 * Created by SharpDevelop.
 * User: Александр
 * Date: 19.07.2015
 * Time: 9:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace savepass
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Sqlite3 sqlconn;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			sqlconn = new Sqlite3();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void bWriteClick(object sender, EventArgs e)
		{
			//if 
			Account acc1 = new Account(tbWebRes.Text, tbName.Text, tbPassword.Text, tbPassword2.Text, tbEmail.Text, tbNote.Text );
			//sqlconn.NewRecord(acc1.;
			//label1.Text=acc1.readacc();
			//acc1.WriteAccToDB();
			if (acc1.checkCorrectAcc())
			{
				sqlconn.newRecord(acc1);
			}
			
					
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e){
		
			if (checkBox1.Checked == true) {
				this.tbEmail.Enabled=true;
				this.tbName.Enabled=false;
			}
			else {
				this.tbEmail.Enabled=false;
				this.tbName.Enabled=true;
			}
		}
		
		
		
		void BReadClick(object sender, EventArgs e)
		{
			this.dataGrid.DataSource = sqlconn.getRecords();
		}
	}
}
