namespace Robot
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGo10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRobot = new System.Windows.Forms.Label();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lbDirections = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDataFill = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.loopCheck = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(817, 644);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 47);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGo10
            // 
            this.btnGo10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo10.Location = new System.Drawing.Point(349, 541);
            this.btnGo10.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnGo10.Name = "btnGo10";
            this.btnGo10.Size = new System.Drawing.Size(96, 44);
            this.btnGo10.TabIndex = 16;
            this.btnGo10.Text = "Go 10";
            this.btnGo10.Click += new System.EventHandler(this.btnGo10_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblRobot);
            this.panel1.Location = new System.Drawing.Point(17, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 394);
            this.panel1.TabIndex = 15;
            // 
            // lblRobot
            // 
            this.lblRobot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblRobot.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblRobot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRobot.Location = new System.Drawing.Point(200, 192);
            this.lblRobot.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(24, 23);
            this.lblRobot.TabIndex = 0;
            this.lblRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGo1
            // 
            this.btnGo1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo1.Location = new System.Drawing.Point(17, 541);
            this.btnGo1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(96, 44);
            this.btnGo1.TabIndex = 14;
            this.btnGo1.Text = "Go 1";
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(258, 541);
            this.btnE.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(48, 44);
            this.btnE.TabIndex = 13;
            this.btnE.Text = "E";
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(159, 541);
            this.btnW.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(48, 44);
            this.btnW.TabIndex = 12;
            this.btnW.Text = "W";
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(208, 586);
            this.btnS.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(48, 44);
            this.btnS.TabIndex = 11;
            this.btnS.Text = "S";
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(208, 497);
            this.btnN.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(48, 44);
            this.btnN.TabIndex = 10;
            this.btnN.Text = "N";
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(44, 17);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(200, 31);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDirections
            // 
            this.lbDirections.FormattingEnabled = true;
            this.lbDirections.IntegralHeight = false;
            this.lbDirections.ItemHeight = 25;
            this.lbDirections.Location = new System.Drawing.Point(614, 82);
            this.lbDirections.Name = "lbDirections";
            this.lbDirections.Size = new System.Drawing.Size(331, 548);
            this.lbDirections.TabIndex = 18;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(673, 644);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(128, 47);
            this.btnPlay.TabIndex = 19;
            this.btnPlay.Text = "Play";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(529, 644);
            this.btnReset.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 47);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(385, 644);
            this.btnClear.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 47);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDataFill
            // 
            this.btnDataFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataFill.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDataFill.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataFill.Location = new System.Drawing.Point(241, 644);
            this.btnDataFill.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnDataFill.Name = "btnDataFill";
            this.btnDataFill.Size = new System.Drawing.Size(128, 47);
            this.btnDataFill.TabIndex = 22;
            this.btnDataFill.Text = "Data Fill";
            this.btnDataFill.Click += new System.EventHandler(this.btnDataFill_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(492, 82);
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSpeed.Size = new System.Drawing.Size(90, 394);
            this.trackBarSpeed.TabIndex = 23;
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // loopCheck
            // 
            this.loopCheck.AutoSize = true;
            this.loopCheck.Location = new System.Drawing.Point(492, 553);
            this.loopCheck.Name = "loopCheck";
            this.loopCheck.Size = new System.Drawing.Size(85, 29);
            this.loopCheck.TabIndex = 24;
            this.loopCheck.Text = "loop";
            this.loopCheck.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(934, 56);
            this.progressBar.TabIndex = 25;
            // 
            // timer
            // 
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(673, 644);
            this.btnStop.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 47);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(961, 714);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.loopCheck);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.btnDataFill);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbDirections);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.lblPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jamie The Robot";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGo10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ListBox lbDirections;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDataFill;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.CheckBox loopCheck;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStop;
    }
}

