using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProcessScheduler
{
    public partial class Form1 : Form
    {
        private readonly List<Process> processes = new List<Process>();
    private Thread schedulingThread;
        private bool isScheduling = false;

        public Form1()
        {
            InitializeComponent();
        }






        private void btnAddProcess_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtArrivalTime.Text, out int arrivalTime) &&
                int.TryParse(txtBurstTime.Text, out int burstTime))
            {
                processes.Add(new Process(arrivalTime, 0, burstTime));
                lstProcesses.Items.Add($"Process {processes.Count} - Arrival: {arrivalTime}, Burst: {burstTime}");
                txtArrivalTime.Clear();
                txtBurstTime.Clear();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for arrival time and burst time.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnStartScheduling_Click_1(object sender, EventArgs e)
        {
            if (processes.Count == 0)
            {
                MessageBox.Show("No processes to schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isScheduling)
            {
                MessageBox.Show("Scheduling is already in progress.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            isScheduling = true;
            schedulingThread = new Thread(ScheduleProcesses);
            schedulingThread.Start();
        }
        private void ScheduleProcesses()
        {
            int currentTime = 0;
            int totalWaitingTime = 0;
            int totalCompletionTime = 0;
            Process currentProcess = null;
            int remainingBurstTime = 0;
            StringBuilder timeline = new StringBuilder();

            while (true)
            {
                var nextProcess = processes
                    .Where(p => p.ArrivalTime <= currentTime && p.RemainingTime > 0)
                    .OrderBy(p => p.RemainingTime)
                    .FirstOrDefault();

                if (nextProcess != null)
                {
                    if (currentProcess != null && nextProcess.RemainingTime < currentProcess.RemainingTime)
                    {
                        currentProcess.RemainingTime = remainingBurstTime;
                        currentProcess = nextProcess;
                        remainingBurstTime = currentProcess.RemainingTime;
                    }
                    else if (currentProcess == null)
                    {
                        currentProcess = nextProcess;
                        remainingBurstTime = currentProcess.RemainingTime;
                    }

                    timeline.AppendLine($"P{processes.IndexOf(currentProcess) + 1} | {currentTime}");
                    remainingBurstTime--;
                    currentProcess.RemainingTime--;
                    currentTime++;

                    if (currentProcess.RemainingTime == 0)
                    {
                        currentProcess.CompletionTime = currentTime;
                        int waitingTime = currentTime - currentProcess.ArrivalTime - currentProcess.BurstTime;

                        totalWaitingTime += waitingTime;
                        totalCompletionTime += currentProcess.CompletionTime;

                        Invoke(new Action(() =>
                        {
                            lstResults.Items.Add($"Process {processes.IndexOf(currentProcess) + 1} - Arrival: {currentProcess.ArrivalTime}, Burst: {currentProcess.BurstTime}, Waiting: {waitingTime}, Completion: {currentProcess.CompletionTime}");
                        }));

                        currentProcess = null;
                    }
                }
                else
                {
                    currentTime++;
                }

                if (processes.All(p => p.RemainingTime == 0))
                {
                    break;
                }

                Thread.Sleep(100);
            }

            double avgWaitingTime = (double)totalWaitingTime / processes.Count;
            double avgCompletionTime = (double)totalCompletionTime / processes.Count;

            Invoke(new Action(() =>
            {
                txtAvgWaitingTime.Text = avgWaitingTime.ToString("F2");
                txtAvgTurnaroundTime.Text = avgCompletionTime.ToString("F2");
                lblTimeline.Text = timeline.ToString();
                isScheduling = false;
            }));
        }




        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (schedulingThread != null && schedulingThread.IsAlive)
            {
                schedulingThread.Join();
            }
            base.OnFormClosed(e);
        }



        private void lstProcesses_SelectedIndexChanged(object sender, EventArgs e) { }        
        private void lstResults_SelectedIndexChanged(object sender, EventArgs e){ }
        private void txtArrivalTime_TextChanged(object sender, EventArgs e) { }
        private void txtBurstTime_TextChanged(object sender, EventArgs e) { }
        private void txtAvgWaitingTime_TextChanged(object sender, EventArgs e) { }
        private void txtAvgTurnaroundTime_TextChanged(object sender, EventArgs e) { }
        private void lblTimeline_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e){}
        private void txtBurstTime_TextChanged_1(object sender, EventArgs e)  {}
        private void label1_Click(object sender, EventArgs e) { }

    }





    public class Process
    {
        public int ArrivalTime { get; }
        public int BurstTime { get; }
        public int RemainingTime { get; set; }
        public int CompletionTime { get; set; }

        public Process(int arrivalTime, int priority, int burstTime)
        {
            ArrivalTime = arrivalTime;
            BurstTime = burstTime;
            RemainingTime = burstTime;
            CompletionTime = 0;
        }
    }
}
