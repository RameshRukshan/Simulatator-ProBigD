using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulatator_ProBigD
{
    public partial class Error : Form
    {
        public Error(string message)
        {
            InitializeComponent();
            lbl_errorMessage.Text = message;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
