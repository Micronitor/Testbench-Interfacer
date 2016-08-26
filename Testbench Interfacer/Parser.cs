using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Globalization;


namespace Testbench_Interfacer
{
    public partial class Interfacer
    {

        int increment = 0;

        //public string LogKeyWord_text;
        public static Carrier[] Carriers = new Carrier[16];
        public static int InitializedCarriers = 0;
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        public int CurrentCarrier;

        //POSITION: ACTUAL AND TARGET TODO MAKE PART OF MotorControllerEPOS class
        public int currentPos = new int();
        public UInt16 target = new UInt16();

        private StreamWriter initializeLoggFile(string CarrierAddress, string CarrierSensorData)
        {
            FileStream fs;
            StreamWriter file;
            string startUpPath;
            string currentLogFileName;
            string logfolder;
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            //TODO Check if file and folders excists
            currentLogFileName = string.Format("{0:yyyy-MM-dd-HH-mm-ss}", DateTime.Now) + "Carrier@" + CarrierAddress + CarrierSensorData +".txt";// There are following custom format specifiers y (year), M (month), d (day), h (hour 12), H (hour 24), m (minute), s (second), f (second fraction), F (second fraction, trailing zeroes are trimmed), t (P.M or A.M) and z (time zone).
            startUpPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "log");
            logfolder = Path.Combine(startUpPath, currentLogFileName);
            fs = File.Create(logfolder);
            file = new StreamWriter(fs);
            return file;
        }


