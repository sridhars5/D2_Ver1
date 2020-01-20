using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.Main;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.InteropServices;

using RGiesecke.DllExport;

namespace D2
{
    public partial class Form1 : Form
    {

        Opbox O = new Opbox();
        datastructs D = new datastructs();


        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_TrigEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_TrigEnable(int yes_no);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_StartSW", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_StartSW();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_Get_Power_Info", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_Get_Power_Info(int Power_ATRIBUTE);



        [System.Security.SuppressUnmanagedCodeSecurity]

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetDataHandle", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static  extern IntPtr op_wrp_GetDataHandle();


        public static byte[] op_wrp_GetDataHandleF(int length)
        {
            byte[] ReturnArray = new byte[length];
            Marshal.Copy(op_wrp_GetDataHandle(), ReturnArray, 0, length);
            return ReturnArray;
        }



        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_Check_Frame_Ready", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_Check_Frame_Ready();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetData", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetData(int Tlenth);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_Instr_RestetFIFO", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_Instr_RestetFIFO();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetDataHandle_Ptr", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetDataHandle_Ptr();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetDepth", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetDepth();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetDelay", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetDelay();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetAnalog", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetAnalog();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetEncoderPosit", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_GetEncoderPosit(int nr);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_CheckPeakFound", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_CheckPeakFound(ref int A, ref int B, ref int C);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_TrigReset", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_TrigReset();


        private static int dataSize = 252090;
        private static int plotDataSize = 750;//20000;

        // Integer meaning selected algorithm for display
        public static int plot_algorithm = 0; // 0 = averaging, 1 = max_min_algorithm

        // Stores information whether or not measurement is in progress
        public static bool measurementInProgress = false;

        // Testing panel - boolean containing information about panel used for tests
        public static bool testing_enabled = false;

        // Race condition prevention - we put out external flags when threads are done
        public static bool plot_bgworker_finished = false;
        public static bool data_bgworker_finished = false;

        // Testing new gain controlling events - switching variable
        public static bool gain_changed = false;
        public static bool window_changed = false;
        public static bool delay_changed = false;
        public static bool charging_time_changed = false;
        public static bool timer_period_changed = false;
        public static bool enca_comparator_step_changed = false;
        public static bool encb_comparator_step_changed = false;

        // Counters required for FPS calculations
        // FPS - how many frames are we able to collect from the device
        // (FPS is NOT EQUAL to plot refreshing frequency, which is much lower than that!)
        public static int counter_begin = 0;
        public static int counter_end = 0;

        // Contains plot-cursor coordinates in XY coordinates
        public static float cursorPosX = 0.0F;
        public static float cursorPosY = 0.0F;

        // Contains plot-cursor coordinates in pixels
        public static int cursorPosXpx = 0;
        public static int cursorPosYpx = 0;

        // Sample data - testing only
        private static double[] sampleDataX = new double[dataSize];
        private static double[] sampleDataY = new double[dataSize];

        // Bool containing information about modification of PD (modifiable by mouse events)
        public static bool pd_change = false;

        // Integer containing information about selected point after clicking on main plot
        public static int pd_selected = -1;

        // Contains data from the device (now: generated data)
        //	private: static array<float> ^ main_dataX = gcnew array<float>(dataSize);
        //	private: static cli::array<System::Byte> ^ main_dataY = gcnew cli::array<System::Byte>(dataSize);

        // External arrays holding data arrays converted to managed types for plot (separated from OPBOX)
        private static float[] ext_plot_dataX = new float[plotDataSize]; //createManagedArr(opbox->data.plot_dataX, opbox->plot.plot_data_size);
        private static float[] ext_plot_dataY = new float[plotDataSize]; //createManagedArr(opbox->data.plot_dataY, opbox->plot.plot_data_size);

        // PD Positions in pixels
        private static float[] pda_X_px = new float[2];
        private static float[] pda_Y_px = new float[2];
        private static float[] pdb_X_px = new float[2];
        private static float[] pdb_Y_px = new float[2];
        private static float[] pdc_X_px = new float[2];
        private static float[] pdc_Y_px = new float[2];

        // init_err just makes sure we don't ask user stupid questions when it is obvious
        // that OPBOX is not connected.
        private static int init_err = 0;


        public int pda_found;
        public int pdb_found;
        public int pdc_found;

        public static UsbDevice MyUsbDevice;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomNumbers.Seed((int)DateTime.Now.Ticks);

            // Initialize Chart - Area for plot
            main_chart.ChartAreas.Add("main_area");

            main_chart.ChartAreas["main_area"].AxisX.Minimum = O.plot.min_x;
            main_chart.ChartAreas["main_area"].AxisX.Maximum = O.plot.max_x;
            main_chart.ChartAreas["main_area"].AxisX.Interval = (O.plot.max_x - O.plot.min_x) / 25;

            main_chart.ChartAreas["main_area"].AxisY.Minimum = O.plot.min_y;
            main_chart.ChartAreas["main_area"].AxisY.Maximum = O.plot.max_y;
            main_chart.ChartAreas["main_area"].AxisY.Interval = (O.plot.max_y - O.plot.min_y) / 10;

            main_chart.ChartAreas["main_area"].BackColor = System.Drawing.Color.Teal;

            main_chart.Series.Add("main_data");
            main_chart.Series["main_data"].Color = System.Drawing.Color.Yellow;

            // Sample  signal generated here
            float rand_factor = (float)(0.2 + (float)RandomNumbers.NextNumber() / ((float)(Int32.MaxValue / (0.5 - 0.2))));

            for (int i = 0; i < O.plot.window_in_smpls; i++)
            {
                O.data.main_dataX[i] = (byte)(O.plot.min_x + i * (O.plot.max_x - O.plot.min_x) / O.plot.window_in_smpls);
                O.data.main_dataY[i] = (byte)(1.5 + rand_factor * (0.8 * (i % 120)) * Math.Sin(O.data.main_dataX[i] * (i % 120) * 0.01));
            }

            O.floatingMean(O.data.main_dataX, O.data.main_dataY, O.plot.window_in_smpls, O.data.plot_dataX, O.data.mean_dataY, O.plot.plot_data_size);
            O.convertDataToRfAbs(O.data.mean_dataY, O.data.plot_dataY, O.plot.plot_data_size);

            float[] ext_plot_dataX = createManagedArr(O.data.plot_dataX, O.plot.plot_data_size);
            float[] ext_plot_dataY = createManagedArr(O.data.plot_dataY, O.plot.plot_data_size);

