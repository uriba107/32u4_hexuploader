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
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpload
            // 
            this.buttonUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpload.Location = new System.Drawing.Point(97, 140);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(116, 42);
            this.buttonUpload.TabIndex = 0;
            this.buttonUpload.Text = "Upload Hex";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // selectCom
            // 
            this.selectCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectCom.FormattingEnabled = true;
            this.selectCom.Location = new System.Drawing.Point(164, 15);
            this.selectCom.Name = "selectCom";
            this.selectCom.Size = new System.Drawing.Size(90, 21);
            this.selectCom.TabIndex = 1;
            this.selectCom.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // textBoxHexPath
            // 
            this.textBoxHexPath.AllowDrop = true;
            this.textBoxHexPath.Location = new System.Drawing.Point(12, 33);
            this.textBoxHexPath.Name = "textBoxHexPath";
            this.textBoxHexPath.Size = new System.Drawing.Size(223, 20);
            this.textBoxHexPath.TabIndex = 4;
            this.textBoxHexPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxHexPath_DragDrop);
            this.textBoxHexPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxHexPath_DragEnter);
            // 
            // buttonBrowsHex
            // 
            this.buttonBrowsHex.Location = new System.Drawing.Point(241, 30);
            this.buttonBrowsHex.Name = "buttonBrowsHex";
            this.buttonBrowsHex.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowsHex.TabIndex = 5;
            this.buttonBrowsHex.Text = "...";
            this.buttonBrowsHex.UseVisualStyleBackColor = true;
            this.buttonBrowsHex.Click += new System.EventHandler(this.buttonBrowsHex_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(9, 9);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(109, 13);
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
            this.groupBoxMode.Location = new System.Drawing.Point(12, 59);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(260, 72);
            this.groupBoxMode.TabIndex = 8;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Select Upload Mode";
            // 
            // radioButtonModeHID
            // 
            this.radioButtonModeHID.AutoSize = true;
            this.radioButtonModeHID.Location = new System.Drawing.Point(6, 43);
            this.radioButtonModeHID.Name = "radioButtonModeHID";
            this.radioButtonModeHID.Size = new System.Drawing.Size(122, 17);
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
            this.radioButtonModeSerial.Location = new System.Drawing.Point(7, 20);
            this.radioButtonModeSerial.Name = "radioButtonModeSerial";
            this.radioButtonModeSerial.Size = new System.Drawing.Size(129, 17);
            this.radioButtonModeSerial.TabIndex = 0;
            this.radioButtonModeSerial.TabStop = true;
            this.radioButtonModeSerial.Text = "Device in Serial Mode";
            this.radioButtonModeSerial.UseVisualStyleBackColor = true;
            this.radioButtonModeSerial.CheckedChanged += new System.EventHandler(this.radioButtonModeSerial_CheckedChanged);
            // 
            // main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonBrowsHex);
            this.Controls.Add(this.textBoxHexPath);
            this.Controls.Add(this.buttonUpload);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "main";
            this.Text = "32U4 Hex Uploader";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxHexPath_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxHexPath_DragEnter);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
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
    }
}

