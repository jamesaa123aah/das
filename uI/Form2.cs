using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uI
{
    public partial class Form2 : Form
    {
        
        Form1 form1 = new Form1();

        public Form2( Form f)
        {
            InitializeComponent();
            this.form1 =(Form1)f;
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
            form1.numericUpDown1.Value = numericUpDown1.Value;
            form1.Update();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            form1.numericUpDown2.Value = numericUpDown2.Value;
           // form1.Update();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            form1.numericUpDown3.Value = numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            form1.numericUpDown4.Value = numericUpDown4.Value;
        }
    }
}
