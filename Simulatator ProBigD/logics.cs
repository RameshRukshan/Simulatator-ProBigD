using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulatator_ProBigD
{
    class logics
    {
        public char selDoor ='x', activeDoor = 'x';
        public int  rNumber = 0;
        public bool status = false;

        public void generateRandomeNumber()
        {
            Random r = new Random();
            rNumber = r.Next();
        }

        public void assignCompDoor()
        {
            generateRandomeNumber();

            if (rNumber % 3 == 0)
                activeDoor = 'A';
            else if (rNumber % 3 == 1)
                activeDoor = 'B';
            else if (rNumber % 3 == 2)
                activeDoor = 'C';

            generateRandomeNumber();

            if (rNumber % 3 == 0)
                selDoor = 'A';
            else if (rNumber % 3 == 1)
                selDoor = 'B';
            else if (rNumber % 3 == 2)
                selDoor = 'C';
        }

        public void check()
        {
            if (activeDoor == selDoor)
            {
                status = true;
            }
            else
            {
                status = false;
            }
        }

        public bool keepModeSt()
        {
            assignCompDoor();
            check();
            return status;
        }

        public string retActDoorS()
        {
            return activeDoor.ToString();
        }

        public string retSelDoor()
        {
            return selDoor.ToString();
        }

        public bool changeModSt()
        {
            assignCompDoor();
            if (selDoor == 'A' && activeDoor =='B')
            {
                selDoor = 'B';
            }else if (selDoor == 'A' && activeDoor == 'c')
            {
                selDoor = 'C';
            }else if (selDoor == 'A' && activeDoor == 'A')
            {
                Random r = new Random();
                rNumber = r.Next();
                if (rNumber % 2 == 0)
                {
                    selDoor = 'B';
                }else if (rNumber % 2 == 1)
                {
                    selDoor = 'C';
                }
            }else if (selDoor == 'B' && activeDoor == 'A')
            {
                selDoor = 'A';
            }
            else if (selDoor == 'B' && activeDoor == 'c')
            {
                selDoor = 'C';
            }
            else if (selDoor == 'B' && activeDoor == 'B')
            {
                Random r = new Random();
                rNumber = r.Next() % 2;
                if (rNumber % 2 == 0)
                {
                    selDoor = 'A';
                }
                else if (rNumber % 2 == 1)
                {
                    selDoor = 'C';
                }
            }
            else if (selDoor == 'C' && activeDoor == 'A')
            {
                selDoor = 'A';
            }
            else if (selDoor == 'C' && activeDoor == 'B')
            {
                selDoor = 'B';
            }
            else if (selDoor == 'C' && activeDoor == 'C')
            {
                Random r = new Random();
                rNumber = r.Next() % 2;
                if (rNumber % 2 == 0)
                {
                    selDoor = 'A';
                }
                else if (rNumber % 2 == 1)
                {
                    selDoor = 'B';
                }
            }
            check();
            return status;
        }
    }
}
