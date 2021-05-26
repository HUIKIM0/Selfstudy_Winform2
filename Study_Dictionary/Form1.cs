using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Study_Dictionary
{
    public partial class Form1 : Form
    {
        enum enCandidateName
        {
            보검,
            수진,
            우식,
            예나,
        }


        enum enClassmateName
        {
            슈화,
            우기,
            아린,
            지효,
            사토미,
            사쿠라,
            선미,
            청하,
            아이린,
            조이,
            슬기,
            예리,
            웬디,
        }


        int _PlayerCount = 0;

        Dictionary<string, string> _dic = new Dictionary<string, string>();
        //Hashtable _ht = new Hashtable();
        // _ht["강아지"] ="멍멍";      Dictionary처럼 key value.
        // _ht["고양이"] ="야옹";   


    public Form1()
        {
            InitializeComponent();
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            string strSelectText = string.Empty;

            PictureBox pbox = sender as PictureBox;
            switch (pbox.Name)
            {
                //pbox1.Name을 클릭 ->보검이를 선택함
                case "pbox1":
                    strSelectText = enCandidateName.보검.ToString();
                    break;

                case "pbox2":
                    strSelectText = enCandidateName.수진.ToString();
                    break;

                case "pbox3":
                    strSelectText = enCandidateName.우식.ToString();
                    break;

                case "pbox4":
                    strSelectText = enCandidateName.예나.ToString();
                    break;

                default:
                    break;
            }

            //Enum ClassmateName의 개수(13명)
            int iTotalCount = Enum.GetValues(typeof(enClassmateName)).Length;

            if (iTotalCount > _PlayerCount)  //if 13 > 0
            {
                /* enum은 integer 형태
                   슈화 0
                   우기 1 이런식
                   enum으로 형변환을 시켜주면 순번값이 int -> enum형태로!
                   _PlayerCount가 0일때, enClassmateName의 0번째 값을 가져감(슈화) */
                enClassmateName enName = (enClassmateName)_PlayerCount;

                _dic.Add(enName.ToString(), strSelectText);  //key->투표한 친구 value->후보자

                fUIDisplay(iTotalCount, enName.ToString());   // 13, 투표자이름 
                fDataGridViewDisplay();

                _PlayerCount++;
            }
            else
            {
                lblTotalCount.Text = "투표가 끝났습니다";
            }
        }


        private void fUIDisplay(int iTotalCount, string strPlayerName)
        {
            int i보검 = 0;
            int i수진 = 0;
            int i우식 = 0;
            int i예나 = 0;

            foreach (string oitem in _dic.Values)
            {
                // string 값을 enum으로 형변환 하는 부분

                switch (oitem)
                {
                    case "보검":
                        i보검++;
                        break;
                    case "수진":
                        i수진++;
                        break;
                    case "우식":
                        i우식++;
                        break;
                    case "예나":
                        i예나++;
                        break;
                }
            }

            lblPick1.Text = i보검.ToString();
            lblPick2.Text = i수진.ToString();
            lblPick3.Text = i우식.ToString();
            lblPick4.Text = i예나.ToString();


            // 0 / 0
            lblTotalCount.Text = string.Format("{0} / {1}", _PlayerCount + 1, iTotalCount);  //  1/13  2/13.. 
            lblPlayerName.Text = strPlayerName;   //투표자 이름
        }


        private void fDataGridViewDisplay()
        {
            //dgViewList.DataSource = _strList.Select(x => new { Value = x }).ToList();


            /* .DataSource 딕셔너리는 이렇게 간단하게 가능 */
            dgViewList.DataSource = _dic.ToArray();


            //dgViewList.Rows.Clear();

            //foreach (KeyValuePair<string,string> oitem in _dic)
            //{
            //    dgViewList.Rows.Add(oitem.Key, oitem.Value);
            //}

            foreach (DataGridViewRow oRow in dgViewList.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

    }
}
