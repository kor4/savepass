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
		public Account Acc1;
		public FormEditAccount FrmUp;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Acc1 = new Account();
			sqlconn = new Sqlite3();			
			RefreshDg();
			
			
			//Acc1 = new Account();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void bWriteClick(object sender, EventArgs e)
		{
			FrmUp = new FormEditAccount(1,Acc1);
			FrmUp.ShowDialog();
			//if
			//Acc1 = new Account(tbWebRes.Text, tbName.Text, tbEmail.Text, tbNote.Text, tbPassword.Text, tbPassword2.Text );
			//sqlconn.NewRecord(acc1.;
			//label1.Text=acc1.readacc();
			//acc1.WriteAccToDB();
			//if (Acc1.checkCorrectAcc())
			//{
			//	sqlconn.newRecord(Acc1);
			//	RefreshDg();
			//}
						
		}
		
		void bEditClick(object sender, EventArgs e)
		{
			fillAccount();
			FrmUp = new FormEditAccount(2,Acc1);
			FrmUp.ShowDialog();			                           
		}
		
		void ClearDatagrid()
		{
			while(dataGrid.Rows.Count > 1)
                for (int i = 0; i < dataGrid.Rows.Count-1; i++)
				{
					dataGrid.Rows.Remove(dataGrid.Rows[i]);
				}
			
		}
		
		void BReadClick(object sender, EventArgs e)
		{
			RefreshDg();
		}
		void RefreshDg()
		{
			this.ClearDatagrid();
			this.dataGrid.DataSource = sqlconn.getRecords();
		}
		
		
		
		
		public void fillAccOnForm()
		{
			//tbWebRes.Text = Acc1.getWebName();
			//tbName.Text = Acc1.getNameAccount();
			//tbEmail.Text = Acc1.getEmail();
			//tbNote.Text = Acc1.getNote();
			//tbPassword.Text= Acc1.getPasswordCr();
			//tbPassword2.Text = tbPassword.Text;
		}
		
		private void fillAccount()
		{
			Acc1.fillAccount(dataGrid.CurrentRow.Cells["resource_name"].Value.ToString(),
					           dataGrid.CurrentRow.Cells["login"].Value.ToString(),
					           dataGrid.CurrentRow.Cells["email"].Value.ToString(),
					           dataGrid.CurrentRow.Cells["note"].Value.ToString(),
							   dataGrid.CurrentRow.Cells["password"].Value.ToString(),
							   dataGrid.CurrentRow.Cells["password"].Value.ToString()
							  );
			//fillAccOnForm();
		}
		
	
		
		void DataGridCurrentCellChanged(object sender, EventArgs e)
		{
			//if (dataGrid.Rows.Count!=0)
			//{
			//	fillAccount();
			//}
		}
		
		void BtDeleteClick(object sender, EventArgs e)
		{
			DialogResult Answer = (MessageBox.Show("Yoy are sure??", "Hmm..", MessageBoxButtons.YesNo));
				if (Answer == System.Windows.Forms.DialogResult.Yes)
				{
					fillAccount();
					sqlconn.deleteRecord(Acc1);
					RefreshDg();
				}
    			
		}
		
		void MainFormActivated(object sender, EventArgs e)
		{
			RefreshDg();
		}
	}
}