            main_chart.Series["main_data"].Points.DataBindXY(ext_plot_dataX, ext_plot_dataY);
            main_chart.Series["main_data"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

            // Add peak detectors and format its' appearance
            // PDA:
            main_chart.Series.Add("pd_a");
            main_chart.Series["pd_a"].Color = System.Drawing.Color.OrangeRed;
            main_chart.Series["pd_a"].BorderWidth = 2;
            main_chart.Series["pd_a"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            main_chart.Series["pd_a"].Enabled = true;
            main_chart.Series["pd_a"].Points.DataBindXY(createManagedArr(O.pd.pda_X_plot, 2), createManagedArr(O.pd.pda_Y_plot, 2));
            main_chart.Series["pd_a"].MarkerSize = 5;
            main_chart.Series["pd_a"].MarkerStep = 1;
            main_chart.Series["pd_a"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            main_chart.Series["pd_a"].MarkerColor = System.Drawing.Color.OrangeRed;
            main_chart.Series["pd_a"].MarkerBorderColor = System.Drawing.Color.Crimson;
            main_chart.Series["pd_a"].MarkerBorderWidth = 2;

            // PDB:
            main_chart.Series.Add("pd_b");
            main_chart.Series["pd_b"].Color = System.Drawing.Color.LawnGreen;
            main_chart.Series["pd_b"].BorderWidth = 2;
            main_chart.Series["pd_b"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            main_chart.Series["pd_b"].Points.DataBindXY(createManagedArr(O.pd.pdb_X_plot, 2), createManagedArr(O.pd.pdb_Y_plot, 2));
            main_chart.Series["pd_b"].MarkerSize = 5;
            main_chart.Series["pd_b"].MarkerStep = 1;
            main_chart.Series["pd_b"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            main_chart.Series["pd_b"].MarkerColor = System.Drawing.Color.Lime;
            main_chart.Series["pd_b"].MarkerBorderColor = System.Drawing.Color.LimeGreen;
            main_chart.Series["pd_b"].MarkerBorderWidth = 2;

            // PDC:
            main_chart.Series.Add("pd_c");
            main_chart.Series["pd_c"].Color = System.Drawing.Color.Aqua;
            main_chart.Series["pd_c"].BorderWidth = 2;
            main_chart.Series["pd_c"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            main_chart.Series["pd_c"].Points.DataBindXY(createManagedArr(O.pd.pdc_X_plot, 2), createManagedArr(O.pd.pdc_Y_plot, 2));
            main_chart.Series["pd_c"].MarkerSize = 5;
            main_chart.Series["pd_c"].MarkerStep = 1;
            main_chart.Series["pd_c"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            main_chart.Series["pd_c"].MarkerColor = System.Drawing.Color.Aqua;
            main_chart.Series["pd_c"].MarkerBorderColor = System.Drawing.Color.DeepSkyBlue;
            main_chart.Series["pd_c"].MarkerBorderWidth = 2;

            // Some changes to make our chart prettier
            main_chart.ChartAreas["main_area"].AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            main_chart.ChartAreas["main_area"].AxisX.Title = "Time [us]";
            main_chart.ChartAreas["main_area"].AxisX.TitleFont = (new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte)238));
            main_chart.ChartAreas["main_area"].AxisY.IsLabelAutoFit = false;
            main_chart.ChartAreas["main_area"].AxisY.LabelStyle.Font = (new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte)238));
            main_chart.ChartAreas["main_area"].AxisY.Title = "Amplitude [V]";
            main_chart.ChartAreas["main_area"].AxisY.TitleFont = (new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte)238));




            // Try to turn on the device a few times and initialize its variables with values defined in class OPBOX
            // - they are hard-coded now, but may be loaded from a file in the future if needed

            // We make sure '0' code is set after we check on initSession error
            O.errorCode = 6;

            for (int i = 1; i <= (O.no_of_tries + 1); i++)
            {

                if (O.errorCode != 0)
                {
                    if (i <= (O.no_of_tries))
                    {

                        if (measurementInProgress)
                        {
                            turnOffAcquisition();
                        }

                        O.errorCode = O.initSession();
                        measurementInProgress = true;

                        if (measurementInProgress && (O.errorCode == 0))
                        {
                            turnOnAcquisition();
                        }

                        if (op_wrp_Get_Power_Info(16) != 0)
                        {
                            string error_string = string.Concat("Power error - Check OPBOX! Retry no.: ", Convert.ToString(i));
                            MessageBox.Show(error_string, "OPBOX 2.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            //opbox->errorCode = opbox->initSession();
                            power_ctrl_timer.Enabled = true;
                            break;
                        }
                    }
                    if (i > O.no_of_tries)
                    {
                        init_err = 1;
                        string error_string = string.Concat("OPBOX Init error. Reconnect OPBOX and restart application! Initial error code: ", Convert.ToString(O.errorCode));
                        MessageBox.Show(error_string, "OPBOX 2.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                        return;
                    }
                }
            }

            // Display OPBOX version and basic information, which guarantee us correct initialization


            string infoDisp = $"OPBOX SN{ O.init.info1}.{ O.init.info2}v:{O.init.version}";
           
            info_disp_ctrl.Text = infoDisp;

            // Acquisition parameters
            sampling_freq_ctrl.SelectedIndex = O.acq.sampling_freq;
            mode_ctrl.SelectedIndex = O.acq.mode;
            window_ctrl.Text = Convert.ToString(O.acq.window);
            delay_ctrl.Text = Convert.ToString(O.acq.delay);
            plot_algorithm_ctrl.SelectedIndex = plot_algorithm;

            // Amplifiers' parameters
            filter_bandtwidth_ctrl.SelectedIndex = O.ampl.filter_bandtwidth;
            preamplifier_ctrl.SelectedIndex = O.ampl.preamplifier;
            input_source_ctrl.SelectedIndex = O.ampl.input_source;
            gain_ctrl.Text = Convert.ToString(O.ampl.gain);
            gain_mode_ctrl.SelectedIndex = O.ampl.gain_mode;

            // Pulser parameters
            amplitude_level_ctrl.SelectedIndex = O.puls.amplitude_level;
            charging_time_ctrl.Text = Convert.ToString(O.puls.charging_time);

            // Trigger parameters
            trigger_source_ctrl.SelectedIndex = O.trig.trigger_source;
            timer_period_ctrl.Text = Convert.ToString(O.trig.timer_period);
            xy_divider_ctrl.SelectedIndex = O.trig.xy_divider;

            // Peak Detectors' controls
            // PDA
            pda_enable_ctrl.Checked = (O.pda.enable == 1);
            pda_mode_ctrl.SelectedIndex = O.pda.mode;
            pda_ref_position_ctrl.Text = Convert.ToString(O.pda.ref_pos);
            pda_peak_amplitude_ctrl.Text = Convert.ToString(O.pda.peak_ampl);
            pda_peak_position_ctrl.Text = Convert.ToString(O.pda.peak_pos);
            // PDB
            pdb_enable_ctrl.Checked = (O.pdb.enable == 1);
            pdb_mode_ctrl.SelectedIndex = O.pdb.mode;
            pdb_ref_position_ctrl.Text = Convert.ToString(O.pdb.ref_pos);
            pdb_peak_amplitude_ctrl.Text = Convert.ToString(O.pdb.peak_ampl);
            pdb_peak_position_ctrl.Text = Convert.ToString(O.pdb.peak_pos);
            // PDC
            pdc_enable_ctrl.Checked = (O.pdc.enable == 1);
            pdc_mode_ctrl.SelectedIndex = O.pdc.mode;
            pdc_ref_position_ctrl.Text = Convert.ToString(O.pdc.ref_pos);
            pdc_peak_amplitude_ctrl.Text = Convert.ToString(O.pdc.peak_ampl);
            pdc_peak_position_ctrl.Text = Convert.ToString(O.pdc.peak_pos);

            // Encoders' controls
            // Encoder A
            enca_enable_ctrl.Checked = (O.enca.enable == 1);
            enca_input_mode_ctrl.SelectedIndex = O.enca.input_mode;
            enca_idx_input_ctrl.SelectedIndex = O.enca.idx_input;
            enca_decode_mode_ctrl.SelectedIndex = O.enca.decode_mode;
            enca_filter_ctrl.SelectedIndex = O.enca.filter;
            enca_comparator_step_ctrl.Text = Convert.ToString(O.enca.comp_step);
            enca_comparator_ctrl.SelectedIndex = O.enca.comparator;
            // Encoder B
            encb_enable_ctrl.Checked = (O.encb.enable == 1);
            encb_input_mode_ctrl.SelectedIndex = O.encb.input_mode;
            encb_idx_input_ctrl.SelectedIndex = O.encb.idx_input;
            encb_decode_mode_ctrl.SelectedIndex = O.encb.decode_mode;
            encb_filter_ctrl.SelectedIndex = O.encb.filter;
            encb_comparator_step_ctrl.Text = Convert.ToString(O.encb.comp_step);
            encb_comparator_ctrl.SelectedIndex = O.encb.comparator;

            // Finally, plot data
            displayData();

            // We need dots as separator in double numbers, so we switch to american-style number formatting
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            main_chart.Refresh();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (!measurementInProgress)
            {
                measurementInProgress = true;
                btn_start.BackColor = System.Drawing.Color.Lime;
                btn_start.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
                btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
                btn_start.ForeColor = System.Drawing.Color.Black;
                btn_start.Text = "RUNNING...";
                O.errorCode = turnOnAcquisition();
            }
            else
            {
                measurementInProgress = false;
                btn_start.BackColor = System.Drawing.Color.LightGreen;
                btn_start.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
                btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
                btn_start.ForeColor = System.Drawing.Color.Black;

                btn_start.Text = "START";
                O.errorCode = turnOffAcquisition();
            }

        }


        public void displayData()
        {
            main_chart.Series["main_data"].Points.DataBindXY(ext_plot_dataX, ext_plot_dataY);
            main_chart.Refresh();
            
        }

        public int turnOffAcquisition()
        {

            plot_timer.Enabled = false;

            if ((pda_enable_ctrl.CheckState == CheckState.Checked) || (pdb_enable_ctrl.CheckState == CheckState.Checked) || (pdc_enable_ctrl.CheckState == CheckState.Checked))
            {
                pd_results_timer.Enabled = false;
            }

            if ((enca_enable_ctrl.CheckState == CheckState.Checked) || (encb_enable_ctrl.CheckState == CheckState.Checked))
            {
                enc_results_timer.Enabled = false;
            }

            // Disabling trigger will throw error if turning off was called by
            // power_check_ctrl detecting any connection with OPBOX failures...
            if (op_wrp_Get_Power_Info(16) == 0)
            {
                for (int i = 0; i < (O.no_of_tries); i++)
                {
                    O.errorCode = op_wrp_TrigEnable(0);
                    if (O.errorCode == 0)
                        break;
                }
            }

            if ((O.errorCode == 0) || (op_wrp_Get_Power_Info(16) != 0))
            {
                if (plot_bgworker.IsBusy)
                {
                    plot_bgworker.CancelAsync();
                }
                if (data_bgworker.IsBusy)
                {
                    data_bgworker.CancelAsync();
                }

                turnOffTimers();
                while ((plot_bgworker.IsBusy) || (data_bgworker.IsBusy))
                { // Continue to process events until both workers stop working
                    Application.DoEvents(); // Then, you can process another thread requests! :)
                }
                //turnOnTimers();
            }

            return (O.errorCode);
        }

        private void turnOffTimers()
        {
            err_timer.Enabled = false;
            pd_results_timer.Enabled = false;
            pd_timer.Enabled = false;
            fps_timer.Enabled = false;
            enc_results_timer.Enabled = false;
        }

        public int turnOnAcquisition()
        {

            for (int i = 0; i < O.no_of_tries; i++)
            {
                O.errorCode = op_wrp_TrigEnable(1);
                O.errorCode = op_wrp_StartSW();
                if (O.errorCode == 0)
                    break;
            }

            if (O.errorCode == 0)
            {
                if (!plot_bgworker.IsBusy)
                {
                    plot_bgworker.RunWorkerAsync();
                }
                if (!data_bgworker.IsBusy)
                {
                    data_bgworker.RunWorkerAsync();
                }

                //turnOffTimers();
                while ((!plot_bgworker.IsBusy) || (!data_bgworker.IsBusy))
                { // Continue to process events until both workers start working
                    Application.DoEvents(); // Then, you can process another thread requests! :)
                }
                turnOnTimers();

                plot_timer.Enabled = true;

                if ((pda_enable_ctrl.CheckState == CheckState.Checked) || (pdb_enable_ctrl.CheckState == CheckState.Checked) || (pdc_enable_ctrl.CheckState == CheckState.Checked))
                {
                    pd_results_timer.Enabled = true;
                }

                if ((enca_enable_ctrl.CheckState == CheckState.Checked) || (encb_enable_ctrl.CheckState == CheckState.Checked))
                {
                    enc_results_timer.Enabled = true;
                }
            }
            else
            {
                string error_string = "TURN ON acquisition error!";
                MessageBox.Show(error_string, "OPBOX 2.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return (O.errorCode);
        }


        private void turnOnTimers()
        {
            err_timer.Enabled = true;
            fps_timer.Enabled = true;
            if ((O.enca.enable == 1) || (O.encb.enable == 1))
            {
                enc_results_timer.Enabled = true;
            }
            if ((O.pda.enable == 1) || (O.pdb.enable == 1) || (O.pdc.enable == 1))
            {
                pd_results_timer.Enabled = true;
                pd_timer.Enabled = true;
            }
        }

        //Create Memory 

        public byte[] createManagedArr(byte[] arr, int arr_size)
        {
            byte[] managedArray = new byte[arr_size];
            for (int i = 0; i < arr_size; i++)
            {

                managedArray[i] = (byte)(arr[i]);


                // managedArray[i] =(byte)(arr.Length);
            }
            return managedArray;
        }

        public void copyToManagedArr(float[] unmanaged_arr,  float[] managed_arr, int arr_size)
        {
            for (int i = 0; i < arr_size; i++)
            {
                managed_arr[i] = unmanaged_arr[i];
            }
        }

        // Float array management
        //C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'arr', so pointers on this parameter are left unchanged:
        public float[] createManagedArr(float[] arr, int arr_size)
        {


            float[] managedArray = new float[arr_size];

            for (int i = 0; i < arr_size; ++i)
            {
                managedArray[i] = (float)(arr[i]);


            }
            return managedArray;
        }

        public void copyToManagedArr(float[] unmanaged_arr, ref float[] managed_arr, int arr_size)
        {
            for (int i = 0; i < arr_size; i++)
            {
                managed_arr[i] = unmanaged_arr[i];
            }
        }

        private void test_mode_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void test_mode_btn_Click(object sender, EventArgs e)
        {
            if (testing_enabled)
            {

                testing_enabled = false;

                // Show the panel:
                test_panel.Enabled = false;
                test_panel.Visible = false;

                // Turn off Encoders' testers
                enc_results_timer.Enabled = false;

                // Switch appearance of our button:
                test_mode_btn.Text = "OFF";
                test_mode_btn.ForeColor = System.Drawing.Color.Black;
            }

            // What happens when we turn it ON:
            else
            {

                testing_enabled = true;

                // Hide the panel:
                test_panel.Enabled = true;
                test_panel.Visible = true;

                // Turn on Encoders' testers:
                if ((O.enca.enable == 1) || (O.encb.enable == 1))
                {
                    enc_results_timer.Enabled = true;
                }

                // Switch appearance of our button:
                test_mode_btn.Text = "ON";
                test_mode_btn.ForeColor = System.Drawing.Color.Yellow;

                // Refresh all parameters displayed by controls:
                window_test.Text = numToMStr(op_wrp_GetDepth()); // Display depth in samples
                delay_test.Text = numToMStr(op_wrp_GetDelay()); // Display delay in samples
                filter_test.Text = intToMStrHex(op_wrp_GetAnalog()); // Display register including filter bandtwidth, input source and gain
                ampl_test.Text = numToMStr(O.ampl.preamplifier); // Display value sent to OPBOX as amplitude level parameter
                source_test.Text = numToMStr(O.ampl.input_source); // Display value sent to OPBOX as input source
                amplitude_level_test.Text = numToMStr(O.puls.amplitude_level); // Display value sent to OPBOX as amplitude level
                if (O.enca.enable == 1)
                {
                    enca_test.Text = numToMStr(op_wrp_GetEncoderPosit(0)); // Display Encoder A position in samples
                }
                else
                {
                    enca_test.Text = "Disabled";
                }

                if (O.encb.enable == 1)
                {
                    encb_test.Text = numToMStr(op_wrp_GetEncoderPosit(1)); // Display Encoder B position in samples
                }
                else
                {
                    encb_test.Text = "Disabled";
                }
                pd_txt.Text = "START"; // Display information about actions on Peak Detectors
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void pd_timer_Tick(object sender, EventArgs e)
        {
            // We check if any kind of error occured by checking values
            // - all 0's returned from OPBOX is a fair sign that we somehow lost peak detector
            for (int pd_no = 0; pd_no < 3; pd_no++)
            {

                if ((!isPDResultCorrect(pd_no)) && (isUserPDSetupCorrect(pd_no)))
                { // if that happens for any PD, we simply set it again
                    for (int i = 0; i <= O.no_of_tries; i++)
                    {
                        if (O.isPdEnabled(pd_no))
                        {
                            O.setPdEnable(0, pd_no);
                            O.setPdEnable(1, pd_no);
                        }
                        O.setPeakDetector(pd_no);

                        // After 5 retries, we can safely assume that user set it incorrectly
                        if (!isPDResultCorrect(pd_no) && (i == O.no_of_tries))
                        {
                            O.setPdUserErr(pd_no, 1);
                        }
                    }
                }
            }
            displayPD();


            // HEREHERE - Test values from Opbox
            if (testing_enabled)
            {

                // Opbox values
                pda_test_level_opbox.Text = Convert.ToString(O.pda.max_val_opbox);
                pdb_test_level_opbox.Text = Convert.ToString(O.pdb.max_val_opbox);
                pdc_test_level_opbox.Text = Convert.ToString(O.pdc.max_val_opbox);

                pda_test_min_opbox.Text = Convert.ToString(O.pda.ref_pos_opbox);
                pdb_test_min_opbox.Text = Convert.ToString(O.pdb.ref_pos_opbox);
                pdc_test_min_opbox.Text = Convert.ToString(O.pdc.ref_pos_opbox);

                pda_test_max_opbox.Text = Convert.ToString(O.pda.max_pos_opbox);
                pdb_test_max_opbox.Text = Convert.ToString(O.pdb.max_pos_opbox);
                pdc_test_max_opbox.Text = Convert.ToString(O.pdc.max_pos_opbox);

                // Plot values
                pda_test_y_plot.Text = Convert.ToString(O.pd.pd_posY_plot[0]);
                pdb_test_y_plot.Text = Convert.ToString(O.pd.pd_posY_plot[1]);
                pdc_test_y_plot.Text = Convert.ToString(O.pd.pd_posY_plot[2]);

                pda_test_x1_plot.Text = Convert.ToString(O.pd.pd_posX1_plot[0]);
                pdb_test_x1_plot.Text = Convert.ToString(O.pd.pd_posX1_plot[1]);
                pdc_test_x1_plot.Text = Convert.ToString(O.pd.pd_posX1_plot[2]);

                pda_test_x2_plot.Text = Convert.ToString(O.pd.pd_posX2_plot[0]);
                pdb_test_x2_plot.Text = Convert.ToString(O.pd.pd_posX2_plot[1]);
                pdc_test_x2_plot.Text = Convert.ToString(O.pd.pd_posX2_plot[2]);

                // Peak detection


                op_wrp_CheckPeakFound(ref pda_found, ref pdb_found, ref pdc_found);

                if (pda_found == 1)
                {
                    pda_test_detection.Text = "YES";
                }
                else
                {
                    pda_test_detection.Text = "NO";
                }

                if (pdb_found == 1)
                {
                    pdb_test_detection.Text = "YES";
                }
                else
                {
                    pdb_test_detection.Text = "NO";
                }

                if (pdc_found == 1)
                {
                    pdc_test_detection.Text = "YES";
                }
                else
                {
                    pdc_test_detection.Text = "NO";
                }

            }

        }


        private void displayPD()
        {
            O.refreshPDArrays();
            if (O.pda.enable == 1)
            {
                main_chart.Series["pd_a"].Points.DataBindXY(createManagedArr(O.pd.pda_X_plot, 2), createManagedArr(O.pd.pda_Y_plot, 2));
            }
            if (O.pdb.enable == 1)
            {
                main_chart.Series["pd_b"].Points.DataBindXY(createManagedArr(O.pd.pdb_X_plot, 2), createManagedArr(O.pd.pdb_Y_plot, 2));
            }
            if (O.pdc.enable == 1)
            {
                main_chart.Series["pd_c"].Points.DataBindXY(createManagedArr(O.pd.pdc_X_plot, 2), createManagedArr(O.pd.pdc_Y_plot, 2));
            }
            main_chart.Refresh();
        }

        private bool isUserPDSetupCorrect(int pd_no)
        {
            switch (pd_no)
            {
                case 0:
                    if (O.pda.user_error != 0)
                    {
                        return false;
                    }
                    break;
                case 1:
                    if (O.pdb.user_error != 0)
                    {
                        return false;
                    }
                    break;
                case 2:
                    if (O.pdc.user_error != 0)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }

        private bool isPDResultCorrect(int pd_no)
        {
            switch (pd_no)
            {
                case 0:
                    if ((O.pda.ref_pos_opbox == 0) && (O.pda.max_val_opbox == 0) && (O.pda.max_pos_opbox == 0))
                    {
                        return false;
                    }
                    break;
                case 1:
                    if ((O.pdb.ref_pos_opbox == 0) && (O.pdb.max_val_opbox == 0) && (O.pdb.max_pos_opbox == 0))
                    {
                        return false;
                    }
                    break;
                case 2:
                    if ((O.pdc.ref_pos_opbox == 0) && (O.pdc.max_val_opbox == 0) && (O.pdc.max_pos_opbox == 0))
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }

        private void fps_timer_Tick(object sender, EventArgs e)
        {
            int fps_value = counter_end - counter_begin;
            fps_display.Text = numToMStr(fps_value);
            counter_begin = counter_end;

        }

        private void plot_timer_Tick(object sender, EventArgs e)
        {
            displayData();
        }

        private void plot_bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            plot_bgworker_finished = false;

            // Collect data until one of events cancels it
            while (true)
            {
                System.Threading.Thread.Sleep(40); // We need to display our signal at reasonable rate - plot might
                O.collectData(); // not be able to refresh fast enough (now it is set at 40 FPS)
                if (O.plot.window_in_smpls >= O.plot.plot_data_size)
                {
                    copyToManagedArr(O.data.plot_dataX, ext_plot_dataX, O.plot.plot_data_size);
                    copyToManagedArr(O.data.plot_dataY, ext_plot_dataY, O.plot.plot_data_size);
                }
                else
                {
                    copyToManagedArr(O.data.plot_dataX,  ext_plot_dataX, O.plot.window_in_smpls);
                    copyToManagedArr(O.data.plot_dataY,  ext_plot_dataY, O.plot.window_in_smpls);
                }

                if (plot_bgworker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
            return;

        }

        private void err_timer_Tick(object sender, EventArgs e)
        {
            err_display.Text = numToMStr(O.errorCode);

        }

        private void power_ctrl_timer_Tick(object sender, EventArgs e)
        {
            // We check if everything is fine with connection to OPBOX
            // If it isn't, throw error notification and after user reconnected OPBOX,
            // set previous parameters again and reset form
            if (op_wrp_Get_Power_Info(16) != 0)
            { // (false)

                // We don't need to flood user with error messages when it happens
                // - they might try to suicide or have heart attack :)
                power_ctrl_timer.Enabled = false;

                // We need to stop displaying or getting data immediately
                if (measurementInProgress)
                {
                    O.errorCode = turnOffAcquisition();
                }

                int error_read = O.errorCode;

                // Try until we get rid of error or user decides to close application
                for (int i = 1; i <= O.no_of_tries; i++)
                {
                    if (i <= O.no_of_tries)
                    {
                        O.errorCode = O.initSession();
                        if (op_wrp_Get_Power_Info(1) != 1)
                        {
                            power_ctrl_timer.Enabled = false;
                            string error_string = string.Concat("Power error - Check OPBOX! Retry no.: ", Convert.ToString(i));
                            MessageBox.Show(error_string, "OPBOX 2.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {

                            // Everything is fine now, we can start collecting data if we did it earlier
                            if (measurementInProgress)
                            {
                                for (int j = 0; j <= O.no_of_tries; j++)
                                {
                                    O.errorCode = turnOffAcquisition(); // First, we must make sure we finish previous acquisition correctly.
                                    if (O.errorCode == 0)
                                    {
                                        O.errorCode = turnOnAcquisition(); // Then, we start acquisition if everything is fine.
                                        break;
                                    }
                                    else if (j == O.no_of_tries)
                                        break;
                                }
                            }
                            power_ctrl_timer.Enabled = true; // Turn on power check control again
                            break;
                        }
                        if (i == O.no_of_tries)
                        {
                            i++;
                        }
                    }

                    if (i > O.no_of_tries)
                    {
                        string error_string = "Power error - Connect OPBOX and restart application!";
                        MessageBox.Show(error_string, "OPBOX 2.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                        return;
                    }
                }
            }

        }

        private void enc_results_timer_Tick(object sender, EventArgs e)
        {
            if (O.enca.enable == 1)
            {
                enca_test.Text = numToMStr(op_wrp_GetEncoderPosit(0));
            }
            else
            {
                enca_test.Text = "Disabled";
            }
            if (O.encb.enable == 1)
            {
                encb_test.Text = numToMStr(op_wrp_GetEncoderPosit(1));
            }
            else
            {
                encb_test.Text = "Disabled";
            }

        }

        private void pd_results_timer_Tick(object sender, EventArgs e)
        {
            // Calculate peak detectors' values collected by OPBOX
            O.pda.ref_pos_opbox = O.data.data_buffer[19] + (1 << 8) * O.data.data_buffer[20] + (1 << 16) * (O.data.data_buffer[21] % 2);
            O.pdb.ref_pos_opbox = O.data.data_buffer[29] + (1 << 8) * O.data.data_buffer[30] + (1 << 16) * (O.data.data_buffer[31] % 2);
            O.pdc.ref_pos_opbox = O.data.data_buffer[39] + (1 << 8) * O.data.data_buffer[40] + (1 << 16) * (O.data.data_buffer[41] % 2);

            O.pda.max_pos_opbox = O.data.data_buffer[25] + (1 << 8) * O.data.data_buffer[26] + (1 << 16) * (O.data.data_buffer[27] % 2);
            O.pdb.max_pos_opbox = O.data.data_buffer[35] + (1 << 8) * O.data.data_buffer[36] + (1 << 16) * (O.data.data_buffer[37] % 2);
            O.pdc.max_pos_opbox = O.data.data_buffer[45] + (1 << 8) * O.data.data_buffer[46] + (1 << 16) * (O.data.data_buffer[47] % 2);

            O.pda.max_val_opbox = O.data.data_buffer[23];
            O.pdb.max_val_opbox = O.data.data_buffer[33];
            O.pdc.max_val_opbox = O.data.data_buffer[43];

            // Convert collected values to plot units
            O.pda.ref_pos = Math.Round(O.pda.ref_pos_opbox / O.plot.sampling_freq_real * 100.0) / 100.0 + O.acq.delay;
            O.pdb.ref_pos = Math.Round(O.pdb.ref_pos_opbox / O.plot.sampling_freq_real * 100.0) / 100.0 + O.acq.delay;
            O.pdc.ref_pos = Math.Round(O.pdc.ref_pos_opbox / O.plot.sampling_freq_real * 100.0) / 100.0 + O.acq.delay;

            if (O.acq.mode == 0)
            { // RF
                O.pda.peak_ampl = Math.Round((O.pda.max_val_opbox / 256.0 - 0.5) * 100.0) / 100.0;
                O.pdb.peak_ampl = Math.Round((O.pdb.max_val_opbox / 256.0 - 0.5) * 100.0) / 100.0;
                O.pdc.peak_ampl = Math.Round((O.pdc.max_val_opbox / 256.0 - 0.5) * 100.0) / 100.0;
            }
            else
            { // ABS
                O.pda.peak_ampl = Math.Round(O.pda.max_val_opbox / 2.56 * 100.0 * 2.0) / 100.0;
                O.pdb.peak_ampl = Math.Round(O.pdb.max_val_opbox / 2.56 * 100.0 * 2.0) / 100.0;
                O.pdc.peak_ampl = Math.Round(O.pdc.max_val_opbox / 2.56 * 100.0 * 2.0) / 100.0;
            }

            O.pda.peak_pos = Math.Round(O.pda.max_pos_opbox / O.plot.sampling_freq_real * 100.0) / 100.0 + O.acq.delay;
            O.pdb.peak_pos = Math.Round(O.pdb.max_pos_opbox / O.plot.sampling_freq_real * 100.0) / 100.0 + O.acq.delay;
            O.pdc.peak_pos = Math.Round(O.pdc.max_pos_opbox / O.plot.sampling_freq_real * 100.0) / 100.0 + O.acq.delay;

            // Display it inside our indicators
            if (O.pda.enable == 1)
            {
                pda_ref_position_ctrl.Text = numToMStr(O.pda.ref_pos);
                pda_peak_amplitude_ctrl.Text = numToMStr(O.pda.peak_ampl);
                pda_peak_position_ctrl.Text = numToMStr(O.pda.peak_pos);
            }

            if (O.pdb.enable == 1)
            {
                pdb_ref_position_ctrl.Text = numToMStr(O.pdb.ref_pos);
                pdb_peak_amplitude_ctrl.Text = numToMStr(O.pdb.peak_ampl);
                pdb_peak_position_ctrl.Text = numToMStr(O.pdb.peak_pos);
            }
            if (O.pdc.enable == 1)
            {
                pdc_ref_position_ctrl.Text = numToMStr(O.pdc.ref_pos);
                pdc_peak_amplitude_ctrl.Text = numToMStr(O.pdc.peak_ampl);
                pdc_peak_position_ctrl.Text = numToMStr(O.pdc.peak_pos);
            }

        }

        private void data_bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            O.data.data_buffer = op_wrp_GetDataHandleF(100000);

            // Remove flag which informs about finishing this thread
            plot_bgworker_finished = false;

            // Collect frames once they are available, until we cancel this task by
            // clicking the 'btn_start' again
            while (true)
            {
                if (op_wrp_Check_Frame_Ready() == 1)
                {
                    O.errorCode = op_wrp_GetData((O.plot.window_in_smpls) + (O.data.header_size));

                    if (O.trig.trigger_source == 0) // Otherwise, trigger doesnt need to be done by software
                    {
                        op_wrp_StartSW();
                    }
                    counter_end++;
                }
                if (data_bgworker.CancellationPending)
                {
                    op_wrp_Instr_RestetFIFO();
                    e.Cancel = true;
                    counter_begin = 0;
                    counter_end = 0;
                    return;
                }
            }

        }

        private void pd_disp_bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                replaceNearestPoint(cursorPosXpx, cursorPosYpx);
                if (testing_enabled)
                {
                    pd_txt.Text = numToMStr(pd_selected);
                }

                if (pd_disp_bgworker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
            return;

        }

        private void main_chart_MouseLeave(object sender, EventArgs e)
        {

            //Turn off the acquistion 

            

            pd_change = false;

            if (pd_disp_bgworker.IsBusy)
            {
                pd_disp_bgworker.CancelAsync();
            }

            main_chart.MouseMove -= new System.Windows.Forms.MouseEventHandler(main_chart_MouseMove);

            O.convertPDToOpbox();

            if (pd_selected != -1)

            {
                if (measurementInProgress)
                {
                    O.errorCode = turnOffAcquisition();
                }

                O.setPeakDetector(pd_selected / 2);

                if (measurementInProgress)
                {
                    O.errorCode = turnOnAcquisition();
                }
            }
            main_chart.MouseLeave -= new System.EventHandler(main_chart_MouseLeave);

            if (testing_enabled)
            {
                pd_txt.Text = numToMStr(pd_selected) + "Leave";
            }

           


        }

        private void main_chart_Click(object sender, EventArgs e)
        {

        }

        private void main_chart_MouseMove(object sender, MouseEventArgs e)
        {

            Point chartLocationOnForm = main_chart.FindForm().PointToClient(main_chart.Parent.PointToScreen(main_chart.Location));

            cursorPosXpx = e.X - chartLocationOnForm.X;
            cursorPosYpx = e.Y - chartLocationOnForm.Y;

            cursorPosX = (float)(main_chart.ChartAreas["main_area"].AxisX.PixelPositionToValue(cursorPosXpx));
            cursorPosY = (float)(main_chart.ChartAreas["main_area"].AxisY.PixelPositionToValue(cursorPosYpx));

            bool isOutOfBounds = false;

            if (cursorPosX > O.plot.max_x)
            {
                cursorPosX = O.plot.max_x;
                isOutOfBounds = true;
            }
            if (cursorPosX < O.plot.min_x)
            {
                cursorPosX = O.plot.min_x;
                isOutOfBounds = true;
            }
            if (cursorPosY > O.plot.max_y)
            {
                cursorPosY = O.plot.max_y;
                isOutOfBounds = true;
            }
            if (cursorPosY < O.plot.min_y)
            {
                cursorPosY = O.plot.min_y;
                isOutOfBounds = true;
            }

            if (isOutOfBounds)
            {
                if (pd_disp_bgworker.IsBusy)
                {
                    pd_disp_bgworker.CancelAsync();
                }
                main_chart.MouseMove -= new System.Windows.Forms.MouseEventHandler(main_chart_MouseMove);
                main_chart.MouseLeave += new System.EventHandler(main_chart_MouseLeave);
                return;
            }

            replaceNearestPoint(cursorPosXpx, cursorPosYpx);

            if (testing_enabled)
            {
                pd_txt.Text = numToMStr(pd_selected) + "Move";
            }

            if (!pd_disp_bgworker.IsBusy)
            {
                pd_disp_bgworker.RunWorkerAsync();
            }

        }


        private void replaceNearestPoint(int cursorPosXPx, int cursorPosYPx)
        {

            // If we dont know which PD was the closest yet, calculate it!
            if (pd_selected == -1)
            {
                convertPDToPxValues();
                findNearestPDPoint(cursorPosXPx, cursorPosYPx);
            }

            replaceNearestPDPoint();
            O.refreshPDArrays();
            O.storePDRelativePositions();
        }


        private void findNearestPDPoint(int cursorPosXPx, int cursorPosYPx)
        {
            float[] distancesToPD = new float[6];

            // Distance to PDA points
            if (O.pda.enable == 1)
            {
                distancesToPD[0] = (float)Math.Sqrt((pda_X_px[0] - cursorPosXPx) * (pda_X_px[0] - cursorPosXPx) + (pda_Y_px[0] - cursorPosYPx) * (pda_Y_px[0] - cursorPosYPx));
                distancesToPD[1] = (float)Math.Sqrt((pda_X_px[1] - cursorPosXPx) * (pda_X_px[1] - cursorPosXPx) + (pda_Y_px[1] - cursorPosYPx) * (pda_Y_px[1] - cursorPosYPx));
            }
            else
            {
                distancesToPD[0] = float.MaxValue;
                distancesToPD[1] = float.MaxValue;
            }

            // Distance to PDB points									   
            if (O.pdb.enable == 1)
            {
                distancesToPD[2] = (float)Math.Sqrt((pdb_X_px[0] - cursorPosXPx) * (pdb_X_px[0] - cursorPosXPx) + (pdb_Y_px[0] - cursorPosYPx) * (pdb_Y_px[0] - cursorPosYPx));
                distancesToPD[3] = (float)Math.Sqrt((pdb_X_px[1] - cursorPosXPx) * (pdb_X_px[1] - cursorPosXPx) + (pdb_Y_px[1] - cursorPosYPx) * (pdb_Y_px[1] - cursorPosYPx));
            }
            else
            {
                distancesToPD[2] = float.MaxValue;
                distancesToPD[3] = float.MaxValue;
            }

            // Distance to PDC points									   
            if (O.pdc.enable == 1)
            {
                distancesToPD[4] = (float)Math.Sqrt((pdc_X_px[0] - cursorPosXPx) * (pdc_X_px[0] - cursorPosXPx) + (pdc_Y_px[0] - cursorPosYPx) * (pdc_Y_px[0] - cursorPosYPx));
                distancesToPD[5] = (float)Math.Sqrt((pdc_X_px[1] - cursorPosXPx) * (pdc_X_px[1] - cursorPosXPx) + (pdc_Y_px[1] - cursorPosYPx) * (pdc_Y_px[1] - cursorPosYPx));
            }
            else
            {
                distancesToPD[4] = float.MaxValue;
                distancesToPD[5] = float.MaxValue;
            }

            // Find minimum
            int min_idx = 0;

            for (int i = 0; i < 6; i++)
            {
                if (distancesToPD[min_idx] >= distancesToPD[i])
                {
                    min_idx = i;
                }
            }

            // Store information about our minimum as global variable
            pd_selected = min_idx;
        }

        private void convertPDToPxValues()
        {

            // PDA conversion
            pda_X_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(O.pd.pda_X_plot[0]));
            pda_X_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(O.pd.pda_X_plot[1]));

            pda_Y_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(O.pd.pda_Y_plot[0]));
            pda_Y_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(O.pd.pda_Y_plot[1]));

            // PDB conversion
            pdb_X_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(O.pd.pdb_X_plot[0]));
            pdb_X_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(O.pd.pdb_X_plot[1]));

            pdb_Y_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(O.pd.pdb_Y_plot[0]));
            pdb_Y_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(O.pd.pdb_Y_plot[1]));

            // PDC conversion
            pdc_X_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(O.pd.pdc_X_plot[0]));
            pdc_X_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(O.pd.pdc_X_plot[1]));

            pdc_Y_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(O.pd.pdc_Y_plot[0]));
            pdc_Y_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(O.pd.pdc_Y_plot[1]));
        }

        private void replaceNearestPDPoint()
        {

            switch (pd_selected)
            {
                case 0:
                    O.pd.pd_posX1_plot[0] = (float)cursorPosX;
                    O.pd.pd_posY_plot[0] = (float)cursorPosY;
                    break;
                case 1:
                    O.pd.pd_posX2_plot[0] = (float)cursorPosX;
                    O.pd.pd_posY_plot[0] = (float)cursorPosY;
                    break;
                case 2:
                    O.pd.pd_posX1_plot[1] = (float)cursorPosX;
                    O.pd.pd_posY_plot[1] = (float)cursorPosY;
                    break;
                case 3:
                    O.pd.pd_posX2_plot[1] = (float)cursorPosX;
                    O.pd.pd_posY_plot[1] = (float)cursorPosY;
                    break;
                case 4:
                    O.pd.pd_posX1_plot[2] = (float)cursorPosX;
                    O.pd.pd_posY_plot[2] = (float)cursorPosY;
                    break;
                case 5:
                    O.pd.pd_posX2_plot[2] = (float)cursorPosX;
                    O.pd.pd_posY_plot[2] = (float)cursorPosY;
                    break;
                default:
                    break;
            }
        }

        private void main_chart_MouseUp(object sender, MouseEventArgs e)
        {

            if (measurementInProgress)
            {
                O.errorCode = turnOffAcquisition();
            }

            pd_change = false;
            if (pd_disp_bgworker.IsBusy)
            {
                pd_disp_bgworker.CancelAsync();
            }

            if (testing_enabled)
            {
                pd_txt.Text = numToMStr(pd_selected) + "Up";
            }

            main_chart.MouseMove -= new System.Windows.Forms.MouseEventHandler(main_chart_MouseMove);
            main_chart.MouseLeave -= new System.EventHandler(main_chart_MouseLeave);
            O.convertPDToOpbox();
            O.setPeakDetector(pd_selected / 2);

            if (measurementInProgress)
            {
                O.errorCode = turnOnAcquisition();
            }
        }

        private void main_chart_MouseDown(object sender, MouseEventArgs e)
        {
            main_chart.Capture = false;

            pd_change = true;

            // Find nearest PD point and replace it to be under mouse cursor
            Point chartLocationOnForm = main_chart.FindForm().PointToClient(main_chart.Parent.PointToScreen(main_chart.Location));

            cursorPosXpx = e.X - chartLocationOnForm.X;
            cursorPosYpx = e.Y - chartLocationOnForm.Y;

            pd_selected = -1;

            if (!pd_disp_bgworker.IsBusy)
            {
                pd_disp_bgworker.RunWorkerAsync();
            }

            if (testing_enabled)
            {
                pd_txt.Text = numToMStr(pd_selected) + "Down";
            }

            // Add new event to handle storing 
            main_chart.MouseMove += new System.Windows.Forms.MouseEventHandler(main_chart_MouseMove);
            main_chart.MouseLeave += new System.EventHandler(main_chart_MouseLeave);
            main_chart.MouseUp += new System.Windows.Forms.MouseEventHandler(main_chart_MouseUp);

        }


        // Function used to display hexadecimal values in registers
        private string intToMStrHex(int int_value)
        {
            //return string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:X}", int_value);
            //   return int_value.ToString();
            //MemoryStream stream = new MemoryStream(int_value);           
            //string str_value = stream.Length.ToString();
            //string managed_str_value = Convert.ToString(str_value);
            //return managed_str_value;
            string vOut = int_value.ToString();
            return vOut;

        }

        // Functions which make converting numbers to managed strings required for GUI MUCH easier! :)
        private string numToMStr(int int_value)
        {

            string vOut = int_value.ToString();
            return vOut;
            // return string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:X}", int_value);

            //MemoryStream str_streamer = new MemoryStream();
            //StreamWriter wr = new StreamWriter(str_streamer);
            //wr.Write(int_value);
            //string str_value = wr.ToString();          
            //string managed_str_value = Convert.ToString(str_value);
            //return managed_str_value;
        }

        private string numToMStr(float flt_value)
        {
            return flt_value.ToString();
        }

        private string numToMStr(double double_value)
        {
           
            string vOut = double_value.ToString();
            return vOut;
            //  return double_value.ToString();
            //MemoryStream str_streamer = new MemoryStream();
           // StreamWriter wr = new StreamWriter(str_streamer);
           // wr.Write(double_value);
            //string str_value = str_streamer.ToString();
            //string managed_str_value = Convert.ToString(str_value);
            //return managed_str_value;
        }

        // Function converting char pointers to string format
        //private string charToStr(ref string char_value)
        //{


        //    //MemoryStream str_streamer = new MemoryStream();
        //    //str_streamer=Convert.ToString(char_value);
        //    //string str_value = str_streamer.ToString();
        //    return str_value;
        //}

        // Makes very complex calculation which is way too hard for old C++98 "math.h" header...
        private double round(double fValue)
        {
            return fValue < 0 ? Math.Ceiling(fValue - 0.5) : Math.Floor(fValue + 0.5);
        }

        private float round(float fValue)
        {
            return (float)(fValue < 0 ? Math.Ceiling(fValue - 0.5) : Math.Floor(fValue + 0.5));
        }

        private void pda_mode_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.pda.mode = pda_mode_ctrl.SelectedIndex;

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    O.errorCode = turnOffAcquisition();
            //}

            //O.errorCode = O.setPdMode(O.pda.mode, 0);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    O.errorCode = turnOnAcquisition();
            //}

        }

        private void updatePlotXAxis(double min_x, double max_x)
        {
            main_chart.ChartAreas["main_area"].AxisX.Minimum = Math.Round(min_x * 10.0) / 10.0;
            main_chart.ChartAreas["main_area"].AxisX.Maximum = Math.Round(max_x * 10.0) / 10.0;
            main_chart.ChartAreas["main_area"].AxisX.Interval = Math.Round(10.0 * (max_x - min_x) / 20.0) / 10.0;
        }

        private void pdb_mode_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.pdb.mode = pdb_mode_ctrl.SelectedIndex;

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    O.errorCode = turnOffAcquisition();
            //}

            //O.errorCode = O.setPdMode(O.pdb.mode, 1);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    O.errorCode = turnOnAcquisition();
            //}

        }

        private void pdc_mode_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.pdc.mode = pdc_mode_ctrl.SelectedIndex;

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    O.errorCode = turnOffAcquisition();
            //}

            //O.errorCode = O.setPdMode(O.pdc.mode, 2);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    O.errorCode = turnOnAcquisition();
            //}

        }

        private void pda_enable_ctrl_CheckedChanged(object sender, EventArgs e)
        {
            if (pda_enable_ctrl.CheckState == CheckState.Checked)
            {
                pd_timer.Enabled = true;
                O.pda.enable = 1;
                main_chart.Series["pd_a"].Enabled = true;
                pda_enable_ctrl.ForeColor = System.Drawing.Color.OrangeRed;
                pda_ref_position_ctrl.Enabled = true;
                pda_peak_amplitude_ctrl.Enabled = true;
                pda_peak_position_ctrl.Enabled = true;
            }
            else
            {
                // if all PDs are disabled, we can turn off timer refreshing it
                if ((pda_enable_ctrl.CheckState == CheckState.Unchecked) && (pdb_enable_ctrl.CheckState == CheckState.Unchecked) && (pdc_enable_ctrl.CheckState == CheckState.Unchecked))
                {
                    pd_timer.Enabled = false;
                }
                O.pda.enable = 0;
                main_chart.Series["pd_a"].Enabled = false;
                pda_enable_ctrl.ForeColor = System.Drawing.Color.White;
                pda_ref_position_ctrl.Enabled = false;
                pda_peak_amplitude_ctrl.Enabled = false;
                pda_peak_position_ctrl.Enabled = false;
            }

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                O.errorCode = turnOffAcquisition();
            }

            O.errorCode = O.setPdEnable(O.pda.enable, 0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                O.errorCode = turnOnAcquisition();
            }

        }

        private void pdb_enable_ctrl_CheckedChanged(object sender, EventArgs e)
        {
            if (pdb_enable_ctrl.CheckState == CheckState.Checked)
            {
                pd_timer.Enabled = true;
                O.pdb.enable = 1;
                main_chart.Series["pd_b"].Enabled = true;
                pdb_enable_ctrl.ForeColor = System.Drawing.Color.LawnGreen;
                pdb_ref_position_ctrl.Enabled = true;
                pdb_peak_amplitude_ctrl.Enabled = true;
                pdb_peak_position_ctrl.Enabled = true;
            }
            else
            {
                // if all PDs are disabled, we can turn off timer refreshing it
                if ((pda_enable_ctrl.CheckState == CheckState.Unchecked) && (pdb_enable_ctrl.CheckState == CheckState.Unchecked) && (pdc_enable_ctrl.CheckState == CheckState.Unchecked))
                {
                    pd_timer.Enabled = false;
                }
                O.pdb.enable = 0;
                main_chart.Series["pd_b"].Enabled = false;
                pdb_enable_ctrl.ForeColor = System.Drawing.Color.White;
                pdb_ref_position_ctrl.Enabled = false;
                pdb_peak_amplitude_ctrl.Enabled = false;
                pdb_peak_position_ctrl.Enabled = false;
            }

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                O.errorCode = turnOffAcquisition();
            }

            O.errorCode = O.setPdEnable(O.pdb.enable, 1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                O.errorCode = turnOnAcquisition();
            }

        }

        private void pdc_enable_ctrl_CheckedChanged(object sender, EventArgs e)
        {
            if (pdc_enable_ctrl.CheckState == CheckState.Checked)
            {
                pd_timer.Enabled = true;
                O.pdc.enable = 1;
                main_chart.Series["pd_c"].Enabled = true;
                pdc_enable_ctrl.ForeColor = System.Drawing.Color.Aqua;
                pdc_ref_position_ctrl.Enabled = true;
                pdc_peak_amplitude_ctrl.Enabled = true;
                pdc_peak_position_ctrl.Enabled = true;
            }
            else
            {
                // if all PDs are disabled now, we can turn off timer refreshing it
                if ((pda_enable_ctrl.CheckState == CheckState.Unchecked) && (pdb_enable_ctrl.CheckState == CheckState.Unchecked) && (pdc_enable_ctrl.CheckState == CheckState.Unchecked))
                {
                    pd_timer.Enabled = false;
                }
                O.pdc.enable = 0;
                main_chart.Series["pd_c"].Enabled = false;
                pdc_enable_ctrl.ForeColor = System.Drawing.Color.White;
                pdc_ref_position_ctrl.Enabled = false;
                pdc_peak_amplitude_ctrl.Enabled = false;
                pdc_peak_position_ctrl.Enabled = false;
            }

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                O.errorCode = turnOffAcquisition();
            }

            O.errorCode = O.setPdEnable(O.pdc.enable, 2);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                O.errorCode = turnOnAcquisition();
            }

        }

        private void enca_enable_ctrl_CheckedChanged(object sender, EventArgs e)
        {
            if (enca_enable_ctrl.CheckState == CheckState.Checked)
            {
                O.enca.enable = 1;

                // if another encoder is also disabled, then our enc_timer must be disabled - turn it on!
                if (testing_enabled && (enca_enable_ctrl.CheckState == CheckState.Unchecked) || (encb_enable_ctrl.CheckState == CheckState.Unchecked))
                {
                    enc_results_timer.Enabled = true;
                }
            }
            else
            {
                O.enca.enable = 0;

                // if both encoders are disabled, then disable encoder timer as well
                if (encb_enable_ctrl.CheckState == CheckState.Unchecked)
                {
                    enc_results_timer.Enabled = false;
                }

                if (testing_enabled)
                {
                    enca_test.Text = "Disabled";
                }
            }
            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            O.errorCode = O.setEncEnable(O.enca.enable, 0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }

        }

        private void encb_enable_ctrl_CheckedChanged(object sender, EventArgs e)
        {
            if (encb_enable_ctrl.CheckState == CheckState.Checked)
            {
                O.encb.enable = 1;

                // if another encoder is also disabled, then our enc_timer must be disabled - turn it on!
                if (testing_enabled && (enca_enable_ctrl.CheckState == CheckState.Unchecked) || (encb_enable_ctrl.CheckState == CheckState.Unchecked))
                {
                    enc_results_timer.Enabled = true;
                }
            }
            else
            {
                O.encb.enable = 0;

                // if both encoders are disabled, then disable encoder timer as well
                if (enca_enable_ctrl.CheckState == CheckState.Unchecked)
                {
                    enc_results_timer.Enabled = false;
                }

                if (testing_enabled)
                {
                    encb_test.Text = "Disabled";
                }
            }

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            O.errorCode = O.setEncEnable(O.encb.enable, 1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }

        }

        private void enca_input_mode_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.enca.input_mode = enca_input_mode_ctrl.SelectedIndex;

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOffAcquisition();
            //}

            //O.errorCode = O.setEncInputMode(O.enca.input_mode, 0);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOnAcquisition();
            //}

        }

        private void encb_input_mode_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.encb.input_mode = encb_input_mode_ctrl.SelectedIndex;
            //int set_value = O.encb.input_mode;

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOffAcquisition();
            //}

            //O.errorCode = O.setEncInputMode(O.encb.input_mode, 1);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOnAcquisition();
            //}

        }

        private void pda_ref_position_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void xy_divider_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.trig.xy_divider = xy_divider_ctrl.SelectedIndex; // * 32000; //almost equal division

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    O.errorCode = turnOffAcquisition();
            //}

            //O.errorCode = O.setXYDivider(O.trig.xy_divider);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    O.errorCode = turnOnAcquisition();
            //}

        }

        private void timer_period_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void trigger_source_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void charging_time_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void amplitude_level_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Turn off acquisition
            if (measurementInProgress)
            {
                O.errorCode = turnOffAcquisition();
            }

            O.puls.amplitude_level = amplitude_level_ctrl.SelectedIndex;
            O.errorCode = O.setAmplitudeLevel(O.puls.amplitude_level);
            O.initSession();

            // Turn on acquisition
            if (measurementInProgress)
            {
                O.errorCode = turnOnAcquisition();
            }

            if (testing_enabled)
            {
                filter_test.Text = intToMStrHex(op_wrp_GetAnalog());
                ampl_test.Text = numToMStr(O.ampl.preamplifier);
                source_test.Text = numToMStr(O.ampl.input_source);
                amplitude_level_test.Text = numToMStr(O.puls.amplitude_level);
            }
        }

        private void gain_mode_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gain_ctrl_TextChanged(object sender, EventArgs e)
        {
            gain_changed = true;
        }

        private void input_source_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void preamplifier_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            O.ampl.preamplifier = preamplifier_ctrl.SelectedIndex;

            if (measurementInProgress)
            {
                O.errorCode = turnOffAcquisition();
            }

            O.errorCode = O.setPreamplifier(O.ampl.preamplifier);

            if (measurementInProgress)
            {
                O.errorCode = turnOnAcquisition();
            }

            if (testing_enabled)
            {
                filter_test.Text = intToMStrHex(op_wrp_GetAnalog());
                ampl_test.Text = numToMStr(O.ampl.preamplifier);
                source_test.Text = numToMStr(O.ampl.input_source);
                amplitude_level_test.Text = numToMStr(O.puls.amplitude_level);
            }
        }

        private void filter_bandtwidth_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            O.ampl.filter_bandtwidth = filter_bandtwidth_ctrl.SelectedIndex;

            // Turn off acquisition
            if (measurementInProgress)
            {
                O.errorCode = turnOffAcquisition();
            }

            O.errorCode = O.setAnalogFilter(O.ampl.filter_bandtwidth);

            if (testing_enabled)
            {
                filter_test.Text = intToMStrHex(op_wrp_GetAnalog());
                ampl_test.Text = numToMStr(O.ampl.preamplifier);
                source_test.Text = numToMStr(O.ampl.input_source);
                amplitude_level_test.Text = numToMStr(O.puls.amplitude_level);
            }

            if (measurementInProgress)
            {
                O.errorCode = turnOnAcquisition();
            }
        }

        private void plot_algorithm_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delay_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void window_ctrl_TextChanged(object sender, EventArgs e)
        {
            window_changed = true;
        }

        private void mode_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode_ctrl.SelectedIndex != O.acq.mode)
            {

                if (measurementInProgress)
                {
                    turnOffAcquisition();
                }

                // We don't need to watch our conversion, we just want to see the result,
                // so during our conversion we disable main data series
                main_chart.Series["main_data"].Enabled = false;

                O.setDataModeFull(mode_ctrl.SelectedIndex);

                if (mode_ctrl.SelectedIndex == 1)
                {

                    text_pd_peak_ampl.Text = "Peak Ampl. [%]";
                    main_chart.ChartAreas["main_area"].AxisY.Minimum = O.plot.min_y;
                    main_chart.ChartAreas["main_area"].AxisY.Maximum = O.plot.max_y;
                    main_chart.ChartAreas["main_area"].AxisY.Interval = (int)((O.plot.max_y - O.plot.min_y) / 10);
                    main_chart.ChartAreas["main_area"].AxisY.Title = "Amplitude [%]";
                }
                else
                {

                    text_pd_peak_ampl.Text = "Peak Ampl. [V]";
                    main_chart.ChartAreas["main_area"].AxisY.Minimum = O.plot.min_y;
                    main_chart.ChartAreas["main_area"].AxisY.Maximum = O.plot.max_y;
                    main_chart.ChartAreas["main_area"].AxisY.Interval = ((O.plot.max_y - O.plot.min_y) / 10);
                    main_chart.ChartAreas["main_area"].AxisY.Title = "Amplitude [V]";
                }

                if (!pd_disp_bgworker.IsBusy)
                {
                    displayPD();
                }

                if (!plot_bgworker.IsBusy)
                {
                    // Collect data and display so we can see the difference
                    O.errorCode = turnOnAcquisition();
                    System.Threading.Thread.Sleep(50);
                    O.collectData();
                    displayData();
                    O.errorCode = turnOffAcquisition();
                }

                // We can safely turn data series on after we did the conversion
                main_chart.Series["main_data"].Enabled = true;

                if (measurementInProgress)
                {
                    turnOnAcquisition();
                }
            }
        }

        private void sampling_freq_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (measurementInProgress)
            {
                O.errorCode = turnOffAcquisition();
            }

            int current_sample_no = (int)(O.acq.window * (100.0 / (O.acq.sampling_freq + 1)));
            O.setSamplingFreqFull(sampling_freq_ctrl.SelectedIndex);
            updatePlotXAxis(O.plot.min_x, O.plot.max_x);
            recreateExtDataArrays(O.plot.sampling_freq_real, O.acq.window, current_sample_no);

            if (testing_enabled)
            {
                window_test.Text = numToMStr(op_wrp_GetDepth());
                delay_test.Text = numToMStr(op_wrp_GetDelay());
            }

            if (!pd_disp_bgworker.IsBusy)
            {
                displayPD();
            }

            if (!plot_bgworker.IsBusy)
            {
                // Collect one data frame
                O.errorCode = turnOnAcquisition();
                System.Threading.Thread.Sleep(50);
                O.collectData();
                displayData();
                O.errorCode = turnOffAcquisition();
            }

            // Turn on acquisition
            if (measurementInProgress)
            {
                O.errorCode = turnOnAcquisition();
            }

        }
        private void recreateExtDataArrays(double real_sampling_freq, double real_depth, int current_array_size)
        {

            // There, we calculate how many data points we will receive
            int new_array_size = (int)(real_depth * real_sampling_freq);

            // We switch data array size when we have or when we want to have less than opbox->plot.plot_data_size points for plotting
            if (!((new_array_size >= O.plot.plot_data_size) && (current_array_size >= O.plot.plot_data_size)))
            {
                if (new_array_size >= O.plot.plot_data_size)
                {
                    System.Array.Resize(ref ext_plot_dataX, O.plot.plot_data_size);
                    System.Array.Resize(ref ext_plot_dataY, O.plot.plot_data_size);
                }
                else
                {
                    System.Array.Resize(ref ext_plot_dataX, O.plot.window_in_smpls);
                    System.Array.Resize(ref ext_plot_dataY, O.plot.window_in_smpls);
                }
            }
        }

        private void enca_reset_btn_Click(object sender, EventArgs e)
        {

        }

        private void encb_reset_btn_Click(object sender, EventArgs e)
        {

        }

        private void enca_comparator_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.enca.comparator = enca_comparator_ctrl.SelectedIndex;

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOffAcquisition();
            //}

            //O.errorCode = O.setEncComparator(O.enca.comparator, 0);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOnAcquisition();
            //}

        }

        private void encb_comparator_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.encb.comparator = encb_comparator_ctrl.SelectedIndex;

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOffAcquisition();
            //}

            //O.errorCode = O.setEncComparator(O.encb.comparator, 1);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOnAcquisition();
            //}

        }

        private void enca_comparator_step_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void encb_comparator_step_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void enca_filter_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.enca.filter = (enca_filter_ctrl.SelectedIndex);

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOffAcquisition();
            //}

            //O.errorCode = O.setEncFilter(O.enca.filter, 0);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOnAcquisition();
            //}

        }

        private void encb_filter_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.encb.filter = (encb_filter_ctrl.SelectedIndex);

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOffAcquisition();
            //}

            //O.errorCode = O.setEncFilter(O.encb.filter, 1);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOnAcquisition();
            //}

        }

        private void enca_decode_mode_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O.enca.decode_mode = enca_decode_mode_ctrl.SelectedIndex;

            ////Turn off the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOffAcquisition();
            //}

            //O.errorCode = O.setEncDecodeMode(O.enca.decode_mode, 0);

            ////Turn on the acquisistion
            //if (measurementInProgress)
            //{
            //    turnOnAcquisition();
            //}

        }

        private void encb_decode_mode_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enca_idx_input_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void encb_idx_input_ctrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void test_mode_txt_Click(object sender, EventArgs e)
        {
            if (testing_enabled)
            {

                testing_enabled = false;

                // Show the panel:
                test_panel.Enabled = false;
                test_panel.Visible = false;

                // Turn off Encoders' testers
                enc_results_timer.Enabled = false;

                // Switch appearance of our button:
                test_mode_btn.Text = "OFF";
                test_mode_btn.ForeColor = System.Drawing.Color.Black;
            }

            // What happens when we turn it ON:
            else
            {

                testing_enabled = true;

                // Hide the panel:
                test_panel.Enabled = true;
                test_panel.Visible = true;

                // Turn on Encoders' testers:
                if ((O.enca.enable == 1) || (O.encb.enable == 1))
                {
                    enc_results_timer.Enabled = true;
                }

                // Switch appearance of our button:
                test_mode_btn.Text = "ON";
                test_mode_btn.ForeColor = System.Drawing.Color.Yellow;

                // Refresh all parameters displayed by controls:
                window_test.Text = numToMStr(op_wrp_GetDepth()); // Display depth in samples
                delay_test.Text = numToMStr(op_wrp_GetDelay()); // Display delay in samples
                filter_test.Text = intToMStrHex(op_wrp_GetAnalog()); // Display register including filter bandtwidth, input source and gain
                ampl_test.Text = numToMStr(O.ampl.preamplifier); // Display value sent to OPBOX as amplitude level parameter
                source_test.Text = numToMStr(O.ampl.input_source); // Display value sent to OPBOX as input source
                amplitude_level_test.Text = numToMStr(O.puls.amplitude_level); // Display value sent to OPBOX as amplitude level
                if (O.enca.enable == 1)
                {
                    enca_test.Text = numToMStr(op_wrp_GetEncoderPosit(0)); // Display Encoder A position in samples
                }
                else
                {
                    enca_test.Text = "Disabled";
                }

                if (O.encb.enable == 1)
                {
                    encb_test.Text = numToMStr(op_wrp_GetEncoderPosit(1)); // Display Encoder B position in samples
                }
                else
                {
                    encb_test.Text = "Disabled";
                }
                pd_txt.Text = "START"; // Display information about actions on Peak Detectors
            }
        }

        private void pda_peak_amplitude_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void pda_peak_position_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void pdb_ref_position_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void pdb_peak_amplitude_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void pdb_peak_position_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void pdc_ref_position_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void pdc_peak_amplitude_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void pdc_peak_position_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void info_disp_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void plot_do_work_Tick(object sender, EventArgs e)
        {
            O.data.data_buffer = op_wrp_GetDataHandleF(300000);
            displayData();
        }

        private void test_mode_txt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void window_ctrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                int pos = window_ctrl.SelectionStart;
                window_ctrl.Text = window_ctrl.Text.Insert(pos, ".");
                window_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }

            else if (e.KeyChar == ' ')
            {
                int pos = window_ctrl.SelectionStart;
                window_ctrl.Text = window_ctrl.Text.Insert(pos, "");
                window_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }
        }

        private void window_ctrl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                // Turn off acquisition and reset FIFO
                if (measurementInProgress)
                {
                    O.errorCode = turnOffAcquisition();
                    O.errorCode = op_wrp_TrigReset();
                }

                int current_sample_no = (int)(O.acq.window * (100.0 / (O.acq.sampling_freq + 1)));

                double depth_value;
                if (System.Double.TryParse(window_ctrl.Text, out depth_value))
                {
                    O.setDepthFull(depth_value);
                    window_ctrl.Text = Convert.ToString(O.acq.window);
                }
                else
                {
                    window_ctrl.Text = Convert.ToString(O.acq.window);
                }

                updatePlotXAxis(O.plot.min_x, O.plot.max_x);
                recreateExtDataArrays(O.plot.sampling_freq_real, O.acq.window, current_sample_no);

                if (testing_enabled)
                {
                    window_test.Text = numToMStr(op_wrp_GetDepth());
                }

                if (!plot_bgworker.IsBusy)
                {
                    // Collect single data frame
                    O.errorCode = turnOnAcquisition();
                    System.Threading.Thread.Sleep(50);
                    O.collectData();
                    displayData();
                    O.errorCode = turnOffAcquisition();
                    O.errorCode = op_wrp_TrigReset();
                }

                // Turn on acquisition if it was disabled just for parameter change
                if (measurementInProgress)
                {
                    O.errorCode = turnOnAcquisition();
                }

                window_changed = false;
            }
        }

        private void window_ctrl_Leave(object sender, System.EventArgs e)
        {

            if (window_changed)
            {

                // Turn off measurement and reset FIFO
                if (measurementInProgress)
                {
                    O.errorCode = turnOffAcquisition();
                    O.errorCode = op_wrp_TrigReset();
                }

                int current_sample_no = (int)(O.acq.window * (100.0 / (O.acq.sampling_freq + 1)));

                double depth_value;
                if (System.Double.TryParse(window_ctrl.Text, out depth_value))
                {
                    O.setDepthFull(depth_value);
                    window_ctrl.Text = Convert.ToString(O.acq.window);
                }
                else
                {
                    window_ctrl.Text = Convert.ToString(O.acq.window);
                }

                updatePlotXAxis(O.plot.min_x, O.plot.max_x);

                recreateExtDataArrays(O.plot.sampling_freq_real, O.acq.window, current_sample_no);

                if (testing_enabled)
                {
                    window_test.Text = numToMStr(op_wrp_GetDepth());
                }

                if (!plot_bgworker.IsBusy)
                {
                    // Collect single data frame
                    O.errorCode = turnOnAcquisition();
                    System.Threading.Thread.Sleep(50);
                    O.collectData();
                    displayData();
                    O.errorCode = turnOffAcquisition();
                    O.errorCode = op_wrp_TrigReset();
                }

                // Turn on measurement if it was stopped just for parameter change
                if (measurementInProgress)
                {
                    O.errorCode = turnOnAcquisition();
                }

                window_changed = false;
            }
        }
        private void gain_ctrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                int pos = gain_ctrl.SelectionStart;
                gain_ctrl.Text = gain_ctrl.Text.Insert(pos, ".");
                gain_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }

            else if (e.KeyChar == ' ')
            {
                int pos = gain_ctrl.SelectionStart;
                gain_ctrl.Text = gain_ctrl.Text.Insert(pos, "");
                gain_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }
        }
    }




}

