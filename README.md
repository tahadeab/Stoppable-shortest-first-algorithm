Shortest Job First (SJF) Preemptive Algorithm with Graphical User Interface (GUI)
Project Description
This project is an application that demonstrates and simulates the Shortest Job First (SJF) Preemptive Algorithm for process scheduling in operating systems. The application provides a user-friendly Graphical User Interface (GUI) allowing users to input process details (arrival time, burst time), monitor the scheduling simulation, and view results and statistics such as average waiting time and average turnaround time.

Features
Process Input: Ability to add new processes with specified Arrival Time and Burst Time.

Interactive Simulation: Step-by-step display of process execution sequence.

SJF Preemptive Scheduling: Accurate implementation of the SJF Preemptive algorithm logic, where the currently running process is interrupted (preempted) if a new process with a shorter remaining burst time arrives.

Results Display: Calculation and display of Completion Time, Turnaround Time, and Waiting Time for each process.

Comprehensive Statistics: Calculation and display of average Turnaround Time and average Waiting Time for all processes.

Graphical User Interface (GUI): Intuitive and easy-to-use design built with C# Windows Forms or WPF.

How the Algorithm Works (SJF Preemptive)
The Shortest Job First (SJF) Preemptive algorithm is a non-periodic scheduling algorithm where priority is given to the process with the shortest remaining execution time. The key characteristic here is "Preemptive," meaning that if a new process arrives in the ready queue and has a shorter execution time remaining than the currently running process, the running process will be immediately preempted, and the new process with the shortest time will begin execution. This ensures that the shortest available job is always executed first, which minimizes the average waiting time.

Getting Started
To set up and run the project on your machine, follow these steps:

Prerequisites
.NET SDK: Ensure you have the .NET SDK installed (preferably version 6.0 or newer, depending on the project's target framework).

Visual Studio: An integrated development environment such as Visual Studio 2019 or 2022.

Installation and Running
Clone the repository:
Open Command Prompt or Git Bash and clone the repository:
Open the project in Visual Studio:
Open the solution file (.sln) of the project using Visual Studio.

Build the project:
In Visual Studio, go to Build -> Build Solution (or press Ctrl+Shift+B).

Run the application:
Press F5 or click the Start button in Visual Studio to run the application.

Usage
After running the application, the main interface will appear:

Add Processes:

Enter the "Arrival Time" for the process in the designated field.

Enter the "Burst Time" for the process in the designated field.

Click the "Add Process" button to add the process to the list.

Start Simulation:

After adding all processes, click the "Start Simulation" button.

The application will display the execution sequence in the output area (or a Gantt chart if available).

View Results:

Tables will appear containing the completion time, turnaround time, and waiting time for each process.

The average turnaround time and average waiting time will be displayed in their respective locations.

Reset:

Click the "Reset" button to clear all processes and results and start a new simulation.

Project Structure
The project typically consists of the following main components:

Program.cs: The main entry point for the application.

MainForm.cs (or similar name for the main UI form): Contains the user interface design and event handling code to update the UI.

Process.cs: Defines a class representing a process, containing properties such as ProcessID, ArrivalTime, BurstTime, RemainingTime, CompletionTime, TurnaroundTime, WaitingTime.

SJF_Preemptive_Scheduler.cs (or similar name for the logic): Contains the core logic for implementing the SJF Preemptive algorithm, including scheduling functions and calculating various times.

UI files: May include .resx and .Designer.cs files related to the graphical interface design.

Technologies Used
C#: The primary programming language for the project.

.NET Framework / .NET Core: The development platform.

Windows Forms / WPF: (Choose one based on your GUI design preference).
