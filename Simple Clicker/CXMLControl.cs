using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace Simple_Clicker
{
    class CXMLControl
    {
        //DiDictionary 및 XML 태그 항목 정의 (static(정적): 프로그램 실행->메모리에 바로 할당
        public static string _TICK = "TICK";
        public static string _TOTAL = "TOTAL";
        public static string _LEVEL_1 = "LEVEL_1";
        public static string _LEVEL_3 = "LEVEL_3";
        public static string _LEVEL_50 = "LEVEL_50";


        /* ★XML 저장하기★ 
           strXMLPath ->저장 할 XML File의 ★경로 및 파일명
           DXMLConfig -> ★XML로 저장 해줄거. Dictionary<키,벨류>를 갖는다 */
        public void fXML_Writer(string strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            StringBuilder sb = new StringBuilder();

            
            //using 벗어나면 자동으로 Dispose 하여 메모리를 관리
            using (XmlWriter wr = XmlWriter.Create(sb))  // XML 생성★ 
            {

                // XML 형태의 Data를 작성
                wr.WriteStartDocument();     //<?xml version="1.0" encoding="UTF-8" 이런거

                // root node  <SETTING ID ="0001"> 
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");  // attribute 쓰기

                // 자식 node
                wr.WriteElementString(_TICK, DXMLConfig[_TICK]);
                wr.WriteElementString(_TOTAL, DXMLConfig[_TOTAL]);
                wr.WriteElementString(_LEVEL_1, DXMLConfig[_LEVEL_1]);
                wr.WriteElementString(_LEVEL_3, DXMLConfig[_LEVEL_3]);
                wr.WriteElementString(_LEVEL_50, DXMLConfig[_LEVEL_50]);



                wr.WriteEndElement();  //자식 node 닫기 </>
                wr.WriteEndDocument();  //root node 닫기 </>
            }

            //암호화
            //sb에다 XML 넣어줬다 sb.ToString(), key는 CRijndael
            string strRijndaelText = CRijndael.EncryptString(sb.ToString(), CRijndael._bkey);
            File.WriteAllText(strXMLPath, strRijndaelText);  //암호화 시킨거 저장(파일경로,암호화시킨거)
        }


        /* ★XML 읽어오기★
         Dictionary 형태로 써줬으니까 Dictionary 형태로!  int stirng 이런거 써주듯 써준거다 헷갈 X
         string strXMLPath -> 읽어 올 XML File의 경로 및 파일명 */
        public Dictionary<string,string> fXML_Reader(string strXMLPath)
        {

            string strRijndaelText = File.ReadAllText(strXMLPath); //암호화 읽어오기
            /* 복호화 -> CRijndael.DecryptString(암호화 되어있는 문서,키)*/
            string strDECText = CRijndael.DecryptString(strRijndaelText, CRijndael._bkey);

            // 읽어 온 XML Data를 Dictionary에 저장하기 위해 선언 및 초기화
            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();

            using (XmlReader rd = XmlReader.Create(new StringReader(strDECText)))   //스트림 형태로
            {
                //한 줄씩 읽으면서 더이상 읽을게 없을 때 까지 정보 가져옴
                while (rd.Read())
                {
                    if (rd.IsStartElement())  //root node 읽기시작 했?
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            string strID = rd["ID"];
                            rd.Read(); //다음 노드로 이동


                            // ★키 값을 기준★으로 결과 값을 가져 옴
                            // 키값과 가져온 결과 값을 Dictionary에 저장
                            string strTICK = rd.ReadElementContentAsString(_TICK, "");
                            DXMLConfig.Add(_TICK, strTICK);

                            string strTOTAL = rd.ReadElementContentAsString(_TOTAL, "");
                            DXMLConfig.Add(_TOTAL, strTOTAL);

                            string strLEVEL_1 = rd.ReadElementContentAsString(_LEVEL_1, "");
                            DXMLConfig.Add(_LEVEL_1, strLEVEL_1);


                            string strLEVEL_3 = rd.ReadElementContentAsString(_LEVEL_3, "");
                            DXMLConfig.Add(_LEVEL_3, strLEVEL_3);


                            string strLEVEL_50 = rd.ReadElementContentAsString(_LEVEL_50, "");
                            DXMLConfig.Add(_LEVEL_50, strLEVEL_50);
                        }
                    }
                }
            }

            return DXMLConfig;  // Dictionary 담아준 읽은 값들 반환
        }
    }
}
