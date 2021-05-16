using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_DataTable
{
    public partial class Form1 : Form
    {
        //반의 정보를 가지고 있을 DataSet
        DataSet ds = new DataSet();

        DataTable dt = null;

        public Form1()
        {
            InitializeComponent();
        }

        /* 등록 버튼
           클릭했을 경우 반에 대한 DataTable을 만들고, DataSet에 등록
           1. DataSet에 해당 데이터가 존재하는지?
           2-1. 존재하지 않는다 -> DataTable 생성 후 DataSet에 넣는다
           2-2. 존재한다 -> 기존 DataTable 가져온다 */
        private void btnReg_Click(object sender, EventArgs e)
        {
            bool CheckIsTable = false;  


            // DataSet의 에 넣어준 값에 해당하는 DataTable이 있는지. 있으면 true
            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                CheckIsTable = true;
            }

            /* 넣어준 값이 기존의 DataTable이 없다! 여기로 옴 ->생성*/
            if (!CheckIsTable)
            {
                dt = new DataTable(cboxRegClass.Text);

                //DataColumn 생성
                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);

            }
            /* 기존 DataTable이 존재 -> DataSet에서 해당 DataTable을 가져온다*/
            else
            {
                dt = ds.Tables[cboxRegClass.Text];
            }


            /* ★ DataTable에 DataRow 생성 */
            DataRow row = dt.NewRow();

            row["NAME"] = tboxRegName.Text;

            if (rdoRegMale.Checked)
            {
                row["SEX"] = "남자";
            }
            else if (rdoRegFemale.Checked)
            {
                row["SEX"] = "여자";
            }

            row["Ref"] = tboxRegRef.Text;


            if (CheckIsTable)
            {
                ds.Tables[cboxRegClass.Text].Rows.Add(row); // DataSet에 해당 DataTalbe이 있을 경우 기존 Table에 Row를 추가한다
            }
            else
            {
                dt.Rows.Add(row);   //신규로 작성한 DataTable에 Row를 등록하고
                ds.Tables.Add(dt);   //등록한 DataTable을 DataSet에 넣는다
            }


        }

        /* Data 삭제 버튼. 맨 왼쪽 칼럼의 번호 클릭 후 삭제버튼 눌러야 삭제됨  */
        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            int iSelectRow = dgViewInfo.SelectedRows[0].Index;  // dgViewInfo에 보여지는 값 중 선택한 값의 첫번째 Row번호를 가져온다

            //DataSet에 있는 DataTable. 추출한 Index값을 이용해 Row삭제
            ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);
            cboxViewClass_SelectedIndexChanged(this, null);

        }

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];


            // DatagridView Cell 정렬 및 Number를 적용
            foreach (DataGridViewRow oRow in dgViewInfo.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

        }


        /* 수정하기 */
        private void btnModify_Click(object sender, EventArgs e)
        {
            //이름이 적혀있으면
            if (!string.IsNullOrEmpty(tboxRegName.Text))
            {
                foreach (DataRow ditem in ds.Tables[cboxRegClass.Text].Rows)   //DataSet에있는 Tables에서 Row찾아서 Row형태로
                {
                    if (ditem["NAME"].Equals(tboxRegName.Text))
                    { 
                        if (rdoRegFemale.Checked)
                        {
                            ditem["SEX"] = "여자";
                        }
                        else if (rdoRegMale.Checked)
                        {
                            ditem["SEX"] = "남자";
                        }

                        ditem["REF"] = tboxRegRef.Text;
                    }
                }
            }
            cboxViewClass_SelectedIndexChanged(this, null);
        }
    }
}
