using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String[] Baudrate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cbBaudRate.Items.AddRange(Baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbComPort.DataSource = SerialPort.GetPortNames();
            cbBaudRate.Text = "9600";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            serCom.Write("@01T#");
        }

        private void ex_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bcon_Click(object sender, EventArgs e)
        {
            if (!serCom.IsOpen)
            {
                bcon.Text = "NGẮT KẾT NỐI";
                serCom.PortName = cbComPort.Text;
                bcon.ForeColor = Color.Red;
                serCom.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serCom.Open();
                serCom.Write("@01D#");

            }
            else
            {
                bcon.Text = "KẾT NỐI";
                serCom.Close();
            }
        }

        private void t1_Click(object sender, EventArgs e)
        {
            serCom.Write("@01B#");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            serCom.Write("@02B#");
        }

        private void t2_Click(object sender, EventArgs e)
        {
            serCom.Write("@02T#");
        }

        private async void serCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String AllData = "";
            AllData = serCom.ReadLine();
            AllData = AllData.Trim();
            txtAllData.Text = AllData;
            int len = AllData.Length;

            if (len > 0)
            {
                if (AllData[0] == '@' && AllData[len - 1] == '#')
                {
                    if (AllData[1] == '1')
                    {
                        if (AllData[2] == '0')
                        {
                            if (AllData[3] == 'D')
                            {
                                int vtT1 = AllData.IndexOf('T');
                                int vtV1 = AllData.IndexOf('V');
                                int vtC1 = AllData.IndexOf('C');
                                int vtS1 = AllData.IndexOf('S');
                                int vtP1 = AllData.IndexOf('P');
                                int vtI1 = AllData.IndexOf('I');                             
                                n1.Text = AllData.Substring(vtT1 + 1, vtV1 - vtT1 - 1) +" C";
                                v1.Text = AllData.Substring(vtV1 + 1, vtC1 - vtV1 - 1) + " V";
                                c1.Text = AllData.Substring(vtC1 + 1, vtS1 - vtC1 - 1) + " A";
                                s1.Text = AllData.Substring(vtS1 + 1, vtP1 - vtS1 - 1) + " RPM";
                                p1.Text = AllData.Substring(vtP1 + 1, vtI1 - vtP1 - 1) + " W";
                                i1.Text = AllData.Substring(vtI1 + 1, len - vtI1 - 2);
                                await Task.Delay(5000);
                                serCom.Write("@02D#");
                            }
                        }
                    }
                }
                if (AllData[0] == '@' && AllData[len - 1] == '#')
                {
                    if (AllData[1] == '2')
                    {
                        if (AllData[2] == '0')
                        {
                            if (AllData[3] == 'D')
                            {
                                int vtT2 = AllData.IndexOf('T');
                                int vtV2 = AllData.IndexOf('V');
                                int vtC2 = AllData.IndexOf('C');
                                int vtS2 = AllData.IndexOf('S');
                                int vtP2 = AllData.IndexOf('P');
                                int vtI2 = AllData.IndexOf('I');
                                n2.Text = AllData.Substring(vtT2 + 1, vtV2 - vtT2 - 1) + " C";
                                v2.Text = AllData.Substring(vtV2 + 1, vtC2 - vtV2 - 1) + " V";
                                c2.Text = AllData.Substring(vtC2 + 1, vtS2 - vtC2 - 1) + " A";
                                s2.Text = AllData.Substring(vtS2 + 1, vtP2 - vtS2 - 1) + " RPM";
                                p2.Text = AllData.Substring(vtP2 + 1, vtI2 - vtP2 - 1) + " W";
                                i2.Text = AllData.Substring(vtI2 + 1, len - vtI2 - 2);
                                await Task.Delay(5000);
                                serCom.Write("@01D#");

                            }
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serCom.Write("@01D#");
        }

        private void thoigian_Tick(object sender, EventArgs e)
        {
            txtthoigian.Text = DateTime.Now.ToString(" dd/MM/yyyy   HH:mm:ss tt");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
