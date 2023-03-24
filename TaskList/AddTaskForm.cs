using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskList.Models;

namespace TaskList
{
    public partial class AddTaskForm : Form
    {
        private XmlHelper _helper;
        public AddTaskForm()
        {
            InitializeComponent();
            _helper = new XmlHelper();
        }

        private void CmdSave(object sender, EventArgs e)
        {
            try
            {
                _helper.CheckDoubles(TaskNameInput.Text);
                _helper.CheckName(TaskNameInput.Text);
               // if (InProcessInput.Text == "") InProcessInput.Text = "Без статуса";
                _helper.AddRecord(TaskNameInput.Text, DateFromInput.Text, DateToInput.Text, AboutInput.Text, InProcessInput.Text);
            }
            catch (Exception ex)
            { MessageBox.Show($"{ex.Message}"); }
            this.Close();

        }
    }
}
