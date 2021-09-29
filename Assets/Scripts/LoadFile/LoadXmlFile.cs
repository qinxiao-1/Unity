using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class LoadXmlFile : MonoBehaviour
{
    /// <summary>
    /// �� Assets/streamingAssets ·���¶�ȡ xmlPath �ļ�
    /// </summary>
    /// <param name="xmlPath"> xml�ļ����ƣ�����"/xxx.xml"</param>
    private void ReadXML(string xmlPath)
    {
        string filePath = Application.streamingAssetsPath + xmlPath;
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(filePath);
        XmlNodeList nodes = xmlDoc.SelectSingleNode("item").ChildNodes;
        foreach (XmlElement node in nodes)
        {
            foreach (XmlElement info in node)
            {
                switch (info.Name)
                {
                    case "name":
                        // ����Ԥ����
                        Debug.Log(info.InnerText);
                        break;
                    case "description":
                        Debug.Log(info.InnerText);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
