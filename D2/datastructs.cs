using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
   public  class datastructs
    {
       // internal int window;

        public class acquisition_parameters {
            public int sampling_freq;
            public int mode;
            public double window;
            public double delay= 0.0D;
		}

        // Amplification
        public class amplifier_parameters {
            public int filter_bandtwidth;
            public int preamplifier;
            public int input_source;
            public int gain;
            public int gain_mode;
		}

        // Pulser
        public class pulser_parameters {
            public int amplitude_level;
            public float charging_time;
            public int enable;
		}

        // Trigger
        public class trigger_parameters {
            public int trigger_source;
            public double timer_period;
            public int xy_divider;
		}

        // Peak detectors
        public class peak_detector_parameters {
            public int enable;
            public int	mode;
            public double ref_pos;
            public double peak_ampl;
            public double peak_pos;
            public int ref_pos_opbox;
            public int max_val_opbox;
            public int max_pos_opbox;
            public int user_error;
		}

        // Struct containing all PD position conversions
        public class peak_detector_helpers {

            // Arrays containing positions of PDs in OPBOX manner

            public float[] pd_posX1_opbox;
           

            public float[] pd_posX2_opbox;
         


            public float[] pd_posY_opbox;
           

            // Arrays containing positions of PDs as real values
            public float[] pd_posX1_plot;
          

            public float[] pd_posX2_plot;
           

            public float[] pd_posY_plot;
          
            // Contains information about relative positions of Peak Detector points
           
            public float[] pd_posX1_rel;
          

            public float[] pd_posX2_rel;
          
            public float[] pd_posY_rel;
          

            // PD Positions sorted by peak detectors for DataBindXY
            public float[] pda_X_plot;
         

            public float[] pda_Y_plot;
         

            public float[] pdb_X_plot;
        

            public float[] pdb_Y_plot;
         

            public float[] pdc_X_plot;
         

            public float[] pdc_Y_plot;
          

        }

        // Encoders
        public class encoder_parameters {
            public int enable;
            public int input_mode;
            public int idx_input;
            public int decode_mode;
            public int filter;
            public int comp_step;
            public int comparator;
		}

        // Parameters stored purely for communication with OPBOX device
        public class all_parameters_structure {

            // Unique parameters -> 1 struct of data
            public acquisition_parameters acq;
            public amplifier_parameters ampl;
            public pulser_parameters puls;
            public trigger_parameters trig;

            // We can have max 3 peak detectors -> 3 structs of data
            public peak_detector_parameters pda;
            public peak_detector_parameters pdb;
            public peak_detector_parameters pdc;

            // We can have max 2 encoders -> 2 structs of data
            public encoder_parameters enca;
            public encoder_parameters encb;
		}

        // Data management structure
        public class data_structure {

            
            public byte[] data_buffer; // Contains data
            public int header_size; // = 54
            public int data_size; // = 262090

            // Contains converted data from the device
            //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
            //ORIGINAL LINE: float* main_dataX;
            public float[] main_dataX; // = gcnew array<float>(dataSize);
                                     //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
                                     //ORIGINAL LINE: System::Byte* main_dataY;
            public byte[] main_dataY; // = gcnew cli::array<System::Byte>(dataSize);

            // Contains reduced data used to plot the signal
            //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
            //ORIGINAL LINE: float* plot_dataX;
            public float[] plot_dataX; // = gcnew array<float>(plotDataSize);
                                     //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
                                     //ORIGINAL LINE: float* plot_dataY;
            public float[] plot_dataY; // = gcnew array<float>(plotDataSize);

            // Contains data reduced by calculating mean values out of full dataset
            //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
            //ORIGINAL LINE: System::Byte* mean_dataY;
            public byte[] mean_dataY;
        }

        // Parameters stored purely for sake of correct plotting
        public class plot_structure {
            public int delay_in_smpls;
            public int window_in_smpls;
            public double sampling_freq_real;
            public float min_x;
            public float max_x;
            public float min_y;
            public float max_y;
            public int plot_data_size;
            public int plot_algorithm;
		}

        // Initial structures
        public class opbox_init_structure
		{
            public int powerCheck;
            public int powerControl;
            public ushort info1;
            public ushort info2;
            public char version;
        }


        // It is more clear to use enums for looking through arrays
        // than to remember that

       
        public enum check_option
		{
			window = 0,
			delay,
			gain,
			charging_time,
			timer_period,
			comp_step = 5
		}
        public check_option check_optionProperty { get; set; }

        public enum peak_detectors
		{
			pd_a,
			pd_b,
			pd_c
		}

        public enum encoders
		{
			enc_a,
			enc_b
		}

        public encoders encodersProperty { get; set; }
    }
}
