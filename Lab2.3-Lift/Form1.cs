using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

//Să se implementeze o aplicaţie vizuală: sincronizarea liftului cu locatarii într-un bloc,
//sincronizarea călătorilor cu o linie de autobuz.

namespace Lab2._3_Lift
{
    public partial class Form1 : Form
    {
        private readonly Thread Elevator;
        private readonly Thread Floor1;
        private readonly Thread Floor2;
        private readonly Thread Floor3;
        private int callingFloor = 800;
        private readonly ManualResetEvent CallElevatorEvent = new ManualResetEvent(false);
        private readonly ManualResetEvent ArriveElevatorEvent = new ManualResetEvent(false);

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Elevator = new Thread(new ThreadStart(WaitCall));
            Floor1 = new Thread(new ThreadStart(CallTo1));
            Floor2 = new Thread(new ThreadStart(CallTo2));
            Floor3 = new Thread(new ThreadStart(CallTo3));
            Elevator.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void floor1Btn_Click(object sender, EventArgs e)
        {
            Floor1.Start();
            floor1Btn.Enabled = false;
            callingFloor = floor1Btn.Location.Y;
            CallElevator(floor1Btn, "1");
            Floor1.Abort();
        }

        private void floor2Btn_Click(object sender, EventArgs e)
        {
            Floor2.Start();
            floor2Btn.Enabled = false;
            callingFloor = floor2Btn.Location.Y;
            CallElevator(floor2Btn, "2");
        }

        private void floor3Btn_Click(object sender, EventArgs e)
        {
            Floor3.Start();
            floor3Btn.Enabled = false;
            callingFloor = floor3Btn.Location.Y;
            CallElevator(floor3Btn, "3");
        }

        private void WaitCall()
        {
            CallElevatorEvent.WaitOne();
            Console.WriteLine("Elevator called");
            Thread.Sleep(1000);
            MoveToFloor();
            ArriveElevatorEvent.Reset();
            CallElevatorEvent.Reset();
            Console.WriteLine("Elevator arrived at floor " + callingFloor);
        }

        private void MoveToFloor()
        {
            Console.WriteLine("Movig to floor " + callingFloor);
            elevatorImg.Location = new Point(500, callingFloor);
            Refresh();
        }

        private void CallElevator(Button btn, string floor)
        {
            Console.WriteLine("Calling Lift to {0}", floor);
            CallElevatorEvent.Set();
            ArriveElevatorEvent.WaitOne();
            Console.WriteLine("Lift arrived at {0}", floor);
            btn.Enabled = true;
            CallElevatorEvent.Reset();
            Elevator.Start();
        }

        private void CallTo1()
        {
            CallElevator(floor1Btn, "1");
        }

        private void CallTo2()
        {
            CallElevator(floor2Btn, "2");
        }

        private void CallTo3()
        {
            CallElevator(floor3Btn, "3");
        }
    }
}