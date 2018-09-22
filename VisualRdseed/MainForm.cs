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
            BasicConversion Bconv = new BasicConversion();
            AdvancedConversion Aconv = new AdvancedConversion();
        
            #region GuiVoids

             #region basicConvert
        private void txtChooseFile_KeyPress(object sender, KeyPressEventArgs e)
                {
                    Bconv.inputFile = InteractChooseInput();
                }

                private void txtChooseOutput_KeyPress(object sender, KeyPressEventArgs e)
                {
                    Bconv.outputFile = InteractChooseOutput();
                }
        

                private void txtChooseFile_Click(object sender, EventArgs e)
                {
                    Bconv.inputFile = InteractChooseInput();
                }

                private void txtChooseOutput_Click(object sender, EventArgs e)
                {

                    Bconv.outputFile = InteractChooseOutput();
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
                    Bconv.convert(txtChooseFile.Text.ToUpper().Contains("BROWSE"), txtChooseOutput.Text.ToUpper().Contains("SELECT"));
                }

                private void cbFileType_SelectedIndexChanged(object sender, EventArgs e)
                {
                    Bconv.fileFormat = cbFileType.SelectedIndex + 1;
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

               
                


            private string InteractChooseInput()
            {
                OpenFileDialog diagopen = new OpenFileDialog();
                if (diagopen.ShowDialog() == DialogResult.OK)
                {
                    txtChooseFile.Text = diagopen.FileName;
                    return diagopen.FileName;
                }
                else
                {
                    return null;
                }
            }
            private string InteractChooseOutput()
            {
                FolderBrowserDialog diagsave = new FolderBrowserDialog();
                if (diagsave.ShowDialog() == DialogResult.OK)
                {
                    txtChooseOutput.Text = diagsave.SelectedPath;
                    return diagsave.SelectedPath;
                }
                else
                {
                    return null;
                }
            }

        #endregion

            private void rbEndtimeNo_CheckedChanged(object sender, EventArgs e)
            {
                if (rbEndtimeNo.Checked)
                {
                    Aconv.endtime = "";
                }
            }

            private void rbEndtimeYes_CheckedChanged(object sender, EventArgs e)
            {
                if (rbEndtimeYes.Checked)
                {
                    Aconv.endtime = "-E y ";
                }
            }

            private void rbPolesNo_CheckedChanged(object sender, EventArgs e)
            {
                if (rbPolesNo.Checked)
                {
                    Aconv.Poles = "";
                }
            }

            private void rbPolesYes_CheckedChanged(object sender, EventArgs e)
            {
                if (rbPolesYes.Checked)
                {
                    Aconv.Poles = "-p y ";
                }
            }

            private void tbBuffer_TextChanged(object sender, EventArgs e)
            {
                Aconv.Buffer = "-b " + tbBuffer.Text + " ";
            }

            private void rbExtractNo_CheckedChanged(object sender, EventArgs e)
            {
                if (rbExtractNo.Checked)
                {
                    Aconv.ExactResponses = "";
                }
            }

            private void rbExtractYes_CheckedChanged(object sender, EventArgs e)
            {
                if (rbExtractYes.Checked)
                {
                    Aconv.ExactResponses = "-R y ";
                }
            }

            private void cbAdvType_SelectedIndexChanged(object sender, EventArgs e)
            {
                Aconv.fileFormat = cbAdvType.SelectedIndex + 1;
            }

            private void tbAdvInput_MouseClick(object sender, MouseEventArgs e)
            {
                string filename = InteractChooseInput();
                Aconv.inputFile = filename;
                tbAdvInput.Text = filename;
            }

            private void tbAdvInput_KeyPress(object sender, KeyPressEventArgs e)
            {
                string filename = InteractChooseInput();
                Aconv.inputFile = filename;
                tbAdvInput.Text = filename;
            }

            private void tbAdvOutput_KeyPress(object sender, KeyPressEventArgs e)
            {
                string filename = InteractChooseOutput();
                Aconv.outputFile = filename;
                tbAdvOutput.Text = filename;
            }

            private void tbAdvOutput_MouseClick(object sender, MouseEventArgs e)
            {
                string filename = InteractChooseOutput();
                Aconv.outputFile = filename;
                tbAdvOutput.Text = filename;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                Aconv.convert(tbAdvInput.Text.ToUpper().Contains("BROWSE"), tbAdvOutput.Text.ToUpper().Contains("SELECT"));
            }

           



    }
}
