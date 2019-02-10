using System.Linq;
using System.Collections.Generic;

namespace MultipleTableViewer {
	public class SingleTableSpecifierPanel : System.Windows.Forms.Panel {
		private int specifierNo = 0;
		public int SpecifierId {
			get { return specifierNo; }
			set {
				specifierNo = value;
				string specifier = specifierNo.ToString();
				this.comboBox.Name = string.Concat("comboBox", specifier);
				this.checkBox.Name = string.Concat("checkBoxView", specifier);
				this.labelNo.Name = string.Concat("labelNo", specifier);
				this.numericUpDown.Name = string.Concat("numericUpDown", specifier);
				this.labelRows.Name = string.Concat("labelRows", specifier);
				this.checkBoxAddIndex.Name = string.Concat("checkBoxAddIndex", specifier);
				this.textBox.Name = string.Concat("textBox", specifier);
				this.labelWhere.Name = string.Concat("labelWhere", specifier);
				this.linkLabelRefresh.Name = string.Concat("linkLabelRefresh", specifier);
				this.linkLabelFrom.Name = string.Concat("linkLabelFrom", specifier);
				this.labelNo.Text = specifierNo.ToString();
			}
		}

		public bool ViewChecked { get { return this.checkBox.Checked; } set { this.checkBox.Checked = value; } }
		public bool IndexAdded { get { return this.checkBoxAddIndex.Checked; } set { this.checkBoxAddIndex.Checked = value; } }
		public string WhereClause { get { return this.textBox.Text; } set { this.textBox.Text = value; } }
		public int MaxRows { get { return (int)this.numericUpDown.Value; } set { this.numericUpDown.Value = new decimal(new int[] { value, 0, 0, 0 }); } }
		public string TableName { get { return this.comboBox.SelectedIndex >= 0 ? this.comboBox.SelectedItem.ToString() : null; } }

		public string ColumnsClause { get { return includeColumns == null || includeColumns.Count <= 0 ? "" : string.Join(", ", includeColumns); } }
		public int IncludeCount { get { return includeColumns.Count; } }
		public List<string> IncludeColumns { get { return new List<string>(includeColumns); } } //creates copy by design
		public List<string> ExcludeColumns { get { return new List<string>(excludeColumns); } } //creates copy by design
		private List<string> includeColumns = new List<string>(); //cannot be null by design
		private List<string> excludeColumns = new List<string>(); //cannot be null by design

