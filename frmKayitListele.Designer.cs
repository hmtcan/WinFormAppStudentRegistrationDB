﻿namespace WinFormAppStudentRegistrationDB
{
	partial class frmKayitListele
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tblOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.okulDBDataSet = new WinFormAppStudentRegistrationDB.OkulDBDataSet();
			this.tbl_OgrenciTableAdapter = new WinFormAppStudentRegistrationDB.OkulDBDataSetTableAdapters.Tbl_OgrenciTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.okulDBDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightSalmon;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(109, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(337, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "ÖĞRENCİ KAYIT LİSTESİ";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.CadetBlue;
			this.button1.Location = new System.Drawing.Point(210, 354);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 46);
			this.button1.TabIndex = 3;
			this.button1.Text = "KAYIT SİL";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.yasDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tblOgrenciBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(76, 74);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(398, 274);
			this.dataGridView1.TabIndex = 4;
			// 
			// adDataGridViewTextBoxColumn
			// 
			this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
			this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
			this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
			// 
			// soyadDataGridViewTextBoxColumn
			// 
			this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
			this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
			this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
			// 
			// telefonDataGridViewTextBoxColumn
			// 
			this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
			this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
			this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
			// 
			// yasDataGridViewTextBoxColumn
			// 
			this.yasDataGridViewTextBoxColumn.DataPropertyName = "Yas";
			this.yasDataGridViewTextBoxColumn.HeaderText = "Yas";
			this.yasDataGridViewTextBoxColumn.Name = "yasDataGridViewTextBoxColumn";
			// 
			// tblOgrenciBindingSource
			// 
			this.tblOgrenciBindingSource.DataMember = "Tbl_Ogrenci";
			this.tblOgrenciBindingSource.DataSource = this.okulDBDataSet;
			// 
			// okulDBDataSet
			// 
			this.okulDBDataSet.DataSetName = "OkulDBDataSet";
			this.okulDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tbl_OgrenciTableAdapter
			// 
			this.tbl_OgrenciTableAdapter.ClearBeforeFill = true;
			// 
			// frmKayitListele
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 412);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "frmKayitListele";
			this.Text = "Kayıt Listele";
			this.Load += new System.EventHandler(this.frmKayitListele_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.okulDBDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private OkulDBDataSet okulDBDataSet;
		private System.Windows.Forms.BindingSource tblOgrenciBindingSource;
		private OkulDBDataSetTableAdapters.Tbl_OgrenciTableAdapter tbl_OgrenciTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yasDataGridViewTextBoxColumn;
	}
}