        private void parse(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            //if(serialData[0] == LogKeyWord.Text[0]) file.WriteLine(serialData);

            try {

            #region ParseSerialdata
            switch (serialData.Substring(0, 24))
            {
                case "Carrier I2C address     ":
                        //Start of Initializing Carrier
                        Carriers[InitializedCarriers] = new Carrier();
                    Carriers[InitializedCarriers].found = true;
                    Carriers[InitializedCarriers].Logg_Active = false;
                    Carriers[InitializedCarriers].Carrier_I2C_address = serialData.Substring(27);
                    break;

                case "Carrier serial number   ":
                    Carriers[InitializedCarriers].Carrier_serial_number = serialData.Substring(27);
                    Add_Carrier_List_Item(Carriers[InitializedCarriers].Carrier_serial_number + "@" + Carriers[InitializedCarriers].Carrier_I2C_address);


                    break;

                case "Sensor 1 name           ":
                    Carriers[InitializedCarriers].Sensor_1_name = serialData.Substring(27);
                    break;

                case "Sensor 2 name           ":
                    Carriers[InitializedCarriers].Sensor_2_name = serialData.Substring(27);
                    break;

                case "Sensor 1 active sensors ":
                    Carriers[InitializedCarriers].Sensor_1_active_sensors = serialData.Substring(27);
                    break;

                case "Sensor 1 installed bitma":
                    Carriers[InitializedCarriers].Sensor_1_installed_bitmap = serialData.Substring(27);
                    break;

                case "Sensor 1 enabled bitmap ":
                    Carriers[InitializedCarriers].Sensor_1_enabled_bitmap = serialData.Substring(27);
                    break;

                case "Sensor 1 faulty bitmap  ":
                    Carriers[InitializedCarriers].Sensor_1_faulty_bitmap = serialData.Substring(27);
                    break;

                case "Sensor 2 active sensors ":
                    Carriers[InitializedCarriers].Sensor_2_active_sensors = serialData.Substring(27);
                    break;

                case "Sensor 2 installed bitma":
                    Carriers[InitializedCarriers].Sensor_2_installed_bitmap = serialData.Substring(27);
                    break;

                case "Sensor 2 enabled bitmap ":
                    Carriers[InitializedCarriers].Sensor_2_enabled_bitmap = serialData.Substring(27);
                    break;

                case "Sensor 2 faulty bitmap  ":
                    Carriers[InitializedCarriers].Sensor_2_failty_bitmap = serialData.Substring(27);
                    break;

                case "Encoder offset          ":
                    Carriers[InitializedCarriers].Encoder_offset = serialData.Substring(27);
                    break;

                case "Sensor 1 Raw data format":
                    Carriers[InitializedCarriers].Sensor_1_Raw_data_format = serialData.Substring(27);
                    break;

                case "Sensor 2 Raw data format":
                    Carriers[InitializedCarriers].Sensor_2_Raw_data_format = serialData.Substring(27);

                    break;

                case "Sensor 1 Sample rate    ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Sample_rate = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Sample_rate = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 1 Scale factor X ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Scale_factor_X = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Scale_factor_X = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 1 Scale factor Y ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Scale_factor_Y = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Scale_factor_Y = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 1 Scale factor Z ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Scale_factor_Z = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Scale_factor_Z = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 1 SF Tempco X    ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_SF_Tempco_X = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_SF_Tempco_X = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 1 SF Tempco Y    ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_SF_Tempco_Y = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_SF_Tempco_Y = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 1 SF Tempco Z    ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_SF_Tempco_Z = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_SF_Tempco_Z = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 1 Offset X       ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_X = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_X = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 1 Offset Y       ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_Y = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_Y = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 1 Offset Z       ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_Z = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_Z = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 1 Offset Tempco X":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_Tempco_X = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_Tempco_X = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 1 Offset Tempco Y":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_Tempco_Y = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_Tempco_Y = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 1 Offset Tempco Z":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_Tempco_Z = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Offset_Tempco_Z = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 1 Misalign Alpha ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Misalign_Alpha = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Misalign_Alpha = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 1 Misalign Beta  ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Misalign_Beta = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Misalign_Beta = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 1 Misalign Gamma ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_1_Misalign_Gamma = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_1_Misalign_Gamma = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 2 Sample rate    ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Sample_rate = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Sample_rate = float.Parse(serialData.Substring(28));
                        }

                    break;

                case "Sensor 2 Scale factor X ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Scale_factor_X = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Scale_factor_X = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 2 Scale factor Y ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Scale_factor_Y = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Scale_factor_Y = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 2 Scale factor Z ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Scale_factor_Z = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Scale_factor_Z = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 2 SF Tempco X    ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_SF_Tempco_X = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_SF_Tempco_X = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 2 SF Tempco Y    ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_SF_Tempco_Y = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_SF_Tempco_Y = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 2 SF Tempco Z    ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_SF_Tempco_Z = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_SF_Tempco_Z = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 2 Offset X       ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_X = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_X = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 2 Offset Y       ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_Y = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_Y = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Sensor 2 Offset Z       ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_Z = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_Z = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 2 Offset Tempco X":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_Tempco_X = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_Tempco_X = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 2 Offset Tempco Y":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_Tempco_Y = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_Tempco_Y = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 2 Offset Tempco Z":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_Tempco_Z = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Offset_Tempco_Z = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 2 Misalign Alpha ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Misalign_Alpha = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Misalign_Alpha = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 2 Misalign Beta  ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Misalign_Beta = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Misalign_Beta = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Sensor 2 Misalign Gamma ":

                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Sensor_2_Misalign_Gamma = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Sensor_2_Misalign_Gamma = float.Parse(serialData.Substring(28));
                        }
                        
                    break;

                case "Temperature offset      ":
                    
                        if (serialData.Substring(27, 9).Equals("undefined"))
                        {
                            Carriers[InitializedCarriers].Temperature_offset = float.NaN;
                        }
                        else
                        {
                            Carriers[InitializedCarriers].Temperature_offset = float.Parse(serialData.Substring(28));
                        }

                        break;

                case "Temperature scale factor":

                        //DEBUGG BUDDY
                        //Invoke(new Action(() => Console.Text = "SERDATA:" + serialData.Substring(27,9)));
                        //Thread.Sleep(4000);

                        if (serialData.Substring(27,9).Equals("undefined"))
                            {
                            Carriers[InitializedCarriers].Temperature_scale_factor = float.NaN;
                            }
                        else
                            {                            
                            Carriers[InitializedCarriers].Temperature_scale_factor = float.Parse(serialData.Substring(28));
                            }
                    


                        //Increment when done Initializing Carrier
                        InitializedCarriers++;
                        break;
                     
                case "No such data or command ":
                    Invoke(new Action(() => sendMessage.Clear()));
                    break;

                case "No carrier at this I2C a":

                        //Invoke(new Action(() => Console.AppendText(serialData)));
                        //TODO delete carrier instances  that has disconnected
                        try
                        {
                            Carriers[InitializedCarriers] = new Carrier();
                            Carriers[InitializedCarriers].found = false;
                            Add_Carrier_List_Item("NONE@0x"+(20+InitializedCarriers));
                            //Increment when done Initializing Carrier
                            InitializedCarriers++;
                        }
                        catch
                        {

                        }

                        break;

                //case "Micronitor DNS prototype":
                        
                //        Thread.Sleep(2000);
                //        Invoke(new Action(() => bt_Reload_Carrier_List_Click(this,new EventArgs())));
                //        break;



                    default:

                    switch (serialData.Substring(0, 2))
                    {
                        case "20":
                            if (Carriers[0].Logg_Active)
                            {
                                Carriers[0].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                                    //TODO EXEPTIONS
                                }
                                break;

                        case "21":
                            if (Carriers[1].Logg_Active)
                            {
                                Carriers[1].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "22":
                            if (Carriers[2].Logg_Active)
                            {
                                    Carriers[2].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "23":
                            if (Carriers[3].Logg_Active)
                            {
                                    //TODO fix parsing of current position
                                    //string[] words = serialData.Split('\t');
                                    //Carriers[3].Current_Position = UInt16.Parse(words[37]);

                                    //Invoke(new Action(() => Console.Text = currentPos.ToString()));
                                    Carriers[3].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "24":
                            if (Carriers[4].Logg_Active)
                            {
                                Carriers[4].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "25":
                            if (Carriers[5].Logg_Active)
                            {
                                Carriers[5].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "26":
                            if (Carriers[6].Logg_Active)
                            {
                                Carriers[6].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "27":
                            if (Carriers[7].Logg_Active)
                            {
                                Carriers[7].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "28":
                            if (Carriers[8].Logg_Active)
                            {
                                Carriers[8].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "29":
                            if (Carriers[9].Logg_Active)
                            {
                                Carriers[9].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "30":
                            if (Carriers[10].Logg_Active)
                            {
                                Carriers[10].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "31":
                            if (Carriers[11].Logg_Active)
                            {
                                Carriers[11].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "32":
                            if (Carriers[12].Logg_Active)
                            {
                                Carriers[12].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "33":
                            if (Carriers[13].Logg_Active)
                            {
                                Carriers[13].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "34":
                            if (Carriers[14].Logg_Active)
                            {
                                Carriers[14].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;

                        case "35":
                            if (Carriers[15].Logg_Active)
                            {
                                Carriers[15].Logg_Target.WriteLine(string.Format("{0:HH:mm:ss:fff}", DateTime.Now) + " " + serialData);
                            }
                            break;


                        default:
                            Invoke(new Action(() => Console.AppendText(serialData)));
                            break;
                    }
                    break;
            }
            #endregion
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //TODO
            }
            catch (Exception ex)
            {
            Invoke(new Action(() => Console.Text = "Parsing failed with error: " + ex.Message + "\n when parsing: " + serialData));
            }
        }

        private void Add_Carrier_List_Item(string text)
        {
            if (this.CarrierList.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Add_Carrier_List_Item);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (!CarrierList.Items.Contains(text))
                {
                    CarrierList.Items.Add(text);
                }
            }
        }
    }



    public class Carrier
    {
        public string Carrier_I2C_address;
        public string Carrier_serial_number;
        public string Sensor_1_name;
        public string Sensor_2_name;
        public string Sensor_1_active_sensors;
        public string Sensor_1_installed_bitmap;
        public string Sensor_1_enabled_bitmap;
        public string Sensor_1_faulty_bitmap;
        public string Sensor_2_active_sensors;
        public string Sensor_2_installed_bitmap;
        public string Sensor_2_enabled_bitmap;
        public string Sensor_2_failty_bitmap;
        public string Encoder_offset;
        public string Sensor_1_Raw_data_format;
        public string Sensor_2_Raw_data_format;
        public float Sensor_1_Sample_rate;
        public float Sensor_1_Scale_factor_X;
        public float Sensor_1_Scale_factor_Y;
        public float Sensor_1_Scale_factor_Z;
        public float Sensor_1_SF_Tempco_X;
        public float Sensor_1_SF_Tempco_Y;
        public float Sensor_1_SF_Tempco_Z;
        public float Sensor_1_Offset_X;
        public float Sensor_1_Offset_Y;
        public float Sensor_1_Offset_Z;
        public float Sensor_1_Offset_Tempco_X;
        public float Sensor_1_Offset_Tempco_Y;
        public float Sensor_1_Offset_Tempco_Z;
        public float Sensor_1_Misalign_Alpha;
        public float Sensor_1_Misalign_Beta;
        public float Sensor_1_Misalign_Gamma;
        public float Sensor_2_Sample_rate;
        public float Sensor_2_Scale_factor_X;
        public float Sensor_2_Scale_factor_Y;
        public float Sensor_2_Scale_factor_Z;
        public float Sensor_2_SF_Tempco_X;
        public float Sensor_2_SF_Tempco_Y;
        public float Sensor_2_SF_Tempco_Z;
        public float Sensor_2_Offset_X;
        public float Sensor_2_Offset_Y;
        public float Sensor_2_Offset_Z;
        public float Sensor_2_Offset_Tempco_X;
        public float Sensor_2_Offset_Tempco_Y;
        public float Sensor_2_Offset_Tempco_Z;
        public float Sensor_2_Misalign_Alpha;
        public float Sensor_2_Misalign_Beta;
        public float Sensor_2_Misalign_Gamma;
        public float Temperature_offset;
        public float Temperature_scale_factor;
        //public float sensor_1_weight[16];
        //public float sensor_2_weight[16];

        public bool Logg_Active;
        public StreamWriter Logg_Target;
        public bool found;

        public int Current_Position;
    }
}
