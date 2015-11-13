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
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//ConnectionMDB conn;
			ConnectionMDB conn= new ConnectionMDB();
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//if 
			Account acc1 = new Account(tbWebRes.Text,tbName.Text);
			label1.Text=acc1.readacc();
					
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
		
		
	}
}
