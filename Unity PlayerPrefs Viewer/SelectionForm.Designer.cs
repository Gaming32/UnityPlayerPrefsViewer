namespace Unity_PlayerPrefs_Viewer
{
    partial class SelectionForm
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
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.InfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.DiscoverButton = new System.Windows.Forms.Button();
            this.DiscoveredSoftware = new System.Windows.Forms.ListBox();
            this.ClearDiscoveredSoftware = new System.Windows.Forms.Button();
            this.DisableCheck = new System.Windows.Forms.CheckBox();
            this.InfoTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(3, 11);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "Company Name";
            this.CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(10, 46);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(75, 13);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Product Name";
            this.ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfoTable
            // 
            this.InfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTable.AutoSize = true;
            this.InfoTable.ColumnCount = 2;
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InfoTable.Controls.Add(this.CompanyNameLabel, 0, 0);
            this.InfoTable.Controls.Add(this.ProductNameLabel, 0, 1);
            this.InfoTable.Controls.Add(this.CompanyName, 1, 0);
            this.InfoTable.Controls.Add(this.ProductName, 1, 1);
            this.InfoTable.Controls.Add(this.DisableCheck, 0, 2);
            this.InfoTable.Controls.Add(this.DiscoverButton, 1, 3);
            this.InfoTable.Location = new System.Drawing.Point(12, 12);
            this.InfoTable.Name = "InfoTable";
            this.InfoTable.RowCount = 1;
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoTable.Size = new System.Drawing.Size(714, 122);
            this.InfoTable.TabIndex = 2;
            // 
            // CompanyName
            // 
            this.CompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyName.Location = new System.Drawing.Point(91, 7);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(620, 20);
            this.CompanyName.TabIndex = 2;
            // 
            // ProductName
            // 
            this.ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductName.Location = new System.Drawing.Point(91, 42);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(620, 20);
            this.ProductName.TabIndex = 3;
            // 
            // DiscoverButton
            // 
            this.DiscoverButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoTable.SetColumnSpan(this.DiscoverButton, 2);
            this.DiscoverButton.Location = new System.Drawing.Point(286, 96);
            this.DiscoverButton.Name = "DiscoverButton";
            this.DiscoverButton.Size = new System.Drawing.Size(142, 23);
            this.DiscoverButton.TabIndex = 4;
            this.DiscoverButton.Text = "Discover";
            this.DiscoverButton.UseVisualStyleBackColor = true;
            this.DiscoverButton.Click += new System.EventHandler(this.DiscoverButton_Click);
            // 
            // DiscoveredSoftware
            // 
            this.DiscoveredSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscoveredSoftware.Location = new System.Drawing.Point(12, 212);
            this.DiscoveredSoftware.Name = "DiscoveredSoftware";
            this.DiscoveredSoftware.Size = new System.Drawing.Size(714, 173);
            this.DiscoveredSoftware.TabIndex = 3;
            // 
            // ClearDiscoveredSoftware
            // 
            this.ClearDiscoveredSoftware.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearDiscoveredSoftware.Location = new System.Drawing.Point(298, 391);
            this.ClearDiscoveredSoftware.Name = "ClearDiscoveredSoftware";
            this.ClearDiscoveredSoftware.Size = new System.Drawing.Size(150, 23);
            this.ClearDiscoveredSoftware.TabIndex = 4;
            this.ClearDiscoveredSoftware.Text = "Clear List";
            this.ClearDiscoveredSoftware.UseVisualStyleBackColor = true;
            this.ClearDiscoveredSoftware.Click += new System.EventHandler(this.ClearDiscoveredSoftware_Click);
            // 
            // DisableCheck
            // 
            this.DisableCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisableCheck.AutoSize = true;
            this.InfoTable.SetColumnSpan(this.DisableCheck, 2);
            this.DisableCheck.Location = new System.Drawing.Point(281, 73);
            this.DisableCheck.Name = "DisableCheck";
            this.DisableCheck.Size = new System.Drawing.Size(151, 17);
            this.DisableCheck.TabIndex = 5;
            this.DisableCheck.Text = "Disable PlayerPrefs Check";
            this.DisableCheck.UseVisualStyleBackColor = true;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 426);
            this.Controls.Add(this.ClearDiscoveredSoftware);
            this.Controls.Add(this.DiscoveredSoftware);
            this.Controls.Add(this.InfoTable);
            this.Name = "SelectionForm";
            this.Text = "Select Software";
            this.InfoTable.ResumeLayout(false);
            this.InfoTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TableLayoutPanel InfoTable;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.ListBox DiscoveredSoftware;
        private System.Windows.Forms.Button DiscoverButton;
        private System.Windows.Forms.Button ClearDiscoveredSoftware;
        private System.Windows.Forms.CheckBox DisableCheck;
    }
}

