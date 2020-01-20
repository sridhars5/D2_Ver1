using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static D2.datastructs;
namespace D2
{
  public  class Opboxheader
    {

       
       
        // Opbox parameters - unique data structs - Structures are defined in "datastructs.h"
        // Basic parameters
    //    public datastructs.acquisition_parameters acq = new datastructs.acquisition_parameters();
   //     public datastructs.amplifier_parameters ampl = new datastructs.amplifier_parameters();
  //      public datastructs.pulser_parameters puls = new datastructs.pulser_parameters();
  //      public datastructs.trigger_parameters trig = new datastructs.trigger_parameters();

        // Peak detectors
      //  public datastructs.peak_detector_parameters pda = new datastructs.peak_detector_parameters();
      //  public datastructs.peak_detector_parameters pdb = new datastructs.peak_detector_parameters();
      //  public datastructs.peak_detector_parameters pdc = new datastructs.peak_detector_parameters();
      //  public datastructs.peak_detector_helpers pd = new datastructs.peak_detector_helpers();

      //  // Encoders
      //  public datastructs.encoder_parameters enca = new datastructs.encoder_parameters();
      //  public datastructs.encoder_parameters encb = new datastructs.encoder_parameters();

      //  // Additional parameters necessary to manage OPBOX session
      ////  public datastructs.plot_structure plot = new datastructs.plot_structure();
      //  public datastructs.data_structure data = new datastructs.data_structure();
      //  public datastructs.opbox_init_structure init = new datastructs.opbox_init_structure();


      //  // Checked parameter names, which is used in the following notation for functions
      //  //C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
      //  public enum check_option { };
      //  //C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
      //  public enum peak_detectors { };
      //  //C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
      //  public enum Encoders { };

      //  // Restrictions for values
      ////  double min_value[6];
      //  public double[] min_value = new double[6];
      //  public double[] max_value = new double[6];
      //  public int[] digits_of_precision = new int[6];

      //  // Error code for error control checkout
      //  public int errorCode;

      //  // Number of attempts that methods of class will make to set correct value in OPBOX
      //  public int no_of_tries;
      //  internal int enc_a;
      //  internal int enc_b;




        // Constructor and destructor:
       
    //   Opbox();
     //   ~Opbox();

		// Initializes and finishes session properly
	//	int initSession();
	//	int endSession();

	//	// Functions to modify OPBOX parameters
	//		// Acquisition parameters	
	//	int setSamplingFreq(int);
	//	int setDataMode(int);
	//	int setDepth(int);
	//	int setDelay(int);

	//	// Amplifiers' parameters
	//	int setAnalogFilter(int);
	//	int setPreamplifier(int);
	//	int setInputSource(int);
	//	int setGain(int);
	//	int setGainMode(int);
	//	bool isAnalogValueCorrect();

	//	// Pulser parameters
	//	int setAmplitudeLevel(int);
	//	int setChargingTime(float);

	//	// Trigger parameters
	//	int setTriggerSource(int);
	//	int setTimerPeriod(double);
	//	int setXYDivider(int);

	//	// Peak Detectors' controls
	//	int setPdStartStopLevel(int, int, int, int);
	//	int setPdEnable(int, int);
	//	int setPdMode(int, int);
	// setPdUserErr(int a, int b);
	//	bool isPdEnabled(int);
	//	void setPeakDetector(int);
	//	void setPeakDetectors();

	//	// Peak Detectors' data conversions and updates		
	//	void convertPDToRfAbs();
	//	void convertPDToOpbox();
	//	void storePDRelativePositions();
	//	void recalculatePDPositions();
	//	void refreshPDArrays();
	//	//	int getPdResults(float* ref_pos, float* peak_pos, float* peak_value);

	//			// Encoders' controls
	//	int initEncoders();
	//	int setEncEnable(int, int);
	//	int setEncInputMode(int, int);
	//	int setEncIdxInput(int, int);
	//	int setEncDecodeMode(int, int);
	//	int setEncFilter(int, int);
	//	int setEncComparatorStep(int, int);
	//	int setEncComparator(int, int);
	//	int resetEnc(int);
	//	//	int getEncPositions(int* enca_position, int* encb_position);


	//			// Functions for data management:
	//	void collectData();
	//	//array<float>^ getCollectedData();
	//	System::Byte* selectRawData(int);
	//	void convertDataToRfAbs(System::Byte*, float*, int);
	//	void floatingMean(float*, System::Byte*, int, float*, System::Byte*, int);
	//	void meanMaxMin(float*, System::Byte*, int, float*, System::Byte*, int);
	//	void smallDataPlot(float*, System::Byte*, int, float*, float*);
	//	void recreateDataArrays();
	//	void updatePlotXAxis();
	//	//	void getPeakPosition(int*, int*, int*);

	//			// Functions for complex operations:
	//	void setSamplingFreqFull(int);
	//	void setDataModeFull(int);
	//	void setDepthFull(double);
	//	void setDelayFull(double);
	//	void setChargingTimeFull(float);

	//	// Internal functions used in complex public functions:
	//private void setWindow(double);
	//private void setDelay(double);


	//	   // Provides value control for most of the complex parameters, which are possible
	//	   // to be input by user
	//	   void refreshRestrictions();

	//	   // Value control - check constraints, correct it and returns valid value
	//public System.String^ inputCheck(System.String^ input, System.String^ previous_value, int parameter);
	}


}
