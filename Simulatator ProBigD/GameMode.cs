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
    public partial class GameMode : Form
    {
        public GameMode()
        {
            InitializeComponent();
        }

        files dataFile = new files();

        public void ResetImages()
        {
            A_DOpen.Visible = false;
            B_DOpen.Visible = false;
            C_DOpen.Visible = false;

            CoInA.Visible = false;
            CoInB.Visible = false;
            CoInC.Visible = false;

            markedA.Visible = false;
            markedB.Visible = false;
            markedC.Visible = false;

            A_DClose.Visible = true;
            B_DClose.Visible = true;
            C_DClose.Visible = true;

            lbl_GameMessage.Visible = false;
        }

        public void assignDoor()
        {
            if (rNumber % 3 == 0)
            {
                actDoor = 'A';
            }else if (rNumber % 3 == 1)
            {
                actDoor = 'B';
            }
            else
            {
                actDoor = 'C';
            }
        }


        int rNumber = 0, round, count;
        double rate = 0E2D;
        Char actDoor = 'c', sugestDoor = 'c', opendDoor = 'C';
        Boolean openState = false;
       

        public void openIncDoorRand()
        {
            Random r = new Random();
            rNumber = r.Next() % 2;
            if (actDoor == 'A' && opendDoor == 'B')
            {
                C_DClose.Visible = false;
                C_DOpen.Visible = true;
                sugestDoor = 'A';
            }else if(actDoor == 'A' && opendDoor == 'C')
            {
                B_DClose.Visible = false;
                B_DOpen.Visible = true;
                sugestDoor = 'A';
            }
            else if (actDoor == 'A' && opendDoor == 'A')
            {
                if (rNumber == 0)
                {
                    C_DClose.Visible = false;
                    C_DOpen.Visible = true;
                    sugestDoor = 'B';
                }
                else
                {
                    B_DClose.Visible = false;
                    B_DOpen.Visible = true;
                    sugestDoor = 'C';
                }
            }
            else if (actDoor == 'B' && opendDoor == 'C')
            {
                A_DClose.Visible = false;
                A_DOpen.Visible = true;
                sugestDoor = 'B';
            }
            else if (actDoor == 'B' && opendDoor == 'A')
            {
                C_DClose.Visible = false;
                C_DOpen.Visible = true;
                sugestDoor = 'B';
            }
            else if (actDoor == 'B' && opendDoor == 'B')
            {
                if (rNumber == 0)
                {
                    A_DClose.Visible = false;
                    A_DOpen.Visible = true;
                    sugestDoor = 'C';
                }
                else
                {
                    C_DClose.Visible = false;
                    C_DOpen.Visible = true;
                    sugestDoor = 'A';
                }
            }
            else if (actDoor == 'C' && opendDoor == 'A')
            {
                B_DClose.Visible = false;
                B_DOpen.Visible = true;
                sugestDoor = 'C';
            }
            else if (actDoor == 'C' && opendDoor == 'B')
            {
                A_DClose.Visible = false;
                A_DOpen.Visible = true;
                sugestDoor = 'C';
            }
            else if (actDoor == 'C' && opendDoor == 'C')
            {
                if (rNumber == 0)
                {
                    B_DClose.Visible = false;
                    B_DOpen.Visible = true;
                    sugestDoor = 'A';
                }
                else
                {
                    A_DClose.Visible = false;
                    A_DOpen.Visible = true;
                    sugestDoor = 'B';
                }
            }

            dataFile.writeSelectedtDoor(opendDoor.ToString());
        }

        public void checkCorrectDoor()
        {
            if (opendDoor == actDoor)
            {
                lbl_GameMessage.Text = "Correct! You pik the right one";
                lbl_GameMessage.ForeColor = Color.Green;
                lbl_GameMessage.Visible = true;
                dataFile.incCount();
            }
            else
            {
                lbl_GameMessage.Text = "Wrongt! You pik the wrong one";
                lbl_GameMessage.ForeColor = Color.Red;
                lbl_GameMessage.Visible = true;
            }
        }

        public void openDoor()
        {
            if (opendDoor == 'A')
            {
                markedA.Visible = true;
            }else if (opendDoor == 'B')
            {
                markedB.Visible = true;
            }
            else if (opendDoor == 'C')
            {
                markedC.Visible = true;
            }

            A_DOpen.Visible = true;
            A_DClose.Visible = false;
           
            B_DClose.Visible = false;
            B_DOpen.Visible = true;
            
            C_DClose.Visible = false;
            C_DOpen.Visible = true;
            
        }

        public void resetLable()
        {
            markedA.Visible = false;
            markedB.Visible = false;
            markedC.Visible = false;
        }

        private void GameMode_Load(object sender, EventArgs e)
        {
            dataFile.incrRound();
            round = dataFile.readRound();
            lbl_round.Text = ("Round " + round.ToString());
            count = dataFile.readCorrectAns();

            lbl_count.Text = count.ToString();
            lbl_rounds.Text = round.ToString();
            rate = (Convert.ToDouble(count) / Convert.ToDouble(round)) * 100;
            rate = Math.Round(rate, 2);
            lbl_rate.Text = "" + rate.ToString() + "%";

            Random rd = new Random();
            rNumber = rd.Next();
            ResetImages();
            assignDoor();
            openState = false;
            if (actDoor == 'A')
            {
                CoInA.Visible = true;
            }else if (actDoor == 'B')
            {
                CoInB.Visible = true;
            }else if (actDoor == 'C')
            {
                CoInC.Visible = true;
            }
        }

        private void btn_newRound_Click(object sender, EventArgs e)
        {
            this.Close();
            GameMode gam = new GameMode();
            gam.Show();
        }

        private void A_DClose_Click(object sender, EventArgs e)
        {
            if (openState == false)
            {
                openState = true;
                markedA.Visible = true;
                opendDoor = 'A';
                openIncDoorRand();
                SwitchConfirm swc = new SwitchConfirm("You wanna change your Selection, A Door to " + sugestDoor + " Door ?", "A", sugestDoor);
                swc.ShowDialog();
                resetLable();
                opendDoor = swc.returnDoor();
                checkCorrectDoor();
                openDoor();
            }
            else
            {
                Error er = new Error("You already Selected an item.");
                er.ShowDialog();
            }
        }

        private void B_DClose_Click(object sender, EventArgs e)
        {
            if (openState == false)
            {
                openState = true;
                opendDoor = 'B';
                markedB.Visible = true;
                openIncDoorRand();
                SwitchConfirm swc = new SwitchConfirm("You wanna change your Selection, B Door to " +sugestDoor+ " Door ?", "B", sugestDoor);
                swc.ShowDialog();
                resetLable();
                opendDoor = swc.returnDoor();
                checkCorrectDoor();
                openDoor();
            }
            else
            {
                Error er = new Error("You already Selected an item.");
                er.ShowDialog();
            }
        }

        private void C_DClose_Click(object sender, EventArgs e)
        {
            if (openState == false)
            {
                openState = true;
                opendDoor = 'C';
                markedC.Visible = true;
                openIncDoorRand();
                SwitchConfirm swc = new SwitchConfirm("You wanna change your Selection, C Door to " + sugestDoor + " Door ?", "C", sugestDoor);
                swc.ShowDialog();
                resetLable();
                opendDoor = swc.returnDoor();
                checkCorrectDoor();
                openDoor();
            }
            else
            {
                Error er = new Error("You already Selected an item.");
                er.ShowDialog();
            }
        }
    }
}
