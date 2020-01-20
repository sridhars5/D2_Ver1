namespace D2
{
    partial class Sensor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sensor));
            this.text_ampl_preamplifier = new System.Windows.Forms.TextBox();
            this.test_table = new System.Windows.Forms.TableLayoutPanel();
            this.txt_pd_test_title = new System.Windows.Forms.TextBox();
            this.txt_encb_test_title = new System.Windows.Forms.TextBox();
            this.txt_enca_test_title = new System.Windows.Forms.TextBox();
            this.amplitude_level_test = new System.Windows.Forms.Label();
            this.source_test = new System.Windows.Forms.Label();
            this.ampl_test = new System.Windows.Forms.Label();
            this.txt_analog_test_title = new System.Windows.Forms.TextBox();
            this.txt_ampl_test_title = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.filter_test = new System.Windows.Forms.Label();
            this.txt_depth_test_title = new System.Windows.Forms.TextBox();
            this.txt_ampl_lvl_test_title = new System.Windows.Forms.TextBox();
            this.enca_test = new System.Windows.Forms.Label();
            this.encb_test = new System.Windows.Forms.Label();
            this.txt_delay_test_title = new System.Windows.Forms.TextBox();
            this.pd_txt = new System.Windows.Forms.Label();
            this.delay_test = new System.Windows.Forms.Label();
            this.window_test = new System.Windows.Forms.Label();
            this.pda_test_detection = new System.Windows.Forms.Label();
            this.pdb_test_detection = new System.Windows.Forms.Label();
            this.pdc_test_detection = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.test_panel = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pdc_test_x2_plot = new System.Windows.Forms.Label();
            this.pdb_test_x2_plot = new System.Windows.Forms.Label();
            this.pda_test_x2_plot = new System.Windows.Forms.Label();
            this.pdc_test_x1_plot = new System.Windows.Forms.Label();
            this.pdb_test_x1_plot = new System.Windows.Forms.Label();
            this.pda_test_x1_plot = new System.Windows.Forms.Label();
            this.pdc_test_y_plot = new System.Windows.Forms.Label();
            this.pdb_test_y_plot = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.pda_test_y_plot = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pdc_test_max_opbox = new System.Windows.Forms.Label();
            this.pdb_test_max_opbox = new System.Windows.Forms.Label();
            this.pda_test_max_opbox = new System.Windows.Forms.Label();
            this.pdc_test_min_opbox = new System.Windows.Forms.Label();
            this.pdb_test_min_opbox = new System.Windows.Forms.Label();
            this.pda_test_min_opbox = new System.Windows.Forms.Label();
            this.pdc_test_level_opbox = new System.Windows.Forms.Label();
            this.pdb_test_level_opbox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.pda_test_level_opbox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.test_mode_txt = new System.Windows.Forms.TextBox();
            this.test_mode_btn = new System.Windows.Forms.Button();
            this.err_timer = new System.Windows.Forms.Timer(this.components);
            this.power_ctrl_timer = new System.Windows.Forms.Timer(this.components);
            this.enc_results_timer = new System.Windows.Forms.Timer(this.components);
            this.pd_results_timer = new System.Windows.Forms.Timer(this.components);
            this.data_bgworker = new System.ComponentModel.BackgroundWorker();
            this.pd_disp_bgworker = new System.ComponentModel.BackgroundWorker();
            this.fps_display = new System.Windows.Forms.TextBox();
            this.err_display = new System.Windows.Forms.TextBox();
            this.fps_txt = new System.Windows.Forms.TextBox();
            this.err_txt = new System.Windows.Forms.TextBox();
            this.pd_timer = new System.Windows.Forms.Timer(this.components);
            this.fps_timer = new System.Windows.Forms.Timer(this.components);
            this.plot_timer = new System.Windows.Forms.Timer(this.components);
            this.plot_bgworker = new System.ComponentModel.BackgroundWorker();
            this.info_disp_ctrl = new System.Windows.Forms.TextBox();
            this.enc_table = new System.Windows.Forms.TableLayoutPanel();
            this.reset_btn_txt = new System.Windows.Forms.TextBox();
            this.encb_reset_btn = new System.Windows.Forms.Button();
            this.encb_filter_ctrl = new System.Windows.Forms.ComboBox();
            this.encb_decode_mode_ctrl = new System.Windows.Forms.ComboBox();
            this.encb_idx_input_ctrl = new System.Windows.Forms.ComboBox();
            this.enca_filter_ctrl = new System.Windows.Forms.ComboBox();
            this.enca_decode_mode_ctrl = new System.Windows.Forms.ComboBox();
            this.enca_idx_input_ctrl = new System.Windows.Forms.ComboBox();
            this.encb_input_mode_ctrl = new System.Windows.Forms.ComboBox();
            this.text_enc_comparator = new System.Windows.Forms.TextBox();
            this.text_enc_comp_step = new System.Windows.Forms.TextBox();
            this.text_enc_filter = new System.Windows.Forms.TextBox();
            this.text_enc_decode_mode = new System.Windows.Forms.TextBox();
            this.text_enc_idx_input = new System.Windows.Forms.TextBox();
            this.text_enc_input_mode = new System.Windows.Forms.TextBox();
            this.enca_input_mode_ctrl = new System.Windows.Forms.ComboBox();
            this.enca_enable_ctrl = new System.Windows.Forms.CheckBox();
            this.encb_enable_ctrl = new System.Windows.Forms.CheckBox();
            this.enca_comparator_ctrl = new System.Windows.Forms.ComboBox();
            this.enca_comparator_step_ctrl = new System.Windows.Forms.TextBox();
            this.encb_comparator_ctrl = new System.Windows.Forms.ComboBox();
            this.encb_comparator_step_ctrl = new System.Windows.Forms.TextBox();
            this.enca_reset_btn = new System.Windows.Forms.Button();
            this.enc_groupbox = new System.Windows.Forms.GroupBox();
            this.text_ampl_input_source = new System.Windows.Forms.TextBox();
            this.text_ampl_gain = new System.Windows.Forms.TextBox();
            this.text_ampl_gain_unit = new System.Windows.Forms.TextBox();
            this.text_ampl_filter_bandtwidth = new System.Windows.Forms.TextBox();
            this.txt_plot_algorithm_title = new System.Windows.Forms.TextBox();
            this.text_acq_mode = new System.Windows.Forms.TextBox();
            this.text_acq_delay_unit = new System.Windows.Forms.TextBox();
            this.text_acq_delay = new System.Windows.Forms.TextBox();
            this.text_acq_window_unit = new System.Windows.Forms.TextBox();
            this.pdc_mode_ctrl = new System.Windows.Forms.ComboBox();
            this.pdc_peak_position_ctrl = new System.Windows.Forms.TextBox();
            this.trig_groupbox = new System.Windows.Forms.GroupBox();
            this.trig_table = new System.Windows.Forms.TableLayoutPanel();
            this.xy_divider_ctrl = new System.Windows.Forms.ComboBox();
            this.trigger_source_ctrl = new System.Windows.Forms.ComboBox();
            this.text_trig_trigger_source = new System.Windows.Forms.TextBox();
            this.text_trig_timer_period = new System.Windows.Forms.TextBox();
            this.text_trig_xy_divider = new System.Windows.Forms.TextBox();
            this.text_trig_timer_unit = new System.Windows.Forms.TextBox();
            this.timer_period_ctrl = new System.Windows.Forms.TextBox();
            this.pdb_mode_ctrl = new System.Windows.Forms.ComboBox();
            this.pdc_enable_ctrl = new System.Windows.Forms.CheckBox();
            this.pdb_peak_position_ctrl = new System.Windows.Forms.TextBox();
            this.pdb_enable_ctrl = new System.Windows.Forms.CheckBox();
            this.pda_peak_position_ctrl = new System.Windows.Forms.TextBox();
            this.pda_enable_ctrl = new System.Windows.Forms.CheckBox();
            this.pda_mode_ctrl = new System.Windows.Forms.ComboBox();
            this.sampling_freq_ctrl = new System.Windows.Forms.ComboBox();
            this.pdc_ref_position_ctrl = new System.Windows.Forms.TextBox();
            this.pda_ref_position_ctrl = new System.Windows.Forms.TextBox();
            this.pdc_peak_amplitude_ctrl = new System.Windows.Forms.TextBox();
            this.pdb_peak_amplitude_ctrl = new System.Windows.Forms.TextBox();
            this.pda_peak_amplitude_ctrl = new System.Windows.Forms.TextBox();
            this.text_pd_mode = new System.Windows.Forms.TextBox();
            this.text_pd_peak_pos = new System.Windows.Forms.TextBox();
            this.text_acq_sampling_freq = new System.Windows.Forms.TextBox();
            this.mode_ctrl = new System.Windows.Forms.ComboBox();
            this.window_ctrl = new System.Windows.Forms.TextBox();
            this.delay_ctrl = new System.Windows.Forms.TextBox();
            this.text_acq_sampling_freq_unit = new System.Windows.Forms.TextBox();
            this.text_acq_window = new System.Windows.Forms.TextBox();
            this.pdb_ref_position_ctrl = new System.Windows.Forms.TextBox();
            this.text_pd_peak_ampl = new System.Windows.Forms.TextBox();
            this.acq_groupbox = new System.Windows.Forms.GroupBox();
            this.acq_table = new System.Windows.Forms.TableLayoutPanel();
            this.plot_algorithm_ctrl = new System.Windows.Forms.ComboBox();
            this.pd_groupbox = new System.Windows.Forms.GroupBox();
            this.pd_table = new System.Windows.Forms.TableLayoutPanel();
            this.text_pd_ref_pos = new System.Windows.Forms.TextBox();
            this.text_pd_results = new System.Windows.Forms.TextBox();
            this.ampl_groupbox = new System.Windows.Forms.GroupBox();
            this.ampl_table = new System.Windows.Forms.TableLayoutPanel();
            this.gain_mode_ctrl = new System.Windows.Forms.ComboBox();
            this.text_ampl_filter_bandtwidth_unit = new System.Windows.Forms.TextBox();
            this.input_source_ctrl = new System.Windows.Forms.ComboBox();
            this.preamplifier_ctrl = new System.Windows.Forms.ComboBox();
            this.filter_bandtwidth_ctrl = new System.Windows.Forms.ComboBox();
            this.gain_ctrl = new System.Windows.Forms.TextBox();
            this.text_ampl_gain_mode = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.main_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.puls_groupbox = new System.Windows.Forms.GroupBox();
            this.puls_table = new System.Windows.Forms.TableLayoutPanel();
            this.charging_time_ctrl = new System.Windows.Forms.TextBox();
            this.amplitude_level_ctrl = new System.Windows.Forms.ComboBox();
            this.text_puls_amplitude_level = new System.Windows.Forms.TextBox();
            this.text_puls_charging_time = new System.Windows.Forms.TextBox();
            this.text_puls_charging_time_unit = new System.Windows.Forms.TextBox();
            this.pict_logo = new System.Windows.Forms.PictureBox();
            this.test_table.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.test_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.enc_table.SuspendLayout();
            this.enc_groupbox.SuspendLayout();
            this.trig_groupbox.SuspendLayout();
            this.trig_table.SuspendLayout();
            this.acq_groupbox.SuspendLayout();
            this.acq_table.SuspendLayout();
            this.pd_groupbox.SuspendLayout();
            this.pd_table.SuspendLayout();
            this.ampl_groupbox.SuspendLayout();
            this.ampl_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_chart)).BeginInit();
            this.puls_groupbox.SuspendLayout();
            this.puls_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // text_ampl_preamplifier
            // 
            this.text_ampl_preamplifier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_ampl_preamplifier.BackColor = System.Drawing.Color.SteelBlue;
            this.text_ampl_preamplifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ampl_preamplifier.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_ampl_preamplifier.ForeColor = System.Drawing.Color.White;
            this.text_ampl_preamplifier.Location = new System.Drawing.Point(4, 53);
            this.text_ampl_preamplifier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_ampl_preamplifier.Name = "text_ampl_preamplifier";
            this.text_ampl_preamplifier.ReadOnly = true;
            this.text_ampl_preamplifier.Size = new System.Drawing.Size(115, 14);
            this.text_ampl_preamplifier.TabIndex = 2;
            this.text_ampl_preamplifier.Text = "Pre-amplifier";
            this.text_ampl_preamplifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // test_table
            // 
            this.test_table.AutoSize = true;
            this.test_table.ColumnCount = 2;
            this.test_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.test_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.test_table.Controls.Add(this.txt_pd_test_title, 0, 8);
            this.test_table.Controls.Add(this.txt_encb_test_title, 0, 7);
            this.test_table.Controls.Add(this.txt_enca_test_title, 0, 6);
            this.test_table.Controls.Add(this.amplitude_level_test, 1, 5);
            this.test_table.Controls.Add(this.source_test, 1, 4);
            this.test_table.Controls.Add(this.ampl_test, 1, 3);
            this.test_table.Controls.Add(this.txt_analog_test_title, 0, 2);
            this.test_table.Controls.Add(this.txt_ampl_test_title, 0, 3);
            this.test_table.Controls.Add(this.textBox5, 0, 4);
            this.test_table.Controls.Add(this.filter_test, 1, 2);
            this.test_table.Controls.Add(this.txt_depth_test_title, 0, 0);
            this.test_table.Controls.Add(this.txt_ampl_lvl_test_title, 0, 5);
            this.test_table.Controls.Add(this.enca_test, 1, 6);
            this.test_table.Controls.Add(this.encb_test, 1, 7);
            this.test_table.Controls.Add(this.txt_delay_test_title, 0, 1);
            this.test_table.Controls.Add(this.pd_txt, 1, 8);
            this.test_table.Controls.Add(this.delay_test, 1, 1);
            this.test_table.Controls.Add(this.window_test, 1, 0);
            this.test_table.Location = new System.Drawing.Point(10, 23);
            this.test_table.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.test_table.Name = "test_table";
            this.test_table.RowCount = 9;
            this.test_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.test_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.test_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.test_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.test_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.test_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.test_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.test_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.test_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.test_table.Size = new System.Drawing.Size(265, 180);
            this.test_table.TabIndex = 0;
            // 
            // txt_pd_test_title
            // 
            this.txt_pd_test_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_pd_test_title.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_pd_test_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pd_test_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_pd_test_title.ForeColor = System.Drawing.Color.White;
            this.txt_pd_test_title.Location = new System.Drawing.Point(4, 163);
            this.txt_pd_test_title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_pd_test_title.Name = "txt_pd_test_title";
            this.txt_pd_test_title.ReadOnly = true;
            this.txt_pd_test_title.Size = new System.Drawing.Size(116, 14);
            this.txt_pd_test_title.TabIndex = 26;
            this.txt_pd_test_title.Text = "PD selection";
            this.txt_pd_test_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_encb_test_title
            // 
            this.txt_encb_test_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_encb_test_title.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_encb_test_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_encb_test_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_encb_test_title.ForeColor = System.Drawing.Color.White;
            this.txt_encb_test_title.Location = new System.Drawing.Point(4, 143);
            this.txt_encb_test_title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_encb_test_title.Name = "txt_encb_test_title";
            this.txt_encb_test_title.ReadOnly = true;
            this.txt_encb_test_title.Size = new System.Drawing.Size(116, 14);
            this.txt_encb_test_title.TabIndex = 25;
            this.txt_encb_test_title.Text = "Enc B pos.";
            this.txt_encb_test_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_enca_test_title
            // 
            this.txt_enca_test_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_enca_test_title.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_enca_test_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_enca_test_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_enca_test_title.ForeColor = System.Drawing.Color.White;
            this.txt_enca_test_title.Location = new System.Drawing.Point(4, 123);
            this.txt_enca_test_title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_enca_test_title.Name = "txt_enca_test_title";
            this.txt_enca_test_title.ReadOnly = true;
            this.txt_enca_test_title.Size = new System.Drawing.Size(116, 14);
            this.txt_enca_test_title.TabIndex = 24;
            this.txt_enca_test_title.Text = "Enc A pos.";
            this.txt_enca_test_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amplitude_level_test
            // 
            this.amplitude_level_test.AutoSize = true;
            this.amplitude_level_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amplitude_level_test.Location = new System.Drawing.Point(136, 100);
            this.amplitude_level_test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amplitude_level_test.Name = "amplitude_level_test";
            this.amplitude_level_test.Size = new System.Drawing.Size(104, 17);
            this.amplitude_level_test.TabIndex = 17;
            this.amplitude_level_test.Text = "Ampl_lvl_test";
            // 
            // source_test
            // 
            this.source_test.AutoSize = true;
            this.source_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.source_test.Location = new System.Drawing.Point(136, 80);
            this.source_test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.source_test.Name = "source_test";
            this.source_test.Size = new System.Drawing.Size(95, 17);
            this.source_test.TabIndex = 17;
            this.source_test.Text = "Source_test";
            // 
            // ampl_test
            // 
            this.ampl_test.AutoSize = true;
            this.ampl_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ampl_test.Location = new System.Drawing.Point(136, 60);
            this.ampl_test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ampl_test.Name = "ampl_test";
            this.ampl_test.Size = new System.Drawing.Size(79, 17);
            this.ampl_test.TabIndex = 19;
            this.ampl_test.Text = "Ampl_test";
            // 
            // txt_analog_test_title
            // 
            this.txt_analog_test_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_analog_test_title.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_analog_test_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_analog_test_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_analog_test_title.ForeColor = System.Drawing.Color.White;
            this.txt_analog_test_title.Location = new System.Drawing.Point(4, 43);
            this.txt_analog_test_title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_analog_test_title.Name = "txt_analog_test_title";
            this.txt_analog_test_title.ReadOnly = true;
            this.txt_analog_test_title.Size = new System.Drawing.Size(116, 14);
            this.txt_analog_test_title.TabIndex = 12;
            this.txt_analog_test_title.Text = "Analog register";
            this.txt_analog_test_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ampl_test_title
            // 
            this.txt_ampl_test_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ampl_test_title.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_ampl_test_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ampl_test_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_ampl_test_title.ForeColor = System.Drawing.Color.White;
            this.txt_ampl_test_title.Location = new System.Drawing.Point(4, 63);
            this.txt_ampl_test_title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ampl_test_title.Name = "txt_ampl_test_title";
            this.txt_ampl_test_title.ReadOnly = true;
            this.txt_ampl_test_title.Size = new System.Drawing.Size(116, 14);
            this.txt_ampl_test_title.TabIndex = 21;
            this.txt_ampl_test_title.Text = "Pre-ampl";
            this.txt_ampl_test_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(4, 83);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(116, 14);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "Input source";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // filter_test
            // 
            this.filter_test.AutoSize = true;
            this.filter_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filter_test.Location = new System.Drawing.Point(136, 40);
            this.filter_test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filter_test.Name = "filter_test";
            this.filter_test.Size = new System.Drawing.Size(81, 17);
            this.filter_test.TabIndex = 18;
            this.filter_test.Text = "Filter_test";
            // 
            // txt_depth_test_title
            // 
            this.txt_depth_test_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_depth_test_title.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_depth_test_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_depth_test_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_depth_test_title.ForeColor = System.Drawing.Color.White;
            this.txt_depth_test_title.Location = new System.Drawing.Point(4, 3);
            this.txt_depth_test_title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_depth_test_title.Name = "txt_depth_test_title";
            this.txt_depth_test_title.ReadOnly = true;
            this.txt_depth_test_title.Size = new System.Drawing.Size(116, 14);
            this.txt_depth_test_title.TabIndex = 1;
            this.txt_depth_test_title.Text = "Depth";
            this.txt_depth_test_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ampl_lvl_test_title
            // 
            this.txt_ampl_lvl_test_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ampl_lvl_test_title.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_ampl_lvl_test_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ampl_lvl_test_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_ampl_lvl_test_title.ForeColor = System.Drawing.Color.White;
            this.txt_ampl_lvl_test_title.Location = new System.Drawing.Point(4, 103);
            this.txt_ampl_lvl_test_title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ampl_lvl_test_title.Name = "txt_ampl_lvl_test_title";
            this.txt_ampl_lvl_test_title.ReadOnly = true;
            this.txt_ampl_lvl_test_title.Size = new System.Drawing.Size(116, 14);
            this.txt_ampl_lvl_test_title.TabIndex = 23;
            this.txt_ampl_lvl_test_title.Text = "Ampl level";
            this.txt_ampl_lvl_test_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // enca_test
            // 
            this.enca_test.AutoSize = true;
            this.enca_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enca_test.Location = new System.Drawing.Point(136, 120);
            this.enca_test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enca_test.Name = "enca_test";
            this.enca_test.Size = new System.Drawing.Size(79, 17);
            this.enca_test.TabIndex = 22;
            this.enca_test.Text = "enca_test";
            // 
            // encb_test
            // 
            this.encb_test.AutoSize = true;
            this.encb_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encb_test.Location = new System.Drawing.Point(136, 140);
            this.encb_test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encb_test.Name = "encb_test";
            this.encb_test.Size = new System.Drawing.Size(79, 17);
            this.encb_test.TabIndex = 23;
            this.encb_test.Text = "encb_test";
            // 
            // txt_delay_test_title
            // 
            this.txt_delay_test_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_delay_test_title.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_delay_test_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_delay_test_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_delay_test_title.ForeColor = System.Drawing.Color.White;
            this.txt_delay_test_title.Location = new System.Drawing.Point(4, 23);
            this.txt_delay_test_title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_delay_test_title.Name = "txt_delay_test_title";
            this.txt_delay_test_title.ReadOnly = true;
            this.txt_delay_test_title.Size = new System.Drawing.Size(116, 14);
            this.txt_delay_test_title.TabIndex = 2;
            this.txt_delay_test_title.Text = "Delay";
            this.txt_delay_test_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pd_txt
            // 
            this.pd_txt.AutoSize = true;
            this.pd_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pd_txt.Location = new System.Drawing.Point(136, 160);
            this.pd_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pd_txt.Name = "pd_txt";
            this.pd_txt.Size = new System.Drawing.Size(59, 17);
            this.pd_txt.TabIndex = 21;
            this.pd_txt.Text = "START";
            // 
            // delay_test
            // 
            this.delay_test.AutoSize = true;
            this.delay_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delay_test.Location = new System.Drawing.Point(136, 20);
            this.delay_test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delay_test.Name = "delay_test";
            this.delay_test.Size = new System.Drawing.Size(85, 17);
            this.delay_test.TabIndex = 19;
            this.delay_test.Text = "Delay_test";
            // 
            // window_test
            // 
            this.window_test.AutoSize = true;
            this.window_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.window_test.Location = new System.Drawing.Point(136, 0);
            this.window_test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.window_test.Name = "window_test";
            this.window_test.Size = new System.Drawing.Size(99, 17);
            this.window_test.TabIndex = 20;
            this.window_test.Text = "Window_test";
            // 
            // pda_test_detection
            // 
            this.pda_test_detection.AutoSize = true;
            this.pda_test_detection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_test_detection.Location = new System.Drawing.Point(4, 0);
            this.pda_test_detection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pda_test_detection.Name = "pda_test_detection";
            this.pda_test_detection.Size = new System.Drawing.Size(25, 13);
            this.pda_test_detection.TabIndex = 29;
            this.pda_test_detection.Text = "NO";
            // 
            // pdb_test_detection
            // 
            this.pdb_test_detection.AutoSize = true;
            this.pdb_test_detection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_test_detection.Location = new System.Drawing.Point(74, 0);
            this.pdb_test_detection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdb_test_detection.Name = "pdb_test_detection";
            this.pdb_test_detection.Size = new System.Drawing.Size(25, 13);
            this.pdb_test_detection.TabIndex = 30;
            this.pdb_test_detection.Text = "NO";
            // 
            // pdc_test_detection
            // 
            this.pdc_test_detection.AutoSize = true;
            this.pdc_test_detection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_test_detection.Location = new System.Drawing.Point(144, 0);
            this.pdc_test_detection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdc_test_detection.Name = "pdc_test_detection";
            this.pdc_test_detection.Size = new System.Drawing.Size(25, 13);
            this.pdc_test_detection.TabIndex = 31;
            this.pdc_test_detection.Text = "NO";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.Controls.Add(this.pda_test_detection, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pdb_test_detection, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pdc_test_detection, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 390);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(216, 24);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // test_panel
            // 
            this.test_panel.BackColor = System.Drawing.Color.White;
            this.test_panel.Controls.Add(this.tableLayoutPanel3);
            this.test_panel.Controls.Add(this.test_table);
            this.test_panel.Controls.Add(this.label21);
            this.test_panel.Controls.Add(this.tableLayoutPanel1);
            this.test_panel.Controls.Add(this.label20);
            this.test_panel.Controls.Add(this.tableLayoutPanel2);
            this.test_panel.Controls.Add(this.label1);
            this.test_panel.Enabled = false;
            this.test_panel.ForeColor = System.Drawing.Color.Black;
            this.test_panel.Location = new System.Drawing.Point(732, 10);
            this.test_panel.Name = "test_panel";
            this.test_panel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.test_panel.Size = new System.Drawing.Size(293, 439);
            this.test_panel.TabIndex = 39;
            this.test_panel.TabStop = false;
            this.test_panel.Text = "Test parameters";
            this.test_panel.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(6, 370);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(162, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Peak Detectors - Detection";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.pdc_test_x2_plot, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pdb_test_x2_plot, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pda_test_x2_plot, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pdc_test_x1_plot, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pdb_test_x1_plot, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pda_test_x1_plot, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pdc_test_y_plot, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pdb_test_y_plot, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pda_test_y_plot, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 229);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 60);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // pdc_test_x2_plot
            // 
            this.pdc_test_x2_plot.AutoSize = true;
            this.pdc_test_x2_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_test_x2_plot.Location = new System.Drawing.Point(190, 40);
            this.pdc_test_x2_plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdc_test_x2_plot.Name = "pdc_test_x2_plot";
            this.pdc_test_x2_plot.Size = new System.Drawing.Size(20, 13);
            this.pdc_test_x2_plot.TabIndex = 24;
            this.pdc_test_x2_plot.Text = "x2";
            // 
            // pdb_test_x2_plot
            // 
            this.pdb_test_x2_plot.AutoSize = true;
            this.pdb_test_x2_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_test_x2_plot.Location = new System.Drawing.Point(190, 20);
            this.pdb_test_x2_plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdb_test_x2_plot.Name = "pdb_test_x2_plot";
            this.pdb_test_x2_plot.Size = new System.Drawing.Size(20, 13);
            this.pdb_test_x2_plot.TabIndex = 25;
            this.pdb_test_x2_plot.Text = "x2";
            // 
            // pda_test_x2_plot
            // 
            this.pda_test_x2_plot.AutoSize = true;
            this.pda_test_x2_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_test_x2_plot.Location = new System.Drawing.Point(190, 0);
            this.pda_test_x2_plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pda_test_x2_plot.Name = "pda_test_x2_plot";
            this.pda_test_x2_plot.Size = new System.Drawing.Size(20, 13);
            this.pda_test_x2_plot.TabIndex = 26;
            this.pda_test_x2_plot.Text = "x2";
            // 
            // pdc_test_x1_plot
            // 
            this.pdc_test_x1_plot.AutoSize = true;
            this.pdc_test_x1_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_test_x1_plot.Location = new System.Drawing.Point(120, 40);
            this.pdc_test_x1_plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdc_test_x1_plot.Name = "pdc_test_x1_plot";
            this.pdc_test_x1_plot.Size = new System.Drawing.Size(20, 13);
            this.pdc_test_x1_plot.TabIndex = 27;
            this.pdc_test_x1_plot.Text = "x1";
            // 
            // pdb_test_x1_plot
            // 
            this.pdb_test_x1_plot.AutoSize = true;
            this.pdb_test_x1_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_test_x1_plot.Location = new System.Drawing.Point(120, 20);
            this.pdb_test_x1_plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdb_test_x1_plot.Name = "pdb_test_x1_plot";
            this.pdb_test_x1_plot.Size = new System.Drawing.Size(20, 13);
            this.pdb_test_x1_plot.TabIndex = 28;
            this.pdb_test_x1_plot.Text = "x1";
            // 
            // pda_test_x1_plot
            // 
            this.pda_test_x1_plot.AutoSize = true;
            this.pda_test_x1_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_test_x1_plot.Location = new System.Drawing.Point(120, 0);
            this.pda_test_x1_plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pda_test_x1_plot.Name = "pda_test_x1_plot";
            this.pda_test_x1_plot.Size = new System.Drawing.Size(20, 13);
            this.pda_test_x1_plot.TabIndex = 29;
            this.pda_test_x1_plot.Text = "x1";
            // 
            // pdc_test_y_plot
            // 
            this.pdc_test_y_plot.AutoSize = true;
            this.pdc_test_y_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_test_y_plot.Location = new System.Drawing.Point(50, 40);
            this.pdc_test_y_plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdc_test_y_plot.Name = "pdc_test_y_plot";
            this.pdc_test_y_plot.Size = new System.Drawing.Size(13, 13);
            this.pdc_test_y_plot.TabIndex = 30;
            this.pdc_test_y_plot.Text = "y";
            // 
            // pdb_test_y_plot
            // 
            this.pdb_test_y_plot.AutoSize = true;
            this.pdb_test_y_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_test_y_plot.Location = new System.Drawing.Point(50, 20);
            this.pdb_test_y_plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdb_test_y_plot.Name = "pdb_test_y_plot";
            this.pdb_test_y_plot.Size = new System.Drawing.Size(13, 13);
            this.pdb_test_y_plot.TabIndex = 31;
            this.pdb_test_y_plot.Text = "y";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(4, 23);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(38, 14);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "PD B";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox6.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(4, 43);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(38, 14);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "PD C";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox11.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(4, 3);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(38, 14);
            this.textBox11.TabIndex = 2;
            this.textBox11.Text = "PD A";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pda_test_y_plot
            // 
            this.pda_test_y_plot.AutoSize = true;
            this.pda_test_y_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_test_y_plot.Location = new System.Drawing.Point(50, 0);
            this.pda_test_y_plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pda_test_y_plot.Name = "pda_test_y_plot";
            this.pda_test_y_plot.Size = new System.Drawing.Size(13, 13);
            this.pda_test_y_plot.TabIndex = 21;
            this.pda_test_y_plot.Text = "y";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(6, 292);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Peak Detectors - Opbox";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Controls.Add(this.pdc_test_max_opbox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.pdb_test_max_opbox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.pda_test_max_opbox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pdc_test_min_opbox, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.pdb_test_min_opbox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pda_test_min_opbox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pdc_test_level_opbox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.pdb_test_level_opbox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pda_test_level_opbox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 307);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(256, 60);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // pdc_test_max_opbox
            // 
            this.pdc_test_max_opbox.AutoSize = true;
            this.pdc_test_max_opbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_test_max_opbox.Location = new System.Drawing.Point(190, 40);
            this.pdc_test_max_opbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdc_test_max_opbox.Name = "pdc_test_max_opbox";
            this.pdc_test_max_opbox.Size = new System.Drawing.Size(29, 13);
            this.pdc_test_max_opbox.TabIndex = 24;
            this.pdc_test_max_opbox.Text = "max";
            // 
            // pdb_test_max_opbox
            // 
            this.pdb_test_max_opbox.AutoSize = true;
            this.pdb_test_max_opbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_test_max_opbox.Location = new System.Drawing.Point(190, 20);
            this.pdb_test_max_opbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdb_test_max_opbox.Name = "pdb_test_max_opbox";
            this.pdb_test_max_opbox.Size = new System.Drawing.Size(29, 13);
            this.pdb_test_max_opbox.TabIndex = 25;
            this.pdb_test_max_opbox.Text = "max";
            // 
            // pda_test_max_opbox
            // 
            this.pda_test_max_opbox.AutoSize = true;
            this.pda_test_max_opbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_test_max_opbox.Location = new System.Drawing.Point(190, 0);
            this.pda_test_max_opbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pda_test_max_opbox.Name = "pda_test_max_opbox";
            this.pda_test_max_opbox.Size = new System.Drawing.Size(29, 13);
            this.pda_test_max_opbox.TabIndex = 26;
            this.pda_test_max_opbox.Text = "max";
            // 
            // pdc_test_min_opbox
            // 
            this.pdc_test_min_opbox.AutoSize = true;
            this.pdc_test_min_opbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_test_min_opbox.Location = new System.Drawing.Point(120, 40);
            this.pdc_test_min_opbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdc_test_min_opbox.Name = "pdc_test_min_opbox";
            this.pdc_test_min_opbox.Size = new System.Drawing.Size(26, 13);
            this.pdc_test_min_opbox.TabIndex = 27;
            this.pdc_test_min_opbox.Text = "min";
            // 
            // pdb_test_min_opbox
            // 
            this.pdb_test_min_opbox.AutoSize = true;
            this.pdb_test_min_opbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_test_min_opbox.Location = new System.Drawing.Point(120, 20);
            this.pdb_test_min_opbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdb_test_min_opbox.Name = "pdb_test_min_opbox";
            this.pdb_test_min_opbox.Size = new System.Drawing.Size(26, 13);
            this.pdb_test_min_opbox.TabIndex = 28;
            this.pdb_test_min_opbox.Text = "min";
            // 
            // pda_test_min_opbox
            // 
            this.pda_test_min_opbox.AutoSize = true;
            this.pda_test_min_opbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_test_min_opbox.Location = new System.Drawing.Point(120, 0);
            this.pda_test_min_opbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pda_test_min_opbox.Name = "pda_test_min_opbox";
            this.pda_test_min_opbox.Size = new System.Drawing.Size(26, 13);
            this.pda_test_min_opbox.TabIndex = 29;
            this.pda_test_min_opbox.Text = "min";
            // 
            // pdc_test_level_opbox
            // 
            this.pdc_test_level_opbox.AutoSize = true;
            this.pdc_test_level_opbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_test_level_opbox.Location = new System.Drawing.Point(50, 40);
            this.pdc_test_level_opbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdc_test_level_opbox.Name = "pdc_test_level_opbox";
            this.pdc_test_level_opbox.Size = new System.Drawing.Size(34, 13);
            this.pdc_test_level_opbox.TabIndex = 30;
            this.pdc_test_level_opbox.Text = "level";
            // 
            // pdb_test_level_opbox
            // 
            this.pdb_test_level_opbox.AutoSize = true;
            this.pdb_test_level_opbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_test_level_opbox.Location = new System.Drawing.Point(50, 20);
            this.pdb_test_level_opbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pdb_test_level_opbox.Name = "pdb_test_level_opbox";
            this.pdb_test_level_opbox.Size = new System.Drawing.Size(34, 13);
            this.pdb_test_level_opbox.TabIndex = 31;
            this.pdb_test_level_opbox.Text = "level";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(4, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(38, 14);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "PD B";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox8.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(4, 43);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(38, 14);
            this.textBox8.TabIndex = 21;
            this.textBox8.Text = "PD C";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox10.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(4, 3);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(38, 14);
            this.textBox10.TabIndex = 2;
            this.textBox10.Text = "PD A";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pda_test_level_opbox
            // 
            this.pda_test_level_opbox.AutoSize = true;
            this.pda_test_level_opbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_test_level_opbox.Location = new System.Drawing.Point(50, 0);
            this.pda_test_level_opbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pda_test_level_opbox.Name = "pda_test_level_opbox";
            this.pda_test_level_opbox.Size = new System.Drawing.Size(34, 13);
            this.pda_test_level_opbox.TabIndex = 21;
            this.pda_test_level_opbox.Text = "level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Peak Detectors - Plot";
            // 
            // test_mode_txt
            // 
            this.test_mode_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.test_mode_txt.BackColor = System.Drawing.Color.SteelBlue;
            this.test_mode_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.test_mode_txt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.test_mode_txt.ForeColor = System.Drawing.Color.White;
            this.test_mode_txt.Location = new System.Drawing.Point(606, 674);
            this.test_mode_txt.Multiline = true;
            this.test_mode_txt.Name = "test_mode_txt";
            this.test_mode_txt.ReadOnly = true;
            this.test_mode_txt.Size = new System.Drawing.Size(59, 32);
            this.test_mode_txt.TabIndex = 38;
            this.test_mode_txt.Text = "Test mode";
            this.test_mode_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.test_mode_txt.Click += new System.EventHandler(this.test_mode_txt_Click);
            this.test_mode_txt.TextChanged += new System.EventHandler(this.test_mode_txt_TextChanged);
            // 
            // test_mode_btn
            // 
            this.test_mode_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.test_mode_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.test_mode_btn.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.test_mode_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.test_mode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test_mode_btn.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.test_mode_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.test_mode_btn.Location = new System.Drawing.Point(606, 708);
            this.test_mode_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.test_mode_btn.Name = "test_mode_btn";
            this.test_mode_btn.Size = new System.Drawing.Size(57, 40);
            this.test_mode_btn.TabIndex = 37;
            this.test_mode_btn.Text = "OFF";
            this.test_mode_btn.UseVisualStyleBackColor = false;
            this.test_mode_btn.Click += new System.EventHandler(this.test_mode_btn_Click);
            // 
            // err_timer
            // 
            this.err_timer.Enabled = true;
            this.err_timer.Interval = 1000;
            this.err_timer.Tick += new System.EventHandler(this.err_timer_Tick);
            // 
            // power_ctrl_timer
            // 
            this.power_ctrl_timer.Interval = 500;
            this.power_ctrl_timer.Tick += new System.EventHandler(this.power_ctrl_timer_Tick);
            // 
            // enc_results_timer
            // 
            this.enc_results_timer.Enabled = true;
            this.enc_results_timer.Interval = 250;
            this.enc_results_timer.Tick += new System.EventHandler(this.enc_results_timer_Tick);
            // 
            // pd_results_timer
            // 
            this.pd_results_timer.Interval = 500;
            this.pd_results_timer.Tick += new System.EventHandler(this.pd_results_timer_Tick);
            // 
            // data_bgworker
            // 
            this.data_bgworker.WorkerSupportsCancellation = true;
            this.data_bgworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.data_bgworker_DoWork);
            // 
            // pd_disp_bgworker
            // 
            this.pd_disp_bgworker.WorkerSupportsCancellation = true;
            this.pd_disp_bgworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.pd_disp_bgworker_DoWork);
            // 
            // fps_display
            // 
            this.fps_display.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fps_display.BackColor = System.Drawing.Color.SteelBlue;
            this.fps_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fps_display.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fps_display.ForeColor = System.Drawing.Color.White;
            this.fps_display.Location = new System.Drawing.Point(1151, 724);
            this.fps_display.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fps_display.Name = "fps_display";
            this.fps_display.ReadOnly = true;
            this.fps_display.Size = new System.Drawing.Size(52, 20);
            this.fps_display.TabIndex = 36;
            this.fps_display.Text = "0";
            // 
            // err_display
            // 
            this.err_display.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.err_display.BackColor = System.Drawing.Color.SteelBlue;
            this.err_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.err_display.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.err_display.ForeColor = System.Drawing.Color.White;
            this.err_display.Location = new System.Drawing.Point(1067, 723);
            this.err_display.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.err_display.Name = "err_display";
            this.err_display.ReadOnly = true;
            this.err_display.Size = new System.Drawing.Size(35, 20);
            this.err_display.TabIndex = 35;
            this.err_display.Text = "0";
            // 
            // fps_txt
            // 
            this.fps_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fps_txt.BackColor = System.Drawing.Color.SteelBlue;
            this.fps_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fps_txt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fps_txt.ForeColor = System.Drawing.Color.White;
            this.fps_txt.Location = new System.Drawing.Point(1109, 726);
            this.fps_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fps_txt.Name = "fps_txt";
            this.fps_txt.ReadOnly = true;
            this.fps_txt.Size = new System.Drawing.Size(35, 14);
            this.fps_txt.TabIndex = 34;
            this.fps_txt.Text = "FPS:";
            this.fps_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // err_txt
            // 
            this.err_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.err_txt.BackColor = System.Drawing.Color.SteelBlue;
            this.err_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.err_txt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.err_txt.ForeColor = System.Drawing.Color.White;
            this.err_txt.Location = new System.Drawing.Point(1025, 726);
            this.err_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.err_txt.Name = "err_txt";
            this.err_txt.ReadOnly = true;
            this.err_txt.Size = new System.Drawing.Size(35, 14);
            this.err_txt.TabIndex = 33;
            this.err_txt.Text = "ERR:";
            this.err_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pd_timer
            // 
            this.pd_timer.Enabled = true;
            this.pd_timer.Interval = 25;
            this.pd_timer.Tick += new System.EventHandler(this.pd_timer_Tick);
            // 
            // fps_timer
            // 
            this.fps_timer.Enabled = true;
            this.fps_timer.Interval = 1000;
            this.fps_timer.Tick += new System.EventHandler(this.fps_timer_Tick);
            // 
            // plot_timer
            // 
            this.plot_timer.Interval = 30;
            this.plot_timer.Tick += new System.EventHandler(this.plot_timer_Tick);
            // 
            // plot_bgworker
            // 
            this.plot_bgworker.WorkerSupportsCancellation = true;
            this.plot_bgworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.plot_bgworker_DoWork);
            // 
            // info_disp_ctrl
            // 
            this.info_disp_ctrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.info_disp_ctrl.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_disp_ctrl.Location = new System.Drawing.Point(1210, 726);
            this.info_disp_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.info_disp_ctrl.MaxLength = 32;
            this.info_disp_ctrl.Name = "info_disp_ctrl";
            this.info_disp_ctrl.ReadOnly = true;
            this.info_disp_ctrl.Size = new System.Drawing.Size(138, 18);
            this.info_disp_ctrl.TabIndex = 32;
            // 
            // enc_table
            // 
            this.enc_table.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.enc_table.BackColor = System.Drawing.Color.Transparent;
            this.enc_table.ColumnCount = 3;
            this.enc_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.enc_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.enc_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.enc_table.Controls.Add(this.reset_btn_txt, 0, 7);
            this.enc_table.Controls.Add(this.encb_reset_btn, 2, 7);
            this.enc_table.Controls.Add(this.encb_filter_ctrl, 2, 4);
            this.enc_table.Controls.Add(this.encb_decode_mode_ctrl, 2, 3);
            this.enc_table.Controls.Add(this.encb_idx_input_ctrl, 2, 2);
            this.enc_table.Controls.Add(this.enca_filter_ctrl, 1, 4);
            this.enc_table.Controls.Add(this.enca_decode_mode_ctrl, 1, 3);
            this.enc_table.Controls.Add(this.enca_idx_input_ctrl, 1, 2);
            this.enc_table.Controls.Add(this.encb_input_mode_ctrl, 2, 1);
            this.enc_table.Controls.Add(this.text_enc_comparator, 0, 6);
            this.enc_table.Controls.Add(this.text_enc_comp_step, 0, 5);
            this.enc_table.Controls.Add(this.text_enc_filter, 0, 4);
            this.enc_table.Controls.Add(this.text_enc_decode_mode, 0, 3);
            this.enc_table.Controls.Add(this.text_enc_idx_input, 0, 2);
            this.enc_table.Controls.Add(this.text_enc_input_mode, 0, 1);
            this.enc_table.Controls.Add(this.enca_input_mode_ctrl, 1, 1);
            this.enc_table.Controls.Add(this.enca_enable_ctrl, 1, 0);
            this.enc_table.Controls.Add(this.encb_enable_ctrl, 2, 0);
            this.enc_table.Controls.Add(this.enca_comparator_ctrl, 1, 6);
            this.enc_table.Controls.Add(this.enca_comparator_step_ctrl, 1, 5);
            this.enc_table.Controls.Add(this.encb_comparator_ctrl, 2, 6);
            this.enc_table.Controls.Add(this.encb_comparator_step_ctrl, 2, 5);
            this.enc_table.Controls.Add(this.enca_reset_btn, 1, 7);
            this.enc_table.Location = new System.Drawing.Point(8, 15);
            this.enc_table.Name = "enc_table";
            this.enc_table.RowCount = 8;
            this.enc_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.enc_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.enc_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.enc_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.enc_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.enc_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.enc_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.enc_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.enc_table.Size = new System.Drawing.Size(323, 280);
            this.enc_table.TabIndex = 0;
            // 
            // reset_btn_txt
            // 
            this.reset_btn_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reset_btn_txt.BackColor = System.Drawing.Color.SteelBlue;
            this.reset_btn_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reset_btn_txt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.reset_btn_txt.ForeColor = System.Drawing.Color.White;
            this.reset_btn_txt.Location = new System.Drawing.Point(3, 255);
            this.reset_btn_txt.Name = "reset_btn_txt";
            this.reset_btn_txt.ReadOnly = true;
            this.reset_btn_txt.Size = new System.Drawing.Size(101, 15);
            this.reset_btn_txt.TabIndex = 17;
            this.reset_btn_txt.Text = "Reset Enc";
            this.reset_btn_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // encb_reset_btn
            // 
            this.encb_reset_btn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encb_reset_btn.ForeColor = System.Drawing.Color.Black;
            this.encb_reset_btn.Location = new System.Drawing.Point(218, 248);
            this.encb_reset_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encb_reset_btn.Name = "encb_reset_btn";
            this.encb_reset_btn.Size = new System.Drawing.Size(99, 29);
            this.encb_reset_btn.TabIndex = 33;
            this.encb_reset_btn.Text = "RESET";
            this.encb_reset_btn.UseVisualStyleBackColor = true;
            this.encb_reset_btn.Click += new System.EventHandler(this.encb_reset_btn_Click);
            // 
            // encb_filter_ctrl
            // 
            this.encb_filter_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encb_filter_ctrl.DisplayMember = "1";
            this.encb_filter_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encb_filter_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encb_filter_ctrl.FormattingEnabled = true;
            this.encb_filter_ctrl.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.encb_filter_ctrl.Location = new System.Drawing.Point(217, 145);
            this.encb_filter_ctrl.Name = "encb_filter_ctrl";
            this.encb_filter_ctrl.Size = new System.Drawing.Size(99, 24);
            this.encb_filter_ctrl.TabIndex = 22;
            this.encb_filter_ctrl.ValueMember = "1";
            this.encb_filter_ctrl.SelectedIndexChanged += new System.EventHandler(this.encb_filter_ctrl_SelectedIndexChanged);
            // 
            // encb_decode_mode_ctrl
            // 
            this.encb_decode_mode_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encb_decode_mode_ctrl.DisplayMember = "1";
            this.encb_decode_mode_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encb_decode_mode_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encb_decode_mode_ctrl.FormattingEnabled = true;
            this.encb_decode_mode_ctrl.Items.AddRange(new object[] {
            "1x",
            "2x",
            "4x"});
            this.encb_decode_mode_ctrl.Location = new System.Drawing.Point(217, 110);
            this.encb_decode_mode_ctrl.Name = "encb_decode_mode_ctrl";
            this.encb_decode_mode_ctrl.Size = new System.Drawing.Size(99, 24);
            this.encb_decode_mode_ctrl.TabIndex = 23;
            this.encb_decode_mode_ctrl.ValueMember = "1";
            this.encb_decode_mode_ctrl.SelectedIndexChanged += new System.EventHandler(this.encb_decode_mode_ctrl_SelectedIndexChanged);
            // 
            // encb_idx_input_ctrl
            // 
            this.encb_idx_input_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encb_idx_input_ctrl.DisplayMember = "1";
            this.encb_idx_input_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encb_idx_input_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encb_idx_input_ctrl.FormattingEnabled = true;
            this.encb_idx_input_ctrl.Items.AddRange(new object[] {
            "IGNORE",
            "RESET"});
            this.encb_idx_input_ctrl.Location = new System.Drawing.Point(217, 75);
            this.encb_idx_input_ctrl.Name = "encb_idx_input_ctrl";
            this.encb_idx_input_ctrl.Size = new System.Drawing.Size(99, 24);
            this.encb_idx_input_ctrl.TabIndex = 24;
            this.encb_idx_input_ctrl.ValueMember = "1";
            this.encb_idx_input_ctrl.SelectedIndexChanged += new System.EventHandler(this.encb_idx_input_ctrl_SelectedIndexChanged);
            // 
            // enca_filter_ctrl
            // 
            this.enca_filter_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enca_filter_ctrl.DisplayMember = "1";
            this.enca_filter_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enca_filter_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enca_filter_ctrl.FormattingEnabled = true;
            this.enca_filter_ctrl.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.enca_filter_ctrl.Location = new System.Drawing.Point(110, 145);
            this.enca_filter_ctrl.Name = "enca_filter_ctrl";
            this.enca_filter_ctrl.Size = new System.Drawing.Size(99, 24);
            this.enca_filter_ctrl.TabIndex = 27;
            this.enca_filter_ctrl.ValueMember = "1";
            this.enca_filter_ctrl.SelectedIndexChanged += new System.EventHandler(this.enca_filter_ctrl_SelectedIndexChanged);
            // 
            // enca_decode_mode_ctrl
            // 
            this.enca_decode_mode_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enca_decode_mode_ctrl.DisplayMember = "1";
            this.enca_decode_mode_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enca_decode_mode_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enca_decode_mode_ctrl.FormattingEnabled = true;
            this.enca_decode_mode_ctrl.Items.AddRange(new object[] {
            "1x",
            "2x",
            "4x"});
            this.enca_decode_mode_ctrl.Location = new System.Drawing.Point(110, 110);
            this.enca_decode_mode_ctrl.Name = "enca_decode_mode_ctrl";
            this.enca_decode_mode_ctrl.Size = new System.Drawing.Size(99, 24);
            this.enca_decode_mode_ctrl.TabIndex = 28;
            this.enca_decode_mode_ctrl.ValueMember = "1";
            this.enca_decode_mode_ctrl.SelectedIndexChanged += new System.EventHandler(this.enca_decode_mode_ctrl_SelectedIndexChanged);
            // 
            // enca_idx_input_ctrl
            // 
            this.enca_idx_input_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enca_idx_input_ctrl.DisplayMember = "1";
            this.enca_idx_input_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enca_idx_input_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enca_idx_input_ctrl.FormattingEnabled = true;
            this.enca_idx_input_ctrl.Items.AddRange(new object[] {
            "IGNORE",
            "RESET"});
            this.enca_idx_input_ctrl.Location = new System.Drawing.Point(110, 75);
            this.enca_idx_input_ctrl.Name = "enca_idx_input_ctrl";
            this.enca_idx_input_ctrl.Size = new System.Drawing.Size(99, 24);
            this.enca_idx_input_ctrl.TabIndex = 29;
            this.enca_idx_input_ctrl.ValueMember = "1";
            this.enca_idx_input_ctrl.SelectedIndexChanged += new System.EventHandler(this.enca_idx_input_ctrl_SelectedIndexChanged);
            // 
            // encb_input_mode_ctrl
            // 
            this.encb_input_mode_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encb_input_mode_ctrl.DisplayMember = "1";
            this.encb_input_mode_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encb_input_mode_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encb_input_mode_ctrl.FormattingEnabled = true;
            this.encb_input_mode_ctrl.Items.AddRange(new object[] {
            "NORM",
            "INV"});
            this.encb_input_mode_ctrl.Location = new System.Drawing.Point(217, 40);
            this.encb_input_mode_ctrl.Name = "encb_input_mode_ctrl";
            this.encb_input_mode_ctrl.Size = new System.Drawing.Size(99, 24);
            this.encb_input_mode_ctrl.TabIndex = 20;
            this.encb_input_mode_ctrl.ValueMember = "1";
            this.encb_input_mode_ctrl.SelectedIndexChanged += new System.EventHandler(this.encb_input_mode_ctrl_SelectedIndexChanged);
            // 
            // text_enc_comparator
            // 
            this.text_enc_comparator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_enc_comparator.BackColor = System.Drawing.Color.SteelBlue;
            this.text_enc_comparator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_enc_comparator.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.text_enc_comparator.ForeColor = System.Drawing.Color.White;
            this.text_enc_comparator.Location = new System.Drawing.Point(3, 220);
            this.text_enc_comparator.Name = "text_enc_comparator";
            this.text_enc_comparator.ReadOnly = true;
            this.text_enc_comparator.Size = new System.Drawing.Size(101, 15);
            this.text_enc_comparator.TabIndex = 14;
            this.text_enc_comparator.Text = "Comparator";
            this.text_enc_comparator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_enc_comp_step
            // 
            this.text_enc_comp_step.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_enc_comp_step.BackColor = System.Drawing.Color.SteelBlue;
            this.text_enc_comp_step.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_enc_comp_step.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.text_enc_comp_step.ForeColor = System.Drawing.Color.White;
            this.text_enc_comp_step.Location = new System.Drawing.Point(3, 185);
            this.text_enc_comp_step.Name = "text_enc_comp_step";
            this.text_enc_comp_step.ReadOnly = true;
            this.text_enc_comp_step.Size = new System.Drawing.Size(101, 15);
            this.text_enc_comp_step.TabIndex = 15;
            this.text_enc_comp_step.Text = "Comp. step";
            this.text_enc_comp_step.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_enc_filter
            // 
            this.text_enc_filter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_enc_filter.BackColor = System.Drawing.Color.SteelBlue;
            this.text_enc_filter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_enc_filter.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.text_enc_filter.ForeColor = System.Drawing.Color.White;
            this.text_enc_filter.Location = new System.Drawing.Point(3, 149);
            this.text_enc_filter.Name = "text_enc_filter";
            this.text_enc_filter.ReadOnly = true;
            this.text_enc_filter.Size = new System.Drawing.Size(101, 17);
            this.text_enc_filter.TabIndex = 16;
            this.text_enc_filter.Text = "Filter";
            this.text_enc_filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_enc_decode_mode
            // 
            this.text_enc_decode_mode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_enc_decode_mode.BackColor = System.Drawing.Color.SteelBlue;
            this.text_enc_decode_mode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_enc_decode_mode.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.text_enc_decode_mode.ForeColor = System.Drawing.Color.White;
            this.text_enc_decode_mode.Location = new System.Drawing.Point(3, 116);
            this.text_enc_decode_mode.Name = "text_enc_decode_mode";
            this.text_enc_decode_mode.ReadOnly = true;
            this.text_enc_decode_mode.Size = new System.Drawing.Size(101, 13);
            this.text_enc_decode_mode.TabIndex = 17;
            this.text_enc_decode_mode.Text = "Decode mode";
            this.text_enc_decode_mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_enc_idx_input
            // 
            this.text_enc_idx_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_enc_idx_input.BackColor = System.Drawing.Color.SteelBlue;
            this.text_enc_idx_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_enc_idx_input.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.text_enc_idx_input.ForeColor = System.Drawing.Color.White;
            this.text_enc_idx_input.Location = new System.Drawing.Point(3, 79);
            this.text_enc_idx_input.Name = "text_enc_idx_input";
            this.text_enc_idx_input.ReadOnly = true;
            this.text_enc_idx_input.Size = new System.Drawing.Size(101, 17);
            this.text_enc_idx_input.TabIndex = 18;
            this.text_enc_idx_input.Text = "IDX input";
            this.text_enc_idx_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_enc_input_mode
            // 
            this.text_enc_input_mode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_enc_input_mode.BackColor = System.Drawing.Color.SteelBlue;
            this.text_enc_input_mode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_enc_input_mode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.text_enc_input_mode.ForeColor = System.Drawing.Color.White;
            this.text_enc_input_mode.Location = new System.Drawing.Point(3, 45);
            this.text_enc_input_mode.Name = "text_enc_input_mode";
            this.text_enc_input_mode.ReadOnly = true;
            this.text_enc_input_mode.Size = new System.Drawing.Size(101, 15);
            this.text_enc_input_mode.TabIndex = 0;
            this.text_enc_input_mode.Text = "Input mode";
            this.text_enc_input_mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // enca_input_mode_ctrl
            // 
            this.enca_input_mode_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enca_input_mode_ctrl.DisplayMember = "1";
            this.enca_input_mode_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enca_input_mode_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enca_input_mode_ctrl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.enca_input_mode_ctrl.FormattingEnabled = true;
            this.enca_input_mode_ctrl.Items.AddRange(new object[] {
            "NORM",
            "INV"});
            this.enca_input_mode_ctrl.Location = new System.Drawing.Point(110, 40);
            this.enca_input_mode_ctrl.Name = "enca_input_mode_ctrl";
            this.enca_input_mode_ctrl.Size = new System.Drawing.Size(99, 24);
            this.enca_input_mode_ctrl.TabIndex = 19;
            this.enca_input_mode_ctrl.ValueMember = "1";
            this.enca_input_mode_ctrl.SelectedIndexChanged += new System.EventHandler(this.enca_input_mode_ctrl_SelectedIndexChanged);
            // 
            // enca_enable_ctrl
            // 
            this.enca_enable_ctrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enca_enable_ctrl.AutoSize = true;
            this.enca_enable_ctrl.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enca_enable_ctrl.Location = new System.Drawing.Point(111, 8);
            this.enca_enable_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enca_enable_ctrl.Name = "enca_enable_ctrl";
            this.enca_enable_ctrl.Size = new System.Drawing.Size(85, 24);
            this.enca_enable_ctrl.TabIndex = 30;
            this.enca_enable_ctrl.Text = "ENC A";
            this.enca_enable_ctrl.UseVisualStyleBackColor = true;
            this.enca_enable_ctrl.CheckedChanged += new System.EventHandler(this.enca_enable_ctrl_CheckedChanged);
            // 
            // encb_enable_ctrl
            // 
            this.encb_enable_ctrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.encb_enable_ctrl.AutoSize = true;
            this.encb_enable_ctrl.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encb_enable_ctrl.Location = new System.Drawing.Point(218, 8);
            this.encb_enable_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encb_enable_ctrl.Name = "encb_enable_ctrl";
            this.encb_enable_ctrl.Size = new System.Drawing.Size(85, 24);
            this.encb_enable_ctrl.TabIndex = 31;
            this.encb_enable_ctrl.Text = "ENC B";
            this.encb_enable_ctrl.UseVisualStyleBackColor = true;
            this.encb_enable_ctrl.CheckedChanged += new System.EventHandler(this.encb_enable_ctrl_CheckedChanged);
            // 
            // enca_comparator_ctrl
            // 
            this.enca_comparator_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enca_comparator_ctrl.DisplayMember = "2";
            this.enca_comparator_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enca_comparator_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enca_comparator_ctrl.FormattingEnabled = true;
            this.enca_comparator_ctrl.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.enca_comparator_ctrl.Location = new System.Drawing.Point(110, 215);
            this.enca_comparator_ctrl.Name = "enca_comparator_ctrl";
            this.enca_comparator_ctrl.Size = new System.Drawing.Size(99, 24);
            this.enca_comparator_ctrl.TabIndex = 25;
            this.enca_comparator_ctrl.ValueMember = "2";
            this.enca_comparator_ctrl.SelectedIndexChanged += new System.EventHandler(this.enca_comparator_ctrl_SelectedIndexChanged);
            // 
            // enca_comparator_step_ctrl
            // 
            this.enca_comparator_step_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enca_comparator_step_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enca_comparator_step_ctrl.Location = new System.Drawing.Point(110, 181);
            this.enca_comparator_step_ctrl.MaxLength = 3;
            this.enca_comparator_step_ctrl.Name = "enca_comparator_step_ctrl";
            this.enca_comparator_step_ctrl.Size = new System.Drawing.Size(99, 23);
            this.enca_comparator_step_ctrl.TabIndex = 13;
            this.enca_comparator_step_ctrl.Text = "34";
            this.enca_comparator_step_ctrl.TextChanged += new System.EventHandler(this.enca_comparator_step_ctrl_TextChanged);
            this.enca_comparator_step_ctrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enca_comparator_step_ctrl_KeyDown);
            this.enca_comparator_step_ctrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enca_comparator_step_ctrl_KeyPress);
            this.enca_comparator_step_ctrl.Leave += new System.EventHandler(this.enca_comparator_step_ctrl_Leave);
            // 
            // encb_comparator_ctrl
            // 
            this.encb_comparator_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encb_comparator_ctrl.DisplayMember = "1";
            this.encb_comparator_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encb_comparator_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encb_comparator_ctrl.FormattingEnabled = true;
            this.encb_comparator_ctrl.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.encb_comparator_ctrl.Location = new System.Drawing.Point(217, 215);
            this.encb_comparator_ctrl.Name = "encb_comparator_ctrl";
            this.encb_comparator_ctrl.Size = new System.Drawing.Size(99, 24);
            this.encb_comparator_ctrl.TabIndex = 21;
            this.encb_comparator_ctrl.ValueMember = "2";
            this.encb_comparator_ctrl.SelectedIndexChanged += new System.EventHandler(this.encb_comparator_ctrl_SelectedIndexChanged);
            this.encb_comparator_ctrl.Click += new System.EventHandler(this.encb_comparator_ctrl_Click);
            // 
            // encb_comparator_step_ctrl
            // 
            this.encb_comparator_step_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encb_comparator_step_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encb_comparator_step_ctrl.Location = new System.Drawing.Point(217, 181);
            this.encb_comparator_step_ctrl.MaxLength = 3;
            this.encb_comparator_step_ctrl.Name = "encb_comparator_step_ctrl";
            this.encb_comparator_step_ctrl.Size = new System.Drawing.Size(99, 23);
            this.encb_comparator_step_ctrl.TabIndex = 12;
            this.encb_comparator_step_ctrl.Text = "1";
            this.encb_comparator_step_ctrl.TextChanged += new System.EventHandler(this.encb_comparator_step_ctrl_TextChanged);
            this.encb_comparator_step_ctrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.encb_comparator_step_ctrl_KeyDown);
            this.encb_comparator_step_ctrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.encb_comparator_step_ctrl_KeyPress);
            this.encb_comparator_step_ctrl.Leave += new System.EventHandler(this.encb_comparator_step_ctrl_Leave);
            // 
            // enca_reset_btn
            // 
            this.enca_reset_btn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enca_reset_btn.ForeColor = System.Drawing.Color.Black;
            this.enca_reset_btn.Location = new System.Drawing.Point(111, 248);
            this.enca_reset_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enca_reset_btn.Name = "enca_reset_btn";
            this.enca_reset_btn.Size = new System.Drawing.Size(99, 29);
            this.enca_reset_btn.TabIndex = 32;
            this.enca_reset_btn.Text = "RESET";
            this.enca_reset_btn.UseVisualStyleBackColor = true;
            this.enca_reset_btn.Click += new System.EventHandler(this.enca_reset_btn_Click);
            // 
            // enc_groupbox
            // 
            this.enc_groupbox.Controls.Add(this.enc_table);
            this.enc_groupbox.ForeColor = System.Drawing.Color.White;
            this.enc_groupbox.Location = new System.Drawing.Point(678, 452);
            this.enc_groupbox.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.enc_groupbox.Name = "enc_groupbox";
            this.enc_groupbox.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.enc_groupbox.Size = new System.Drawing.Size(339, 300);
            this.enc_groupbox.TabIndex = 31;
            this.enc_groupbox.TabStop = false;
            this.enc_groupbox.Text = "Encoders\' Parameters";
            // 
            // text_ampl_input_source
            // 
            this.text_ampl_input_source.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_ampl_input_source.BackColor = System.Drawing.Color.SteelBlue;
            this.text_ampl_input_source.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ampl_input_source.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_ampl_input_source.ForeColor = System.Drawing.Color.White;
            this.text_ampl_input_source.Location = new System.Drawing.Point(4, 93);
            this.text_ampl_input_source.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_ampl_input_source.Name = "text_ampl_input_source";
            this.text_ampl_input_source.ReadOnly = true;
            this.text_ampl_input_source.Size = new System.Drawing.Size(115, 14);
            this.text_ampl_input_source.TabIndex = 4;
            this.text_ampl_input_source.Text = "Input source";
            this.text_ampl_input_source.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_ampl_gain
            // 
            this.text_ampl_gain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_ampl_gain.BackColor = System.Drawing.Color.SteelBlue;
            this.text_ampl_gain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ampl_gain.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_ampl_gain.ForeColor = System.Drawing.Color.White;
            this.text_ampl_gain.Location = new System.Drawing.Point(4, 133);
            this.text_ampl_gain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_ampl_gain.Name = "text_ampl_gain";
            this.text_ampl_gain.ReadOnly = true;
            this.text_ampl_gain.Size = new System.Drawing.Size(115, 14);
            this.text_ampl_gain.TabIndex = 3;
            this.text_ampl_gain.Text = "Gain";
            this.text_ampl_gain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_ampl_gain_unit
            // 
            this.text_ampl_gain_unit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_ampl_gain_unit.BackColor = System.Drawing.Color.SteelBlue;
            this.text_ampl_gain_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ampl_gain_unit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_ampl_gain_unit.ForeColor = System.Drawing.Color.White;
            this.text_ampl_gain_unit.Location = new System.Drawing.Point(250, 132);
            this.text_ampl_gain_unit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_ampl_gain_unit.Name = "text_ampl_gain_unit";
            this.text_ampl_gain_unit.ReadOnly = true;
            this.text_ampl_gain_unit.Size = new System.Drawing.Size(55, 16);
            this.text_ampl_gain_unit.TabIndex = 10;
            this.text_ampl_gain_unit.Text = "dB";
            // 
            // text_ampl_filter_bandtwidth
            // 
            this.text_ampl_filter_bandtwidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_ampl_filter_bandtwidth.BackColor = System.Drawing.Color.SteelBlue;
            this.text_ampl_filter_bandtwidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ampl_filter_bandtwidth.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.text_ampl_filter_bandtwidth.ForeColor = System.Drawing.Color.White;
            this.text_ampl_filter_bandtwidth.Location = new System.Drawing.Point(4, 14);
            this.text_ampl_filter_bandtwidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_ampl_filter_bandtwidth.Name = "text_ampl_filter_bandtwidth";
            this.text_ampl_filter_bandtwidth.ReadOnly = true;
            this.text_ampl_filter_bandtwidth.Size = new System.Drawing.Size(115, 12);
            this.text_ampl_filter_bandtwidth.TabIndex = 1;
            this.text_ampl_filter_bandtwidth.Text = "Filter bandtwidth";
            this.text_ampl_filter_bandtwidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_plot_algorithm_title
            // 
            this.txt_plot_algorithm_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_plot_algorithm_title.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_plot_algorithm_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_plot_algorithm_title.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_plot_algorithm_title.ForeColor = System.Drawing.Color.White;
            this.txt_plot_algorithm_title.Location = new System.Drawing.Point(4, 137);
            this.txt_plot_algorithm_title.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_plot_algorithm_title.Name = "txt_plot_algorithm_title";
            this.txt_plot_algorithm_title.ReadOnly = true;
            this.txt_plot_algorithm_title.Size = new System.Drawing.Size(115, 14);
            this.txt_plot_algorithm_title.TabIndex = 15;
            this.txt_plot_algorithm_title.Text = "Plot algorithm";
            this.txt_plot_algorithm_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_acq_mode
            // 
            this.text_acq_mode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_acq_mode.BackColor = System.Drawing.Color.SteelBlue;
            this.text_acq_mode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_acq_mode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_acq_mode.ForeColor = System.Drawing.Color.White;
            this.text_acq_mode.Location = new System.Drawing.Point(4, 41);
            this.text_acq_mode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_acq_mode.Name = "text_acq_mode";
            this.text_acq_mode.ReadOnly = true;
            this.text_acq_mode.Size = new System.Drawing.Size(115, 14);
            this.text_acq_mode.TabIndex = 1;
            this.text_acq_mode.Text = "Mode";
            this.text_acq_mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_acq_delay_unit
            // 
            this.text_acq_delay_unit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_acq_delay_unit.BackColor = System.Drawing.Color.SteelBlue;
            this.text_acq_delay_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_acq_delay_unit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_acq_delay_unit.ForeColor = System.Drawing.Color.White;
            this.text_acq_delay_unit.Location = new System.Drawing.Point(250, 104);
            this.text_acq_delay_unit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_acq_delay_unit.Name = "text_acq_delay_unit";
            this.text_acq_delay_unit.ReadOnly = true;
            this.text_acq_delay_unit.Size = new System.Drawing.Size(55, 16);
            this.text_acq_delay_unit.TabIndex = 12;
            this.text_acq_delay_unit.Text = "us";
            // 
            // text_acq_delay
            // 
            this.text_acq_delay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_acq_delay.BackColor = System.Drawing.Color.SteelBlue;
            this.text_acq_delay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_acq_delay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_acq_delay.ForeColor = System.Drawing.Color.White;
            this.text_acq_delay.Location = new System.Drawing.Point(4, 105);
            this.text_acq_delay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_acq_delay.Name = "text_acq_delay";
            this.text_acq_delay.ReadOnly = true;
            this.text_acq_delay.Size = new System.Drawing.Size(115, 14);
            this.text_acq_delay.TabIndex = 3;
            this.text_acq_delay.Text = "Delay";
            this.text_acq_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_acq_window_unit
            // 
            this.text_acq_window_unit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_acq_window_unit.BackColor = System.Drawing.Color.SteelBlue;
            this.text_acq_window_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_acq_window_unit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_acq_window_unit.ForeColor = System.Drawing.Color.White;
            this.text_acq_window_unit.Location = new System.Drawing.Point(250, 72);
            this.text_acq_window_unit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_acq_window_unit.Name = "text_acq_window_unit";
            this.text_acq_window_unit.ReadOnly = true;
            this.text_acq_window_unit.Size = new System.Drawing.Size(55, 16);
            this.text_acq_window_unit.TabIndex = 13;
            this.text_acq_window_unit.Text = "us";
            // 
            // pdc_mode_ctrl
            // 
            this.pdc_mode_ctrl.DisplayMember = "1";
            this.pdc_mode_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pdc_mode_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_mode_ctrl.FormattingEnabled = true;
            this.pdc_mode_ctrl.Items.AddRange(new object[] {
            "LEVEL",
            "RISING",
            "FALLING",
            "TRANSITION"});
            this.pdc_mode_ctrl.Location = new System.Drawing.Point(96, 156);
            this.pdc_mode_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdc_mode_ctrl.Name = "pdc_mode_ctrl";
            this.pdc_mode_ctrl.Size = new System.Drawing.Size(158, 24);
            this.pdc_mode_ctrl.TabIndex = 8;
            this.pdc_mode_ctrl.Tag = "pd_mode_list";
            this.pdc_mode_ctrl.ValueMember = "1";
            this.pdc_mode_ctrl.SelectedIndexChanged += new System.EventHandler(this.pdc_mode_ctrl_SelectedIndexChanged);
            // 
            // pdc_peak_position_ctrl
            // 
            this.pdc_peak_position_ctrl.BackColor = System.Drawing.Color.White;
            this.pdc_peak_position_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_peak_position_ctrl.Location = new System.Drawing.Point(497, 156);
            this.pdc_peak_position_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdc_peak_position_ctrl.Name = "pdc_peak_position_ctrl";
            this.pdc_peak_position_ctrl.ReadOnly = true;
            this.pdc_peak_position_ctrl.Size = new System.Drawing.Size(106, 23);
            this.pdc_peak_position_ctrl.TabIndex = 15;
            this.pdc_peak_position_ctrl.Text = "0.0";
            // 
            // trig_groupbox
            // 
            this.trig_groupbox.Controls.Add(this.trig_table);
            this.trig_groupbox.ForeColor = System.Drawing.Color.White;
            this.trig_groupbox.Location = new System.Drawing.Point(1025, 577);
            this.trig_groupbox.Name = "trig_groupbox";
            this.trig_groupbox.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.trig_groupbox.Size = new System.Drawing.Size(325, 140);
            this.trig_groupbox.TabIndex = 28;
            this.trig_groupbox.TabStop = false;
            this.trig_groupbox.Text = "Trigger Parameters";
            // 
            // trig_table
            // 
            this.trig_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trig_table.BackColor = System.Drawing.Color.Transparent;
            this.trig_table.ColumnCount = 3;
            this.trig_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.trig_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.trig_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.trig_table.Controls.Add(this.xy_divider_ctrl, 1, 2);
            this.trig_table.Controls.Add(this.trigger_source_ctrl, 1, 0);
            this.trig_table.Controls.Add(this.text_trig_trigger_source, 0, 0);
            this.trig_table.Controls.Add(this.text_trig_timer_period, 0, 1);
            this.trig_table.Controls.Add(this.text_trig_xy_divider, 0, 2);
            this.trig_table.Controls.Add(this.text_trig_timer_unit, 2, 1);
            this.trig_table.Controls.Add(this.timer_period_ctrl, 1, 1);
            this.trig_table.Location = new System.Drawing.Point(11, 14);
            this.trig_table.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trig_table.Name = "trig_table";
            this.trig_table.RowCount = 3;
            this.trig_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.trig_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.trig_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.trig_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.trig_table.Size = new System.Drawing.Size(309, 120);
            this.trig_table.TabIndex = 13;
            // 
            // xy_divider_ctrl
            // 
            this.xy_divider_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xy_divider_ctrl.DisplayMember = "2";
            this.xy_divider_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xy_divider_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xy_divider_ctrl.FormattingEnabled = true;
            this.xy_divider_ctrl.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.xy_divider_ctrl.Location = new System.Drawing.Point(127, 88);
            this.xy_divider_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xy_divider_ctrl.Name = "xy_divider_ctrl";
            this.xy_divider_ctrl.Size = new System.Drawing.Size(115, 24);
            this.xy_divider_ctrl.TabIndex = 13;
            this.xy_divider_ctrl.ValueMember = "2";
            this.xy_divider_ctrl.SelectedIndexChanged += new System.EventHandler(this.xy_divider_ctrl_SelectedIndexChanged);
            // 
            // trigger_source_ctrl
            // 
            this.trigger_source_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trigger_source_ctrl.DisplayMember = "1";
            this.trigger_source_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trigger_source_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trigger_source_ctrl.FormattingEnabled = true;
            this.trigger_source_ctrl.Items.AddRange(new object[] {
            "INT",
            "EXT X",
            "EXT Y",
            "TIMER",
            "ENC A",
            "ENC B"});
            this.trigger_source_ctrl.Location = new System.Drawing.Point(127, 8);
            this.trigger_source_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trigger_source_ctrl.Name = "trigger_source_ctrl";
            this.trigger_source_ctrl.Size = new System.Drawing.Size(115, 24);
            this.trigger_source_ctrl.TabIndex = 15;
            this.trigger_source_ctrl.ValueMember = "1";
            this.trigger_source_ctrl.SelectedIndexChanged += new System.EventHandler(this.trigger_source_ctrl_SelectedIndexChanged);
            // 
            // text_trig_trigger_source
            // 
            this.text_trig_trigger_source.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_trig_trigger_source.BackColor = System.Drawing.Color.SteelBlue;
            this.text_trig_trigger_source.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_trig_trigger_source.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.text_trig_trigger_source.ForeColor = System.Drawing.Color.White;
            this.text_trig_trigger_source.Location = new System.Drawing.Point(4, 13);
            this.text_trig_trigger_source.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_trig_trigger_source.Name = "text_trig_trigger_source";
            this.text_trig_trigger_source.ReadOnly = true;
            this.text_trig_trigger_source.Size = new System.Drawing.Size(115, 14);
            this.text_trig_trigger_source.TabIndex = 1;
            this.text_trig_trigger_source.Text = "Trigger source";
            this.text_trig_trigger_source.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_trig_timer_period
            // 
            this.text_trig_timer_period.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_trig_timer_period.BackColor = System.Drawing.Color.SteelBlue;
            this.text_trig_timer_period.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_trig_timer_period.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_trig_timer_period.ForeColor = System.Drawing.Color.White;
            this.text_trig_timer_period.Location = new System.Drawing.Point(4, 53);
            this.text_trig_timer_period.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_trig_timer_period.Name = "text_trig_timer_period";
            this.text_trig_timer_period.ReadOnly = true;
            this.text_trig_timer_period.Size = new System.Drawing.Size(115, 14);
            this.text_trig_timer_period.TabIndex = 2;
            this.text_trig_timer_period.Text = "Timer period";
            this.text_trig_timer_period.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_trig_xy_divider
            // 
            this.text_trig_xy_divider.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_trig_xy_divider.BackColor = System.Drawing.Color.SteelBlue;
            this.text_trig_xy_divider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_trig_xy_divider.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_trig_xy_divider.ForeColor = System.Drawing.Color.White;
            this.text_trig_xy_divider.Location = new System.Drawing.Point(4, 93);
            this.text_trig_xy_divider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_trig_xy_divider.Name = "text_trig_xy_divider";
            this.text_trig_xy_divider.ReadOnly = true;
            this.text_trig_xy_divider.Size = new System.Drawing.Size(115, 14);
            this.text_trig_xy_divider.TabIndex = 4;
            this.text_trig_xy_divider.Text = "X/Y divider";
            this.text_trig_xy_divider.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_trig_timer_unit
            // 
            this.text_trig_timer_unit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_trig_timer_unit.BackColor = System.Drawing.Color.SteelBlue;
            this.text_trig_timer_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_trig_timer_unit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_trig_timer_unit.ForeColor = System.Drawing.Color.White;
            this.text_trig_timer_unit.Location = new System.Drawing.Point(250, 52);
            this.text_trig_timer_unit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_trig_timer_unit.Name = "text_trig_timer_unit";
            this.text_trig_timer_unit.ReadOnly = true;
            this.text_trig_timer_unit.Size = new System.Drawing.Size(55, 16);
            this.text_trig_timer_unit.TabIndex = 9;
            this.text_trig_timer_unit.Text = "kHz";
            // 
            // timer_period_ctrl
            // 
            this.timer_period_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timer_period_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timer_period_ctrl.Location = new System.Drawing.Point(127, 48);
            this.timer_period_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.timer_period_ctrl.MaxLength = 6;
            this.timer_period_ctrl.Name = "timer_period_ctrl";
            this.timer_period_ctrl.Size = new System.Drawing.Size(115, 23);
            this.timer_period_ctrl.TabIndex = 16;
            this.timer_period_ctrl.Text = "6.3";
            this.timer_period_ctrl.TextChanged += new System.EventHandler(this.timer_period_ctrl_TextChanged);
            this.timer_period_ctrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timer_period_ctrl_KeyDown);
            this.timer_period_ctrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timer_period_ctrl_KeyPress);
            this.timer_period_ctrl.Leave += new System.EventHandler(this.timer_period_ctrl_Leave);
            // 
            // pdb_mode_ctrl
            // 
            this.pdb_mode_ctrl.DisplayMember = "1";
            this.pdb_mode_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pdb_mode_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_mode_ctrl.FormattingEnabled = true;
            this.pdb_mode_ctrl.Items.AddRange(new object[] {
            "LEVEL",
            "RISING",
            "FALLING",
            "TRANSITION"});
            this.pdb_mode_ctrl.Location = new System.Drawing.Point(96, 120);
            this.pdb_mode_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdb_mode_ctrl.Name = "pdb_mode_ctrl";
            this.pdb_mode_ctrl.Size = new System.Drawing.Size(158, 24);
            this.pdb_mode_ctrl.TabIndex = 7;
            this.pdb_mode_ctrl.Tag = "pd_mode_list";
            this.pdb_mode_ctrl.ValueMember = "1";
            this.pdb_mode_ctrl.SelectedIndexChanged += new System.EventHandler(this.pdb_mode_ctrl_SelectedIndexChanged);
            // 
            // pdc_enable_ctrl
            // 
            this.pdc_enable_ctrl.AutoSize = true;
            this.pdc_enable_ctrl.Checked = true;
            this.pdc_enable_ctrl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pdc_enable_ctrl.ForeColor = System.Drawing.Color.Aqua;
            this.pdc_enable_ctrl.Location = new System.Drawing.Point(4, 156);
            this.pdc_enable_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdc_enable_ctrl.Name = "pdc_enable_ctrl";
            this.pdc_enable_ctrl.Size = new System.Drawing.Size(51, 17);
            this.pdc_enable_ctrl.TabIndex = 2;
            this.pdc_enable_ctrl.Text = "PDC";
            this.pdc_enable_ctrl.UseVisualStyleBackColor = true;
            this.pdc_enable_ctrl.CheckedChanged += new System.EventHandler(this.pdc_enable_ctrl_CheckedChanged);
            // 
            // pdb_peak_position_ctrl
            // 
            this.pdb_peak_position_ctrl.BackColor = System.Drawing.Color.White;
            this.pdb_peak_position_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_peak_position_ctrl.Location = new System.Drawing.Point(497, 120);
            this.pdb_peak_position_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdb_peak_position_ctrl.Name = "pdb_peak_position_ctrl";
            this.pdb_peak_position_ctrl.ReadOnly = true;
            this.pdb_peak_position_ctrl.Size = new System.Drawing.Size(106, 23);
            this.pdb_peak_position_ctrl.TabIndex = 14;
            this.pdb_peak_position_ctrl.Text = "0.0";
            // 
            // pdb_enable_ctrl
            // 
            this.pdb_enable_ctrl.AutoSize = true;
            this.pdb_enable_ctrl.Checked = true;
            this.pdb_enable_ctrl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pdb_enable_ctrl.ForeColor = System.Drawing.Color.LawnGreen;
            this.pdb_enable_ctrl.Location = new System.Drawing.Point(4, 120);
            this.pdb_enable_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdb_enable_ctrl.Name = "pdb_enable_ctrl";
            this.pdb_enable_ctrl.Size = new System.Drawing.Size(51, 17);
            this.pdb_enable_ctrl.TabIndex = 1;
            this.pdb_enable_ctrl.Text = "PDB";
            this.pdb_enable_ctrl.UseVisualStyleBackColor = true;
            this.pdb_enable_ctrl.CheckedChanged += new System.EventHandler(this.pdb_enable_ctrl_CheckedChanged);
            // 
            // pda_peak_position_ctrl
            // 
            this.pda_peak_position_ctrl.BackColor = System.Drawing.Color.White;
            this.pda_peak_position_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_peak_position_ctrl.Location = new System.Drawing.Point(497, 84);
            this.pda_peak_position_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pda_peak_position_ctrl.Name = "pda_peak_position_ctrl";
            this.pda_peak_position_ctrl.ReadOnly = true;
            this.pda_peak_position_ctrl.Size = new System.Drawing.Size(106, 23);
            this.pda_peak_position_ctrl.TabIndex = 13;
            this.pda_peak_position_ctrl.Text = "0.0";
            // 
            // pda_enable_ctrl
            // 
            this.pda_enable_ctrl.AutoSize = true;
            this.pda_enable_ctrl.Checked = true;
            this.pda_enable_ctrl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pda_enable_ctrl.ForeColor = System.Drawing.Color.OrangeRed;
            this.pda_enable_ctrl.Location = new System.Drawing.Point(4, 84);
            this.pda_enable_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pda_enable_ctrl.Name = "pda_enable_ctrl";
            this.pda_enable_ctrl.Size = new System.Drawing.Size(51, 17);
            this.pda_enable_ctrl.TabIndex = 0;
            this.pda_enable_ctrl.Text = "PDA";
            this.pda_enable_ctrl.UseVisualStyleBackColor = true;
            this.pda_enable_ctrl.CheckedChanged += new System.EventHandler(this.pda_enable_ctrl_CheckedChanged);
            // 
            // pda_mode_ctrl
            // 
            this.pda_mode_ctrl.DisplayMember = "1";
            this.pda_mode_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pda_mode_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_mode_ctrl.FormattingEnabled = true;
            this.pda_mode_ctrl.Items.AddRange(new object[] {
            "LEVEL",
            "RISING",
            "FALLING",
            "TRANSITION"});
            this.pda_mode_ctrl.Location = new System.Drawing.Point(96, 84);
            this.pda_mode_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pda_mode_ctrl.Name = "pda_mode_ctrl";
            this.pda_mode_ctrl.Size = new System.Drawing.Size(158, 24);
            this.pda_mode_ctrl.TabIndex = 3;
            this.pda_mode_ctrl.Tag = "pd_mode_list";
            this.pda_mode_ctrl.ValueMember = "1";
            this.pda_mode_ctrl.SelectedIndexChanged += new System.EventHandler(this.pda_mode_ctrl_SelectedIndexChanged);
            // 
            // sampling_freq_ctrl
            // 
            this.sampling_freq_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sampling_freq_ctrl.DisplayMember = "1";
            this.sampling_freq_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sampling_freq_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sampling_freq_ctrl.FormattingEnabled = true;
            this.sampling_freq_ctrl.Items.AddRange(new object[] {
            "100.0",
            "50.0",
            "33.3",
            "25.0",
            "20.0",
            "16.7",
            "14.3",
            "12.5",
            "11.1",
            "10.0",
            "9.1",
            "8.3",
            "7.7",
            "7.1",
            "6.7"});
            this.sampling_freq_ctrl.Location = new System.Drawing.Point(127, 4);
            this.sampling_freq_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sampling_freq_ctrl.Name = "sampling_freq_ctrl";
            this.sampling_freq_ctrl.Size = new System.Drawing.Size(115, 24);
            this.sampling_freq_ctrl.TabIndex = 4;
            this.sampling_freq_ctrl.Tag = "sampling_freq_list";
            this.sampling_freq_ctrl.ValueMember = "1";
            this.sampling_freq_ctrl.SelectedIndexChanged += new System.EventHandler(this.sampling_freq_ctrl_SelectedIndexChanged);
            // 
            // pdc_ref_position_ctrl
            // 
            this.pdc_ref_position_ctrl.BackColor = System.Drawing.Color.White;
            this.pdc_ref_position_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_ref_position_ctrl.Location = new System.Drawing.Point(265, 156);
            this.pdc_ref_position_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdc_ref_position_ctrl.Name = "pdc_ref_position_ctrl";
            this.pdc_ref_position_ctrl.ReadOnly = true;
            this.pdc_ref_position_ctrl.Size = new System.Drawing.Size(106, 23);
            this.pdc_ref_position_ctrl.TabIndex = 11;
            this.pdc_ref_position_ctrl.Text = "0.0";
            // 
            // pda_ref_position_ctrl
            // 
            this.pda_ref_position_ctrl.BackColor = System.Drawing.Color.White;
            this.pda_ref_position_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_ref_position_ctrl.Location = new System.Drawing.Point(265, 84);
            this.pda_ref_position_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pda_ref_position_ctrl.Name = "pda_ref_position_ctrl";
            this.pda_ref_position_ctrl.ReadOnly = true;
            this.pda_ref_position_ctrl.Size = new System.Drawing.Size(106, 23);
            this.pda_ref_position_ctrl.TabIndex = 9;
            this.pda_ref_position_ctrl.Text = "0.0";
            this.pda_ref_position_ctrl.TextChanged += new System.EventHandler(this.pda_ref_position_ctrl_TextChanged);
            // 
            // pdc_peak_amplitude_ctrl
            // 
            this.pdc_peak_amplitude_ctrl.BackColor = System.Drawing.Color.White;
            this.pdc_peak_amplitude_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdc_peak_amplitude_ctrl.Location = new System.Drawing.Point(381, 156);
            this.pdc_peak_amplitude_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdc_peak_amplitude_ctrl.Name = "pdc_peak_amplitude_ctrl";
            this.pdc_peak_amplitude_ctrl.ReadOnly = true;
            this.pdc_peak_amplitude_ctrl.Size = new System.Drawing.Size(106, 23);
            this.pdc_peak_amplitude_ctrl.TabIndex = 11;
            this.pdc_peak_amplitude_ctrl.Text = "0.0";
            this.pdc_peak_amplitude_ctrl.TextChanged += new System.EventHandler(this.pdc_peak_amplitude_ctrl_TextChanged);
            // 
            // pdb_peak_amplitude_ctrl
            // 
            this.pdb_peak_amplitude_ctrl.BackColor = System.Drawing.Color.White;
            this.pdb_peak_amplitude_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_peak_amplitude_ctrl.Location = new System.Drawing.Point(381, 120);
            this.pdb_peak_amplitude_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdb_peak_amplitude_ctrl.Name = "pdb_peak_amplitude_ctrl";
            this.pdb_peak_amplitude_ctrl.ReadOnly = true;
            this.pdb_peak_amplitude_ctrl.Size = new System.Drawing.Size(106, 23);
            this.pdb_peak_amplitude_ctrl.TabIndex = 10;
            this.pdb_peak_amplitude_ctrl.Text = "0.0";
            this.pdb_peak_amplitude_ctrl.TextChanged += new System.EventHandler(this.pdb_peak_amplitude_ctrl_TextChanged);
            // 
            // pda_peak_amplitude_ctrl
            // 
            this.pda_peak_amplitude_ctrl.BackColor = System.Drawing.Color.White;
            this.pda_peak_amplitude_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pda_peak_amplitude_ctrl.Location = new System.Drawing.Point(381, 84);
            this.pda_peak_amplitude_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pda_peak_amplitude_ctrl.Name = "pda_peak_amplitude_ctrl";
            this.pda_peak_amplitude_ctrl.ReadOnly = true;
            this.pda_peak_amplitude_ctrl.Size = new System.Drawing.Size(106, 23);
            this.pda_peak_amplitude_ctrl.TabIndex = 12;
            this.pda_peak_amplitude_ctrl.Text = "0.0";
            this.pda_peak_amplitude_ctrl.TextChanged += new System.EventHandler(this.pda_peak_amplitude_ctrl_TextChanged);
            // 
            // text_pd_mode
            // 
            this.text_pd_mode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_pd_mode.BackColor = System.Drawing.Color.SteelBlue;
            this.text_pd_mode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pd_mode.ForeColor = System.Drawing.Color.White;
            this.text_pd_mode.Location = new System.Drawing.Point(95, 65);
            this.text_pd_mode.Name = "text_pd_mode";
            this.text_pd_mode.ReadOnly = true;
            this.text_pd_mode.Size = new System.Drawing.Size(116, 13);
            this.text_pd_mode.TabIndex = 16;
            this.text_pd_mode.Text = "PD Mode";
            // 
            // text_pd_peak_pos
            // 
            this.text_pd_peak_pos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_pd_peak_pos.BackColor = System.Drawing.Color.SteelBlue;
            this.text_pd_peak_pos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pd_peak_pos.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.text_pd_peak_pos.ForeColor = System.Drawing.Color.White;
            this.text_pd_peak_pos.Location = new System.Drawing.Point(496, 44);
            this.text_pd_peak_pos.Multiline = true;
            this.text_pd_peak_pos.Name = "text_pd_peak_pos";
            this.text_pd_peak_pos.ReadOnly = true;
            this.text_pd_peak_pos.Size = new System.Drawing.Size(109, 34);
            this.text_pd_peak_pos.TabIndex = 17;
            this.text_pd_peak_pos.Text = "Peak \r\nPos. [us]";
            // 
            // text_acq_sampling_freq
            // 
            this.text_acq_sampling_freq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_acq_sampling_freq.BackColor = System.Drawing.Color.SteelBlue;
            this.text_acq_sampling_freq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_acq_sampling_freq.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_acq_sampling_freq.ForeColor = System.Drawing.Color.White;
            this.text_acq_sampling_freq.Location = new System.Drawing.Point(4, 9);
            this.text_acq_sampling_freq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_acq_sampling_freq.Name = "text_acq_sampling_freq";
            this.text_acq_sampling_freq.ReadOnly = true;
            this.text_acq_sampling_freq.Size = new System.Drawing.Size(115, 14);
            this.text_acq_sampling_freq.TabIndex = 0;
            this.text_acq_sampling_freq.Text = "Sampling freq";
            this.text_acq_sampling_freq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mode_ctrl
            // 
            this.mode_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mode_ctrl.DisplayMember = "1";
            this.mode_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mode_ctrl.FormattingEnabled = true;
            this.mode_ctrl.Items.AddRange(new object[] {
            "RF",
            "ABS"});
            this.mode_ctrl.Location = new System.Drawing.Point(127, 36);
            this.mode_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mode_ctrl.Name = "mode_ctrl";
            this.mode_ctrl.Size = new System.Drawing.Size(115, 24);
            this.mode_ctrl.TabIndex = 5;
            this.mode_ctrl.ValueMember = "1";
            this.mode_ctrl.SelectedIndexChanged += new System.EventHandler(this.mode_ctrl_SelectedIndexChanged);
            // 
            // window_ctrl
            // 
            this.window_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.window_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.window_ctrl.Location = new System.Drawing.Point(127, 68);
            this.window_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.window_ctrl.MaxLength = 10;
            this.window_ctrl.Name = "window_ctrl";
            this.window_ctrl.Size = new System.Drawing.Size(115, 23);
            this.window_ctrl.TabIndex = 6;
            this.window_ctrl.Text = "100.0";
            this.window_ctrl.TextChanged += new System.EventHandler(this.window_ctrl_TextChanged);
            this.window_ctrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.window_ctrl_KeyDown);
            this.window_ctrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.window_ctrl_KeyPress);
            this.window_ctrl.Leave += new System.EventHandler(this.window_ctrl_Leave);
            // 
            // delay_ctrl
            // 
            this.delay_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.delay_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delay_ctrl.Location = new System.Drawing.Point(127, 100);
            this.delay_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delay_ctrl.MaxLength = 10;
            this.delay_ctrl.Name = "delay_ctrl";
            this.delay_ctrl.Size = new System.Drawing.Size(115, 23);
            this.delay_ctrl.TabIndex = 7;
            this.delay_ctrl.Text = "0.0";
            this.delay_ctrl.TextChanged += new System.EventHandler(this.delay_ctrl_TextChanged);
            this.delay_ctrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.delay_ctrl_KeyDown);
            this.delay_ctrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delay_ctrl_KeyPress);
            this.delay_ctrl.Leave += new System.EventHandler(this.delay_ctrl_Leave);
            // 
            // text_acq_sampling_freq_unit
            // 
            this.text_acq_sampling_freq_unit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_acq_sampling_freq_unit.BackColor = System.Drawing.Color.SteelBlue;
            this.text_acq_sampling_freq_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_acq_sampling_freq_unit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_acq_sampling_freq_unit.ForeColor = System.Drawing.Color.White;
            this.text_acq_sampling_freq_unit.Location = new System.Drawing.Point(250, 8);
            this.text_acq_sampling_freq_unit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_acq_sampling_freq_unit.Name = "text_acq_sampling_freq_unit";
            this.text_acq_sampling_freq_unit.ReadOnly = true;
            this.text_acq_sampling_freq_unit.Size = new System.Drawing.Size(55, 16);
            this.text_acq_sampling_freq_unit.TabIndex = 8;
            this.text_acq_sampling_freq_unit.Text = "MHz";
            // 
            // text_acq_window
            // 
            this.text_acq_window.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_acq_window.BackColor = System.Drawing.Color.SteelBlue;
            this.text_acq_window.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_acq_window.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_acq_window.ForeColor = System.Drawing.Color.White;
            this.text_acq_window.Location = new System.Drawing.Point(4, 73);
            this.text_acq_window.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_acq_window.Name = "text_acq_window";
            this.text_acq_window.ReadOnly = true;
            this.text_acq_window.Size = new System.Drawing.Size(115, 14);
            this.text_acq_window.TabIndex = 2;
            this.text_acq_window.Text = "Depth";
            this.text_acq_window.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pdb_ref_position_ctrl
            // 
            this.pdb_ref_position_ctrl.BackColor = System.Drawing.Color.White;
            this.pdb_ref_position_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdb_ref_position_ctrl.Location = new System.Drawing.Point(265, 120);
            this.pdb_ref_position_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdb_ref_position_ctrl.Name = "pdb_ref_position_ctrl";
            this.pdb_ref_position_ctrl.ReadOnly = true;
            this.pdb_ref_position_ctrl.Size = new System.Drawing.Size(106, 23);
            this.pdb_ref_position_ctrl.TabIndex = 12;
            this.pdb_ref_position_ctrl.Text = "0.0";
            // 
            // text_pd_peak_ampl
            // 
            this.text_pd_peak_ampl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_pd_peak_ampl.BackColor = System.Drawing.Color.SteelBlue;
            this.text_pd_peak_ampl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pd_peak_ampl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.text_pd_peak_ampl.ForeColor = System.Drawing.Color.White;
            this.text_pd_peak_ampl.Location = new System.Drawing.Point(380, 44);
            this.text_pd_peak_ampl.Multiline = true;
            this.text_pd_peak_ampl.Name = "text_pd_peak_ampl";
            this.text_pd_peak_ampl.ReadOnly = true;
            this.text_pd_peak_ampl.Size = new System.Drawing.Size(109, 34);
            this.text_pd_peak_ampl.TabIndex = 18;
            this.text_pd_peak_ampl.Text = "Peak \r\nAmpl. [V]";
            // 
            // acq_groupbox
            // 
            this.acq_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.acq_groupbox.Controls.Add(this.acq_table);
            this.acq_groupbox.ForeColor = System.Drawing.Color.White;
            this.acq_groupbox.Location = new System.Drawing.Point(1026, 10);
            this.acq_groupbox.Name = "acq_groupbox";
            this.acq_groupbox.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.acq_groupbox.Size = new System.Drawing.Size(326, 180);
            this.acq_groupbox.TabIndex = 27;
            this.acq_groupbox.TabStop = false;
            this.acq_groupbox.Text = "Acquisition Parameters";
            // 
            // acq_table
            // 
            this.acq_table.ColumnCount = 3;
            this.acq_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.acq_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.acq_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.acq_table.Controls.Add(this.txt_plot_algorithm_title, 0, 4);
            this.acq_table.Controls.Add(this.text_acq_sampling_freq, 0, 0);
            this.acq_table.Controls.Add(this.text_acq_mode, 0, 1);
            this.acq_table.Controls.Add(this.text_acq_delay_unit, 2, 3);
            this.acq_table.Controls.Add(this.text_acq_delay, 0, 3);
            this.acq_table.Controls.Add(this.text_acq_window_unit, 2, 2);
            this.acq_table.Controls.Add(this.sampling_freq_ctrl, 1, 0);
            this.acq_table.Controls.Add(this.mode_ctrl, 1, 1);
            this.acq_table.Controls.Add(this.window_ctrl, 1, 2);
            this.acq_table.Controls.Add(this.delay_ctrl, 1, 3);
            this.acq_table.Controls.Add(this.text_acq_sampling_freq_unit, 2, 0);
            this.acq_table.Controls.Add(this.text_acq_window, 0, 2);
            this.acq_table.Controls.Add(this.plot_algorithm_ctrl, 1, 4);
            this.acq_table.Location = new System.Drawing.Point(10, 15);
            this.acq_table.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.acq_table.Name = "acq_table";
            this.acq_table.RowCount = 5;
            this.acq_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.acq_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.acq_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.acq_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.acq_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.acq_table.Size = new System.Drawing.Size(309, 160);
            this.acq_table.TabIndex = 0;
            // 
            // plot_algorithm_ctrl
            // 
            this.plot_algorithm_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.plot_algorithm_ctrl.DisplayMember = "1";
            this.plot_algorithm_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plot_algorithm_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plot_algorithm_ctrl.FormattingEnabled = true;
            this.plot_algorithm_ctrl.Items.AddRange(new object[] {
            "Averaging",
            "Extremes"});
            this.plot_algorithm_ctrl.Location = new System.Drawing.Point(127, 132);
            this.plot_algorithm_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plot_algorithm_ctrl.Name = "plot_algorithm_ctrl";
            this.plot_algorithm_ctrl.Size = new System.Drawing.Size(115, 24);
            this.plot_algorithm_ctrl.TabIndex = 14;
            this.plot_algorithm_ctrl.ValueMember = "1";
            // 
            // pd_groupbox
            // 
            this.pd_groupbox.Controls.Add(this.pd_table);
            this.pd_groupbox.ForeColor = System.Drawing.Color.White;
            this.pd_groupbox.Location = new System.Drawing.Point(45, 452);
            this.pd_groupbox.Name = "pd_groupbox";
            this.pd_groupbox.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.pd_groupbox.Size = new System.Drawing.Size(624, 210);
            this.pd_groupbox.TabIndex = 26;
            this.pd_groupbox.TabStop = false;
            this.pd_groupbox.Text = "Peak Detectors";
            // 
            // pd_table
            // 
            this.pd_table.BackColor = System.Drawing.Color.Transparent;
            this.pd_table.ColumnCount = 5;
            this.pd_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.pd_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.pd_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.pd_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.pd_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.pd_table.Controls.Add(this.pdc_mode_ctrl, 1, 4);
            this.pd_table.Controls.Add(this.pdc_peak_position_ctrl, 4, 4);
            this.pd_table.Controls.Add(this.pdb_mode_ctrl, 1, 3);
            this.pd_table.Controls.Add(this.pdc_enable_ctrl, 0, 4);
            this.pd_table.Controls.Add(this.pdb_peak_position_ctrl, 4, 3);
            this.pd_table.Controls.Add(this.pdb_enable_ctrl, 0, 3);
            this.pd_table.Controls.Add(this.pda_peak_position_ctrl, 4, 2);
            this.pd_table.Controls.Add(this.pda_enable_ctrl, 0, 2);
            this.pd_table.Controls.Add(this.pda_mode_ctrl, 1, 2);
            this.pd_table.Controls.Add(this.pdc_ref_position_ctrl, 2, 4);
            this.pd_table.Controls.Add(this.pdb_ref_position_ctrl, 2, 3);
            this.pd_table.Controls.Add(this.pda_ref_position_ctrl, 2, 2);
            this.pd_table.Controls.Add(this.pdc_peak_amplitude_ctrl, 3, 4);
            this.pd_table.Controls.Add(this.pdb_peak_amplitude_ctrl, 3, 3);
            this.pd_table.Controls.Add(this.pda_peak_amplitude_ctrl, 3, 2);
            this.pd_table.Controls.Add(this.text_pd_mode, 1, 1);
            this.pd_table.Controls.Add(this.text_pd_peak_pos, 4, 1);
            this.pd_table.Controls.Add(this.text_pd_peak_ampl, 3, 1);
            this.pd_table.Controls.Add(this.text_pd_ref_pos, 2, 1);
            this.pd_table.Controls.Add(this.text_pd_results, 3, 0);
            this.pd_table.Location = new System.Drawing.Point(6, 15);
            this.pd_table.Name = "pd_table";
            this.pd_table.RowCount = 5;
            this.pd_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.9919F));
            this.pd_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.02672F));
            this.pd_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.9938F));
            this.pd_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.9938F));
            this.pd_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.9938F));
            this.pd_table.Size = new System.Drawing.Size(613, 190);
            this.pd_table.TabIndex = 6;
            // 
            // text_pd_ref_pos
            // 
            this.text_pd_ref_pos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_pd_ref_pos.BackColor = System.Drawing.Color.SteelBlue;
            this.text_pd_ref_pos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pd_ref_pos.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.text_pd_ref_pos.ForeColor = System.Drawing.Color.White;
            this.text_pd_ref_pos.Location = new System.Drawing.Point(264, 44);
            this.text_pd_ref_pos.Multiline = true;
            this.text_pd_ref_pos.Name = "text_pd_ref_pos";
            this.text_pd_ref_pos.ReadOnly = true;
            this.text_pd_ref_pos.Size = new System.Drawing.Size(109, 34);
            this.text_pd_ref_pos.TabIndex = 19;
            this.text_pd_ref_pos.Text = "Reference Pos. [us]";
            // 
            // text_pd_results
            // 
            this.text_pd_results.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_pd_results.BackColor = System.Drawing.Color.SteelBlue;
            this.text_pd_results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pd_results.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.text_pd_results.ForeColor = System.Drawing.Color.White;
            this.text_pd_results.Location = new System.Drawing.Point(380, 11);
            this.text_pd_results.Name = "text_pd_results";
            this.text_pd_results.ReadOnly = true;
            this.text_pd_results.Size = new System.Drawing.Size(109, 22);
            this.text_pd_results.TabIndex = 20;
            this.text_pd_results.Text = "RESULTS:";
            // 
            // ampl_groupbox
            // 
            this.ampl_groupbox.Controls.Add(this.ampl_table);
            this.ampl_groupbox.ForeColor = System.Drawing.Color.White;
            this.ampl_groupbox.Location = new System.Drawing.Point(1026, 210);
            this.ampl_groupbox.Name = "ampl_groupbox";
            this.ampl_groupbox.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.ampl_groupbox.Size = new System.Drawing.Size(326, 220);
            this.ampl_groupbox.TabIndex = 30;
            this.ampl_groupbox.TabStop = false;
            this.ampl_groupbox.Text = "Amplifiers Parameters";
            // 
            // ampl_table
            // 
            this.ampl_table.BackColor = System.Drawing.Color.Transparent;
            this.ampl_table.ColumnCount = 3;
            this.ampl_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ampl_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ampl_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ampl_table.Controls.Add(this.gain_mode_ctrl, 1, 4);
            this.ampl_table.Controls.Add(this.text_ampl_filter_bandtwidth_unit, 2, 0);
            this.ampl_table.Controls.Add(this.input_source_ctrl, 1, 2);
            this.ampl_table.Controls.Add(this.preamplifier_ctrl, 1, 1);
            this.ampl_table.Controls.Add(this.filter_bandtwidth_ctrl, 1, 0);
            this.ampl_table.Controls.Add(this.gain_ctrl, 1, 3);
            this.ampl_table.Controls.Add(this.text_ampl_gain_mode, 0, 4);
            this.ampl_table.Controls.Add(this.text_ampl_filter_bandtwidth, 0, 0);
            this.ampl_table.Controls.Add(this.text_ampl_preamplifier, 0, 1);
            this.ampl_table.Controls.Add(this.text_ampl_input_source, 0, 2);
            this.ampl_table.Controls.Add(this.text_ampl_gain, 0, 3);
            this.ampl_table.Controls.Add(this.text_ampl_gain_unit, 2, 3);
            this.ampl_table.Location = new System.Drawing.Point(10, 15);
            this.ampl_table.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ampl_table.Name = "ampl_table";
            this.ampl_table.RowCount = 5;
            this.ampl_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ampl_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ampl_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ampl_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ampl_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ampl_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ampl_table.Size = new System.Drawing.Size(309, 200);
            this.ampl_table.TabIndex = 1;
            // 
            // gain_mode_ctrl
            // 
            this.gain_mode_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gain_mode_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gain_mode_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gain_mode_ctrl.FormattingEnabled = true;
            this.gain_mode_ctrl.Items.AddRange(new object[] {
            "CONST",
            "TGC"});
            this.gain_mode_ctrl.Location = new System.Drawing.Point(127, 168);
            this.gain_mode_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gain_mode_ctrl.Name = "gain_mode_ctrl";
            this.gain_mode_ctrl.Size = new System.Drawing.Size(115, 24);
            this.gain_mode_ctrl.TabIndex = 12;
            this.gain_mode_ctrl.SelectedIndexChanged += new System.EventHandler(this.gain_mode_ctrl_SelectedIndexChanged);
            // 
            // text_ampl_filter_bandtwidth_unit
            // 
            this.text_ampl_filter_bandtwidth_unit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_ampl_filter_bandtwidth_unit.BackColor = System.Drawing.Color.SteelBlue;
            this.text_ampl_filter_bandtwidth_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ampl_filter_bandtwidth_unit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_ampl_filter_bandtwidth_unit.ForeColor = System.Drawing.Color.White;
            this.text_ampl_filter_bandtwidth_unit.Location = new System.Drawing.Point(250, 12);
            this.text_ampl_filter_bandtwidth_unit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_ampl_filter_bandtwidth_unit.Name = "text_ampl_filter_bandtwidth_unit";
            this.text_ampl_filter_bandtwidth_unit.ReadOnly = true;
            this.text_ampl_filter_bandtwidth_unit.Size = new System.Drawing.Size(55, 16);
            this.text_ampl_filter_bandtwidth_unit.TabIndex = 9;
            this.text_ampl_filter_bandtwidth_unit.Text = "MHz";
            // 
            // input_source_ctrl
            // 
            this.input_source_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.input_source_ctrl.DisplayMember = "1";
            this.input_source_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_source_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_source_ctrl.FormattingEnabled = true;
            this.input_source_ctrl.Items.AddRange(new object[] {
            "PE",
            "TT"});
            this.input_source_ctrl.Location = new System.Drawing.Point(127, 88);
            this.input_source_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.input_source_ctrl.Name = "input_source_ctrl";
            this.input_source_ctrl.Size = new System.Drawing.Size(115, 24);
            this.input_source_ctrl.TabIndex = 13;
            this.input_source_ctrl.ValueMember = "1";
            this.input_source_ctrl.SelectedIndexChanged += new System.EventHandler(this.input_source_ctrl_SelectedIndexChanged);
            // 
            // preamplifier_ctrl
            // 
            this.preamplifier_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.preamplifier_ctrl.DisplayMember = "1";
            this.preamplifier_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.preamplifier_ctrl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.preamplifier_ctrl.FormattingEnabled = true;
            this.preamplifier_ctrl.Items.AddRange(new object[] {
            "0 dB",
            "+24 dB",
            "-20 dB"});
            this.preamplifier_ctrl.Location = new System.Drawing.Point(127, 47);
            this.preamplifier_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.preamplifier_ctrl.Name = "preamplifier_ctrl";
            this.preamplifier_ctrl.Size = new System.Drawing.Size(115, 24);
            this.preamplifier_ctrl.TabIndex = 14;
            this.preamplifier_ctrl.ValueMember = "1";
            this.preamplifier_ctrl.SelectedIndexChanged += new System.EventHandler(this.preamplifier_ctrl_SelectedIndexChanged);
            // 
            // filter_bandtwidth_ctrl
            // 
            this.filter_bandtwidth_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filter_bandtwidth_ctrl.DisplayMember = "1";
            this.filter_bandtwidth_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_bandtwidth_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filter_bandtwidth_ctrl.FormattingEnabled = true;
            this.filter_bandtwidth_ctrl.Items.AddRange(new object[] {
            "0.5 - 6",
            "0.5 - 10",
            "0.5 - 15",
            "0.5 - 25",
            "1 - 6",
            "1 - 10",
            "1 - 15",
            "1 - 25",
            "2 - 6",
            "2 - 10",
            "2 - 15",
            "2 - 25",
            "4 - 6",
            "4 - 10",
            "4 - 15",
            "4 - 25"});
            this.filter_bandtwidth_ctrl.Location = new System.Drawing.Point(127, 8);
            this.filter_bandtwidth_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.filter_bandtwidth_ctrl.Name = "filter_bandtwidth_ctrl";
            this.filter_bandtwidth_ctrl.Size = new System.Drawing.Size(115, 24);
            this.filter_bandtwidth_ctrl.TabIndex = 15;
            this.filter_bandtwidth_ctrl.ValueMember = "1";
            this.filter_bandtwidth_ctrl.SelectedIndexChanged += new System.EventHandler(this.filter_bandtwidth_ctrl_SelectedIndexChanged);
            // 
            // gain_ctrl
            // 
            this.gain_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gain_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gain_ctrl.Location = new System.Drawing.Point(127, 128);
            this.gain_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gain_ctrl.Name = "gain_ctrl";
            this.gain_ctrl.Size = new System.Drawing.Size(115, 23);
            this.gain_ctrl.TabIndex = 12;
            this.gain_ctrl.Text = "35";
            this.gain_ctrl.TextChanged += new System.EventHandler(this.gain_ctrl_TextChanged);
            this.gain_ctrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gain_ctrl_KeyDown);
            this.gain_ctrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gain_ctrl_KeyPress);
            this.gain_ctrl.Leave += new System.EventHandler(this.gain_ctrl_Leave);
            // 
            // text_ampl_gain_mode
            // 
            this.text_ampl_gain_mode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_ampl_gain_mode.BackColor = System.Drawing.Color.SteelBlue;
            this.text_ampl_gain_mode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ampl_gain_mode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_ampl_gain_mode.ForeColor = System.Drawing.Color.White;
            this.text_ampl_gain_mode.Location = new System.Drawing.Point(4, 173);
            this.text_ampl_gain_mode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_ampl_gain_mode.Name = "text_ampl_gain_mode";
            this.text_ampl_gain_mode.ReadOnly = true;
            this.text_ampl_gain_mode.Size = new System.Drawing.Size(115, 14);
            this.text_ampl_gain_mode.TabIndex = 5;
            this.text_ampl_gain_mode.Text = "Gain mode";
            this.text_ampl_gain_mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_exit.FlatAppearance.BorderSize = 3;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(483, 672);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(116, 76);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Lime;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_start.FlatAppearance.BorderSize = 3;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_start.ForeColor = System.Drawing.Color.Black;
            this.btn_start.Location = new System.Drawing.Point(45, 672);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(186, 76);
            this.btn_start.TabIndex = 24;
            this.btn_start.Text = "RUNNING...";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // main_chart
            // 
            this.main_chart.BackColor = System.Drawing.Color.SteelBlue;
            this.main_chart.BorderlineWidth = 0;
            this.main_chart.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.main_chart.Cursor = System.Windows.Forms.Cursors.Default;
            this.main_chart.Location = new System.Drawing.Point(10, 9);
            this.main_chart.Margin = new System.Windows.Forms.Padding(0);
            this.main_chart.Name = "main_chart";
            this.main_chart.Size = new System.Drawing.Size(1014, 440);
            this.main_chart.TabIndex = 23;
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.DockingOffset = 10;
            title1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "pe_plot_title";
            title1.Position.Auto = false;
            title1.Position.Height = 5.456821F;
            title1.Position.Width = 90F;
            title1.Position.X = 10F;
            title1.Text = "A-Scan in PE mode";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.DockingOffset = 10;
            title2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.Name = "tt_plot_title";
            title2.Position.Auto = false;
            title2.Position.Height = 5.456821F;
            title2.Position.Width = 90F;
            title2.Position.X = 10F;
            title2.Text = "A-Scan in TT mode";
            this.main_chart.Titles.Add(title1);
            this.main_chart.Titles.Add(title2);
            this.main_chart.Click += new System.EventHandler(this.main_chart_Click);
            this.main_chart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_chart_MouseDown);
            this.main_chart.MouseLeave += new System.EventHandler(this.main_chart_MouseLeave);
            this.main_chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_chart_MouseMove);
            this.main_chart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.main_chart_MouseUp);
            // 
            // puls_groupbox
            // 
            this.puls_groupbox.Controls.Add(this.puls_table);
            this.puls_groupbox.ForeColor = System.Drawing.Color.White;
            this.puls_groupbox.Location = new System.Drawing.Point(1026, 452);
            this.puls_groupbox.Name = "puls_groupbox";
            this.puls_groupbox.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.puls_groupbox.Size = new System.Drawing.Size(325, 100);
            this.puls_groupbox.TabIndex = 29;
            this.puls_groupbox.TabStop = false;
            this.puls_groupbox.Text = "Pulser Parameters";
            // 
            // puls_table
            // 
            this.puls_table.BackColor = System.Drawing.Color.Transparent;
            this.puls_table.ColumnCount = 3;
            this.puls_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.puls_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.puls_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.puls_table.Controls.Add(this.charging_time_ctrl, 1, 1);
            this.puls_table.Controls.Add(this.amplitude_level_ctrl, 1, 0);
            this.puls_table.Controls.Add(this.text_puls_amplitude_level, 0, 0);
            this.puls_table.Controls.Add(this.text_puls_charging_time, 0, 1);
            this.puls_table.Controls.Add(this.text_puls_charging_time_unit, 2, 1);
            this.puls_table.Location = new System.Drawing.Point(10, 15);
            this.puls_table.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.puls_table.Name = "puls_table";
            this.puls_table.RowCount = 2;
            this.puls_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.puls_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.puls_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.puls_table.Size = new System.Drawing.Size(309, 80);
            this.puls_table.TabIndex = 12;
            // 
            // charging_time_ctrl
            // 
            this.charging_time_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.charging_time_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charging_time_ctrl.Location = new System.Drawing.Point(127, 48);
            this.charging_time_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.charging_time_ctrl.MaxLength = 6;
            this.charging_time_ctrl.Name = "charging_time_ctrl";
            this.charging_time_ctrl.Size = new System.Drawing.Size(115, 23);
            this.charging_time_ctrl.TabIndex = 13;
            this.charging_time_ctrl.Text = "6.3";
            this.charging_time_ctrl.TextChanged += new System.EventHandler(this.charging_time_ctrl_TextChanged);
            this.charging_time_ctrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.charging_time_ctrl_KeyDown);
            this.charging_time_ctrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.charging_time_ctrl_KeyPress);
            this.charging_time_ctrl.Leave += new System.EventHandler(this.charging_time_ctrl_Leave);
            // 
            // amplitude_level_ctrl
            // 
            this.amplitude_level_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amplitude_level_ctrl.DisplayMember = "1";
            this.amplitude_level_ctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amplitude_level_ctrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amplitude_level_ctrl.FormattingEnabled = true;
            this.amplitude_level_ctrl.Items.AddRange(new object[] {
            "Level 0",
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Level 9",
            "Level 10",
            "Level 11",
            "Level 12",
            "Level 13",
            "Level 14",
            "Level 15",
            "Level 16"});
            this.amplitude_level_ctrl.Location = new System.Drawing.Point(127, 8);
            this.amplitude_level_ctrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.amplitude_level_ctrl.Name = "amplitude_level_ctrl";
            this.amplitude_level_ctrl.Size = new System.Drawing.Size(115, 24);
            this.amplitude_level_ctrl.TabIndex = 14;
            this.amplitude_level_ctrl.ValueMember = "1";
            this.amplitude_level_ctrl.SelectedIndexChanged += new System.EventHandler(this.amplitude_level_ctrl_SelectedIndexChanged);
            // 
            // text_puls_amplitude_level
            // 
            this.text_puls_amplitude_level.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_puls_amplitude_level.BackColor = System.Drawing.Color.SteelBlue;
            this.text_puls_amplitude_level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_puls_amplitude_level.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.text_puls_amplitude_level.ForeColor = System.Drawing.Color.White;
            this.text_puls_amplitude_level.Location = new System.Drawing.Point(4, 14);
            this.text_puls_amplitude_level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_puls_amplitude_level.Name = "text_puls_amplitude_level";
            this.text_puls_amplitude_level.ReadOnly = true;
            this.text_puls_amplitude_level.Size = new System.Drawing.Size(115, 12);
            this.text_puls_amplitude_level.TabIndex = 2;
            this.text_puls_amplitude_level.Text = "Amplitude level";
            this.text_puls_amplitude_level.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_puls_charging_time
            // 
            this.text_puls_charging_time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_puls_charging_time.BackColor = System.Drawing.Color.SteelBlue;
            this.text_puls_charging_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_puls_charging_time.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_puls_charging_time.ForeColor = System.Drawing.Color.White;
            this.text_puls_charging_time.Location = new System.Drawing.Point(4, 53);
            this.text_puls_charging_time.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_puls_charging_time.Name = "text_puls_charging_time";
            this.text_puls_charging_time.ReadOnly = true;
            this.text_puls_charging_time.Size = new System.Drawing.Size(115, 14);
            this.text_puls_charging_time.TabIndex = 4;
            this.text_puls_charging_time.Text = "Charging time";
            this.text_puls_charging_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_puls_charging_time_unit
            // 
            this.text_puls_charging_time_unit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_puls_charging_time_unit.BackColor = System.Drawing.Color.SteelBlue;
            this.text_puls_charging_time_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_puls_charging_time_unit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_puls_charging_time_unit.ForeColor = System.Drawing.Color.White;
            this.text_puls_charging_time_unit.Location = new System.Drawing.Point(250, 52);
            this.text_puls_charging_time_unit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_puls_charging_time_unit.Name = "text_puls_charging_time_unit";
            this.text_puls_charging_time_unit.ReadOnly = true;
            this.text_puls_charging_time_unit.Size = new System.Drawing.Size(55, 16);
            this.text_puls_charging_time_unit.TabIndex = 14;
            this.text_puls_charging_time_unit.Text = "us";
            // 
            // pict_logo
            // 
            this.pict_logo.Image = ((System.Drawing.Image)(resources.GetObject("pict_logo.Image")));
            this.pict_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pict_logo.InitialImage")));
            this.pict_logo.Location = new System.Drawing.Point(241, 672);
            this.pict_logo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pict_logo.Name = "pict_logo";
            this.pict_logo.Size = new System.Drawing.Size(234, 76);
            this.pict_logo.TabIndex = 22;
            this.pict_logo.TabStop = false;
            // 
            // Sensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 761);
            this.Controls.Add(this.test_panel);
            this.Controls.Add(this.test_mode_txt);
            this.Controls.Add(this.test_mode_btn);
            this.Controls.Add(this.fps_display);
            this.Controls.Add(this.err_display);
            this.Controls.Add(this.fps_txt);
            this.Controls.Add(this.err_txt);
            this.Controls.Add(this.info_disp_ctrl);
            this.Controls.Add(this.enc_groupbox);
            this.Controls.Add(this.trig_groupbox);
            this.Controls.Add(this.acq_groupbox);
            this.Controls.Add(this.pd_groupbox);
            this.Controls.Add(this.ampl_groupbox);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.main_chart);
            this.Controls.Add(this.puls_groupbox);
            this.Controls.Add(this.pict_logo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Sensor";
            this.Text = "Sensor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sensor_FormClosing);
            this.Load += new System.EventHandler(this.Sensor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sensor_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Sensor_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sensor_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sensor_MouseUp);
            this.test_table.ResumeLayout(false);
            this.test_table.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.test_panel.ResumeLayout(false);
            this.test_panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.enc_table.ResumeLayout(false);
            this.enc_table.PerformLayout();
            this.enc_groupbox.ResumeLayout(false);
            this.trig_groupbox.ResumeLayout(false);
            this.trig_table.ResumeLayout(false);
            this.trig_table.PerformLayout();
            this.acq_groupbox.ResumeLayout(false);
            this.acq_table.ResumeLayout(false);
            this.acq_table.PerformLayout();
            this.pd_groupbox.ResumeLayout(false);
            this.pd_table.ResumeLayout(false);
            this.pd_table.PerformLayout();
            this.ampl_groupbox.ResumeLayout(false);
            this.ampl_table.ResumeLayout(false);
            this.ampl_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_chart)).EndInit();
            this.puls_groupbox.ResumeLayout(false);
            this.puls_table.ResumeLayout(false);
            this.puls_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_ampl_preamplifier;
        private System.Windows.Forms.TableLayoutPanel test_table;
        private System.Windows.Forms.TextBox txt_pd_test_title;
        private System.Windows.Forms.TextBox txt_encb_test_title;
        private System.Windows.Forms.TextBox txt_enca_test_title;
        private System.Windows.Forms.Label amplitude_level_test;
        private System.Windows.Forms.Label source_test;
        private System.Windows.Forms.Label ampl_test;
        private System.Windows.Forms.TextBox txt_analog_test_title;
        private System.Windows.Forms.TextBox txt_ampl_test_title;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label filter_test;
        private System.Windows.Forms.TextBox txt_depth_test_title;
        private System.Windows.Forms.TextBox txt_ampl_lvl_test_title;
        private System.Windows.Forms.Label enca_test;
        private System.Windows.Forms.Label encb_test;
        private System.Windows.Forms.TextBox txt_delay_test_title;
        private System.Windows.Forms.Label pd_txt;
        private System.Windows.Forms.Label delay_test;
        private System.Windows.Forms.Label window_test;
        private System.Windows.Forms.Label pda_test_detection;
        private System.Windows.Forms.Label pdb_test_detection;
        private System.Windows.Forms.Label pdc_test_detection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox test_panel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label pdc_test_x2_plot;
        private System.Windows.Forms.Label pdb_test_x2_plot;
        private System.Windows.Forms.Label pda_test_x2_plot;
        private System.Windows.Forms.Label pdc_test_x1_plot;
        private System.Windows.Forms.Label pdb_test_x1_plot;
        private System.Windows.Forms.Label pda_test_x1_plot;
        private System.Windows.Forms.Label pdc_test_y_plot;
        private System.Windows.Forms.Label pdb_test_y_plot;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label pda_test_y_plot;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label pdc_test_max_opbox;
        private System.Windows.Forms.Label pdb_test_max_opbox;
        private System.Windows.Forms.Label pda_test_max_opbox;
        private System.Windows.Forms.Label pdc_test_min_opbox;
        private System.Windows.Forms.Label pdb_test_min_opbox;
        private System.Windows.Forms.Label pda_test_min_opbox;
        private System.Windows.Forms.Label pdc_test_level_opbox;
        private System.Windows.Forms.Label pdb_test_level_opbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label pda_test_level_opbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox test_mode_txt;
        private System.Windows.Forms.Button test_mode_btn;
        private System.Windows.Forms.Timer err_timer;
        private System.Windows.Forms.Timer power_ctrl_timer;
        private System.Windows.Forms.Timer enc_results_timer;
        private System.Windows.Forms.Timer pd_results_timer;
        private System.ComponentModel.BackgroundWorker data_bgworker;
        private System.ComponentModel.BackgroundWorker pd_disp_bgworker;
        private System.Windows.Forms.TextBox fps_display;
        private System.Windows.Forms.TextBox err_display;
        private System.Windows.Forms.TextBox fps_txt;
        private System.Windows.Forms.TextBox err_txt;
        private System.Windows.Forms.Timer pd_timer;
        private System.Windows.Forms.Timer fps_timer;
        private System.Windows.Forms.Timer plot_timer;
        private System.ComponentModel.BackgroundWorker plot_bgworker;
        private System.Windows.Forms.TextBox info_disp_ctrl;
        private System.Windows.Forms.TableLayoutPanel enc_table;
        private System.Windows.Forms.TextBox reset_btn_txt;
        private System.Windows.Forms.Button encb_reset_btn;
        private System.Windows.Forms.ComboBox encb_filter_ctrl;
        private System.Windows.Forms.ComboBox encb_decode_mode_ctrl;
        private System.Windows.Forms.ComboBox encb_idx_input_ctrl;
        private System.Windows.Forms.ComboBox enca_filter_ctrl;
        private System.Windows.Forms.ComboBox enca_decode_mode_ctrl;
        private System.Windows.Forms.ComboBox enca_idx_input_ctrl;
        private System.Windows.Forms.ComboBox encb_input_mode_ctrl;
        private System.Windows.Forms.TextBox text_enc_comparator;
        private System.Windows.Forms.TextBox text_enc_comp_step;
        private System.Windows.Forms.TextBox text_enc_filter;
        private System.Windows.Forms.TextBox text_enc_decode_mode;
        private System.Windows.Forms.TextBox text_enc_idx_input;
        private System.Windows.Forms.TextBox text_enc_input_mode;
        private System.Windows.Forms.ComboBox enca_input_mode_ctrl;
        private System.Windows.Forms.CheckBox enca_enable_ctrl;
        private System.Windows.Forms.CheckBox encb_enable_ctrl;
        private System.Windows.Forms.ComboBox enca_comparator_ctrl;
        private System.Windows.Forms.TextBox enca_comparator_step_ctrl;
        private System.Windows.Forms.ComboBox encb_comparator_ctrl;
        private System.Windows.Forms.TextBox encb_comparator_step_ctrl;
        private System.Windows.Forms.Button enca_reset_btn;
        private System.Windows.Forms.GroupBox enc_groupbox;
        private System.Windows.Forms.TextBox text_ampl_input_source;
        private System.Windows.Forms.TextBox text_ampl_gain;
        private System.Windows.Forms.TextBox text_ampl_gain_unit;
        private System.Windows.Forms.TextBox text_ampl_filter_bandtwidth;
        private System.Windows.Forms.TextBox txt_plot_algorithm_title;
        private System.Windows.Forms.TextBox text_acq_mode;
        private System.Windows.Forms.TextBox text_acq_delay_unit;
        private System.Windows.Forms.TextBox text_acq_delay;
        private System.Windows.Forms.TextBox text_acq_window_unit;
        private System.Windows.Forms.ComboBox pdc_mode_ctrl;
        private System.Windows.Forms.TextBox pdc_peak_position_ctrl;
        private System.Windows.Forms.GroupBox trig_groupbox;
        private System.Windows.Forms.TableLayoutPanel trig_table;
        private System.Windows.Forms.ComboBox xy_divider_ctrl;
        private System.Windows.Forms.ComboBox trigger_source_ctrl;
        private System.Windows.Forms.TextBox text_trig_trigger_source;
        private System.Windows.Forms.TextBox text_trig_timer_period;
        private System.Windows.Forms.TextBox text_trig_xy_divider;
        private System.Windows.Forms.TextBox text_trig_timer_unit;
        private System.Windows.Forms.TextBox timer_period_ctrl;
        private System.Windows.Forms.ComboBox pdb_mode_ctrl;
        private System.Windows.Forms.CheckBox pdc_enable_ctrl;
        private System.Windows.Forms.TextBox pdb_peak_position_ctrl;
        private System.Windows.Forms.CheckBox pdb_enable_ctrl;
        private System.Windows.Forms.TextBox pda_peak_position_ctrl;
        private System.Windows.Forms.CheckBox pda_enable_ctrl;
        private System.Windows.Forms.ComboBox pda_mode_ctrl;
        private System.Windows.Forms.ComboBox sampling_freq_ctrl;
        private System.Windows.Forms.TextBox pdc_ref_position_ctrl;
        private System.Windows.Forms.TextBox pda_ref_position_ctrl;
        private System.Windows.Forms.TextBox pdc_peak_amplitude_ctrl;
        private System.Windows.Forms.TextBox pdb_peak_amplitude_ctrl;
        private System.Windows.Forms.TextBox pda_peak_amplitude_ctrl;
        private System.Windows.Forms.TextBox text_pd_mode;
        private System.Windows.Forms.TextBox text_pd_peak_pos;
        private System.Windows.Forms.TextBox text_acq_sampling_freq;
        private System.Windows.Forms.ComboBox mode_ctrl;
        private System.Windows.Forms.TextBox window_ctrl;
        private System.Windows.Forms.TextBox delay_ctrl;
        private System.Windows.Forms.TextBox text_acq_sampling_freq_unit;
        private System.Windows.Forms.TextBox text_acq_window;
        private System.Windows.Forms.TextBox pdb_ref_position_ctrl;
        private System.Windows.Forms.TextBox text_pd_peak_ampl;
        private System.Windows.Forms.GroupBox acq_groupbox;
        private System.Windows.Forms.TableLayoutPanel acq_table;
        private System.Windows.Forms.ComboBox plot_algorithm_ctrl;
        private System.Windows.Forms.GroupBox pd_groupbox;
        private System.Windows.Forms.TableLayoutPanel pd_table;
        private System.Windows.Forms.TextBox text_pd_ref_pos;
        private System.Windows.Forms.TextBox text_pd_results;
        private System.Windows.Forms.GroupBox ampl_groupbox;
        private System.Windows.Forms.TableLayoutPanel ampl_table;
        private System.Windows.Forms.ComboBox gain_mode_ctrl;
        private System.Windows.Forms.TextBox text_ampl_filter_bandtwidth_unit;
        private System.Windows.Forms.ComboBox input_source_ctrl;
        private System.Windows.Forms.ComboBox preamplifier_ctrl;
        private System.Windows.Forms.ComboBox filter_bandtwidth_ctrl;
        private System.Windows.Forms.TextBox gain_ctrl;
        private System.Windows.Forms.TextBox text_ampl_gain_mode;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.DataVisualization.Charting.Chart main_chart;
        private System.Windows.Forms.GroupBox puls_groupbox;
        private System.Windows.Forms.TableLayoutPanel puls_table;
        private System.Windows.Forms.TextBox charging_time_ctrl;
        private System.Windows.Forms.ComboBox amplitude_level_ctrl;
        private System.Windows.Forms.TextBox text_puls_amplitude_level;
        private System.Windows.Forms.TextBox text_puls_charging_time;
        private System.Windows.Forms.TextBox text_puls_charging_time_unit;
        private System.Windows.Forms.PictureBox pict_logo;
    }
}