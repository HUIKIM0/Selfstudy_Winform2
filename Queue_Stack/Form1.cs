using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_Stack
{
    public partial class Form1 : Form
    {

        // 선언 및 초기화
        Queue<int> _Queue = new Queue<int>(6); 
        Stack<int> _Stack = new Stack<int>(6);

        public Form1()
        {
            InitializeComponent();
        }

        
        /* 버튼 In */
        private void btnDataIn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int iData = rd.Next(1, 101); 

            if(_Queue.Count < 6)
            {
                _Queue.Enqueue(iData);  
                fQueueDataDisplay();
            }

            if(_Stack.Count < 6)
            {
                _Stack.Push(iData);
                fStackDataDisplay();
            }
        }


        /* 버튼 Out */
        private void btnDataOut_Click(object sender, EventArgs e)
        {
            fDataOut();
        }



        Timer _oTimer = new Timer();   //Timer 사용
        bool _bTimer = false;   //Timer 스위치

        /* 버튼 Auto out */
        private void btnAutoDataOut_Click(object sender, EventArgs e)
        {
            // _bTiemr = false
            if (_bTimer)
            {
                _oTimer.Stop();

                _bTimer = false;
            }
            else
            {
                _oTimer.Interval = 2000; //2초
                _oTimer.Tick += _oTimer_Tick;  //Timer 이벤트
                _oTimer.Start();

                _bTimer = true;
            }
        }

        private void _oTimer_Tick(object sender, EventArgs e)
        {
            //Timer 실행이 된다 -> Data가 하나씩 빠진다
            fDataOut();
        }



        /* 값 빼기 */
        private void fDataOut()
        {
            if(_Queue.Count > 0)    //6 5 4 3 2 1. [5] [4] [3] [2] [1] [0]
            {
                _Queue.Dequeue();
                fQueueDataDisplay();
            }

            if(_Stack.Count > 0)
            {
                _Stack.Pop();
                fStackDataDisplay();
            }
        }


        /* Queue의 자료 구조를 화면에 보여줌 _Queue를 Array로! */
        private void fQueueDataDisplay()
        {
            int[] iArray = _Queue.ToArray();
            Array.Resize(ref iArray, 6);  //배열 사이즈 고정

            lblQueue1.Text = (iArray[0] == 0 ? "" : iArray[0].ToString());
            lblQueue2.Text = (iArray[0] == 0 ? "" : iArray[1].ToString());
            lblQueue3.Text = (iArray[0] == 0 ? "" : iArray[2].ToString());
            lblQueue4.Text = (iArray[0] == 0 ? "" : iArray[3].ToString());
            lblQueue5.Text = (iArray[0] == 0 ? "" : iArray[4].ToString());
            lblQueue6.Text = (iArray[0] == 0 ? "" : iArray[5].ToString());

        }


        /* Stack의 자료 구조를 화면에 보여줌 _Stack을 Array로! */
        private void fStackDataDisplay()
        {
            int[] iArray = _Stack.ToArray();
            Array.Resize(ref iArray, 6);  //배열 사이즈 고정

            lblStack1.Text = (iArray[0] == 0 ? "" : iArray[0].ToString());
            lblStack2.Text = (iArray[0] == 0 ? "" : iArray[1].ToString());
            lblStack3.Text = (iArray[0] == 0 ? "" : iArray[2].ToString());
            lblStack4.Text = (iArray[0] == 0 ? "" : iArray[3].ToString());
            lblStack5.Text = (iArray[0] == 0 ? "" : iArray[4].ToString());
            lblStack6.Text = (iArray[0] == 0 ? "" : iArray[5].ToString());

        }

      
    }
}
