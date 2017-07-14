/******************************************************************************
 *
 *  Filename: PS9300ClientMainForm.cs
 * 
 *  Description:
 *    This is an example GUI application demonstrating how to send commands
 *    from an ActiveX client to an ActiveX server in order to control a 
 *    PicoScope 9300 series PC sampling oscilloscope.
 *
 *  Copyright © 2014-2017 Pico Technology Ltd. See LICENSE file for terms.
 * 
 ******************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PicoScope9300CSharpClient
{
    public partial class PS9300ClientMainForm : Form
    {

        private class COMRCWrapper
        {
            // COM object of the oscilloscope 
            PicoSample3.COMRC COMRC;
            // Project | Add Reference... | COM | PicoSample 3 Type Library 
            public COMRCWrapper()
            {
                COMRC = new PicoSample3.COMRC();
            }
            public string ExecCommand(string command)
            {
                // Executes a command, returns string result or raises an exception
                string result = COMRC.ExecCommand(command);
                if ((result == null))
                {
                    return "";
                }
                else if (result == "ERROR")
                {
                    throw new Exception("PicoScope9000.COMRC command error (" + command + ")");
                }
                else
                {
                    return result;
                }
            }
        }

        public PS9300ClientMainForm()
        {
            InitializeComponent();
        }

        COMRCWrapper COMRCW;

        private void updateUI()
        {
            bool connected = (COMRCW != null);
            btnOff.Enabled = connected;
            btnOn.Enabled = !connected;
            lblCommand.Enabled = connected;
            lblResponse.Enabled = connected;
            cbCommand.Enabled = connected;
            btnExecute.Enabled = connected;
            btnGetSignal.Enabled = connected;
            btnRun.Enabled = connected;
            btnSingle.Enabled = connected;
            btnStop.Enabled = connected;
        }

        private void MainForm_Close(object sender, FormClosedEventArgs e)
        {
            COMRCW = null;
            GC.Collect();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            COMRCW = new COMRCWrapper();
            updateUI();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            COMRCW = null;
            GC.Collect();
            // Forse GC to release the COM object
            updateUI();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                string result = COMRCW.ExecCommand(cbCommand.Text);
                tbResult.Text = result;
                if (cbCommand.Items.Contains(cbCommand.Text))
                {
                    cbCommand.Items.Insert(0, cbCommand.Text);
                }
                cbCommand.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCommand_TextChanged(System.Object sender, System.EventArgs e)
        {
            btnExecute.Enabled = !string.IsNullOrEmpty(cbCommand.Text);
        }

        private void cbCommand_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 & btnExecute.Enabled)
            {
                btnExecute_Click(null, null);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            COMRCW.ExecCommand("*RunControl:Run");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            COMRCW.ExecCommand("*RunControl:Stop");
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            COMRCW.ExecCommand("*RunControl:Single");
        }

        private void btnGetSignal_Click(object sender, EventArgs e)
        {
            // Getting data 
            COMRCW.ExecCommand("Header Off");
            // Switching off headers in results
            string strdata = COMRCW.ExecCommand("Wfm:Data?");
            // Getting points
            string YU = COMRCW.ExecCommand("Wfm:Preamb:YU?");
            // Y-axis units
            string XU = COMRCW.ExecCommand("Wfm:Preamb:XU?");
            // X-axis units
            double XInc = Convert.ToDouble(COMRCW.ExecCommand("Wfm:Preamb:XInc?"));
            // X-axis step
            double XOrg = Convert.ToDouble(COMRCW.ExecCommand("Wfm:Preamb:XOrg?"));
            // Y-axis origin

            // Converting string of values to array of doubles

            string[] arraystrdata = strdata.Split(',');
            double[] data = new double[arraystrdata.Length];
            for (int i = 0; i <= arraystrdata.Length - 1; i++)
            {
                data[i] = Convert.ToDouble(arraystrdata[i]);
            }

            // Determining the vertical scale
            double XMax = double.MinValue;
            double XMin = double.MaxValue;
            foreach (double point in data)
            {
                XMax = Math.Max(XMax, point);
                XMin = Math.Min(XMin, point);
            }
            Double XSize = XMax - XMin;
            XMax += 0.1 * XSize;
            XMin -= 0.1 * XSize;
            if (XSize <= 0)
            {
                XMax = 1;
                XMin = -1;
            }
            XSize = XMax - XMin;

            // Screen width and height
            int width = pbScreen.ClientRectangle.Width;
            int height = pbScreen.ClientRectangle.Height;

            // Creating screen bitmap
            Bitmap bitmap = new Bitmap(width, height);

            // Painting the Ox axis
            int x = 0;
            int y = (int)((0 - XMin / XSize) * (height - 1));
            y = height - y - 1;
            // inverse because of inversed GDI y-coordinate
            if (y >= 0 & y < height)
            {
                for (x = 0; x <= width - 1; x++)
                {
                    bitmap.SetPixel(x, y, Color.Lime);
                }
            }

            // Painting the signal
            for (int i = 0; i <= data.Length - 1; i++)
            {
                x = i * (width - 1) / (data.Length - 1);
                // Scale signal to screen width
                y = (int)((((data[i] - XMin) / XSize)) * (height - 1));
                // Scale signal to screen height
                y = height - y - 1;
                // inverse because of inversed GDI y-coordinate
                bitmap.SetPixel(x, y, Color.Yellow);
            }

            // Assigning screen bitmap to screen
            pbScreen.Image = bitmap;

            // Axis limits
            lblXStart.Text = XOrg + " " + XU;
            lblXEnd.Text = (XOrg + XInc * (data.Length - 1)).ToString() + " " + XU;
            lblYTop.Text = XMax + " " + YU;
            lblYBottom.Text = XMin + " " + YU;
        }



    }
}
