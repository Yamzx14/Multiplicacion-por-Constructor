using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicasion_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Multiplicaclass mult = new Multiplicaclass
                (int.Parse(textBox1.Text),
                int.Parse(textBox2.Text));

            textBox3.Text = mult.Multi().ToString();
        }
    }
}
