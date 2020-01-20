using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using RGiesecke.DllExport;

namespace D2
{
   public class Opbox
    {
        // Constructor - contains initial parameters for OPBOX
      
        datastructs ds = new datastructs();


        public datastructs.plot_structure plot = new datastructs.plot_structure();


        public datastructs.acquisition_parameters acq = new datastructs.acquisition_parameters();
        public datastructs.amplifier_parameters ampl = new datastructs.amplifier_parameters();
        public datastructs.pulser_parameters puls = new datastructs.pulser_parameters();
        public datastructs.trigger_parameters trig = new datastructs.trigger_parameters();

        // Peak detectors
        public datastructs.peak_detector_parameters pda = new datastructs.peak_detector_parameters();
        public datastructs.peak_detector_parameters pdb = new datastructs.peak_detector_parameters();
        public datastructs.peak_detector_parameters pdc = new datastructs.peak_detector_parameters();
        public datastructs.peak_detector_helpers pd = new datastructs.peak_detector_helpers();

        // Encoders
        public datastructs.encoder_parameters enca = new datastructs.encoder_parameters();
        public datastructs.encoder_parameters encb = new datastructs.encoder_parameters();

        // Additional parameters necessary to manage OPBOX session
        //  public datastructs.plot_structure plot = new datastructs.plot_structure();
        public datastructs.data_structure data = new datastructs.data_structure();
        public datastructs.opbox_init_structure init = new datastructs.opbox_init_structure();


        // Checked parameter names, which is used in the following notation for functions
        //C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
        public enum check_option { };
        //C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
        public enum peak_detectors { };
        //C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
        public enum Encoders { };

        // Restrictions for values
        //  double min_value[6];
        public double[] min_value = new double[6];
        public double[] max_value = new double[6];
        public int[] digits_of_precision = new int[6];

        // Error code for error control checkout
        public int errorCode;

        // Number of attempts that methods of class will make to set correct value in OPBOX
        public int no_of_tries;
        internal int enc_a;
        internal int enc_b;



                          

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_Get_Power_Info", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_Get_Power_Info(int p1);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_OpenOpbox", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_OpenOpbox();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_Instr_Restet", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_Instr_Restet();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_Instr_RestetFIFO", CallingConvention = CallingConvention.StdCall)]
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
        public static extern int op_wrp_GetPulserTime(int pulser_time,int driver_enable);

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






        // public datastructs.check_option check = datastructs.check_option.window;

        //public static datastructs.check_option window = new datastructs.check_option();

        //public static datastructs.check_option delay = new datastructs.check_option();

        //public static datastructs.check_option gain = new datastructs.check_option();

        //public static datastructs.check_option charging_time = new datastructs.check_option();

        //public static datastructs.check_option timer_period = new datastructs.check_option();

        //public static datastructs.check_option comp_step = new datastructs.check_option();

        public  Opbox()
{



            //   datastructs.check_option check = datastructs.check_option.window;


            ds.check_optionProperty = datastructs.check_option.window;
            ds.check_optionProperty = datastructs.check_option.delay;
            ds.check_optionProperty = datastructs.check_option.gain;
            ds.check_optionProperty = datastructs.check_option.charging_time;
            ds.check_optionProperty = datastructs.check_option.timer_period;
            ds.check_optionProperty = datastructs.check_option.comp_step;





            ds.encodersProperty = datastructs.encoders.enc_a;
            ds.encodersProperty = datastructs.encoders.enc_b;
            // ds.check_option mode = ds.check_option.window;
            // Initial restrictions for our plot - whatever we switch, we must either
            // modify these restrictictions or obey them


          

            min_value[datastructs.check_option.window.GetHashCode()] = 1.0; // For smpl_freq = 100 MHz; recalc: min = 1 / (plot.sampling_freq_real);
            min_value[datastructs.check_option.delay.GetHashCode()] = 0.0;
            min_value[datastructs.check_option.gain.GetHashCode()] = -28.0;
            min_value[datastructs.check_option.charging_time.GetHashCode()] = 0.0;
            min_value[datastructs.check_option.timer_period.GetHashCode()] = 0.01;
            min_value[datastructs.check_option.comp_step.GetHashCode()] = 1.0;

            max_value[datastructs.check_option.window.GetHashCode()] = 2620.9; // For smpl_freq = 100 MHz; recalc: max = 262090 / (plot.sampling_freq_real);
            max_value[datastructs.check_option.delay.GetHashCode()] = 655.35; // For smpl_freq = 100 MHz; recalc: max = 65535 / (plot.sampling_freq_real);
            max_value[datastructs.check_option.gain.GetHashCode()] = 68.0;
            max_value[datastructs.check_option.charging_time.GetHashCode()] = 6.3;
            max_value[datastructs.check_option.timer_period.GetHashCode()] = 100.0;
            max_value[datastructs.check_option.comp_step.GetHashCode()] = 255.0;

            digits_of_precision[datastructs.check_option.window.GetHashCode()] = 2; // For smpl_freq = 100 MHz; recalc: 2 for 100 MHz, else its equal to 1
            digits_of_precision[datastructs.check_option.delay.GetHashCode()] = 2; // For smpl_freq = 100 MHz; recalc: 2 for 100 MHz, else its equal to 1
            digits_of_precision[datastructs.check_option.gain.GetHashCode()] = 0;
            digits_of_precision[datastructs.check_option.charging_time.GetHashCode()] = 1;
            digits_of_precision[datastructs.check_option.timer_period.GetHashCode()] = 2;
            digits_of_precision[datastructs.check_option.comp_step.GetHashCode()] = 1;

            ////acq = {0, 0, 100.0, 5.0}
            acq.sampling_freq = 1;
            acq.mode = 0;
            acq.window = 200.0D;
            acq.delay = 0.0D;

            ////ampl = {0, 0, 0, 35, 0};
            ampl.filter_bandtwidth = 2;
            ampl.preamplifier = 1;
            ampl.input_source = 0;
            ampl.gain = 45;
            ampl.gain_mode = 0;

            ////puls = {0, 6.4, 0};
            puls.amplitude_level = 16;
            puls.charging_time = 3.0F;
            puls.enable = 0;

            ////trig = {0, 5.5, 0};
            trig.trigger_source = 0;
            trig.timer_period = 4.0;
            trig.xy_divider = 1;

            ////pda = {0, 0, 0.0, 0.0, 0.0, 0, 0, 0};
            pda.enable = 1;
            pda.mode = 0;
            pda.ref_pos = 0.0D;
            pda.peak_ampl = 0.0D;
            pda.peak_pos = 0.0D;
            pda.ref_pos_opbox = 0;
            pda.max_val_opbox = 0;
            pda.max_pos_opbox = 0;
            pda.user_error = 0;

            ////pdb = {1, 1, 0.0, 0.0, 0.0, 0, 0, 0};
            pdb.enable = 1;
            pdb.mode = 0;
            pdb.ref_pos = 0.0D;
            pdb.peak_ampl = 0.0D;
            pdb.peak_pos = 0.0D;
            pdb.ref_pos_opbox = 0;
            pdb.max_val_opbox = 0;
            pdb.max_pos_opbox = 0;
            pdb.user_error = 0;

            ////pdc = {0, 2, 0.0, 0.0, 0.0, 0, 0, 0};
            pdc.enable = 1;
            pdc.mode = 0;
            pdc.ref_pos = 0.0D;
            pdc.peak_ampl = 0.0D;
            pdc.peak_pos = 0.0D;
            pdc.ref_pos_opbox = 0;
            pdc.max_val_opbox = 0;
            pdc.max_pos_opbox = 0;
            pdc.user_error = 0;

            ////pd helpers
            pd.pd_posX1_opbox = new float[3]; 
            pd.pd_posX2_opbox = new float[3];
            pd.pd_posY_opbox = new float[3];

            pd.pd_posX1_plot = new float[3];
            pd.pd_posX2_plot = new float[3];
            pd.pd_posY_plot = new float[3];

            pd.pd_posX1_rel = new float[3];
            pd.pd_posX2_rel = new float[3];
            pd.pd_posY_rel = new float[3];


            pd.pda_X_plot = new float[2];
            pd.pda_Y_plot = new float[2];
            pd.pdb_X_plot = new float[2];
            pd.pdb_Y_plot = new float[2];
            pd.pdc_X_plot = new float[2];
            pd.pdc_Y_plot = new float[2];


        

            // Peak detectors' initial positions on plot
            pd.pd_posX1_plot[0] = 20.0F;
            pd.pd_posX1_plot[1] = 120.0F;
			pd.pd_posX1_plot[2] = 70.0F;

			pd.pd_posX2_plot[0] = 80.0F;
	        pd.pd_posX2_plot[1] = 180.0F;
            pd.pd_posX2_plot[2] = 130.0F;

            pd.pd_posY_plot[0] = 0.25F;
            pd.pd_posY_plot[1] = -0.35F;
            pd.pd_posY_plot[2] = -0.05F;

	// Calculate the rest of array values
	        refreshPDArrays();
	        convertPDToOpbox();

	//enca = {0, 0, 0, 0, 0, 1, 0};
			enca.enable = 0;
            enca.input_mode = 0;
            enca.idx_input = 0;
            enca.decode_mode = 0;
            enca.filter = 0;
            enca.comp_step = 1;
            enca.comparator = 1;

            //encb = {1, 1, 1, 2, 1, 1, 1};
            encb.enable = 0;
            encb.input_mode = 0;
            encb.idx_input = 0;
            encb.decode_mode = 1;
            encb.filter = 1;
            encb.comp_step = 64;
            encb.comparator = 1;

            //plot = {0, 0, 0, ...};
            plot.delay_in_smpls = (int)(acq.delay * (100.0 / acq.sampling_freq));
            plot.window_in_smpls = (int)(acq.window * (100.0 / acq.sampling_freq));
            plot.sampling_freq_real = (acq.sampling_freq + 1) / 100.0;
            plot.min_x = (float)(acq.delay);
            plot.max_x = (float)(acq.delay + acq.window);
            plot.min_y = -0.5F;
            plot.max_y = 0.5F;
            plot.plot_data_size = 750; //20000;
            plot.plot_algorithm = 0;

            //data = {0, 0, 0};
            data.header_size = 54;            // = 54
            data.data_size = 262090;      

            data.data_buffer = new byte[data.header_size + data.data_size];  // Contains all data
            data.main_dataX = new float[plot.window_in_smpls];
            data.main_dataY = new byte[plot.window_in_smpls];
            data.plot_dataX = new float[plot.plot_data_size];
            data.plot_dataY = new float[plot.plot_data_size];
            data.mean_dataY = new byte[plot.plot_data_size];

            //init = {0, 0, 0, 0, 'x'};
            init.powerCheck = 0;
            init.powerControl = 0;
            init.info1 = 0;
            init.info2 = 0;
            init.version = '1';

            errorCode = 123;
            no_of_tries = 5;
}

