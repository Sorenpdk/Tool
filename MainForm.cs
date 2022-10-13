using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Serial_Terminal
{
    public partial class MainForm : Form
    {   
        #region Properties
        UInt32 u32BaudRate { get; set; }
        String? strPort { get; set; }
        Byte u8Parity { get; set; }
        Byte u8StopBits { get; set; }

        UInt32 u32ConnectedTime_ms { get; set; }
        #endregion /* Properties */
        #region Fields 
        public SerialPort? PortInstance;
        readonly StringBuilder sb = new StringBuilder();
        private List<String> strSerialPortNames { get; set; }
        #endregion /* Fields */

        public MainForm()
        {
           InitializeComponent();
           strSerialPortNames = SerialPort.GetPortNames().ToList();
           cbCOMPorts.DataSource = strSerialPortNames;
           pictureBox1.Image = Properties.Resources.rsz_redled;
           cbBaudRate.SelectedIndex = 2;
           cbParity.SelectedIndex = 0;
           cbStopBits.SelectedIndex = 0;
           cbDatabits.SelectedIndex = 1;
        }
        #region Events
        private void btnConnect_Click(object sender, EventArgs e)
        { 
            try 
            {
                PortInstance = new SerialPort();
                PortInstance.BaudRate = (int) u32BaudRate;
                PortInstance.Parity = (Parity) u8Parity;
                PortInstance.StopBits = (StopBits) u8StopBits;
                PortInstance.PortName = strPort;              
                PortInstance.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                PortInstance.Open();

                if (PortInstance.IsOpen)
                {
                    lbConnectedStatus.Text = "Connected";
                    u32ConnectedTime_ms = 0;
                    timer1.Start();
                    pictureBox1.Image = Properties.Resources.rsz_greenled;
                }             
            }
            catch(Exception ex) 
            {
              Console.WriteLine(ex.Message);
            }
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    SerialPort sp = (SerialPort)sender;
                    String indata = sp.ReadExisting();

                    System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
                    Byte[] encodedBytes = utf8.GetBytes(indata);
                    Byte[] convertedBytes = Encoding.Convert(Encoding.UTF8, Encoding.ASCII, encodedBytes);
                    System.Text.Encoding ascii = System.Text.Encoding.ASCII;

                    sb.Append(ascii.GetString(convertedBytes));
                    lbBytesReceivedValue.Text = sb.Length.ToString();
                    richTextBox1.Text = sb.ToString();
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            PortInstance.Close();
            try
            {
                if (!PortInstance.IsOpen)
                {
                    timer1.Stop();
                    lbBytesReceivedValue.Text = "0";
                    lbConnectedTimeValue.Text = "0";
                    lbConnectedStatus.Text = "Disconnected";
                    pictureBox1.Image = Properties.Resources.rsz_redled;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        #region Combobox Selection Change
        private void cbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                int selectedIndex = this.cbBaudRate.SelectedIndex;
                u32BaudRate = Convert.ToUInt32(this.cbBaudRate.GetItemText(this.cbBaudRate.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void cbParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            u8Parity = Convert.ToByte(this.cbParity.SelectedIndex);
        }
        private void cbStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = this.cbStopBits.SelectedIndex;
            u8StopBits = Convert.ToByte(this.cbStopBits.GetItemText(this.cbStopBits.SelectedItem));
        }
        private void cbCOMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = this.cbCOMPorts.SelectedIndex;          
            strPort = this.cbCOMPorts.GetItemText(this.cbCOMPorts.SelectedItem);
        }
        #endregion /* Combobox Selection Change */

        #endregion /* Event */    

        private void cbCOMPorts_Click(object sender, EventArgs e)
        {
            strSerialPortNames = SerialPort.GetPortNames().ToList();
            cbCOMPorts.DataSource = strSerialPortNames;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sb.Clear();
            richTextBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            u32ConnectedTime_ms++;
            lbConnectedTimeValue.Text = (u32ConnectedTime_ms / 10).ToString();
        }
    }
}
