using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex18_2
{
    public partial class Form1 : Form
    {
        private bool switchingEnabled = true;
        private bool currentLabelIsHello = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void switchingToggleButton_Click(object sender, EventArgs e)
        {
            switchingEnabled = !switchingEnabled;
            switchingToggleButton.Text = switchingEnabled ? "Disable Switching" : "Enable Switching";
            timer.Enabled = switchingEnabled;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentLabelIsHello = !currentLabelIsHello;
            displayLabel.Text = currentLabelIsHello ? "Hello" : "Goodbye";
        }
    }
}
