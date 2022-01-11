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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_gameMode_Click(object sender, EventArgs e)
        {
            files dataFile = new files();
            dataFile.incrRound();
            GameMode gm = new GameMode();
            gm.ShowDialog();
        }

        private void btn_SimulatatorMode_Click(object sender, EventArgs e)
        {
            SimulatationMode sm = new SimulatationMode();
            sm.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            files dataFile = new files();
            dataFile.writeRoundNum(0);
            dataFile.writeCorrectAns(0);
        }
    }
}
