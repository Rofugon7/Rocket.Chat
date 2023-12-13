

namespace AutoMouseMover.Utils
{
    //
    // Settings helper
    //
    class SettingsHelper
    {
        //
        // Constants
        //
        #region Constants

        // Defautl moving period
        private const int DEF_MOVING_PERIOD       = 5;
        // Default moving pixel
        private const int DEF_MOVING_PIXEL        = 5;
        // Default minimize to tray bar
        private const bool DEF_MINIMIZE_TRAY_BAR  = true;
        // Default show tray bar icon
        private const bool DEF_SHOW_TRAY_BAR_ICON = true;

        #endregion

        //
        // Members
        //
        #region Members

        // Moving period
        private int  mMovingPeriod;
        // Moving pixel
        private int  mMovingPixel;
        // Minimize to tray flag
        private bool mMinimizeToTrayBar;
        // Show tray icon flag
        private bool mShowTrayBarIcon;

        #endregion

        //
        // Public methods
        //
        #region Public methods

        // Constructor
        public SettingsHelper()
        {
            Load();
        }

        // Load settings
        public void Load()
        {
            mMovingPeriod      = Rocket.Chat.Properties.Settings.Default.MovingPeriod;
            mMovingPixel       = Rocket.Chat.Properties.Settings.Default.MovingPixel;
            mMinimizeToTrayBar = Rocket.Chat.Properties.Settings.Default.MinimizeToTrayBar;
            mShowTrayBarIcon   = Rocket.Chat.Properties.Settings.Default.ShowTrayBarIcon;
        }

        // Load default settings
        public void LoadDefault()
        {
            mMovingPeriod      = DEF_MOVING_PERIOD;
            mMovingPixel       = DEF_MOVING_PIXEL;
            mMinimizeToTrayBar = DEF_MINIMIZE_TRAY_BAR;
            mShowTrayBarIcon   = DEF_SHOW_TRAY_BAR_ICON;
        }

        // Save settings
        public void Save()
        {
            Rocket.Chat.Properties.Settings.Default.MovingPeriod      = mMovingPeriod;
            Rocket.Chat.Properties.Settings.Default.MovingPixel       = mMovingPixel;
            Rocket.Chat.Properties.Settings.Default.MinimizeToTrayBar = mMinimizeToTrayBar;
            Rocket.Chat.Properties.Settings.Default.ShowTrayBarIcon   = mShowTrayBarIcon;
            Rocket.Chat.Properties.Settings.Default.Save();
        }

        #endregion

        //
        // Properties
        //
        #region Properties
        
        // Moving time property
        public int MovingTime
        {
            get { return mMovingPeriod; }
            set { mMovingPeriod = value; }
        }

        // Moving pixel property
        public int MovingPixel
        {
            get { return mMovingPixel; }
            set { mMovingPixel = value; }
        }

        // Minimize to tray bar property
        public bool MinimizeToTrayBar
        {
            get { return mMinimizeToTrayBar; }
            set { mMinimizeToTrayBar = value; }
        }

        // Show tray bar icon property
        public bool ShowTrayBarIcon
        {
            get { return mShowTrayBarIcon; }
            set { mShowTrayBarIcon = value; }
        }

        #endregion
    }
}
