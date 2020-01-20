using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

// Initial structures




namespace D2
{   
   
    public partial class Filesetup : Form
    {
     
        Opboxheader OH = new Opboxheader();
      
       



        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_Get_Power_Info", CallingConvention = CallingConvention.Cdecl)]
        public static extern int op_wrp_Get_Power_Info(int p1);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_OpenOpbox", CallingConvention = CallingConvention.Cdecl)]
        public static extern int op_wrp_OpenOpbox();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_Instr_Restet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int op_wrp_Instr_Restet();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_Instr_RestetFIFO", CallingConvention = CallingConvention.Cdecl)]
        public static extern int op_wrp_Instr_RestetFIFO();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_PowerOnOff", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_PowerOnOff(int p1);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetInfo(ref ushort Info1,ref ushort Info2);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetDepth", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetDepth(int depth);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetSamplingFreq", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetSamplingFreq(double sampling_freq);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetDataMode", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetDataMode(int raw_abs);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetDelay", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetDelay(int delay);



        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetAnalogFilter", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetAnalogFilter(int analoig_filter);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetPreAmp", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetPreAmp(int option);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetSource", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetSource(int source);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetTimerperiod", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetTimerperiod(double timer);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetXYDivider", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetXYDivider(int value);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_PDEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_PDEnable(int nr, int enable_disable);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_PDmode", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_PDmode(int nr, int mode);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetGain", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetGain(int gain);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetGainMode", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetGainMode(int gainM);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetAmplitude", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetAmplitude(int Amp);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetPulserTime", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetPulserTime(int pulser_time, int driver_enable);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetVersion", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetVersion(ref char version);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetPDStartStopLevel", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetPDStartStopLevel(int start, int stop, int level, int nr);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetEncoder", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetEncoder(int option, int mN, int step, int nr);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetDepth", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetDepth();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_CloseOpbox", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_CloseOpbox();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetDelay", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetDelay();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetAnalog", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetAnalog();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetGain", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetGain();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetPulserTime", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetPulserTime(int pulser_time, int driver_enable);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_SetTriggerSource", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_SetTriggerSource(int option);


        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetTimerperion", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetTimerperion();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetXYDivider", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetXYDivider(int var);


        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetEncoder", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetEncoder(int option, int mN, int step, int nr);


        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_TrigEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_TrigEnable(int yes_no);

      


        
        struct opbox_init_structure
        {
            public int powerCheck;
            public int powerControl;
            public ushort info1;
            public ushort info2;
            public char version;
        };

        struct plot_structure
        {
            public int delay_in_smpls;
            public int window_in_smpls;
            public double sampling_freq_real;
            public double min_x;
            public double max_x;
            public double min_y;
            public double max_y;
            public int plot_data_size;
            public int plot_algorithm;
        };

        struct acquisition_parameters
        {
            public int sampling_freq;
            public int mode;
            public double window;
            public double delay;
        };


        struct amplifier_parameters
        {
            public int filter_bandtwidth;
            public int preamplifier;
            public int input_source;
            public int gain;
            public int gain_mode;
        };


        // Pulser
        struct pulser_parameters
        {
            public int amplitude_level;
            public float charging_time;
            public int enable;
        };

        struct trigger_parameters
        {
            public int trigger_source;
            public double timer_period;
            public int xy_divider;
        };


        struct peak_detector_parameters
        {
            public int enable;
            public int mode;
            public double ref_pos;
            public double peak_ampl;
            public double peak_pos;
            public int ref_pos_opbox;
            public int max_val_opbox;
            public int max_pos_opbox;
            public int user_error;
        };

        struct peak_detector_helpers
        {

            // Arrays containing positions of PDs in OPBOX manner
            public float pd_posX1_opbox;
            public float pd_posX2_opbox;
            public float pd_posY_opbox;

            // Arrays containing positions of PDs as real values
            public float pd_posX1_plot;
            public float pd_posX2_plot;
            public float pd_posY_plot;

