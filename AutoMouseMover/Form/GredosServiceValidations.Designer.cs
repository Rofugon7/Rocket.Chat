namespace AutoMouseMover
{
    partial class AutoMouseMoverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoMouseMoverForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.MovingTimeLabel = new System.Windows.Forms.Label();
            this.MovingPixelLabel = new System.Windows.Forms.Label();
            this.MovingPixelBox = new System.Windows.Forms.NumericUpDown();
            this.MovingPeriodBox = new System.Windows.Forms.NumericUpDown();
            this.MovingTimeSecondLabel = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CursorTimer = new System.Windows.Forms.Timer(this.components);
            this.TrayBarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayBarContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayBarMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayBarMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.StopButton = new System.Windows.Forms.Button();
            this.MinimizeToTrayBarBox = new System.Windows.Forms.CheckBox();
            this.ShowTrayBarIconBox = new System.Windows.Forms.CheckBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.StripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MovingPixelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingPeriodBox)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.TrayBarContextMenu.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(14, 353);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MovingTimeLabel
            // 
            this.MovingTimeLabel.AutoSize = true;
            this.MovingTimeLabel.Location = new System.Drawing.Point(12, 38);
            this.MovingTimeLabel.Name = "MovingTimeLabel";
            this.MovingTimeLabel.Size = new System.Drawing.Size(127, 13);
            this.MovingTimeLabel.TabIndex = 3;
            this.MovingTimeLabel.Text = "Move when PC is idle for:";
            // 
            // MovingPixelLabel
            // 
            this.MovingPixelLabel.AutoSize = true;
            this.MovingPixelLabel.Location = new System.Drawing.Point(12, 64);
            this.MovingPixelLabel.Name = "MovingPixelLabel";
            this.MovingPixelLabel.Size = new System.Drawing.Size(158, 13);
            this.MovingPixelLabel.TabIndex = 4;
            this.MovingPixelLabel.Text = "Number of pixel to move mouse:";
            // 
            // MovingPixelBox
            // 
            this.MovingPixelBox.Location = new System.Drawing.Point(176, 62);
            this.MovingPixelBox.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.MovingPixelBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MovingPixelBox.Name = "MovingPixelBox";
            this.MovingPixelBox.Size = new System.Drawing.Size(50, 20);
            this.MovingPixelBox.TabIndex = 5;
            this.MovingPixelBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MovingPeriodBox
            // 
            this.MovingPeriodBox.Location = new System.Drawing.Point(176, 36);
            this.MovingPeriodBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MovingPeriodBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MovingPeriodBox.Name = "MovingPeriodBox";
            this.MovingPeriodBox.Size = new System.Drawing.Size(50, 20);
            this.MovingPeriodBox.TabIndex = 6;
            this.MovingPeriodBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MovingPeriodBox.ValueChanged += new System.EventHandler(this.MovingPeriodBox_ValueChanged);
            // 
            // MovingTimeSecondLabel
            // 
            this.MovingTimeSecondLabel.AutoSize = true;
            this.MovingTimeSecondLabel.Location = new System.Drawing.Point(232, 38);
            this.MovingTimeSecondLabel.Name = "MovingTimeSecondLabel";
            this.MovingTimeSecondLabel.Size = new System.Drawing.Size(53, 13);
            this.MovingTimeSecondLabel.TabIndex = 7;
            this.MovingTimeSecondLabel.Text = "second(s)";
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 390);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(295, 22);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 8;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(59, 17);
            this.StatusLabel.Text = "Status: {0}";
            // 
            // CursorTimer
            // 
            this.CursorTimer.Tick += new System.EventHandler(this.CursorTimer_Tick);
            // 
            // TrayBarIcon
            // 
            this.TrayBarIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TrayBarIcon.BalloonTipText = "RocketChat is running in background";
            this.TrayBarIcon.BalloonTipTitle = "RocketChat";
            this.TrayBarIcon.ContextMenuStrip = this.TrayBarContextMenu;
            this.TrayBarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayBarIcon.Icon")));
            this.TrayBarIcon.Text = "AutomaticRocketChat running";
            this.TrayBarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayBarIcon_MouseDoubleClick);
            // 
            // TrayBarContextMenu
            // 
            this.TrayBarContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TrayBarContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayBarMenuOpen,
            this.TrayBarMenuClose});
            this.TrayBarContextMenu.Name = "TrayBarContextMenu";
            this.TrayBarContextMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // TrayBarMenuOpen
            // 
            this.TrayBarMenuOpen.Name = "TrayBarMenuOpen";
            this.TrayBarMenuOpen.Size = new System.Drawing.Size(103, 22);
            this.TrayBarMenuOpen.Text = "Open";
            this.TrayBarMenuOpen.Click += new System.EventHandler(this.TrayBarMenuOpen_Click);
            // 
            // TrayBarMenuClose
            // 
            this.TrayBarMenuClose.Name = "TrayBarMenuClose";
            this.TrayBarMenuClose.Size = new System.Drawing.Size(103, 22);
            this.TrayBarMenuClose.Text = "Close";
            this.TrayBarMenuClose.Click += new System.EventHandler(this.TrayBarMenuClose_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(206, 353);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MinimizeToTrayBarBox
            // 
            this.MinimizeToTrayBarBox.AutoSize = true;
            this.MinimizeToTrayBarBox.Checked = true;
            this.MinimizeToTrayBarBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MinimizeToTrayBarBox.Location = new System.Drawing.Point(15, 296);
            this.MinimizeToTrayBarBox.Name = "MinimizeToTrayBarBox";
            this.MinimizeToTrayBarBox.Size = new System.Drawing.Size(180, 17);
            this.MinimizeToTrayBarBox.TabIndex = 11;
            this.MinimizeToTrayBarBox.Text = "Minimize to tray bar when started";
            this.MinimizeToTrayBarBox.UseVisualStyleBackColor = true;
            this.MinimizeToTrayBarBox.CheckedChanged += new System.EventHandler(this.MinimizeToTrayBarBox_CheckedChanged);
            // 
            // ShowTrayBarIconBox
            // 
            this.ShowTrayBarIconBox.AutoSize = true;
            this.ShowTrayBarIconBox.Checked = true;
            this.ShowTrayBarIconBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowTrayBarIconBox.Location = new System.Drawing.Point(15, 319);
            this.ShowTrayBarIconBox.Name = "ShowTrayBarIconBox";
            this.ShowTrayBarIconBox.Size = new System.Drawing.Size(191, 17);
            this.ShowTrayBarIconBox.TabIndex = 12;
            this.ShowTrayBarIconBox.Text = "Show tray bar icon when minimized";
            this.ShowTrayBarIconBox.UseVisualStyleBackColor = true;
            this.ShowTrayBarIconBox.CheckedChanged += new System.EventHandler(this.ShowTrayBarIconBox_CheckedChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuAbout});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip.Size = new System.Drawing.Size(295, 24);
            this.MenuStrip.TabIndex = 13;
            // 
            // StripMenuAbout
            // 
            this.StripMenuAbout.Name = "StripMenuAbout";
            this.StripMenuAbout.Size = new System.Drawing.Size(52, 20);
            this.StripMenuAbout.Text = "About";
            this.StripMenuAbout.Click += new System.EventHandler(this.StripMenuAbout_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2024, 3, 4, 8, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.Value = new System.DateTime(2024, 3, 4, 17, 32, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH:mm";
            this.dateTimePicker3.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(15, 152);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker3.TabIndex = 16;
            this.dateTimePicker3.Value = new System.DateTime(2024, 3, 4, 13, 30, 0, 0);
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(131, 152);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            57,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(131, 180);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "HH:mm";
            this.dateTimePicker4.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(16, 180);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker4.TabIndex = 18;
            this.dateTimePicker4.Value = new System.DateTime(2024, 3, 4, 11, 5, 0, 0);
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(131, 206);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown3.TabIndex = 21;
            this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "HH:mm";
            this.dateTimePicker5.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker5.Location = new System.Drawing.Point(16, 206);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.ShowUpDown = true;
            this.dateTimePicker5.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker5.TabIndex = 20;
            this.dateTimePicker5.Value = new System.DateTime(2024, 3, 4, 9, 40, 0, 0);
            this.dateTimePicker5.ValueChanged += new System.EventHandler(this.dateTimePicker5_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(131, 232);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown4.TabIndex = 23;
            this.numericUpDown4.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.CustomFormat = "HH:mm";
            this.dateTimePicker6.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker6.Location = new System.Drawing.Point(16, 232);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.ShowUpDown = true;
            this.dateTimePicker6.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker6.TabIndex = 22;
            this.dateTimePicker6.Value = new System.DateTime(2024, 3, 4, 12, 15, 0, 0);
            this.dateTimePicker6.ValueChanged += new System.EventHandler(this.dateTimePicker6_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(131, 258);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown5.TabIndex = 25;
            this.numericUpDown5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.CustomFormat = "HH:mm";
            this.dateTimePicker7.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker7.Location = new System.Drawing.Point(16, 258);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.ShowUpDown = true;
            this.dateTimePicker7.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker7.TabIndex = 24;
            this.dateTimePicker7.Value = new System.DateTime(2024, 3, 4, 16, 12, 0, 0);
            this.dateTimePicker7.ValueChanged += new System.EventHandler(this.dateTimePicker7_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(201, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Comida";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(201, 182);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "Desayuno";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(201, 207);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 17);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "Descanso 1";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(201, 233);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(83, 17);
            this.checkBox4.TabIndex = 29;
            this.checkBox4.Text = "Descanso 2";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(201, 259);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(83, 17);
            this.checkBox5.TabIndex = 30;
            this.checkBox5.Text = "Descanso 3";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // AutoMouseMoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 412);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.dateTimePicker7);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.dateTimePicker6);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ShowTrayBarIconBox);
            this.Controls.Add(this.MinimizeToTrayBarBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.MovingTimeSecondLabel);
            this.Controls.Add(this.MovingPeriodBox);
            this.Controls.Add(this.MovingPixelBox);
            this.Controls.Add(this.MovingPixelLabel);
            this.Controls.Add(this.MovingTimeLabel);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "AutoMouseMoverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RocketChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoMouseMoverForm_FormClosing);
            this.Load += new System.EventHandler(this.AutoMouseMoverForm_Load);
            this.Resize += new System.EventHandler(this.AutoMouseMoverForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MovingPixelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingPeriodBox)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.TrayBarContextMenu.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label MovingTimeLabel;
        private System.Windows.Forms.Label MovingPixelLabel;
        private System.Windows.Forms.NumericUpDown MovingPixelBox;
        private System.Windows.Forms.NumericUpDown MovingPeriodBox;
        private System.Windows.Forms.Label MovingTimeSecondLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Timer CursorTimer;
        private System.Windows.Forms.NotifyIcon TrayBarIcon;
        private System.Windows.Forms.ContextMenuStrip TrayBarContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayBarMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem TrayBarMenuClose;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.CheckBox MinimizeToTrayBarBox;
        private System.Windows.Forms.CheckBox ShowTrayBarIconBox;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StripMenuAbout;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

