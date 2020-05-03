using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace MouseHandler
{
    public partial class InitialForm : Form
    {
        public List<string> UsbDevices { get; set; }
        


        public InitialForm()
        {
            InitializeComponent();

           
            //SystemUSBDrives systemUSBDrives = new System.Management.SystemUSBDrives();
            ////SystemUSBDrives systemUSBDrives = new SystemUSBDrives("[Computer Name]");

            //var USBDrivesEnum = systemUSBDrives.GetUSBDrivesInfo([UserName], [Password], [Domain]);

            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("select * from Win32_DiskDrive");

            ManagementObjectCollection items = searcher.Get();

            foreach (ManagementObject item in items)
            {
            }
        }

        private void DummyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
