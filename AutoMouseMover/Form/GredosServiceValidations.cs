
using System;
using System.Threading;
using System.Windows.Forms;
using AutoMouseMover.Logic;
using AutoMouseMover.Utils;

namespace AutoMouseMover
{
    //
    // Main form
    //
    public partial class AutoMouseMoverForm : Form
    {
        //
        // Constants
        //
        #region Constants

        // Idle status string
        private const string STATUS_IDLE_STR    = "idle";
        // Running status string
        private const string STATUS_RUNNING_STR = "running";
        // Balloon tip timeout
        private const int  BALLOON_TIP_TIMEOUT  = 500;

        #endregion

        //
        // Members
        //
        #region Members

        // Automatic mouse mover
        private AutomaticMouseMover mAutoMouseMover;
        // Settings
        private SettingsHelper      mSettings;
        private int clickTime = 0;
        private bool calc = true;
        bool lunchtime = true;
        private DateTime lunch = DateTime.Now;
        private DateTime endlunch = DateTime.Now;
        #endregion

        //
        // Constructor
        //
        #region Constructor

        // Constructor
        public AutoMouseMoverForm()
        {
            InitializeComponent();
            // Create classes
            mAutoMouseMover = new AutomaticMouseMover();
            mSettings = new SettingsHelper();
            // Load settings
            LoadSettings();
            // Set status
            SetStatus(STATUS_IDLE_STR);
        }

        #endregion

        //
        // GUI events
        //
        #region GUI events

        // Start button
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Disable GUI on start
            DisableGuiOnStart();
            // Minimize to tray bar if requested
            if (MinimizeToTrayBarBox.Checked)
            {
                MinimizeWindowToTrayBar();
            }
            // Set status
            SetStatus(STATUS_RUNNING_STR);
            // Initialize auto mouse mover class
            mAutoMouseMover.Initialize((int) MovingPixelBox.Value);
            // Set timer interval and start it
            CursorTimer.Interval = ((int) MovingPeriodBox.Value) * 1000;
            CursorTimer.Start();
        }

        // Stop button
        private void StopButton_Click(object sender, EventArgs e)
        {
            SetStatus(STATUS_IDLE_STR);
            EnableGuiOnStop();
            CursorTimer.Stop();
        }

