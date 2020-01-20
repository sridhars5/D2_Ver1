using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Collections;

namespace D2
{
    public partial class Sensor : Form
    {

        Opbox OP = new Opbox();
        managed_arrays MA = new managed_arrays();


    



        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_TrigEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_TrigEnable(int yes_no);

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_StartSW", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_StartSW();

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_Get_Power_Info", CallingConvention = CallingConvention.StdCall)]
        public static extern int op_wrp_Get_Power_Info(int Power_ATRIBUTE);

        [System.Security.SuppressUnmanagedCodeSecurity]

        [DllImport("DynamicOPBOX.dll", EntryPoint = "op_wrp_GetDataHandle", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern IntPtr op_wrp_GetDataHandle(int x);


        public static byte[] op_wrp_GetDataHandleF(int length)
        {
            byte[] ReturnArray = new byte[length];
            Marshal.Copy(op_wrp_GetDataHandle(length), ReturnArray, 0, length);
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







        public Sensor()
        {
            InitializeComponent();
        }



        public int pda_found;
        public int pdb_found;
        public int pdc_found;
        // Instance of class Opbox - contains all datasets required for correct control
        protected static Opbox opbox = new Opbox();

        // All parameters required for correct management of graph
        // Maximal data size and size of subset, which will be plotted on main_chart
        public static int dataSize = 252090;
        public static int plotDataSize = 750;

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




        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            // Application.Exit();

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
                OP.errorCode = turnOnAcquisition();
            }
            else
            {
                measurementInProgress = false;
                btn_start.BackColor = System.Drawing.Color.LightGreen;
                btn_start.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
                btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
                btn_start.ForeColor = System.Drawing.Color.Black;
                btn_start.Text = "START";
                OP.errorCode = turnOffAcquisition();
            }

        }


        public int turnOnAcquisition()
        {

            for (int i = 0; i < OP.no_of_tries; i++)
            {
                OP.errorCode = op_wrp_TrigEnable(1);
                OP.errorCode = op_wrp_StartSW();
                if (OP.errorCode == 0)
                    break;
            }

            if (OP.errorCode == 0)
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
            return (OP.errorCode);
        }

        private void turnOnTimers()
        {
            err_timer.Enabled = true;
            fps_timer.Enabled = true;
            if ((OP.enca.enable == 1) || (OP.encb.enable == 1))
            {
                enc_results_timer.Enabled = true;
            }
            if ((OP.pda.enable == 1) || (OP.pdb.enable == 1) || (OP.pdc.enable == 1))
            {
                pd_results_timer.Enabled = true;
                pd_timer.Enabled = true;
            }
        }

        //off

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
                for (int i = 0; i < (OP.no_of_tries); i++)
                {
                    OP.errorCode = op_wrp_TrigEnable(0);
                    if (OP.errorCode == 0)
                        break;
                }
            }

            if ((OP.errorCode == 0) || (op_wrp_Get_Power_Info(16) != 0))
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

            return (OP.errorCode);
        }


        private void turnOffTimers()
        {
            err_timer.Enabled = false;
            pd_results_timer.Enabled = false;
            pd_timer.Enabled = false;
            fps_timer.Enabled = false;
            enc_results_timer.Enabled = false;
        }





        // Makes very complex calculation which is way too hard for old C++98 "math.h" header...
        private double round(double fValue)
        {
            return fValue < 0 ? Math.Ceiling(fValue - 0.5) : Math.Floor(fValue + 0.5);
        }

        private float round(float fValue)
        {
            return (float)(fValue < 0 ? Math.Ceiling(fValue - 0.5) : Math.Floor(fValue + 0.5));
        }











