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
      


        public Form2(Form f)
        {
            InitializeComponent();

        
           
            this.form1 =(Form1)f;

            /*
             * 初始化按钮
             * 禁用离开按钮
             */
            button3.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button19.Enabled = false;

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

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Status.p001 = "001进入D区域";

            Status.p001_st.Push("001进入D区域");

            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Status.p001 = "001离开D区域";

            Status.p001_st.Push("001离开D区域");


            button3.Enabled = false;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Status.p002 = "002进入D区域";
            button1.Enabled = false;
            button7.Enabled = true;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Status.p002 = "002离开D区域";
            button7.Enabled = false;
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Status.p003 = "003进入D区域";
            button4.Enabled = false;
            button8.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Status.p003 = "003离开D区域";
            button8.Enabled = false;
            button4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button9.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button5.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

      
    }
}
