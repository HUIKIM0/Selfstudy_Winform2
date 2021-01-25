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
using System.IO;

namespace Simple_Clicker
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> _dData = new Dictionary<string, string>();
        CXMLControl _xml = new CXMLControl();
        string strPath = Application.StartupPath + "\\Save.txt";
        

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
            if (File.Exists(strPath))
            {
                // File이 있을 경우 File Loading
                _dData = _xml.fXML_Reader(strPath);   //파일경로를 Dictionary안에다 넣어주기

                iTick = double.Parse(_dData[CXMLControl._TICK]);     //CXMLControl의 _TICK은 string 형태로 되어있으니까 double로 형변환
                iTotal = double.Parse(_dData[CXMLControl._TOTAL]);
                i1Level = int.Parse(_dData[CXMLControl._LEVEL_1]);
                i3Level = int.Parse(_dData[CXMLControl._LEVEL_3]);
                i50Level = int.Parse(_dData[CXMLControl._LEVEL_50]);
            }


            //Form 에서 제공하는 Timer
            System.Windows.Forms.Timer oTimer = new System.Windows.Forms.Timer();
            oTimer.Enabled = true;
            oTimer.Interval = 100;
            oTimer.Tick += oTimer_Tick;
            oTimer.Start();

        }

        /* Form 닫는 순간 save 되게 작업 */
        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {

            _dData.Clear();

            _dData.Add(CXMLControl._TICK, iTick.ToString());
            _dData.Add(CXMLControl._TOTAL, iTotal.ToString());
            _dData.Add(CXMLControl._LEVEL_1, i1Level.ToString());
            _dData.Add(CXMLControl._LEVEL_3, i3Level.ToString());
            _dData.Add(CXMLControl._LEVEL_50, i50Level.ToString());

            _xml.fXML_Writer(strPath, _dData);  //경로,저장할 데이터
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
