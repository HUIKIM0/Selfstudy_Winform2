using System;
using System.Collections;  //ArrayList
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_List
{
    public partial class Form1 : Form
    {
       
        List<string> _strList = new List<string>();  
        ArrayList _arList = new ArrayList();     

        public Form1()
        {
            InitializeComponent();
            dgViewList.Columns.Add("food", "음식");  //Column추가

            //dgViewList["food", 0].Value = "cake";
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            //object sender을 PictureBox로 형변환
            PictureBox pbox = sender as PictureBox;
            string strSelectText = String.Empty;

            //PictureBox Name속성
            switch (pbox.Name)
            {
                case"pbox1":
                    strSelectText = "cake";
                    break;
                case "pbox2":
                    strSelectText = "burger";
                    break;
                case "pbox3":
                    strSelectText = "pizza";
                    break;
                case "pbox4":
                    strSelectText = "ice";
                    break;
                default:
                    break;
            }
            _strList.Add(strSelectText);   //List<string>에 추가

            fUIDisplay();
            fDataGridViewDisplay();
        }


        /* 좋아하는 음식사진 클릭 -> 라벨의 숫자/Total이 올라가게! */
        private void fUIDisplay()
        {
            int iCake = 0;
            int iBurger = 0;
            int iPizza = 0;
            int iIce = 0;

            foreach (string oitem in _strList)
            {
                switch (oitem)
                {
                    case"cake":
                        iCake++;
                        break;

                    case "burger":
                        iBurger++;
                        break;

                    case "pizza":
                        iPizza++;
                        break;

                    case "ice":
                        iIce++;
                        break;
                    default:
                        break;
                }
            }

            lblPick1.Text = iCake.ToString();
            lblPick2.Text = iBurger.ToString();
            lblPick3.Text = iPizza.ToString();
            lblPick4.Text = iIce.ToString();

            lblTotalCount.Text = _strList.Count.ToString();
        }


        private void fDataGridViewDisplay()
        {
            dgViewList.Rows.Clear();

            foreach (string oitem in _strList)
            {
                dgViewList.Rows.Add(oitem);  //cake,burger,pizza,ice로 dgViewList에 추가해주기 위함
            }


            foreach (DataGridViewRow oRow in dgViewList.Rows)
            {
                //HeaderCell의 Value값을 dgViewList.Rows의 Index 값으로 하면,
                //사용자가 음식 선택해서 dgViewList에 들어갈 때 마다 0,1,2,3..번호가 적힌다
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

   
    }
}

