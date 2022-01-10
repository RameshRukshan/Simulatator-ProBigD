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


        int rNumber = 0;
        Char actDoor = 'c', sugestDoor = 'c', opendDoor = 'C';
        Boolean actDA = false, actDB = false, actDC = false;
        Boolean openState = false;
        Boolean[] incDoors = new Boolean[3];
        Char[] remainDNum = new Char[2];

        public void SelectSuggestDoor()
        {
            if (remainDNum[0] != opendDoor)
            {
                sugestDoor = remainDNum[0];
            }
            else
            {
                sugestDoor = remainDNum[1];
            }
        }

        public void checks()
        {
            if (actDA == true)
            {
                actDoor = 'A';
                incDoors[0] = false;
                incDoors[1] = true;
                incDoors[2] = true;
            }
            else if (actDB == true)
            {
                actDoor = 'B';
                incDoors[0] = true;
                incDoors[1] = false;
                incDoors[2] = true;
            }
            else
            {
                actDoor = 'c';
                incDoors[0] = true;
                incDoors[1] = true;
                incDoors[2] = false;
            }
        }

        public void openIncDoorRand()
        {
            Random rd = new Random();
            rNumber = rd.Next();
            if (rNumber % 3 == 0)
            {
                if (incDoors[0] == true && opendDoor != 'A' && actDoor != 'A') { 
                    A_DOpen.Visible = true;
                    A_DClose.Visible = false;
                    remainDNum[0] = 'B'; remainDNum[1] = 'C';
                }
                else
                {
                    B_DOpen.Visible = true;
                    B_DClose.Visible = false;
                    remainDNum[0] = 'A'; remainDNum[1] = 'C';
                }
            }
            else if (rNumber % 3 == 1)
            {
                if (incDoors[1] == true && opendDoor != 'B' && actDoor != 'B')
                {
                    B_DOpen.Visible = true;
                    B_DClose.Visible = false;
                    remainDNum[0] = 'A'; remainDNum[1] = 'C';
                }
                else
                {
                    C_DOpen.Visible = true;
                    C_DClose.Visible = false;
                    remainDNum[0] = 'B'; remainDNum[1] = 'A';
                }
            }
            else
            {
                if (incDoors[2] == true && opendDoor != 'C' && actDoor != 'C')
                {
                    C_DOpen.Visible = true;
                    C_DClose.Visible = false;
                    remainDNum[0] = 'B'; remainDNum[1] = 'A';
                }
                else
                {
                    A_DOpen.Visible = true;
                    A_DClose.Visible = false;
                    remainDNum[0] = 'B'; remainDNum[1] = 'C';
                }
            }
        }


        private void GameMode_Load(object sender, EventArgs e)
        {
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

        private void A_DClose_Click(object sender, EventArgs e)
        {
            if (openState == false)
            {
                openState = true;
                opendDoor = 'A';
                markedA.Visible = true;
                checks();
                openIncDoorRand();
                SelectSuggestDoor();
                SwitchConfirm swc = new SwitchConfirm("You wanna change your Selection, A Door to " + sugestDoor + " Door ?", "A", sugestDoor);
                swc.ShowDialog();

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
                checks();
                openIncDoorRand();
                SelectSuggestDoor();
                SwitchConfirm swc = new SwitchConfirm("You wanna change your Selection, B Door to " +sugestDoor+ " Door ?", "B", sugestDoor);
                swc.ShowDialog();

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
                checks();
                openIncDoorRand();
                SelectSuggestDoor();
                SwitchConfirm swc = new SwitchConfirm("You wanna change your Selection, C Door to " + sugestDoor + " Door ?", "C", sugestDoor);
                swc.ShowDialog();
            }
            else
            {
                Error er = new Error("You already Selected an item.");
                er.ShowDialog();
            }
        }
    }
}
