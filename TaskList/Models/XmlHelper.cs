using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TaskList.Models
{
    internal class XmlHelper
    {

public void DeleteElement(string TName)
        {
            XElement doc = XElement.Load("pdata.xml");
            doc.Elements("Task").Where(e => e.Attribute("name").Value == TName).Remove();
            doc.Save("pdata.xml");
        }

        //string namein, string datefromin, string datetoin, string aboutin, bool inprocessin
        public void AddRecord(string namein, string datefromin, string datetoin, string aboutin, string inprocessin)
        {


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("pdata.xml");
            XmlElement? xRoot = xDoc.DocumentElement;

            // создаем новый элемент person
            XmlElement task = xDoc.CreateElement("Task");

            // создаем атрибут name
            XmlAttribute name = xDoc.CreateAttribute("name");

            // создаем элементы company и age
            XmlElement datefrom = xDoc.CreateElement("DateFrom");
            XmlElement dateto = xDoc.CreateElement("DateTo");
            XmlElement about = xDoc.CreateElement("About");
            XmlElement inprocess = xDoc.CreateElement("InProcess");

            // создаем текстовые значения для элементов и атрибута
            XmlText nameText = xDoc.CreateTextNode(namein);
            XmlText dateFromText = xDoc.CreateTextNode(datefromin);
            XmlText dateToText = xDoc.CreateTextNode(datetoin);
            XmlText aboutText = xDoc.CreateTextNode(aboutin);
            XmlText inprocessBool = xDoc.CreateTextNode(inprocessin);

            //добавляем узлы
            name.AppendChild(nameText);
            datefrom.AppendChild(dateFromText);
            dateto.AppendChild(dateToText);
            about.AppendChild(aboutText);
            inprocess.AppendChild(inprocessBool);

            // добавляем атрибут name
            task.Attributes.Append(name);
            // добавляем элементы company и age
            task.AppendChild(datefrom);
            task.AppendChild(dateto);
            task.AppendChild(about);
            task.AppendChild(inprocess);
            // добавляем в корневой элемент новый элемент person
            xRoot?.AppendChild(task);
            // сохраняем изменения xml-документа в файл
            xDoc.Save("pdata.xml");

        }

        public void CheckDoubles(string namein)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("pdata.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                if (name == namein)
                {
                    throw new Exception("Нельзя создать задачу с таким же именем!");
                }
                
            }
        }//check doubles

        public void CheckName(string namein)
        {
  
                
                if (namein == null || namein == "")
                {
                    throw new Exception("Имя проекта не может быть пустым!");
                }

            
        }//check doubles


    }
}
