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
        string chDoor, cDoor;


        public SwitchConfirm(string message, string cDoor, char chDoor)
        {
            InitializeComponent();
            lbl_desText.Text = message;
            lbl_currentDoor.Text = cDoor;
            lbl_changeDoor.Text = chDoor.ToString();
            this.chDoor = chDoor.ToString();
            this.cDoor = cDoor;
        }

        files dataFile = new files();

        char door;

        private void SwitchConfirm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            door = Convert.ToChar(chDoor);
            dataFile.writeSelectedtDoor(chDoor);
            this.Close();
        }

        private void brn_No_Click(object sender, EventArgs e)
        {
            door = Convert.ToChar(cDoor);
            this.Close();
        }

        public char returnDoor()
        {
            return door;
        }
    }
}
