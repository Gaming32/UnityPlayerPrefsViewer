﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Unity_PlayerPrefs_Viewer
{
    class Utilities
    {
        [DllImport("advapi32.dll")]
        static extern uint RegSetValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPStr)] string lpValueName,
            int Reserved,
            RegistryValueKind dwType,
            IntPtr lpData,
            int cbData);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern uint RegOpenKeyEx(
            IntPtr hKey,
            string subKey,
            int ulOptions,
            int samDesired,
            out UIntPtr hkResult);

        [DllImport("advapi32.dll")]
        public static extern int RegCloseKey(UIntPtr hKey);

        static public readonly IntPtr HKEY_CURRENT_USER = new IntPtr(-2147483647);

        public static int SetNamedValue(string path, string valName, double value)
        {
            UIntPtr hKey = UIntPtr.Zero;
            try
            {
                if (RegOpenKeyEx(HKEY_CURRENT_USER, path, 0, 0x20006, out hKey) != 0)
                    return 1;

                int size = 8;
                IntPtr pData = Marshal.AllocHGlobal(size);
                Marshal.WriteInt64(pData, BitConverter.DoubleToInt64Bits(value));
                if (RegSetValueEx(hKey, valName, 0, RegistryValueKind.DWord, pData, size) != 0)
                    return 2;
            }
            finally
            {
                if (hKey != UIntPtr.Zero)
                    RegCloseKey(hKey);
            }
            return 0;
        }
    }
}
