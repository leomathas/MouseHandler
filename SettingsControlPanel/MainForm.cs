using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HidLibrary;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace SettingsControlPanel
{
    public partial class MainForm : Form
    {
        public List<HidDevice> HIDDevices = new List<HidDevice>();
        public HidDevice SelectedDevice = null;
        public RegistryKey FleepFlopRegistryKey = null;
        public MainForm()
        {
            InitializeComponent();
            

            Details.Text = "Initial Value";
            this.NaturalScrollingCheckBox.Checked = false;
            this.Text = "Natural scrolling helper";
            this.HIDDevices = HidDevices.Enumerate().ToList();

            DeviceSelector.DataSource = HIDDevices;
            DeviceSelector.DisplayMember = "Description";

        }

        private void DeviceSelector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedDevice = (HidDevice)DeviceSelector.SelectedItem;
            
            var myregex = new Regex("#(vid.*)#");
            var match = myregex.Match(SelectedDevice.DevicePath);
            var group = match.Groups.Values.LastOrDefault();

            if(group == null)
            {
                this.Details.Text = "Failed to match with registry key";
                return;
            }

            var HIDSection = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentCOntrolSet\Enum\HID");
            var paths = group.Value.ToUpper().Split('#').ToList();

            this.Details.Clear();
            this.Details.AppendText($"Product Id: {SelectedDevice.Attributes.ProductId}");
            this.Details.AppendText(Environment.NewLine);
            this.Details.AppendText($"Vendor Id: {SelectedDevice.Attributes.VendorId}");
            this.Details.AppendText(Environment.NewLine);
            this.Details.AppendText($"Product Hex Id: {SelectedDevice.Attributes.ProductHexId}");
            this.Details.AppendText(Environment.NewLine);
            this.Details.AppendText($"Vendor Hex Id: {SelectedDevice.Attributes.VendorHexId}");
            this.Details.AppendText(Environment.NewLine);
            this.Details.AppendText($"Device Path: {SelectedDevice.DevicePath}");
            this.Details.AppendText(Environment.NewLine);

            foreach(var path in paths)
            {
                HIDSection = HIDSection.OpenSubKey(path);
            }

            FleepFlopRegistryKey = HIDSection.OpenSubKey("Device Parameters", true);

            NaturalScrollingCheckBox.Enabled = (FleepFlopRegistryKey.GetValue("FlipFlopWheel") is null) ? false : true;
            NaturalScrollingCheckBox.Checked = (FleepFlopRegistryKey.GetValue("FlipFlopWheel") != null && (int)FleepFlopRegistryKey.GetValue("FlipFlopWheel") == 1) ? true : false;



        }

        private void SubmitButton_MouseClick(object sender, MouseEventArgs e)
        {
            if(FleepFlopRegistryKey != null)
                FleepFlopRegistryKey.SetValue("FlipFlopWheel", NaturalScrollingCheckBox.Checked ? 1 : 0);
        }

  
    }
}
