namespace VisualRdseed
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtChooseFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChooseOutput = new System.Windows.Forms.TextBox();
            this.cbFileType = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpBasic = new System.Windows.Forms.TabPage();
            this.tpAdvanced = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbExtractYes = new System.Windows.Forms.RadioButton();
            this.rbExtractNo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBuffer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPolesYes = new System.Windows.Forms.RadioButton();
            this.rbPolesNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEndtimeYes = new System.Windows.Forms.RadioButton();
            this.rbEndtimeNo = new System.Windows.Forms.RadioButton();
            this.cbAdvType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdvInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAdvOutput = new System.Windows.Forms.TextBox();
            this.tcMain.SuspendLayout();
            this.tpBasic.SuspendLayout();
            this.tpAdvanced.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChooseFile
            // 
            this.txtChooseFile.Location = new System.Drawing.Point(104, 30);
            this.txtChooseFile.Name = "txtChooseFile";
            this.txtChooseFile.ReadOnly = true;
            this.txtChooseFile.Size = new System.Drawing.Size(137, 20);
            this.txtChooseFile.TabIndex = 1;
            this.txtChooseFile.Text = "Click here to Browse";
            this.txtChooseFile.Click += new System.EventHandler(this.txtChooseFile_Click);
            this.txtChooseFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChooseFile_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input seed file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Directory:";
            // 
            // txtChooseOutput
            // 
            this.txtChooseOutput.Location = new System.Drawing.Point(104, 97);
            this.txtChooseOutput.Name = "txtChooseOutput";
            this.txtChooseOutput.ReadOnly = true;
            this.txtChooseOutput.Size = new System.Drawing.Size(137, 20);
            this.txtChooseOutput.TabIndex = 3;
            this.txtChooseOutput.Text = "Click here toSelect Folder";
            this.txtChooseOutput.Click += new System.EventHandler(this.txtChooseOutput_Click);
            this.txtChooseOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChooseOutput_KeyPress);
            // 
            // cbFileType
            // 
            this.cbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileType.FormattingEnabled = true;
            this.cbFileType.Items.AddRange(new object[] {
            "SAC",
            "AH",
            "CSS",
            "miniSEED",
            "SEED",
            "SAC ALPHA",
            "SEGY"});
            this.cbFileType.Location = new System.Drawing.Point(104, 62);
            this.cbFileType.Name = "cbFileType";
            this.cbFileType.Size = new System.Drawing.Size(58, 21);
            this.cbFileType.TabIndex = 0;
            this.cbFileType.Tag = "";
            this.cbFileType.SelectedIndexChanged += new System.EventHandler(this.cbFileType_SelectedIndexChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(73, 130);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(125, 32);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Save Type:";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpBasic);
            this.tcMain.Controls.Add(this.tpAdvanced);
            this.tcMain.Location = new System.Drawing.Point(-3, -2);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(330, 314);
            this.tcMain.TabIndex = 7;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpBasic
            // 
            this.tpBasic.Controls.Add(this.cbFileType);
            this.tpBasic.Controls.Add(this.label3);
            this.tpBasic.Controls.Add(this.txtChooseFile);
            this.tpBasic.Controls.Add(this.btnConvert);
            this.tpBasic.Controls.Add(this.label1);
            this.tpBasic.Controls.Add(this.label2);
            this.tpBasic.Controls.Add(this.txtChooseOutput);
            this.tpBasic.Location = new System.Drawing.Point(4, 22);
            this.tpBasic.Name = "tpBasic";
            this.tpBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tpBasic.Size = new System.Drawing.Size(322, 288);
            this.tpBasic.TabIndex = 0;
            this.tpBasic.Text = "Basic";
            this.tpBasic.UseVisualStyleBackColor = true;
            // 
            // tpAdvanced
            // 
            this.tpAdvanced.Controls.Add(this.groupBox3);
            this.tpAdvanced.Controls.Add(this.label7);
            this.tpAdvanced.Controls.Add(this.tbBuffer);
            this.tpAdvanced.Controls.Add(this.groupBox2);
            this.tpAdvanced.Controls.Add(this.groupBox1);
            this.tpAdvanced.Controls.Add(this.cbAdvType);
            this.tpAdvanced.Controls.Add(this.label4);
            this.tpAdvanced.Controls.Add(this.tbAdvInput);
            this.tpAdvanced.Controls.Add(this.button1);
            this.tpAdvanced.Controls.Add(this.label5);
            this.tpAdvanced.Controls.Add(this.label6);
            this.tpAdvanced.Controls.Add(this.tbAdvOutput);
            this.tpAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tpAdvanced.Name = "tpAdvanced";
            this.tpAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvanced.Size = new System.Drawing.Size(322, 288);
            this.tpAdvanced.TabIndex = 1;
            this.tpAdvanced.Text = "Advanced";
            this.tpAdvanced.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbExtractYes);
            this.groupBox3.Controls.Add(this.rbExtractNo);
            this.groupBox3.Location = new System.Drawing.Point(6, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 46);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extract Responses";
            // 
            // rbExtractYes
            // 
            this.rbExtractYes.AutoSize = true;
            this.rbExtractYes.Location = new System.Drawing.Point(12, 19);
            this.rbExtractYes.Name = "rbExtractYes";
            this.rbExtractYes.Size = new System.Drawing.Size(43, 17);
            this.rbExtractYes.TabIndex = 19;
            this.rbExtractYes.Text = "Yes";
            this.rbExtractYes.UseVisualStyleBackColor = true;
            this.rbExtractYes.CheckedChanged += new System.EventHandler(this.rbExtractYes_CheckedChanged);
            // 
            // rbExtractNo
            // 
            this.rbExtractNo.AutoSize = true;
            this.rbExtractNo.Checked = true;
            this.rbExtractNo.Location = new System.Drawing.Point(70, 19);
            this.rbExtractNo.Name = "rbExtractNo";
            this.rbExtractNo.Size = new System.Drawing.Size(39, 17);
            this.rbExtractNo.TabIndex = 20;
            this.rbExtractNo.TabStop = true;
            this.rbExtractNo.Text = "No";
            this.rbExtractNo.UseVisualStyleBackColor = true;
            this.rbExtractNo.CheckedChanged += new System.EventHandler(this.rbExtractNo_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sample Buffer Length:";
            // 
            // tbBuffer
            // 
            this.tbBuffer.Location = new System.Drawing.Point(129, 154);
            this.tbBuffer.Name = "tbBuffer";
            this.tbBuffer.Size = new System.Drawing.Size(68, 20);
            this.tbBuffer.TabIndex = 19;
            this.tbBuffer.Text = "2000000";
            this.tbBuffer.TextChanged += new System.EventHandler(this.tbBuffer_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPolesYes);
            this.groupBox2.Controls.Add(this.rbPolesNo);
            this.groupBox2.Location = new System.Drawing.Point(129, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 47);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output poles and zeroes?";
            // 
            // rbPolesYes
            // 
            this.rbPolesYes.AutoSize = true;
            this.rbPolesYes.Location = new System.Drawing.Point(14, 21);
            this.rbPolesYes.Name = "rbPolesYes";
            this.rbPolesYes.Size = new System.Drawing.Size(43, 17);
            this.rbPolesYes.TabIndex = 17;
            this.rbPolesYes.Text = "Yes";
            this.rbPolesYes.UseVisualStyleBackColor = true;
            this.rbPolesYes.CheckedChanged += new System.EventHandler(this.rbPolesYes_CheckedChanged);
            // 
            // rbPolesNo
            // 
            this.rbPolesNo.AutoSize = true;
            this.rbPolesNo.Checked = true;
            this.rbPolesNo.Location = new System.Drawing.Point(72, 21);
            this.rbPolesNo.Name = "rbPolesNo";
            this.rbPolesNo.Size = new System.Drawing.Size(39, 17);
            this.rbPolesNo.TabIndex = 18;
            this.rbPolesNo.TabStop = true;
            this.rbPolesNo.Text = "No";
            this.rbPolesNo.UseVisualStyleBackColor = true;
            this.rbPolesNo.CheckedChanged += new System.EventHandler(this.rbPolesNo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEndtimeYes);
            this.groupBox1.Controls.Add(this.rbEndtimeNo);
            this.groupBox1.Location = new System.Drawing.Point(14, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 47);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Include endtime?";
            // 
            // rbEndtimeYes
            // 
            this.rbEndtimeYes.AutoSize = true;
            this.rbEndtimeYes.Location = new System.Drawing.Point(6, 19);
            this.rbEndtimeYes.Name = "rbEndtimeYes";
            this.rbEndtimeYes.Size = new System.Drawing.Size(43, 17);
            this.rbEndtimeYes.TabIndex = 15;
            this.rbEndtimeYes.Text = "Yes";
            this.rbEndtimeYes.UseVisualStyleBackColor = true;
            this.rbEndtimeYes.CheckedChanged += new System.EventHandler(this.rbEndtimeYes_CheckedChanged);
            // 
            // rbEndtimeNo
            // 
            this.rbEndtimeNo.AutoSize = true;
            this.rbEndtimeNo.Checked = true;
            this.rbEndtimeNo.Location = new System.Drawing.Point(55, 19);
            this.rbEndtimeNo.Name = "rbEndtimeNo";
            this.rbEndtimeNo.Size = new System.Drawing.Size(39, 17);
            this.rbEndtimeNo.TabIndex = 16;
            this.rbEndtimeNo.TabStop = true;
            this.rbEndtimeNo.Text = "No";
            this.rbEndtimeNo.UseVisualStyleBackColor = true;
            this.rbEndtimeNo.CheckedChanged += new System.EventHandler(this.rbEndtimeNo_CheckedChanged);
            // 
            // cbAdvType
            // 
            this.cbAdvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdvType.FormattingEnabled = true;
            this.cbAdvType.Items.AddRange(new object[] {
            "SAC",
            "AH",
            "CSS",
            "miniSEED",
            "SEED",
            "SAC ALPHA",
            "SEGY"});
            this.cbAdvType.Location = new System.Drawing.Point(104, 42);
            this.cbAdvType.Name = "cbAdvType";
            this.cbAdvType.Size = new System.Drawing.Size(58, 21);
            this.cbAdvType.TabIndex = 8;
            this.cbAdvType.Tag = "";
            this.cbAdvType.SelectedIndexChanged += new System.EventHandler(this.cbAdvType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Save Type:";
            // 
            // tbAdvInput
            // 
            this.tbAdvInput.Location = new System.Drawing.Point(104, 16);
            this.tbAdvInput.Name = "tbAdvInput";
            this.tbAdvInput.ReadOnly = true;
            this.tbAdvInput.Size = new System.Drawing.Size(137, 20);
            this.tbAdvInput.TabIndex = 9;
            this.tbAdvInput.Text = "Click here to Browse";
            this.tbAdvInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbAdvInput_MouseClick);
            this.tbAdvInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAdvInput_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Input seed file:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Output Directory:";
            // 
            // tbAdvOutput
            // 
            this.tbAdvOutput.Location = new System.Drawing.Point(104, 72);
            this.tbAdvOutput.Name = "tbAdvOutput";
            this.tbAdvOutput.ReadOnly = true;
            this.tbAdvOutput.Size = new System.Drawing.Size(137, 20);
            this.tbAdvOutput.TabIndex = 11;
            this.tbAdvOutput.Text = "Click here toSelect Folder";
            this.tbAdvOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbAdvOutput_MouseClick);
            this.tbAdvOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAdvOutput_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 324);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Visual Rdseed";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tpBasic.ResumeLayout(false);
            this.tpBasic.PerformLayout();
            this.tpAdvanced.ResumeLayout(false);
            this.tpAdvanced.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtChooseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChooseOutput;
        private System.Windows.Forms.ComboBox cbFileType;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpBasic;
        private System.Windows.Forms.TabPage tpAdvanced;
        private System.Windows.Forms.ComboBox cbAdvType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdvInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAdvOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbExtractYes;
        private System.Windows.Forms.RadioButton rbExtractNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBuffer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPolesYes;
        private System.Windows.Forms.RadioButton rbPolesNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEndtimeYes;
        private System.Windows.Forms.RadioButton rbEndtimeNo;
    }
}