            // Contains information about relative positions of Peak Detector points
            public float pd_posX1_rel;
            public float pd_posX2_rel;
            public float pd_posY_rel;

            // PD Positions sorted by peak detectors for DataBindXY
            public float pda_X_plot;
            public float pda_Y_plot;
            public float pdb_X_plot;
            public float pdb_Y_plot;
            public float pdc_X_plot;
            public float pdc_Y_plot;
        };


        opbox_init_structure einit = new opbox_init_structure();
        plot_structure plot = new plot_structure();
        acquisition_parameters acq = new acquisition_parameters();
        amplifier_parameters ampl = new amplifier_parameters();
        pulser_parameters puls = new pulser_parameters();
        trigger_parameters trig = new trigger_parameters();
        peak_detector_parameters pda = new peak_detector_parameters();
        peak_detector_parameters pdb = new peak_detector_parameters();
        peak_detector_parameters pdc = new peak_detector_parameters();

        peak_detector_helpers pd = new peak_detector_helpers();

        private int initError;

        public int errorCode { get; private set; }




        public Filesetup()
        {
            InitializeComponent();
        }
       
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }




        private void name_txt_Enter(object sender, EventArgs e)
        {
            if(name_txt.Text=="Enter Name")
            {
                name_txt.Text = "";
                name_txt.ForeColor = Color.Black;
            }
        }

        private void name_txt_Leave(object sender, EventArgs e)
        {
            if (name_txt.Text == "")
            {
                name_txt.Text = "Enter Name";
                name_txt.ForeColor = Color.Silver;
            }
        }

      
     
        private void name_txt_Leave_1(object sender, EventArgs e)
        {
            if (name_txt.Text == "")
            {
                name_txt.Text = "Enter Name";
                name_txt.ForeColor = Color.Silver;
            }
        }

        private void stave_txt_Enter(object sender, EventArgs e)
        {
            if (stave_txt.Text == "No. of Stave")
            {
               stave_txt.Text = "";
               stave_txt.ForeColor = Color.Black;
            }
        }

        private void stave_txt_Leave(object sender, EventArgs e)
        {
            if (stave_txt.Text == "")
            {
                stave_txt.Text = "No. of Stave";
                stave_txt.ForeColor = Color.Silver;
            }
        }

        private void length_stave_txt_Enter(object sender, EventArgs e)
        {
            if (length_stave_txt.Text == "Length of Stave")
            {
                length_stave_txt.Text = "";
                length_stave_txt.ForeColor = Color.Black;
            }
        }

        private void length_stave_txt_Leave(object sender, EventArgs e)
        {
            if (length_stave_txt.Text == "")
            {
                length_stave_txt.Text = "Length of Stave";
                length_stave_txt.ForeColor = Color.Silver;
            }
        }

        private void angle_txt_Enter(object sender, EventArgs e)
        {
            if (angle_txt.Text == "Angle of Bend")
            {
                angle_txt.Text = "";
                angle_txt.ForeColor = Color.Black;
            }
        }

        private void angle_txt_Leave(object sender, EventArgs e)
        {
            if (angle_txt.Text == "")
            {
                angle_txt.Text = "Angle of Bend";
                angle_txt.ForeColor = Color.Silver;
            }
        }

        private void width_txt_Enter(object sender, EventArgs e)
        {
            if (width_txt.Text == "Width")
            {
                width_txt.Text = "";
                width_txt.ForeColor = Color.Black;
            }
        }

        private void width_txt_Leave(object sender, EventArgs e)
        {
            if (width_txt.Text == "")
            {
                width_txt.Text = "Width";
                width_txt.ForeColor = Color.Silver;
            }
        }

        private void gap_txt_Enter(object sender, EventArgs e)
        {
            if (gap_txt.Text == "Gap")
            {
                gap_txt.Text = "";
                gap_txt.ForeColor = Color.Black;
            }
        }

