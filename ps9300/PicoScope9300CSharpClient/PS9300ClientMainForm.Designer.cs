/******************************************************************************
 *
 * Filename: PS9300ClientMainForm.Designer.cs
 * 
 * Copyright © 2014-2017 Pico Technology Ltd. See LICENSE file for terms.
 *
 ******************************************************************************/

namespace PicoScope9300CSharpClient
{
    partial class PS9300ClientMainForm
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
            this.lblXStart = new System.Windows.Forms.Label();
            this.lblXEnd = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.btnSingle = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.btnGetSignal = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.lblYTop = new System.Windows.Forms.Label();
            this.lblYBottom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblXStart
            // 
            this.lblXStart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblXStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblXStart.Location = new System.Drawing.Point(144, 370);
            this.lblXStart.Margin = new System.Windows.Forms.Padding(0);
            this.lblXStart.Name = "lblXStart";
            this.lblXStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblXStart.Size = new System.Drawing.Size(188, 17);
            this.lblXStart.TabIndex = 29;
            // 
            // lblXEnd
            // 
            this.lblXEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblXEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXEnd.Location = new System.Drawing.Point(292, 370);
            this.lblXEnd.Margin = new System.Windows.Forms.Padding(0);
            this.lblXEnd.Name = "lblXEnd";
            this.lblXEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblXEnd.Size = new System.Drawing.Size(188, 17);
            this.lblXEnd.TabIndex = 30;
            this.lblXEnd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(42, 121);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(70, 16);
            this.lblResponse.TabIndex = 20;
            this.lblResponse.Text = "Res&ponse:";
            // 
            // btnSingle
            // 
            this.btnSingle.Enabled = false;
            this.btnSingle.Location = new System.Drawing.Point(223, 219);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(70, 25);
            this.btnSingle.TabIndex = 24;
            this.btnSingle.Text = "Si&ngle";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(299, 219);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 25);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(147, 219);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(70, 25);
            this.btnRun.TabIndex = 22;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pbScreen
            // 
            this.pbScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScreen.BackColor = System.Drawing.Color.Black;
            this.pbScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbScreen.Enabled = false;
            this.pbScreen.Location = new System.Drawing.Point(147, 250);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(330, 117);
            this.pbScreen.TabIndex = 23;
            this.pbScreen.TabStop = false;
            // 
            // btnGetSignal
            // 
            this.btnGetSignal.Enabled = false;
            this.btnGetSignal.Location = new System.Drawing.Point(386, 219);
            this.btnGetSignal.Name = "btnGetSignal";
            this.btnGetSignal.Size = new System.Drawing.Size(91, 25);
            this.btnGetSignal.TabIndex = 26;
            this.btnGetSignal.Text = "&Get Signal";
            this.btnGetSignal.UseVisualStyleBackColor = true;
            this.btnGetSignal.Click += new System.EventHandler(this.btnGetSignal_Click);
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Enabled = false;
            this.tbResult.Location = new System.Drawing.Point(147, 121);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(330, 76);
            this.tbResult.TabIndex = 21;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(42, 93);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(71, 16);
            this.lblCommand.TabIndex = 17;
            this.lblCommand.Text = "&Command:";
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(402, 89);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 24);
            this.btnExecute.TabIndex = 19;
            this.btnExecute.Text = "Send";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cbCommand
            // 
            this.cbCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCommand.Enabled = false;
            this.cbCommand.FormattingEnabled = true;
            this.cbCommand.Items.AddRange(new object[] {
            "*Run",
            "*StopSingle Stop",
            "*Autoscale",
            "Wfm:Data?",
            "Wfm:Preamb?",
            "Header Off",
            "Header On"});
            this.cbCommand.Location = new System.Drawing.Point(147, 89);
            this.cbCommand.Name = "cbCommand";
            this.cbCommand.Size = new System.Drawing.Size(249, 24);
            this.cbCommand.TabIndex = 18;
            this.cbCommand.Text = "*Run";
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOff.Enabled = false;
            this.btnOff.Location = new System.Drawing.Point(118, 44);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(70, 25);
            this.btnOff.TabIndex = 16;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOn.Location = new System.Drawing.Point(42, 44);
            this.btnOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(70, 25);
            this.btnOn.TabIndex = 15;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // lblYTop
            // 
            this.lblYTop.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblYTop.Location = new System.Drawing.Point(39, 250);
            this.lblYTop.Margin = new System.Windows.Forms.Padding(0);
            this.lblYTop.Name = "lblYTop";
            this.lblYTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYTop.Size = new System.Drawing.Size(188, 17);
            this.lblYTop.TabIndex = 27;
            // 
            // lblYBottom
            // 
            this.lblYBottom.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblYBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYBottom.Location = new System.Drawing.Point(39, 350);
            this.lblYBottom.Margin = new System.Windows.Forms.Padding(0);
            this.lblYBottom.Name = "lblYBottom";
            this.lblYBottom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYBottom.Size = new System.Drawing.Size(188, 17);
            this.lblYBottom.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 448);
            this.Controls.Add(this.lblXStart);
            this.Controls.Add(this.lblXEnd);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnSingle);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.pbScreen);
            this.Controls.Add(this.btnGetSignal);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cbCommand);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.lblYTop);
            this.Controls.Add(this.lblYBottom);
            this.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "PicoScope 9300 C# Client";
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblXStart;
        internal System.Windows.Forms.Label lblXEnd;
        internal System.Windows.Forms.Label lblResponse;
        internal System.Windows.Forms.Button btnSingle;
        internal System.Windows.Forms.Button btnStop;
        internal System.Windows.Forms.Button btnRun;
        internal System.Windows.Forms.PictureBox pbScreen;
        internal System.Windows.Forms.Button btnGetSignal;
        internal System.Windows.Forms.TextBox tbResult;
        internal System.Windows.Forms.Label lblCommand;
        internal System.Windows.Forms.Button btnExecute;
        internal System.Windows.Forms.ComboBox cbCommand;
        internal System.Windows.Forms.Button btnOff;
        internal System.Windows.Forms.Button btnOn;
        internal System.Windows.Forms.Label lblYTop;
        internal System.Windows.Forms.Label lblYBottom;

    }
}

