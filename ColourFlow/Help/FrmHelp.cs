using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColourFlow
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        private void lblHClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the form
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the form
        }

    }
}
