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

        private void PlayerPrefsGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

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
                        row.Cells[0].ReadOnly = true;

                        row.Cells[1].Value = valueNameMatch.Groups[1];
                        row.Cells[1].ReadOnly = true;

                        object value = productKey.GetValue(valueName);
                        RegistryValueKind valueKind = productKey.GetValueKind(valueName);
                        if (valueKind == RegistryValueKind.Binary)
                        {
                            row.Cells[2].Value = "String (string)";
                            row.Cells[5].Value = Encoding.UTF8.GetString((byte[])value);
                        }
                        else
                        {
                            try
                            {
                                long longValue = (long)value;
                                row.Cells[4].Value = BitConverter.Int64BitsToDouble(longValue);
                                row.Cells[2].Value = "Float (float)";
                            }
                            catch (InvalidCastException)
                            {
                                int intValue = (int)value;
                                row.Cells[3].Value = intValue;
                                row.Cells[2].Value = "Integer (int)";
                            }
                        }


                        PlayerPrefsGrid.Rows.Add(row);
                    }
                }
            }
            hasLoadedPrefs = true;
        }
    }
}
