namespace URG_04LX_Data_Decoder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.staStatus = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDataCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.chkHex = new System.Windows.Forms.CheckBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.radDec = new System.Windows.Forms.RadioButton();
            this.radHex = new System.Windows.Forms.RadioButton();
            this.radString = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.staStatus.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // staStatus
            // 
            this.staStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus,
            this.tsDataCount});
            this.staStatus.Location = new System.Drawing.Point(0, 515);
            this.staStatus.Name = "staStatus";
            this.staStatus.Size = new System.Drawing.Size(935, 22);
            this.staStatus.TabIndex = 7;
            this.staStatus.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(795, 17);
            this.tsStatus.Spring = true;
            this.tsStatus.Text = "Ready";
            this.tsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsDataCount
            // 
            this.tsDataCount.AutoSize = false;
            this.tsDataCount.Name = "tsDataCount";
            this.tsDataCount.Size = new System.Drawing.Size(125, 17);
            this.tsDataCount.Text = "Data Count: 682";
            this.tsDataCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(87, 19);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(107, 28);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "&Convert to Hex";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // grpInput
            // 
            this.grpInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInput.Controls.Add(this.btnDecode);
            this.grpInput.Controls.Add(this.chkHex);
            this.grpInput.Controls.Add(this.txtInput);
            this.grpInput.Controls.Add(this.btnConvert);
            this.grpInput.Location = new System.Drawing.Point(12, 6);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(475, 500);
            this.grpInput.TabIndex = 6;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecode.Location = new System.Drawing.Point(362, 19);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(107, 28);
            this.btnDecode.TabIndex = 4;
            this.btnDecode.Text = "&Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // chkHex
            // 
            this.chkHex.AutoSize = true;
            this.chkHex.Checked = true;
            this.chkHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHex.Location = new System.Drawing.Point(6, 26);
            this.chkHex.Name = "chkHex";
            this.chkHex.Size = new System.Drawing.Size(77, 17);
            this.chkHex.TabIndex = 1;
            this.chkHex.Text = "Hex Value";
            this.chkHex.UseVisualStyleBackColor = true;
            this.chkHex.CheckedChanged += new System.EventHandler(this.chkHex_CheckedChanged);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(6, 53);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(463, 441);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = resources.GetString("txtInput.Text");
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.radDec);
            this.grpOutput.Controls.Add(this.radHex);
            this.grpOutput.Controls.Add(this.radString);
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Location = new System.Drawing.Point(493, 6);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(430, 500);
            this.grpOutput.TabIndex = 8;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // radDec
            // 
            this.radDec.AutoSize = true;
            this.radDec.Location = new System.Drawing.Point(118, 25);
            this.radDec.Name = "radDec";
            this.radDec.Size = new System.Drawing.Size(44, 17);
            this.radDec.TabIndex = 7;
            this.radDec.Text = "Dec";
            this.radDec.UseVisualStyleBackColor = true;
            // 
            // radHex
            // 
            this.radHex.AutoSize = true;
            this.radHex.Location = new System.Drawing.Point(68, 25);
            this.radHex.Name = "radHex";
            this.radHex.Size = new System.Drawing.Size(44, 17);
            this.radHex.TabIndex = 7;
            this.radHex.Text = "Hex";
            this.radHex.UseVisualStyleBackColor = true;
            // 
            // radString
            // 
            this.radString.AutoSize = true;
            this.radString.Checked = true;
            this.radString.Location = new System.Drawing.Point(6, 25);
            this.radString.Name = "radString";
            this.radString.Size = new System.Drawing.Size(56, 17);
            this.radString.TabIndex = 7;
            this.radString.TabStop = true;
            this.radString.Text = "String";
            this.radString.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(6, 53);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(418, 441);
            this.txtOutput.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 537);
            this.Controls.Add(this.staStatus);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpOutput);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "URG-04LX RAW Data Decoder";
            this.staStatus.ResumeLayout(false);
            this.staStatus.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip staStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsDataCount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.CheckBox chkHex;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.RadioButton radDec;
        private System.Windows.Forms.RadioButton radHex;
        private System.Windows.Forms.RadioButton radString;
        private System.Windows.Forms.TextBox txtOutput;

    }
}

