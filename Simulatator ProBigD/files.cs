using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Simulatator_ProBigD
{
    class files
    {
        public void exmp()
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it
            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
        }

        public void writelog(String Door)
        {
            File.AppendAllText("log.txt", ""+Door+"    ");
        }

        public void clearLog()
        {
            File.WriteAllText("log.txt"," ");
        }

        public string readLog()
        {
            String data = Convert.ToString(File.ReadAllText("log.txt"));
            return data;
        }

        public void writeSelectedtDoor(String doorNum)
        {
            File.WriteAllText("currentDoor.txt", doorNum);
        }

        public void writeRoundNum(int round)
        {
            File.WriteAllText("round.txt", round.ToString());
        }

        public void writeCorrectAns(int count)
        {
            File.WriteAllText("count.txt", count.ToString());
        }

        public int readRound()
        {
            int round = Convert.ToInt32(File.ReadAllText("round.txt"));
            return round;
        }

        public int readCorrectAns()
        {
            int count = Convert.ToInt32(File.ReadAllText("count.txt"));
            return count;
        }

        public string readDoor()
        {
            string readText = File.ReadAllText("filename.txt");
            return readText;
        }

        public void incrRound()
        {
            int round = readRound();
            round = round + 1;
            writeRoundNum(round);
        }

        public void incCount()
        {
            int count = readCorrectAns();
            count = count + 1;
            writeCorrectAns(count);
        }

    }
}
