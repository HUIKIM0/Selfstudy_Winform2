using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;    //StreamWriter
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selfstudy_Winform2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Enter = "\r\n";

        /*config 설정하기*/
        private void btnConfigSet_Click(object sender, EventArgs e)
        {
            

            string strText = tboxData.Text;  //Text
            bool bChecked = cboxData.Checked;  //Checkbox
            int iNumber = (int)numData.Value;  //NumbericUpDown

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + Enter);
            sb.Append(bChecked.ToString() + Enter); //bool -> string 형변환
            sb.Append(iNumber.ToString());

            tboxConfigData.Text = sb.ToString();  //StringBuilder -> string 형변환
        }


        /*text 저장하기*/
        private void btnTextSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;  // ★프로그램 실행파일 위치
            SFDialog.FileName = "*.txt";  //파일 이름
            SFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";  //파일 형식의 확장자들

            if(SFDialog.ShowDialog() == DialogResult.OK)  //저장버튼(OK) 이면
            {
                strFilePath = SFDialog.FileName;   //파일 이름이랑 경로까지 다 가져옴

                StreamWriter swSFDialog = new StreamWriter(strFilePath); //텍스트 파일 쓰기
                swSFDialog.WriteLine(tboxConfigData.Text);  //tboxCinfigData의 내용 파일 안에다 쓰기
                swSFDialog.Close(); //다 쓰고 닫기

            }
        }

        /* text 읽어오기 */
        private void btnTextLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;  // ★프로그램 실행파일 위치
            OFDialog.FileName = "*.txt";  //파일 이름
            OFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";  //파일 형식의 확장자들

            if(OFDialog.ShowDialog() == DialogResult.OK)  // 파일 열기(OK)
            {
                strFilePath = OFDialog.FileName;  //FilePath에 불러온 파일 이름 넣기

                StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);


                StringBuilder sb = new StringBuilder();

                //불러온 파일의 텍스트가 마지막 줄이 아니면(false) 계속 돈다
                while (srOFDialog.EndOfStream == false) //EndOfStream 마지막 줄인지 아닌지 체크.
                {
                    sb.Append(srOFDialog.ReadLine() + Enter);  //ReadLine 한줄씩 읽어옴

                }

                tboxConfigData.Text = sb.ToString();
            }
        }
    }
}