        private void gap_txt_Leave(object sender, EventArgs e)
        {
            if (gap_txt.Text == "")
            {
                gap_txt.Text = "Gap";
                gap_txt.ForeColor = Color.Silver;
            }
        }

        private void diameter_txt_Enter(object sender, EventArgs e)
        {
            if (diameter_txt.Text == "Diameter of Pipe")
            {
                diameter_txt.Text = "";
                diameter_txt.ForeColor = Color.Black;
            }
        }

        private void diameter_txt_Leave(object sender, EventArgs e)
        {
            if (diameter_txt.Text == "")
            {
                diameter_txt.Text = "Diameter of Pipe";
                diameter_txt.ForeColor = Color.Silver;
            }
        }

        private void channel_txt_Enter(object sender, EventArgs e)
        {
            if (channel_txt.Text == "Diameter of Channel")
            {
                channel_txt.Text = "";
                channel_txt.ForeColor = Color.Black;
            }
        }

        private void channel_txt_Leave(object sender, EventArgs e)
        {
            if (channel_txt.Text == "")
            {
                channel_txt.Text = "Diameter of Channel";
                channel_txt.ForeColor = Color.Silver;
            }
        }

        private void thickness_txt_Enter(object sender, EventArgs e)
        {
            if (thickness_txt.Text == "Thickness")
            {
                thickness_txt.Text = "";
                thickness_txt.ForeColor = Color.Black;
            }
        }

        private void thickness_txt_Leave(object sender, EventArgs e)
        {
            if (thickness_txt.Text == "")
            {
                thickness_txt.Text = "Thickness";
                thickness_txt.ForeColor = Color.Silver;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void Filesetup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {         


        }



        public static string sendtext = "";
       
     

       

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Selectprofile sp = new Selectprofile();
            sp.Show();
            Visible = false;
        }

       

        private void gap_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileFormSave_btn_Click(object sender, EventArgs e)
        {
           
            Filesetupgraph txtval = new Filesetupgraph();
            txtval.Show();           
            Visible = false;
        }

        private void Filesetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a=0;
            int b = 0;
            Opbox op = new Opbox();
            op.initSession();
            op.endSession();
            op.setSamplingFreq(a);
            op.setDataMode(a);
            op.setDepth(a);
            op.setDelay(a);
            op.setAnalogFilter(a);
            op.setPreamplifier(a);
            op.setInputSource(a);
            op.setGain(a);
            op.setGainMode(a);
            op.initEncoders();
            op.setEncEnable(a, b);
            op.setEncInputMode(a, b);
            op.setEncIdxInput(a, b);
            op.setEncDecodeMode(a, b);
            op.setEncFilter(a, b);
            op.setEncComparatorStep(a, b);
            op.setEncComparator(a, b);
            op.setEnc(a);
           

        }

