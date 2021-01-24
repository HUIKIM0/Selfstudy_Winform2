using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Clicker
{
    public partial class Form1 : Form
    {
        private double iTick = 0; //한 Tick당 더할 값
        private double iToTal = 0; //전체 값

        private int i1Add = 1;  // 처음 더해주고 할 기본값은 +1
        private int i1Level = 1;

        private int i3Add = 0;
        private int i3Level = 0;

        private int i50Add = 0;
        private int i50Level = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form 에서 제공하는 Timer
            System.Windows.Forms.Timer oTimer = new System.Windows.Forms.Timer();
            oTimer.Enabled = true;
            oTimer.Interval = 100;
            oTimer.Tick += oTimer_Tick;

            oTimer.Start();  //timer 호출!
        }

        //타이머에서 호출할 Event
        private void oTimer_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i3Add + i50Add;
            iToTal = iToTal + iTick;

            lblTickPoint.Text = string.Format("{0} : (1:{1}), (3:{2}), (50:{3})",iToTal.ToString(),i1Level.ToString(),i3Level.ToString(),i50Level.ToString());
            lblTotal.Text = iToTal.ToString();
        }
    }
}
