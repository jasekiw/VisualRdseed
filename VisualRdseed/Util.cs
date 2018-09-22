using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualRdseed
{
    class Util
    {
        public static string RemoveDrivefromString(string filename)
        {
            return filename.Substring(filename.IndexOf(":") + 2, filename.Length - (filename.IndexOf(":") + 2));
        }

        public static string convertSlashesToUnix(string filepath)
        {
            return filepath.Replace("\\", "/");
        }

        public static string GrabDrive(string filename)
        {
            return filename.Substring(0, filename.IndexOf(":")).ToLower();
        }

        public static string getCygwinPathForFile(string filePath)
        {
            return "/cygdrive/" + GrabDrive(filePath) + "/" + convertSlashesToUnix(RemoveDrivefromString(filePath));
        }

        public static string getFileName(string filePath)
        {
            filePath = RemoveDrivefromString(filePath);
            var lastSlash = filePath.LastIndexOf("\\");
            if(lastSlash > -1)
                filePath = filePath.Substring(lastSlash + 1);
            var indexOfDot = filePath.IndexOf(".");
            if (indexOfDot > -1)
                filePath = filePath.Substring(0, indexOfDot);
            return filePath;
        }
        
        public static string quote(string input)
        {
            return "\"" + input + "\"";
        }

        public static void startRdseed(string arguments)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "rdseed.exe";
            processInfo.Arguments = arguments;
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(processInfo);
        }

        public static bool canConvert(bool fileready, bool outputready)
        {
            if (fileready) {
                MessageBox.Show("Be sure to set input file!");
                return false;
            }
            if (outputready) {
                MessageBox.Show("Be sure to set output Directory!");
                return false;
            }
            return true;
        }

    }
}

