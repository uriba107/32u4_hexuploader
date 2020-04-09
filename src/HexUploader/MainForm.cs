using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;
using ArduinoUploader;
using ArduinoUploader.Hardware;
using System.Runtime.InteropServices;

namespace HexUploader
{
    public partial class main : Form
    {
        static SerialPort _serialPort;

        public string[] AvailablePorts = SerialPort.GetPortNames();
        public string UploadMode = "bootloader";

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern uint GetShortPathName(string lpszLongPath, StringBuilder lpszShortPath, uint cchBuffer);

        private static string GetShortPath(string longPath)
        {
            StringBuilder shortPath = new StringBuilder(255);
            GetShortPathName(longPath, shortPath, 255);
            return shortPath.ToString();
        }

        public main()
        {
            InitializeComponent();
            CheckPorts();
        }

        private void selectCom_DropDown(object sender, EventArgs e)
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
            setButtonEnable(false);

            var HexPath = @textBoxHexPath.Text;
            var triggerBootloader = (UploadMode == "bootloader")?true:false;
            //HexPath = GetShortPath(HexPath);
            if (HexPath == "" || !File.Exists(HexPath))
            {
                UploadError("No HEX file was selected");
                return;
            }
            AvailablePorts = SerialPort.GetPortNames();

            string ProgPort = (triggerBootloader)? getActivePort(UploadMode): AutoDetectNewPort(AvailablePorts);
 
            if (ProgPort != "")
            {
                uploadHex(ProgPort, HexPath, triggerBootloader);

                setButtonEnable(true);

                return;
            }
            UploadError("No Device Detected");
        }

        private void setButtonEnable(bool state)
        {
            groupBoxMode.Enabled = state;
            buttonUpload.Enabled = state;
        }
        private void setButtonEnable()
        {
            groupBoxMode.Enabled = true;
            buttonUpload.Enabled = true;
        }

        private void UploadError(string msg)
        {
            MessageBox.Show(msg);
            setButtonEnable(true);
        }

        private string AutoDetectNewPort(string[] InitialPorts)
        {
            List<string> ProgramingPort = new List<string>();
            var Timeout = DateTimeOffset.UtcNow.Add(TimeSpan.FromSeconds(15));
            while ((ProgramingPort.Count() == 0) && (DateTimeOffset.UtcNow < Timeout))
            {
                Thread.Sleep(50);
                string[] updatedPorts = SerialPort.GetPortNames();
                ProgramingPort = updatedPorts.Except(InitialPorts).ToList();
            }
            if (ProgramingPort.Any())
                return ProgramingPort[0];
            return "";
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
            try
            {
                _serialPort.Open();
                Thread.Sleep(50);
                _serialPort.Close();
                Thread.Sleep(50);
            }
            catch
            {
                return;
            }

        }

        private void uploadHexAvrdude(string ComPort, string HexPath)
        {
            if (HexPath == "")
            {
                MessageBox.Show("No HEX file was selected");
                return;
            }
            string AvrDudePath = @"Avrdude";
            string AvrDudeBin = AvrDudePath + @"\avrdude.exe";
            string AvrDudeParams = "-v -patmega32u4 -cavr109  -P" + ComPort + " -b57600 -D -Uflash:w:\'" + HexPath + "\':i -C " + @AvrDudePath + "\\avrdude.conf";

            Console.WriteLine(AvrDudeBin);
            ProcessStartInfo avrdude = new ProcessStartInfo();
            Process p = new Process();

            avrdude.FileName = AvrDudeBin;
            avrdude.Arguments = AvrDudeParams;
            avrdude.RedirectStandardError = false;
            avrdude.RedirectStandardOutput = false;
            avrdude.UseShellExecute = false;

            p.StartInfo = avrdude;
            p.Start();
            if (p != null && !p.HasExited)
                p.WaitForExit(15000);
        }

        private void uploadHex(string ComPort, string HexPath, bool triggerBootloader)
        {

            if (HexPath == "")
            {
                MessageBox.Show("No HEX file was selected");
                return;
            }

            var options = new ArduinoSketchUploaderOptions()
            {
                FileName = @HexPath,
                PortName = ComPort,
                ArduinoModel = ArduinoModel.Micro,
                TriggerBootloader = triggerBootloader
            };
            //var progress = new Progress<double>(ReportProgress);

            var uploader = new ArduinoSketchUploader(
                options, progress: new Progress<double>(ReportProgress));

            var t = new Thread(uploader.UploadSketch);

            t.Start();

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

        private void textBoxHexPath_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropped_file = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (dropped_file != null && dropped_file.Length != 0 && dropped_file[0].EndsWith(".hex"))
            {
                textBoxHexPath.Text = dropped_file[0];
            }
        }

        private void textBoxHexPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        void ReportProgress(double value)
        {
            //Update the UI to reflect the progress value that is passed back.
            //Debug.WriteLine((int)(value*100));
            UploadProgressBar.Value = (int)(value*100)+1;
        }
    }
}
