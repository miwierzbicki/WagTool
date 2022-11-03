namespace WagTool
{
    partial class MainScreen
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.currentDateTime = new System.Windows.Forms.Timer(this.components);
            this.currentDateTimeValue = new System.Windows.Forms.Label();
            this.saveToCsvBtn = new System.Windows.Forms.Button();
            this.selectMaterial = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.countDiffTime = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startTimeValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tonsPerHour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopTimeValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sqlStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.tonsCalculatedValue = new System.Windows.Forms.Label();
            this.countWeightTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentDateTime
            // 
            this.currentDateTime.Enabled = true;
            this.currentDateTime.Interval = 1000;
            this.currentDateTime.Tick += new System.EventHandler(this.currentDateTime_Tick);
            // 
            // currentDateTimeValue
            // 
            this.currentDateTimeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentDateTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentDateTimeValue.Location = new System.Drawing.Point(560, 397);
            this.currentDateTimeValue.Name = "currentDateTimeValue";
            this.currentDateTimeValue.Size = new System.Drawing.Size(231, 41);
            this.currentDateTimeValue.TabIndex = 0;
            this.currentDateTimeValue.Text = "-";
            this.currentDateTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveToCsvBtn
            // 
            this.saveToCsvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveToCsvBtn.Location = new System.Drawing.Point(12, 397);
            this.saveToCsvBtn.Name = "saveToCsvBtn";
            this.saveToCsvBtn.Size = new System.Drawing.Size(172, 41);
            this.saveToCsvBtn.TabIndex = 2;
            this.saveToCsvBtn.Text = "Zapisz do pliku";
            this.saveToCsvBtn.UseVisualStyleBackColor = true;
            this.saveToCsvBtn.Click += new System.EventHandler(this.saveToCsvBtn_Click);
            // 
            // selectMaterial
            // 
            this.selectMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectMaterial.FormattingEnabled = true;
            this.selectMaterial.Items.AddRange(new object[] {
            "Smieci mokre",
            "Smieci suche",
            "Plastiki",
            "Szklo",
            "Papier"});
            this.selectMaterial.Location = new System.Drawing.Point(560, 184);
            this.selectMaterial.Name = "selectMaterial";
            this.selectMaterial.Size = new System.Drawing.Size(193, 30);
            this.selectMaterial.TabIndex = 3;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.materialLabel.Location = new System.Drawing.Point(556, 160);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(128, 20);
            this.materialLabel.TabIndex = 4;
            this.materialLabel.Text = "Wybór materiału:";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.LightGreen;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBtn.Location = new System.Drawing.Point(12, 104);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(172, 50);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.IndianRed;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopBtn.Location = new System.Drawing.Point(12, 330);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(172, 50);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // countDiffTime
            // 
            this.countDiffTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countDiffTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countDiffTime.Location = new System.Drawing.Point(193, 114);
            this.countDiffTime.Name = "countDiffTime";
            this.countDiffTime.Size = new System.Drawing.Size(206, 29);
            this.countDiffTime.TabIndex = 7;
            this.countDiffTime.Text = "-\r\n";
            // 
            // counterLabel
            // 
            this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.counterLabel.Location = new System.Drawing.Point(6, 114);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(172, 30);
            this.counterLabel.TabIndex = 8;
            this.counterLabel.Text = "Czas trwania:";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startTimeLabel.Location = new System.Drawing.Point(6, 26);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(172, 28);
            this.startTimeLabel.TabIndex = 9;
            this.startTimeLabel.Text = "Godzina rozpoczęcia:";
            // 
            // startTimeValue
            // 
            this.startTimeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startTimeValue.Location = new System.Drawing.Point(193, 26);
            this.startTimeValue.Name = "startTimeValue";
            this.startTimeValue.Size = new System.Drawing.Size(206, 29);
            this.startTimeValue.TabIndex = 10;
            this.startTimeValue.Text = "-\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(557, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aktualna data i czas:";
            // 
            // tonsPerHour
            // 
            this.tonsPerHour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tonsPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tonsPerHour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tonsPerHour.Location = new System.Drawing.Point(246, 49);
            this.tonsPerHour.Name = "tonsPerHour";
            this.tonsPerHour.Size = new System.Drawing.Size(147, 46);
            this.tonsPerHour.TabIndex = 12;
            this.tonsPerHour.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(243, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ilość ton na godzinę (T/h)";
            // 
            // stopTimeValue
            // 
            this.stopTimeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stopTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopTimeValue.Location = new System.Drawing.Point(193, 68);
            this.stopTimeValue.Name = "stopTimeValue";
            this.stopTimeValue.Size = new System.Drawing.Size(206, 29);
            this.stopTimeValue.TabIndex = 15;
            this.stopTimeValue.Text = "-\r\n";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Godzina zakończenia:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startTimeLabel);
            this.groupBox1.Controls.Add(this.stopTimeValue);
            this.groupBox1.Controls.Add(this.countDiffTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.counterLabel);
            this.groupBox1.Controls.Add(this.startTimeValue);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 164);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.sqlStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Value = 10;
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(648, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Pomiar w trakcie...";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel1.Visible = false;
            // 
            // sqlStatus
            // 
            this.sqlStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sqlStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sqlStatus.Name = "sqlStatus";
            this.sqlStatus.Size = new System.Drawing.Size(138, 17);
            this.sqlStatus.Text = "sql connection status = ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(449, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Łącznie ton";
            // 
            // tonsCalculatedValue
            // 
            this.tonsCalculatedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tonsCalculatedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tonsCalculatedValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tonsCalculatedValue.Location = new System.Drawing.Point(452, 49);
            this.tonsCalculatedValue.Name = "tonsCalculatedValue";
            this.tonsCalculatedValue.Size = new System.Drawing.Size(146, 46);
            this.tonsCalculatedValue.TabIndex = 21;
            this.tonsCalculatedValue.Text = "-";
            // 
            // countWeightTimer
            // 
            this.countWeightTimer.Interval = 1000;
            this.countWeightTimer.Tick += new System.EventHandler(this.countWeightTimer_Tick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(801, 473);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tonsCalculatedValue);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tonsPerHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.selectMaterial);
            this.Controls.Add(this.saveToCsvBtn);
            this.Controls.Add(this.currentDateTimeValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WagTool 1.0";
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer currentDateTime;
        private System.Windows.Forms.Label currentDateTimeValue;
        private System.Windows.Forms.Button saveToCsvBtn;
        private System.Windows.Forms.ComboBox selectMaterial;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label countDiffTime;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label startTimeValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tonsPerHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stopTimeValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sqlStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tonsCalculatedValue;
        private System.Windows.Forms.Timer countWeightTimer;
    }
}

