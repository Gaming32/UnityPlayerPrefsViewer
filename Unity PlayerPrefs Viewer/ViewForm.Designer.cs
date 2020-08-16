namespace Unity_PlayerPrefs_Viewer
{
    partial class ViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PlayerPrefsGrid = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IntegerValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloatValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StringValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPrefsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerPrefsGrid
            // 
            this.PlayerPrefsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerPrefsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerPrefsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.TypeColumn,
            this.IntegerValueColumn,
            this.FloatValueColumn,
            this.StringValueColumn});
            this.PlayerPrefsGrid.Location = new System.Drawing.Point(0, 0);
            this.PlayerPrefsGrid.Name = "PlayerPrefsGrid";
            this.PlayerPrefsGrid.Size = new System.Drawing.Size(643, 278);
            this.PlayerPrefsGrid.TabIndex = 1;
            this.PlayerPrefsGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerPrefsGrid_CellValidated);
            this.PlayerPrefsGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.PlayerPrefsGrid_CellValidating);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Items.AddRange(new object[] {
            "Integer (int)",
            "Float (float)",
            "String (string)"});
            this.TypeColumn.Name = "TypeColumn";
            // 
            // IntegerValueColumn
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.IntegerValueColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.IntegerValueColumn.HeaderText = "Integer";
            this.IntegerValueColumn.Name = "IntegerValueColumn";
            // 
            // FloatValueColumn
            // 
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = "0";
            this.FloatValueColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.FloatValueColumn.HeaderText = "Float";
            this.FloatValueColumn.Name = "FloatValueColumn";
            // 
            // StringValueColumn
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.StringValueColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.StringValueColumn.HeaderText = "String";
            this.StringValueColumn.Name = "StringValueColumn";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 278);
            this.Controls.Add(this.PlayerPrefsGrid);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPrefsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView PlayerPrefsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegerValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloatValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StringValueColumn;
    }
}