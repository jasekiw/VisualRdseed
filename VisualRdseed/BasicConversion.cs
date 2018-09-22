using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace VisualRdseed
{
    class BasicConversion
    {
        public string inputFile = "";
        public string outputFile = "";
        public int fileFormat = 1;
        public void convert(bool fileready, bool outputready)
        {
            bool readytogo = true;

            if (fileready)
            {
                readytogo = false;
                MessageBox.Show("Be sure to set input file!");
            }
            if (outputready)
            {
                readytogo = false;
                MessageBox.Show("Be sure to set output Directory!");
            }
            
            if (readytogo)
            {
                try
                {
                    ProcessStartInfo processInfo = new ProcessStartInfo();
                    processInfo.FileName = "rdseed.exe";
                    processInfo.Arguments = "-d -o " + fileFormat + " -f \"/cygdrive/" + GrabDrive(inputFile) + "/" + RemoveDrivefromString(inputFile) + "\" -q \"/cygdrive/" + GrabDrive(outputFile) + "/" + RemoveDrivefromString(outputFile) + "\"";
                    processInfo.CreateNoWindow = true;
                    processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(processInfo);
                    MessageBox.Show("Converted files were stored in: " + outputFile);
                }
                catch
                {
                    MessageBox.Show("Program components corrup or missing, please reinstall to fix.");
                }

            }
            
        }
        



        string RemoveDrivefromString(string filename)
        {
            return filename.Substring(filename.IndexOf(":") + 2, filename.Length - (filename.IndexOf(":") + 2));
        }

        string GrabDrive(string filename)
        {
            return filename.Substring(0, filename.IndexOf(":")).ToLower();
        }

    }
}
