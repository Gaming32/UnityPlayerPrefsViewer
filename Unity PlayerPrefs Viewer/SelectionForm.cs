using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Unity_PlayerPrefs_Viewer;

namespace Unity_PlayerPrefs_Viewer
{
    public partial class SelectionForm : Form
    {
        public readonly string discoveredSoftwareFilePath;

        public SelectionForm()
        {
            discoveredSoftwareFilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "DiscoveredSoftware.txt");
            InitializeComponent();
            try
            {
                DiscoveredSoftware.Items.AddRange(File.ReadAllLines(discoveredSoftwareFilePath, Encoding.UTF8));
            }
            catch (FileNotFoundException) { }
        }

        private void DiscoverButton_Click(object sender, EventArgs e)
        {
            DiscoveredSoftware.Items.Clear();

            if (CompanyName.Text == "")
                CompanyName.Text = "*";
            if (ProductName.Text == "")
                ProductName.Text = "*";

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                RegistryKey currentUser = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                RegistryKey software = currentUser.OpenSubKey("SOFTWARE");
                foreach (string companyKeyName in software.GetSubKeyNames())
                {
                    if (!companyKeyName.Like(CompanyName.Text))
                        continue;
                    RegistryKey companyKey = software.OpenSubKey(companyKeyName);
                    foreach (string productKeyName in companyKey.GetSubKeyNames())
                    {
                        if (!productKeyName.Like(ProductName.Text))
                            continue;
                        RegistryKey productKey = companyKey.OpenSubKey(productKeyName);
                        bool valid = false;
                        if (DisableCheck.Checked)
                            valid = true;
                        else
                        {
                            foreach (string valueName in productKey.GetValueNames())
                            {
                                if (valueName.StartsWith("UnitySelectMonitor_h"))
                                {
                                    valid = true;
                                    break;
                                }
                            }
                        }
                        if (valid)
                        {
                            DiscoveredSoftware.Items.Add(companyKeyName + "/" + productKeyName);
                        }
                    }
                }
            }

            File.WriteAllLines(discoveredSoftwareFilePath, DiscoveredSoftware.Items.Cast<string>(), Encoding.UTF8);
        }

        private void ClearDiscoveredSoftware_Click(object sender, EventArgs e)
        {
            DiscoveredSoftware.Items.Clear();
            File.WriteAllText(discoveredSoftwareFilePath, "");
        }

        private void OpenNewWindow(object sender, EventArgs e)
        {
            string destination = ((ListBox)sender).SelectedItem.ToString();
            Debug.WriteLine(destination);
            new ViewForm(destination).Show();
        }

        private void DiscoveredSoftware_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == char.ConvertFromUtf32(13)[0])
            {
                OpenNewWindow(sender, e);
            }
        }
    }
}