        private void sensor_call_btn_Click(object sender, EventArgs e)
        {
            Sensor sen = new Sensor();           
            sen.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            einit.powerCheck = 0;
            einit.powerControl = 0;
            einit.info1 = 0;
            einit.info2 = 0;
           // einit.version = Convert.ToSByte('1');
            einit.version = '1';

            //plot.sampling_freq_real = 0.0;
            //plot.delay_in_smpls = 0;
            //plot.window_in_smpls = 0;
            //plot.min_x  a;
            //plot.min_y = 0;
            //plot.max_x = 0;
            //plot.max_y = 0;
            //plot.plot_data_size = 0;
            //plot.plot_algorithm = 0;

            acq.sampling_freq = 1;
            acq.mode = 0;
            acq.window = 200.0;
            acq.delay = 0.0;


            plot.delay_in_smpls = (int)(acq.delay * (100.0 / acq.sampling_freq));
            plot.window_in_smpls = (int)(acq.window * (100.0 / acq.sampling_freq));
            plot.sampling_freq_real = (acq.sampling_freq + 1) / 100.0;
            plot.min_x = (float)(acq.delay);
            plot.max_x = (float)(acq.delay + acq.window);
            plot.min_y = -0.5;
            plot.max_y = 0.5;
            plot.plot_data_size = 750;
            plot.plot_algorithm = 0;

            //ampl = {0, 0, 0, 35, 0};
            ampl.filter_bandtwidth = 2;
            ampl.preamplifier = 1;
            ampl.input_source = 0;
            ampl.gain = 45;
            ampl.gain_mode = 0;

            puls.amplitude_level = 16;
            puls.charging_time = (float)3.0;
            puls.enable = 0;

            trig.trigger_source = 0;
            trig.timer_period = 4.0;
            trig.xy_divider = 1;

            //pda = {0, 0, 0.0, 0.0, 0.0, 0, 0, 0};
            pda.enable = 1;
            pda.mode = 0;
            pda.ref_pos = 0.0;
            pda.peak_ampl = 0.0;
            pda.peak_pos = 0.0;
            pda.ref_pos_opbox = 0;
            pda.max_val_opbox = 0;
            pda.max_pos_opbox = 0;
            pda.user_error = 0;


            //pdb = {1, 1, 0.0, 0.0, 0.0, 0, 0, 0};
            pdb.enable = 1;
            pdb.mode = 0;
            pdb.ref_pos = 0.0;
            pdb.peak_ampl = 0.0;
            pdb.peak_pos = 0.0;
            pdb.ref_pos_opbox = 0;
            pdb.max_val_opbox = 0;
            pdb.max_pos_opbox = 0;
            pdb.user_error = 0;

            //pdc = {0, 2, 0.0, 0.0, 0.0, 0, 0, 0};
            pdc.enable = 1;
            pdc.mode = 0;
            pdc.ref_pos = 0.0;
            pdc.peak_ampl = 0.0;
            pdc.peak_pos = 0.0;
            pdc.ref_pos_opbox = 0;
            pdc.max_val_opbox = 0;
            pdc.max_pos_opbox = 0;
            pdc.user_error = 0;


            pd.pd_posX1_opbox = Convert.ToInt32(3);// new float[3];
            pd.pd_posX2_opbox = Convert.ToInt32(3);
            pd.pd_posY_opbox = Convert.ToInt32(3);

            pd.pd_posX1_plot = Convert.ToInt32(3);
            pd.pd_posX2_plot = Convert.ToInt32(3);
            pd.pd_posY_plot = Convert.ToInt32(3);

            pd.pd_posX1_rel = Convert.ToInt32(3);
            pd.pd_posX2_rel = Convert.ToInt32(3);
            pd.pd_posY_rel = Convert.ToInt32(3);

            pd.pda_X_plot = Convert.ToInt32(2);
            pd.pda_Y_plot = Convert.ToInt32(2);
            pd.pdb_X_plot = Convert.ToInt32(2);
            pd.pdb_Y_plot = Convert.ToInt32(2);
            pd.pdc_X_plot = Convert.ToInt32(2);
            pd.pdc_Y_plot = Convert.ToInt32(2);

            // Peak detectors' initial positions on plot
            //pd.pd_posX1_plot[0] = 20.0;
            //pd.pd_posX1_plot[1] = (float)120.0;
            //pd.pd_posX1_plot[2] = (float)70.0;

            //pd.pd_posX2_plot[0] = (float)80.0;
            //pd.pd_posX2_plot[1] = (float)180.0;
            //pd.pd_posX2_plot[2] = (float)130.0;

            //pd.pd_posY_plot[0] = (float)0.25;
            //pd.pd_posY_plot[1] = (float)-0.35;
            //pd.pd_posY_plot[2] = (float)-0.05;






            int errorCode = 123;
            int no_of_tries = 5;




            errorCode = 100;
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_OpenOpbox();
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 1;
                //   return initError;
            }
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_Instr_Restet();
                errorCode = op_wrp_Instr_RestetFIFO();
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 3;
                //   return initError;
            }
            einit.powerControl = 1;
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_PowerOnOff(einit.powerControl);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 4;
                //return initError;
            }
            for (int i = 0; i < no_of_tries; i++)
            {
                einit.powerCheck = op_wrp_Get_Power_Info(einit.powerControl);
                if (einit.powerCheck >= 1)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (einit.powerCheck < 1)
            {
                initError = 5;
                //return initError;
            }

            if (errorCode != 0)
            {
                initError = 6;
                //  return initError;
            }


            // Set up some parameters in OPBOX based on predefined variables

            // Acquisition parameters
            // Get version of device:
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_GetInfo(ref einit.info2,ref einit.info1);
                errorCode = op_wrp_GetVersion( ref einit.version);
              
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 100;
                //  return initError;
            }
            // Sampling frequency
            plot.sampling_freq_real = (100.0 / (double)(acq.sampling_freq + 1) * 10.0) / 10.0; //rounding!
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetSamplingFreq(plot.sampling_freq_real);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 100;
                //  return initError;
            }

            // Acquisition mode
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetDataMode(acq.mode);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 101;
                // return initError;
            }

            // Window
            plot.window_in_smpls = (int)Math.Round(plot.sampling_freq_real * acq.window);
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetDepth(plot.window_in_smpls);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 102;
                //   return initError;
            }

            // Delay 
            plot.delay_in_smpls = (int)Math.Round(plot.sampling_freq_real * acq.delay);
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetDelay(plot.delay_in_smpls);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 103;
                //   return initError;
            }

            // Amplification parameters

            //Filter bandtwidth
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetAnalogFilter(ampl.filter_bandtwidth);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 104;
                //   return initError;
            }

            //Preamplifier
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetPreAmp(ampl.preamplifier);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 104;
                //   return initError;
            }

            //Input source
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetSource(ampl.input_source);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 104;
                //    return initError;
            }


            //Gain
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetGain(ampl.gain);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 105;
                //    return initError;
            }

            //Gain mode
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetGainMode(ampl.gain_mode);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 106;
                //   return initError;
            }

            // Pulser parameters

            // Amplitude level
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetAmplitude(puls.amplitude_level);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 107;
                //   return initError;
            }

            // Charging time in us
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetPulserTime((int)(10 * puls.charging_time), puls.enable);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 108;
                System.Threading.Thread.Sleep(50);
            }


            //// Trigger parameters

            // Trigger source
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetSource(trig.trigger_source);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 109;
                //   return initError;
            }

            // Timer period
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetTimerperiod(trig.timer_period);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 110;
                //    return initError;
            }

            // XY divider
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetXYDivider(trig.xy_divider);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 111;
                //   return initError;
            }

            // Peak detector parameters - PDA

            // Enable
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_PDEnable(0, pda.enable);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 112;
                //  return initError;
            }

            // Mode
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_PDmode(0, pda.mode);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 113;
                //   return initError;
            }

            // Parameters (start / stop / level)
            //OB.setPdStartStopLevel(pd.pd_posX1_opbox[0], OB.pd.pd_posX2_opbox[0],OB.pd.pd_posY_opbox[0], 0);


            // Peak detector parameters - PDB

            // Enable
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_PDEnable(1, pdb.enable);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 112;
                //   return initError;
            }

            // Mode
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_PDmode(1, pdb.mode);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 113;
                //  return initError;
            }

            // Parameters (start / stop / level)
            //     Opbox.setPdStartStopLevel(pd.pd_posX1_opbox[1], pd.pd_posX2_opbox[1], pd.pd_posY_opbox[1], 1);


            // Peak detector parameters - PDC

            // Enable
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_PDEnable(2, pdc.enable);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 112;
                //  return initError;
            }

            // Mode
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_PDmode(2, pdc.mode);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 113;
                // return initError;
            }








        }

        private void button4_Click(object sender, EventArgs e)
        {
           
         
        }
    }
}