        // Minimize to tray icon check box changed
        private void MinimizeToTrayBarBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowTrayBarIconBox.Enabled = MinimizeToTrayBarBox.Checked;
            ShowTrayBarIconBox.Checked = MinimizeToTrayBarBox.Checked;
        }

        // Tray icon double clicked
        private void TrayBarIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RestoreWindowFromTrayBar();
        }

        // About button in menu strip
        private void StripMenuAbout_Click(object sender, EventArgs e)
        {
            AboutForm about_form = new AboutForm();
            about_form.ShowDialog();
        }

        // Open button in tray bar context menu
        private void TrayBarMenuOpen_Click(object sender, EventArgs e)
        {
            RestoreWindowFromTrayBar();
        }

        // Close button in tray bar context menu
        private void TrayBarMenuClose_Click(object sender, EventArgs e)
        {
            CursorTimer.Stop();
            Close();
        }

        #endregion

        //
        // Other events
        //
        #region Other events

        // Closing form event
        private void AutoMouseMoverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        // Form resize
        private void AutoMouseMoverForm_Resize(object sender, EventArgs e)
        {
            // If window is minized when timer is enabled, minimize it to tray bar
            if ((WindowState == FormWindowState.Minimized) && (CursorTimer.Enabled))
            {
                MinimizeWindowToTrayBar();
            }
        }

        // Cursor timer elapsed
        private void CursorTimer_Tick(object sender, EventArgs e)
        {
            //if (IsWithinTime())
            {
                clickTime = clickTime + 1;
                mAutoMouseMover.MoveMouse();
                if (clickTime == 50)
                {
                    var seed = Environment.TickCount;
                    var random = new Random(seed);
                    clickTime = random.Next(0, 40);
                    mAutoMouseMover.DoMouseClick();
                }
            }
        }

        #endregion

        //
        // Private methods
        //
        #region Private methods

        // Load settings
        private void LoadSettings()
        {
            try
            {
                MovingPeriodBox.Value        = mSettings.MovingTime;
                MovingPixelBox.Value         = mSettings.MovingPixel;
                MinimizeToTrayBarBox.Checked = mSettings.MinimizeToTrayBar;
                ShowTrayBarIconBox.Checked   = mSettings.ShowTrayBarIcon;
            }
            catch
            {
                // Default settings in case of errors
                mSettings.LoadDefault();
                // Set again
                MovingPeriodBox.Value        = mSettings.MovingTime;
                MovingPixelBox.Value         = mSettings.MovingPixel;
                MinimizeToTrayBarBox.Checked = mSettings.MinimizeToTrayBar;
                ShowTrayBarIconBox.Checked   = mSettings.ShowTrayBarIcon;
            }
        }

        // Save settings
        private void SaveSettings()
        {
            mSettings.MovingTime        = (int) MovingPeriodBox.Value;
            mSettings.MovingPixel       = (int) MovingPixelBox.Value;
            mSettings.MinimizeToTrayBar = MinimizeToTrayBarBox.Checked;
            mSettings.ShowTrayBarIcon   = ShowTrayBarIconBox.Checked;
            mSettings.Save();
        }

        // Disable GUI on start
        private void DisableGuiOnStart()
        {
            MovingPeriodBox.Enabled      = false;
            MovingPixelBox.Enabled       = false;
            MinimizeToTrayBarBox.Enabled = false;
            ShowTrayBarIconBox.Enabled   = false;
            StartButton.Enabled          = false;
            StopButton.Enabled           = true;
        }

        // Enable GUI on stop
        private void EnableGuiOnStop()
        {
            MovingPeriodBox.Enabled      = true;
            MovingPixelBox.Enabled       = true;
            MinimizeToTrayBarBox.Enabled = true;
            ShowTrayBarIconBox.Enabled   = true;
            StartButton.Enabled          = true;
            StopButton.Enabled           = false;
        }

        // Set status
        private void SetStatus(string cText)
        {
            StatusLabel.Text = String.Format(StatusLabel.Text, cText);
        }

        // Minimize window to tray bar
        private void MinimizeWindowToTrayBar()
        {
            ShowInTaskbar = false;
            TrayBarIcon.Visible = ShowTrayBarIconBox.Checked;
            TrayBarIcon.ShowBalloonTip(BALLOON_TIP_TIMEOUT);
            Hide();
        }

        // Restore window from tray bar
        private void RestoreWindowFromTrayBar()
        {
            TrayBarIcon.Visible = false;
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            Show();
        }

        private bool IsWithinTime()
        {
            Random r = new Random();
            int m1 = 0;
            int m2 = 0;
            int m3 = 0;
            int m4 = 0;
            if (calc)
            {
                //mediodia
                m1 = r.Next(-10, 10);
                m2 = r.Next(-10, 10);
                // entrada y salida
                m3 = r.Next(-10, 2);
                m4 = r.Next(-1, 10);
            }
            
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday) return false;
            string gohome = "17:34:05";
            if (((DateTime.Now.Month == 6) && (DateTime.Now.Day >= 15)) || (DateTime.Now.Month == 7) || (DateTime.Now.Month == 8) || ((DateTime.Now.Month == 9) && (DateTime.Now.Day <= 15)))
                gohome = "14:32:23";
            
        
            if (lunchtime)
            {
                int rd = 0;
                rd = (DateTime.Now.Day % 2 ==0) ? DateTime.Now.Day : DateTime.Now.Day * -1;
                lunch = DateTime.Parse("13:30:02").AddMinutes(m1).AddSeconds(m2);
                endlunch = lunch.AddMinutes(65).AddMinutes(r.Next(-5, 5)).AddSeconds(r.Next(-15, 12));
                lunchtime = false;
            }
            else
            {
                if (DateTime.Now.Hour ==7)
                    lunchtime = true;                
            }

            if (DateTime.Now.DayOfWeek != DayOfWeek.Friday && (DateTime.Now.TimeOfDay < DateTime.Parse("7:57:00").AddMinutes(m3).AddSeconds(m4).TimeOfDay || DateTime.Now.TimeOfDay > DateTime.Parse(gohome).AddMinutes(m4).AddSeconds(m3).TimeOfDay))
            {
                calc = true;
                Thread.Sleep(600000);
                return false;
            }
            if (DateTime.Now.DayOfWeek != DayOfWeek.Friday && (!(DateTime.Now.TimeOfDay < lunch.TimeOfDay || DateTime.Now.TimeOfDay > endlunch.TimeOfDay)))
            {  
                Thread.Sleep(600000);
                return false;
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && (DateTime.Now.TimeOfDay < DateTime.Parse("7:56:00").AddMinutes(m3).AddSeconds(m4).TimeOfDay || DateTime.Now.TimeOfDay > DateTime.Parse("14:03:23").AddMinutes(m4).AddSeconds(m3).TimeOfDay))
            {
                calc = true;
                Thread.Sleep(600000);
                return false;
            }
            calc = false;
            return true;
        }

        #endregion
    }
}
