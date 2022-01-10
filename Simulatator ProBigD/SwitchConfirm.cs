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
    public partial class SwitchConfirm : Form
    {
        public SwitchConfirm(string message, string cDoor, char chDoor)
        {
            InitializeComponent();
            lbl_desText.Text = message;
            lbl_currentDoor.Text = cDoor;
            lbl_changeDoor.Text = chDoor.ToString();
        }

        Boolean stat = false;
        private void SwitchConfirm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            stat = true;
            this.Close();
        }

        private void brn_No_Click(object sender, EventArgs e)
        {
            stat = false;
            this.Close();
        }
    }
}
