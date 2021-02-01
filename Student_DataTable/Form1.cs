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

            /* DataTable에 DataRow 생성 */
            DataRow row = dt.NewRow();

            row["Name"] = tboxRegName.Text;

            if (rdoRegMale.Checked)
            {
                row["Sex"] = "남자";
            }
            else if (rdoRegFemale.Checked)
            {
                row["Sex"] = "여자";
            }

            row["Ref"] = tboxRegRef.Text;

            bool CheckIsTable = false;

            // DataSet의 에 해당하는 DataTable이 있는지
            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                CheckIsTable = true;
            }


            /* 기존 DataTable이 없다 ->생성*/
            if (!CheckIsTable)
            {
                dt = new DataTable(cboxRegClass.Text);

                //DataColumn 생성
                DataColumn colName = new DataColumn("Name", typeof(string));
                DataColumn colSex = new DataColumn("Sex", typeof(string));
                DataColumn colRef = new DataColumn("Ref", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);

            }
            /* 기존 DataTable이 존재 -> DataSet에서 해당 DataTable을 가져온다*/
            else
            {
                dt = ds.Tables[cboxRegClass.Text];
            }
        }
    }
}
