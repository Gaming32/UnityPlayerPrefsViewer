using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Unity_PlayerPrefs_Viewer
{
    public partial class ViewForm : Form
    {
        public string path;
        public string productName, companyName;
        private readonly Regex keyRegex = new Regex("^(.*)_h[0-9A-Fa-f]+$");

        private bool hasLoadedPrefs;

        public ViewForm(string path)
        {
            this.path = path;
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                string[] pathParts = path.Split(new char[] { '/' }, 2);
                companyName = pathParts[0];
                productName = pathParts[1];
            }

            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            Text = "Editing PlayerPrefs for " + path;
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                RegistryKey productKey = Registry.CurrentUser
                    .OpenSubKey("SOFTWARE")
                    .OpenSubKey(companyName)
                    .OpenSubKey(productName);
                foreach (string valueName in productKey.GetValueNames())
                {
                    Match valueNameMatch = keyRegex.Match(valueName);
                    if (valueNameMatch.Success)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(PlayerPrefsGrid);
                        row.Cells[0].Value = valueName;
                        row.Cells[1].Value = valueNameMatch.Groups[1];
                        PlayerPrefsGrid.Rows.Add(row);
                    }
                }
            }
            hasLoadedPrefs = true;
        }
    }
}
