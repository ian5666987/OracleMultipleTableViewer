﻿namespace MultipleTableViewer {
	partial class OracleMultipleTableViewersForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OracleMultipleTableViewersForm));
			this.labelDBConnStat = new System.Windows.Forms.Label();
			this.textBoxDBPassword = new System.Windows.Forms.TextBox();
			this.textBoxDBUserID = new System.Windows.Forms.TextBox();
			this.textBoxDBDataSource = new System.Windows.Forms.TextBox();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panelDbConnection = new System.Windows.Forms.Panel();
			this.labelTableNumber = new System.Windows.Forms.Label();
			this.numericUpDownTableNumber = new System.Windows.Forms.NumericUpDown();
			this.pictureBoxConnection = new System.Windows.Forms.PictureBox();
			this.panelDbConnection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTableNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnection)).BeginInit();
			this.SuspendLayout();
			// 
			// labelDBConnStat
			// 
			this.labelDBConnStat.AutoSize = true;
			this.labelDBConnStat.Location = new System.Drawing.Point(586, 12);
			this.labelDBConnStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDBConnStat.Name = "labelDBConnStat";
			this.labelDBConnStat.Size = new System.Drawing.Size(63, 13);
			this.labelDBConnStat.TabIndex = 34;
			this.labelDBConnStat.Text = "Uninitialized";
			// 
			// textBoxDBPassword
			// 
			this.textBoxDBPassword.Location = new System.Drawing.Point(379, 8);
			this.textBoxDBPassword.Name = "textBoxDBPassword";
			this.textBoxDBPassword.PasswordChar = '*';
			this.textBoxDBPassword.Size = new System.Drawing.Size(86, 20);
			this.textBoxDBPassword.TabIndex = 17;
			// 
			// textBoxDBUserID
			// 
			this.textBoxDBUserID.Location = new System.Drawing.Point(224, 8);
			this.textBoxDBUserID.Name = "textBoxDBUserID";
			this.textBoxDBUserID.Size = new System.Drawing.Size(86, 20);
			this.textBoxDBUserID.TabIndex = 16;
			// 
			// textBoxDBDataSource
			// 
			this.textBoxDBDataSource.Location = new System.Drawing.Point(79, 8);
			this.textBoxDBDataSource.Name = "textBoxDBDataSource";
			this.textBoxDBDataSource.Size = new System.Drawing.Size(86, 20);
			this.textBoxDBDataSource.TabIndex = 15;
			// 
			// buttonConnect
			// 
			this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonConnect.Location = new System.Drawing.Point(478, 6);
			this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(79, 24);
			this.buttonConnect.TabIndex = 22;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(319, 11);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 13);
			this.label9.TabIndex = 13;
			this.label9.Text = "Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(174, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "User ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Data Source";
			// 
			// panelDbConnection
			// 
			this.panelDbConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelDbConnection.Controls.Add(this.labelTableNumber);
			this.panelDbConnection.Controls.Add(this.numericUpDownTableNumber);
			this.panelDbConnection.Controls.Add(this.labelDBConnStat);
			this.panelDbConnection.Controls.Add(this.label1);
			this.panelDbConnection.Controls.Add(this.pictureBoxConnection);
			this.panelDbConnection.Controls.Add(this.label2);
			this.panelDbConnection.Controls.Add(this.textBoxDBPassword);
			this.panelDbConnection.Controls.Add(this.label9);
			this.panelDbConnection.Controls.Add(this.textBoxDBUserID);
			this.panelDbConnection.Controls.Add(this.buttonConnect);
			this.panelDbConnection.Controls.Add(this.textBoxDBDataSource);
			this.panelDbConnection.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelDbConnection.Location = new System.Drawing.Point(0, 0);
			this.panelDbConnection.Name = "panelDbConnection";
			this.panelDbConnection.Size = new System.Drawing.Size(819, 37);
			this.panelDbConnection.TabIndex = 47;
			// 
			// labelTableNumber
			// 
			this.labelTableNumber.AutoSize = true;
			this.labelTableNumber.Location = new System.Drawing.Point(657, 12);
			this.labelTableNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTableNumber.Name = "labelTableNumber";
			this.labelTableNumber.Size = new System.Drawing.Size(62, 13);
			this.labelTableNumber.TabIndex = 48;
			this.labelTableNumber.Text = "Table No(s)";
			// 
			// numericUpDownTableNumber
			// 
			this.numericUpDownTableNumber.Location = new System.Drawing.Point(723, 9);
			this.numericUpDownTableNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDownTableNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownTableNumber.Name = "numericUpDownTableNumber";
			this.numericUpDownTableNumber.ReadOnly = true;
			this.numericUpDownTableNumber.Size = new System.Drawing.Size(50, 20);
			this.numericUpDownTableNumber.TabIndex = 35;
			this.numericUpDownTableNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownTableNumber.ValueChanged += new System.EventHandler(this.numericUpDownTableNumber_ValueChanged);
			// 
			// pictureBoxConnection
			// 
			this.pictureBoxConnection.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxConnection.Location = new System.Drawing.Point(567, 10);
			this.pictureBoxConnection.Name = "pictureBoxConnection";
			this.pictureBoxConnection.Size = new System.Drawing.Size(17, 17);
			this.pictureBoxConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxConnection.TabIndex = 24;
			this.pictureBoxConnection.TabStop = false;
			// 
			// OracleMultipleTableViewersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 37);
			this.Controls.Add(this.panelDbConnection);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(835, 76);
			this.MinimumSize = new System.Drawing.Size(835, 76);
			this.Name = "OracleMultipleTableViewersForm";
			this.Text = "Oracle Multipe Tables Viewer v1.2";
			this.panelDbConnection.ResumeLayout(false);
			this.panelDbConnection.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTableNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnection)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelDBConnStat;
		private System.Windows.Forms.PictureBox pictureBoxConnection;
		private System.Windows.Forms.TextBox textBoxDBPassword;
		private System.Windows.Forms.TextBox textBoxDBUserID;
		private System.Windows.Forms.TextBox textBoxDBDataSource;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelDbConnection;
		private System.Windows.Forms.NumericUpDown numericUpDownTableNumber;
		private System.Windows.Forms.Label labelTableNumber;
	}
}