		public SingleTableSpecifierPanel(){
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.checkBox = new System.Windows.Forms.CheckBox();
			this.labelNo = new System.Windows.Forms.Label();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.labelRows = new System.Windows.Forms.Label();
			this.checkBoxAddIndex = new System.Windows.Forms.CheckBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.labelWhere = new System.Windows.Forms.Label();
			this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
			this.linkLabelFrom = new System.Windows.Forms.LinkLabel();

			this.Height = 35;
			this.Width = 819;

			string specifier = specifierNo.ToString();

			// 
			// labelNo
			// 
			this.labelNo.AutoSize = true;
			this.labelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNo.Location = new System.Drawing.Point(6, 10);
			this.labelNo.Name = string.Concat("labelNo", specifier);
			this.labelNo.Size = new System.Drawing.Size(16, 16);
			this.labelNo.TabIndex = 24;
			this.labelNo.Text = specifierNo.ToString();
			this.labelNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

			// 
			// comboBox
			// 
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(35, 7);
			this.comboBox.Name = string.Concat("comboBox", specifier);
			this.comboBox.Size = new System.Drawing.Size(199, 21);
			this.comboBox.TabIndex = 4;
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

			// 
			// linkLabel
			// 
			this.linkLabelFrom.AutoSize = true;
			this.linkLabelFrom.Location = new System.Drawing.Point(240, 10);
			this.linkLabelFrom.Name = string.Concat("linkLabelFrom", specifier);
			//this.linkLabelFrom.Size = new System.Drawing.Size(55, 13);
			this.linkLabelFrom.TabIndex = 47;
			this.linkLabelFrom.TabStop = true;
			this.linkLabelFrom.Text = "From";

			// 
			// checkBoxView
			// 
			this.checkBox.AutoSize = true;
			this.checkBox.Location = new System.Drawing.Point(275, 9);
			this.checkBox.Name = string.Concat("checkBoxView", specifier);
			this.checkBox.Size = new System.Drawing.Size(49, 17);
			this.checkBox.TabIndex = 8;
			this.checkBox.Text = "View";
			this.checkBox.UseVisualStyleBackColor = true;

			// 
			// checkBoxAddIndex
			// 
			this.checkBoxAddIndex.AutoSize = true;
			this.checkBoxAddIndex.Location = new System.Drawing.Point(325, 9);
			this.checkBoxAddIndex.Name = string.Concat("checkBoxAddIndex", specifier);
			this.checkBoxAddIndex.Size = new System.Drawing.Size(52, 17);
			this.checkBoxAddIndex.TabIndex = 36;
			this.checkBoxAddIndex.Text = "Index";
			this.checkBoxAddIndex.UseVisualStyleBackColor = true;

			// 
			// labelRows
			// 
			this.labelRows.AutoSize = true;
			this.labelRows.Location = new System.Drawing.Point(373, 10);
			this.labelRows.Name = string.Concat("labelRows", specifier);
			this.labelRows.Size = new System.Drawing.Size(57, 13);
			this.labelRows.TabIndex = 35;
			this.labelRows.Text = "Max Rows";

			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(446, 8);
			this.numericUpDown.Name = string.Concat("numericUpDown", specifier);
			this.numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown.Size = new System.Drawing.Size(55, 20);
			this.numericUpDown.TabIndex = 34;
			this.numericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});

			// 
			// labelWhere
			// 
			this.labelWhere.AutoSize = true;
			this.labelWhere.Location = new System.Drawing.Point(508, 10);
			this.labelWhere.Name = string.Concat("labelWhere", specifier);
			this.labelWhere.Size = new System.Drawing.Size(39, 13);
			this.labelWhere.TabIndex = 38;
			this.labelWhere.Text = "Where";

			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(553, 7);
			this.textBox.Name = string.Concat("textBox", specifier);
			this.textBox.Size = new System.Drawing.Size(200, 20);
			this.textBox.TabIndex = 37;

			// 
			// linkLabel
			// 
			this.linkLabelRefresh.AutoSize = true;
			this.linkLabelRefresh.Location = new System.Drawing.Point(763, 10);
			this.linkLabelRefresh.Name = string.Concat("linkLabelRefresh", specifier);
			this.linkLabelRefresh.Size = new System.Drawing.Size(55, 13);
			this.linkLabelRefresh.TabIndex = 47;
			this.linkLabelRefresh.TabStop = true;
			this.linkLabelRefresh.Text = "Refresh";

			this.Controls.Add(this.linkLabelFrom);
			this.Controls.Add(this.linkLabelRefresh);
			this.Controls.Add(this.labelWhere);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.checkBoxAddIndex);
			this.Controls.Add(this.labelRows);
			this.Controls.Add(this.numericUpDown);
			this.Controls.Add(this.labelNo);
			this.Controls.Add(this.checkBox);
			this.Controls.Add(this.comboBox);
		}

		public SingleTableSpecifierPanel(int specifierNo) {
			SpecifierId = specifierNo;
		}

		public void SetColumns(List<string> includeColumns, List<string> excludeColumns) {
			this.includeColumns = includeColumns == null ? new List<string>() : includeColumns;
			this.excludeColumns = excludeColumns == null ? new List<string>() : excludeColumns;
		}

		public void ResetColumns() {
			this.includeColumns.Clear();
			this.excludeColumns.Clear();
		}

		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.CheckBox checkBox;
		private System.Windows.Forms.Label labelNo;
		private System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.Label labelRows;
		private System.Windows.Forms.CheckBox checkBoxAddIndex;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Label labelWhere;
		private System.Windows.Forms.LinkLabel linkLabelRefresh;
		private System.Windows.Forms.LinkLabel linkLabelFrom;
	}
}
