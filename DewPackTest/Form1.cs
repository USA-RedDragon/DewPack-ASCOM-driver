using System;
using System.Windows.Forms;

namespace ASCOM.DewPack
{
    public partial class Form1 : Form
    {

        private ASCOM.DriverAccess.Switch driver;

        public Form1()
        {
            InitializeComponent();
            SetUIState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConnected)
                driver.Connected = false;

            Properties.Settings.Default.Save();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DriverId = ASCOM.DriverAccess.Switch.Choose(Properties.Settings.Default.DriverId);
            SetUIState();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                driver.Connected = false;
            }
            else
            {
                driver = new DriverAccess.Switch(Properties.Settings.Default.DriverId)
                {
                    Connected = true
                };
            }
            SetUIState();
        }

        private void SetUIState()
        {
            buttonConnect.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";

            if (IsConnected)
            {
                buttonUsb0.Text = string.Format("{0}: {1}", driver.GetSwitchName(0), driver.GetSwitchValue(0) > 0);
                buttonUSB1.Text = string.Format("{0}: {1}", driver.GetSwitchName(1), driver.GetSwitchValue(1) > 0);

                trackBarUSB0.Value = (int)driver.GetSwitchValue(0);
                trackBarUSB1.Value = (int)driver.GetSwitchValue(1);
            }
        }

        private bool IsConnected
        {
            get
            {
                return ((this.driver != null) && (driver.Connected == true));
            }
        }

        private void buttonUsb0_Click(object sender, EventArgs e)
        {
            driver.SetSwitch(0, !driver.GetSwitch(0));
            SetUIState();
        }

        private void buttonUSB1_Click(object sender, EventArgs e)
        {
            driver.SetSwitch(1, !driver.GetSwitch(1));
            SetUIState();
        }

        private void trackBarUSB0_Scroll(object sender, EventArgs e)
        {
            driver.SetSwitchValue(0, trackBarUSB0.Value);
        }

        private void trackBarUSB1_Scroll(object sender, EventArgs e)
        {
            driver.SetSwitchValue(1, trackBarUSB1.Value);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SetUIState();
        }
    }
}
