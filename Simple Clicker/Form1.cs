using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace Simple_Clicker
{
    public partial class Form1 : Form
    {
        private double iTick = 0; //한 Tick당 더할 값
        private double iTotal = 0; //전체 값

        private int i1Add = 1;  // 1 * LEVEL 값
        private int i1Level = 1;

        private int i3Add = 3;  // 3 * LEVEL 값
        private int i3Level = 1;

        private int i50Add = 50;   // 50 * LEVEL 값
        private int i50Level = 1;


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
            oTimer.Start();

        }


        //타이머에서 호출할 Event
        private void oTimer_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i3Add + i50Add;
            iTotal = iTotal + iTick;

            lblTickPoint.Text = string.Format("{0} (1:{1}), (3:{2}), (50:{3})", iTick.ToString(), i1Level.ToString(), i3Level.ToString(), i50Level.ToString());
            lblTotal.Text = iTotal.ToString();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            //object sender을 Button으로 형변환
            Button obtn = sender as Button;


            //obtn이 Button으로 형변환됨 -> Button의 name속성 사용가능
            switch (obtn.Name)
            {
                case "btn1Add":
                    if (iTotal > 100)
                    {
                        iTotal = iTotal - 100;

                        i1Level++;
                        i1Add = 1 * i1Level;
                    }
                    break;
                case "btn3Add":
                    if (iTotal > 300)
                    {
                        iTotal = iTotal - 300;

                        i3Level++;
                        i3Add = 3 * i3Level;
                    }
                    break;
                case "btn50Add":
                    if (iTotal > 5000)
                    {
                        iTotal = iTotal - 5000;

                        i50Level++;
                        i50Add = 50 * i50Level;
                    }
                    break;
                default:
                    break;
            }
        }



    }
}
