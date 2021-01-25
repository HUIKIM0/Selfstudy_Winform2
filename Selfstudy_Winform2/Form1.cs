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

        CXMLControl _xml = new CXMLControl(); // 만들어 놓은 CXMLControl을 사용. 선언 및 초기화 (기본 생성자)
        Dictionary<string, string> _dData = new Dictionary<string, string>();  // CXMLControl과 Data를 _dData 통해 주고받기. Dictionary형
        string strPath = Application.StartupPath + "\\Save.txt";


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
            sb.Append(iNumber.ToString());   //int -> string 형변환

            // UI에서 작성 한 항목과 값을 딕셔너리 Key와 Value로 저장
            //static 형태라서 바로 접근 사용 _xml 이 아니다
            _dData.Add(CXMLControl._TEXT_DATA, strText);
            _dData.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _dData.Add(CXMLControl._NUMBER_DATA, iNumber.ToString());

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

                /* File.IO 사용 ver */
                // File.WriteAllText(strFilePath, tboxConfigData.Text);

                /* XML 파일 생성. 저장할 데이터 _dData */
                _xml.fXML_Writer(strFilePath, _dData);  

                //StreamWriter swSFDialog = new StreamWriter(strFilePath); //텍스트 파일 쓰기
                //swSFDialog.WriteLine(tboxConfigData.Text);  //tboxCinfigData의 내용 파일 안에다 쓰기
                //swSFDialog.Close(); //다 쓰고 닫기
            }
        }

        /* text 읽어오기 */
        private void btnTextLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;  // ★프로그램 실행파일 위치
            OFDialog.FileName = "*.txt";  //파일 이름
            OFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";  //파일 형식의 확장자들

            StringBuilder sb = new StringBuilder();

            if (OFDialog.ShowDialog() == DialogResult.OK)  // 파일 열기(OK)
            {
                strFilePath = OFDialog.FileName;  //FilePath에 불러온 파일 이름 넣기

                /* File.IO 사용 ver */
                sb.Append(File.ReadAllText(strFilePath));

                tboxConfigData.Text = sb.ToString();


                //StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);

                ////불러온 파일의 텍스트가 마지막 줄이 아니면(false) 계속 돈다
                //while (srOFDialog.EndOfStream == false) //EndOfStream 마지막 줄인지 아닌지 체크.
                //{
                //    sb.Append(srOFDialog.ReadLine() + Enter);  //ReadLine 한줄씩 읽어옴

                //}

                _dData.Clear();  //기존 데이터가 남아 있을 수도 있어서
                _dData = _xml.fXML_Reader(strFilePath);    //읽어오는 거니까 경로만 필요
            }
        }

        /* config 가져오기 */
        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            //string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); // 자르고 버리기

            //tboxData.Text = strConfig[0];
            //cboxData.Checked = bool.Parse(strConfig[1]);    //string -> bool로 형변환
            //numData.Value = int.Parse(strConfig[2]);    //string -> int로 형변환

            /* 디렉토리에 있는 정보를 UI에 입력함 */
            tboxData.Text = _dData[CXMLControl._TEXT_DATA];
            cboxData.Checked = bool.Parse(_dData[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_dData[CXMLControl._NUMBER_DATA]);



        }
    }
}
