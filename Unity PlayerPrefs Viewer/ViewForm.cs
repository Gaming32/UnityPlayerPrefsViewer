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
using System.Globalization;

namespace Unity_PlayerPrefs_Viewer
{
    public partial class ViewForm : Form
    {
        public string path;
        public string productName, companyName;
        public static readonly Regex keyRegex = new Regex(@"^(.*)_h\d+$");

        private RegistryKey productKey;
        object previousValue;

        public ViewForm(string path)
        {
            this.path = path;
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                string[] pathParts = path.Split(new char[] { '/' }, 2);
                companyName = pathParts[0];
                productName = pathParts[1];
                productKey = Registry.CurrentUser
                    .OpenSubKey("SOFTWARE")
                    .OpenSubKey(companyName)
                    .OpenSubKey(productName, true);
            }

            InitializeComponent();
        }

        private void PlayerPrefsGrid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = PlayerPrefsGrid.Rows[e.RowIndex];
            if (row.Cells[e.ColumnIndex].Value == previousValue)
                return;

            if (e.ColumnIndex == 3)
            {
                row.Cells[2].Value = "Integer (int)";
            }
            else if (e.ColumnIndex == 4)
            {
                row.Cells[2].Value = "Float (float)";
            }
            else if (e.ColumnIndex == 5)
            {
                row.Cells[2].Value = "String (string)";
            }

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                switch (row.Cells[2].Value)
                {
                    case "Integer (int)":
                        int intValue;
                        if (row.Cells[3].Value == null)
                        {
                            intValue = 0;
                        }
                        else
                        {
                            if (!int.TryParse(row.Cells[3].Value.ToString(),
                                NumberStyles.Integer | NumberStyles.AllowThousands,
                                null,
                                out intValue))
                            {
                                MessageBox.Show($"Invalid integer \"{row.Cells[3].Value}\"",
                                                "PlayerPrefs Viewer",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                break;
                            }
                        }
                        productKey.SetValue((string)row.Cells[0].Value, intValue, RegistryValueKind.DWord);
                        break;
                    case "Float (float)":
                        double floatValue;
                        if (row.Cells[4].Value == null)
                        {
                            floatValue = 0f;
                        }
                        else
                        {
                            if (!double.TryParse(row.Cells[4].Value.ToString(),
                                NumberStyles.Float | NumberStyles.AllowThousands,
                                null,
                                out floatValue))
                            {
                                MessageBox.Show($"Invalid float \"{row.Cells[4].Value}\"",
                                                "PlayerPrefs Viewer",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                break;
                            }
                        }
                        int error = Utilities.SetNamedValue($"SOFTWARE\\{companyName}\\{productName}", (string)row.Cells[0].Value, floatValue);
                        if (error != 0)
                        {
                            MessageBox.Show($"Could not write PlayerPrefs float to registry. (Error code {error})",
                                "PlayerPrefs Viewer",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            break;
                        }
                        break;
                    case "String (string)":
                        productKey.SetValue((string)row.Cells[0].Value, Encoding.UTF8.GetBytes(row.Cells[5].Value.ToString()), RegistryValueKind.Binary);
                        break;
                }
            }
        }

        private void PlayerPrefsGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            previousValue = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            Text = "Editing PlayerPrefs for " + path;
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
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
        }
    }
}
