using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ComDev
{
    public partial class Form1 : Form
    {
        int[] BaudRateArr = new int[] { 9600, 2400, 4800, 115200 };
        int[] DataBitArr = new int[] { 8, 7 };
        int[] StopBitArr = new int[] { 1, 2, 3 };
        private PortControlHelper pchReceive;

        public Form1()
        {
            InitializeComponent();
            pchReceive = new PortControlHelper();
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            if(!pchReceive.PortState)
            {
                pchReceive.OpenPort(cb_portNameReceive.Text, int.Parse(cb_baudRate.Text),
                    int.Parse(cb_dataBit.Text), int.Parse(cb_stopBit.Text), 1000);
                pchReceive.OnComReceiveDataHandler += new PortControlHelper.ComReceiveDataHandler(ComReceiveData);
                Btn_open.Text = "关闭串口";
            }
            else
            {
                pchReceive.OnComReceiveDataHandler -= new PortControlHelper.ComReceiveDataHandler(ComReceiveData);
                pchReceive.ClosePort();
                Btn_open.Text = "打开串口";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_portNameReceive.DataSource = pchReceive.PortNameArr;
            cb_baudRate.DataSource = BaudRateArr;
            cb_dataBit.DataSource = DataBitArr;
            cb_stopBit.DataSource = StopBitArr;
        }

        private void ComReceiveData(string data)
        {
            this.Invoke(new EventHandler(delegate
            {
                if (data.Length > 0)
                {
                    if(data[0] == 'A')
                    {
                        string str = "按下";
                        labelVal.Text = str;
                    }
                    else if(data[0] == 'B')
                    {
                        string str = "正常";
                        labelVal.Text = str;
                    }
                }
            }));
        }

        private void Btn_press(object sender, EventArgs e)
        {
            pchReceive.SendData("A");
        }

        private void Btn_return(object sender, EventArgs e)
        {
            pchReceive.SendData("B");
        }

        private void Btn_get(object sender, EventArgs e)
        {
            pchReceive.SendData("C");
        }
    }
}
