using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace Xml_Loader
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("FG-GML-5437-70-dem10b-20090201.xml");

            XmlNode root = doc.DocumentElement;//<samle>

            Console.WriteLine(root.Name);

            XmlNode A = root.FirstChild;//最初の子ノードを取得

            Console.WriteLine(A.Name);
            //attribute を取得するときはXmlNodeをXmlElementに変換する。
            Console.WriteLine(((XmlElement)A).GetAttribute("attr1"));
            
            //タグの名前で検索。

            XmlNode B = root.SelectSingleNode("gml:name");

            Console.WriteLine(((XmlElement)B).GetAttribute("attr2"));
            
            //Bの最初の子供のリスト
            XmlNodeList bChildren = B.ChildNodes;

            foreach (XmlNode bchild in bChildren)
            {
                Console.WriteLine(((XmlElement)bchild).InnerText);
            }

            Console.ReadLine();
        }
    }
}
