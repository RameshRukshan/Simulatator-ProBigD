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
    public partial class SimulatationMode : Form
    {
        public SimulatationMode()
        {
            InitializeComponent();
        }
        int rounds, countC, countInc;
        double rate;

        files f = new files();

        private void btn_Start_Click(object sender, EventArgs e)
        {
            img_loading.Visible = true;
            rounds = Convert.ToInt32(txt_rounds.Text);
            countC = 0; countInc = 0; rate = 0;
            f.clearLog();
            f.writelog("\n");
            for (int c = 1; c <= rounds; c++)
            {
                
                bool status = false;
                //lg.assignCompDoor();
                if (opt_keep.Checked)
                {
                    status = lg.keepModeSt();
                }else if (opt_change.Checked)
                {
                    status = lg.changeModSt();
                }

                if(status == true)
                {
                    countC = countC + 1;
                }
                else
                {
                    countInc = countInc + 1;
                }

                f.writelog(lg.retActDoorS());
                f.writelog(lg.retSelDoor());
                f.writelog("\n");

                lbl_Rounds.Text = c.ToString();
                lbl_Correct.Text = countC.ToString();
                lbl_Incorrect.Text = countInc.ToString();

                rate = (Convert.ToDouble(countC) / Convert.ToDouble(c)) * 100;
                rate = Math.Round(rate, 2);
                lbl_winRate.Text = "" + rate.ToString() + "%";
            }
            img_loading.Visible = false;
        }

        private void btn_logs_Click(object sender, EventArgs e)
        {
            Log lg = new Log();
            lg.Show();
        }

        logics lg = new logics();

        private void SimulatationMode_Load(object sender, EventArgs e)
        {
            rounds = 0;
            img_loading.Visible = false;
        }
    }
}
