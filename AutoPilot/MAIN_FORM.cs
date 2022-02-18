using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutoPilot
{

    public partial class MAIN_FORM : Form
    {
        Stopwatch timerIdle = new Stopwatch();
        Stopwatch timerRemaining = new Stopwatch();
        Point prevPoint;
        int i = 0;

        public MAIN_FORM()
        {
            InitializeComponent();
        }

        private void BTN_GO_Click(object sender, EventArgs e)
        {
            if ((HH_TB.TextLength == 0) || (MM_TB.TextLength == 0) || (HH_TB.TextLength > 2) || (MM_TB.TextLength > 2) || (MM_TOLERANCE_TB.TextLength > 2) || (MM_TOLERANCE_TB.TextLength == 0))
            {
                MessageBox.Show("Textbox error, maximum digits are 2 and the minimum is one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(HH_TB.Text) < 0 || int.Parse(HH_TB.Text) > 24 || int.Parse(MM_TB.Text) < 0  || int.Parse(MM_TB.Text) > 59  || int.Parse(MM_TOLERANCE_TB.Text) >= 15 || int.Parse(MM_TOLERANCE_TB.Text) < 0)
            {
                MessageBox.Show("Textbox must contain numbers from ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            timerIdle.Start();
            timerRemaining.Start();

            GB1.Enabled = false;
            GB2.Enabled = false;

        }

        private void TIME_UPDATE_REMAINING()
        {
            TB_TIME_REMAINING.Text = "0";
            TB_IDLE_TIME.Text = "1";
            
        }

        private void TIME_UPDATE_IDLE(Object source, ElapsedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timerIdle.IsRunning == true)
            {
                if (prevPoint == Cursor.Position)
                {
                    TB_IDLE_TIME.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    timerIdle.Elapsed.Hours, timerIdle.Elapsed.Minutes, timerIdle.Elapsed.Seconds,
                    timerIdle.Elapsed.Milliseconds / 10);


                    TB_TIME_REMAINING.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    timerRemaining.Elapsed.Hours, timerRemaining.Elapsed.Minutes, timerRemaining.Elapsed.Seconds,
                    timerRemaining.Elapsed.Milliseconds / 10);
                }
                else
                {
                    prevPoint = Cursor.Position;
                    timerIdle.Reset();
                    timerIdle.Start();

                }
            }

            if (timerRemaining.IsRunning == true)
            {
                if ((timerRemaining.Elapsed.Hours == int.Parse(HH_TB.Text)) && (timerRemaining.Elapsed.Minutes == int.Parse(MM_TB.Text)))
                {

                    this.Close();
                }

            }

            if (timerRemaining.IsRunning == true)
            {
                if (timerIdle.Elapsed.Minutes == int.Parse(MM_TOLERANCE_TB.Text))
                {
                    SendKeys.Send("{DOWN}");
                    Thread.Sleep(5000);
                    SendKeys.Send("{UP}");

                }

            }


        }

    }
}
