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

using System.Data;


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
		
			//Sqlite3 sqlconn = new Sqlite3();
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			

		}
		
	}
}
