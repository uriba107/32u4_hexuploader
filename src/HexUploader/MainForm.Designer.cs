namespace HexUploader
{
    partial class main
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
            this.buttonUpload = new System.Windows.Forms.Button();
            this.selectCom = new System.Windows.Forms.ComboBox();
            this.textBoxHexPath = new System.Windows.Forms.TextBox();
            this.buttonBrowsHex = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonModeHID = new System.Windows.Forms.RadioButton();
            this.radioButtonModeSerial = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UploadProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBoxMode.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpload
            // 
            this.buttonUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpload.Location = new System.Drawing.Point(146, 217);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(174, 65);
            this.buttonUpload.TabIndex = 0;
            this.buttonUpload.Text = "Upload Hex";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // selectCom
            // 
            this.selectCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectCom.FormattingEnabled = true;
            this.selectCom.Location = new System.Drawing.Point(246, 23);
            this.selectCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectCom.Name = "selectCom";
            this.selectCom.Size = new System.Drawing.Size(133, 28);
            this.selectCom.TabIndex = 1;
            this.selectCom.DropDown += new System.EventHandler(this.selectCom_DropDown);
            // 
            // textBoxHexPath
            // 
            this.textBoxHexPath.AllowDrop = true;
            this.textBoxHexPath.Location = new System.Drawing.Point(18, 51);
            this.textBoxHexPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHexPath.Name = "textBoxHexPath";
            this.textBoxHexPath.Size = new System.Drawing.Size(332, 26);
            this.textBoxHexPath.TabIndex = 4;
            this.textBoxHexPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxHexPath_DragDrop);
            this.textBoxHexPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxHexPath_DragEnter);
            // 
            // buttonBrowsHex
            // 
            this.buttonBrowsHex.Location = new System.Drawing.Point(362, 46);
            this.buttonBrowsHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBrowsHex.Name = "buttonBrowsHex";
            this.buttonBrowsHex.Size = new System.Drawing.Size(38, 35);
            this.buttonBrowsHex.TabIndex = 5;
            this.buttonBrowsHex.Text = "...";
            this.buttonBrowsHex.UseVisualStyleBackColor = true;
            this.buttonBrowsHex.Click += new System.EventHandler(this.buttonBrowsHex_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(14, 14);
            this.labelPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(162, 20);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "Select HEX to upload";
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMode.Controls.Add(this.radioButtonModeHID);
            this.groupBoxMode.Controls.Add(this.radioButtonModeSerial);
            this.groupBoxMode.Controls.Add(this.selectCom);
            this.groupBoxMode.Location = new System.Drawing.Point(18, 91);
            this.groupBoxMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMode.Size = new System.Drawing.Size(390, 111);
            this.groupBoxMode.TabIndex = 8;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Select Upload Mode";
            // 
            // radioButtonModeHID
            // 
            this.radioButtonModeHID.AutoSize = true;
            this.radioButtonModeHID.Location = new System.Drawing.Point(9, 66);
            this.radioButtonModeHID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonModeHID.Name = "radioButtonModeHID";
            this.radioButtonModeHID.Size = new System.Drawing.Size(175, 24);
            this.radioButtonModeHID.TabIndex = 1;
            this.radioButtonModeHID.TabStop = true;
            this.radioButtonModeHID.Text = "Device in HID Mode";
            this.radioButtonModeHID.UseVisualStyleBackColor = true;
            this.radioButtonModeHID.CheckedChanged += new System.EventHandler(this.radioButtonModeSerial_CheckedChanged);
            // 
            // radioButtonModeSerial
            // 
            this.radioButtonModeSerial.AutoSize = true;
            this.radioButtonModeSerial.Checked = true;
            this.radioButtonModeSerial.Location = new System.Drawing.Point(10, 31);
            this.radioButtonModeSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonModeSerial.Name = "radioButtonModeSerial";
            this.radioButtonModeSerial.Size = new System.Drawing.Size(186, 24);
            this.radioButtonModeSerial.TabIndex = 0;
            this.radioButtonModeSerial.TabStop = true;
            this.radioButtonModeSerial.Text = "Device in Serial Mode";
            this.radioButtonModeSerial.UseVisualStyleBackColor = true;
            this.radioButtonModeSerial.CheckedChanged += new System.EventHandler(this.radioButtonModeSerial_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UploadProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(426, 28);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UploadProgressBar
            // 
            this.UploadProgressBar.Name = "UploadProgressBar";
            this.UploadProgressBar.Size = new System.Drawing.Size(100, 22);
            this.UploadProgressBar.Step = 5;
            this.UploadProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 327);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonBrowsHex);
            this.Controls.Add(this.textBoxHexPath);
            this.Controls.Add(this.buttonUpload);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(889, 585);
            this.MinimumSize = new System.Drawing.Size(439, 278);
            this.Name = "main";
            this.Text = "32U4 Hex Uploader";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxHexPath_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxHexPath_DragEnter);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.ComboBox selectCom;
        private System.Windows.Forms.TextBox textBoxHexPath;
        private System.Windows.Forms.Button buttonBrowsHex;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioButtonModeHID;
        private System.Windows.Forms.RadioButton radioButtonModeSerial;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar UploadProgressBar;
    }
}

