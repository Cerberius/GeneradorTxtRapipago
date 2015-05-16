using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorTxtRapipago
{
    public partial class Form1 : Form
    {
        Controller.FormController formController;
        public Form1(Controller.FormController formController)
        {
            this.formController = formController;
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons ok = MessageBoxButtons.OK;
            MessageBox.Show(sender.ToString(), "Sarasa",ok);
        }
    }
}
