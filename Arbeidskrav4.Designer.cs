namespace Arbeidskrav1
{
    partial class Arbeidskrav4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.save_db = new System.Windows.Forms.Button();
            this.monit_light = new System.Windows.Forms.TextBox();
            this.monit_status = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.read_readings_box = new System.Windows.Forms.TextBox();
            this.read_status_text = new System.Windows.Forms.TextBox();
            this.reading_txt = new System.Windows.Forms.TextBox();
            this.readraw_file = new System.Windows.Forms.Button();
            this.read_status_btn = new System.Windows.Forms.Button();
            this.readscaled_file = new System.Windows.Forms.Button();
            this.save_readings = new System.Windows.Forms.Button();
            this.test_scaled = new System.Windows.Forms.Button();
            this.stop_monit = new System.Windows.Forms.Button();
            this.tst_monit = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.import_config_button = new System.Windows.Forms.Button();
            this.config_status = new System.Windows.Forms.TextBox();
            this.confi_light = new System.Windows.Forms.TextBox();
            this.alarmh_textBox8 = new System.Windows.Forms.TextBox();
            this.alarml_textBox7 = new System.Windows.Forms.TextBox();
            this.urv_textBox6 = new System.Windows.Forms.TextBox();
            this.lrv_textBox5 = new System.Windows.Forms.TextBox();
            this.readpar_textBox3 = new System.Windows.Forms.TextBox();
            this.name_textBox2 = new System.Windows.Forms.TextBox();
            this.clearconfig_button = new System.Windows.Forms.Button();
            this.writeconfig1_button = new System.Windows.Forms.Button();
            this.viewconf_button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.readpar_button2 = new System.Windows.Forms.Button();
            this.savepar_button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sc_status_box = new System.Windows.Forms.TextBox();
            this.sc_statuslight = new System.Windows.Forms.TextBox();
            this.send_textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cleardata_button = new System.Windows.Forms.Button();
            this.send_button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.discon_button = new System.Windows.Forms.Button();
            this.bitrate_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comport_combobox = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.database_status = new System.Windows.Forms.TextBox();
            this.database_ligt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save_scaled = new System.Windows.Forms.Button();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.save_scaled);
            this.tabPage4.Controls.Add(this.save_db);
            this.tabPage4.Controls.Add(this.monit_light);
            this.tabPage4.Controls.Add(this.monit_status);
            this.tabPage4.Controls.Add(this.clear_button);
            this.tabPage4.Controls.Add(this.read_readings_box);
            this.tabPage4.Controls.Add(this.read_status_text);
            this.tabPage4.Controls.Add(this.reading_txt);
            this.tabPage4.Controls.Add(this.readraw_file);
            this.tabPage4.Controls.Add(this.read_status_btn);
            this.tabPage4.Controls.Add(this.readscaled_file);
            this.tabPage4.Controls.Add(this.save_readings);
            this.tabPage4.Controls.Add(this.test_scaled);
            this.tabPage4.Controls.Add(this.stop_monit);
            this.tabPage4.Controls.Add(this.tst_monit);
            this.tabPage4.Controls.Add(this.chart3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1100, 712);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Monitoring";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // save_db
            // 
            this.save_db.Location = new System.Drawing.Point(16, 573);
            this.save_db.Name = "save_db";
            this.save_db.Size = new System.Drawing.Size(110, 44);
            this.save_db.TabIndex = 15;
            this.save_db.Text = "Save to Database";
            this.save_db.UseVisualStyleBackColor = true;
            this.save_db.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // monit_light
            // 
            this.monit_light.Location = new System.Drawing.Point(985, 30);
            this.monit_light.Name = "monit_light";
            this.monit_light.ReadOnly = true;
            this.monit_light.Size = new System.Drawing.Size(60, 22);
            this.monit_light.TabIndex = 14;
            // 
            // monit_status
            // 
            this.monit_status.Location = new System.Drawing.Point(879, 30);
            this.monit_status.Name = "monit_status";
            this.monit_status.ReadOnly = true;
            this.monit_status.Size = new System.Drawing.Size(100, 22);
            this.monit_status.TabIndex = 13;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(16, 526);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(110, 23);
            this.clear_button.TabIndex = 12;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // read_readings_box
            // 
            this.read_readings_box.Location = new System.Drawing.Point(147, 380);
            this.read_readings_box.Multiline = true;
            this.read_readings_box.Name = "read_readings_box";
            this.read_readings_box.ReadOnly = true;
            this.read_readings_box.Size = new System.Drawing.Size(190, 237);
            this.read_readings_box.TabIndex = 11;
            // 
            // read_status_text
            // 
            this.read_status_text.Location = new System.Drawing.Point(855, 620);
            this.read_status_text.Multiline = true;
            this.read_status_text.Name = "read_status_text";
            this.read_status_text.ReadOnly = true;
            this.read_status_text.Size = new System.Drawing.Size(190, 22);
            this.read_status_text.TabIndex = 10;
            // 
            // reading_txt
            // 
            this.reading_txt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reading_txt.Location = new System.Drawing.Point(609, 82);
            this.reading_txt.Name = "reading_txt";
            this.reading_txt.ReadOnly = true;
            this.reading_txt.Size = new System.Drawing.Size(213, 22);
            this.reading_txt.TabIndex = 5;
            // 
            // readraw_file
            // 
            this.readraw_file.Location = new System.Drawing.Point(16, 457);
            this.readraw_file.Name = "readraw_file";
            this.readraw_file.Size = new System.Drawing.Size(110, 23);
            this.readraw_file.TabIndex = 9;
            this.readraw_file.Text = "Readraw file";
            this.readraw_file.UseVisualStyleBackColor = true;
            this.readraw_file.Click += new System.EventHandler(this.readraw_file_Click);
            // 
            // read_status_btn
            // 
            this.read_status_btn.Location = new System.Drawing.Point(712, 620);
            this.read_status_btn.Name = "read_status_btn";
            this.read_status_btn.Size = new System.Drawing.Size(110, 23);
            this.read_status_btn.TabIndex = 8;
            this.read_status_btn.Text = "Readstatus";
            this.read_status_btn.UseVisualStyleBackColor = true;
            this.read_status_btn.Click += new System.EventHandler(this.read_status_btn_Click);
            // 
            // readscaled_file
            // 
            this.readscaled_file.Location = new System.Drawing.Point(16, 380);
            this.readscaled_file.Name = "readscaled_file";
            this.readscaled_file.Size = new System.Drawing.Size(110, 23);
            this.readscaled_file.TabIndex = 7;
            this.readscaled_file.Text = "Readscaled file";
            this.readscaled_file.UseVisualStyleBackColor = true;
            this.readscaled_file.Click += new System.EventHandler(this.readscaled_file_Click);
            // 
            // save_readings
            // 
            this.save_readings.Location = new System.Drawing.Point(16, 211);
            this.save_readings.Name = "save_readings";
            this.save_readings.Size = new System.Drawing.Size(110, 43);
            this.save_readings.TabIndex = 6;
            this.save_readings.Text = "Save Raw Values";
            this.save_readings.UseVisualStyleBackColor = true;
            this.save_readings.Click += new System.EventHandler(this.save_readings_Click);
            // 
            // test_scaled
            // 
            this.test_scaled.Location = new System.Drawing.Point(147, 110);
            this.test_scaled.Name = "test_scaled";
            this.test_scaled.Size = new System.Drawing.Size(110, 23);
            this.test_scaled.TabIndex = 3;
            this.test_scaled.Text = "ReadScaled";
            this.test_scaled.UseVisualStyleBackColor = true;
            this.test_scaled.Click += new System.EventHandler(this.test_scaled_Click);
            // 
            // stop_monit
            // 
            this.stop_monit.Location = new System.Drawing.Point(16, 159);
            this.stop_monit.Name = "stop_monit";
            this.stop_monit.Size = new System.Drawing.Size(110, 23);
            this.stop_monit.TabIndex = 2;
            this.stop_monit.Text = "Stop";
            this.stop_monit.UseVisualStyleBackColor = true;
            this.stop_monit.Click += new System.EventHandler(this.stop_monit_Click);
            // 
            // tst_monit
            // 
            this.tst_monit.Location = new System.Drawing.Point(16, 110);
            this.tst_monit.Name = "tst_monit";
            this.tst_monit.Size = new System.Drawing.Size(110, 23);
            this.tst_monit.TabIndex = 1;
            this.tst_monit.Text = "ReadRaw";
            this.tst_monit.UseVisualStyleBackColor = true;
            this.tst_monit.Click += new System.EventHandler(this.tst_monit_Click);
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(442, 110);
            this.chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "readings";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(626, 490);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.import_config_button);
            this.tabPage2.Controls.Add(this.config_status);
            this.tabPage2.Controls.Add(this.confi_light);
            this.tabPage2.Controls.Add(this.alarmh_textBox8);
            this.tabPage2.Controls.Add(this.alarml_textBox7);
            this.tabPage2.Controls.Add(this.urv_textBox6);
            this.tabPage2.Controls.Add(this.lrv_textBox5);
            this.tabPage2.Controls.Add(this.readpar_textBox3);
            this.tabPage2.Controls.Add(this.name_textBox2);
            this.tabPage2.Controls.Add(this.clearconfig_button);
            this.tabPage2.Controls.Add(this.writeconfig1_button);
            this.tabPage2.Controls.Add(this.viewconf_button1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.readpar_button2);
            this.tabPage2.Controls.Add(this.savepar_button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1100, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config Area";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // import_config_button
            // 
            this.import_config_button.Location = new System.Drawing.Point(28, 347);
            this.import_config_button.Margin = new System.Windows.Forms.Padding(4);
            this.import_config_button.Name = "import_config_button";
            this.import_config_button.Size = new System.Drawing.Size(188, 38);
            this.import_config_button.TabIndex = 20;
            this.import_config_button.Text = "Import config from file";
            this.import_config_button.UseVisualStyleBackColor = true;
            this.import_config_button.Click += new System.EventHandler(this.import_config_button_Click);
            // 
            // config_status
            // 
            this.config_status.Location = new System.Drawing.Point(879, 30);
            this.config_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.config_status.Name = "config_status";
            this.config_status.ReadOnly = true;
            this.config_status.Size = new System.Drawing.Size(100, 22);
            this.config_status.TabIndex = 19;
            // 
            // confi_light
            // 
            this.confi_light.Location = new System.Drawing.Point(985, 30);
            this.confi_light.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confi_light.Multiline = true;
            this.confi_light.Name = "confi_light";
            this.confi_light.ReadOnly = true;
            this.confi_light.Size = new System.Drawing.Size(60, 22);
            this.confi_light.TabIndex = 18;
            // 
            // alarmh_textBox8
            // 
            this.alarmh_textBox8.Location = new System.Drawing.Point(124, 188);
            this.alarmh_textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alarmh_textBox8.Name = "alarmh_textBox8";
            this.alarmh_textBox8.Size = new System.Drawing.Size(188, 22);
            this.alarmh_textBox8.TabIndex = 12;
            // 
            // alarml_textBox7
            // 
            this.alarml_textBox7.Location = new System.Drawing.Point(124, 146);
            this.alarml_textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alarml_textBox7.Name = "alarml_textBox7";
            this.alarml_textBox7.Size = new System.Drawing.Size(188, 22);
            this.alarml_textBox7.TabIndex = 11;
            // 
            // urv_textBox6
            // 
            this.urv_textBox6.Location = new System.Drawing.Point(124, 106);
            this.urv_textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urv_textBox6.Name = "urv_textBox6";
            this.urv_textBox6.Size = new System.Drawing.Size(188, 22);
            this.urv_textBox6.TabIndex = 10;
            // 
            // lrv_textBox5
            // 
            this.lrv_textBox5.Location = new System.Drawing.Point(124, 71);
            this.lrv_textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lrv_textBox5.Name = "lrv_textBox5";
            this.lrv_textBox5.Size = new System.Drawing.Size(188, 22);
            this.lrv_textBox5.TabIndex = 9;
            // 
            // readpar_textBox3
            // 
            this.readpar_textBox3.Location = new System.Drawing.Point(365, 30);
            this.readpar_textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readpar_textBox3.Multiline = true;
            this.readpar_textBox3.Name = "readpar_textBox3";
            this.readpar_textBox3.Size = new System.Drawing.Size(257, 181);
            this.readpar_textBox3.TabIndex = 1;
            // 
            // name_textBox2
            // 
            this.name_textBox2.Location = new System.Drawing.Point(124, 32);
            this.name_textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_textBox2.Name = "name_textBox2";
            this.name_textBox2.Size = new System.Drawing.Size(188, 22);
            this.name_textBox2.TabIndex = 0;
            // 
            // clearconfig_button
            // 
            this.clearconfig_button.Location = new System.Drawing.Point(19, 225);
            this.clearconfig_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearconfig_button.Name = "clearconfig_button";
            this.clearconfig_button.Size = new System.Drawing.Size(75, 23);
            this.clearconfig_button.TabIndex = 17;
            this.clearconfig_button.Text = "Clear";
            this.clearconfig_button.UseVisualStyleBackColor = true;
            this.clearconfig_button.Click += new System.EventHandler(this.clearconfig_button_Click);
            // 
            // writeconfig1_button
            // 
            this.writeconfig1_button.Location = new System.Drawing.Point(365, 299);
            this.writeconfig1_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.writeconfig1_button.Name = "writeconfig1_button";
            this.writeconfig1_button.Size = new System.Drawing.Size(223, 33);
            this.writeconfig1_button.TabIndex = 16;
            this.writeconfig1_button.Text = "Writeconf";
            this.writeconfig1_button.UseVisualStyleBackColor = true;
            this.writeconfig1_button.Click += new System.EventHandler(this.writeconfig1_button_Click);
            // 
            // viewconf_button1
            // 
            this.viewconf_button1.Location = new System.Drawing.Point(28, 284);
            this.viewconf_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewconf_button1.Name = "viewconf_button1";
            this.viewconf_button1.Size = new System.Drawing.Size(188, 38);
            this.viewconf_button1.TabIndex = 13;
            this.viewconf_button1.Text = "View Current config";
            this.viewconf_button1.UseVisualStyleBackColor = true;
            this.viewconf_button1.Click += new System.EventHandler(this.viewconf_button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Alarm Upper";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Alarm Lower ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Upper range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lower range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // readpar_button2
            // 
            this.readpar_button2.Location = new System.Drawing.Point(365, 241);
            this.readpar_button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readpar_button2.Name = "readpar_button2";
            this.readpar_button2.Size = new System.Drawing.Size(223, 46);
            this.readpar_button2.TabIndex = 3;
            this.readpar_button2.Text = "Read Parameter file";
            this.readpar_button2.UseVisualStyleBackColor = true;
            this.readpar_button2.Click += new System.EventHandler(this.readpar_button2_Click);
            // 
            // savepar_button1
            // 
            this.savepar_button1.Location = new System.Drawing.Point(28, 409);
            this.savepar_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savepar_button1.Name = "savepar_button1";
            this.savepar_button1.Size = new System.Drawing.Size(188, 42);
            this.savepar_button1.TabIndex = 2;
            this.savepar_button1.Text = "Save New Parameters";
            this.savepar_button1.UseVisualStyleBackColor = true;
            this.savepar_button1.Click += new System.EventHandler(this.savepar_button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sc_status_box);
            this.tabPage1.Controls.Add(this.sc_statuslight);
            this.tabPage1.Controls.Add(this.send_textBox5);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cleardata_button);
            this.tabPage1.Controls.Add(this.send_button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.discon_button);
            this.tabPage1.Controls.Add(this.bitrate_combobox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comport_combobox);
            this.tabPage1.Controls.Add(this.Connect);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1100, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sc_status_box
            // 
            this.sc_status_box.Location = new System.Drawing.Point(879, 30);
            this.sc_status_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sc_status_box.Multiline = true;
            this.sc_status_box.Name = "sc_status_box";
            this.sc_status_box.ReadOnly = true;
            this.sc_status_box.Size = new System.Drawing.Size(100, 22);
            this.sc_status_box.TabIndex = 15;
            // 
            // sc_statuslight
            // 
            this.sc_statuslight.Location = new System.Drawing.Point(985, 30);
            this.sc_statuslight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sc_statuslight.Multiline = true;
            this.sc_statuslight.Name = "sc_statuslight";
            this.sc_statuslight.ReadOnly = true;
            this.sc_statuslight.Size = new System.Drawing.Size(60, 22);
            this.sc_statuslight.TabIndex = 14;
            // 
            // send_textBox5
            // 
            this.send_textBox5.Location = new System.Drawing.Point(151, 474);
            this.send_textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send_textBox5.Name = "send_textBox5";
            this.send_textBox5.Size = new System.Drawing.Size(136, 22);
            this.send_textBox5.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 158);
            this.textBox1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Her kan du sende inn kommandoer selv";
            // 
            // cleardata_button
            // 
            this.cleardata_button.Location = new System.Drawing.Point(689, 217);
            this.cleardata_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cleardata_button.Name = "cleardata_button";
            this.cleardata_button.Size = new System.Drawing.Size(75, 23);
            this.cleardata_button.TabIndex = 12;
            this.cleardata_button.Text = "Clear Data";
            this.cleardata_button.UseVisualStyleBackColor = true;
            this.cleardata_button.Click += new System.EventHandler(this.cleardata_button_Click);
            // 
            // send_button1
            // 
            this.send_button1.Location = new System.Drawing.Point(-4, 473);
            this.send_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send_button1.Name = "send_button1";
            this.send_button1.Size = new System.Drawing.Size(117, 23);
            this.send_button1.TabIndex = 8;
            this.send_button1.Text = "Send";
            this.send_button1.UseVisualStyleBackColor = true;
            this.send_button1.Click += new System.EventHandler(this.send_button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vennligst velg Port og Bitrate";
            // 
            // discon_button
            // 
            this.discon_button.Location = new System.Drawing.Point(151, 283);
            this.discon_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discon_button.Name = "discon_button";
            this.discon_button.Size = new System.Drawing.Size(136, 23);
            this.discon_button.TabIndex = 6;
            this.discon_button.Text = "Disconnect";
            this.discon_button.UseVisualStyleBackColor = true;
            this.discon_button.Click += new System.EventHandler(this.discon_button_Click);
            // 
            // bitrate_combobox
            // 
            this.bitrate_combobox.AccessibleName = "";
            this.bitrate_combobox.FormattingEnabled = true;
            this.bitrate_combobox.Location = new System.Drawing.Point(151, 209);
            this.bitrate_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bitrate_combobox.Name = "bitrate_combobox";
            this.bitrate_combobox.Size = new System.Drawing.Size(136, 24);
            this.bitrate_combobox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bit Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Com Port";
            // 
            // comport_combobox
            // 
            this.comport_combobox.FormattingEnabled = true;
            this.comport_combobox.Location = new System.Drawing.Point(151, 148);
            this.comport_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comport_combobox.Name = "comport_combobox";
            this.comport_combobox.Size = new System.Drawing.Size(136, 24);
            this.comport_combobox.TabIndex = 1;
            this.comport_combobox.Click += new System.EventHandler(this.comport_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(5, 283);
            this.Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(121, 23);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 741);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.database_ligt);
            this.tabPage3.Controls.Add(this.database_status);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1100, 712);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Database";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update data to Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show data from Database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // database_status
            // 
            this.database_status.Location = new System.Drawing.Point(879, 30);
            this.database_status.Name = "database_status";
            this.database_status.ReadOnly = true;
            this.database_status.Size = new System.Drawing.Size(100, 22);
            this.database_status.TabIndex = 2;
            // 
            // database_ligt
            // 
            this.database_ligt.Location = new System.Drawing.Point(985, 30);
            this.database_ligt.Name = "database_ligt";
            this.database_ligt.ReadOnly = true;
            this.database_ligt.Size = new System.Drawing.Size(60, 22);
            this.database_ligt.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 467);
            this.dataGridView1.TabIndex = 4;
            // 
            // save_scaled
            // 
            this.save_scaled.Location = new System.Drawing.Point(147, 211);
            this.save_scaled.Name = "save_scaled";
            this.save_scaled.Size = new System.Drawing.Size(110, 43);
            this.save_scaled.TabIndex = 16;
            this.save_scaled.Text = "Save Scaled Values";
            this.save_scaled.UseVisualStyleBackColor = true;
            this.save_scaled.Click += new System.EventHandler(this.save_scaled_Click);
            // 
            // Arbeidskrav1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 751);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Arbeidskrav1";
            this.Text = "Arbeidskrav1";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox read_readings_box;
        private System.Windows.Forms.TextBox read_status_text;
        private System.Windows.Forms.TextBox reading_txt;
        private System.Windows.Forms.Button readraw_file;
        private System.Windows.Forms.Button read_status_btn;
        private System.Windows.Forms.Button readscaled_file;
        private System.Windows.Forms.Button save_readings;
        private System.Windows.Forms.Button test_scaled;
        private System.Windows.Forms.Button stop_monit;
        private System.Windows.Forms.Button tst_monit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button import_config_button;
        private System.Windows.Forms.TextBox config_status;
        private System.Windows.Forms.TextBox confi_light;
        private System.Windows.Forms.TextBox alarmh_textBox8;
        private System.Windows.Forms.TextBox alarml_textBox7;
        private System.Windows.Forms.TextBox urv_textBox6;
        private System.Windows.Forms.TextBox lrv_textBox5;
        private System.Windows.Forms.TextBox readpar_textBox3;
        private System.Windows.Forms.TextBox name_textBox2;
        private System.Windows.Forms.Button clearconfig_button;
        private System.Windows.Forms.Button writeconfig1_button;
        private System.Windows.Forms.Button viewconf_button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button readpar_button2;
        private System.Windows.Forms.Button savepar_button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox sc_status_box;
        private System.Windows.Forms.TextBox sc_statuslight;
        private System.Windows.Forms.TextBox send_textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cleardata_button;
        private System.Windows.Forms.Button send_button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button discon_button;
        private System.Windows.Forms.ComboBox bitrate_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comport_combobox;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox monit_light;
        private System.Windows.Forms.TextBox monit_status;
        private System.Windows.Forms.Button save_db;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox database_ligt;
        private System.Windows.Forms.TextBox database_status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_scaled;
    }
}

