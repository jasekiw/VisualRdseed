using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace VisualRdseed
{
    class AdvancedConverter
    {
        public string[] inputFiles = new string[0];
        public string outputFile = "";
        public int fileFormat = 1;
        public string endtime = "";
        public string Poles = "";
        public string ExactResponses = "";
        public string Buffer = "";

        public void convert(bool fileready, bool outputready)
        {
            if (!Util.canConvert(fileready, outputready))
                return;

            try
            {
                foreach (string inputFile in this.inputFiles)
                {
                    var desination = outputFile + "\\" + Util.getFileName(inputFile);
                    Directory.CreateDirectory(desination);
                    Util.startRdseed("-d -o " + fileFormat + " " + endtime + Poles + ExactResponses + Buffer +
                                     " -f " + Util.quote(Util.getCygwinPathForFile(inputFile)) +
                                     " -q " + Util.quote(Util.getCygwinPathForFile(desination)));
                }

                MessageBox.Show("Converted files were stored in: " + outputFile);
            }
            catch
            {
                MessageBox.Show("Program components corrup or missing, please reinstall to fix.");
            }

        }

    }


}