        private void Sensor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.WindowsShutDown)
            {

                // BUT STILL, we have to close session properly if we can!
                if (measurementInProgress)
                {
                    turnOffAcquisition();
                    turnOffTimers();
                }
                OP.endSession();
                return;
            }

            // In case user is trying to shut it down (e.g. by [X]), we want to ask him/her first
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                switch (MessageBox.Show(this, "Close OPBOX session ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    // If we cancel exiting, we don't do anything
                    case (System.Windows.Forms.DialogResult.No):
                        e.Cancel = true;
                        break;

                    // Otherwise, we have to close OPBOX session before we close the application
                    default:
                        if (measurementInProgress)
                        {
                            turnOffAcquisition();
                            turnOffTimers();
                        }
                        OP.endSession();
                        break;
                }
            }

            // The only left case is when user didn't connect OPBOX via USB, and then we don't need to do anything
            // but to force application to close (we call Application::Exit) after few notifications:
            // (these are the code lines added just for the code clearance - this would happen anyway)
            if ((e.CloseReason == System.Windows.Forms.CloseReason.ApplicationExitCall) && (init_err == 0))
            {
                switch (MessageBox.Show(this, "Close OPBOX session ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    // If we cancel exiting, we don't do anything
                    case (System.Windows.Forms.DialogResult.No):
                        e.Cancel = true;
                        break;

                    // Otherwise, we have to close OPBOX session before we close the application
                    default:
                        if (measurementInProgress)
                        {
                            turnOffAcquisition();
                            turnOffTimers();
                        }
                        OP.endSession();
                        break;
                }
            }

            // If it is caused by initial error (OPBOX is not connected), we don't have to ask user
            // stupid questions - just autofinish it! 
            if ((e.CloseReason == System.Windows.Forms.CloseReason.ApplicationExitCall) && (init_err == 1))
            {
                if (measurementInProgress)
                {
                    turnOffAcquisition();
                    turnOffTimers();
                }
                OP.endSession();
            }

        }

        private void Sensor_Load(object sender, EventArgs e)
        {
           

            RandomNumbers.Seed((int)DateTime.Now.Ticks);

           // Random rnd = new Random((int)DateTime.Now.Ticks);
            // return rnd.Next(-1, 1);

            //// Initialize Chart - Area for plot
            main_chart.ChartAreas.Add("main_area");

            main_chart.ChartAreas["main_area"].AxisX.Minimum = OP.plot.min_x;
            main_chart.ChartAreas["main_area"].AxisX.Maximum = OP.plot.max_x;
            main_chart.ChartAreas["main_area"].AxisX.Interval = (OP.plot.max_x - OP.plot.min_x) / 25;

            main_chart.ChartAreas["main_area"].AxisY.Minimum = OP.plot.min_y;
            main_chart.ChartAreas["main_area"].AxisY.Maximum = OP.plot.max_y;
            main_chart.ChartAreas["main_area"].AxisY.Interval =(OP.plot.max_y - OP.plot.min_y) / 10;

            main_chart.ChartAreas["main_area"].BackColor = System.Drawing.Color.Teal;

            main_chart.Series.Add("main_data");
            main_chart.Series["main_data"].Color = System.Drawing.Color.Yellow;

            //// Sample  signal generated here
            float rand_factor = (float)(0.2 + (float)RandomNumbers.NextNumber() / ((float)(Int32.MaxValue / (0.5 - 0.2))));

            double x = Math.PI * RandomNumbers.NextNumber() / (Int32.MaxValue + 1.0);

            for (int i = 0; i < OP.plot.window_in_smpls; i++)
            {
                OP.data.main_dataX[i] = (byte)(OP.plot.min_x + i * (OP.plot.max_x - OP.plot.min_x) / OP.plot.window_in_smpls);
                OP.data.main_dataY[i] = (byte)(1.5 + rand_factor * (0.8 * (i % 120)) * Math.Sin(OP.data.main_dataX[i] * (i % 120) * 0.01));
            }

            OP.floatingMean(OP.data.main_dataX, OP.data.main_dataY, OP.plot.window_in_smpls, OP.data.plot_dataX, OP.data.mean_dataY, OP.plot.plot_data_size);
            OP.convertDataToRfAbs(OP.data.mean_dataY, OP.data.plot_dataY, OP.plot.plot_data_size);

            float[] ext_plot_dataX = MA.createManagedArr(OP.data.plot_dataX, OP.plot.plot_data_size);
            float[] ext_plot_dataY = MA.createManagedArr(OP.data.plot_dataY, OP.plot.plot_data_size);

            main_chart.Series["main_data"].Points.DataBindXY(ext_plot_dataX, ext_plot_dataY);
            main_chart.Series["main_data"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

            //Add peak detectors and format its' appearance
            // PDA:
            main_chart.Series.Add("pd_a");
            main_chart.Series["pd_a"].Color = System.Drawing.Color.OrangeRed;
            main_chart.Series["pd_a"].BorderWidth = 2;
            main_chart.Series["pd_a"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            main_chart.Series["pd_a"].Enabled = true;
            main_chart.Series["pd_a"].Points.DataBindXY(MA.createManagedArr(OP.pd.pda_X_plot, 2), MA.createManagedArr(OP.pd.pda_Y_plot, 2));
            main_chart.Series["pd_a"].MarkerSize = 5;
            main_chart.Series["pd_a"].MarkerStep = 1;
            main_chart.Series["pd_a"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            main_chart.Series["pd_a"].MarkerColor = System.Drawing.Color.OrangeRed;
            main_chart.Series["pd_a"].MarkerBorderColor = System.Drawing.Color.Crimson;
            main_chart.Series["pd_a"].MarkerBorderWidth = 2;

            main_chart.Series.Add("pd_b");
            main_chart.Series["pd_b"].Color = System.Drawing.Color.LawnGreen;
            main_chart.Series["pd_b"].BorderWidth = 2;
            main_chart.Series["pd_b"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            main_chart.Series["pd_b"].Points.DataBindXY(MA.createManagedArr(OP.pd.pdb_X_plot, 2), MA.createManagedArr(OP.pd.pdb_Y_plot, 2));
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
            main_chart.Series["pd_c"].Points.DataBindXY(MA.createManagedArr(OP.pd.pdc_X_plot, 2), MA.createManagedArr(OP.pd.pdc_Y_plot, 2));
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
            OP.errorCode = 6;

            for (int i = 1; i <= (OP.no_of_tries + 1); i++)
            {

                if (OP.errorCode != 0)
                {
                    if (i <= (OP.no_of_tries))
                    {

                        if (measurementInProgress)
                        {
                            turnOffAcquisition();
                        }

                        OP.errorCode = OP.initSession();
                        measurementInProgress = true;

                        if (measurementInProgress && (OP.errorCode == 0))
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
                    if (i > OP.no_of_tries)
                    {
                        init_err = 1;
                        string error_string = string.Concat("OPBOX Init error. Reconnect OPBOX and restart application! Initial error code: ", Convert.ToString(OP.errorCode));
                        MessageBox.Show(error_string, "OPBOX 2.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                        return;
                    }
                }
            }

            // Display OPBOX version and basic information, which guarantee us correct initialization
            string infoDisp = $"OPBOX SN{ OP.init.info1}.{ OP.init.info2} v:{OP.init.version}";
            info_disp_ctrl.Text = infoDisp;

            // Acquisition parameters
            sampling_freq_ctrl.SelectedIndex = OP.acq.sampling_freq;
            mode_ctrl.SelectedIndex = OP.acq.mode;
            window_ctrl.Text = Convert.ToString(OP.acq.window);
            delay_ctrl.Text = Convert.ToString(OP.acq.delay);
            plot_algorithm_ctrl.SelectedIndex = plot_algorithm;

            // Amplifiers' parameters
            filter_bandtwidth_ctrl.SelectedIndex = OP.ampl.filter_bandtwidth;
            preamplifier_ctrl.SelectedIndex = OP.ampl.preamplifier;
            input_source_ctrl.SelectedIndex = OP.ampl.input_source;
            gain_ctrl.Text = Convert.ToString(OP.ampl.gain);
            gain_mode_ctrl.SelectedIndex = OP.ampl.gain_mode;

            // Pulser parameters
            amplitude_level_ctrl.SelectedIndex = OP.puls.amplitude_level;
            charging_time_ctrl.Text = Convert.ToString(OP.puls.charging_time);

            // Trigger parameters
            trigger_source_ctrl.SelectedIndex = OP.trig.trigger_source;
            timer_period_ctrl.Text = Convert.ToString(OP.trig.timer_period);
            xy_divider_ctrl.SelectedIndex = OP.trig.xy_divider;

            // Peak Detectors' controls
            // PDA
            pda_enable_ctrl.Checked = (OP.pda.enable == 1);
            pda_mode_ctrl.SelectedIndex = OP.pda.mode;
            pda_ref_position_ctrl.Text =Convert.ToString(OP.pda.ref_pos);
            pda_peak_amplitude_ctrl.Text =Convert.ToString(OP.pda.peak_ampl);
            pda_peak_position_ctrl.Text = Convert.ToString(OP.pda.peak_pos);
            // PDB
            pdb_enable_ctrl.Checked = (OP.pdb.enable == 1);
            pdb_mode_ctrl.SelectedIndex = OP.pdb.mode;
            pdb_ref_position_ctrl.Text = Convert.ToString(OP.pdb.ref_pos);
            pdb_peak_amplitude_ctrl.Text =Convert.ToString(OP.pdb.peak_ampl);
            pdb_peak_position_ctrl.Text = Convert.ToString(OP.pdb.peak_pos);
            // PDC
            pdc_enable_ctrl.Checked = (OP.pdc.enable == 1);
            pdc_mode_ctrl.SelectedIndex = OP.pdc.mode;
            pdc_ref_position_ctrl.Text = Convert.ToString(OP.pdc.ref_pos);
            pdc_peak_amplitude_ctrl.Text = Convert.ToString(OP.pdc.peak_ampl);
            pdc_peak_position_ctrl.Text = Convert.ToString(OP.pdc.peak_pos);

            // Encoders' controls
            // Encoder A
            enca_enable_ctrl.Checked = (OP.enca.enable == 1);
            enca_input_mode_ctrl.SelectedIndex = OP.enca.input_mode;
            enca_idx_input_ctrl.SelectedIndex = OP.enca.idx_input;
            enca_decode_mode_ctrl.SelectedIndex = OP.enca.decode_mode;
            enca_filter_ctrl.SelectedIndex = OP.enca.filter;
            enca_comparator_step_ctrl.Text = Convert.ToString(OP.enca.comp_step);
            enca_comparator_ctrl.SelectedIndex = OP.enca.comparator;
            // Encoder B
            encb_enable_ctrl.Checked = (OP.encb.enable == 1);
            encb_input_mode_ctrl.SelectedIndex = OP.encb.input_mode;
            encb_idx_input_ctrl.SelectedIndex = OP.encb.idx_input;
            encb_decode_mode_ctrl.SelectedIndex = OP.encb.decode_mode;
            encb_filter_ctrl.SelectedIndex = OP.encb.filter;
            encb_comparator_step_ctrl.Text = Convert.ToString(OP.encb.comp_step);
            encb_comparator_ctrl.SelectedIndex = OP.encb.comparator;

            // Finally, plot data
            displayData();

            // We need dots as separator in double numbers, so we switch to american-style number formatting
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");


        }

        private void convertPDToPxValues()
        {

            // PDA conversion
            pda_X_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(OP.pd.pda_X_plot[0]));
            pda_X_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(OP.pd.pda_X_plot[1]));

            pda_Y_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(OP.pd.pda_Y_plot[0]));
            pda_Y_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(OP.pd.pda_Y_plot[1]));

            // PDB conversion
            pdb_X_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(OP.pd.pdb_X_plot[0]));
            pdb_X_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(OP.pd.pdb_X_plot[1]));

            pdb_Y_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(OP.pd.pdb_Y_plot[0]));
            pdb_Y_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(OP.pd.pdb_Y_plot[1]));

            // PDC conversion
            pdc_X_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(OP.pd.pdc_X_plot[0]));
            pdc_X_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisX.ValueToPixelPosition(OP.pd.pdc_X_plot[1]));

            pdc_Y_px[0] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(OP.pd.pdc_Y_plot[0]));
            pdc_Y_px[1] = (float)(main_chart.ChartAreas["main_area"].AxisY.ValueToPixelPosition(OP.pd.pdc_Y_plot[1]));
        }

        public void convertDataToRfAbs(byte[] meanDataY, float[] plotDataY, int plotDataSize)
        {
            if (OP.acq.mode == 0)
            {
                for (int i = 0; i < plotDataSize; i++)
                {
                    plotDataY[i] = (float)(meanDataY[i] / 256.0 - 0.5);
                }
            }
            if (OP.acq.mode == 1)
            {
                for (int i = 0; i < plotDataSize; i++)
                {
                    plotDataY[i] = (float)(meanDataY[i] / 2.56 * 2.0);
                }
            }
        }










        // THREADS

        // Thread for plot refresh at real-time - pace 
        private void plot_bgworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {


            // Remove flag which informs about finishing this thread
            plot_bgworker_finished = false;

            // Collect data until one of events cancels it
            while (true)
            {
                System.Threading.Thread.Sleep(40); // We need to display our signal at reasonable rate - plot might
                OP.collectData(); // not be able to refresh fast enough (now it is set at 40 FPS)
                if (OP.plot.window_in_smpls >= OP.plot.plot_data_size)
                {
                    copyToManagedArr(OP.data.plot_dataX, ref ext_plot_dataX, OP.plot.plot_data_size);
                    copyToManagedArr(OP.data.plot_dataY, ref ext_plot_dataY, OP.plot.plot_data_size);
                }
                else
                {
                    copyToManagedArr(OP.data.plot_dataX, ref ext_plot_dataX, OP.plot.window_in_smpls);
                    copyToManagedArr(OP.data.plot_dataY, ref ext_plot_dataY, OP.plot.window_in_smpls);
                }

                if (plot_bgworker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
            return;
        }

        // Thread for peak detectors' refresh at real - time pace
        private void pd_disp_bgworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
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

        private void data_bgworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

           OP.data.data_buffer = op_wrp_GetDataHandleF(100000);

            // Remove flag which informs about finishing this thread
            plot_bgworker_finished = false;

            //// Collect frames once they are available, until we cancel this task by
            //// clicking the 'btn_start' again
            while (true)
            {
                if (op_wrp_Check_Frame_Ready() == 1)
                {
                    OP.errorCode = op_wrp_GetData((OP.plot.window_in_smpls) + (OP.data.header_size));

                    if (OP.trig.trigger_source == 0) // Otherwise, trigger doesnt need to be done by software
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
        private void power_ctrl_timer_Tick(object sender, System.EventArgs e)
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
                    OP.errorCode = turnOffAcquisition();
                }

                int error_read = OP.errorCode;

                // Try until we get rid of error or user decides to close application
                for (int i = 1; i <= OP.no_of_tries; i++)
                {
                    if (i <= OP.no_of_tries)
                    {
                        OP.errorCode = OP.initSession();
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
                                for (int j = 0; j <= OP.no_of_tries; j++)
                                {
                                    OP.errorCode = turnOffAcquisition(); // First, we must make sure we finish previous acquisition correctly.
                                    if (OP.errorCode == 0)
                                    {
                                        OP.errorCode = turnOnAcquisition(); // Then, we start acquisition if everything is fine.
                                        break;
                                    }
                                    else if (j == OP.no_of_tries)
                                        break;
                                }
                            }
                            power_ctrl_timer.Enabled = true; // Turn on power check control again
                            break;
                        }
                        if (i == OP.no_of_tries)
                        {
                            i++;
                        }
                    }

                    if (i > OP.no_of_tries)
                    {
                        string error_string = "Power error - Connect OPBOX and restart application!";
                        MessageBox.Show(error_string, "OPBOX 2.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                        return;
                    }
                }
            }
        }

        private void err_timer_Tick(object sender, System.EventArgs e)
        {
            err_display.Text = numToMStr(OP.errorCode);
        }


        private void pd_results_timer_Tick(object sender, System.EventArgs e)
        {

            // Calculate peak detectors' values collected by OPBOX
            OP.pda.ref_pos_opbox = OP.data.data_buffer[19] + (1 << 8) * OP.data.data_buffer[20] + (1 << 16) * (OP.data.data_buffer[21] % 2);
            OP.pdb.ref_pos_opbox = OP.data.data_buffer[29] + (1 << 8) * OP.data.data_buffer[30] + (1 << 16) * (OP.data.data_buffer[31] % 2);
            OP.pdc.ref_pos_opbox = OP.data.data_buffer[39] + (1 << 8) * OP.data.data_buffer[40] + (1 << 16) * (OP.data.data_buffer[41] % 2);

            OP.pda.max_pos_opbox = OP.data.data_buffer[25] + (1 << 8) * OP.data.data_buffer[26] + (1 << 16) * (OP.data.data_buffer[27] % 2);
            OP.pdb.max_pos_opbox = OP.data.data_buffer[35] + (1 << 8) * OP.data.data_buffer[36] + (1 << 16) * (OP.data.data_buffer[37] % 2);
            OP.pdc.max_pos_opbox = OP.data.data_buffer[45] + (1 << 8) * OP.data.data_buffer[46] + (1 << 16) * (OP.data.data_buffer[47] % 2);

            OP.pda.max_val_opbox = OP.data.data_buffer[23];
            OP.pdb.max_val_opbox = OP.data.data_buffer[33];
            OP.pdc.max_val_opbox = OP.data.data_buffer[43];

            // Convert collected values to plot units
            OP.pda.ref_pos = Math.Round(OP.pda.ref_pos_opbox / OP.plot.sampling_freq_real * 100.0) / 100.0 + OP.acq.delay;
            OP.pdb.ref_pos = Math.Round(OP.pdb.ref_pos_opbox / OP.plot.sampling_freq_real * 100.0) / 100.0 + OP.acq.delay;
            OP.pdc.ref_pos = Math.Round(OP.pdc.ref_pos_opbox / OP.plot.sampling_freq_real * 100.0) / 100.0 + OP.acq.delay;

            if (OP.acq.mode == 0)
            { // RF
                OP.pda.peak_ampl = Math.Round((OP.pda.max_val_opbox / 256.0 - 0.5) * 100.0) / 100.0;
                OP.pdb.peak_ampl = Math.Round((OP.pdb.max_val_opbox / 256.0 - 0.5) * 100.0) / 100.0;
                OP.pdc.peak_ampl = Math.Round((OP.pdc.max_val_opbox / 256.0 - 0.5) * 100.0) / 100.0;
            }
            else
            { // ABS
                OP.pda.peak_ampl = Math.Round(OP.pda.max_val_opbox / 2.56 * 100.0 * 2.0) / 100.0;
                OP.pdb.peak_ampl = Math.Round(OP.pdb.max_val_opbox / 2.56 * 100.0 * 2.0) / 100.0;
                OP.pdc.peak_ampl = Math.Round(OP.pdc.max_val_opbox / 2.56 * 100.0 * 2.0) / 100.0;
            }

            OP.pda.peak_pos = Math.Round(OP.pda.max_pos_opbox / OP.plot.sampling_freq_real * 100.0) / 100.0 + OP.acq.delay;
            OP.pdb.peak_pos = Math.Round(OP.pdb.max_pos_opbox / OP.plot.sampling_freq_real * 100.0) / 100.0 + OP.acq.delay;
            OP.pdc.peak_pos = Math.Round(OP.pdc.max_pos_opbox / OP.plot.sampling_freq_real * 100.0) / 100.0 + OP.acq.delay;

            // Display it inside our indicators
            if (OP.pda.enable == 1)
            {
                pda_ref_position_ctrl.Text = numToMStr(OP.pda.ref_pos);
                pda_peak_amplitude_ctrl.Text = numToMStr(OP.pda.peak_ampl);
                pda_peak_position_ctrl.Text = numToMStr(OP.pda.peak_pos);
            }

            if (OP.pdb.enable == 1)
            {
                pdb_ref_position_ctrl.Text = numToMStr(OP.pdb.ref_pos);
                pdb_peak_amplitude_ctrl.Text = numToMStr(OP.pdb.peak_ampl);
                pdb_peak_position_ctrl.Text = numToMStr(OP.pdb.peak_pos);
            }
            if (OP.pdc.enable == 1)
            {
                pdc_ref_position_ctrl.Text = numToMStr(OP.pdc.ref_pos);
                pdc_peak_amplitude_ctrl.Text = numToMStr(OP.pdc.peak_ampl);
                pdc_peak_position_ctrl.Text = numToMStr(OP.pdc.peak_pos);
            }
        }


        public static byte[] convertdoubleTobytearray(double values)
        {
            return BitConverter.GetBytes(values);
        }
        private string numToMStr(int int_value)
        {

            string vOut = int_value.ToString();
            return vOut;
        }
        private string intToMStrHex(int int_value)
        {

            string vOut = int_value.ToString();
            return vOut;
        }
        private string numToMStr(double double_value)
        {
            string vOut = double_value.ToString();
            return vOut;
        }
        public void displayData()
        {
            main_chart.Series["main_data"].Points.DataBindXY(ext_plot_dataX, ext_plot_dataY);
            main_chart.Refresh();
        }

        private void displayPD()
        {
            OP.refreshPDArrays();
            if (OP.pda.enable == 1)
            {
                main_chart.Series["pd_a"].Points.DataBindXY(MA.createManagedArr(OP.pd.pda_X_plot, 2), MA.createManagedArr(OP.pd.pda_Y_plot, 2));
            }
            if (OP.pdb.enable == 1)
            {
                main_chart.Series["pd_b"].Points.DataBindXY(MA.createManagedArr(OP.pd.pdb_X_plot, 2), MA.createManagedArr(OP.pd.pdb_Y_plot, 2));
            }
            if (OP.pdc.enable == 1)
            {
                main_chart.Series["pd_c"].Points.DataBindXY(MA.createManagedArr(OP.pd.pdc_X_plot, 2), MA.createManagedArr(OP.pd.pdc_Y_plot, 2));
            }
            main_chart.Refresh();
        }

      

        private void copyToManagedArr(float[] unmanaged_arr, ref float[] managed_arr, int arr_size)
        {
            for (int i = 0; i < arr_size; i++)
            {
                managed_arr[i] = unmanaged_arr[i];
            }
        }

        private void test_mode_txt_TextChanged(object sender, EventArgs e)
        {

        }


        // TIMERS 

        // Timer for correct plot refreshing (50 FPS)
        private void plot_timer_Tick(object sender, System.EventArgs e)
        {
            displayData();
        }

        // Timer for FPS calculations (once per second)
        private void fps_timer_Tick(object sender, System.EventArgs e)
        {
            int fps_value = counter_end - counter_begin;
            fps_display.Text = numToMStr(fps_value);
            counter_begin = counter_end;
        }

        private void pd_timer_Tick(object sender, System.EventArgs e)
        {

            // We check if any kind of error occured by checking values
            // - all 0's returned from OPBOX is a fair sign that we somehow lost peak detector
            for (int pd_no = 0; pd_no < 3; pd_no++)
            {

                if ((!isPDResultCorrect(pd_no)) && (isUserPDSetupCorrect(pd_no)))
                { // if that happens for any PD, we simply set it again
                    for (int i = 0; i <= OP.no_of_tries; i++)
                    {
                        if (OP.isPdEnabled(pd_no))
                        {
                            OP.setPdEnable(0, pd_no);
                            OP.setPdEnable(1, pd_no);
                        }
                        OP.setPeakDetector(pd_no);

                        // After 5 retries, we can safely assume that user set it incorrectly
                        if (!isPDResultCorrect(pd_no) && (i == OP.no_of_tries))
                        {
                            OP.setPdUserErr(pd_no, 1);
                        }
                    }
                }
            }
            displayPD();


            // HEREHERE - Test values from Opbox
            if (testing_enabled)
            {

                // Opbox values
                pda_test_level_opbox.Text = Convert.ToString(OP.pda.max_val_opbox);
                pdb_test_level_opbox.Text = Convert.ToString(OP.pdb.max_val_opbox);
                pdc_test_level_opbox.Text = Convert.ToString(OP.pdc.max_val_opbox);

                pda_test_min_opbox.Text = Convert.ToString(OP.pda.ref_pos_opbox);
                pdb_test_min_opbox.Text = Convert.ToString(OP.pdb.ref_pos_opbox);
                pdc_test_min_opbox.Text = Convert.ToString(OP.pdc.ref_pos_opbox);

                pda_test_max_opbox.Text = Convert.ToString(OP.pda.max_pos_opbox);
                pdb_test_max_opbox.Text = Convert.ToString(OP.pdb.max_pos_opbox);
                pdc_test_max_opbox.Text = Convert.ToString(OP.pdc.max_pos_opbox);

                // Plot values
                pda_test_y_plot.Text = Convert.ToString(OP.pd.pd_posY_plot[0]);
                pdb_test_y_plot.Text = Convert.ToString(OP.pd.pd_posY_plot[1]);
                pdc_test_y_plot.Text = Convert.ToString(OP.pd.pd_posY_plot[2]);

                pda_test_x1_plot.Text = Convert.ToString(OP.pd.pd_posX1_plot[0]);
                pdb_test_x1_plot.Text = Convert.ToString(OP.pd.pd_posX1_plot[1]);
                pdc_test_x1_plot.Text = Convert.ToString(OP.pd.pd_posX1_plot[2]);

                pda_test_x2_plot.Text = Convert.ToString(OP.pd.pd_posX2_plot[0]);
                pdb_test_x2_plot.Text = Convert.ToString(OP.pd.pd_posX2_plot[1]);
                pdc_test_x2_plot.Text = Convert.ToString(OP.pd.pd_posX2_plot[2]);

                // Peak detection
                int pda_found = 0;
                int pdb_found = 0;
                int pdc_found = 0;

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
        private bool isPDResultCorrect(int pd_no)
        {
            switch (pd_no)
            {
                case 0:
                    if ((OP.pda.ref_pos_opbox == 0) && (OP.pda.max_val_opbox == 0) && (OP.pda.max_pos_opbox == 0))
                    {
                        return false;
                    }
                    break;
                case 1:
                    if ((OP.pdb.ref_pos_opbox == 0) && (OP.pdb.max_val_opbox == 0) && (OP.pdb.max_pos_opbox == 0))
                    {
                        return false;
                    }
                    break;
                case 2:
                    if ((OP.pdc.ref_pos_opbox == 0) && (OP.pdc.max_val_opbox == 0) && (OP.pdc.max_pos_opbox == 0))
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }
        private bool isUserPDSetupCorrect(int pd_no)
        {
            switch (pd_no)
            {
                case 0:
                    if (OP.pda.user_error != 0)
                    {
                        return false;
                    }
                    break;
                case 1:
                    if (OP.pdb.user_error != 0)
                    {
                        return false;
                    }
                    break;
                case 2:
                    if (OP.pdc.user_error != 0)
                    {
                        return false;
                    }
                    break;
            }
            return true;
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
                if ((OP.enca.enable == 1) || (OP.encb.enable == 1))
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
                ampl_test.Text = numToMStr(OP.ampl.preamplifier); // Display value sent to OPBOX as amplitude level parameter
                source_test.Text = numToMStr(OP.ampl.input_source); // Display value sent to OPBOX as input source
                amplitude_level_test.Text = numToMStr(OP.puls.amplitude_level); // Display value sent to OPBOX as amplitude level
                if (OP.enca.enable == 1)
                {
                    enca_test.Text = numToMStr(op_wrp_GetEncoderPosit(0)); // Display Encoder A position in samples
                }
                else
                {
                    enca_test.Text = "Disabled";
                }

                if (OP.encb.enable == 1)
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






        private void encb_comparator_step_ctrl_TextChanged(object sender, System.EventArgs e)
        {
            encb_comparator_step_changed = true;
        }

        private void encb_comparator_step_ctrl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                int pos = encb_comparator_step_ctrl.SelectionStart;
                encb_comparator_step_ctrl.Text = encb_comparator_step_ctrl.Text.Insert(pos, "");
                encb_comparator_step_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }

            else if (e.KeyChar == ' ')
            {
                int pos = encb_comparator_step_ctrl.SelectionStart;
                encb_comparator_step_ctrl.Text = encb_comparator_step_ctrl.Text.Insert(pos, "");
                encb_comparator_step_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }
        }

        private void encb_comparator_step_ctrl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                //Turn off the acquisistion
                if (measurementInProgress)
                {
                    turnOffAcquisition();
                }

                int comp_step;
                if (System.Int32.TryParse(encb_comparator_step_ctrl.Text, out comp_step))
                {
                    OP.errorCode = OP.setEncComparatorStep(comp_step, 1);
                }

                // Update UI value with actual value for charging time
                encb_comparator_step_ctrl.Text = Convert.ToString(OP.encb.comp_step);

                //Turn on the acquisistion
                if (measurementInProgress)
                {
                    turnOnAcquisition();
                }

                encb_comparator_step_changed = false;
            }
        }

        private void encb_comparator_step_ctrl_Leave(object sender, System.EventArgs e)
        {
            if (encb_comparator_step_changed)
            {

                //Turn off the acquisistion
                if (measurementInProgress)
                {
                    turnOffAcquisition();
                }

                int comp_step;
                if (System.Int32.TryParse(encb_comparator_step_ctrl.Text, out comp_step))
                {
                    OP.errorCode = OP.setEncComparatorStep(comp_step, 1);
                }

                // Update UI value with actual value for charging time
                encb_comparator_step_ctrl.Text = Convert.ToString(OP.encb.comp_step);

                //Turn on the acquisistion
                if (measurementInProgress)
                {
                    turnOnAcquisition();
                }

                encb_comparator_step_changed = false;
            }
        }

        // Encoders' comparator step controls
        // Enc A
        private void enca_comparator_step_ctrl_TextChanged(object sender, System.EventArgs e)
        {
            enca_comparator_step_changed = true;
        }

        private void enca_comparator_step_ctrl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                int pos = enca_comparator_step_ctrl.SelectionStart;
                enca_comparator_step_ctrl.Text = enca_comparator_step_ctrl.Text.Insert(pos, "");
                enca_comparator_step_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }

            else if (e.KeyChar == ' ')
            {
                int pos = enca_comparator_step_ctrl.SelectionStart;
                enca_comparator_step_ctrl.Text = enca_comparator_step_ctrl.Text.Insert(pos, "");
                enca_comparator_step_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }
        }

        private void enca_comparator_step_ctrl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                //Turn off the acquisistion
                if (measurementInProgress)
                {
                    turnOffAcquisition();
                }

                int comp_step;
                if (System.Int32.TryParse(enca_comparator_step_ctrl.Text, out comp_step))
                {
                    OP.errorCode = OP.setEncComparatorStep(comp_step, 0);
                }

                // Update UI value with actual value for charging time
                enca_comparator_step_ctrl.Text = Convert.ToString(OP.enca.comp_step);

                //Turn on the acquisistion
                if (measurementInProgress)
                {
                    turnOnAcquisition();
                }

                enca_comparator_step_changed = false;
            }
        }

        private void enca_comparator_step_ctrl_Leave(object sender, System.EventArgs e)
        {
            if (enca_comparator_step_changed)
            {

                //Turn off the acquisistion
                if (measurementInProgress)
                {
                    turnOffAcquisition();
                }

                int comp_step;
                if (System.Int32.TryParse(enca_comparator_step_ctrl.Text, out comp_step))
                {
                    OP.errorCode = OP.setEncComparatorStep(comp_step, 0);
                }

                // Update UI value with actual value for charging time
                enca_comparator_step_ctrl.Text = Convert.ToString(OP.enca.comp_step);

                //Turn on the acquisistion
                if (measurementInProgress)
                {
                    turnOnAcquisition();
                }

                enca_comparator_step_changed = false;
            }
        }




        // Acquisition controls:
        // Sampling freq
        private void sampling_freq_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            // Turn off acquisition
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            int current_sample_no = (int)(OP.acq.window * (100.0 / (OP.acq.sampling_freq + 1)));
            OP.setSamplingFreqFull(sampling_freq_ctrl.SelectedIndex);
            updatePlotXAxis(OP.plot.min_x, OP.plot.max_x);
            recreateExtDataArrays(OP.plot.sampling_freq_real, OP.acq.window, current_sample_no);

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
                OP.errorCode = turnOnAcquisition();
                System.Threading.Thread.Sleep(50);
                OP.collectData();
                displayData();
                OP.errorCode = turnOffAcquisition();
            }

            // Turn on acquisition
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }
        }


        // Mode control
        private void mode_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            if (mode_ctrl.SelectedIndex != OP.acq.mode)
            {

                if (measurementInProgress)
                {
                    turnOffAcquisition();
                }

                // We don't need to watch our conversion, we just want to see the result,
                // so during our conversion we disable main data series
                main_chart.Series["main_data"].Enabled = false;

                OP.setDataModeFull(mode_ctrl.SelectedIndex);

                if (mode_ctrl.SelectedIndex == 1)
                {

                    text_pd_peak_ampl.Text = "Peak Ampl. [%]";
                    main_chart.ChartAreas["main_area"].AxisY.Minimum = OP.plot.min_y;
                    main_chart.ChartAreas["main_area"].AxisY.Maximum = OP.plot.max_y;
                    main_chart.ChartAreas["main_area"].AxisY.Interval = (int)((OP.plot.max_y - OP.plot.min_y) / 10);
                    main_chart.ChartAreas["main_area"].AxisY.Title = "Amplitude [%]";
                }
                else
                {

                    text_pd_peak_ampl.Text = "Peak Ampl. [V]";
                    main_chart.ChartAreas["main_area"].AxisY.Minimum = OP.plot.min_y;
                    main_chart.ChartAreas["main_area"].AxisY.Maximum = OP.plot.max_y;
                    main_chart.ChartAreas["main_area"].AxisY.Interval = ((OP.plot.max_y - OP.plot.min_y) / 10);
                    main_chart.ChartAreas["main_area"].AxisY.Title = "Amplitude [V]";
                }

                if (!pd_disp_bgworker.IsBusy)
                {
                    displayPD();
                }

                if (!plot_bgworker.IsBusy)
                {
                    // Collect data and display so we can see the difference
                    OP.errorCode = turnOnAcquisition();
                    System.Threading.Thread.Sleep(50);
                    OP.collectData();
                    displayData();
                    OP.errorCode = turnOffAcquisition();
                }

                // We can safely turn data series on after we did the conversion
                main_chart.Series["main_data"].Enabled = true;

                if (measurementInProgress)
                {
                    turnOnAcquisition();
                }
            }
        }




        // Depth controls
        private void window_ctrl_TextChanged(object sender, System.EventArgs e)
        {
            window_changed = true;
        }

        // Control input after each key press (comma replacement)
        private void window_ctrl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
                    OP.errorCode = turnOffAcquisition();
                    OP.errorCode = op_wrp_TrigReset();
                }

                int current_sample_no = (int)(OP.acq.window * (100.0 / (OP.acq.sampling_freq + 1)));

                double depth_value;
                if (System.Double.TryParse(window_ctrl.Text, out depth_value))
                {
                    OP.setDepthFull(depth_value);
                    window_ctrl.Text = Convert.ToString(OP.acq.window);
                }
                else
                {
                    window_ctrl.Text = Convert.ToString(OP.acq.window);
                }

                updatePlotXAxis(OP.plot.min_x, OP.plot.max_x);
                recreateExtDataArrays(OP.plot.sampling_freq_real, OP.acq.window, current_sample_no);

                if (testing_enabled)
                {
                    window_test.Text = numToMStr(op_wrp_GetDepth());
                }

                if (!plot_bgworker.IsBusy)
                {
                    // Collect single data frame
                    OP.errorCode = turnOnAcquisition();
                    System.Threading.Thread.Sleep(50);
                    OP.collectData();
                    displayData();
                    OP.errorCode = turnOffAcquisition();
                    OP.errorCode = op_wrp_TrigReset();
                }

                // Turn on acquisition if it was disabled just for parameter change
                if (measurementInProgress)
                {
                    OP.errorCode = turnOnAcquisition();
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
                    OP.errorCode = turnOffAcquisition();
                    OP.errorCode = op_wrp_TrigReset();
                }

                int current_sample_no = (int)(OP.acq.window * (100.0 / (OP.acq.sampling_freq + 1)));

                double depth_value;
                if (System.Double.TryParse(window_ctrl.Text, out depth_value))
                {
                    OP.setDepthFull(depth_value);
                    window_ctrl.Text = Convert.ToString(OP.acq.window);
                }
                else
                {
                    window_ctrl.Text = Convert.ToString(OP.acq.window);
                }

                updatePlotXAxis(OP.plot.min_x, OP.plot.max_x);

                recreateExtDataArrays(OP.plot.sampling_freq_real, OP.acq.window, current_sample_no);

                if (testing_enabled)
                {
                    window_test.Text = numToMStr(op_wrp_GetDepth());
                }

                if (!plot_bgworker.IsBusy)
                {
                    // Collect single data frame
                    OP.errorCode = turnOnAcquisition();
                    System.Threading.Thread.Sleep(50);
                    OP.collectData();
                    displayData();
                    OP.errorCode = turnOffAcquisition();
                    OP.errorCode = op_wrp_TrigReset();
                }

                // Turn on measurement if it was stopped just for parameter change
                if (measurementInProgress)
                {
                    OP.errorCode = turnOnAcquisition();
                }

                window_changed = false;
            }
        }



        // Delay controls
        private void delay_ctrl_TextChanged(object sender, System.EventArgs e)
        {
            delay_changed = true;
        }

        // Control input after each key press (comma replacement)		
        private void delay_ctrl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (e.KeyChar == ',')
            {
                int pos = delay_ctrl.SelectionStart;
                delay_ctrl.Text = delay_ctrl.Text.Insert(pos, ".");
                delay_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }

            else if (e.KeyChar == ' ')
            {
                int pos = delay_ctrl.SelectionStart;
                delay_ctrl.Text = delay_ctrl.Text.Insert(pos, "");
                delay_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }
        }

        // Controls ENTER hit (checks and claims value input by user)
        private void delay_ctrl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                double delay_value;
                if (System.Double.TryParse(delay_ctrl.Text, out delay_value))
                {
                    OP.setDelayFull(delay_value);
                    delay_ctrl.Text = Convert.ToString(OP.acq.delay);
                }
                else
                {
                    delay_ctrl.Text = Convert.ToString(OP.acq.delay);
                }

                updatePlotXAxis(OP.plot.min_x, OP.plot.max_x);

                if (!plot_bgworker.IsBusy)
                {
                    displayData();
                }

                if (testing_enabled)
                {
                    delay_test.Text = numToMStr(op_wrp_GetDelay());
                }

                delay_changed = false;
            }
        }

        // Controls leave event (checks and claims value input by user)
        private void delay_ctrl_Leave(object sender, System.EventArgs e)
        {
            if (delay_changed)
            {

                double delay_value;
                if (System.Double.TryParse(delay_ctrl.Text, out delay_value))
                {
                    OP.setDelayFull(delay_value);
                    delay_ctrl.Text = Convert.ToString(OP.acq.delay);
                }
                else
                {
                    delay_ctrl.Text = Convert.ToString(OP.acq.delay);
                }

                updatePlotXAxis(OP.plot.min_x, OP.plot.max_x);

                if (!plot_bgworker.IsBusy)
                {
                    displayData();
                }

                if (testing_enabled)
                {
                    delay_test.Text = numToMStr(op_wrp_GetDelay());
                }

                delay_changed = false;
            }
        }


        // Amplifiers' controls:
        // Filter bandtwidth control
        private void filter_bandtwidth_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.ampl.filter_bandtwidth = filter_bandtwidth_ctrl.SelectedIndex;

            // Turn off acquisition
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setAnalogFilter(OP.ampl.filter_bandtwidth);

            if (testing_enabled)
            {
                filter_test.Text = intToMStrHex(op_wrp_GetAnalog());
                ampl_test.Text = numToMStr(OP.ampl.preamplifier);
                source_test.Text = numToMStr(OP.ampl.input_source);
                amplitude_level_test.Text = numToMStr(OP.puls.amplitude_level);
            }

            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }
        }

        // Preamplifier control
        private void preamplifier_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.ampl.preamplifier = preamplifier_ctrl.SelectedIndex;

            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setPreamplifier(OP.ampl.preamplifier);

            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }

            if (testing_enabled)
            {
                filter_test.Text = intToMStrHex(op_wrp_GetAnalog());
                ampl_test.Text = numToMStr(OP.ampl.preamplifier);
                source_test.Text = numToMStr(OP.ampl.input_source);
                amplitude_level_test.Text = numToMStr(OP.puls.amplitude_level);
            }
        }




        // Input source control
        private void input_source_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.ampl.input_source = input_source_ctrl.SelectedIndex;

            // Turn off acquisition
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setInputSource(OP.ampl.input_source);

            // Turn on acquisition
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }

            if (OP.ampl.input_source == 0)
            {
                main_chart.Titles["pe_plot_title"].Visible = true;
                main_chart.Titles["tt_plot_title"].Visible = false;
            }
            else
            {
                main_chart.Titles["pe_plot_title"].Visible = false;
                main_chart.Titles["tt_plot_title"].Visible = true;
            }

            if (testing_enabled)
            {
                filter_test.Text = intToMStrHex(op_wrp_GetAnalog());
                ampl_test.Text = numToMStr(OP.ampl.preamplifier);
                source_test.Text = numToMStr(OP.ampl.input_source);
                amplitude_level_test.Text = numToMStr(OP.puls.amplitude_level);
            }
        }


        // Gain controls
        private void gain_ctrl_TextChanged(object sender, System.EventArgs e)
        {
            gain_changed = true;
        }

        private void gain_ctrl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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

        private void gain_ctrl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string current_value = Convert.ToString(OP.ampl.gain);
                string input_value = gain_ctrl.Text;
                string correct_value = OP.inputCheck(input_value, current_value, 2);
                gain_ctrl.Text = correct_value;
                System.Int32.TryParse(correct_value, out OP.ampl.gain);

                // Turn off acquisition
                if (measurementInProgress)
                {
                    OP.errorCode = turnOffAcquisition();
                }

                OP.errorCode = OP.setGain(OP.ampl.gain);

                // Turn on acquisition
                if (measurementInProgress)
                {
                    OP.errorCode = turnOnAcquisition();
                }

                gain_changed = false;
            }
        }

        private void gain_ctrl_Leave(object sender, System.EventArgs e)
        {
            if (gain_changed)
            {
                string current_value = Convert.ToString(OP.ampl.gain);
                string input_value = gain_ctrl.Text;
                string correct_value = OP.inputCheck(input_value, current_value, 2);
                gain_ctrl.Text = correct_value;
                System.Int32.TryParse(correct_value, out OP.ampl.gain);

                // Turn off acquisition
                if (measurementInProgress)
                {
                    OP.errorCode = turnOffAcquisition();
                }

                OP.errorCode = OP.setGain(OP.ampl.gain);

                // Turn off acquisition
                if (measurementInProgress)
                {
                    OP.errorCode = turnOnAcquisition();
                }

                gain_changed = false;
            }
        }


        // Gain mode control
        private void gain_mode_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.ampl.gain_mode = gain_mode_ctrl.SelectedIndex;

            // Turn off acquisition
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setGainMode(OP.ampl.gain_mode);

            // Turn on acquisition
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }
        }


        // Pulser controls:
        // Amplitude level control
        private void amplitude_level_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            // Turn off acquisition
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.puls.amplitude_level = amplitude_level_ctrl.SelectedIndex;
            OP.errorCode = OP.setAmplitudeLevel(OP.puls.amplitude_level);
            OP.initSession();

            // Turn on acquisition
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }

            if (testing_enabled)
            {
                filter_test.Text = intToMStrHex(op_wrp_GetAnalog());
                ampl_test.Text = numToMStr(OP.ampl.preamplifier);
                source_test.Text = numToMStr(OP.ampl.input_source);
                amplitude_level_test.Text = numToMStr(OP.puls.amplitude_level);
            }
        }

        // Charging time controls
        private void charging_time_ctrl_TextChanged(object sender, System.EventArgs e)
        {
            charging_time_changed = true;
        }

        private void charging_time_ctrl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                int pos = charging_time_ctrl.SelectionStart;
                charging_time_ctrl.Text = charging_time_ctrl.Text.Insert(pos, ".");
                charging_time_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }

            else if (e.KeyChar == ' ')
            {
                int pos = charging_time_ctrl.SelectionStart;
                charging_time_ctrl.Text = charging_time_ctrl.Text.Insert(pos, "");
                charging_time_ctrl.SelectionStart = pos + 1;
                e.Handled = true;

            }
        }

        private void charging_time_ctrl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                // Turn off acquisition
                if (measurementInProgress)
                {
                    OP.errorCode = turnOffAcquisition();
                }

                float charging_time;
                if (System.Single.TryParse(charging_time_ctrl.Text, out charging_time))
                {
                    OP.setChargingTimeFull(charging_time);
                }

                // Update UI value with actual value for charging time
                charging_time_ctrl.Text = Convert.ToString(OP.puls.charging_time);

                // Turn on acquisition
                if (measurementInProgress)
                {
                    OP.errorCode = turnOnAcquisition();
                }

                charging_time_changed = false;
            }
        }

        private void charging_time_ctrl_Leave(object sender, System.EventArgs e)
        {
            if (charging_time_changed)
            {

                // Turn off acquisition
                if (measurementInProgress)
                {
                    OP.errorCode = turnOffAcquisition();
                }

                float charging_time;
                if (System.Single.TryParse(charging_time_ctrl.Text, out charging_time))
                {
                    OP.errorCode = OP.setChargingTime(OP.puls.charging_time);
                }

                // Update UI value with actual value for charging time
                charging_time_ctrl.Text = Convert.ToString(OP.puls.charging_time);

                // Turn on acquisition
                if (measurementInProgress)
                {
                    OP.errorCode = turnOnAcquisition();
                }

                charging_time_changed = false;
            }
        }



        // Trigger controls:
        // Trigger source control
        private void trigger_source_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.trig.trigger_source = trigger_source_ctrl.SelectedIndex;
            OP.errorCode = OP.setTriggerSource(OP.trig.trigger_source);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }
        }


        // Timer period controls
        private void timer_period_ctrl_TextChanged(object sender, System.EventArgs e)
        {
            timer_period_changed = true;
        }

        private void timer_period_ctrl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                int pos = timer_period_ctrl.SelectionStart;
                timer_period_ctrl.Text = timer_period_ctrl.Text.Insert(pos, ".");
                timer_period_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }

            else if (e.KeyChar == ' ')
            {
                int pos = timer_period_ctrl.SelectionStart;
                timer_period_ctrl.Text = timer_period_ctrl.Text.Insert(pos, "");
                timer_period_ctrl.SelectionStart = pos + 1;
                e.Handled = true;
            }
        }

        private void timer_period_ctrl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                //Turn off the acquisistion
                if (measurementInProgress)
                {
                    OP.errorCode = turnOffAcquisition();
                }

                double timer_period;
                if (System.Double.TryParse(timer_period_ctrl.Text, out timer_period))
                {
                    OP.errorCode = OP.setTimerPeriod(timer_period);
                }

                // Update UI value with actual value for charging time
                timer_period_ctrl.Text = Convert.ToString(OP.trig.timer_period);

                //Turn on the acquisistion
                if (measurementInProgress)
                {
                    OP.errorCode = turnOnAcquisition();
                }

                timer_period_changed = false;
            }
        }

        private void timer_period_ctrl_Leave(object sender, System.EventArgs e)
        {
            if (timer_period_changed)
            {

                //if(System::Double::TryParse(correct_value, opbox->trig.timer_period) )

                //Turn off the acquisistion
                if (measurementInProgress)
                {
                    OP.errorCode = turnOffAcquisition();
                }

                double timer_period;
                if (System.Double.TryParse(timer_period_ctrl.Text, out timer_period))
                {
                    OP.errorCode = OP.setTimerPeriod(OP.trig.timer_period);
                }

                // Update UI value with actual value for charging time
                timer_period_ctrl.Text = Convert.ToString(OP.puls.charging_time);


                //Turn on the acquisistion
                if (measurementInProgress)
                {
                    OP.errorCode = turnOnAcquisition();
                }

                timer_period_changed = false;
            }
        }


        // XY Divider
        private void xy_divider_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.trig.xy_divider = xy_divider_ctrl.SelectedIndex; // * 32000; //almost equal division

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setXYDivider(OP.trig.xy_divider);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }
        }


        // Peak Detectors' controls:
        // Peak Detectors' enable controls
        // PDA

        private void pda_enable_ctrl_CheckedChanged(object sender, System.EventArgs e)
        {
            if (pda_enable_ctrl.CheckState == CheckState.Checked)
            {
                pd_timer.Enabled = true;
                OP.pda.enable = 1;
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
                OP.pda.enable = 0;
                main_chart.Series["pd_a"].Enabled = false;
                pda_enable_ctrl.ForeColor = System.Drawing.Color.White;
                pda_ref_position_ctrl.Enabled = false;
                pda_peak_amplitude_ctrl.Enabled = false;
                pda_peak_position_ctrl.Enabled = false;
            }

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setPdEnable(OP.pda.enable, 0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }

        }
        // PDB
        private void pdb_enable_ctrl_CheckedChanged(object sender, System.EventArgs e)
        {
            if (pdb_enable_ctrl.CheckState == CheckState.Checked)
            {
                pd_timer.Enabled = true;
                OP.pdb.enable = 1;
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
                OP.pdb.enable = 0;
                main_chart.Series["pd_b"].Enabled = false;
                pdb_enable_ctrl.ForeColor = System.Drawing.Color.White;
                pdb_ref_position_ctrl.Enabled = false;
                pdb_peak_amplitude_ctrl.Enabled = false;
                pdb_peak_position_ctrl.Enabled = false;
            }

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setPdEnable(OP.pdb.enable, 1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }
        }
        // PDC
        private void pdc_enable_ctrl_CheckedChanged(object sender, System.EventArgs e)
        {
            if (pdc_enable_ctrl.CheckState == CheckState.Checked)
            {
                pd_timer.Enabled = true;
                OP.pdc.enable = 1;
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
                OP.pdc.enable = 0;
                main_chart.Series["pd_c"].Enabled = false;
                pdc_enable_ctrl.ForeColor = System.Drawing.Color.White;
                pdc_ref_position_ctrl.Enabled = false;
                pdc_peak_amplitude_ctrl.Enabled = false;
                pdc_peak_position_ctrl.Enabled = false;
            }

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setPdEnable(OP.pdc.enable, 2);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }
        }


        // Peak Detectors' mode controls
        // PDA
        private void pda_mode_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.pda.mode = pda_mode_ctrl.SelectedIndex;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setPdMode(OP.pda.mode, 0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }

        }
        // PDB
        private void pdb_mode_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.pdb.mode = pdb_mode_ctrl.SelectedIndex;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setPdMode(OP.pdb.mode, 1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }
        }
        // PDC
        private void pdc_mode_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.pdc.mode = pdc_mode_ctrl.SelectedIndex;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOffAcquisition();
            }

            OP.errorCode = OP.setPdMode(OP.pdc.mode, 2);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                OP.errorCode = turnOnAcquisition();
            }
        }


        // Encoders' controls:
        // Encoders' enable control
        // Enc A
        private void enca_enable_ctrl_CheckedChanged(object sender, System.EventArgs e)
        {
            if (enca_enable_ctrl.CheckState == CheckState.Checked)
            {
                OP.enca.enable = 1;

                // if another encoder is also disabled, then our enc_timer must be disabled - turn it on!
                if (testing_enabled && (enca_enable_ctrl.CheckState == CheckState.Unchecked) || (encb_enable_ctrl.CheckState == CheckState.Unchecked))
                {
                    enc_results_timer.Enabled = true;
                }
            }
            else
            {
                OP.enca.enable = 0;

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

            OP.errorCode = OP.setEncEnable(OP.enca.enable, 0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }


        // Enc B
        private void encb_enable_ctrl_CheckedChanged(object sender, System.EventArgs e)
        {
            if (encb_enable_ctrl.CheckState == CheckState.Checked)
            {
                OP.encb.enable = 1;

                // if another encoder is also disabled, then our enc_timer must be disabled - turn it on!
                if (testing_enabled && (enca_enable_ctrl.CheckState == CheckState.Unchecked) || (encb_enable_ctrl.CheckState == CheckState.Unchecked))
                {
                    enc_results_timer.Enabled = true;
                }
            }
            else
            {
                OP.encb.enable = 0;

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

            OP.errorCode = OP.setEncEnable(OP.encb.enable, 1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }

        // Encoders' input mode control
        // Enc A
        private void enca_input_mode_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.enca.input_mode = enca_input_mode_ctrl.SelectedIndex;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.errorCode = OP.setEncInputMode(OP.enca.input_mode, 0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }
        // Enc B
        private void encb_input_mode_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.encb.input_mode = encb_input_mode_ctrl.SelectedIndex;
            int set_value = OP.encb.input_mode;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.errorCode = OP.setEncInputMode(OP.encb.input_mode, 1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }

        // Encoders' index input control
        // Enc A
        private void enca_idx_input_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.enca.idx_input = enca_idx_input_ctrl.SelectedIndex;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.errorCode = OP.setEncIdxInput(OP.enca.idx_input, 0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }
        // Enc B
        private void encb_idx_input_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.encb.idx_input = encb_idx_input_ctrl.SelectedIndex;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.errorCode = OP.setEncIdxInput(OP.encb.idx_input, 1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }



        // Encoders' decode mode control
        // Enc A
        private void enca_decode_mode_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.enca.decode_mode = enca_decode_mode_ctrl.SelectedIndex;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.errorCode = OP.setEncDecodeMode(OP.enca.decode_mode, 0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }
        // Enc B
        private void encb_decode_mode_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.encb.decode_mode = encb_decode_mode_ctrl.SelectedIndex;
            int set_value = OP.encb.decode_mode;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.errorCode = OP.setEncDecodeMode(OP.encb.decode_mode, 1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }

        // Encoders' filter control
        // Enc A
        private void enca_filter_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.enca.filter = (enca_filter_ctrl.SelectedIndex);

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.errorCode = OP.setEncFilter(OP.enca.filter, 0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }
        // Enc B
        private void encb_filter_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.encb.filter = (encb_filter_ctrl.SelectedIndex);

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.errorCode = OP.setEncFilter(OP.encb.filter, 1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }



        // Encoders' comparator (ON/OFF) control
        // Enc A
        private void enca_comparator_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.enca.comparator = enca_comparator_ctrl.SelectedIndex;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.errorCode = OP.setEncComparator(OP.enca.comparator, 0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }

        }
        // Enc B
        private void encb_comparator_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OP.encb.comparator = encb_comparator_ctrl.SelectedIndex;

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.errorCode = OP.setEncComparator(OP.encb.comparator, 1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }

        // Timers for testing purposes
        private void enc_results_timer_Tick(object sender, System.EventArgs e)
        {
            if (OP.enca.enable == 1)
            {
                enca_test.Text = numToMStr(op_wrp_GetEncoderPosit(0));
            }
            else
            {
                enca_test.Text = "Disabled";
            }
            if (OP.encb.enable == 1)
            {
                encb_test.Text = numToMStr(op_wrp_GetEncoderPosit(1));
            }
            else
            {
                encb_test.Text = "Disabled";
            }
        }

        // Encoder A reset button
        private void enca_reset_btn_Click(object sender, System.EventArgs e)
        {

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.resetEnc(0);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }


        // Encoder B reset button
        private void encb_reset_btn_Click(object sender, System.EventArgs e)
        {

            //Turn off the acquisistion
            if (measurementInProgress)
            {
                turnOffAcquisition();
            }

            OP.resetEnc(1);

            //Turn on the acquisistion
            if (measurementInProgress)
            {
                turnOnAcquisition();
            }
        }

        private void recreateExtDataArrays(double real_sampling_freq, double real_depth, int current_array_size)
        {

            // There, we calculate how many data points we will receive
            int new_array_size = (int)(real_depth * real_sampling_freq);

            // We switch data array size when we have or when we want to have less than opbox->plot.plot_data_size points for plotting
            if (!((new_array_size >= OP.plot.plot_data_size) && (current_array_size >= OP.plot.plot_data_size)))
            {
                if (new_array_size >= OP.plot.plot_data_size)
                {
                    System.Array.Resize(ref ext_plot_dataX, OP.plot.plot_data_size);
                    System.Array.Resize(ref ext_plot_dataY, OP.plot.plot_data_size);
                }
                else
                {
                    System.Array.Resize(ref ext_plot_dataX, OP.plot.window_in_smpls);
                    System.Array.Resize(ref ext_plot_dataY, OP.plot.window_in_smpls);
                }
            }
        }

        // Updates plot properties for X axis based on current delay / depth / sampling freq modification
        private void updatePlotXAxis(double min_x, double max_x)
        {
            main_chart.ChartAreas["main_area"].AxisX.Minimum = Math.Round(min_x * 10.0) / 10.0;
            main_chart.ChartAreas["main_area"].AxisX.Maximum = Math.Round(max_x * 10.0) / 10.0;
            main_chart.ChartAreas["main_area"].AxisX.Interval = Math.Round(10.0 * (max_x - min_x) / 20.0) / 10.0;
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
            OP.refreshPDArrays();
            OP.storePDRelativePositions();
        }

        private void findNearestPDPoint(int cursorPosXPx, int cursorPosYPx)
        {
            float[] distancesToPD = new float[6];

            // Distance to PDA points
            if (OP.pda.enable == 1)
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
            if (OP.pdb.enable == 1)
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
            if (OP.pdc.enable == 1)
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

        public void replaceNearestPDPoint()
        {

            switch (pd_selected)
            {
                case 0:
                    OP.pd.pd_posX1_plot[0] = (float)cursorPosX;
                    OP.pd.pd_posY_plot[0] = (float)cursorPosY;
                    break;
                case 1:
                    OP.pd.pd_posX2_plot[0] = (float)cursorPosX;
                    OP.pd.pd_posY_plot[0] = (float)cursorPosY;
                    break;
                case 2:
                    OP.pd.pd_posX1_plot[1] = (float)cursorPosX;
                    OP.pd.pd_posY_plot[1] = (float)cursorPosY;
                    break;
                case 3:
                    OP.pd.pd_posX2_plot[1] = (float)cursorPosX;
                    OP.pd.pd_posY_plot[1] = (float)cursorPosY;
                    break;
                case 4:
                    OP.pd.pd_posX1_plot[2] = (float)cursorPosX;
                    OP.pd.pd_posY_plot[2] = (float)cursorPosY;
                    break;
                case 5:
                    OP.pd.pd_posX2_plot[2] = (float)cursorPosX;
                    OP.pd.pd_posY_plot[2] = (float)cursorPosY;
                    break;
                default:
                    break;
            }
        }





        private void plot_algorithm_ctrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            plot_algorithm = plot_algorithm_ctrl.SelectedIndex;
            OP.plot.plot_algorithm = plot_algorithm_ctrl.SelectedIndex;
        }

        private void Sensor_MouseLeave(object sender, EventArgs e)
        {


        }

        private void Sensor_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Sensor_MouseUp(object sender, MouseEventArgs e)
        {


        }

        private void Sensor_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void main_chart_Click(object sender, EventArgs e)
        {

        }

        private void main_chart_MouseDown(object sender, MouseEventArgs e)
        {
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

        private void main_chart_MouseUp(object sender, MouseEventArgs e)
        {
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
            OP.convertPDToOpbox();
            OP.setPeakDetector(pd_selected / 2);

        }

        private void main_chart_MouseMove(object sender, MouseEventArgs e)
        {
            Point chartLocationOnForm = main_chart.FindForm().PointToClient(main_chart.Parent.PointToScreen(main_chart.Location));

            cursorPosXpx = e.X - chartLocationOnForm.X;
            cursorPosYpx = e.Y - chartLocationOnForm.Y;

            cursorPosX = (float)(main_chart.ChartAreas["main_area"].AxisX.PixelPositionToValue(cursorPosXpx));
            cursorPosY = (float)(main_chart.ChartAreas["main_area"].AxisY.PixelPositionToValue(cursorPosYpx));

            bool isOutOfBounds = false;

            if (cursorPosX > OP.plot.max_x)
            {
                cursorPosX = OP.plot.max_x;
                isOutOfBounds = true;
            }
            if (cursorPosX < OP.plot.min_x)
            {
                cursorPosX = OP.plot.min_x;
                isOutOfBounds = true;
            }
            if (cursorPosY > OP.plot.max_y)
            {
                cursorPosY = OP.plot.max_y;
                isOutOfBounds = true;
            }
            if (cursorPosY < OP.plot.min_y)
            {
                cursorPosY = OP.plot.min_y;
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

        private void main_chart_MouseLeave(object sender, EventArgs e)
        {
            pd_change = false;
            if (pd_disp_bgworker.IsBusy)
            {
                pd_disp_bgworker.CancelAsync();
            }
            main_chart.MouseMove -= new System.Windows.Forms.MouseEventHandler(main_chart_MouseMove);
            OP.convertPDToOpbox();
            if (pd_selected != -1)
            {
                OP.setPeakDetector(pd_selected / 2);
            }
            main_chart.MouseLeave -= new System.EventHandler(main_chart_MouseLeave);
            if (testing_enabled)
            {
                pd_txt.Text = numToMStr(pd_selected) + "Leave";
            }

        }

        private void plot_bgworker_DoWork_1(object sender, DoWorkEventArgs e)
        {

        }

        private void pda_peak_amplitude_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void pdb_peak_amplitude_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void pdc_peak_amplitude_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void pda_ref_position_ctrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void encb_comparator_ctrl_Click(object sender, EventArgs e)
        {

        }

        private void test_mode_btn_Click(object sender, EventArgs e)
        {
            if (testing_enabled)
            {

                testing_enabled = false;

                // Show the panel:
                this.test_panel.Enabled = false;
                this.test_panel.Visible = false;

                // Turn off Encoders' testers
                enc_results_timer.Enabled = false;

                // Switch appearance of our button:
                this.test_mode_btn.Text = "OFF";
                this.test_mode_btn.ForeColor = System.Drawing.Color.Black;
            }

            // What happens when we turn it ON:
            else
            {

                testing_enabled = true;

                // Hide the panel:
                this.test_panel.Enabled = true;
                this.test_panel.Visible = true;

                // Turn on Encoders' testers:
                if ((opbox.enca.enable == 1) || (opbox.encb.enable == 1))
                {
                    enc_results_timer.Enabled = true;
                }

                // Switch appearance of our button:
                this.test_mode_btn.Text = "ON";
                this.test_mode_btn.ForeColor = System.Drawing.Color.Yellow;

                // Refresh all parameters displayed by controls:
                window_test.Text = numToMStr(op_wrp_GetDepth()); // Display depth in samples
                delay_test.Text = numToMStr(op_wrp_GetDelay()); // Display delay in samples
                filter_test.Text = intToMStrHex(op_wrp_GetAnalog()); // Display register including filter bandtwidth, input source and gain
                ampl_test.Text = numToMStr(opbox.ampl.preamplifier); // Display value sent to OPBOX as amplitude level parameter
                source_test.Text = numToMStr(opbox.ampl.input_source); // Display value sent to OPBOX as input source
                amplitude_level_test.Text = numToMStr(opbox.puls.amplitude_level); // Display value sent to OPBOX as amplitude level
                if (opbox.enca.enable == 1)
                {
                    enca_test.Text = numToMStr(op_wrp_GetEncoderPosit(0)); // Display Encoder A position in samples
                }
                else
                {
                    enca_test.Text = "Disabled";
                }

                if (opbox.encb.enable == 1)
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
    }



    internal static class RandomNumbers
    {
        private static System.Random r;

        internal static int NextNumber()
        {
            if (r == null)
                Seed();

            return r.Next();
        }

        internal static int NextNumber(int ceiling)
        {
            if (r == null)
                Seed();

            return r.Next(ceiling);
        }

        internal static void Seed()
        {
            r = new System.Random();
        }

        internal static void Seed(int seed)
        {
            r = new System.Random(seed);
        }








    }


}
