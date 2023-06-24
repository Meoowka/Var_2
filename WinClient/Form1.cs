using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service_s.Var_2_spClient client = new Service_s.Var_2_spClient("NetHttpBinding_IVar_2_sp");
            MessageBox.Show(client.GetMessage('\t'+textBox1.Text));
        }
    }
}
