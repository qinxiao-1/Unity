using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class LoadXmlFile : MonoBehaviour
{
    /// <summary>
    /// 从 Assets/streamingAssets 路径下读取 xmlPath 文件
    /// </summary>
    /// <param name="xmlPath"> xml文件名称，例："/xxx.xml"</param>
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
                        // 创建预制体
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
