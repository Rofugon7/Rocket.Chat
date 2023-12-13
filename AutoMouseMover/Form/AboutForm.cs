using System;
using System.Windows.Forms;
using AutoMouseMover.Utils;

namespace AutoMouseMover
{
    //
    // About form
    //
    public partial class AboutForm : Form
    {
        //
        // Constructor
        //
        #region Constructor

        // Constructor
        public AboutForm()
        {
            InitializeComponent();
            // Get assembly information
            var ass_helper = new AssemblyHelper();
            // Set labels
            ProductLabel.Text = String.Format(ProductLabel.Text, ass_helper.Product);
            DescriptionLabel.Text = String.Format(DescriptionLabel.Text, ass_helper.Description);
            VersionLabel.Text = String.Format(VersionLabel.Text, ass_helper.Version);
            CopyrightLabel.Text = String.Format(CopyrightLabel.Text, ass_helper.Copyright);
        }

        #endregion

        //
        // GUI events
        //
        #region GUI events

        /* Close button */
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
