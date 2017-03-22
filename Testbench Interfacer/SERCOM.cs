using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Text.RegularExpressions;

namespace Testbench_Interfacer
{
    public partial class Interfacer
    {
        static SerialPort _serialPort;
        static bool _continue;

        private Object serialLock = new Object();
        private static Mutex serialMutex = new Mutex();
        string serialData = " ";
        //bool CanSend = true;
        
        public void SerialInitialize()
        {
            _serialPort = new SerialPort();
            _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None", true);
            _serialPort.DataBits = 8;
            _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One", true);
            _serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "None", true);
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.BaudRate = 230400; //455580 456.6
            _serialPort.PortName = " ";
            _serialPort.Close();
            foreach (string s in SerialPort.GetPortNames())
            {
                comList.Items.Add(s);
            }
            update_ComStatus(this, new EventArgs());
        }

        private void bt_serialConnect_Click(object sender, EventArgs e)
        {
            if (_serialPort.PortName.Equals(" "))
            {
                MessageBox.Show("Please select COM port");
                return;
            }
            Invoke(new Action(() => bt_serialConnect.Enabled = false));
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            if (!_continue)
            {
                try
                {
                    Console.Clear();
                    _serialPort.Open();
                    _continue = true;
                    ReceiveWorker.RunWorkerAsync();
                    bt_serialConnect.Text = "Disconnect";
                    //statusStrip1.Text = "Connected";
                    SendWorker.RunWorkerAsync();
                    bt_Reload_Carrier_List.Enabled = true;
                    comList.Enabled = false;
                    Baudrate.Enabled = false;
                    ComStatus.Enabled = false;
                }
                catch (Exception ex)
                {
                    if (ex is InvalidOperationException)
                    {
                        MessageBox.Show("BUSY!");
                    }
                    if (ex is System.IO.IOException)
                    {
                        MessageBox.Show("Invalid Connection Parameters.");
                    }
                    if (ex is System.UnauthorizedAccessException)
                    {
                        MessageBox.Show("Access to serial port denied.");
                    }
                    else
                    {
                        //TODO minor: IOExeption is thrown twice for some reason.
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                _continue = false;
                bt_serialConnect.Text = "Connect";
                bt_Reload_Carrier_List.Enabled = false;
                CarrierList.Enabled = false;
                Carrier_Parameters_Enabled(false);
                comList.Enabled = true;
                Baudrate.Enabled = true;
                ComStatus.Enabled = true;
                SERCOM_statusbar.Value = 0;
                //statusStrip1.Text = "Disconnected";
                //backgroundWorker1.CancelAsync();
            }
            Invoke(new Action(() => bt_serialConnect.Enabled = true));
        }
        private void serial_Read_Worker(object sender, DoWorkEventArgs e)
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    if (!SDCreadactive)
                    {
                        serialData = message.ToString();
                        //Invoke(new Action(() => Console.AppendText(serialData)));
                        //Thread.Sleep(1000);
                        try
                        {
                            parse(this, e);
                        }
                        catch
                        {
                            //TODO
                        }
                    }
                    else
                    {
                        file.WriteLine(message.ToString());
                        Invoke(new Action(() => Console.AppendText(message.ToString())));
                    }
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("ArgumentOutOfRangeException");
                    }
                    if (ex is TimeoutException)
                    {
                        //if (SDCreadactive)
                        //{
                        //    SDCreadactive = false;
                        //    fs.Close();
                        //    MessageBox.Show("Done reading SD card");
                        //}
                        //CanSend = true;
                        //MessageBox.Show("TimeoutException!");
                    }
                    
                    else
                    {
                        //throw;
                    }
                }
            }
            _serialPort.Close();
        }


        private void serial_Write(string text, bool remove_endings)
        {
            string txt;
            if (remove_endings)
            {
                txt = RemoveLineEndings(text);
            }
            else
            {
                txt = text;
            }
                try
                    {
                        //set_Console_Text(txt + Environment.NewLine);
                        _serialPort.WriteLine(txt);
                Invoke(new Action(() => Sent.AppendText(txt+ "\t")));
                //Give MCU time to respond
                //Thread.Sleep(10);
            }
                catch (Exception ex)
                    {
                        if (ex is InvalidOperationException)
                        {
                            MessageBox.Show("No active connection");
                        }
                        if (ex is ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("ArgumentOutOfRangeException");
                        }
                        //else
                        //{
                        //    throw;
                        //}
                    }
            
        }

        static string RemoveLineEndings(string text)
        {
            StringBuilder newText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsControl(text, i))
                    newText.Append(text[i]);
            }
            return newText.ToString();
        }

    }
}