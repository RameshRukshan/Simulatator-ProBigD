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

        Char actDoor = 'c';
        Boolean actDA = false, actDB = false, actDC = false;
        Boolean openState = false;
        Char[] incDoors = new Char[2];

        public void checks()
        {
            if (actDA == true)
            {
                actDoor = 'A';
                incDoors[0] = 'B';
                incDoors[1] = 'C';
            }
            else if (actDB == true)
            {
                actDoor = 'B';
                incDoors[0] = 'A';
                incDoors[1] = 'C';
            }
            else
            {
                actDoor = 'c';
                incDoors[0] = 'B';
                incDoors[1] = 'A';
            }

            // ----------------------------------------

            if (actDoor == 'A')
            {
                A_DClose.Visible = false;
                A_DOpen.Visible = true;

                lbl_GameMessage.Visible = true;
                lbl_GameMessage.Text = "Correct! You pik the right one";
                lbl_GameMessage.ForeColor = Color.Green;
            }


            if (actDoor == 'B')
            {
                B_DClose.Visible = false;
                B_DOpen.Visible = true;

                lbl_GameMessage.Visible = true;
                lbl_GameMessage.Text = "Correct! You pik the right one";
                lbl_GameMessage.ForeColor = Color.Green;
            }


            if (actDoor == 'C')
            {
                C_DClose.Visible = false;
                C_DOpen.Visible = true;

                lbl_GameMessage.Visible = true;
                lbl_GameMessage.Text = "Correct! You pik the right one";
                lbl_GameMessage.ForeColor = Color.Green;
            }
        }


        private void GameMode_Load(object sender, EventArgs e)
        {
            ResetImages();
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
                markedA.Visible = true;
                SwitchConfirm swc = new SwitchConfirm("You wanna change your Selection, A Door to B Door ?");
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
                markedB.Visible = true;
                SwitchConfirm swc = new SwitchConfirm("You wanna change your Selection, B Door to C Door ?");
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
                markedC.Visible = true;
                SwitchConfirm swc = new SwitchConfirm("You wanna change your Selection, A Door to C Door ?");
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
