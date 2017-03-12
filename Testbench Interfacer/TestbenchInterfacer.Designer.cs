namespace Testbench_Interfacer
{
    partial class Interfacer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfacer));
            this.bt_serialConnect = new System.Windows.Forms.Button();
            this.Baudrate = new System.Windows.Forms.TextBox();
            this.sendMessage = new System.Windows.Forms.TextBox();
            this.ComStatus = new System.Windows.Forms.RichTextBox();
            this.ReceiveWorker = new System.ComponentModel.BackgroundWorker();
            this.comList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Baudrate = new System.Windows.Forms.Label();
            this.bt_send = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CarrierList = new System.Windows.Forms.ListBox();
            this.bt_Reload_Carrier_List = new System.Windows.Forms.Button();
            this.bt_Set_Carrier = new System.Windows.Forms.Button();
            this.SendWorker = new System.ComponentModel.BackgroundWorker();
            this.Carrier_serial_number = new System.Windows.Forms.TextBox();
            this.Sensor_A_name = new System.Windows.Forms.TextBox();
            this.Sensor_B_name = new System.Windows.Forms.TextBox();
            this.Sensor_A_active_sensors = new System.Windows.Forms.TextBox();
            this.Sensor_A_installed_bitmap = new System.Windows.Forms.TextBox();
            this.Sensor_A_enabled_bitmap = new System.Windows.Forms.TextBox();
            this.Sensor_A_faulty_bitmap = new System.Windows.Forms.TextBox();
            this.Sensor_B_active_sensors = new System.Windows.Forms.TextBox();
            this.Sensor_B_installed_bitmap = new System.Windows.Forms.TextBox();
            this.Sensor_B_enabled_bitmap = new System.Windows.Forms.TextBox();
            this.Sensor_B_failty_bitmap = new System.Windows.Forms.TextBox();
            this.Encoder_offset = new System.Windows.Forms.TextBox();
            this.Sensor_A_Raw_data_format = new System.Windows.Forms.TextBox();
            this.Sensor_B_Raw_data_format = new System.Windows.Forms.TextBox();
            this.Sensor_A_Sample_rate = new System.Windows.Forms.TextBox();
            this.Sensor_A_Scale_factor_X = new System.Windows.Forms.TextBox();
            this.Sensor_A_Scale_factor_Y = new System.Windows.Forms.TextBox();
            this.Sensor_A_Scale_factor_Z = new System.Windows.Forms.TextBox();
            this.Sensor_A_SF_Tempco_X = new System.Windows.Forms.TextBox();
            this.Sensor_A_SF_Tempco_Y = new System.Windows.Forms.TextBox();
            this.Sensor_A_SF_Tempco_Z = new System.Windows.Forms.TextBox();
            this.Sensor_A_Offset_X = new System.Windows.Forms.TextBox();
            this.Sensor_A_Offset_Y = new System.Windows.Forms.TextBox();
            this.Sensor_A_Offset_Z = new System.Windows.Forms.TextBox();
            this.Sensor_A_Offset_Tempco_X = new System.Windows.Forms.TextBox();
            this.Sensor_A_Offset_Tempco_Y = new System.Windows.Forms.TextBox();
            this.Sensor_A_Offset_Tempco_Z = new System.Windows.Forms.TextBox();
            this.Sensor_A_Misalign_Alpha = new System.Windows.Forms.TextBox();
            this.Sensor_A_Misalign_Beta = new System.Windows.Forms.TextBox();
            this.Sensor_A_Misalign_Gamma = new System.Windows.Forms.TextBox();
            this.Sensor_B_Sample_rate = new System.Windows.Forms.TextBox();
            this.Sensor_B_Scale_factor_X = new System.Windows.Forms.TextBox();
            this.Sensor_B_Scale_factor_Y = new System.Windows.Forms.TextBox();
            this.Sensor_B_Scale_factor_Z = new System.Windows.Forms.TextBox();
            this.Sensor_B_SF_Tempco_X = new System.Windows.Forms.TextBox();
            this.Sensor_B_SF_Tempco_Y = new System.Windows.Forms.TextBox();
            this.Sensor_B_SF_Tempco_Z = new System.Windows.Forms.TextBox();
            this.Sensor_B_Offset_X = new System.Windows.Forms.TextBox();
            this.Sensor_B_Offset_Y = new System.Windows.Forms.TextBox();
            this.Sensor_B_Offset_Z = new System.Windows.Forms.TextBox();
            this.Sensor_B_Offset_Tempco_X = new System.Windows.Forms.TextBox();
            this.Sensor_B_Offset_Tempco_Y = new System.Windows.Forms.TextBox();
            this.Sensor_B_Offset_Tempco_Z = new System.Windows.Forms.TextBox();
            this.Sensor_B_Misalign_Alpha = new System.Windows.Forms.TextBox();
            this.Sensor_B_Misalign_Beta = new System.Windows.Forms.TextBox();
            this.Sensor_B_Misalign_Gamma = new System.Windows.Forms.TextBox();
            this.Temperature_offset = new System.Windows.Forms.TextBox();
            this.Temperature_scale_factor = new System.Windows.Forms.TextBox();
            this.label_Carrier_serial_number = new System.Windows.Forms.Label();
            this.label_Sensor_A_name = new System.Windows.Forms.Label();
            this.label_Sensor_B_name = new System.Windows.Forms.Label();
            this.label_Sensor_A_active_sensors = new System.Windows.Forms.Label();
            this.label_Sensor_A_installed_bitmap = new System.Windows.Forms.Label();
            this.label_Sensor_A_enabled_bitmap = new System.Windows.Forms.Label();
            this.label_Sensor_A_faulty_bitmap = new System.Windows.Forms.Label();
            this.label_Sensor_B_active_sensors = new System.Windows.Forms.Label();
            this.label_Sensor_B_installed_bitmap = new System.Windows.Forms.Label();
            this.label_Sensor_B_enabled_bitmap = new System.Windows.Forms.Label();
            this.label_Sensor_B_failty_bitmap = new System.Windows.Forms.Label();
            this.label_Encoder_offset = new System.Windows.Forms.Label();
            this.label_Sensor_A_Raw_data_format = new System.Windows.Forms.Label();
            this.label_Sensor_B_Raw_data_format = new System.Windows.Forms.Label();
            this.label_Sensor_A_Sample_rate = new System.Windows.Forms.Label();
            this.label_Sensor_A_Scale_factor_X = new System.Windows.Forms.Label();
            this.label_Sensor_A_Scale_factor_Y = new System.Windows.Forms.Label();
            this.label_Sensor_A_Scale_factor_Z = new System.Windows.Forms.Label();
            this.label_Sensor_A_SF_Tempco_X = new System.Windows.Forms.Label();
            this.label_Sensor_A_SF_Tempco_Y = new System.Windows.Forms.Label();
            this.label_Sensor_A_SF_Tempco_Z = new System.Windows.Forms.Label();
            this.label_Sensor_A_Offset_X = new System.Windows.Forms.Label();
            this.label_Sensor_A_Offset_Y = new System.Windows.Forms.Label();
            this.label_Sensor_A_Offset_Z = new System.Windows.Forms.Label();
            this.label_Sensor_A_Offset_Tempco_X = new System.Windows.Forms.Label();
            this.label_Sensor_A_Offset_Tempco_Y = new System.Windows.Forms.Label();
            this.label_Sensor_A_Offset_Tempco_Z = new System.Windows.Forms.Label();
            this.label_Sensor_A_Misalign_Alpha = new System.Windows.Forms.Label();
            this.label_Sensor_A_Misalign_Beta = new System.Windows.Forms.Label();
            this.label_Sensor_A_Misalign_Gamma = new System.Windows.Forms.Label();
            this.label_Sensor_B_Sample_rate = new System.Windows.Forms.Label();
            this.label_Sensor_B_Scale_factor_X = new System.Windows.Forms.Label();
            this.label_Sensor_B_Scale_factor_Y = new System.Windows.Forms.Label();
            this.label_Sensor_B_Scale_factor_Z = new System.Windows.Forms.Label();
            this.label_Sensor_B_SF_Tempco_X = new System.Windows.Forms.Label();
            this.label_Sensor_B_SF_Tempco_Y = new System.Windows.Forms.Label();
            this.label_Sensor_B_SF_Tempco_Z = new System.Windows.Forms.Label();
            this.label_Sensor_B_Offset_X = new System.Windows.Forms.Label();
            this.label_Sensor_B_Offset_Y = new System.Windows.Forms.Label();
            this.label_Sensor_B_Offset_Z = new System.Windows.Forms.Label();
            this.label_Sensor_B_Offset_Tempco_X = new System.Windows.Forms.Label();
            this.label_Sensor_B_Offset_Tempco_Y = new System.Windows.Forms.Label();
            this.label_Sensor_B_Offset_Tempco_Z = new System.Windows.Forms.Label();
            this.label_Sensor_B_Misalign_Alpha = new System.Windows.Forms.Label();
            this.label_Sensor_B_Misalign_Beta = new System.Windows.Forms.Label();
            this.label_Sensor_B_Misalign_Gamma = new System.Windows.Forms.Label();
            this.label_Temperature_offset = new System.Windows.Forms.Label();
            this.SERCOM_statusbar = new System.Windows.Forms.ProgressBar();
            this.Sent = new System.Windows.Forms.TextBox();
            this.LoggProgress = new System.Windows.Forms.ProgressBar();
            this.bt_Start_Logging = new System.Windows.Forms.Button();
            this.LoggWorker = new System.ComponentModel.BackgroundWorker();
            this.bt_Cancel_Logging = new System.Windows.Forms.Button();
            this.lb_Motor_Controller1 = new System.Windows.Forms.Label();
            this.Motor1_Velocity = new System.Windows.Forms.TextBox();
            this.Motor1_Acceleration = new System.Windows.Forms.TextBox();
            this.bt_Motor1_Save_Setting = new System.Windows.Forms.Button();
            this.Logging_Period = new System.Windows.Forms.TextBox();
            this.Toggle_Delay = new System.Windows.Forms.TextBox();
            this.lb_Logging_Period = new System.Windows.Forms.Label();
            this.lb_Toggle_Delay = new System.Windows.Forms.Label();
            this.lb_Motor1_Velocity = new System.Windows.Forms.Label();
            this.lb_Motor1_Acceleration = new System.Windows.Forms.Label();
            this.Motor1_Status = new System.Windows.Forms.TextBox();
            this.cb_Logg_Enabled = new System.Windows.Forms.CheckBox();
            this.cb_Motor1_Enabled = new System.Windows.Forms.CheckBox();
            this.cb_Motor2_Enabled = new System.Windows.Forms.CheckBox();
            this.Motor2_Status = new System.Windows.Forms.TextBox();
            this.lb_Motor2_Acceleration = new System.Windows.Forms.Label();
            this.lb_Motor2_Velocity = new System.Windows.Forms.Label();
            this.bt_Motor2_Save_Setting = new System.Windows.Forms.Button();
            this.lb_Motor_Controller2 = new System.Windows.Forms.Label();
            this.bt_Motor2_Setup = new System.Windows.Forms.Button();
            this.cb_Motor3_Enabled = new System.Windows.Forms.CheckBox();
            this.Motor3_Status = new System.Windows.Forms.TextBox();
            this.lb_Motor3_Acceleration = new System.Windows.Forms.Label();
            this.lb_Motor3_Velocity = new System.Windows.Forms.Label();
            this.bt_Motor3_Save_Setting = new System.Windows.Forms.Button();
            this.Motor3_Acceleration = new System.Windows.Forms.TextBox();
            this.Motor3_Velocity = new System.Windows.Forms.TextBox();
            this.lb_Motor_Controller3 = new System.Windows.Forms.Label();
            this.bt_Motor3_Setup = new System.Windows.Forms.Button();
            this.lb_Motor1_distance = new System.Windows.Forms.Label();
            this.lb_Motor2_distance = new System.Windows.Forms.Label();
            this.lb_Motor3_distance = new System.Windows.Forms.Label();
            this.Motor1_Distance = new System.Windows.Forms.TextBox();
            this.Motor3_Distance = new System.Windows.Forms.TextBox();
            this.Motor1_Deacceleration = new System.Windows.Forms.TextBox();
            this.lb_Motor1_Deacceleration = new System.Windows.Forms.Label();
            this.lb_Motor2_Deacceleration = new System.Windows.Forms.Label();
            this.lb_Motor3_Deacceleration = new System.Windows.Forms.Label();
            this.Motor3_Deacceleration = new System.Windows.Forms.TextBox();
            this.bt_Motor1_Set_Zero = new System.Windows.Forms.Button();
            this.Motor1_Position = new System.Windows.Forms.TextBox();
            this.MotorStatusWorker = new System.ComponentModel.BackgroundWorker();
            this.bt_Motor1_Read_Position = new System.Windows.Forms.Button();
            this.lb_Motor1_Position = new System.Windows.Forms.Label();
            this.label_Temperature_scale_factor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Motor2_Read_Position = new System.Windows.Forms.Button();
            this.bt_Motor2_Set_Zero = new System.Windows.Forms.Button();
            this.lb_Motor2_Position = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Motor2_Distancereal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Motor2_Deaccelerationreal = new System.Windows.Forms.TextBox();
            this.Motor2_Positionreal = new System.Windows.Forms.TextBox();
            this.Motor2_Accelerationreal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Motor2_Velocityreal = new System.Windows.Forms.TextBox();
            this.bt_Motor3_Read_Position = new System.Windows.Forms.Button();
            this.bt_Motor3_Set_Zero = new System.Windows.Forms.Button();
            this.lb_Motor3_Position = new System.Windows.Forms.Label();
            this.Motor3_Position = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_Micronitor = new System.Windows.Forms.Label();
            this.cb_Toggle_in_on_direction = new System.Windows.Forms.CheckBox();
            this.bt_Motor1_Setup = new System.Windows.Forms.Button();
            this.cb_Textguide = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_serialConnect
            // 
            this.bt_serialConnect.BackColor = System.Drawing.SystemColors.Control;
            this.bt_serialConnect.Enabled = false;
            this.bt_serialConnect.Location = new System.Drawing.Point(93, 144);
            this.bt_serialConnect.Name = "bt_serialConnect";
            this.bt_serialConnect.Size = new System.Drawing.Size(163, 23);
            this.bt_serialConnect.TabIndex = 0;
            this.bt_serialConnect.Text = "Connect";
            this.bt_serialConnect.UseVisualStyleBackColor = false;
            this.bt_serialConnect.Click += new System.EventHandler(this.bt_serialConnect_Click);
            // 
            // Baudrate
            // 
            this.Baudrate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Baudrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Baudrate.Location = new System.Drawing.Point(12, 144);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(75, 20);
            this.Baudrate.TabIndex = 1;
            this.Baudrate.Text = "230400";
            this.Baudrate.TextChanged += new System.EventHandler(this.Baudrate_TextChanged);
            // 
            // sendMessage
            // 
            this.sendMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sendMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendMessage.Enabled = false;
            this.sendMessage.Location = new System.Drawing.Point(12, 645);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(448, 20);
            this.sendMessage.TabIndex = 2;
            this.sendMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendMessage_KeyDown);
            // 
            // ComStatus
            // 
            this.ComStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ComStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ComStatus.Location = new System.Drawing.Point(93, 26);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.ReadOnly = true;
            this.ComStatus.Size = new System.Drawing.Size(163, 93);
            this.ComStatus.TabIndex = 11;
            this.ComStatus.Text = "";
            this.ComStatus.TextChanged += new System.EventHandler(this.ComStatus_TextChanged);
            // 
            // ReceiveWorker
            // 
            this.ReceiveWorker.WorkerSupportsCancellation = true;
            this.ReceiveWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.serial_Read_Worker);
            // 
            // comList
            // 
            this.comList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comList.FormattingEnabled = true;
            this.comList.Location = new System.Drawing.Point(12, 26);
            this.comList.Name = "comList";
            this.comList.Size = new System.Drawing.Size(75, 93);
            this.comList.TabIndex = 12;
            this.comList.SelectedIndexChanged += new System.EventHandler(this.comList_SelectChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lb_Baudrate
            // 
            this.lb_Baudrate.AutoSize = true;
            this.lb_Baudrate.Location = new System.Drawing.Point(12, 125);
            this.lb_Baudrate.Name = "lb_Baudrate";
            this.lb_Baudrate.Size = new System.Drawing.Size(50, 13);
            this.lb_Baudrate.TabIndex = 13;
            this.lb_Baudrate.Text = "Baudrate";
            // 
            // bt_send
            // 
            this.bt_send.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_send.Enabled = false;
            this.bt_send.Location = new System.Drawing.Point(469, 644);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 23);
            this.bt_send.TabIndex = 14;
            this.bt_send.Text = "Send";
            this.bt_send.UseVisualStyleBackColor = false;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Console.Location = new System.Drawing.Point(12, 173);
            this.Console.MaxLength = 2000000;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(529, 466);
            this.Console.TabIndex = 15;
            this.Console.Text = "";
            this.Console.TextChanged += new System.EventHandler(this.Console_TextChanged);
            // 
            // CarrierList
            // 
            this.CarrierList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CarrierList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarrierList.CausesValidation = false;
            this.CarrierList.Cursor = System.Windows.Forms.Cursors.Default;
            this.CarrierList.FormattingEnabled = true;
            this.CarrierList.Location = new System.Drawing.Point(262, 26);
            this.CarrierList.Name = "CarrierList";
            this.CarrierList.Size = new System.Drawing.Size(279, 93);
            this.CarrierList.TabIndex = 17;
            this.CarrierList.SelectedIndexChanged += new System.EventHandler(this.CarrierList_SelectedIndexChanged);
            // 
            // bt_Reload_Carrier_List
            // 
            this.bt_Reload_Carrier_List.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Reload_Carrier_List.Enabled = false;
            this.bt_Reload_Carrier_List.Location = new System.Drawing.Point(262, 145);
            this.bt_Reload_Carrier_List.Name = "bt_Reload_Carrier_List";
            this.bt_Reload_Carrier_List.Size = new System.Drawing.Size(279, 22);
            this.bt_Reload_Carrier_List.TabIndex = 3;
            this.bt_Reload_Carrier_List.Text = "Reload Carrier List";
            this.bt_Reload_Carrier_List.UseVisualStyleBackColor = false;
            this.bt_Reload_Carrier_List.Click += new System.EventHandler(this.bt_Reload_Carrier_List_Click_1);
            // 
            // bt_Set_Carrier
            // 
            this.bt_Set_Carrier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Set_Carrier.Enabled = false;
            this.bt_Set_Carrier.Location = new System.Drawing.Point(557, 671);
            this.bt_Set_Carrier.Name = "bt_Set_Carrier";
            this.bt_Set_Carrier.Size = new System.Drawing.Size(431, 23);
            this.bt_Set_Carrier.TabIndex = 1;
            this.bt_Set_Carrier.Text = "Set Carrier";
            this.bt_Set_Carrier.UseVisualStyleBackColor = false;
            this.bt_Set_Carrier.Click += new System.EventHandler(this.bt_Set_Carrier_Click);
            // 
            // SendWorker
            // 
            this.SendWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Find_Carriers);
            // 
            // Carrier_serial_number
            // 
            this.Carrier_serial_number.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Carrier_serial_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Carrier_serial_number.Enabled = false;
            this.Carrier_serial_number.Location = new System.Drawing.Point(558, 45);
            this.Carrier_serial_number.Name = "Carrier_serial_number";
            this.Carrier_serial_number.Size = new System.Drawing.Size(130, 20);
            this.Carrier_serial_number.TabIndex = 27;
            this.Carrier_serial_number.TextChanged += new System.EventHandler(this.Carrier_serial_number_TextChanged);
            // 
            // Sensor_A_name
            // 
            this.Sensor_A_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_name.Enabled = false;
            this.Sensor_A_name.Location = new System.Drawing.Point(558, 85);
            this.Sensor_A_name.Name = "Sensor_A_name";
            this.Sensor_A_name.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_name.TabIndex = 27;
            this.Sensor_A_name.TextChanged += new System.EventHandler(this.Sensor_A_name_TextChanged);
            // 
            // Sensor_B_name
            // 
            this.Sensor_B_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_name.Enabled = false;
            this.Sensor_B_name.Location = new System.Drawing.Point(558, 125);
            this.Sensor_B_name.Name = "Sensor_B_name";
            this.Sensor_B_name.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_name.TabIndex = 27;
            this.Sensor_B_name.TextChanged += new System.EventHandler(this.Sensor_B_name_TextChanged);
            // 
            // Sensor_A_active_sensors
            // 
            this.Sensor_A_active_sensors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_active_sensors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_active_sensors.Enabled = false;
            this.Sensor_A_active_sensors.Location = new System.Drawing.Point(558, 165);
            this.Sensor_A_active_sensors.Name = "Sensor_A_active_sensors";
            this.Sensor_A_active_sensors.ReadOnly = true;
            this.Sensor_A_active_sensors.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_active_sensors.TabIndex = 27;
            this.Sensor_A_active_sensors.TextChanged += new System.EventHandler(this.Sensor_A_active_sensors_TextChanged);
            // 
            // Sensor_A_installed_bitmap
            // 
            this.Sensor_A_installed_bitmap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_installed_bitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_installed_bitmap.Enabled = false;
            this.Sensor_A_installed_bitmap.Location = new System.Drawing.Point(558, 205);
            this.Sensor_A_installed_bitmap.Name = "Sensor_A_installed_bitmap";
            this.Sensor_A_installed_bitmap.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_installed_bitmap.TabIndex = 27;
            this.Sensor_A_installed_bitmap.TextChanged += new System.EventHandler(this.Sensor_A_installed_bitmap_TextChanged);
            // 
            // Sensor_A_enabled_bitmap
            // 
            this.Sensor_A_enabled_bitmap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_enabled_bitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_enabled_bitmap.Enabled = false;
            this.Sensor_A_enabled_bitmap.Location = new System.Drawing.Point(558, 245);
            this.Sensor_A_enabled_bitmap.Name = "Sensor_A_enabled_bitmap";
            this.Sensor_A_enabled_bitmap.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_enabled_bitmap.TabIndex = 27;
            this.Sensor_A_enabled_bitmap.TextChanged += new System.EventHandler(this.Sensor_A_enabled_bitmap_TextChanged);
            // 
            // Sensor_A_faulty_bitmap
            // 
            this.Sensor_A_faulty_bitmap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_faulty_bitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_faulty_bitmap.Enabled = false;
            this.Sensor_A_faulty_bitmap.Location = new System.Drawing.Point(558, 285);
            this.Sensor_A_faulty_bitmap.Name = "Sensor_A_faulty_bitmap";
            this.Sensor_A_faulty_bitmap.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_faulty_bitmap.TabIndex = 27;
            this.Sensor_A_faulty_bitmap.TextChanged += new System.EventHandler(this.Sensor_A_faulty_bitmap_TextChanged);
            // 
            // Sensor_B_active_sensors
            // 
            this.Sensor_B_active_sensors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_active_sensors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_active_sensors.Enabled = false;
            this.Sensor_B_active_sensors.Location = new System.Drawing.Point(558, 325);
            this.Sensor_B_active_sensors.Name = "Sensor_B_active_sensors";
            this.Sensor_B_active_sensors.ReadOnly = true;
            this.Sensor_B_active_sensors.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_active_sensors.TabIndex = 27;
            this.Sensor_B_active_sensors.TextChanged += new System.EventHandler(this.Sensor_B_active_sensors_TextChanged);
            // 
            // Sensor_B_installed_bitmap
            // 
            this.Sensor_B_installed_bitmap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_installed_bitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_installed_bitmap.Enabled = false;
            this.Sensor_B_installed_bitmap.Location = new System.Drawing.Point(558, 365);
            this.Sensor_B_installed_bitmap.Name = "Sensor_B_installed_bitmap";
            this.Sensor_B_installed_bitmap.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_installed_bitmap.TabIndex = 27;
            this.Sensor_B_installed_bitmap.TextChanged += new System.EventHandler(this.Sensor_B_installed_bitmap_TextChanged);
            // 
            // Sensor_B_enabled_bitmap
            // 
            this.Sensor_B_enabled_bitmap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_enabled_bitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_enabled_bitmap.Enabled = false;
            this.Sensor_B_enabled_bitmap.Location = new System.Drawing.Point(558, 405);
            this.Sensor_B_enabled_bitmap.Name = "Sensor_B_enabled_bitmap";
            this.Sensor_B_enabled_bitmap.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_enabled_bitmap.TabIndex = 27;
            this.Sensor_B_enabled_bitmap.TextChanged += new System.EventHandler(this.Sensor_B_enabled_bitmap_TextChanged);
            // 
            // Sensor_B_failty_bitmap
            // 
            this.Sensor_B_failty_bitmap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_failty_bitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_failty_bitmap.Enabled = false;
            this.Sensor_B_failty_bitmap.Location = new System.Drawing.Point(558, 445);
            this.Sensor_B_failty_bitmap.Name = "Sensor_B_failty_bitmap";
            this.Sensor_B_failty_bitmap.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_failty_bitmap.TabIndex = 27;
            this.Sensor_B_failty_bitmap.TextChanged += new System.EventHandler(this.Sensor_B_failty_bitmap_TextChanged);
            // 
            // Encoder_offset
            // 
            this.Encoder_offset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Encoder_offset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Encoder_offset.Enabled = false;
            this.Encoder_offset.Location = new System.Drawing.Point(558, 485);
            this.Encoder_offset.Name = "Encoder_offset";
            this.Encoder_offset.Size = new System.Drawing.Size(130, 20);
            this.Encoder_offset.TabIndex = 27;
            this.Encoder_offset.TextChanged += new System.EventHandler(this.Encoder_offset_TextChanged);
            // 
            // Sensor_A_Raw_data_format
            // 
            this.Sensor_A_Raw_data_format.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Raw_data_format.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Raw_data_format.Enabled = false;
            this.Sensor_A_Raw_data_format.Location = new System.Drawing.Point(558, 525);
            this.Sensor_A_Raw_data_format.Name = "Sensor_A_Raw_data_format";
            this.Sensor_A_Raw_data_format.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Raw_data_format.TabIndex = 27;
            this.Sensor_A_Raw_data_format.TextChanged += new System.EventHandler(this.Sensor_A_Raw_data_format_TextChanged);
            // 
            // Sensor_B_Raw_data_format
            // 
            this.Sensor_B_Raw_data_format.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Raw_data_format.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Raw_data_format.Enabled = false;
            this.Sensor_B_Raw_data_format.Location = new System.Drawing.Point(558, 565);
            this.Sensor_B_Raw_data_format.Name = "Sensor_B_Raw_data_format";
            this.Sensor_B_Raw_data_format.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Raw_data_format.TabIndex = 27;
            this.Sensor_B_Raw_data_format.TextChanged += new System.EventHandler(this.Sensor_B_Raw_data_format_TextChanged);
            // 
            // Sensor_A_Sample_rate
            // 
            this.Sensor_A_Sample_rate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Sample_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Sample_rate.Enabled = false;
            this.Sensor_A_Sample_rate.Location = new System.Drawing.Point(558, 605);
            this.Sensor_A_Sample_rate.Name = "Sensor_A_Sample_rate";
            this.Sensor_A_Sample_rate.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Sample_rate.TabIndex = 27;
            this.Sensor_A_Sample_rate.TextChanged += new System.EventHandler(this.Sensor_A_Sample_rate_TextChanged);
            // 
            // Sensor_A_Scale_factor_X
            // 
            this.Sensor_A_Scale_factor_X.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Scale_factor_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Scale_factor_X.Enabled = false;
            this.Sensor_A_Scale_factor_X.Location = new System.Drawing.Point(558, 645);
            this.Sensor_A_Scale_factor_X.Name = "Sensor_A_Scale_factor_X";
            this.Sensor_A_Scale_factor_X.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Scale_factor_X.TabIndex = 27;
            this.Sensor_A_Scale_factor_X.TextChanged += new System.EventHandler(this.Sensor_A_Scale_factor_X_TextChanged);
            // 
            // Sensor_A_Scale_factor_Y
            // 
            this.Sensor_A_Scale_factor_Y.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Scale_factor_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Scale_factor_Y.Enabled = false;
            this.Sensor_A_Scale_factor_Y.Location = new System.Drawing.Point(708, 45);
            this.Sensor_A_Scale_factor_Y.Name = "Sensor_A_Scale_factor_Y";
            this.Sensor_A_Scale_factor_Y.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Scale_factor_Y.TabIndex = 27;
            this.Sensor_A_Scale_factor_Y.TextChanged += new System.EventHandler(this.Sensor_A_Scale_factor_Y_TextChanged);
            // 
            // Sensor_A_Scale_factor_Z
            // 
            this.Sensor_A_Scale_factor_Z.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Scale_factor_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Scale_factor_Z.Enabled = false;
            this.Sensor_A_Scale_factor_Z.Location = new System.Drawing.Point(708, 85);
            this.Sensor_A_Scale_factor_Z.Name = "Sensor_A_Scale_factor_Z";
            this.Sensor_A_Scale_factor_Z.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Scale_factor_Z.TabIndex = 27;
            this.Sensor_A_Scale_factor_Z.TextChanged += new System.EventHandler(this.Sensor_A_Scale_factor_Z_TextChanged);
            // 
            // Sensor_A_SF_Tempco_X
            // 
            this.Sensor_A_SF_Tempco_X.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_SF_Tempco_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_SF_Tempco_X.Enabled = false;
            this.Sensor_A_SF_Tempco_X.Location = new System.Drawing.Point(708, 125);
            this.Sensor_A_SF_Tempco_X.Name = "Sensor_A_SF_Tempco_X";
            this.Sensor_A_SF_Tempco_X.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_SF_Tempco_X.TabIndex = 27;
            this.Sensor_A_SF_Tempco_X.TextChanged += new System.EventHandler(this.Sensor_A_SF_Tempco_X_TextChanged);
            // 
            // Sensor_A_SF_Tempco_Y
            // 
            this.Sensor_A_SF_Tempco_Y.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_SF_Tempco_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_SF_Tempco_Y.Enabled = false;
            this.Sensor_A_SF_Tempco_Y.Location = new System.Drawing.Point(708, 165);
            this.Sensor_A_SF_Tempco_Y.Name = "Sensor_A_SF_Tempco_Y";
            this.Sensor_A_SF_Tempco_Y.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_SF_Tempco_Y.TabIndex = 27;
            this.Sensor_A_SF_Tempco_Y.TextChanged += new System.EventHandler(this.Sensor_A_SF_Tempco_Y_TextChanged);
            // 
            // Sensor_A_SF_Tempco_Z
            // 
            this.Sensor_A_SF_Tempco_Z.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_SF_Tempco_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_SF_Tempco_Z.Enabled = false;
            this.Sensor_A_SF_Tempco_Z.Location = new System.Drawing.Point(708, 205);
            this.Sensor_A_SF_Tempco_Z.Name = "Sensor_A_SF_Tempco_Z";
            this.Sensor_A_SF_Tempco_Z.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_SF_Tempco_Z.TabIndex = 27;
            this.Sensor_A_SF_Tempco_Z.TextChanged += new System.EventHandler(this.Sensor_A_SF_Tempco_Z_TextChanged);
            // 
            // Sensor_A_Offset_X
            // 
            this.Sensor_A_Offset_X.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Offset_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Offset_X.Enabled = false;
            this.Sensor_A_Offset_X.Location = new System.Drawing.Point(708, 245);
            this.Sensor_A_Offset_X.Name = "Sensor_A_Offset_X";
            this.Sensor_A_Offset_X.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Offset_X.TabIndex = 27;
            this.Sensor_A_Offset_X.TextChanged += new System.EventHandler(this.Sensor_A_Offset_X_TextChanged);
            // 
            // Sensor_A_Offset_Y
            // 
            this.Sensor_A_Offset_Y.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Offset_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Offset_Y.Enabled = false;
            this.Sensor_A_Offset_Y.Location = new System.Drawing.Point(708, 285);
            this.Sensor_A_Offset_Y.Name = "Sensor_A_Offset_Y";
            this.Sensor_A_Offset_Y.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Offset_Y.TabIndex = 27;
            this.Sensor_A_Offset_Y.TextChanged += new System.EventHandler(this.Sensor_A_Offset_Y_TextChanged);
            // 
            // Sensor_A_Offset_Z
            // 
            this.Sensor_A_Offset_Z.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Offset_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Offset_Z.Enabled = false;
            this.Sensor_A_Offset_Z.Location = new System.Drawing.Point(708, 325);
            this.Sensor_A_Offset_Z.Name = "Sensor_A_Offset_Z";
            this.Sensor_A_Offset_Z.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Offset_Z.TabIndex = 27;
            this.Sensor_A_Offset_Z.TextChanged += new System.EventHandler(this.Sensor_A_Offset_Z_TextChanged);
            // 
            // Sensor_A_Offset_Tempco_X
            // 
            this.Sensor_A_Offset_Tempco_X.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Offset_Tempco_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Offset_Tempco_X.Enabled = false;
            this.Sensor_A_Offset_Tempco_X.Location = new System.Drawing.Point(708, 365);
            this.Sensor_A_Offset_Tempco_X.Name = "Sensor_A_Offset_Tempco_X";
            this.Sensor_A_Offset_Tempco_X.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Offset_Tempco_X.TabIndex = 27;
            this.Sensor_A_Offset_Tempco_X.TextChanged += new System.EventHandler(this.Sensor_A_Offset_Tempco_X_TextChanged);
            // 
            // Sensor_A_Offset_Tempco_Y
            // 
            this.Sensor_A_Offset_Tempco_Y.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Offset_Tempco_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Offset_Tempco_Y.Enabled = false;
            this.Sensor_A_Offset_Tempco_Y.Location = new System.Drawing.Point(708, 405);
            this.Sensor_A_Offset_Tempco_Y.Name = "Sensor_A_Offset_Tempco_Y";
            this.Sensor_A_Offset_Tempco_Y.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Offset_Tempco_Y.TabIndex = 27;
            this.Sensor_A_Offset_Tempco_Y.TextChanged += new System.EventHandler(this.Sensor_A_Offset_Tempco_Y_TextChanged);
            // 
            // Sensor_A_Offset_Tempco_Z
            // 
            this.Sensor_A_Offset_Tempco_Z.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Offset_Tempco_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Offset_Tempco_Z.Enabled = false;
            this.Sensor_A_Offset_Tempco_Z.Location = new System.Drawing.Point(708, 445);
            this.Sensor_A_Offset_Tempco_Z.Name = "Sensor_A_Offset_Tempco_Z";
            this.Sensor_A_Offset_Tempco_Z.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Offset_Tempco_Z.TabIndex = 27;
            this.Sensor_A_Offset_Tempco_Z.TextChanged += new System.EventHandler(this.Sensor_A_Offset_Tempco_Z_TextChanged);
            // 
            // Sensor_A_Misalign_Alpha
            // 
            this.Sensor_A_Misalign_Alpha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Misalign_Alpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Misalign_Alpha.Enabled = false;
            this.Sensor_A_Misalign_Alpha.Location = new System.Drawing.Point(708, 485);
            this.Sensor_A_Misalign_Alpha.Name = "Sensor_A_Misalign_Alpha";
            this.Sensor_A_Misalign_Alpha.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Misalign_Alpha.TabIndex = 27;
            this.Sensor_A_Misalign_Alpha.TextChanged += new System.EventHandler(this.Sensor_A_Misalign_Alpha_TextChanged);
            // 
            // Sensor_A_Misalign_Beta
            // 
            this.Sensor_A_Misalign_Beta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Misalign_Beta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Misalign_Beta.Enabled = false;
            this.Sensor_A_Misalign_Beta.Location = new System.Drawing.Point(708, 525);
            this.Sensor_A_Misalign_Beta.Name = "Sensor_A_Misalign_Beta";
            this.Sensor_A_Misalign_Beta.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Misalign_Beta.TabIndex = 27;
            this.Sensor_A_Misalign_Beta.TextChanged += new System.EventHandler(this.Sensor_A_Misalign_Beta_TextChanged);
            // 
            // Sensor_A_Misalign_Gamma
            // 
            this.Sensor_A_Misalign_Gamma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_A_Misalign_Gamma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_A_Misalign_Gamma.Enabled = false;
            this.Sensor_A_Misalign_Gamma.Location = new System.Drawing.Point(708, 565);
            this.Sensor_A_Misalign_Gamma.Name = "Sensor_A_Misalign_Gamma";
            this.Sensor_A_Misalign_Gamma.Size = new System.Drawing.Size(130, 20);
            this.Sensor_A_Misalign_Gamma.TabIndex = 27;
            this.Sensor_A_Misalign_Gamma.TextChanged += new System.EventHandler(this.Sensor_A_Misalign_Gamma_TextChanged);
            // 
            // Sensor_B_Sample_rate
            // 
            this.Sensor_B_Sample_rate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Sample_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Sample_rate.Enabled = false;
            this.Sensor_B_Sample_rate.Location = new System.Drawing.Point(708, 605);
            this.Sensor_B_Sample_rate.Name = "Sensor_B_Sample_rate";
            this.Sensor_B_Sample_rate.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Sample_rate.TabIndex = 27;
            this.Sensor_B_Sample_rate.TextChanged += new System.EventHandler(this.Sensor_B_Sample_rate_TextChanged);
            // 
            // Sensor_B_Scale_factor_X
            // 
            this.Sensor_B_Scale_factor_X.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Scale_factor_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Scale_factor_X.Enabled = false;
            this.Sensor_B_Scale_factor_X.Location = new System.Drawing.Point(708, 645);
            this.Sensor_B_Scale_factor_X.Name = "Sensor_B_Scale_factor_X";
            this.Sensor_B_Scale_factor_X.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Scale_factor_X.TabIndex = 27;
            this.Sensor_B_Scale_factor_X.TextChanged += new System.EventHandler(this.Sensor_B_Scale_factor_X_TextChanged);
            // 
            // Sensor_B_Scale_factor_Y
            // 
            this.Sensor_B_Scale_factor_Y.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Scale_factor_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Scale_factor_Y.Enabled = false;
            this.Sensor_B_Scale_factor_Y.Location = new System.Drawing.Point(858, 45);
            this.Sensor_B_Scale_factor_Y.Name = "Sensor_B_Scale_factor_Y";
            this.Sensor_B_Scale_factor_Y.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Scale_factor_Y.TabIndex = 27;
            this.Sensor_B_Scale_factor_Y.TextChanged += new System.EventHandler(this.Sensor_B_Scale_factor_Y_TextChanged);
            // 
            // Sensor_B_Scale_factor_Z
            // 
            this.Sensor_B_Scale_factor_Z.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Scale_factor_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Scale_factor_Z.Enabled = false;
            this.Sensor_B_Scale_factor_Z.Location = new System.Drawing.Point(858, 85);
            this.Sensor_B_Scale_factor_Z.Name = "Sensor_B_Scale_factor_Z";
            this.Sensor_B_Scale_factor_Z.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Scale_factor_Z.TabIndex = 27;
            this.Sensor_B_Scale_factor_Z.TextChanged += new System.EventHandler(this.Sensor_B_Scale_factor_Z_TextChanged);
            // 
            // Sensor_B_SF_Tempco_X
            // 
            this.Sensor_B_SF_Tempco_X.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_SF_Tempco_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_SF_Tempco_X.Enabled = false;
            this.Sensor_B_SF_Tempco_X.Location = new System.Drawing.Point(858, 125);
            this.Sensor_B_SF_Tempco_X.Name = "Sensor_B_SF_Tempco_X";
            this.Sensor_B_SF_Tempco_X.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_SF_Tempco_X.TabIndex = 27;
            this.Sensor_B_SF_Tempco_X.TextChanged += new System.EventHandler(this.Sensor_B_SF_Tempco_X_TextChanged);
            // 
            // Sensor_B_SF_Tempco_Y
            // 
            this.Sensor_B_SF_Tempco_Y.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_SF_Tempco_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_SF_Tempco_Y.Enabled = false;
            this.Sensor_B_SF_Tempco_Y.Location = new System.Drawing.Point(858, 165);
            this.Sensor_B_SF_Tempco_Y.Name = "Sensor_B_SF_Tempco_Y";
            this.Sensor_B_SF_Tempco_Y.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_SF_Tempco_Y.TabIndex = 27;
            this.Sensor_B_SF_Tempco_Y.TextChanged += new System.EventHandler(this.Sensor_B_SF_Tempco_Y_TextChanged);
            // 
            // Sensor_B_SF_Tempco_Z
            // 
            this.Sensor_B_SF_Tempco_Z.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_SF_Tempco_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_SF_Tempco_Z.Enabled = false;
            this.Sensor_B_SF_Tempco_Z.Location = new System.Drawing.Point(858, 205);
            this.Sensor_B_SF_Tempco_Z.Name = "Sensor_B_SF_Tempco_Z";
            this.Sensor_B_SF_Tempco_Z.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_SF_Tempco_Z.TabIndex = 27;
            this.Sensor_B_SF_Tempco_Z.TextChanged += new System.EventHandler(this.Sensor_B_SF_Tempco_Z_TextChanged);
            // 
            // Sensor_B_Offset_X
            // 
            this.Sensor_B_Offset_X.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Offset_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Offset_X.Enabled = false;
            this.Sensor_B_Offset_X.Location = new System.Drawing.Point(858, 245);
            this.Sensor_B_Offset_X.Name = "Sensor_B_Offset_X";
            this.Sensor_B_Offset_X.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Offset_X.TabIndex = 27;
            this.Sensor_B_Offset_X.TextChanged += new System.EventHandler(this.Sensor_B_Offset_X_TextChanged);
            // 
            // Sensor_B_Offset_Y
            // 
            this.Sensor_B_Offset_Y.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Offset_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Offset_Y.Enabled = false;
            this.Sensor_B_Offset_Y.Location = new System.Drawing.Point(858, 285);
            this.Sensor_B_Offset_Y.Name = "Sensor_B_Offset_Y";
            this.Sensor_B_Offset_Y.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Offset_Y.TabIndex = 27;
            this.Sensor_B_Offset_Y.TextChanged += new System.EventHandler(this.Sensor_B_Offset_Y_TextChanged);
            // 
            // Sensor_B_Offset_Z
            // 
            this.Sensor_B_Offset_Z.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Offset_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Offset_Z.Enabled = false;
            this.Sensor_B_Offset_Z.Location = new System.Drawing.Point(858, 325);
            this.Sensor_B_Offset_Z.Name = "Sensor_B_Offset_Z";
            this.Sensor_B_Offset_Z.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Offset_Z.TabIndex = 27;
            this.Sensor_B_Offset_Z.TextChanged += new System.EventHandler(this.Sensor_B_Offset_Z_TextChanged);
            // 
            // Sensor_B_Offset_Tempco_X
            // 
            this.Sensor_B_Offset_Tempco_X.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Offset_Tempco_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Offset_Tempco_X.Enabled = false;
            this.Sensor_B_Offset_Tempco_X.Location = new System.Drawing.Point(858, 365);
            this.Sensor_B_Offset_Tempco_X.Name = "Sensor_B_Offset_Tempco_X";
            this.Sensor_B_Offset_Tempco_X.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Offset_Tempco_X.TabIndex = 27;
            this.Sensor_B_Offset_Tempco_X.TextChanged += new System.EventHandler(this.Sensor_B_Offset_Tempco_X_TextChanged);
            // 
            // Sensor_B_Offset_Tempco_Y
            // 
            this.Sensor_B_Offset_Tempco_Y.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Offset_Tempco_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Offset_Tempco_Y.Enabled = false;
            this.Sensor_B_Offset_Tempco_Y.Location = new System.Drawing.Point(858, 405);
            this.Sensor_B_Offset_Tempco_Y.Name = "Sensor_B_Offset_Tempco_Y";
            this.Sensor_B_Offset_Tempco_Y.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Offset_Tempco_Y.TabIndex = 27;
            this.Sensor_B_Offset_Tempco_Y.TextChanged += new System.EventHandler(this.Sensor_B_Offset_Tempco_Y_TextChanged);
            // 
            // Sensor_B_Offset_Tempco_Z
            // 
            this.Sensor_B_Offset_Tempco_Z.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Offset_Tempco_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Offset_Tempco_Z.Enabled = false;
            this.Sensor_B_Offset_Tempco_Z.Location = new System.Drawing.Point(858, 445);
            this.Sensor_B_Offset_Tempco_Z.Name = "Sensor_B_Offset_Tempco_Z";
            this.Sensor_B_Offset_Tempco_Z.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Offset_Tempco_Z.TabIndex = 27;
            this.Sensor_B_Offset_Tempco_Z.TextChanged += new System.EventHandler(this.Sensor_B_Offset_Tempco_Z_TextChanged);
            // 
            // Sensor_B_Misalign_Alpha
            // 
            this.Sensor_B_Misalign_Alpha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Misalign_Alpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Misalign_Alpha.Enabled = false;
            this.Sensor_B_Misalign_Alpha.Location = new System.Drawing.Point(858, 485);
            this.Sensor_B_Misalign_Alpha.Name = "Sensor_B_Misalign_Alpha";
            this.Sensor_B_Misalign_Alpha.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Misalign_Alpha.TabIndex = 27;
            this.Sensor_B_Misalign_Alpha.TextChanged += new System.EventHandler(this.Sensor_B_Misalign_Alpha_TextChanged);
            // 
            // Sensor_B_Misalign_Beta
            // 
            this.Sensor_B_Misalign_Beta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Misalign_Beta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Misalign_Beta.Enabled = false;
            this.Sensor_B_Misalign_Beta.Location = new System.Drawing.Point(858, 525);
            this.Sensor_B_Misalign_Beta.Name = "Sensor_B_Misalign_Beta";
            this.Sensor_B_Misalign_Beta.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Misalign_Beta.TabIndex = 27;
            this.Sensor_B_Misalign_Beta.TextChanged += new System.EventHandler(this.Sensor_B_Misalign_Beta_TextChanged);
            // 
            // Sensor_B_Misalign_Gamma
            // 
            this.Sensor_B_Misalign_Gamma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sensor_B_Misalign_Gamma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensor_B_Misalign_Gamma.Enabled = false;
            this.Sensor_B_Misalign_Gamma.Location = new System.Drawing.Point(858, 565);
            this.Sensor_B_Misalign_Gamma.Name = "Sensor_B_Misalign_Gamma";
            this.Sensor_B_Misalign_Gamma.Size = new System.Drawing.Size(130, 20);
            this.Sensor_B_Misalign_Gamma.TabIndex = 27;
            this.Sensor_B_Misalign_Gamma.TextChanged += new System.EventHandler(this.Sensor_B_Misalign_Gamma_TextChanged);
            // 
            // Temperature_offset
            // 
            this.Temperature_offset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Temperature_offset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Temperature_offset.Enabled = false;
            this.Temperature_offset.Location = new System.Drawing.Point(858, 605);
            this.Temperature_offset.Name = "Temperature_offset";
            this.Temperature_offset.Size = new System.Drawing.Size(130, 20);
            this.Temperature_offset.TabIndex = 27;
            this.Temperature_offset.TextChanged += new System.EventHandler(this.Temperature_offset_TextChanged);
            // 
            // Temperature_scale_factor
            // 
            this.Temperature_scale_factor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Temperature_scale_factor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Temperature_scale_factor.Enabled = false;
            this.Temperature_scale_factor.Location = new System.Drawing.Point(858, 645);
            this.Temperature_scale_factor.Name = "Temperature_scale_factor";
            this.Temperature_scale_factor.Size = new System.Drawing.Size(130, 20);
            this.Temperature_scale_factor.TabIndex = 27;
            this.Temperature_scale_factor.TextChanged += new System.EventHandler(this.Temperature_scale_factor_TextChanged);
            // 
            // label_Carrier_serial_number
            // 
            this.label_Carrier_serial_number.AutoSize = true;
            this.label_Carrier_serial_number.Enabled = false;
            this.label_Carrier_serial_number.Location = new System.Drawing.Point(557, 30);
            this.label_Carrier_serial_number.Name = "label_Carrier_serial_number";
            this.label_Carrier_serial_number.Size = new System.Drawing.Size(102, 13);
            this.label_Carrier_serial_number.TabIndex = 28;
            this.label_Carrier_serial_number.Text = "Carrier serial number";
            this.label_Carrier_serial_number.Click += new System.EventHandler(this.label_Carrier_serial_number_Click);
            // 
            // label_Sensor_A_name
            // 
            this.label_Sensor_A_name.AutoSize = true;
            this.label_Sensor_A_name.Enabled = false;
            this.label_Sensor_A_name.Location = new System.Drawing.Point(557, 70);
            this.label_Sensor_A_name.Name = "label_Sensor_A_name";
            this.label_Sensor_A_name.Size = new System.Drawing.Size(79, 13);
            this.label_Sensor_A_name.TabIndex = 28;
            this.label_Sensor_A_name.Text = "Sensor A name";
            // 
            // label_Sensor_B_name
            // 
            this.label_Sensor_B_name.AutoSize = true;
            this.label_Sensor_B_name.Enabled = false;
            this.label_Sensor_B_name.Location = new System.Drawing.Point(557, 110);
            this.label_Sensor_B_name.Name = "label_Sensor_B_name";
            this.label_Sensor_B_name.Size = new System.Drawing.Size(79, 13);
            this.label_Sensor_B_name.TabIndex = 28;
            this.label_Sensor_B_name.Text = "Sensor B name";
            // 
            // label_Sensor_A_active_sensors
            // 
            this.label_Sensor_A_active_sensors.AutoSize = true;
            this.label_Sensor_A_active_sensors.Enabled = false;
            this.label_Sensor_A_active_sensors.Location = new System.Drawing.Point(557, 150);
            this.label_Sensor_A_active_sensors.Name = "label_Sensor_A_active_sensors";
            this.label_Sensor_A_active_sensors.Size = new System.Drawing.Size(121, 13);
            this.label_Sensor_A_active_sensors.TabIndex = 28;
            this.label_Sensor_A_active_sensors.Text = "Sensor A active sensors";
            // 
            // label_Sensor_A_installed_bitmap
            // 
            this.label_Sensor_A_installed_bitmap.AutoSize = true;
            this.label_Sensor_A_installed_bitmap.Enabled = false;
            this.label_Sensor_A_installed_bitmap.Location = new System.Drawing.Point(557, 190);
            this.label_Sensor_A_installed_bitmap.Name = "label_Sensor_A_installed_bitmap";
            this.label_Sensor_A_installed_bitmap.Size = new System.Drawing.Size(125, 13);
            this.label_Sensor_A_installed_bitmap.TabIndex = 28;
            this.label_Sensor_A_installed_bitmap.Text = "Sensor A installed bitmap";
            // 
            // label_Sensor_A_enabled_bitmap
            // 
            this.label_Sensor_A_enabled_bitmap.AutoSize = true;
            this.label_Sensor_A_enabled_bitmap.Enabled = false;
            this.label_Sensor_A_enabled_bitmap.Location = new System.Drawing.Point(557, 230);
            this.label_Sensor_A_enabled_bitmap.Name = "label_Sensor_A_enabled_bitmap";
            this.label_Sensor_A_enabled_bitmap.Size = new System.Drawing.Size(125, 13);
            this.label_Sensor_A_enabled_bitmap.TabIndex = 28;
            this.label_Sensor_A_enabled_bitmap.Text = "Sensor A enabled bitmap";
            // 
            // label_Sensor_A_faulty_bitmap
            // 
            this.label_Sensor_A_faulty_bitmap.AutoSize = true;
            this.label_Sensor_A_faulty_bitmap.Enabled = false;
            this.label_Sensor_A_faulty_bitmap.Location = new System.Drawing.Point(557, 270);
            this.label_Sensor_A_faulty_bitmap.Name = "label_Sensor_A_faulty_bitmap";
            this.label_Sensor_A_faulty_bitmap.Size = new System.Drawing.Size(112, 13);
            this.label_Sensor_A_faulty_bitmap.TabIndex = 28;
            this.label_Sensor_A_faulty_bitmap.Text = "Sensor A faulty bitmap";
            // 
            // label_Sensor_B_active_sensors
            // 
            this.label_Sensor_B_active_sensors.AutoSize = true;
            this.label_Sensor_B_active_sensors.Enabled = false;
            this.label_Sensor_B_active_sensors.Location = new System.Drawing.Point(557, 310);
            this.label_Sensor_B_active_sensors.Name = "label_Sensor_B_active_sensors";
            this.label_Sensor_B_active_sensors.Size = new System.Drawing.Size(121, 13);
            this.label_Sensor_B_active_sensors.TabIndex = 28;
            this.label_Sensor_B_active_sensors.Text = "Sensor B active sensors";
            // 
            // label_Sensor_B_installed_bitmap
            // 
            this.label_Sensor_B_installed_bitmap.AutoSize = true;
            this.label_Sensor_B_installed_bitmap.Enabled = false;
            this.label_Sensor_B_installed_bitmap.Location = new System.Drawing.Point(557, 350);
            this.label_Sensor_B_installed_bitmap.Name = "label_Sensor_B_installed_bitmap";
            this.label_Sensor_B_installed_bitmap.Size = new System.Drawing.Size(125, 13);
            this.label_Sensor_B_installed_bitmap.TabIndex = 28;
            this.label_Sensor_B_installed_bitmap.Text = "Sensor B installed bitmap";
            // 
            // label_Sensor_B_enabled_bitmap
            // 
            this.label_Sensor_B_enabled_bitmap.AutoSize = true;
            this.label_Sensor_B_enabled_bitmap.Enabled = false;
            this.label_Sensor_B_enabled_bitmap.Location = new System.Drawing.Point(557, 390);
            this.label_Sensor_B_enabled_bitmap.Name = "label_Sensor_B_enabled_bitmap";
            this.label_Sensor_B_enabled_bitmap.Size = new System.Drawing.Size(125, 13);
            this.label_Sensor_B_enabled_bitmap.TabIndex = 28;
            this.label_Sensor_B_enabled_bitmap.Text = "Sensor B enabled bitmap";
            // 
            // label_Sensor_B_failty_bitmap
            // 
            this.label_Sensor_B_failty_bitmap.AutoSize = true;
            this.label_Sensor_B_failty_bitmap.Enabled = false;
            this.label_Sensor_B_failty_bitmap.Location = new System.Drawing.Point(557, 430);
            this.label_Sensor_B_failty_bitmap.Name = "label_Sensor_B_failty_bitmap";
            this.label_Sensor_B_failty_bitmap.Size = new System.Drawing.Size(108, 13);
            this.label_Sensor_B_failty_bitmap.TabIndex = 28;
            this.label_Sensor_B_failty_bitmap.Text = "Sensor B failty bitmap";
            // 
            // label_Encoder_offset
            // 
            this.label_Encoder_offset.AutoSize = true;
            this.label_Encoder_offset.Enabled = false;
            this.label_Encoder_offset.Location = new System.Drawing.Point(557, 470);
            this.label_Encoder_offset.Name = "label_Encoder_offset";
            this.label_Encoder_offset.Size = new System.Drawing.Size(76, 13);
            this.label_Encoder_offset.TabIndex = 28;
            this.label_Encoder_offset.Text = "Encoder offset";
            // 
            // label_Sensor_A_Raw_data_format
            // 
            this.label_Sensor_A_Raw_data_format.AutoSize = true;
            this.label_Sensor_A_Raw_data_format.Enabled = false;
            this.label_Sensor_A_Raw_data_format.Location = new System.Drawing.Point(557, 510);
            this.label_Sensor_A_Raw_data_format.Name = "label_Sensor_A_Raw_data_format";
            this.label_Sensor_A_Raw_data_format.Size = new System.Drawing.Size(131, 13);
            this.label_Sensor_A_Raw_data_format.TabIndex = 28;
            this.label_Sensor_A_Raw_data_format.Text = "Sensor A Raw data format";
            // 
            // label_Sensor_B_Raw_data_format
            // 
            this.label_Sensor_B_Raw_data_format.AutoSize = true;
            this.label_Sensor_B_Raw_data_format.Enabled = false;
            this.label_Sensor_B_Raw_data_format.Location = new System.Drawing.Point(557, 550);
            this.label_Sensor_B_Raw_data_format.Name = "label_Sensor_B_Raw_data_format";
            this.label_Sensor_B_Raw_data_format.Size = new System.Drawing.Size(131, 13);
            this.label_Sensor_B_Raw_data_format.TabIndex = 28;
            this.label_Sensor_B_Raw_data_format.Text = "Sensor B Raw data format";
            // 
            // label_Sensor_A_Sample_rate
            // 
            this.label_Sensor_A_Sample_rate.AutoSize = true;
            this.label_Sensor_A_Sample_rate.Enabled = false;
            this.label_Sensor_A_Sample_rate.Location = new System.Drawing.Point(557, 590);
            this.label_Sensor_A_Sample_rate.Name = "label_Sensor_A_Sample_rate";
            this.label_Sensor_A_Sample_rate.Size = new System.Drawing.Size(109, 13);
            this.label_Sensor_A_Sample_rate.TabIndex = 28;
            this.label_Sensor_A_Sample_rate.Text = "Sensor A Sample rate";
            // 
            // label_Sensor_A_Scale_factor_X
            // 
            this.label_Sensor_A_Scale_factor_X.AutoSize = true;
            this.label_Sensor_A_Scale_factor_X.Enabled = false;
            this.label_Sensor_A_Scale_factor_X.Location = new System.Drawing.Point(557, 630);
            this.label_Sensor_A_Scale_factor_X.Name = "label_Sensor_A_Scale_factor_X";
            this.label_Sensor_A_Scale_factor_X.Size = new System.Drawing.Size(120, 13);
            this.label_Sensor_A_Scale_factor_X.TabIndex = 28;
            this.label_Sensor_A_Scale_factor_X.Text = "Sensor A Scale factor X";
            // 
            // label_Sensor_A_Scale_factor_Y
            // 
            this.label_Sensor_A_Scale_factor_Y.AutoSize = true;
            this.label_Sensor_A_Scale_factor_Y.Enabled = false;
            this.label_Sensor_A_Scale_factor_Y.Location = new System.Drawing.Point(707, 30);
            this.label_Sensor_A_Scale_factor_Y.Name = "label_Sensor_A_Scale_factor_Y";
            this.label_Sensor_A_Scale_factor_Y.Size = new System.Drawing.Size(120, 13);
            this.label_Sensor_A_Scale_factor_Y.TabIndex = 28;
            this.label_Sensor_A_Scale_factor_Y.Text = "Sensor A Scale factor Y";
            // 
            // label_Sensor_A_Scale_factor_Z
            // 
            this.label_Sensor_A_Scale_factor_Z.AutoSize = true;
            this.label_Sensor_A_Scale_factor_Z.Enabled = false;
            this.label_Sensor_A_Scale_factor_Z.Location = new System.Drawing.Point(707, 70);
            this.label_Sensor_A_Scale_factor_Z.Name = "label_Sensor_A_Scale_factor_Z";
            this.label_Sensor_A_Scale_factor_Z.Size = new System.Drawing.Size(120, 13);
            this.label_Sensor_A_Scale_factor_Z.TabIndex = 28;
            this.label_Sensor_A_Scale_factor_Z.Text = "Sensor A Scale factor Z";
            // 
            // label_Sensor_A_SF_Tempco_X
            // 
            this.label_Sensor_A_SF_Tempco_X.AutoSize = true;
            this.label_Sensor_A_SF_Tempco_X.Enabled = false;
            this.label_Sensor_A_SF_Tempco_X.Location = new System.Drawing.Point(707, 110);
            this.label_Sensor_A_SF_Tempco_X.Name = "label_Sensor_A_SF_Tempco_X";
            this.label_Sensor_A_SF_Tempco_X.Size = new System.Drawing.Size(118, 13);
            this.label_Sensor_A_SF_Tempco_X.TabIndex = 28;
            this.label_Sensor_A_SF_Tempco_X.Text = "Sensor A SF Tempco X";
            // 
            // label_Sensor_A_SF_Tempco_Y
            // 
            this.label_Sensor_A_SF_Tempco_Y.AutoSize = true;
            this.label_Sensor_A_SF_Tempco_Y.Enabled = false;
            this.label_Sensor_A_SF_Tempco_Y.Location = new System.Drawing.Point(707, 150);
            this.label_Sensor_A_SF_Tempco_Y.Name = "label_Sensor_A_SF_Tempco_Y";
            this.label_Sensor_A_SF_Tempco_Y.Size = new System.Drawing.Size(118, 13);
            this.label_Sensor_A_SF_Tempco_Y.TabIndex = 28;
            this.label_Sensor_A_SF_Tempco_Y.Text = "Sensor A SF Tempco Y";
            // 
            // label_Sensor_A_SF_Tempco_Z
            // 
            this.label_Sensor_A_SF_Tempco_Z.AutoSize = true;
            this.label_Sensor_A_SF_Tempco_Z.Enabled = false;
            this.label_Sensor_A_SF_Tempco_Z.Location = new System.Drawing.Point(707, 190);
            this.label_Sensor_A_SF_Tempco_Z.Name = "label_Sensor_A_SF_Tempco_Z";
            this.label_Sensor_A_SF_Tempco_Z.Size = new System.Drawing.Size(118, 13);
            this.label_Sensor_A_SF_Tempco_Z.TabIndex = 28;
            this.label_Sensor_A_SF_Tempco_Z.Text = "Sensor A SF Tempco Z";
            // 
            // label_Sensor_A_Offset_X
            // 
            this.label_Sensor_A_Offset_X.AutoSize = true;
            this.label_Sensor_A_Offset_X.Enabled = false;
            this.label_Sensor_A_Offset_X.Location = new System.Drawing.Point(707, 230);
            this.label_Sensor_A_Offset_X.Name = "label_Sensor_A_Offset_X";
            this.label_Sensor_A_Offset_X.Size = new System.Drawing.Size(91, 13);
            this.label_Sensor_A_Offset_X.TabIndex = 28;
            this.label_Sensor_A_Offset_X.Text = "Sensor A Offset X";
            // 
            // label_Sensor_A_Offset_Y
            // 
            this.label_Sensor_A_Offset_Y.AutoSize = true;
            this.label_Sensor_A_Offset_Y.Enabled = false;
            this.label_Sensor_A_Offset_Y.Location = new System.Drawing.Point(707, 270);
            this.label_Sensor_A_Offset_Y.Name = "label_Sensor_A_Offset_Y";
            this.label_Sensor_A_Offset_Y.Size = new System.Drawing.Size(91, 13);
            this.label_Sensor_A_Offset_Y.TabIndex = 28;
            this.label_Sensor_A_Offset_Y.Text = "Sensor A Offset Y";
            // 
            // label_Sensor_A_Offset_Z
            // 
            this.label_Sensor_A_Offset_Z.AutoSize = true;
            this.label_Sensor_A_Offset_Z.Enabled = false;
            this.label_Sensor_A_Offset_Z.Location = new System.Drawing.Point(707, 310);
            this.label_Sensor_A_Offset_Z.Name = "label_Sensor_A_Offset_Z";
            this.label_Sensor_A_Offset_Z.Size = new System.Drawing.Size(91, 13);
            this.label_Sensor_A_Offset_Z.TabIndex = 28;
            this.label_Sensor_A_Offset_Z.Text = "Sensor A Offset Z";
            // 
            // label_Sensor_A_Offset_Tempco_X
            // 
            this.label_Sensor_A_Offset_Tempco_X.AutoSize = true;
            this.label_Sensor_A_Offset_Tempco_X.Enabled = false;
            this.label_Sensor_A_Offset_Tempco_X.Location = new System.Drawing.Point(707, 350);
            this.label_Sensor_A_Offset_Tempco_X.Name = "label_Sensor_A_Offset_Tempco_X";
            this.label_Sensor_A_Offset_Tempco_X.Size = new System.Drawing.Size(133, 13);
            this.label_Sensor_A_Offset_Tempco_X.TabIndex = 28;
            this.label_Sensor_A_Offset_Tempco_X.Text = "Sensor A Offset Tempco X";
            // 
            // label_Sensor_A_Offset_Tempco_Y
            // 
            this.label_Sensor_A_Offset_Tempco_Y.AutoSize = true;
            this.label_Sensor_A_Offset_Tempco_Y.Enabled = false;
            this.label_Sensor_A_Offset_Tempco_Y.Location = new System.Drawing.Point(707, 390);
            this.label_Sensor_A_Offset_Tempco_Y.Name = "label_Sensor_A_Offset_Tempco_Y";
            this.label_Sensor_A_Offset_Tempco_Y.Size = new System.Drawing.Size(133, 13);
            this.label_Sensor_A_Offset_Tempco_Y.TabIndex = 28;
            this.label_Sensor_A_Offset_Tempco_Y.Text = "Sensor A Offset Tempco Y";
            // 
            // label_Sensor_A_Offset_Tempco_Z
            // 
            this.label_Sensor_A_Offset_Tempco_Z.AutoSize = true;
            this.label_Sensor_A_Offset_Tempco_Z.Enabled = false;
            this.label_Sensor_A_Offset_Tempco_Z.Location = new System.Drawing.Point(707, 430);
            this.label_Sensor_A_Offset_Tempco_Z.Name = "label_Sensor_A_Offset_Tempco_Z";
            this.label_Sensor_A_Offset_Tempco_Z.Size = new System.Drawing.Size(133, 13);
            this.label_Sensor_A_Offset_Tempco_Z.TabIndex = 28;
            this.label_Sensor_A_Offset_Tempco_Z.Text = "Sensor A Offset Tempco Z";
            // 
            // label_Sensor_A_Misalign_Alpha
            // 
            this.label_Sensor_A_Misalign_Alpha.AutoSize = true;
            this.label_Sensor_A_Misalign_Alpha.Enabled = false;
            this.label_Sensor_A_Misalign_Alpha.Location = new System.Drawing.Point(707, 470);
            this.label_Sensor_A_Misalign_Alpha.Name = "label_Sensor_A_Misalign_Alpha";
            this.label_Sensor_A_Misalign_Alpha.Size = new System.Drawing.Size(121, 13);
            this.label_Sensor_A_Misalign_Alpha.TabIndex = 28;
            this.label_Sensor_A_Misalign_Alpha.Text = "Sensor A Misalign Alpha";
            // 
            // label_Sensor_A_Misalign_Beta
            // 
            this.label_Sensor_A_Misalign_Beta.AutoSize = true;
            this.label_Sensor_A_Misalign_Beta.Enabled = false;
            this.label_Sensor_A_Misalign_Beta.Location = new System.Drawing.Point(707, 510);
            this.label_Sensor_A_Misalign_Beta.Name = "label_Sensor_A_Misalign_Beta";
            this.label_Sensor_A_Misalign_Beta.Size = new System.Drawing.Size(116, 13);
            this.label_Sensor_A_Misalign_Beta.TabIndex = 28;
            this.label_Sensor_A_Misalign_Beta.Text = "Sensor A Misalign Beta";
            // 
            // label_Sensor_A_Misalign_Gamma
            // 
            this.label_Sensor_A_Misalign_Gamma.AutoSize = true;
            this.label_Sensor_A_Misalign_Gamma.Enabled = false;
            this.label_Sensor_A_Misalign_Gamma.Location = new System.Drawing.Point(707, 550);
            this.label_Sensor_A_Misalign_Gamma.Name = "label_Sensor_A_Misalign_Gamma";
            this.label_Sensor_A_Misalign_Gamma.Size = new System.Drawing.Size(130, 13);
            this.label_Sensor_A_Misalign_Gamma.TabIndex = 28;
            this.label_Sensor_A_Misalign_Gamma.Text = "Sensor A Misalign Gamma";
            // 
            // label_Sensor_B_Sample_rate
            // 
            this.label_Sensor_B_Sample_rate.AutoSize = true;
            this.label_Sensor_B_Sample_rate.Enabled = false;
            this.label_Sensor_B_Sample_rate.Location = new System.Drawing.Point(707, 590);
            this.label_Sensor_B_Sample_rate.Name = "label_Sensor_B_Sample_rate";
            this.label_Sensor_B_Sample_rate.Size = new System.Drawing.Size(109, 13);
            this.label_Sensor_B_Sample_rate.TabIndex = 28;
            this.label_Sensor_B_Sample_rate.Text = "Sensor B Sample rate";
            // 
            // label_Sensor_B_Scale_factor_X
            // 
            this.label_Sensor_B_Scale_factor_X.AutoSize = true;
            this.label_Sensor_B_Scale_factor_X.Enabled = false;
            this.label_Sensor_B_Scale_factor_X.Location = new System.Drawing.Point(707, 630);
            this.label_Sensor_B_Scale_factor_X.Name = "label_Sensor_B_Scale_factor_X";
            this.label_Sensor_B_Scale_factor_X.Size = new System.Drawing.Size(120, 13);
            this.label_Sensor_B_Scale_factor_X.TabIndex = 28;
            this.label_Sensor_B_Scale_factor_X.Text = "Sensor B Scale factor X";
            // 
            // label_Sensor_B_Scale_factor_Y
            // 
            this.label_Sensor_B_Scale_factor_Y.AutoSize = true;
            this.label_Sensor_B_Scale_factor_Y.Enabled = false;
            this.label_Sensor_B_Scale_factor_Y.Location = new System.Drawing.Point(857, 30);
            this.label_Sensor_B_Scale_factor_Y.Name = "label_Sensor_B_Scale_factor_Y";
            this.label_Sensor_B_Scale_factor_Y.Size = new System.Drawing.Size(120, 13);
            this.label_Sensor_B_Scale_factor_Y.TabIndex = 28;
            this.label_Sensor_B_Scale_factor_Y.Text = "Sensor B Scale factor Y";
            // 
            // label_Sensor_B_Scale_factor_Z
            // 
            this.label_Sensor_B_Scale_factor_Z.AutoSize = true;
            this.label_Sensor_B_Scale_factor_Z.Enabled = false;
            this.label_Sensor_B_Scale_factor_Z.Location = new System.Drawing.Point(857, 70);
            this.label_Sensor_B_Scale_factor_Z.Name = "label_Sensor_B_Scale_factor_Z";
            this.label_Sensor_B_Scale_factor_Z.Size = new System.Drawing.Size(120, 13);
            this.label_Sensor_B_Scale_factor_Z.TabIndex = 28;
            this.label_Sensor_B_Scale_factor_Z.Text = "Sensor B Scale factor Z";
            // 
            // label_Sensor_B_SF_Tempco_X
            // 
            this.label_Sensor_B_SF_Tempco_X.AutoSize = true;
            this.label_Sensor_B_SF_Tempco_X.Enabled = false;
            this.label_Sensor_B_SF_Tempco_X.Location = new System.Drawing.Point(857, 110);
            this.label_Sensor_B_SF_Tempco_X.Name = "label_Sensor_B_SF_Tempco_X";
            this.label_Sensor_B_SF_Tempco_X.Size = new System.Drawing.Size(118, 13);
            this.label_Sensor_B_SF_Tempco_X.TabIndex = 28;
            this.label_Sensor_B_SF_Tempco_X.Text = "Sensor B SF Tempco X";
            // 
            // label_Sensor_B_SF_Tempco_Y
            // 
            this.label_Sensor_B_SF_Tempco_Y.AutoSize = true;
            this.label_Sensor_B_SF_Tempco_Y.Enabled = false;
            this.label_Sensor_B_SF_Tempco_Y.Location = new System.Drawing.Point(857, 150);
            this.label_Sensor_B_SF_Tempco_Y.Name = "label_Sensor_B_SF_Tempco_Y";
            this.label_Sensor_B_SF_Tempco_Y.Size = new System.Drawing.Size(118, 13);
            this.label_Sensor_B_SF_Tempco_Y.TabIndex = 28;
            this.label_Sensor_B_SF_Tempco_Y.Text = "Sensor B SF Tempco Y";
            // 
            // label_Sensor_B_SF_Tempco_Z
            // 
            this.label_Sensor_B_SF_Tempco_Z.AutoSize = true;
            this.label_Sensor_B_SF_Tempco_Z.Enabled = false;
            this.label_Sensor_B_SF_Tempco_Z.Location = new System.Drawing.Point(857, 190);
            this.label_Sensor_B_SF_Tempco_Z.Name = "label_Sensor_B_SF_Tempco_Z";
            this.label_Sensor_B_SF_Tempco_Z.Size = new System.Drawing.Size(118, 13);
            this.label_Sensor_B_SF_Tempco_Z.TabIndex = 28;
            this.label_Sensor_B_SF_Tempco_Z.Text = "Sensor B SF Tempco Z";
            // 
            // label_Sensor_B_Offset_X
            // 
            this.label_Sensor_B_Offset_X.AutoSize = true;
            this.label_Sensor_B_Offset_X.Enabled = false;
            this.label_Sensor_B_Offset_X.Location = new System.Drawing.Point(857, 230);
            this.label_Sensor_B_Offset_X.Name = "label_Sensor_B_Offset_X";
            this.label_Sensor_B_Offset_X.Size = new System.Drawing.Size(91, 13);
            this.label_Sensor_B_Offset_X.TabIndex = 28;
            this.label_Sensor_B_Offset_X.Text = "Sensor B Offset X";
            // 
            // label_Sensor_B_Offset_Y
            // 
            this.label_Sensor_B_Offset_Y.AutoSize = true;
            this.label_Sensor_B_Offset_Y.Enabled = false;
            this.label_Sensor_B_Offset_Y.Location = new System.Drawing.Point(857, 270);
            this.label_Sensor_B_Offset_Y.Name = "label_Sensor_B_Offset_Y";
            this.label_Sensor_B_Offset_Y.Size = new System.Drawing.Size(91, 13);
            this.label_Sensor_B_Offset_Y.TabIndex = 28;
            this.label_Sensor_B_Offset_Y.Text = "Sensor B Offset Y";
            // 
            // label_Sensor_B_Offset_Z
            // 
            this.label_Sensor_B_Offset_Z.AutoSize = true;
            this.label_Sensor_B_Offset_Z.Enabled = false;
            this.label_Sensor_B_Offset_Z.Location = new System.Drawing.Point(857, 310);
            this.label_Sensor_B_Offset_Z.Name = "label_Sensor_B_Offset_Z";
            this.label_Sensor_B_Offset_Z.Size = new System.Drawing.Size(91, 13);
            this.label_Sensor_B_Offset_Z.TabIndex = 28;
            this.label_Sensor_B_Offset_Z.Text = "Sensor B Offset Z";
            // 
            // label_Sensor_B_Offset_Tempco_X
            // 
            this.label_Sensor_B_Offset_Tempco_X.AutoSize = true;
            this.label_Sensor_B_Offset_Tempco_X.Enabled = false;
            this.label_Sensor_B_Offset_Tempco_X.Location = new System.Drawing.Point(857, 350);
            this.label_Sensor_B_Offset_Tempco_X.Name = "label_Sensor_B_Offset_Tempco_X";
            this.label_Sensor_B_Offset_Tempco_X.Size = new System.Drawing.Size(133, 13);
            this.label_Sensor_B_Offset_Tempco_X.TabIndex = 28;
            this.label_Sensor_B_Offset_Tempco_X.Text = "Sensor B Offset Tempco X";
            // 
            // label_Sensor_B_Offset_Tempco_Y
            // 
            this.label_Sensor_B_Offset_Tempco_Y.AutoSize = true;
            this.label_Sensor_B_Offset_Tempco_Y.Enabled = false;
            this.label_Sensor_B_Offset_Tempco_Y.Location = new System.Drawing.Point(857, 390);
            this.label_Sensor_B_Offset_Tempco_Y.Name = "label_Sensor_B_Offset_Tempco_Y";
            this.label_Sensor_B_Offset_Tempco_Y.Size = new System.Drawing.Size(133, 13);
            this.label_Sensor_B_Offset_Tempco_Y.TabIndex = 28;
            this.label_Sensor_B_Offset_Tempco_Y.Text = "Sensor B Offset Tempco Y";
            // 
            // label_Sensor_B_Offset_Tempco_Z
            // 
            this.label_Sensor_B_Offset_Tempco_Z.AutoSize = true;
            this.label_Sensor_B_Offset_Tempco_Z.Enabled = false;
            this.label_Sensor_B_Offset_Tempco_Z.Location = new System.Drawing.Point(857, 430);
            this.label_Sensor_B_Offset_Tempco_Z.Name = "label_Sensor_B_Offset_Tempco_Z";
            this.label_Sensor_B_Offset_Tempco_Z.Size = new System.Drawing.Size(133, 13);
            this.label_Sensor_B_Offset_Tempco_Z.TabIndex = 28;
            this.label_Sensor_B_Offset_Tempco_Z.Text = "Sensor B Offset Tempco Z";
            // 
            // label_Sensor_B_Misalign_Alpha
            // 
            this.label_Sensor_B_Misalign_Alpha.AutoSize = true;
            this.label_Sensor_B_Misalign_Alpha.Enabled = false;
            this.label_Sensor_B_Misalign_Alpha.Location = new System.Drawing.Point(857, 470);
            this.label_Sensor_B_Misalign_Alpha.Name = "label_Sensor_B_Misalign_Alpha";
            this.label_Sensor_B_Misalign_Alpha.Size = new System.Drawing.Size(121, 13);
            this.label_Sensor_B_Misalign_Alpha.TabIndex = 28;
            this.label_Sensor_B_Misalign_Alpha.Text = "Sensor B Misalign Alpha";
            // 
            // label_Sensor_B_Misalign_Beta
            // 
            this.label_Sensor_B_Misalign_Beta.AutoSize = true;
            this.label_Sensor_B_Misalign_Beta.Enabled = false;
            this.label_Sensor_B_Misalign_Beta.Location = new System.Drawing.Point(857, 510);
            this.label_Sensor_B_Misalign_Beta.Name = "label_Sensor_B_Misalign_Beta";
            this.label_Sensor_B_Misalign_Beta.Size = new System.Drawing.Size(116, 13);
            this.label_Sensor_B_Misalign_Beta.TabIndex = 28;
            this.label_Sensor_B_Misalign_Beta.Text = "Sensor B Misalign Beta";
            // 
            // label_Sensor_B_Misalign_Gamma
            // 
            this.label_Sensor_B_Misalign_Gamma.AutoSize = true;
            this.label_Sensor_B_Misalign_Gamma.Enabled = false;
            this.label_Sensor_B_Misalign_Gamma.Location = new System.Drawing.Point(857, 550);
            this.label_Sensor_B_Misalign_Gamma.Name = "label_Sensor_B_Misalign_Gamma";
            this.label_Sensor_B_Misalign_Gamma.Size = new System.Drawing.Size(130, 13);
            this.label_Sensor_B_Misalign_Gamma.TabIndex = 28;
            this.label_Sensor_B_Misalign_Gamma.Text = "Sensor B Misalign Gamma";
            // 
            // label_Temperature_offset
            // 
            this.label_Temperature_offset.AutoSize = true;
            this.label_Temperature_offset.Enabled = false;
            this.label_Temperature_offset.Location = new System.Drawing.Point(857, 590);
            this.label_Temperature_offset.Name = "label_Temperature_offset";
            this.label_Temperature_offset.Size = new System.Drawing.Size(96, 13);
            this.label_Temperature_offset.TabIndex = 28;
            this.label_Temperature_offset.Text = "Temperature offset";
            // 
            // SERCOM_statusbar
            // 
            this.SERCOM_statusbar.Location = new System.Drawing.Point(12, 3);
            this.SERCOM_statusbar.Name = "SERCOM_statusbar";
            this.SERCOM_statusbar.Size = new System.Drawing.Size(529, 20);
            this.SERCOM_statusbar.TabIndex = 29;
            // 
            // Sent
            // 
            this.Sent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Sent.Location = new System.Drawing.Point(11, 673);
            this.Sent.Name = "Sent";
            this.Sent.ReadOnly = true;
            this.Sent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sent.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Sent.Size = new System.Drawing.Size(533, 20);
            this.Sent.TabIndex = 30;
            // 
            // LoggProgress
            // 
            this.LoggProgress.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoggProgress.Location = new System.Drawing.Point(12, 918);
            this.LoggProgress.MarqueeAnimationSpeed = 50;
            this.LoggProgress.Maximum = 20;
            this.LoggProgress.Name = "LoggProgress";
            this.LoggProgress.Size = new System.Drawing.Size(978, 23);
            this.LoggProgress.TabIndex = 32;
            // 
            // bt_Start_Logging
            // 
            this.bt_Start_Logging.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Start_Logging.Enabled = false;
            this.bt_Start_Logging.Location = new System.Drawing.Point(703, 889);
            this.bt_Start_Logging.Name = "bt_Start_Logging";
            this.bt_Start_Logging.Size = new System.Drawing.Size(143, 23);
            this.bt_Start_Logging.TabIndex = 33;
            this.bt_Start_Logging.Text = "Start Logging";
            this.bt_Start_Logging.UseVisualStyleBackColor = false;
            this.bt_Start_Logging.Click += new System.EventHandler(this.InitializeLoggSession);
            // 
            // LoggWorker
            // 
            this.LoggWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoggWorker_DoWork);
            // 
            // bt_Cancel_Logging
            // 
            this.bt_Cancel_Logging.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Cancel_Logging.Enabled = false;
            this.bt_Cancel_Logging.Location = new System.Drawing.Point(852, 889);
            this.bt_Cancel_Logging.Name = "bt_Cancel_Logging";
            this.bt_Cancel_Logging.Size = new System.Drawing.Size(137, 23);
            this.bt_Cancel_Logging.TabIndex = 34;
            this.bt_Cancel_Logging.Text = "Cancel Logging";
            this.bt_Cancel_Logging.UseVisualStyleBackColor = false;
            this.bt_Cancel_Logging.Click += new System.EventHandler(this.CancelLoggSession);
            // 
            // lb_Motor_Controller1
            // 
            this.lb_Motor_Controller1.AutoSize = true;
            this.lb_Motor_Controller1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Motor_Controller1.Location = new System.Drawing.Point(13, 705);
            this.lb_Motor_Controller1.Name = "lb_Motor_Controller1";
            this.lb_Motor_Controller1.Size = new System.Drawing.Size(79, 13);
            this.lb_Motor_Controller1.TabIndex = 36;
            this.lb_Motor_Controller1.Text = "20MM : Motor1";
            // 
            // Motor1_Velocity
            // 
            this.Motor1_Velocity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor1_Velocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor1_Velocity.Enabled = false;
            this.Motor1_Velocity.Location = new System.Drawing.Point(217, 731);
            this.Motor1_Velocity.Name = "Motor1_Velocity";
            this.Motor1_Velocity.Size = new System.Drawing.Size(100, 20);
            this.Motor1_Velocity.TabIndex = 37;
            this.Motor1_Velocity.Text = "120";
            this.Motor1_Velocity.TextChanged += new System.EventHandler(this.Motor1_Velocity_TextChanged);
            // 
            // Motor1_Acceleration
            // 
            this.Motor1_Acceleration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor1_Acceleration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor1_Acceleration.Enabled = false;
            this.Motor1_Acceleration.Location = new System.Drawing.Point(217, 757);
            this.Motor1_Acceleration.Name = "Motor1_Acceleration";
            this.Motor1_Acceleration.Size = new System.Drawing.Size(100, 20);
            this.Motor1_Acceleration.TabIndex = 38;
            this.Motor1_Acceleration.Text = "720";
            // 
            // bt_Motor1_Save_Setting
            // 
            this.bt_Motor1_Save_Setting.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Motor1_Save_Setting.Enabled = false;
            this.bt_Motor1_Save_Setting.Location = new System.Drawing.Point(3, 41);
            this.bt_Motor1_Save_Setting.Name = "bt_Motor1_Save_Setting";
            this.bt_Motor1_Save_Setting.Size = new System.Drawing.Size(100, 25);
            this.bt_Motor1_Save_Setting.TabIndex = 41;
            this.bt_Motor1_Save_Setting.Text = "Save Settings";
            this.bt_Motor1_Save_Setting.UseVisualStyleBackColor = false;
            this.bt_Motor1_Save_Setting.Click += new System.EventHandler(this.bt_Motor1_Save_Setting_Click);
            // 
            // Logging_Period
            // 
            this.Logging_Period.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Logging_Period.Location = new System.Drawing.Point(108, 892);
            this.Logging_Period.Name = "Logging_Period";
            this.Logging_Period.Size = new System.Drawing.Size(100, 20);
            this.Logging_Period.TabIndex = 42;
            this.Logging_Period.Text = "60";
            // 
            // Toggle_Delay
            // 
            this.Toggle_Delay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Toggle_Delay.Location = new System.Drawing.Point(315, 892);
            this.Toggle_Delay.Name = "Toggle_Delay";
            this.Toggle_Delay.Size = new System.Drawing.Size(100, 20);
            this.Toggle_Delay.TabIndex = 43;
            this.Toggle_Delay.Text = "5";
            // 
            // lb_Logging_Period
            // 
            this.lb_Logging_Period.AutoSize = true;
            this.lb_Logging_Period.Location = new System.Drawing.Point(10, 895);
            this.lb_Logging_Period.Name = "lb_Logging_Period";
            this.lb_Logging_Period.Size = new System.Drawing.Size(92, 13);
            this.lb_Logging_Period.TabIndex = 44;
            this.lb_Logging_Period.Text = "Logging Period (s)";
            // 
            // lb_Toggle_Delay
            // 
            this.lb_Toggle_Delay.AutoSize = true;
            this.lb_Toggle_Delay.Location = new System.Drawing.Point(225, 895);
            this.lb_Toggle_Delay.Name = "lb_Toggle_Delay";
            this.lb_Toggle_Delay.Size = new System.Drawing.Size(84, 13);
            this.lb_Toggle_Delay.TabIndex = 45;
            this.lb_Toggle_Delay.Text = "Toggle Delay (s)";
            // 
            // lb_Motor1_Velocity
            // 
            this.lb_Motor1_Velocity.AutoSize = true;
            this.lb_Motor1_Velocity.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Motor1_Velocity.Location = new System.Drawing.Point(132, 733);
            this.lb_Motor1_Velocity.Name = "lb_Motor1_Velocity";
            this.lb_Motor1_Velocity.Size = new System.Drawing.Size(44, 13);
            this.lb_Motor1_Velocity.TabIndex = 46;
            this.lb_Motor1_Velocity.Text = "Velocity";
            // 
            // lb_Motor1_Acceleration
            // 
            this.lb_Motor1_Acceleration.AutoSize = true;
            this.lb_Motor1_Acceleration.Location = new System.Drawing.Point(119, 58);
            this.lb_Motor1_Acceleration.Name = "lb_Motor1_Acceleration";
            this.lb_Motor1_Acceleration.Size = new System.Drawing.Size(66, 13);
            this.lb_Motor1_Acceleration.TabIndex = 47;
            this.lb_Motor1_Acceleration.Text = "Acceleration";
            // 
            // Motor1_Status
            // 
            this.Motor1_Status.BackColor = System.Drawing.Color.Red;
            this.Motor1_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor1_Status.Enabled = false;
            this.Motor1_Status.Location = new System.Drawing.Point(87, 719);
            this.Motor1_Status.Name = "Motor1_Status";
            this.Motor1_Status.ReadOnly = true;
            this.Motor1_Status.Size = new System.Drawing.Size(29, 20);
            this.Motor1_Status.TabIndex = 48;
            // 
            // cb_Logg_Enabled
            // 
            this.cb_Logg_Enabled.AutoSize = true;
            this.cb_Logg_Enabled.Enabled = false;
            this.cb_Logg_Enabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Logg_Enabled.Location = new System.Drawing.Point(557, -2);
            this.cb_Logg_Enabled.Name = "cb_Logg_Enabled";
            this.cb_Logg_Enabled.Size = new System.Drawing.Size(176, 29);
            this.cb_Logg_Enabled.TabIndex = 49;
            this.cb_Logg_Enabled.Text = "Logg Enabled";
            this.cb_Logg_Enabled.UseVisualStyleBackColor = true;
            this.cb_Logg_Enabled.CheckedChanged += new System.EventHandler(this.cb_Logg_Enabled_CheckedChanged);
            // 
            // cb_Motor1_Enabled
            // 
            this.cb_Motor1_Enabled.AutoSize = true;
            this.cb_Motor1_Enabled.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cb_Motor1_Enabled.Location = new System.Drawing.Point(16, 722);
            this.cb_Motor1_Enabled.Name = "cb_Motor1_Enabled";
            this.cb_Motor1_Enabled.Size = new System.Drawing.Size(65, 17);
            this.cb_Motor1_Enabled.TabIndex = 50;
            this.cb_Motor1_Enabled.Text = "Enabled";
            this.cb_Motor1_Enabled.UseVisualStyleBackColor = false;
            this.cb_Motor1_Enabled.CheckedChanged += new System.EventHandler(this.cb_Motor1_Enabled_CheckedChanged);
            // 
            // cb_Motor2_Enabled
            // 
            this.cb_Motor2_Enabled.AutoSize = true;
            this.cb_Motor2_Enabled.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cb_Motor2_Enabled.Location = new System.Drawing.Point(349, 722);
            this.cb_Motor2_Enabled.Name = "cb_Motor2_Enabled";
            this.cb_Motor2_Enabled.Size = new System.Drawing.Size(65, 17);
            this.cb_Motor2_Enabled.TabIndex = 59;
            this.cb_Motor2_Enabled.Text = "Enabled";
            this.cb_Motor2_Enabled.UseVisualStyleBackColor = false;
            this.cb_Motor2_Enabled.CheckedChanged += new System.EventHandler(this.cb_Motor2_Enabled_CheckedChanged);
            // 
            // Motor2_Status
            // 
            this.Motor2_Status.BackColor = System.Drawing.Color.Red;
            this.Motor2_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor2_Status.Enabled = false;
            this.Motor2_Status.Location = new System.Drawing.Point(420, 719);
            this.Motor2_Status.Name = "Motor2_Status";
            this.Motor2_Status.ReadOnly = true;
            this.Motor2_Status.Size = new System.Drawing.Size(29, 20);
            this.Motor2_Status.TabIndex = 58;
            // 
            // lb_Motor2_Acceleration
            // 
            this.lb_Motor2_Acceleration.AutoSize = true;
            this.lb_Motor2_Acceleration.Location = new System.Drawing.Point(120, 58);
            this.lb_Motor2_Acceleration.Name = "lb_Motor2_Acceleration";
            this.lb_Motor2_Acceleration.Size = new System.Drawing.Size(66, 13);
            this.lb_Motor2_Acceleration.TabIndex = 57;
            this.lb_Motor2_Acceleration.Text = "Acceleration";
            // 
            // lb_Motor2_Velocity
            // 
            this.lb_Motor2_Velocity.AutoSize = true;
            this.lb_Motor2_Velocity.Location = new System.Drawing.Point(120, 32);
            this.lb_Motor2_Velocity.Name = "lb_Motor2_Velocity";
            this.lb_Motor2_Velocity.Size = new System.Drawing.Size(44, 13);
            this.lb_Motor2_Velocity.TabIndex = 56;
            this.lb_Motor2_Velocity.Text = "Velocity";
            // 
            // bt_Motor2_Save_Setting
            // 
            this.bt_Motor2_Save_Setting.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Motor2_Save_Setting.Enabled = false;
            this.bt_Motor2_Save_Setting.Location = new System.Drawing.Point(349, 742);
            this.bt_Motor2_Save_Setting.Name = "bt_Motor2_Save_Setting";
            this.bt_Motor2_Save_Setting.Size = new System.Drawing.Size(100, 25);
            this.bt_Motor2_Save_Setting.TabIndex = 55;
            this.bt_Motor2_Save_Setting.Text = "Save Settings";
            this.bt_Motor2_Save_Setting.UseVisualStyleBackColor = false;
            this.bt_Motor2_Save_Setting.Click += new System.EventHandler(this.bt_Motor2_Save_Setting_Click);
            // 
            // lb_Motor_Controller2
            // 
            this.lb_Motor_Controller2.AutoSize = true;
            this.lb_Motor_Controller2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Motor_Controller2.Location = new System.Drawing.Point(346, 705);
            this.lb_Motor_Controller2.Name = "lb_Motor_Controller2";
            this.lb_Motor_Controller2.Size = new System.Drawing.Size(79, 13);
            this.lb_Motor_Controller2.TabIndex = 52;
            this.lb_Motor_Controller2.Text = "20MM : Motor2";
            // 
            // bt_Motor2_Setup
            // 
            this.bt_Motor2_Setup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Motor2_Setup.Enabled = false;
            this.bt_Motor2_Setup.Location = new System.Drawing.Point(478, 947);
            this.bt_Motor2_Setup.Name = "bt_Motor2_Setup";
            this.bt_Motor2_Setup.Size = new System.Drawing.Size(100, 23);
            this.bt_Motor2_Setup.TabIndex = 51;
            this.bt_Motor2_Setup.Text = "Motor2 Setup";
            this.bt_Motor2_Setup.UseVisualStyleBackColor = false;
            this.bt_Motor2_Setup.Visible = false;
            this.bt_Motor2_Setup.Click += new System.EventHandler(this.bt_Motor2_Setup_Click);
            // 
            // cb_Motor3_Enabled
            // 
            this.cb_Motor3_Enabled.AutoSize = true;
            this.cb_Motor3_Enabled.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cb_Motor3_Enabled.Location = new System.Drawing.Point(682, 721);
            this.cb_Motor3_Enabled.Name = "cb_Motor3_Enabled";
            this.cb_Motor3_Enabled.Size = new System.Drawing.Size(65, 17);
            this.cb_Motor3_Enabled.TabIndex = 68;
            this.cb_Motor3_Enabled.Text = "Enabled";
            this.cb_Motor3_Enabled.UseVisualStyleBackColor = false;
            this.cb_Motor3_Enabled.CheckedChanged += new System.EventHandler(this.cb_Motor3_Enabled_CheckedChanged);
            // 
            // Motor3_Status
            // 
            this.Motor3_Status.BackColor = System.Drawing.Color.Red;
            this.Motor3_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor3_Status.Enabled = false;
            this.Motor3_Status.Location = new System.Drawing.Point(753, 718);
            this.Motor3_Status.Name = "Motor3_Status";
            this.Motor3_Status.ReadOnly = true;
            this.Motor3_Status.Size = new System.Drawing.Size(29, 20);
            this.Motor3_Status.TabIndex = 67;
            // 
            // lb_Motor3_Acceleration
            // 
            this.lb_Motor3_Acceleration.AutoSize = true;
            this.lb_Motor3_Acceleration.Location = new System.Drawing.Point(122, 58);
            this.lb_Motor3_Acceleration.Name = "lb_Motor3_Acceleration";
            this.lb_Motor3_Acceleration.Size = new System.Drawing.Size(66, 13);
            this.lb_Motor3_Acceleration.TabIndex = 66;
            this.lb_Motor3_Acceleration.Text = "Acceleration";
            // 
            // lb_Motor3_Velocity
            // 
            this.lb_Motor3_Velocity.AutoSize = true;
            this.lb_Motor3_Velocity.Location = new System.Drawing.Point(122, 32);
            this.lb_Motor3_Velocity.Name = "lb_Motor3_Velocity";
            this.lb_Motor3_Velocity.Size = new System.Drawing.Size(44, 13);
            this.lb_Motor3_Velocity.TabIndex = 65;
            this.lb_Motor3_Velocity.Text = "Velocity";
            // 
            // bt_Motor3_Save_Setting
            // 
            this.bt_Motor3_Save_Setting.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Motor3_Save_Setting.Enabled = false;
            this.bt_Motor3_Save_Setting.Location = new System.Drawing.Point(3, 40);
            this.bt_Motor3_Save_Setting.Name = "bt_Motor3_Save_Setting";
            this.bt_Motor3_Save_Setting.Size = new System.Drawing.Size(100, 25);
            this.bt_Motor3_Save_Setting.TabIndex = 64;
            this.bt_Motor3_Save_Setting.Text = "Save Settings";
            this.bt_Motor3_Save_Setting.UseVisualStyleBackColor = false;
            this.bt_Motor3_Save_Setting.Click += new System.EventHandler(this.bt_Motor3_Save_Setting_Click);
            // 
            // Motor3_Acceleration
            // 
            this.Motor3_Acceleration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor3_Acceleration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor3_Acceleration.Enabled = false;
            this.Motor3_Acceleration.Location = new System.Drawing.Point(884, 757);
            this.Motor3_Acceleration.Name = "Motor3_Acceleration";
            this.Motor3_Acceleration.Size = new System.Drawing.Size(100, 20);
            this.Motor3_Acceleration.TabIndex = 63;
            this.Motor3_Acceleration.Text = "9000";
            // 
            // Motor3_Velocity
            // 
            this.Motor3_Velocity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor3_Velocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor3_Velocity.Enabled = false;
            this.Motor3_Velocity.Location = new System.Drawing.Point(884, 731);
            this.Motor3_Velocity.Name = "Motor3_Velocity";
            this.Motor3_Velocity.Size = new System.Drawing.Size(100, 20);
            this.Motor3_Velocity.TabIndex = 62;
            this.Motor3_Velocity.Text = "3000";
            // 
            // lb_Motor_Controller3
            // 
            this.lb_Motor_Controller3.AutoSize = true;
            this.lb_Motor_Controller3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Motor_Controller3.Location = new System.Drawing.Point(679, 704);
            this.lb_Motor_Controller3.Name = "lb_Motor_Controller3";
            this.lb_Motor_Controller3.Size = new System.Drawing.Size(73, 13);
            this.lb_Motor_Controller3.TabIndex = 61;
            this.lb_Motor_Controller3.Text = "10MM : Motor";
            // 
            // bt_Motor3_Setup
            // 
            this.bt_Motor3_Setup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Motor3_Setup.Enabled = false;
            this.bt_Motor3_Setup.Location = new System.Drawing.Point(584, 947);
            this.bt_Motor3_Setup.Name = "bt_Motor3_Setup";
            this.bt_Motor3_Setup.Size = new System.Drawing.Size(100, 23);
            this.bt_Motor3_Setup.TabIndex = 60;
            this.bt_Motor3_Setup.Text = "Motor3 Setup";
            this.bt_Motor3_Setup.UseVisualStyleBackColor = false;
            this.bt_Motor3_Setup.Visible = false;
            this.bt_Motor3_Setup.Click += new System.EventHandler(this.bt_Motor3_Setup_Click);
            // 
            // lb_Motor1_distance
            // 
            this.lb_Motor1_distance.AutoSize = true;
            this.lb_Motor1_distance.Location = new System.Drawing.Point(119, 109);
            this.lb_Motor1_distance.Name = "lb_Motor1_distance";
            this.lb_Motor1_distance.Size = new System.Drawing.Size(49, 13);
            this.lb_Motor1_distance.TabIndex = 69;
            this.lb_Motor1_distance.Text = "Distance";
            // 
            // lb_Motor2_distance
            // 
            this.lb_Motor2_distance.AutoSize = true;
            this.lb_Motor2_distance.Location = new System.Drawing.Point(120, 109);
            this.lb_Motor2_distance.Name = "lb_Motor2_distance";
            this.lb_Motor2_distance.Size = new System.Drawing.Size(49, 13);
            this.lb_Motor2_distance.TabIndex = 70;
            this.lb_Motor2_distance.Text = "Distance";
            // 
            // lb_Motor3_distance
            // 
            this.lb_Motor3_distance.AutoSize = true;
            this.lb_Motor3_distance.Location = new System.Drawing.Point(122, 109);
            this.lb_Motor3_distance.Name = "lb_Motor3_distance";
            this.lb_Motor3_distance.Size = new System.Drawing.Size(49, 13);
            this.lb_Motor3_distance.TabIndex = 71;
            this.lb_Motor3_distance.Text = "Distance";
            // 
            // Motor1_Distance
            // 
            this.Motor1_Distance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor1_Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor1_Distance.Enabled = false;
            this.Motor1_Distance.Location = new System.Drawing.Point(217, 809);
            this.Motor1_Distance.Name = "Motor1_Distance";
            this.Motor1_Distance.Size = new System.Drawing.Size(100, 20);
            this.Motor1_Distance.TabIndex = 72;
            this.Motor1_Distance.Text = "32";
            // 
            // Motor3_Distance
            // 
            this.Motor3_Distance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor3_Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor3_Distance.Enabled = false;
            this.Motor3_Distance.Location = new System.Drawing.Point(884, 808);
            this.Motor3_Distance.Name = "Motor3_Distance";
            this.Motor3_Distance.Size = new System.Drawing.Size(100, 20);
            this.Motor3_Distance.TabIndex = 74;
            this.Motor3_Distance.Text = "3072";
            // 
            // Motor1_Deacceleration
            // 
            this.Motor1_Deacceleration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor1_Deacceleration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor1_Deacceleration.Enabled = false;
            this.Motor1_Deacceleration.Location = new System.Drawing.Point(217, 783);
            this.Motor1_Deacceleration.Name = "Motor1_Deacceleration";
            this.Motor1_Deacceleration.Size = new System.Drawing.Size(100, 20);
            this.Motor1_Deacceleration.TabIndex = 75;
            this.Motor1_Deacceleration.Text = "720";
            // 
            // lb_Motor1_Deacceleration
            // 
            this.lb_Motor1_Deacceleration.AutoSize = true;
            this.lb_Motor1_Deacceleration.Location = new System.Drawing.Point(119, 84);
            this.lb_Motor1_Deacceleration.Name = "lb_Motor1_Deacceleration";
            this.lb_Motor1_Deacceleration.Size = new System.Drawing.Size(79, 13);
            this.lb_Motor1_Deacceleration.TabIndex = 76;
            this.lb_Motor1_Deacceleration.Text = "Deacceleration";
            // 
            // lb_Motor2_Deacceleration
            // 
            this.lb_Motor2_Deacceleration.AutoSize = true;
            this.lb_Motor2_Deacceleration.Location = new System.Drawing.Point(120, 84);
            this.lb_Motor2_Deacceleration.Name = "lb_Motor2_Deacceleration";
            this.lb_Motor2_Deacceleration.Size = new System.Drawing.Size(79, 13);
            this.lb_Motor2_Deacceleration.TabIndex = 77;
            this.lb_Motor2_Deacceleration.Text = "Deacceleration";
            // 
            // lb_Motor3_Deacceleration
            // 
            this.lb_Motor3_Deacceleration.AutoSize = true;
            this.lb_Motor3_Deacceleration.Location = new System.Drawing.Point(122, 84);
            this.lb_Motor3_Deacceleration.Name = "lb_Motor3_Deacceleration";
            this.lb_Motor3_Deacceleration.Size = new System.Drawing.Size(79, 13);
            this.lb_Motor3_Deacceleration.TabIndex = 78;
            this.lb_Motor3_Deacceleration.Text = "Deacceleration";
            // 
            // Motor3_Deacceleration
            // 
            this.Motor3_Deacceleration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor3_Deacceleration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor3_Deacceleration.Enabled = false;
            this.Motor3_Deacceleration.Location = new System.Drawing.Point(884, 783);
            this.Motor3_Deacceleration.Name = "Motor3_Deacceleration";
            this.Motor3_Deacceleration.Size = new System.Drawing.Size(100, 20);
            this.Motor3_Deacceleration.TabIndex = 80;
            this.Motor3_Deacceleration.Text = "9000";
            // 
            // bt_Motor1_Set_Zero
            // 
            this.bt_Motor1_Set_Zero.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Motor1_Set_Zero.Enabled = false;
            this.bt_Motor1_Set_Zero.Location = new System.Drawing.Point(16, 804);
            this.bt_Motor1_Set_Zero.Name = "bt_Motor1_Set_Zero";
            this.bt_Motor1_Set_Zero.Size = new System.Drawing.Size(100, 25);
            this.bt_Motor1_Set_Zero.TabIndex = 81;
            this.bt_Motor1_Set_Zero.Text = "Set Zero";
            this.bt_Motor1_Set_Zero.UseVisualStyleBackColor = false;
            this.bt_Motor1_Set_Zero.Click += new System.EventHandler(this.bt_Motor1_Set_Zero_Click);
            // 
            // Motor1_Position
            // 
            this.Motor1_Position.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Motor1_Position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor1_Position.Location = new System.Drawing.Point(217, 705);
            this.Motor1_Position.Name = "Motor1_Position";
            this.Motor1_Position.ReadOnly = true;
            this.Motor1_Position.Size = new System.Drawing.Size(100, 20);
            this.Motor1_Position.TabIndex = 83;
            // 
            // MotorStatusWorker
            // 
            this.MotorStatusWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MotorStatusWorker_DoWork);
            // 
            // bt_Motor1_Read_Position
            // 
            this.bt_Motor1_Read_Position.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Motor1_Read_Position.Enabled = false;
            this.bt_Motor1_Read_Position.Location = new System.Drawing.Point(16, 773);
            this.bt_Motor1_Read_Position.Name = "bt_Motor1_Read_Position";
            this.bt_Motor1_Read_Position.Size = new System.Drawing.Size(100, 25);
            this.bt_Motor1_Read_Position.TabIndex = 86;
            this.bt_Motor1_Read_Position.Text = "Read Position";
            this.bt_Motor1_Read_Position.UseVisualStyleBackColor = false;
            this.bt_Motor1_Read_Position.Click += new System.EventHandler(this.bt_Motor1_Read_Position_Click);
            // 
            // lb_Motor1_Position
            // 
            this.lb_Motor1_Position.AutoSize = true;
            this.lb_Motor1_Position.Location = new System.Drawing.Point(119, 6);
            this.lb_Motor1_Position.Name = "lb_Motor1_Position";
            this.lb_Motor1_Position.Size = new System.Drawing.Size(44, 13);
            this.lb_Motor1_Position.TabIndex = 87;
            this.lb_Motor1_Position.Text = "Position";
            // 
            // label_Temperature_scale_factor
            // 
            this.label_Temperature_scale_factor.AutoSize = true;
            this.label_Temperature_scale_factor.Enabled = false;
            this.label_Temperature_scale_factor.Location = new System.Drawing.Point(857, 630);
            this.label_Temperature_scale_factor.Name = "label_Temperature_scale_factor";
            this.label_Temperature_scale_factor.Size = new System.Drawing.Size(125, 13);
            this.label_Temperature_scale_factor.TabIndex = 28;
            this.label_Temperature_scale_factor.Text = "Temperature scale factor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_Motor1_Save_Setting);
            this.panel1.Controls.Add(this.lb_Motor1_Acceleration);
            this.panel1.Controls.Add(this.lb_Motor1_Deacceleration);
            this.panel1.Controls.Add(this.lb_Motor1_distance);
            this.panel1.Controls.Add(this.lb_Motor1_Position);
            this.panel1.Location = new System.Drawing.Point(12, 700);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 134);
            this.panel1.TabIndex = 88;
            // 
            // bt_Motor2_Read_Position
            // 
            this.bt_Motor2_Read_Position.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Motor2_Read_Position.Enabled = false;
            this.bt_Motor2_Read_Position.Location = new System.Drawing.Point(349, 773);
            this.bt_Motor2_Read_Position.Name = "bt_Motor2_Read_Position";
            this.bt_Motor2_Read_Position.Size = new System.Drawing.Size(100, 25);
            this.bt_Motor2_Read_Position.TabIndex = 90;
            this.bt_Motor2_Read_Position.Text = "Read Position";
            this.bt_Motor2_Read_Position.UseVisualStyleBackColor = false;
            this.bt_Motor2_Read_Position.Click += new System.EventHandler(this.bt_Motor2_Read_Position_Click);
            // 
            // bt_Motor2_Set_Zero
            // 
            this.bt_Motor2_Set_Zero.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Motor2_Set_Zero.Enabled = false;
            this.bt_Motor2_Set_Zero.Location = new System.Drawing.Point(349, 804);
            this.bt_Motor2_Set_Zero.Name = "bt_Motor2_Set_Zero";
            this.bt_Motor2_Set_Zero.Size = new System.Drawing.Size(100, 25);
            this.bt_Motor2_Set_Zero.TabIndex = 89;
            this.bt_Motor2_Set_Zero.Text = "Set Zero";
            this.bt_Motor2_Set_Zero.UseVisualStyleBackColor = false;
            this.bt_Motor2_Set_Zero.Click += new System.EventHandler(this.bt_Motor2_Set_Zero_Click);
            // 
            // lb_Motor2_Position
            // 
            this.lb_Motor2_Position.AutoSize = true;
            this.lb_Motor2_Position.Location = new System.Drawing.Point(120, 6);
            this.lb_Motor2_Position.Name = "lb_Motor2_Position";
            this.lb_Motor2_Position.Size = new System.Drawing.Size(44, 13);
            this.lb_Motor2_Position.TabIndex = 92;
            this.lb_Motor2_Position.Text = "Position";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lb_Motor2_Acceleration);
            this.panel2.Controls.Add(this.lb_Motor2_Deacceleration);
            this.panel2.Controls.Add(this.lb_Motor2_distance);
            this.panel2.Controls.Add(this.lb_Motor2_Position);
            this.panel2.Controls.Add(this.lb_Motor2_Velocity);
            this.panel2.Location = new System.Drawing.Point(345, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 134);
            this.panel2.TabIndex = 93;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Motor2_Distancereal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Motor2_Deaccelerationreal);
            this.panel3.Controls.Add(this.Motor2_Positionreal);
            this.panel3.Controls.Add(this.Motor2_Accelerationreal);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Motor2_Velocityreal);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 134);
            this.panel3.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Acceleration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Deacceleration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Distance";
            // 
            // Motor2_Distancereal
            // 
            this.Motor2_Distancereal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor2_Distancereal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor2_Distancereal.Enabled = false;
            this.Motor2_Distancereal.Location = new System.Drawing.Point(205, 107);
            this.Motor2_Distancereal.Name = "Motor2_Distancereal";
            this.Motor2_Distancereal.Size = new System.Drawing.Size(100, 20);
            this.Motor2_Distancereal.TabIndex = 73;
            this.Motor2_Distancereal.Text = "32";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Position";
            // 
            // Motor2_Deaccelerationreal
            // 
            this.Motor2_Deaccelerationreal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor2_Deaccelerationreal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor2_Deaccelerationreal.Enabled = false;
            this.Motor2_Deaccelerationreal.Location = new System.Drawing.Point(205, 82);
            this.Motor2_Deaccelerationreal.Name = "Motor2_Deaccelerationreal";
            this.Motor2_Deaccelerationreal.Size = new System.Drawing.Size(100, 20);
            this.Motor2_Deaccelerationreal.TabIndex = 79;
            this.Motor2_Deaccelerationreal.Text = "720";
            // 
            // Motor2_Positionreal
            // 
            this.Motor2_Positionreal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Motor2_Positionreal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor2_Positionreal.Location = new System.Drawing.Point(205, 4);
            this.Motor2_Positionreal.Name = "Motor2_Positionreal";
            this.Motor2_Positionreal.ReadOnly = true;
            this.Motor2_Positionreal.Size = new System.Drawing.Size(100, 20);
            this.Motor2_Positionreal.TabIndex = 91;
            // 
            // Motor2_Accelerationreal
            // 
            this.Motor2_Accelerationreal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor2_Accelerationreal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor2_Accelerationreal.Enabled = false;
            this.Motor2_Accelerationreal.Location = new System.Drawing.Point(205, 56);
            this.Motor2_Accelerationreal.Name = "Motor2_Accelerationreal";
            this.Motor2_Accelerationreal.Size = new System.Drawing.Size(100, 20);
            this.Motor2_Accelerationreal.TabIndex = 54;
            this.Motor2_Accelerationreal.Text = "720";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Velocity";
            // 
            // Motor2_Velocityreal
            // 
            this.Motor2_Velocityreal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Motor2_Velocityreal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor2_Velocityreal.Enabled = false;
            this.Motor2_Velocityreal.Location = new System.Drawing.Point(205, 30);
            this.Motor2_Velocityreal.Name = "Motor2_Velocityreal";
            this.Motor2_Velocityreal.Size = new System.Drawing.Size(100, 20);
            this.Motor2_Velocityreal.TabIndex = 53;
            this.Motor2_Velocityreal.Text = "120";
            // 
            // bt_Motor3_Read_Position
            // 
            this.bt_Motor3_Read_Position.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Motor3_Read_Position.Enabled = false;
            this.bt_Motor3_Read_Position.Location = new System.Drawing.Point(3, 72);
            this.bt_Motor3_Read_Position.Name = "bt_Motor3_Read_Position";
            this.bt_Motor3_Read_Position.Size = new System.Drawing.Size(100, 25);
            this.bt_Motor3_Read_Position.TabIndex = 95;
            this.bt_Motor3_Read_Position.Text = "Read Position";
            this.bt_Motor3_Read_Position.UseVisualStyleBackColor = false;
            this.bt_Motor3_Read_Position.Click += new System.EventHandler(this.bt_Motor3_Read_Position_Click);
            // 
            // bt_Motor3_Set_Zero
            // 
            this.bt_Motor3_Set_Zero.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Motor3_Set_Zero.Enabled = false;
            this.bt_Motor3_Set_Zero.Location = new System.Drawing.Point(3, 104);
            this.bt_Motor3_Set_Zero.Name = "bt_Motor3_Set_Zero";
            this.bt_Motor3_Set_Zero.Size = new System.Drawing.Size(100, 25);
            this.bt_Motor3_Set_Zero.TabIndex = 94;
            this.bt_Motor3_Set_Zero.Text = "Set Zero";
            this.bt_Motor3_Set_Zero.UseVisualStyleBackColor = false;
            this.bt_Motor3_Set_Zero.Click += new System.EventHandler(this.bt_Motor3_Set_Zero_Click);
            // 
            // lb_Motor3_Position
            // 
            this.lb_Motor3_Position.AutoSize = true;
            this.lb_Motor3_Position.Location = new System.Drawing.Point(122, 6);
            this.lb_Motor3_Position.Name = "lb_Motor3_Position";
            this.lb_Motor3_Position.Size = new System.Drawing.Size(44, 13);
            this.lb_Motor3_Position.TabIndex = 96;
            this.lb_Motor3_Position.Text = "Position";
            // 
            // Motor3_Position
            // 
            this.Motor3_Position.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Motor3_Position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Motor3_Position.Location = new System.Drawing.Point(205, 4);
            this.Motor3_Position.Name = "Motor3_Position";
            this.Motor3_Position.ReadOnly = true;
            this.Motor3_Position.Size = new System.Drawing.Size(100, 20);
            this.Motor3_Position.TabIndex = 97;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Motor3_Position);
            this.panel5.Controls.Add(this.lb_Motor3_Deacceleration);
            this.panel5.Controls.Add(this.lb_Motor3_distance);
            this.panel5.Controls.Add(this.bt_Motor3_Set_Zero);
            this.panel5.Controls.Add(this.lb_Motor3_Position);
            this.panel5.Controls.Add(this.bt_Motor3_Read_Position);
            this.panel5.Controls.Add(this.bt_Motor3_Save_Setting);
            this.panel5.Controls.Add(this.lb_Motor3_Velocity);
            this.panel5.Controls.Add(this.lb_Motor3_Acceleration);
            this.panel5.Location = new System.Drawing.Point(678, 700);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 134);
            this.panel5.TabIndex = 90;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lb_Micronitor
            // 
            this.lb_Micronitor.AutoSize = true;
            this.lb_Micronitor.Enabled = false;
            this.lb_Micronitor.Location = new System.Drawing.Point(913, 944);
            this.lb_Micronitor.Name = "lb_Micronitor";
            this.lb_Micronitor.Size = new System.Drawing.Size(80, 13);
            this.lb_Micronitor.TabIndex = 94;
            this.lb_Micronitor.Text = "Micronitor 2016";
            // 
            // cb_Toggle_in_on_direction
            // 
            this.cb_Toggle_in_on_direction.AutoSize = true;
            this.cb_Toggle_in_on_direction.Location = new System.Drawing.Point(12, 867);
            this.cb_Toggle_in_on_direction.Name = "cb_Toggle_in_on_direction";
            this.cb_Toggle_in_on_direction.Size = new System.Drawing.Size(156, 17);
            this.cb_Toggle_in_on_direction.TabIndex = 96;
            this.cb_Toggle_in_on_direction.Text = "Toggle in one direction only";
            this.cb_Toggle_in_on_direction.UseVisualStyleBackColor = true;
            this.cb_Toggle_in_on_direction.CheckedChanged += new System.EventHandler(this.cb_Toggle_in_on_direction_CheckedChanged);
            // 
            // bt_Motor1_Setup
            // 
            this.bt_Motor1_Setup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Motor1_Setup.Enabled = false;
            this.bt_Motor1_Setup.Location = new System.Drawing.Point(372, 945);
            this.bt_Motor1_Setup.Name = "bt_Motor1_Setup";
            this.bt_Motor1_Setup.Size = new System.Drawing.Size(100, 25);
            this.bt_Motor1_Setup.TabIndex = 35;
            this.bt_Motor1_Setup.Text = "Motor1 Setup";
            this.bt_Motor1_Setup.UseVisualStyleBackColor = false;
            this.bt_Motor1_Setup.Visible = false;
            this.bt_Motor1_Setup.Click += new System.EventHandler(this.bt_Motor1_Setup_Click);
            // 
            // cb_Textguide
            // 
            this.cb_Textguide.AutoSize = true;
            this.cb_Textguide.Location = new System.Drawing.Point(176, 867);
            this.cb_Textguide.Name = "cb_Textguide";
            this.cb_Textguide.Size = new System.Drawing.Size(186, 17);
            this.cb_Textguide.TabIndex = 97;
            this.cb_Textguide.Text = "Run distances defined in guide.txt";
            this.cb_Textguide.UseVisualStyleBackColor = true;
            this.cb_Textguide.CheckedChanged += new System.EventHandler(this.cb_Textguide_CheckedChanged);
            // 
            // Interfacer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1007, 970);
            this.Controls.Add(this.cb_Textguide);
            this.Controls.Add(this.cb_Toggle_in_on_direction);
            this.Controls.Add(this.lb_Micronitor);
            this.Controls.Add(this.Motor3_Deacceleration);
            this.Controls.Add(this.Motor3_Distance);
            this.Controls.Add(this.cb_Motor3_Enabled);
            this.Controls.Add(this.Motor3_Status);
            this.Controls.Add(this.Motor3_Acceleration);
            this.Controls.Add(this.Motor3_Velocity);
            this.Controls.Add(this.lb_Motor_Controller3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.bt_Motor2_Read_Position);
            this.Controls.Add(this.bt_Motor2_Set_Zero);
            this.Controls.Add(this.cb_Motor2_Enabled);
            this.Controls.Add(this.Motor2_Status);
            this.Controls.Add(this.bt_Motor2_Save_Setting);
            this.Controls.Add(this.lb_Motor_Controller2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_Motor1_Read_Position);
            this.Controls.Add(this.Motor1_Position);
            this.Controls.Add(this.bt_Motor1_Set_Zero);
            this.Controls.Add(this.Motor1_Deacceleration);
            this.Controls.Add(this.Motor1_Distance);
            this.Controls.Add(this.cb_Motor1_Enabled);
            this.Controls.Add(this.Motor1_Status);
            this.Controls.Add(this.lb_Motor1_Velocity);
            this.Controls.Add(this.Motor1_Acceleration);
            this.Controls.Add(this.Motor1_Velocity);
            this.Controls.Add(this.lb_Motor_Controller1);
            this.Controls.Add(this.bt_Motor1_Setup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Motor3_Setup);
            this.Controls.Add(this.bt_Motor2_Setup);
            this.Controls.Add(this.cb_Logg_Enabled);
            this.Controls.Add(this.lb_Toggle_Delay);
            this.Controls.Add(this.lb_Logging_Period);
            this.Controls.Add(this.Toggle_Delay);
            this.Controls.Add(this.Logging_Period);
            this.Controls.Add(this.bt_Cancel_Logging);
            this.Controls.Add(this.bt_Start_Logging);
            this.Controls.Add(this.LoggProgress);
            this.Controls.Add(this.Sent);
            this.Controls.Add(this.SERCOM_statusbar);
            this.Controls.Add(this.bt_Set_Carrier);
            this.Controls.Add(this.bt_Reload_Carrier_List);
            this.Controls.Add(this.CarrierList);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.lb_Baudrate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comList);
            this.Controls.Add(this.ComStatus);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.Baudrate);
            this.Controls.Add(this.bt_serialConnect);
            this.Controls.Add(this.Carrier_serial_number);
            this.Controls.Add(this.Sensor_A_name);
            this.Controls.Add(this.Sensor_B_name);
            this.Controls.Add(this.Sensor_A_active_sensors);
            this.Controls.Add(this.Sensor_A_installed_bitmap);
            this.Controls.Add(this.Sensor_A_enabled_bitmap);
            this.Controls.Add(this.Sensor_A_faulty_bitmap);
            this.Controls.Add(this.Sensor_B_active_sensors);
            this.Controls.Add(this.Sensor_B_installed_bitmap);
            this.Controls.Add(this.Sensor_B_enabled_bitmap);
            this.Controls.Add(this.Sensor_B_failty_bitmap);
            this.Controls.Add(this.Encoder_offset);
            this.Controls.Add(this.Sensor_A_Raw_data_format);
            this.Controls.Add(this.Sensor_B_Raw_data_format);
            this.Controls.Add(this.Sensor_A_Sample_rate);
            this.Controls.Add(this.Sensor_A_Scale_factor_X);
            this.Controls.Add(this.Sensor_A_Scale_factor_Y);
            this.Controls.Add(this.Sensor_A_Scale_factor_Z);
            this.Controls.Add(this.Sensor_A_SF_Tempco_X);
            this.Controls.Add(this.Sensor_A_SF_Tempco_Y);
            this.Controls.Add(this.Sensor_A_SF_Tempco_Z);
            this.Controls.Add(this.Sensor_A_Offset_X);
            this.Controls.Add(this.Sensor_A_Offset_Y);
            this.Controls.Add(this.Sensor_A_Offset_Z);
            this.Controls.Add(this.Sensor_A_Offset_Tempco_X);
            this.Controls.Add(this.Sensor_A_Offset_Tempco_Y);
            this.Controls.Add(this.Sensor_A_Offset_Tempco_Z);
            this.Controls.Add(this.Sensor_A_Misalign_Alpha);
            this.Controls.Add(this.Sensor_A_Misalign_Beta);
            this.Controls.Add(this.Sensor_A_Misalign_Gamma);
            this.Controls.Add(this.Sensor_B_Sample_rate);
            this.Controls.Add(this.Sensor_B_Scale_factor_X);
            this.Controls.Add(this.Sensor_B_Scale_factor_Y);
            this.Controls.Add(this.Sensor_B_Scale_factor_Z);
            this.Controls.Add(this.Sensor_B_SF_Tempco_X);
            this.Controls.Add(this.Sensor_B_SF_Tempco_Y);
            this.Controls.Add(this.Sensor_B_SF_Tempco_Z);
            this.Controls.Add(this.Sensor_B_Offset_X);
            this.Controls.Add(this.Sensor_B_Offset_Y);
            this.Controls.Add(this.Sensor_B_Offset_Z);
            this.Controls.Add(this.Sensor_B_Offset_Tempco_X);
            this.Controls.Add(this.Sensor_B_Offset_Tempco_Y);
            this.Controls.Add(this.Sensor_B_Offset_Tempco_Z);
            this.Controls.Add(this.Sensor_B_Misalign_Alpha);
            this.Controls.Add(this.Sensor_B_Misalign_Beta);
            this.Controls.Add(this.Sensor_B_Misalign_Gamma);
            this.Controls.Add(this.Temperature_offset);
            this.Controls.Add(this.Temperature_scale_factor);
            this.Controls.Add(this.label_Carrier_serial_number);
            this.Controls.Add(this.label_Sensor_A_name);
            this.Controls.Add(this.label_Sensor_B_name);
            this.Controls.Add(this.label_Sensor_A_active_sensors);
            this.Controls.Add(this.label_Sensor_A_installed_bitmap);
            this.Controls.Add(this.label_Sensor_A_enabled_bitmap);
            this.Controls.Add(this.label_Sensor_A_faulty_bitmap);
            this.Controls.Add(this.label_Sensor_B_active_sensors);
            this.Controls.Add(this.label_Sensor_B_installed_bitmap);
            this.Controls.Add(this.label_Sensor_B_enabled_bitmap);
            this.Controls.Add(this.label_Sensor_B_failty_bitmap);
            this.Controls.Add(this.label_Encoder_offset);
            this.Controls.Add(this.label_Sensor_A_Raw_data_format);
            this.Controls.Add(this.label_Sensor_B_Raw_data_format);
            this.Controls.Add(this.label_Sensor_A_Sample_rate);
            this.Controls.Add(this.label_Sensor_A_Scale_factor_X);
            this.Controls.Add(this.label_Sensor_A_Scale_factor_Y);
            this.Controls.Add(this.label_Sensor_A_Scale_factor_Z);
            this.Controls.Add(this.label_Sensor_A_SF_Tempco_X);
            this.Controls.Add(this.label_Sensor_A_SF_Tempco_Y);
            this.Controls.Add(this.label_Sensor_A_SF_Tempco_Z);
            this.Controls.Add(this.label_Sensor_A_Offset_X);
            this.Controls.Add(this.label_Sensor_A_Offset_Y);
            this.Controls.Add(this.label_Sensor_A_Offset_Z);
            this.Controls.Add(this.label_Sensor_A_Offset_Tempco_X);
            this.Controls.Add(this.label_Sensor_A_Offset_Tempco_Y);
            this.Controls.Add(this.label_Sensor_A_Offset_Tempco_Z);
            this.Controls.Add(this.label_Sensor_A_Misalign_Alpha);
            this.Controls.Add(this.label_Sensor_A_Misalign_Beta);
            this.Controls.Add(this.label_Sensor_A_Misalign_Gamma);
            this.Controls.Add(this.label_Sensor_B_Sample_rate);
            this.Controls.Add(this.label_Sensor_B_Scale_factor_X);
            this.Controls.Add(this.label_Sensor_B_Scale_factor_Y);
            this.Controls.Add(this.label_Sensor_B_Scale_factor_Z);
            this.Controls.Add(this.label_Sensor_B_SF_Tempco_X);
            this.Controls.Add(this.label_Sensor_B_SF_Tempco_Y);
            this.Controls.Add(this.label_Sensor_B_SF_Tempco_Z);
            this.Controls.Add(this.label_Sensor_B_Offset_X);
            this.Controls.Add(this.label_Sensor_B_Offset_Y);
            this.Controls.Add(this.label_Sensor_B_Offset_Z);
            this.Controls.Add(this.label_Sensor_B_Offset_Tempco_X);
            this.Controls.Add(this.label_Sensor_B_Offset_Tempco_Y);
            this.Controls.Add(this.label_Sensor_B_Offset_Tempco_Z);
            this.Controls.Add(this.label_Sensor_B_Misalign_Alpha);
            this.Controls.Add(this.label_Sensor_B_Misalign_Beta);
            this.Controls.Add(this.label_Sensor_B_Misalign_Gamma);
            this.Controls.Add(this.label_Temperature_offset);
            this.Controls.Add(this.label_Temperature_scale_factor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interfacer";
            this.Text = "Testbench Interfacer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Interfacer_FormClosing);
            this.Load += new System.EventHandler(this.Interfacer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_serialConnect;
        private System.Windows.Forms.TextBox Baudrate;
        private System.Windows.Forms.TextBox sendMessage;
        //private System.Windows.Forms.TextBox Carrier_Serial_number;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.RichTextBox ComStatus;
        private System.ComponentModel.BackgroundWorker ReceiveWorker;
        private System.Windows.Forms.ListBox comList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Baudrate;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox CarrierList;
        private System.Windows.Forms.Button bt_Reload_Carrier_List;
        private System.Windows.Forms.Button bt_Set_Carrier;
        private System.ComponentModel.BackgroundWorker SendWorker;

        private System.Windows.Forms.TextBox Carrier_serial_number;
        private System.Windows.Forms.Label label_Carrier_serial_number;
        private System.Windows.Forms.TextBox Sensor_A_name;
        private System.Windows.Forms.Label label_Sensor_A_name;
        private System.Windows.Forms.TextBox Sensor_B_name;
        private System.Windows.Forms.Label label_Sensor_B_name;
        private System.Windows.Forms.TextBox Sensor_A_active_sensors;
        private System.Windows.Forms.Label label_Sensor_A_active_sensors;
        private System.Windows.Forms.TextBox Sensor_A_installed_bitmap;
        private System.Windows.Forms.Label label_Sensor_A_installed_bitmap;
        private System.Windows.Forms.TextBox Sensor_A_enabled_bitmap;
        private System.Windows.Forms.Label label_Sensor_A_enabled_bitmap;
        private System.Windows.Forms.TextBox Sensor_A_faulty_bitmap;
        private System.Windows.Forms.Label label_Sensor_A_faulty_bitmap;
        private System.Windows.Forms.TextBox Sensor_B_active_sensors;
        private System.Windows.Forms.Label label_Sensor_B_active_sensors;
        private System.Windows.Forms.TextBox Sensor_B_installed_bitmap;
        private System.Windows.Forms.Label label_Sensor_B_installed_bitmap;
        private System.Windows.Forms.TextBox Sensor_B_enabled_bitmap;
        private System.Windows.Forms.Label label_Sensor_B_enabled_bitmap;
        private System.Windows.Forms.TextBox Sensor_B_failty_bitmap;
        private System.Windows.Forms.Label label_Sensor_B_failty_bitmap;
        private System.Windows.Forms.TextBox Encoder_offset;
        private System.Windows.Forms.Label label_Encoder_offset;
        private System.Windows.Forms.TextBox Sensor_A_Raw_data_format;
        private System.Windows.Forms.Label label_Sensor_A_Raw_data_format;
        private System.Windows.Forms.TextBox Sensor_B_Raw_data_format;
        private System.Windows.Forms.Label label_Sensor_B_Raw_data_format;
        private System.Windows.Forms.TextBox Sensor_A_Sample_rate;
        private System.Windows.Forms.Label label_Sensor_A_Sample_rate;
        private System.Windows.Forms.TextBox Sensor_A_Scale_factor_X;
        private System.Windows.Forms.Label label_Sensor_A_Scale_factor_X;
        private System.Windows.Forms.TextBox Sensor_A_Scale_factor_Y;
        private System.Windows.Forms.Label label_Sensor_A_Scale_factor_Y;
        private System.Windows.Forms.TextBox Sensor_A_Scale_factor_Z;
        private System.Windows.Forms.Label label_Sensor_A_Scale_factor_Z;
        private System.Windows.Forms.TextBox Sensor_A_SF_Tempco_X;
        private System.Windows.Forms.Label label_Sensor_A_SF_Tempco_X;
        private System.Windows.Forms.TextBox Sensor_A_SF_Tempco_Y;
        private System.Windows.Forms.Label label_Sensor_A_SF_Tempco_Y;
        private System.Windows.Forms.TextBox Sensor_A_SF_Tempco_Z;
        private System.Windows.Forms.Label label_Sensor_A_SF_Tempco_Z;
        private System.Windows.Forms.TextBox Sensor_A_Offset_X;
        private System.Windows.Forms.Label label_Sensor_A_Offset_X;
        private System.Windows.Forms.TextBox Sensor_A_Offset_Y;
        private System.Windows.Forms.Label label_Sensor_A_Offset_Y;
        private System.Windows.Forms.TextBox Sensor_A_Offset_Z;
        private System.Windows.Forms.Label label_Sensor_A_Offset_Z;
        private System.Windows.Forms.TextBox Sensor_A_Offset_Tempco_X;
        private System.Windows.Forms.Label label_Sensor_A_Offset_Tempco_X;
        private System.Windows.Forms.TextBox Sensor_A_Offset_Tempco_Y;
        private System.Windows.Forms.Label label_Sensor_A_Offset_Tempco_Y;
        private System.Windows.Forms.TextBox Sensor_A_Offset_Tempco_Z;
        private System.Windows.Forms.Label label_Sensor_A_Offset_Tempco_Z;
        private System.Windows.Forms.TextBox Sensor_A_Misalign_Alpha;
        private System.Windows.Forms.Label label_Sensor_A_Misalign_Alpha;
        private System.Windows.Forms.TextBox Sensor_A_Misalign_Beta;
        private System.Windows.Forms.Label label_Sensor_A_Misalign_Beta;
        private System.Windows.Forms.TextBox Sensor_A_Misalign_Gamma;
        private System.Windows.Forms.Label label_Sensor_A_Misalign_Gamma;
        private System.Windows.Forms.TextBox Sensor_B_Sample_rate;
        private System.Windows.Forms.Label label_Sensor_B_Sample_rate;
        private System.Windows.Forms.TextBox Sensor_B_Scale_factor_X;
        private System.Windows.Forms.Label label_Sensor_B_Scale_factor_X;
        private System.Windows.Forms.TextBox Sensor_B_Scale_factor_Y;
        private System.Windows.Forms.Label label_Sensor_B_Scale_factor_Y;
        private System.Windows.Forms.TextBox Sensor_B_Scale_factor_Z;
        private System.Windows.Forms.Label label_Sensor_B_Scale_factor_Z;
        private System.Windows.Forms.TextBox Sensor_B_SF_Tempco_X;
        private System.Windows.Forms.Label label_Sensor_B_SF_Tempco_X;
        private System.Windows.Forms.TextBox Sensor_B_SF_Tempco_Y;
        private System.Windows.Forms.Label label_Sensor_B_SF_Tempco_Y;
        private System.Windows.Forms.TextBox Sensor_B_SF_Tempco_Z;
        private System.Windows.Forms.Label label_Sensor_B_SF_Tempco_Z;
        private System.Windows.Forms.TextBox Sensor_B_Offset_X;
        private System.Windows.Forms.Label label_Sensor_B_Offset_X;
        private System.Windows.Forms.TextBox Sensor_B_Offset_Y;
        private System.Windows.Forms.Label label_Sensor_B_Offset_Y;
        private System.Windows.Forms.TextBox Sensor_B_Offset_Z;
        private System.Windows.Forms.Label label_Sensor_B_Offset_Z;
        private System.Windows.Forms.TextBox Sensor_B_Offset_Tempco_X;
        private System.Windows.Forms.Label label_Sensor_B_Offset_Tempco_X;
        private System.Windows.Forms.TextBox Sensor_B_Offset_Tempco_Y;
        private System.Windows.Forms.Label label_Sensor_B_Offset_Tempco_Y;
        private System.Windows.Forms.TextBox Sensor_B_Offset_Tempco_Z;
        private System.Windows.Forms.Label label_Sensor_B_Offset_Tempco_Z;
        private System.Windows.Forms.TextBox Sensor_B_Misalign_Alpha;
        private System.Windows.Forms.Label label_Sensor_B_Misalign_Alpha;
        private System.Windows.Forms.TextBox Sensor_B_Misalign_Beta;
        private System.Windows.Forms.Label label_Sensor_B_Misalign_Beta;
        private System.Windows.Forms.TextBox Sensor_B_Misalign_Gamma;
        private System.Windows.Forms.Label label_Sensor_B_Misalign_Gamma;
        private System.Windows.Forms.TextBox Temperature_offset;
        private System.Windows.Forms.Label label_Temperature_offset;
        private System.Windows.Forms.TextBox Temperature_scale_factor;
        private System.Windows.Forms.ProgressBar SERCOM_statusbar;
        private System.Windows.Forms.TextBox Sent;
        private System.Windows.Forms.ProgressBar LoggProgress;
        private System.Windows.Forms.Button bt_Start_Logging;
        private System.ComponentModel.BackgroundWorker LoggWorker;
        private System.Windows.Forms.Button bt_Cancel_Logging;
        private System.Windows.Forms.Label lb_Motor_Controller1;
        private System.Windows.Forms.TextBox Motor1_Velocity;
        private System.Windows.Forms.TextBox Motor1_Acceleration;
        private System.Windows.Forms.TextBox Logging_Period;
        private System.Windows.Forms.TextBox Toggle_Delay;
        private System.Windows.Forms.Label lb_Logging_Period;
        private System.Windows.Forms.Label lb_Toggle_Delay;
        private System.Windows.Forms.Label lb_Motor1_Velocity;
        private System.Windows.Forms.Label lb_Motor1_Acceleration;
        private System.Windows.Forms.TextBox Motor1_Status;
        private System.Windows.Forms.CheckBox cb_Logg_Enabled;
        private System.Windows.Forms.CheckBox cb_Motor1_Enabled;
        private System.Windows.Forms.CheckBox cb_Motor2_Enabled;
        private System.Windows.Forms.TextBox Motor2_Status;
        private System.Windows.Forms.Label lb_Motor2_Acceleration;
        private System.Windows.Forms.Label lb_Motor2_Velocity;
        private System.Windows.Forms.Button bt_Motor2_Save_Setting;
        //private System.Windows.Forms.TextBox Motor2_Accelerations;
        //private System.Windows.Forms.TextBox Motor2_Velocitys;
        private System.Windows.Forms.Label lb_Motor_Controller2;
        private System.Windows.Forms.Button bt_Motor2_Setup;
        private System.Windows.Forms.CheckBox cb_Motor3_Enabled;
        private System.Windows.Forms.TextBox Motor3_Status;
        private System.Windows.Forms.Label lb_Motor3_Acceleration;
        private System.Windows.Forms.Label lb_Motor3_Velocity;
        private System.Windows.Forms.Button bt_Motor3_Save_Setting;
        private System.Windows.Forms.TextBox Motor3_Acceleration;
        private System.Windows.Forms.TextBox Motor3_Velocity;
        private System.Windows.Forms.Label lb_Motor_Controller3;
        private System.Windows.Forms.Button bt_Motor3_Setup;
        private System.Windows.Forms.Label lb_Motor1_distance;
        private System.Windows.Forms.Label lb_Motor2_distance;
        private System.Windows.Forms.Label lb_Motor3_distance;
        private System.Windows.Forms.TextBox Motor1_Distance;
        //private System.Windows.Forms.TextBox Motor2_Distances;
        private System.Windows.Forms.TextBox Motor3_Distance;
        private System.Windows.Forms.TextBox Motor1_Deacceleration;
        private System.Windows.Forms.Label lb_Motor1_Deacceleration;
        private System.Windows.Forms.Label lb_Motor2_Deacceleration;
        private System.Windows.Forms.Label lb_Motor3_Deacceleration;
        //private System.Windows.Forms.TextBox Motor2_Deaccelerations;
        private System.Windows.Forms.TextBox Motor3_Deacceleration;
        private System.Windows.Forms.Button bt_Motor1_Set_Zero;
        private System.Windows.Forms.TextBox Motor1_Position;
        private System.ComponentModel.BackgroundWorker MotorStatusWorker;
        private System.Windows.Forms.Button bt_Motor1_Read_Position;
        private System.Windows.Forms.Label lb_Motor1_Position;
        private System.Windows.Forms.Label label_Temperature_scale_factor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Motor2_Read_Position;
        private System.Windows.Forms.Button bt_Motor2_Set_Zero;
        //private System.Windows.Forms.TextBox Motor2_Positions;
        private System.Windows.Forms.Label lb_Motor2_Position;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Motor3_Read_Position;
        private System.Windows.Forms.Button bt_Motor3_Set_Zero;
        private System.Windows.Forms.Label lb_Motor3_Position;
        private System.Windows.Forms.TextBox Motor3_Position;
        private System.Windows.Forms.Button bt_Motor1_Save_Setting;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Motor2_Distancereal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Motor2_Deaccelerationreal;
        private System.Windows.Forms.TextBox Motor2_Positionreal;
        private System.Windows.Forms.TextBox Motor2_Accelerationreal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Motor2_Velocityreal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lb_Micronitor;
        private System.Windows.Forms.CheckBox cb_Toggle_in_on_direction;
        private System.Windows.Forms.Button bt_Motor1_Setup;
        private System.Windows.Forms.CheckBox cb_Textguide;
    }
}

