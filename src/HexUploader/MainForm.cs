using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;

namespace HexUploader
{
    public partial class main : Form
    {
        static SerialPort _serialPort;
        public string[] AvailablePorts = SerialPort.GetPortNames();
        public string UploadMode = "bootloader";
        public main()
        {
            InitializeComponent();
            CheckPorts();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            CheckPorts();
        }

        void CheckPorts() //Function scans computer for available COM ports and puts them into the dropdown box for selection
        {
            var CurrentAvailablePorts = SerialPort.GetPortNames(); // put available ports into variable
            selectCom.DataSource = CurrentAvailablePorts; //insert into drop box
        }

        private string getActivePort(string mode)
        {
            if (mode == "bootloader")
            {
                if (selectCom.SelectedValue != null)
                {
                    return selectCom.SelectedValue.ToString();
                }
                else
                {
                    return "error";
                }
            }
            else if (mode == "manual")
            {
                return "reset";
            }
            else
            {
                MessageBox.Show("wrong mode");
                return "error";
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            groupBoxMode.Enabled = false;
            buttonUpload.Enabled = false;
            AvailablePorts = SerialPort.GetPortNames();
            if (UploadMode == "bootloader")
            {
                string ActivePort = getActivePort(UploadMode);
                launchBootloader(ActivePort);
            }
            string ProgPort = AutoDetectNewPort(AvailablePorts);
            if (ProgPort != "")
            {
                uploadHex(ProgPort, textBoxHexPath.Text);
                groupBoxMode.Enabled = true;
                buttonUpload.Enabled = true;
                return;
            }
            MessageBox.Show("No Device Detected");
            groupBoxMode.Enabled = true;
            buttonUpload.Enabled = true;
        }

        private string AutoDetectNewPort(string[] InitialPorts)
        {
            List<string> ProgramingPort = new List<string>();
            while (ProgramingPort.Count() == 0)
            {
                Thread.Sleep(50);
                string[] updatedPorts = SerialPort.GetPortNames();
                ProgramingPort = updatedPorts.Except(InitialPorts).ToList();
            }
            return ProgramingPort[0];
        }

        private string incrementComPort(string ComPort)
        {
            var match = Regex.Match(ComPort, @"^([^0-9]+)([0-9]+)$");
            var num = int.Parse(match.Groups[2].Value);
            return match.Groups[1].Value + (num + 1);
        }

        private void launchBootloader(string ComPort)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = ComPort;
            _serialPort.BaudRate = 1200;
            _serialPort.Open();
            Thread.Sleep(50);
            _serialPort.Close();
            Thread.Sleep(50);
        }

        private void uploadHex(string ComPort, string HexPath)
        {
            if (HexPath == "")
            {
                MessageBox.Show("No HEX file was selected");
                return;
            }
            string AvrDudePath = "bin\\Avrdude";
            //string AvrDudeBin = AvrDudePath + "\\avrdude.exe";
            //string AvrDudeParams = " -C " + AvrDudePath + "\\avrdude.conf -patmega32u4 -cavr109 -b57600 -D -U -PCOM" + ComPort + " flash:w:" + HexPath + ":i";
            string AvrDudeBin = AvrDudePath + "\\upload_code.bat";
            string AvrDudeParams = " " + ComPort + " " + HexPath;
            //MessageBox.Show(AvrDudeBin + AvrDudeParams);
            Process p = new Process();
            //p.StartInfo.UseShellExecute = true;
            //p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.FileName = AvrDudeBin;
            p.StartInfo.Arguments = AvrDudeParams;
            p.StartInfo.RedirectStandardError = false;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            //Debug.WriteLine(p.StandardOutput.ReadToEnd());
            p.WaitForExit(15000);
        }

        private void buttonBrowsHex_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "HEX Files|*.hex";
            openFileDialog1.Title = "Select a HEX File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .CUR file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxHexPath.Text = openFileDialog1.FileName;
                // Assign the cursor in the Stream to the Form's Cursor property.
            }
        }


        private void radioButtonModeSerial_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonModeSerial.Checked)
            {
                selectCom.Enabled = true;
                UploadMode = "bootloader";
            }
            else
            {
                selectCom.Enabled = false;
                UploadMode = "manual";
            }
        }
    }
}
