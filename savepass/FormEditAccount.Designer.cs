/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 14.01.2016
 * Time: 17:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace savepass
{
	partial class FormEditAccount
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbNote = new System.Windows.Forms.TextBox();
			this.tbPassw = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tbPassw2 = new System.Windows.Forms.TextBox();
			this.tbWebRes = new System.Windows.Forms.TextBox();
			this.btOk = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbLogin
			// 
			this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLogin.Location = new System.Drawing.Point(247, 69);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(238, 20);
			this.tbLogin.TabIndex = 2;
			// 
			// tbEmail
			// 
			this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbEmail.Location = new System.Drawing.Point(247, 122);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(238, 20);
			this.tbEmail.TabIndex = 3;
			// 
			// tbNote
			// 
			this.tbNote.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbNote.Location = new System.Drawing.Point(247, 214);
			this.tbNote.Multiline = true;
			this.tbNote.Name = "tbNote";
			this.tbNote.Size = new System.Drawing.Size(238, 51);
			this.tbNote.TabIndex = 6;
			// 
			// tbPassw
			// 
			this.tbPassw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbPassw.Location = new System.Drawing.Point(247, 162);
			this.tbPassw.Name = "tbPassw";
			this.tbPassw.Size = new System.Drawing.Size(238, 20);
			this.tbPassw.TabIndex = 4;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.tbLogin, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.tbEmail, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tbPassw, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tbNote, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbPassw2, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.tbWebRes, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 268);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(3, 214);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 20;
			this.textBox6.Text = "comment";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(3, 188);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 19;
			this.textBox5.Text = "Повторите П";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(3, 162);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 18;
			this.textBox4.Text = "Пароль";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(3, 109);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 17;
			this.textBox3.Text = "Почта";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(3, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 16;
			this.textBox2.Text = "Имя/Ник";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 15;
			this.textBox1.Text = "ВебРесурс";
			// 
			// tbPassw2
			// 
			this.tbPassw2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbPassw2.Location = new System.Drawing.Point(247, 188);
			this.tbPassw2.Name = "tbPassw2";
			this.tbPassw2.Size = new System.Drawing.Size(238, 20);
			this.tbPassw2.TabIndex = 5;
			// 
			// tbWebRes
			// 
			this.tbWebRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbWebRes.Location = new System.Drawing.Point(247, 16);
			this.tbWebRes.Name = "tbWebRes";
			this.tbWebRes.Size = new System.Drawing.Size(238, 20);
			this.tbWebRes.TabIndex = 1;
			// 
			// btOk
			// 
			this.btOk.Location = new System.Drawing.Point(13, 286);
			this.btOk.Name = "btOk";
			this.btOk.Size = new System.Drawing.Size(418, 32);
			this.btOk.TabIndex = 6;
			this.btOk.Text = "Запись";
			this.btOk.UseVisualStyleBackColor = true;
			this.btOk.Click += new System.EventHandler(this.BtOkClick);
			// 
			// btCancel
			// 
			this.btCancel.ForeColor = System.Drawing.Color.Maroon;
			this.btCancel.Location = new System.Drawing.Point(437, 286);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(61, 32);
			this.btCancel.TabIndex = 7;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.BtCancelClick);
			// 
			// FormEditAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 345);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOk);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FormEditAccount";
			this.Text = "FormEditAccount";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button btOk;
		private System.Windows.Forms.TextBox tbPassw2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox tbPassw;
		private System.Windows.Forms.TextBox tbNote;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbWebRes;
		private System.Windows.Forms.TextBox tbLogin;
	}
}
