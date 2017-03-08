using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Thomas Fisher MIS 220-001
//extras: 
// -the speed adjustment bar
// -if you loop the robot to endlessly crash into a wall,
//      instead of breaking, the program only shows 1 "Crash!" message

namespace Robot
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();                            
        }

        private Robot robot;
        private int count;

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            robot = new Robot();
            robot.Crash += new EventHandler(CrashHandler);
            lblPosition.Text = robot.Position.ToString();
            lblRobot.Text = Convert.ToChar(233).ToString();
            lbDirections.Items.Add("RobotDirection.N");
            btnStop.Visible = false;
        }

        private void btnN_Click(object sender, System.EventArgs e)
        {
            robot.Direction = RobotDirection.N;
            lblRobot.Text = Convert.ToChar(233).ToString();  // Up arrow
            //This is there in case the user has already hit the N direction button
            if ((lbDirections.Items.Count > 0) && (!(lbDirections.Items[lbDirections.Items.Count - 1].Equals("RobotDirection.N"))))
            {
                lbDirections.Items.Add("RobotDirection.N");
            }
        }

        private void btnS_Click(object sender, System.EventArgs e)
        {
            robot.Direction = RobotDirection.S;
            lblRobot.Text = Convert.ToChar(234).ToString();  // Down arrow
            //This is there in case the user has already hit the S direction button
            if ((lbDirections.Items.Count > 0) && (!(lbDirections.Items[lbDirections.Items.Count - 1].Equals("RobotDirection.S"))))
            {
                lbDirections.Items.Add("RobotDirection.S");
            }
        }

        private void btnW_Click(object sender, System.EventArgs e)
        {
            robot.Direction = RobotDirection.W;
            lblRobot.Text = Convert.ToChar(231).ToString();  // Left arrow
            //This is there in case the user has already hit the W direction button
            if ((lbDirections.Items.Count > 0) && (!(lbDirections.Items[lbDirections.Items.Count - 1].Equals("RobotDirection.W"))))
            {
                lbDirections.Items.Add("RobotDirection.W");
            }
        }

        private void btnE_Click(object sender, System.EventArgs e)
        {
            robot.Direction = RobotDirection.E;
            lblRobot.Text = Convert.ToChar(232).ToString();  // Right arrow
            //This is there in case the user has already hit the E direction button
            if ((lbDirections.Items.Count > 0) && (!(lbDirections.Items[lbDirections.Items.Count - 1].Equals("RobotDirection.E"))))
            {
                lbDirections.Items.Add("RobotDirection.E");
            }
        }

        private void btnGo1_Click(object sender, System.EventArgs e)
        {
            this.MoveRobot(1);
            lbDirections.Items.Add("MoveRobot(1)");
        }

        private void btnGo10_Click(object sender, System.EventArgs e)
        {
            this.MoveRobot(10);
            lbDirections.Items.Add("MoveRobot(10)");
        }

        private void MoveRobot(int units)
        {
            robot.Go(units);
            Point rp = robot.Position;
            lblRobot.Location = new Point(rp.X + 100, -rp.Y + 100);
            lblPosition.Text = rp.ToString();
        }

        private void CrashHandler(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btnStop.Visible = false;
            btnDataFill.Enabled = true;
            btnClear.Enabled = true;
            btnReset.Enabled = true;
            btnPlay.Visible = true;
            MessageBox.Show("Crash!");
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            robot = new Robot();
            lblRobot.Location = new Point(100, 100);
            lblPosition.Text = robot.Position.ToString();
            count = 0;
            lbDirections.SetSelected(count, true);
            lbDirections.Items.Clear();
            robot.Direction = RobotDirection.N;
            lblRobot.Text = Convert.ToChar(233).ToString();
            lbDirections.Items.Add("RobotDirection.N");
            progressBar.Value = 0;
            btnGo1.Enabled = true;
            btnGo10.Enabled = true;
            btnN.Enabled = true;
            btnS.Enabled = true;
            btnE.Enabled = true;
            btnW.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            robot = new Robot();
            lblRobot.Location = new Point(100, 100);
            lblPosition.Text = robot.Position.ToString();
            count = 0;
            lbDirections.SetSelected(count, true);
            robot.Direction = RobotDirection.N;
            lblRobot.Text = Convert.ToChar(233).ToString();
            lbDirections.Items.Add("RobotDirection.N");
            progressBar.Value = 0;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = lbDirections.Items.Count;
            timer.Enabled = true;
            btnPlay.Visible = false;
            btnDataFill.Enabled = false;
            btnClear.Enabled = false;
            btnReset.Enabled = false;
            btnGo1.Enabled = false;
            btnGo10.Enabled = false;
            btnN.Enabled = false;
            btnS.Enabled = false;
            btnE.Enabled = false;
            btnW.Enabled = false;
            btnStop.Visible = true;
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = (300 / trackBarSpeed.Value);
            //this makes sure there is a command to execute
            //the count starts at 0, and the count in the list class starts at 1,
            //so when they are equal, it is at the end of the list.
            if (count != lbDirections.Items.Count)
            {
                lbDirections.SetSelected(count, true);
                progressBar.Value = count +1; //
                progressBar.Value = count;    // this is a workaround to force the progress bar to update when the robot moves fast
                progressBar.Value = count +1; //
                runCommand(count);
                count++;
            }
            //if it is at the end of the commands, and the loop box is checked, this runs
            else if (loopCheck.Checked)
            {
                count = 0;
                progressBar.Value = count;
                robot = new Robot();
                lblRobot.Location = new Point(100, 100);
                lblPosition.Text = robot.Position.ToString();
                progressBar.Value = 0;
            }
            //else the tracking is done
            else
            {
                lbDirections.SetSelected(lbDirections.Items.Count - 1, true);
                progressBar.Value = count;
                timer.Enabled = false;
                btnStop.Visible = false;
                btnDataFill.Enabled = true;
                btnClear.Enabled = true;
                btnReset.Enabled = true;
                btnPlay.Visible = true;
                robot = new Robot();
                lblRobot.Location = new Point(100, 100);
                lblPosition.Text = robot.Position.ToString();
                MessageBox.Show("Tracking complete.");
            }
        }

        //this method will execute whatever command lbDirections[count] is
        private void runCommand(int count)
        {
            string currentCommand = lbDirections.Items[count].ToString();

            if(currentCommand.Equals("RobotDirection.N"))
            {
                robot.Direction = RobotDirection.N;
                lblRobot.Text = Convert.ToChar(233).ToString();
            }
            else if (currentCommand.Equals("RobotDirection.S"))
            {
                robot.Direction = RobotDirection.S;
                lblRobot.Text = Convert.ToChar(234).ToString();
            }
            else if (currentCommand.Equals("RobotDirection.E"))
            {
                robot.Direction = RobotDirection.E;
                lblRobot.Text = Convert.ToChar(232).ToString();
            }
            else if (currentCommand.Equals("RobotDirection.W"))
            {
                robot.Direction = RobotDirection.W;
                lblRobot.Text = Convert.ToChar(231).ToString();
            }
            else if (currentCommand.Equals("MoveRobot(1)"))
            {
                robot.Go(1);
                Point p = robot.Position;
                lblRobot.Location = new Point(p.X + 100, -p.Y + 100);
                lblPosition.Text = p.ToString();
            }
            else if (currentCommand.Equals("MoveRobot(10)"))
            {
                robot.Go(10);
                Point p = robot.Position;
                lblRobot.Location = new Point(p.X + 100, -p.Y + 100);
                lblPosition.Text = p.ToString();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btnStop.Visible = false;
            btnDataFill.Enabled = true;
            btnClear.Enabled = true;
            btnReset.Enabled = true;
            btnPlay.Visible = true;
        }

        private void btnDataFill_Click(object sender, EventArgs e)
        {
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("RobotDirection.E");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("RobotDirection.S");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("RobotDirection.W");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("RobotDirection.S");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("RobotDirection.E");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("RobotDirection.N");
            lbDirections.Items.Add("MoveRobot(10)");
            lbDirections.Items.Add("MoveRobot(10)");
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            timer.Interval = (300/trackBarSpeed.Value);
        }
    }
}