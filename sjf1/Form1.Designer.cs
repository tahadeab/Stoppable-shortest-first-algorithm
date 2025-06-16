namespace ProcessScheduler
{
    partial class Form1
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
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.btnStartScheduling = new System.Windows.Forms.Button();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.txtArrivalTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBurstTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvgWaitingTime = new System.Windows.Forms.TextBox();
            this.txtAvgTurnaroundTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTimeline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(231, 298);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(539, 84);
            this.lstResults.TabIndex = 15;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // lstProcesses
            // 
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.ItemHeight = 16;
            this.lstProcesses.Location = new System.Drawing.Point(231, 208);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(336, 84);
            this.lstProcesses.TabIndex = 14;
            this.lstProcesses.SelectedIndexChanged += new System.EventHandler(this.lstProcesses_SelectedIndexChanged);
            // 
            // btnStartScheduling
            // 
            this.btnStartScheduling.Location = new System.Drawing.Point(37, 155);
            this.btnStartScheduling.Name = "btnStartScheduling";
            this.btnStartScheduling.Size = new System.Drawing.Size(75, 23);
            this.btnStartScheduling.TabIndex = 13;
            this.btnStartScheduling.Text = "بدء الجدولة";
            this.btnStartScheduling.UseVisualStyleBackColor = true;
            this.btnStartScheduling.Click += new System.EventHandler(this.btnStartScheduling_Click_1);
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.Location = new System.Drawing.Point(160, 155);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(75, 23);
            this.btnAddProcess.TabIndex = 12;
            this.btnAddProcess.Text = "إضافة العملية";
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click_1);
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Location = new System.Drawing.Point(37, 57);
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.Size = new System.Drawing.Size(100, 22);
            this.txtArrivalTime.TabIndex = 10;
            this.txtArrivalTime.TextChanged += new System.EventHandler(this.txtArrivalTime_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "زمن الوصول";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBurstTime
            // 
            this.txtBurstTime.Location = new System.Drawing.Point(160, 57);
            this.txtBurstTime.Name = "txtBurstTime";
            this.txtBurstTime.Size = new System.Drawing.Size(100, 22);
            this.txtBurstTime.TabIndex = 16;
            this.txtBurstTime.TextChanged += new System.EventHandler(this.txtBurstTime_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "زمن العملية";
            // 
            // txtAvgWaitingTime
            // 
            this.txtAvgWaitingTime.Location = new System.Drawing.Point(78, 298);
            this.txtAvgWaitingTime.Name = "txtAvgWaitingTime";
            this.txtAvgWaitingTime.Size = new System.Drawing.Size(100, 22);
            this.txtAvgWaitingTime.TabIndex = 18;
            this.txtAvgWaitingTime.TextChanged += new System.EventHandler(this.txtAvgWaitingTime_TextChanged);
            // 
            // txtAvgTurnaroundTime
            // 
            this.txtAvgTurnaroundTime.Location = new System.Drawing.Point(78, 252);
            this.txtAvgTurnaroundTime.Name = "txtAvgTurnaroundTime";
            this.txtAvgTurnaroundTime.Size = new System.Drawing.Size(100, 22);
            this.txtAvgTurnaroundTime.TabIndex = 19;
            this.txtAvgTurnaroundTime.TextChanged += new System.EventHandler(this.txtAvgTurnaroundTime_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "الانتظار";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "الاكتمال";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTimeline
            // 
            this.lblTimeline.AutoSize = true;
            this.lblTimeline.Location = new System.Drawing.Point(942, 208);
            this.lblTimeline.Name = "lblTimeline";
            this.lblTimeline.Size = new System.Drawing.Size(44, 16);
            this.lblTimeline.TabIndex = 24;
            this.lblTimeline.Text = "label6";
            this.lblTimeline.Click += new System.EventHandler(this.lblTimeline_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 554);
            this.Controls.Add(this.lblTimeline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAvgTurnaroundTime);
            this.Controls.Add(this.txtAvgWaitingTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBurstTime);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.lstProcesses);
            this.Controls.Add(this.btnStartScheduling);
            this.Controls.Add(this.btnAddProcess);
            this.Controls.Add(this.txtArrivalTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.Button btnStartScheduling;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.TextBox txtArrivalTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBurstTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAvgWaitingTime;
        private System.Windows.Forms.TextBox txtAvgTurnaroundTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTimeline;
    }
}