// Destructor - there is no 'new' assignment, so we don't have to worry about that
~Opbox()
{

            GC.Collect();

            pd.pd_posX1_opbox = null;
            pd.pd_posX2_opbox = null;
            pd.pd_posY_opbox = null;

            pd.pd_posX1_rel = null;
            pd.pd_posX2_rel = null;
            pd.pd_posY_rel = null;

            pd.pda_X_plot = null;
            pd.pda_Y_plot = null;
            pd.pdb_X_plot = null;
            pd.pdb_Y_plot = null;
            pd.pdc_X_plot = null;
            pd.pdc_Y_plot = null;

            // We need to get rid of all pointer arrays - data structures
            data.data_buffer = null;
            data.main_dataX = null;
            data.main_dataY = null;
            data.plot_dataX = null;
            data.plot_dataY = null;
            data.mean_dataY = null;
        }
       
      

        // Function which rounds values to integer precision 



        // Initializing OPBOX, which manages the device: load library DynamicOPBOX, turn on the device, 
        // power it on, initialize all parameters in the device, etc.
        public int  initSession() 
		{

	int initError = 0;
	int no_of_tries = 10;
	errorCode = 100;

	// OPBOX opening
	for (int i = 0; i < no_of_tries; i++) {
		errorCode = op_wrp_OpenOpbox();
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 1;
		return initError;
	}

	// Reset of device if anything has been left after last session
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_Instr_Restet();
                errorCode = op_wrp_Instr_RestetFIFO();
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 3;
		return initError;
	}

            // Power control: 
            init.powerControl = 1;
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_PowerOnOff(init.powerControl);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 4;
		return initError;
	}

	// Check power:
	for (int i = 0; i < no_of_tries; i++) {
        init.powerCheck = op_wrp_Get_Power_Info(init.powerControl);
		if (init.powerCheck >= 1)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (init.powerCheck < 1) {
		initError = 5;
		return initError;
	}

          //  Get version of device:
            for (int i = 0; i < no_of_tries; i++)
            {
                
                errorCode = op_wrp_GetInfo(ref init.info2, ref init.info1);
                errorCode = op_wrp_GetVersion(ref init.version);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0) {
		initError = 6;
		return initError;
	}

	// Set up some parameters in OPBOX based on predefined variables

		// Acquisition parameters

			// Sampling frequency
	plot.sampling_freq_real = (100.0 / (double)(acq.sampling_freq + 1) * 10.0) / 10.0; //rounding!
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetSamplingFreq(plot.sampling_freq_real);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 100;
		return initError;
	}

	// Acquisition mode
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetDataMode(acq.mode);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50); 
	}
	if (errorCode != 0) {
		initError = 101;
		return initError;
	}

	// Window
	plot.window_in_smpls = (int)Math.Round(plot.sampling_freq_real * acq.window);
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetDepth(plot.window_in_smpls);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 102;
		return initError;
	}

            // Delay 
         
            plot.delay_in_smpls = (int)Math.Round(plot.sampling_freq_real * acq.delay);
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetDelay(plot.delay_in_smpls);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 103;
		return initError;
	}


	// Amplification parameters

		//Filter bandtwidth
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetAnalogFilter(ampl.filter_bandtwidth);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 104;
		return initError;
	}

	//Preamplifier
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetPreAmp(ampl.preamplifier);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 104;
		return initError;
	}

	//Input source
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetSource(ampl.input_source);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 104;
		return initError;
	}

	//Gain
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetGain(ampl.gain);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 105;
		return initError;
	}

	//Gain mode
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetGainMode(ampl.gain_mode);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 106;
		return initError;
	}

	// Pulser parameters

		// Amplitude level
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetAmplitude(puls.amplitude_level);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 107;
		return initError;
	}

	// Charging time in us
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetPulserTime((int)(10 * puls.charging_time), puls.enable);
               if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 108;
		return initError;
	}

	// Trigger parameters

		// Trigger source
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetSource(trig.trigger_source);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 109;
		return initError;
	}

	// Timer period
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetTimerperiod(trig.timer_period);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 110;
		return initError;
	}

	// XY divider
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_SetXYDivider(trig.xy_divider);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 111;
		return initError;
	}

	// Peak detector parameters - PDA

		// Enable
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_PDEnable(0, pda.enable);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 112;
		return initError;
	}

	// Mode
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_PDmode(0, pda.mode);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 113;
		return initError;
	}




	// Parameters (start / stop / level)
	
       
         setPdStartStopLevel((int)pd.pd_posX1_opbox[0], (int)pd.pd_posX2_opbox[0], (int)pd.pd_posY_opbox[0], (int)0);


            // Peak detector parameters - PDB

            // Enable
            for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_PDEnable(1, pdb.enable);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 112;
		return initError;
	}

	// Mode
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_PDmode(1, pdb.mode);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 113;
		return initError;
	}

	// Parameters (start / stop / level)
	

          setPdStartStopLevel((int)pd.pd_posX1_opbox[1], (int)pd.pd_posX2_opbox[1], (int)pd.pd_posY_opbox[1], (int)1);
            // Peak detector parameters - PDC

            // Enable
            for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_PDEnable(2, pdc.enable);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 112;
		return initError;
	}

	// Mode
	for (int i = 0; i < no_of_tries; i++) {
                errorCode = op_wrp_PDmode(2, pdc.mode);
		if (errorCode == 0)
			break;
                System.Threading.Thread.Sleep(50);
            }
	if (errorCode != 0) {
		initError = 113;
		return initError;
	}

	// Parameters (start / stop / level)
	//setPdStartStopLevel(0, 0,0, 2);

          setPdStartStopLevel((int)pd.pd_posX1_opbox[2],(int) pd.pd_posX2_opbox[2],(int) pd.pd_posY_opbox[2],(int) 2);
            refreshPDArrays();
			
	// Initialize both encoders
	initEncoders();

            System.Threading.Thread.Sleep(50);
            return initError;
}



        // Function, which finishes OPBOX session
      public  int endSession()
        {
            int no_of_tries = 5;
            int endError = 0;
            init.powerControl = 0;

            // We reset the device
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_Instr_Restet();
                if (errorCode == 0)
                    break;
            }
            if (errorCode != 0)
            {
                endError = 1;
                return endError;
            }

            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_Instr_RestetFIFO();
                if (errorCode == 0)
                    break;
            }
            if (errorCode != 0)
            {
                endError = 2;
                return endError;
            }

            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_PowerOnOff(init.powerControl);
                if (errorCode == 0)
                    break;
            }
            if (errorCode != 0)
            {
                endError = 3;
                return endError;
            }

            for (int i = 0; i < no_of_tries; i++)
            {
                init.powerCheck = op_wrp_Get_Power_Info(init.powerControl);
                if (init.powerCheck == 0)
                    break;
            }
            if (init.powerCheck != 0)
            {
                endError = 4;
                return endError;
            }

            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_CloseOpbox();
                if (errorCode == 0)
                    break;
            }
            if (errorCode != 0)
                endError = 5;

            return endError;
        }


        // Functions to modify OPBOX parameters - we switch the parameter, check error code
        // and compare value set and get from the device; if anything fails, we repeat the process
        // a few times and then throw error code outside the function

        // Acquisition parameters	
        public int setSamplingFreq(int sampling_freq)
        {
            int err_code = 0;
            refreshRestrictions();
            plot.sampling_freq_real = Math.Round(100.0 / (double)(sampling_freq + 1) * 10.0) / 10.0;
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetSamplingFreq(plot.sampling_freq_real);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 1;

            return err_code;
        }

        public int setDataMode(int rf_abs_mode)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetDataMode(acq.mode);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 2;

            return err_code;
        }



        public int setDepth(int depth_in_smpls)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetDepth(plot.window_in_smpls);
                if (errorCode == 0)
                    if (op_wrp_GetDepth() == plot.window_in_smpls)
                        break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 3;

            return err_code;
        }

        public int setDelay(int delay_in_smpls)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetDelay(plot.delay_in_smpls);
                if (errorCode == 0)
                {
                    if (op_wrp_GetDelay() == plot.delay_in_smpls)
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 4;

            return err_code;
        }


        // AMPLIFIERS' PARAMETERS:

        public int setAnalogFilter(int analog_filter)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                ampl.filter_bandtwidth = analog_filter;
                //errorCode = op_wrp_SetAnalog(analog_set_value);//
                errorCode = op_wrp_SetAnalogFilter(ampl.filter_bandtwidth);
                if (errorCode == 0)
                {
                    int test = op_wrp_GetAnalog();
                    if (isAnalogValueCorrect())
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 5;

            return err_code;
        }

        public int setPreamplifier(int preamplifier)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                ampl.preamplifier = preamplifier;
                //errorCode = op_wrp_SetAnalog(analog_set_value);//
                errorCode = op_wrp_SetPreAmp(preamplifier);
                if (errorCode == 0)
                {
                    if (isAnalogValueCorrect())
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 6;

            return err_code;
        }

        public int setInputSource(int input_source)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                ampl.input_source = input_source;
                //errorCode = op_wrp_SetAnalog(analog_set_value);//
                errorCode = op_wrp_SetSource(input_source);
                if (errorCode == 0)
                {
                    if (isAnalogValueCorrect())
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 7;

            return err_code;
        }

        public int setGain(int gain)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                ampl.gain = gain;
                errorCode = op_wrp_SetGain(ampl.gain);
                if (errorCode == 0)
                {
                    if (op_wrp_GetGain() == ampl.gain)
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 8;

            return err_code;
        }

        public int setGainMode(int gainMode)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                ampl.gain_mode = gainMode;
                errorCode = op_wrp_SetGainMode(ampl.gain_mode);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 9;

            return err_code;
        }

        // Function, which provides us with the way to check analog values
        public bool isAnalogValueCorrect()
        {
            int analog_value = 0;
            analog_value += (ampl.filter_bandtwidth);
            switch (ampl.preamplifier)
            {
                case 0:
                    analog_value += 0;
                    break;
                case 1:
                    analog_value += 32;
                    break;
                case 2:
                    analog_value += 16;
                    break;
            }
            analog_value += (ampl.input_source << 6);
            if (op_wrp_GetAnalog() == analog_value)
                return true;
            else
                return false;
        }



        // Pulser parameters
        public int setAmplitudeLevel(int amplitude_level)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                puls.amplitude_level = amplitude_level;
                errorCode = op_wrp_SetAmplitude(puls.amplitude_level);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 10;

            return err_code;
        }

        public int setChargingTime(float charging_time)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                puls.charging_time = charging_time;
                errorCode = op_wrp_SetPulserTime((int)(10 * puls.charging_time), puls.enable);
                if (errorCode == 0)
                {
                    int puls_enable=0;
                    int puls_time=0;
                    op_wrp_GetPulserTime(puls_time, puls_enable);
                    if ((puls_enable == puls.enable) && (puls_time == (int)(10 * puls.charging_time)))
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 11;

            return err_code;
        }

        // TRIGGER PARAMETERS:

        public int setTriggerSource(int trigger_source)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                trig.trigger_source = trigger_source;
                errorCode = op_wrp_SetTriggerSource(trig.trigger_source);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 12;

            return err_code;
        }

        public int setTimerPeriod(double timer_period)
        {
            int err_code = 0;

          

            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetTimerperiod(trig.timer_period);
                if (errorCode == 0)
                {
                    if (op_wrp_GetTimerperion() == (trig.timer_period))
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 13;

            return err_code;
        }

        public int setXYDivider(int xy_divider)
        {
            int err_code = 0;
            for (int i = 0; i < no_of_tries; i++)
            {
                trig.xy_divider = xy_divider;
                errorCode = op_wrp_SetXYDivider(trig.xy_divider);
                if (errorCode == 0)
                {
                    int xy_div_device_check=0;
                    int xy_div_opbox = trig.xy_divider;
                    errorCode = op_wrp_GetXYDivider(xy_div_device_check);
                    if ((errorCode == 0) && (xy_div_device_check == trig.xy_divider))
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 14;

            return err_code;
        }



      

     public  int setPdStartStopLevel(int start, int stop, int level, int pd_no)
        {
            int err_code = 0;

            for (int i = 0; i <no_of_tries; i++)
            {

                switch (pd_no)
                {
                    case 0:
                        pda.ref_pos_opbox = start;
                        pda.max_pos_opbox = stop;
                        pda.max_val_opbox = level;
                        break;
                    case 1:
                        pdb.ref_pos_opbox = start;
                        pdb.max_pos_opbox = stop;
                        pdb.max_val_opbox = level;
                        break;
                    case 2:
                        pdc.ref_pos_opbox = start;
                        pdc.max_pos_opbox = stop;
                        pdc.max_val_opbox = level;
                        break;
                }
                errorCode = op_wrp_SetPDStartStopLevel(start, stop, level, pd_no);

                // Set user error to 0 - we assume that user is right at first :)
                setPdUserErr(pd_no, 0);

                if (errorCode == 0)
                    break;
            }
            if (errorCode != 0)
                err_code = 16;

            return err_code;
        }


        public int setPdEnable(int enable, int pd_no)
        {
            int err_code = 0;

            for (int i = 0; i < no_of_tries; i++)
            {
                switch (pd_no)
                {
                    case 0:
                        pda.enable = enable;
                        errorCode = op_wrp_PDEnable(0, pda.enable);
                        break;
                    case 1:
                        pdb.enable = enable;
                        errorCode = op_wrp_PDEnable(1, pdb.enable);
                        break;
                    case 2:
                        pdc.enable = enable;
                        errorCode = op_wrp_PDEnable(2, pdc.enable);
                        break;
                }

                // Set user error to 0 - we assume that user is right at first :)
                setPdUserErr(pd_no, 0);

                if (errorCode == 0)
                    break;
            }
            if (errorCode != 0)
                err_code = 15;

            return err_code;
        }


        public int setPdMode(int pd_mode, int pd_no)
        {
            int err_code = 0;

            for (int i = 0; i < no_of_tries; i++)
            {
                switch (pd_no)
                {
                    case 0:
                        pda.mode = pd_mode;
                        errorCode = op_wrp_PDmode(0, pda.mode);
                        break;
                    case 1:
                        pdb.mode = pd_mode;
                        errorCode = op_wrp_PDmode(1, pdb.mode);
                        break;
                    case 2:
                        pdc.mode = pd_mode;
                        errorCode = op_wrp_PDmode(2, pdc.mode);
                        break;
                }

                // Set user error to 0 - we assume that user is right at first :)
                setPdUserErr(pd_no, 0);

                if (errorCode == 0)
                    break;
            }
            if (errorCode != 0)
                err_code = 17;

            return err_code;
        }


        //// Function modifying state of error code for PD raised after user mistake
        //// - after we make sure user set PD in a position that ensures no signal detection, we set error
        // - any PD set will remove error code (1) from PD; only PD timer can set it up in our program.
        public void setPdUserErr(int pd_no, int value)
        {
            switch (pd_no)
            {
                case 0:
                    pda.user_error = value;
                    break;
                case 1:
                    pdb.user_error = value;
                    break;
                case 2:
                    pdc.user_error = value;
                    break;
            }
        }


        // Provides a way to check state of any peak detector
        public bool isPdEnabled(int pd_no)
        {
            switch (pd_no)
            {
                case 0:     // PDA
                    if (pda.enable == 1)
                        return true;
                    else
                        return false;
                    break;
                case 1:     // PDB
                    if (pdb.enable == 1)
                        return true;
                    else
                        return false;
                    break;
                default:    // PDC
                    if (pdc.enable == 1)
                        return true;
                    else
                        return false;
                    break;
            }
        }

        // We set all of them, so we don't need to take care about repositioning after disabling issues
        void setPeakDetectors()
        {
            errorCode =setPdStartStopLevel((int)Math.Min(pd.pd_posX1_opbox[0], pd.pd_posX2_opbox[0]), (int)Math.Max(pd.pd_posX1_opbox[0], pd.pd_posX2_opbox[0]), (int)pd.pd_posY_opbox[0], (int)0);
            setPdUserErr(0, 0);
            errorCode = setPdStartStopLevel((int)Math.Min(pd.pd_posX1_opbox[1], pd.pd_posX2_opbox[1]),(int) Math.Max(pd.pd_posX1_opbox[1], pd.pd_posX2_opbox[1]),(int) pd.pd_posY_opbox[1], 1);
            setPdUserErr(1, 0);
            errorCode =setPdStartStopLevel((int)Math.Min(pd.pd_posX1_opbox[2], pd.pd_posX2_opbox[2]),(int) Math.Max(pd.pd_posX1_opbox[2], pd.pd_posX2_opbox[2]),(int) pd.pd_posY_opbox[2], 2);
            setPdUserErr(2, 0);
        }


        public void setPeakDetector(int pd_number)
        {
           errorCode = setPdStartStopLevel((int)Math.Min(pd.pd_posX1_opbox[pd_number], pd.pd_posX2_opbox[pd_number]), (int)Math.Max(pd.pd_posX1_opbox[pd_number], pd.pd_posX2_opbox[pd_number]),(int) pd.pd_posY_opbox[pd_number], pd_number);
            setPdUserErr(pd_number, 0);
        }


        ////	PEAK DETECTORS - METHODS FOR CONVERSIONS:

        // PD values for Opbox --> PD Real values
        public void convertPDToRfAbs()
        {
            if (acq.mode == 0)
            {   // RF
                for (int i = 0; i < 3; i++)
                {
                    pd.pd_posY_plot[0] = (float)(pd.pd_posY_plot[0] / 100.0 - 0.5);
                }
            }
            if (acq.mode == 1)
            {   // ABS
                for (int i = 0; i < 3; i++)
                {
                    pd.pd_posY_plot[0] = (float)((pd.pd_posY_plot[0]+ 0.5) * 100.0);
                }
            }
        }

        //// PD values --> Opbox values
        //	// Should be done after any crucial parameter switch
        // - window, delay or simply PD change (after removing MouseDown event, MouseUp occurence or MouseClick
        public  void convertPDToOpbox()
        {

            pd.pd_posX1_opbox[0] = (int)((pd.pd_posX1_plot[0] - acq.delay) * plot.sampling_freq_real);
            pd.pd_posX1_opbox[1] = (int)((pd.pd_posX1_plot[1] - acq.delay) * plot.sampling_freq_real);
            pd.pd_posX1_opbox[2] = (int)((pd.pd_posX1_plot[2] - acq.delay) * plot.sampling_freq_real);

            pd.pd_posX2_opbox[0] = (int)((pd.pd_posX2_plot[0] - acq.delay) * plot.sampling_freq_real);
            pd.pd_posX2_opbox[1] = (int)((pd.pd_posX2_plot[1] - acq.delay) * plot.sampling_freq_real);
            pd.pd_posX2_opbox[2] = (int)((pd.pd_posX2_plot[2] - acq.delay) * plot.sampling_freq_real);

            if (acq.mode == 0)
            {   // RF
                pd.pd_posY_opbox[0] = (char)((pd.pd_posY_plot[0] + 0.5) * 256);
                pd.pd_posY_opbox[1] = (char)((pd.pd_posY_plot[1] + 0.5) * 256);
                pd.pd_posY_opbox[2] = (char)((pd.pd_posY_plot[2] + 0.5) * 256);
            }
            if (acq.mode == 1)
            {   // ABS
                pd.pd_posY_opbox[0] = (char)(pd.pd_posY_plot[0] * 2.56);
                pd.pd_posY_opbox[1] = (char)(pd.pd_posY_plot[1] * 2.56);
                pd.pd_posY_opbox[2] = (char)(pd.pd_posY_plot[2] * 2.56);
            }
        }


        // Recalculation of peak detectors, so we can resize our chart safely without
        // Peak Detector replacement or any restrictions - it will be held at the same place
        // no matter what sort of resize or switch of window / delay we do there...
      public  void storePDRelativePositions()
        {

            // Units equal to 1% of range X and range Y
            double norm_x = (plot.max_x - plot.min_x) / 100.0;
            double norm_y = (plot.max_y - plot.min_y) / 100.0;

            // Store relative positions of Peak Detectors
            pd.pd_posX1_rel[0] = (float)((pd.pd_posX1_plot[0] - plot.min_x) / norm_x);
            pd.pd_posX2_rel[0] = (float)((pd.pd_posX2_plot[0] - plot.min_x) / norm_x);
            pd.pd_posY_rel[0]= (float)((pd.pd_posY_plot[0] - plot.min_y) / norm_y);

            pd.pd_posX1_rel[1] = (float)((pd.pd_posX1_plot[1] - plot.min_x) / norm_x);
            pd.pd_posX2_rel[1] = (float)((pd.pd_posX2_plot[1] - plot.min_x) / norm_x);
            pd.pd_posY_rel[1] = (float)((pd.pd_posY_plot[1] - plot.min_y) / norm_y);

            pd.pd_posX1_rel[2] = (float)((pd.pd_posX1_plot[2] - plot.min_x) / norm_x);
            pd.pd_posX2_rel[2] = (float)((pd.pd_posX2_plot[2] - plot.min_x) / norm_x);
            pd.pd_posY_rel[2] = (float)((pd.pd_posY_plot[2] - plot.min_y) / norm_y);
        }

        // Recalculation of PD positions
        void recalculatePDPositions()
        {

            // Units equal to 1% of range X and range Y
            double norm_x = (plot.max_x - plot.min_x) / 100.0;
            double norm_y = (plot.max_y - plot.min_y) / 100.0;

            // Recalculate units
            pd.pd_posX1_plot[0] = (float)(plot.min_x + norm_x * pd.pd_posX1_rel[0]);
            pd.pd_posX2_plot[0] = (float)(plot.min_x + norm_x * pd.pd_posX2_rel[0]);
            pd.pd_posY_plot[0] = (float)(plot.min_y + norm_y * pd.pd_posY_rel[0]);

            pd.pd_posX1_plot[1] = (float)(plot.min_x + norm_x * pd.pd_posX1_rel[1]);
            pd.pd_posX2_plot[1] = (float)(plot.min_x + norm_x * pd.pd_posX2_rel[1]);
            pd.pd_posY_plot[1] = (float)(plot.min_y + norm_y * pd.pd_posY_rel[1]);

            pd.pd_posX1_plot[2] = (float)(plot.min_x + norm_x * pd.pd_posX1_rel[2]);
            pd.pd_posX2_plot[2]= (float)(plot.min_x + norm_x * pd.pd_posX2_rel[2]);
            pd.pd_posY_plot[2] = (float)(plot.min_y + norm_y * pd.pd_posY_rel[2]);

            // Refresh values
            refreshPDArrays();

            // Recalculate values for OPBOX
            convertPDToOpbox();
            setPeakDetectors();
        }

        // Function refreshing data arrays about PD which are required in some places
        public  void refreshPDArrays()
        {
            pd.pda_X_plot[0] = pd.pd_posX1_plot[0];
            pd.pda_X_plot[1] = pd.pd_posX2_plot[0];

            pd.pda_Y_plot[0] = pd.pd_posY_plot[0];
            pd.pda_Y_plot[1] = pd.pd_posY_plot[0];

            pd.pdb_X_plot[0] = pd.pd_posX1_plot[1];
            pd.pdb_X_plot[1] = pd.pd_posX2_plot[1];

            pd.pdb_Y_plot[0] = pd.pd_posY_plot[1];
            pd.pdb_Y_plot[1] = pd.pd_posY_plot[1];

            pd.pdc_X_plot[0] = pd.pd_posX1_plot[2];
            pd.pdc_X_plot[1] = pd.pd_posX2_plot[2];

            pd.pdc_Y_plot[0] = pd.pd_posY_plot[2];
            pd.pdc_Y_plot[1] = pd.pd_posY_plot[2];
        }



        // Function initializing both encoders with values initialized by constructor
      public  int initEncoders()
        {

            int initError = 0;

            // Encoder A parameters

            // Enc A - Enabling
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(enca.enable, 0, enca.comp_step, enc_a);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 114;
                return initError;
            }

            // Enc A - Input mode
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(enca.input_mode, 2, enca.comp_step, enc_a);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 115;
                return initError;
            }

            // Enc A - Idx Input
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(enca.idx_input, 3, enca.comp_step, enc_a);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 116;
                return initError;
            }

            // Enc A - Decode Mode
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(enca.decode_mode, 4, enca.comp_step, enc_a);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 117;
                return initError;
            }

            // Enc A - Filter
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(enca.filter, 6, enca.comp_step, enc_a);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 118;
                return initError;
            }

            // Enc A - Comparator and Comparator Step
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(enca.comparator, 7, enca.comp_step, enc_a);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 119;
                return initError;
            }

            // Encoder B parameters

            // Enc B - Enabling
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(encb.enable, 0, encb.comp_step, enc_b);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 114;
                return initError;
            }

            // Enc B - Input mode
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(encb.input_mode, 2, encb.comp_step, enc_b);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 115;
                return initError;
            }

            // Enc B - Idx Input
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(encb.idx_input, 3, encb.comp_step, enc_b);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 116;
                return initError;
            }

            // Enc B - Decode Mode
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(encb.decode_mode, 4, encb.comp_step, enc_b);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 117;
                return initError;
            }

            // Enc B - Filter
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(encb.filter, 6, encb.comp_step, enc_b);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 118;
                return initError;
            }

            // Enc B - Comparator and Comparator Step
            for (int i = 0; i < no_of_tries; i++)
            {
                errorCode = op_wrp_SetEncoder(encb.comparator, 7, encb.comp_step, enc_b);
                if (errorCode == 0)
                    break;
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                initError = 119;
                return initError;
            }

            return initError;
        }


        // Encoders' controls
        public int setEncEnable(int enable, int enc_no)
        {
            int err_code = 0;

            int option=0;
            int mN = 0;
            int step;

            for (int i = 0; i < no_of_tries; i++)
            {
                if (enc_no == 0)
                {
                    enca.enable = enable;
                    step = enca.comp_step;
                    errorCode = op_wrp_SetEncoder(enca.enable, mN, step, enc_no);
                }
                else
                {
                    encb.enable = enable;
                    step = encb.comp_step;
                    errorCode = op_wrp_SetEncoder(encb.enable, mN, step, enc_no);
                }
                if (errorCode == 0)
                { // check set value in opbox
                    errorCode = op_wrp_GetEncoder(option, mN, step, enc_no);

                    // We want no errors and we expect correct value - let's check this!
                    if ((errorCode == 0) && (((enc_no == 0) && (option == enca.enable)) || ((enc_no == 1) && (option == encb.enable))))
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 18;

            return err_code;
        }

     public   int setEncInputMode(int input_mode, int enc_no)
        {
            int err_code = 0;

            int option = 0;
            int mN = 2;
            int step;

            for (int i = 0; i < no_of_tries; i++)
            {
                if (enc_no == 0)
                {
                    step = enca.comp_step;
                    enca.input_mode = input_mode;
                    errorCode = op_wrp_SetEncoder(enca.input_mode, mN, enca.comp_step, enc_no);
                }
                else
                {
                    step = encb.comp_step;
                    encb.input_mode = input_mode;
                    errorCode = op_wrp_SetEncoder(encb.input_mode, mN, encb.comp_step, enc_no);
                }
                if (errorCode == 0)
                { // check set value in opbox
                    errorCode = op_wrp_GetEncoder(option, mN, step, enc_no);

                    // We want no errors and we expect correct value - let's check this!
                    if ((errorCode == 0) && (((enc_no == 0) && (option == enca.input_mode)) || ((enc_no == 1) && (option == encb.input_mode))))
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 19;

            return err_code;
        }

      public  int setEncIdxInput(int idx_input, int enc_no)
        {
            int err_code = 0;
            int option=0;
            int mN = 3;
            int step;

            for (int i = 0; i < no_of_tries; i++)
            {
                if (enc_no == 0)
                {
                    enca.idx_input = idx_input;
                    step = enca.comp_step;

                    errorCode = op_wrp_SetEncoder(idx_input, mN, step, enc_no);
                }
                else
                {
                    encb.idx_input = idx_input;
                    step = encb.comp_step;
                    errorCode = op_wrp_SetEncoder(idx_input, mN, step, enc_no);
                }
                if (errorCode == 0)
                { // check set value in opbox
                    errorCode = op_wrp_GetEncoder(option, mN, step, enc_no);

                    // We want no errors and we expect correct value - let's check this!
                    if ((errorCode == 0) && (((enc_no == 0) && (option == enca.idx_input)) || ((enc_no == 1) && (option == encb.idx_input))))
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 20;

            return err_code;
        }

     public   int setEncDecodeMode(int decode_mode, int enc_no)
        {
            int err_code = 0;

            int option=0;
            int mN = 4;
            int step;

            for (int i = 0; i < no_of_tries; i++)
            {
                if (enc_no == 0)
                {
                    enca.decode_mode = decode_mode;
                    step = enca.comp_step;
                    errorCode = op_wrp_SetEncoder(enca.decode_mode, mN, step, enc_no);
                }
                else
                {
                    encb.decode_mode = decode_mode;
                    step = encb.comp_step;
                    errorCode = op_wrp_SetEncoder(encb.decode_mode, mN, step, enc_no);
                }
                if (errorCode == 0)
                { // check set value in opbox
                    errorCode = op_wrp_GetEncoder(option, mN, step, enc_no);

                    // We want no errors and we expect correct value - let's check this!
                    if ((errorCode == 0) && (((enc_no == 0) && (option == enca.decode_mode)) || ((enc_no == 1) && (option == encb.decode_mode))))
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 21;

            return err_code;
        }

      public  int setEncFilter(int filter, int enc_no)
        {
            int err_code = 0;

            int option=0;
            int mN = 6;
            int step;

            for (int i = 0; i < no_of_tries; i++)
            {
                if (enc_no == 0)
                {
                    enca.filter = filter;
                    step = enca.comp_step;
                    errorCode = op_wrp_SetEncoder(enca.filter, mN, enca.comp_step, enc_no);
                    //errorCode = op_wrp_SetEncoder(Opbox::enca.filter, mN, step, enc_no);
                }
                else
                {
                    encb.filter = filter;
                    step = encb.comp_step;
                    errorCode = op_wrp_SetEncoder(encb.filter, mN, encb.comp_step, enc_no);
                    //				errorCode = op_wrp_SetEncoder(Opbox::encb.filter, mN, step, enc_no);
                }
                if (errorCode == 0)
                { // check set value in opbox
                    errorCode = op_wrp_GetEncoder(option, mN, step, enc_no);

                    // We want no errors and we expect correct value - let's check this!
                    if ((errorCode == 0) && (((enc_no == 0) && (option == enca.filter)) || ((enc_no == 1) && (option == encb.filter))))
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 22;

            return err_code;
        }

        public int setEncComparatorStep(int comparator_step, int enc_no)
        {
            int err_code = 0;

            int option=0;
            int mN = 0;
            int step=0;

           string  current_value;
           string input_value;
           string  correct_value;

            if (enc_no == 0)
            {
                current_value = Convert.ToString(enca.comp_step);
                input_value = Convert.ToString(comparator_step);
                correct_value = inputCheck(input_value, current_value, 5);
                System.Int32.TryParse(correct_value, out enca.comp_step);
            }
            else
            {
                current_value = Convert.ToString(encb.comp_step);
                input_value = Convert.ToString(comparator_step);
                correct_value = inputCheck(input_value, current_value, 5);
                System.Int32.TryParse(correct_value,out encb.comp_step);
            }

            for (int i = 0; i < no_of_tries; i++)
            {
                if (enc_no == 0)
                {
                    errorCode = op_wrp_SetEncoder(enca.enable, mN, enca.comp_step, enc_no);
                }
                else
                {
                    errorCode = op_wrp_SetEncoder(encb.enable, mN, encb.comp_step, enc_no);
                }
                if (errorCode == 0)
                { // check set value in opbox
                    errorCode = op_wrp_GetEncoder(option, mN, step, enc_no);

                    // We want no errors and we expect correct value - let's check this!
                    if ((errorCode == 0) && (((enc_no == 0) && (option == enca.enable)) || ((enc_no == 1) && (option == encb.enable))))
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }

            if (errorCode != 0)
                err_code = 23;

            return err_code;
        }

        public string inputCheck(string input, string previous_value, int parameter)
        {

            // Variable required for numeric boundaries checkout if input
            // provided by user is valid
            double num_input;

            // 1. Check if the input is a legit double value and is not empty; 
            //    otherwise, return string of previous value
            if (System.Double.TryParse(input,out num_input))
            {

                // 2. Check if variable matches numeric restrictions (min / max)
                if (num_input > max_value[parameter])
                {
                    num_input = max_value[parameter];
                }
                if (num_input < min_value[parameter])
                {
                    num_input = min_value[parameter];
                }

                // 3. Make sure it will match desired precision restrictions
                num_input = Math.Round(num_input * Math.Pow(10.0, (double)digits_of_precision[parameter])) / Math.Pow(10.0, (double)digits_of_precision[parameter]);

                // 4. Convert it back to string and return valid string value
                string correct_value = System.Convert.ToString(num_input);

                return correct_value;
            }
            else
            {
                return previous_value;
            }
        }

        public int setEncComparator(int comparator, int enc_no)
        {
            int err_code = 0;

            int option=0;
            int mN = 7;
            int step;

            for (int i = 0; i < no_of_tries; i++)
            {
                if (enc_no == 0)
                {
                    enca.comparator = comparator;
                    step = enca.comp_step;
                    errorCode = op_wrp_SetEncoder(enca.comparator, mN, step, enc_no);
                }
                else
                {
                    encb.comparator = comparator;
                    step = encb.comp_step;
                    errorCode = op_wrp_SetEncoder(encb.comparator, mN, step, enc_no);
                }
                if (errorCode == 0)
                { // check set value in opbox
                    errorCode = op_wrp_GetEncoder(option, mN, step, enc_no);

                    // We want no errors and we expect correct value - let's check this!
                    if ((errorCode == 0) && (((enc_no == 0) && (option == enca.comparator)) || ((enc_no == 1) && (option == encb.comparator))))
                        break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 24;

            return err_code;
        }


        // Function which resets encoder position
      public  int setEnc(int enc_no)
        {
            int err_code = 0;

            int mN = 1;
            int step;

            for (int i = 0; i < no_of_tries; i++)
            {
                if (enc_no == 0)
                {
                    step = enca.comp_step;
                    errorCode = op_wrp_SetEncoder(1, mN, step, enc_no);
                    if (errorCode == 0)
                        errorCode = op_wrp_SetEncoder(0, mN, step, enc_no);
                    if (errorCode == 0)
                        errorCode = op_wrp_SetEncoder(enca.enable, 0, step, enc_no);
                }
                else
                {
                    step = encb.comp_step;
                    errorCode = op_wrp_SetEncoder(1, mN, step, enc_no);
                    if (errorCode == 0)
                        errorCode = op_wrp_SetEncoder(0, mN, step, enc_no);
                    if (errorCode == 0)
                        errorCode = op_wrp_SetEncoder(encb.enable, 0, step, enc_no);
                }
                if (errorCode == 0)
                { // check if there were no errors
                    break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
                err_code = 25;

            // Set encoder enable
            if (enc_no == 0)
                errorCode = setEncEnable(enca.enable, enc_no);
            if (enc_no == 1)
                errorCode = setEncEnable(encb.enable, enc_no);


            return err_code;
        }


        // FUNCTIONS FOR DATA MANAGEMENT:

        // Function called to collect single data frame
      public  void collectData()
        {

            data.main_dataY = selectRawData(plot.window_in_smpls) ;
            if (plot.window_in_smpls >= plot.plot_data_size)
            {
                switch (plot.plot_algorithm)
                {
                    case 0:
                        floatingMean(data.main_dataX, data.main_dataY, plot.window_in_smpls, data.plot_dataX, data.mean_dataY, plot.plot_data_size);
                        break;
                    case 1:
                        meanMaxMin(data.main_dataX, data.main_dataY, plot.window_in_smpls, data.plot_dataX, data.mean_dataY, plot.plot_data_size);
                        break;
                    default:
                        floatingMean(data.main_dataX, data.main_dataY, plot.window_in_smpls, data.plot_dataX, data.mean_dataY, plot.plot_data_size);
                        break;
				}

                convertDataToRfAbs(data.mean_dataY, data.plot_dataY, plot.plot_data_size);
            }
            else
            {
                smallDataPlot(data.main_dataX, data.main_dataY, plot.window_in_smpls, data.plot_dataX, data.plot_dataY);
                convertDataToRfAbs(data.main_dataY, data.plot_dataY, plot.window_in_smpls);
            }
        }






        public byte[] selectRawData(int length)
        { 
            byte[] result = new byte[length];
            data.main_dataX = new float[length];
            for (int i = 0; i < length; i++)
            {
                data.main_dataX[i] = plot.min_x + i * (plot.max_x - plot.min_x) / length;
                result[i] = data.data_buffer[i + data.header_size];
            }
            return result;
        }


        //public byte selectRawData(int length)
        //{ 
        //    byte[] result = new byte[length];
        //   data.main_dataX = new float[length];
        //    for (int i = 0; i < length; i++)
        //    {
        //       data.main_dataX[i] = plot.min_x + i * (plot.max_x - plot.min_x) / length;
        //        result[i] = data.data_buffer[i + data.header_size];
        //    }
        //    return result[length];
        //}






        public void floatingMean(float[] dataX, byte[] dataY, int dataSize, float[] plotDataX, byte[] meanDataY, int plotDataSize)
        {
            int samplesPerPoint; // How many points
            int currentDataSize = dataSize; // Make sure we work on copy of value
            int plotDataSizeLeft = plotDataSize;
            int currentIndex = 0;
            float sumX;
            int sumY ;
            for (int i = 0; i < plotDataSize; i++)
            {
                samplesPerPoint = currentDataSize / plotDataSizeLeft; // We recalculate this due to integer rounding causing errors
                sumX = 0.0F;
                sumY = 0;
                for (int j = 0; j < samplesPerPoint; j++)
                {
                    sumX += dataX[currentIndex];
                    sumY += dataY[currentIndex];
                    currentIndex++;
                }
                sumX = sumX / samplesPerPoint;
                sumY = sumY / samplesPerPoint;
                plotDataX[i] = sumX;
                meanDataY[i] = Convert.ToByte(sumY);
                currentDataSize -= samplesPerPoint;
                plotDataSizeLeft--;
            }
        }


        public void meanMaxMin(float[] dataX, byte[] dataY, int dataSize, float[] plotDataX, byte[] meanDataY, int plotDataSize)
        {
            int samplesPerPoint; // How many points
            int currentDataSize = dataSize; // Make sure we work on copy of value
            int plotDataSizeLeft = plotDataSize;
            int currentIndex = 0;
            float sumX = 0F;
            int sumY = 0;
            int minY=0;
            int maxY=0;
            for (int i = 0; i < plotDataSize; i++)
            {
                samplesPerPoint = currentDataSize / plotDataSizeLeft; // We recalculate this due to integer rounding causing errors
                sumX = 0.0F;
                sumY = 0;
                for (int j = 0; j < samplesPerPoint; j++)
                {

                    // Check for extreme values in the averaging level
                    if (j == 0)
                    {
                        minY = dataY[currentIndex];
                        maxY = dataY[currentIndex];
                    }
                    else
                    {
                        if (minY > dataY[currentIndex])
                        {
                            minY = dataY[currentIndex];
                        }
                        if (maxY < dataY[currentIndex])
                        {
                            maxY = dataY[currentIndex];
                        }
                    }
                    sumX += dataX[currentIndex];
                    sumY += dataY[currentIndex];
                    currentIndex++;
                }
                sumX = sumX / samplesPerPoint;
                sumY = sumY / samplesPerPoint; // From now on, sumY is average value
                plotDataX[i] = sumX;
                if ((maxY - sumY) > (sumY - minY))
                {
                    meanDataY[i] = Convert.ToByte(maxY);
                }
                else
                {
                    meanDataY[i] = Convert.ToByte(minY);
                }
                currentDataSize -= samplesPerPoint;
                plotDataSizeLeft--;
            }
        }



        public void convertDataToRfAbs(byte[] meanDataY, float[] plotDataY, int plotDataSize)
        {
            if (acq.mode == 0)
            {
                for (int i = 0; i < plotDataSize; i++)
                {
                    plotDataY[i] = (float)(meanDataY[i] / 256.0 - 0.5);
                }
            }
            if (acq.mode == 1)
            {
                for (int i = 0; i < plotDataSize; i++)
                {
                    plotDataY[i] = (float)(meanDataY[i] / 2.56 * 2.0);
                }
            }
        }


        public void smallDataPlot(float[] dataX, byte[] dataY, int dataSize, float[] plotDataX, float[] plotDataY)
        {
            for (int i = 0; i < dataSize; i++)
            {
                plotDataX[i] = dataX[i];
                plotDataY[i] = dataY[i];
            }
        }

       


      



        ////Function which allocates new arrays to fit user requirements - we need to plot all the spectrum of 
        public void recreateDataArrays()
        { //array<float>^ dataX, array<System::Byte>^ dataY, int newDataSize, array<float>^ plotDataX, array<float> plotDataY) {

            data.main_dataX = new float[plot.window_in_smpls]; // float[Opbox::plot.window_in_smpls];
            data.main_dataY = new System.Byte[plot.window_in_smpls];

            if ((plot.window_in_smpls) >= plot.plot_data_size)
            {
                data.plot_dataX = new float[plot.plot_data_size];
                data.plot_dataY = new float[plot.plot_data_size];
            }
            else
            {
                data.plot_dataX = new float[plot.window_in_smpls];
                data.plot_dataY = new float[plot.window_in_smpls];
            }
        }



       

        //// Updates plot properties for X axis based on current delay / depth / sampling freq modification
      public  void updatePlotXAxis()
        {
            plot.max_x = (float)((plot.delay_in_smpls + plot.window_in_smpls) / plot.sampling_freq_real);
            plot.min_x = (float)(plot.delay_in_smpls / plot.sampling_freq_real);
        }


        //// Sets sampling frequency (we pass 0(100) - 15(6.7) here)
        public void setSamplingFreqFull(int sampling_freq)
        {

            // Make changes in parameters		 
            acq.sampling_freq = sampling_freq;
            refreshRestrictions();
            plot.sampling_freq_real = 100.0 / ((acq.sampling_freq) + 1);
            errorCode = setSamplingFreq(sampling_freq);

            setWindow(acq.window);
            setDelay(acq.delay);
            updatePlotXAxis();
            convertPDToOpbox();
            setPeakDetectors();
        }



        //// Sets data mode (0 = RF, 1 = ABS)
        public void setDataModeFull(int data_mode)
        {

            acq.mode = data_mode;

            // Control restrictions
            if (data_mode == 1)
            {
                plot.min_y = 0.0f;
                plot.max_y = 100.0f;
            }
            else
            {
                plot.min_y = -0.5f;
                plot.max_y = 0.5f;
            }

            // Switch data mode
            errorCode = setDataMode(data_mode);

            // Recalculate data displayed on plot
            // If we have more data points than we want to plot, we use only plotDataSize of them
            if (plot.window_in_smpls >= plot.plot_data_size)
            {
                convertDataToRfAbs(data.mean_dataY, data.plot_dataY, plot.plot_data_size);
            }
            // Otherwise, we will plot all points
            else
            {
                convertDataToRfAbs(data.mean_dataY, data.plot_dataY, plot.window_in_smpls);
            }

            convertPDToRfAbs();
            convertPDToOpbox();
            setPeakDetectors();
        }



        //// Sets depth - we pass depth in us
        public void setDepthFull(double depth)
        {
            setWindow(depth);
            updatePlotXAxis();
            recalculatePDPositions();
        }


        //// Sets delay - we pass delay in us
        public  void setDelayFull(double delay)
        {
            setDelay(delay);
           updatePlotXAxis();
           recalculatePDPositions();
        }

        //// Sets charging time - we pass number in us
        public void setChargingTimeFull(float charging_time)
        {
            string current_value = System.Convert.ToString(puls.charging_time);
            string input_value = System.Convert.ToString(charging_time);
            string correct_value = inputCheck(input_value, current_value, 3);
            System.Single.TryParse(correct_value,out  puls.charging_time);

            errorCode = setChargingTime(puls.charging_time);
        }



        //// INTERNAL FUNCTIONS USED IN COMPLEX PARAMETERS' MODIFICATION FUNCTIONS:

        public void setWindow(double depth)
        {
            storePDRelativePositions();

            string current_value = System.Convert.ToString(acq.window);
            string input_value = System.Convert.ToString(depth);
            string correct_value = inputCheck(input_value, current_value, 0);
            System.Double.TryParse(correct_value,out acq.window);

            // Store it for usage of the following condition
            int old_window_in_smpls = plot.window_in_smpls;
            plot.window_in_smpls = (int)Math.Round(plot.sampling_freq_real * acq.window);

            // ... or just create it whenever we switch depth to another value
            recreateDataArrays();

            errorCode = setDepth(plot.window_in_smpls);
        }



        public void setDelay(double delay)
        {
            storePDRelativePositions();

            string current_value = System.Convert.ToString(acq.delay);
            string input_value = System.Convert.ToString(delay);
            string correct_value = inputCheck(input_value, current_value, 1);
            System.Double.TryParse(correct_value,out acq.delay);

            plot.delay_in_smpls = (int)Math.Round(plot.sampling_freq_real * acq.delay);
            errorCode = setDelay(plot.delay_in_smpls);
        }



        //// VALUE CONTROL FUNCTIONS:

        // Function for values updating
        void refreshRestrictions()
        {
            plot.sampling_freq_real = 100.0 / (acq.sampling_freq + 1);
            min_value[datastructs.check_option.window.GetHashCode()] = 1.0;//1.0 / (this->plot.sampling_freq_real);
            max_value[datastructs.check_option.window.GetHashCode()] = 262090 / plot.sampling_freq_real;
            max_value[datastructs.check_option.delay.GetHashCode()] = 65535 / plot.sampling_freq_real;
            if (acq.sampling_freq == 100.0)
            {
                digits_of_precision[datastructs.check_option.window.GetHashCode()] = 2;
                digits_of_precision[datastructs.check_option.window.GetHashCode()] = 2;
            }
            else
            {
                digits_of_precision[datastructs.check_option.window.GetHashCode()] = 1;
                digits_of_precision[datastructs.check_option.window.GetHashCode()] = 1;
            }
            if (acq.window > max_value[datastructs.check_option.window.GetHashCode()])
            {
                acq.window = max_value[datastructs.check_option.window.GetHashCode()];
            }
            if (acq.delay > max_value[datastructs.check_option.delay.GetHashCode()])
            {
                acq.delay = max_value[datastructs.check_option.delay.GetHashCode()];
            }
        }

        public int resetEnc(int enc_no)
        {
            int err_code = 0;

            int mN = 1;
            int step;

            for (int i = 0; i < no_of_tries; i++)
            {
                if (enc_no == 0)
                {
                    step = enca.comp_step;
                    errorCode = op_wrp_SetEncoder(1, mN, step, enc_no);
                    if (errorCode == 0)
                    {
                        errorCode = op_wrp_SetEncoder(0, mN, step, enc_no);
                    }
                    if (errorCode == 0)
                    {
                        errorCode = op_wrp_SetEncoder(enca.enable, 0, step, enc_no);
                    }
                }
                else
                {
                    step = encb.comp_step;
                    errorCode = op_wrp_SetEncoder(1, mN, step, enc_no);
                    if (errorCode == 0)
                    {
                        errorCode = op_wrp_SetEncoder(0, mN, step, enc_no);
                    }
                    if (errorCode == 0)
                    {
                        errorCode = op_wrp_SetEncoder(encb.enable, 0, step, enc_no);
                    }
                }
                if (errorCode == 0)
                { // check if there were no errors
                    break;
                }
                System.Threading.Thread.Sleep(50);
            }
            if (errorCode != 0)
            {
                err_code = 25;
            }

            // Set encoder enable
            if (enc_no == 0)
            {
                errorCode = setEncEnable(enca.enable, enc_no);
            }
            if (enc_no == 1)
            {
                errorCode = setEncEnable(encb.enable, enc_no);
            }


            return err_code;
        }







    }
}
