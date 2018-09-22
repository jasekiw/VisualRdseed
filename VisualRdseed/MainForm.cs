using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace VisualRdseed
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        BasicConverter basicConverter = new BasicConverter();
        AdvancedConverter advancedConverter = new AdvancedConverter();

        #region GuiVoids

        #region basicConvert

        private void txtChooseFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.basicConverter_chooseInputFile();
        }

        private void txtChooseOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            basicConverter.outputFile = InteractChooseOutput();
        }


        private void txtChooseFile_Click(object sender, EventArgs e)
        {
            this.basicConverter_chooseInputFile();
        }

        private void basicConverter_chooseInputFile()
        {
            string[] inputFiles = InteractChooseInput();
            if (inputFiles.Length == 0)
                return;
            basicConverter.inputFiles = inputFiles;
            txtChooseFile.Text = String.Join(";", inputFiles);
        }

        private void advancedConverter_chooseInputFile()
        {
            string[] inputFiles = InteractChooseInput();

            if (inputFiles.Length == 0)
                return;
            advancedConverter.inputFiles = inputFiles;
            tbAdvInput.Text = String.Join(";", inputFiles);
        }

        private void txtChooseOutput_Click(object sender, EventArgs e)
        {
            basicConverter.outputFile = InteractChooseOutput();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbAdvType.SelectedIndex = 0;
            cbFileType.SelectedIndex = 0;
            this.Width = 299;
            this.Height = 305;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            basicConverter.convert(txtChooseFile.Text.ToUpper().Contains("BROWSE"),
                txtChooseOutput.Text.ToUpper().Contains("SELECT"));
        }

        private void cbFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            basicConverter.fileFormat = cbFileType.SelectedIndex + 1;
        }

        #endregion

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedIndex == 0)
            {
                this.Width = 299;
                this.Height = 305;
            }
            else if (tcMain.SelectedIndex == 1)
            {
                this.Width = 310;
                this.Height = 320;
            }
        }

        #endregion

        #region personalvoids

        private string[] InteractChooseInput()
        {
            OpenFileDialog diagopen = new OpenFileDialog();
            diagopen.Multiselect = true;
            if (diagopen.ShowDialog() == DialogResult.OK)
            {
                return diagopen.FileNames;
            }
            return new string[0];
        }

        private string InteractChooseOutput()
        {
            FolderBrowserDialog diagsave = new FolderBrowserDialog();
            if (diagsave.ShowDialog() == DialogResult.OK)
            {
                txtChooseOutput.Text = diagsave.SelectedPath;
                return diagsave.SelectedPath;
            }
            return null;
        }

        #endregion

        private void rbEndtimeNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEndtimeNo.Checked)
            {
                advancedConverter.endtime = "";
            }
        }

        private void rbEndtimeYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEndtimeYes.Checked)
            {
                advancedConverter.endtime = "-E y ";
            }
        }

        private void rbPolesNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPolesNo.Checked)
            {
                advancedConverter.Poles = "";
            }
        }

        private void rbPolesYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPolesYes.Checked)
            {
                advancedConverter.Poles = "-p y ";
            }
        }

        private void tbBuffer_TextChanged(object sender, EventArgs e)
        {
            advancedConverter.Buffer = "-b " + tbBuffer.Text + " ";
        }

        private void rbExtractNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExtractNo.Checked)
            {
                advancedConverter.ExactResponses = "";
            }
        }

        private void rbExtractYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExtractYes.Checked)
            {
                advancedConverter.ExactResponses = "-R y ";
            }
        }

        private void cbAdvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            advancedConverter.fileFormat = cbAdvType.SelectedIndex + 1;
        }

        private void tbAdvInput_MouseClick(object sender, MouseEventArgs e)
        {
            this.advancedConverter_chooseInputFile();
        }

        private void tbAdvInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.advancedConverter_chooseInputFile();
        }

        private void tbAdvOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filename = InteractChooseOutput();
            if (filename == null)
                return;
            advancedConverter.outputFile = filename;
            tbAdvOutput.Text = filename;
        }

        private void tbAdvOutput_MouseClick(object sender, MouseEventArgs e)
        {
            string filename = InteractChooseOutput();
            if (filename == null)
                return;
            advancedConverter.outputFile = filename;
            tbAdvOutput.Text = filename;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            advancedConverter.convert(tbAdvInput.Text.ToUpper().Contains("BROWSE"),
                tbAdvOutput.Text.ToUpper().Contains("SELECT"));
        }
    }
}