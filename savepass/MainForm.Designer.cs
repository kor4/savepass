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
			this.lbWerRes = new System.Windows.Forms.ListBox();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.bRead = new System.Windows.Forms.Button();
			this.btEdit = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// bWrite
			// 
			this.bWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.bWrite.Location = new System.Drawing.Point(1, 23);
			this.bWrite.Name = "bWrite";
			this.bWrite.Size = new System.Drawing.Size(137, 94);
			this.bWrite.TabIndex = 0;
			this.bWrite.Text = "Новая Запись";
			this.bWrite.UseVisualStyleBackColor = true;
			this.bWrite.Click += new System.EventHandler(this.bWriteClick);
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
			this.dataGrid.Location = new System.Drawing.Point(1, 120);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid.Size = new System.Drawing.Size(836, 357);
			this.dataGrid.TabIndex = 17;
			this.dataGrid.CurrentCellChanged += new System.EventHandler(this.DataGridCurrentCellChanged);
			// 
			// bRead
			// 
			this.bRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bRead.ForeColor = System.Drawing.Color.Blue;
			this.bRead.Location = new System.Drawing.Point(4, 483);
			this.bRead.Name = "bRead";
			this.bRead.Size = new System.Drawing.Size(134, 94);
			this.bRead.TabIndex = 18;
			this.bRead.Text = "Обновить";
			this.bRead.UseVisualStyleBackColor = true;
			this.bRead.Click += new System.EventHandler(this.BReadClick);
			// 
			// btEdit
			// 
			this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btEdit.ForeColor = System.Drawing.Color.Goldenrod;
			this.btEdit.Location = new System.Drawing.Point(144, 23);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(134, 94);
			this.btEdit.TabIndex = 19;
			this.btEdit.Text = "Изменить";
			this.btEdit.UseVisualStyleBackColor = true;
			this.btEdit.Click += new System.EventHandler(this.bEditClick);
			// 
			// btDelete
			// 
			this.btDelete.ForeColor = System.Drawing.Color.OrangeRed;
			this.btDelete.Location = new System.Drawing.Point(688, 483);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(137, 22);
			this.btDelete.TabIndex = 20;
			this.btDelete.Text = "Стереть";
			this.btDelete.UseVisualStyleBackColor = true;
			this.btDelete.Click += new System.EventHandler(this.BtDeleteClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 604);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btEdit);
			this.Controls.Add(this.bRead);
			this.Controls.Add(this.dataGrid);
			this.Controls.Add(this.lbWerRes);
			this.Controls.Add(this.bWrite);
			this.Name = "MainForm";
			this.Text = "savepass";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btDelete;
		private System.Windows.Forms.Button btEdit;
		private System.Windows.Forms.Button bRead;
		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.ListBox lbWerRes;
		private System.Windows.Forms.Button bWrite;
		
	
		
		
		
		
		
		
	
	}
}
