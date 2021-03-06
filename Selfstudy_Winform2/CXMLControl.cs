﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace Selfstudy_Winform2
{
    /* Xml 읽을때 : 경로
       Xml 저장할때 : 경로, 딕셔너리<키,벨류> */


    class CXMLControl
    {
        //DiDictionary 및 XML 태그 항목 정의 (static(정적): 프로그램 실행->메모리에 바로 할당
        public static string _TEXT_DATA = "TEXT_DATA";      
        public static string _CBOX_DATA = "CBOX_DATA";
        public static string _NUMBER_DATA = "NUMBER_DATA";



        /* ★XML 저장하기/만들기★ 
          strXMLPath ->저장 할 XML File의 ★경로 및 파일명
          DXMLConfig -> ★XML로 저장 해줄 내용. Dictionary<키,벨류>를 갖는다 */
        public void fXML_Writer(string strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            //using 벗어나면 자동으로 Dispose 하여 메모리를 관리
            using (XmlWriter wr = XmlWriter.Create(strXMLPath))    //xml 파일이 만들어짐(wr) 경로는 strXMLPath
            {

                // XML 형태의 Data를 작성
                wr.WriteStartDocument();     //<?xml version="1.0" encoding="UTF-8" 이런거

                // root node  <SETTING ID ="0001"> 
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");  // attribute 쓰기

                // 자식 node. 요소를 작성
                wr.WriteElementString(_TEXT_DATA, DXMLConfig[_TEXT_DATA]);  //name,value(딕셔너리 이므로 여기는 key 적어줌)
                wr.WriteElementString(_CBOX_DATA, DXMLConfig[_CBOX_DATA]);
                wr.WriteElementString(_NUMBER_DATA, DXMLConfig[_NUMBER_DATA]);


                wr.WriteEndElement();  //자식 node 닫기 </>
                wr.WriteEndDocument();  //root node 닫기 </>
            }
        }



        /* ★XML 읽어오기★
         ★딕셔너리 형태<키,벨류> 값 읽어온걸 딕셔너리에 넣어서 xml형태로 바꾸기★
          Dictionary 형태로 써줬으니까 Dictionary<키,벨류> 로!  int stirng 이런거 써주듯 써준거다 헷갈 X
         ★ string strXMLPath -> 읽어 올 XML File의 경로 및 파일명 */
        public Dictionary<string, string> fXML_Reader(string strXMLPATH)
        {
            // 읽어 온 XML Data를 Dictionary에 저장하기 위해 선언 및 초기화
            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();

            using (XmlReader rd = XmlReader.Create(strXMLPATH))
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


                            /* 1.★키 값을 기준★ ex)_TEXT_DATA 으로 결과 값을 가져 옴
                                 ex) <TEXT_DATA> ff </TEXT DATA> 에서 ff 이거를 strTEXT 변수에 넣는다
                               2. ★키값과 가져온 결과 값을 Dictionary에 저장★ */

                            string strTEXT = rd.ReadElementContentAsString(_TEXT_DATA, "");
                            DXMLConfig.Add(_TEXT_DATA, strTEXT);

                            string strCBOX = rd.ReadElementContentAsString(_CBOX_DATA, "");
                            DXMLConfig.Add(_CBOX_DATA, strCBOX);

                            string strNUMBER = rd.ReadElementContentAsString(_NUMBER_DATA, "");
                            DXMLConfig.Add(_NUMBER_DATA, strNUMBER);
                        }
                    }
                }
            }
            return DXMLConfig;  // Dictionary 담아준 읽은 값들 반환
        }
       

    }
}

