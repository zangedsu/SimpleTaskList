using System.Xml.Serialization;
using System.Xml;
using System.Windows.Forms;
using TaskList.Models;

namespace TaskList
{
    public partial class Form1 : Form
    {
        private XmlHelper _helper; 
        public Form1()
        {
            InitializeComponent();
            _helper = new XmlHelper();
            LoadTasks();
        }

        private void LoadTasks()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("pdata.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                string datefrom = (node["DateFrom"].InnerText);
                string dateto = (node["DateTo"].InnerText);
                string about = (node["About"].InnerText);
                string inprocess = (node["InProcess"].InnerText);
                listBox1.Items.Add(new Task(name, datefrom, dateto, about, inprocess));
            }
        }
        //string namein, string datefromin, string datetoin, string aboutin, bool inprocessin

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
                propertyGrid1.BackColor = Color.LightBlue;
                propertyGrid1.CategoryForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTaskForm addtaskform = new AddTaskForm();
            addtaskform.ShowDialog();

            listBox1.Items.Clear();
           
            LoadTasks();
            

        }

        private void ClickDelete(object sender, EventArgs e)
        {
            try
            {
                string elename = listBox1.SelectedItem.ToString();

                if (elename.Equals("") || elename.Length.Equals(0)){throw new Exception("Вы не выбрали поле для удаления"); }
                _helper.DeleteElement(elename);
                MessageBox.Show(Text = $"Будут удалены все елементы с именем {elename}");
                listBox1.Items.Clear();
                LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text = $"Ошибка {ex}");
            }
            }

        private void ClickExit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}