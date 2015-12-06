/*
 * Created by SharpDevelop.
 * User: Александр
 * Date: 19.07.2015
 * Time: 9:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace savepass
{
	partial class MainForm
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
			this.bWrite = new System.Windows.Forms.Button();
			this.tbWebRes = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.bOpenList = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.tbPassword2 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.tbNote = new System.Windows.Forms.TextBox();
			this.lbWerRes = new System.Windows.Forms.ListBox();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.bRead = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// bWrite
			// 
			this.bWrite.Location = new System.Drawing.Point(339, 439);
			this.bWrite.Name = "bWrite";
			this.bWrite.Size = new System.Drawing.Size(137, 94);
			this.bWrite.TabIndex = 0;
			this.bWrite.Text = "Записать";
			this.bWrite.UseVisualStyleBackColor = true;
			this.bWrite.Click += new System.EventHandler(this.bWriteClick);
			// 
			// tbWebRes
			// 
			this.tbWebRes.Location = new System.Drawing.Point(121, 231);
			this.tbWebRes.Name = "tbWebRes";
			this.tbWebRes.Size = new System.Drawing.Size(211, 20);
			this.tbWebRes.TabIndex = 1;
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(121, 309);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(211, 20);
			this.tbEmail.TabIndex = 2;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(121, 283);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(211, 20);
			this.tbName.TabIndex = 3;
			// 
			// bOpenList
			// 
			this.bOpenList.Location = new System.Drawing.Point(416, 544);
			this.bOpenList.Name = "bOpenList";
			this.bOpenList.Size = new System.Drawing.Size(75, 23);
			this.bOpenList.TabIndex = 4;
			this.bOpenList.Text = "button2";
			this.bOpenList.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(101, 537);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 50);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// checkBox1
			// 
			this.checkBox1.Enabled = false;
			this.checkBox1.Location = new System.Drawing.Point(121, 257);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(151, 20);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Вход по почте/имени";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(121, 353);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(211, 20);
			this.tbPassword.TabIndex = 7;
			// 
			// domainUpDown1
			// 
			this.domainUpDown1.Location = new System.Drawing.Point(272, 547);
			this.domainUpDown1.Name = "domainUpDown1";
			this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
			this.domainUpDown1.TabIndex = 8;
			this.domainUpDown1.Text = "domainUpDown1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(362, 230);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = "ВебРесурс";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(362, 283);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 10;
			this.textBox2.Text = "Имя/Ник";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(362, 309);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 11;
			this.textBox3.Text = "Почта";
			// 
			// tbPassword2
			// 
			this.tbPassword2.Location = new System.Drawing.Point(121, 379);
			this.tbPassword2.Name = "tbPassword2";
			this.tbPassword2.Size = new System.Drawing.Size(211, 20);
			this.tbPassword2.TabIndex = 12;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(362, 353);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 13;
			this.textBox4.Text = "Пароль";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(362, 379);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 14;
			this.textBox5.Text = "Повторите П";
			// 
			// tbNote
			// 
			this.tbNote.Location = new System.Drawing.Point(122, 439);
			this.tbNote.Multiline = true;
			this.tbNote.Name = "tbNote";
			this.tbNote.Size = new System.Drawing.Size(211, 38);
			this.tbNote.TabIndex = 15;
			this.tbNote.Text = "Комментарий";
			// 
			// lbWerRes
			// 
			this.lbWerRes.FormattingEnabled = true;
			this.lbWerRes.Location = new System.Drawing.Point(1, 0);
			this.lbWerRes.Name = "lbWerRes";
			this.lbWerRes.Size = new System.Drawing.Size(58, 17);
			this.lbWerRes.TabIndex = 16;
			// 
			// dataGrid
			// 
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Location = new System.Drawing.Point(1, 41);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(836, 151);
			this.dataGrid.TabIndex = 17;
			// 
			// bRead
			// 
			this.bRead.Location = new System.Drawing.Point(498, 439);
			this.bRead.Name = "bRead";
			this.bRead.Size = new System.Drawing.Size(134, 94);
			this.bRead.TabIndex = 18;
			this.bRead.Text = "bRead";
			this.bRead.UseVisualStyleBackColor = true;
			this.bRead.Click += new System.EventHandler(this.BReadClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 604);
			this.Controls.Add(this.bRead);
			this.Controls.Add(this.dataGrid);
			this.Controls.Add(this.lbWerRes);
			this.Controls.Add(this.tbNote);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.tbPassword2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.domainUpDown1);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bOpenList);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.tbWebRes);
			this.Controls.Add(this.bWrite);
			this.Name = "MainForm";
			this.Text = "savepass";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button bRead;
		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.ListBox lbWerRes;
		private System.Windows.Forms.TextBox tbNote;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox tbPassword2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DomainUpDown domainUpDown1;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bOpenList;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbWebRes;
		private System.Windows.Forms.Button bWrite;
		
	
		
		
		
		
		
		
	
	}
}
