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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox3.Text = "adasdasda";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox23.Text = (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value).ToString();
            decimal tem = 293;
            textBox24.Text =(tem-(numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value)).ToString();
            Random random = new Random();
            if(random.Next(10,13)==10)
            richTextBox1.AppendText(DateTime.Now.ToString()+" A区域非法离开\r\n");
            else
                richTextBox1.AppendText(DateTime.Now.ToString() + " A区域非法进入\r\n");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox23.Text = (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value).ToString();
            decimal tem = 293;
            textBox24.Text = (tem - (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value)).ToString();
            richTextBox1.AppendText(DateTime.Now.ToString() + " B区域\r\n");
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {


            
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            textBox23.Text = (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value).ToString();
            decimal tem = 293;
            textBox24.Text = (tem - (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value)).ToString();
            richTextBox1.AppendText(DateTime.Now.ToString() + " C区域\r\n");
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            textBox23.Text = (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value).ToString();
            decimal tem = 293;
            textBox24.Text = (tem - (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value)).ToString();
            richTextBox1.AppendText(DateTime.Now.ToString() + " D区域\r\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
        

            Form2 form2 = new Form2(this);
            form2.Show();
           
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Console.WriteLine("A"+Area.A_time+"s+"+Area.A_tag);
            Console.WriteLine("B" + Area.B_time + "s+" + Area.B_tag);
            Console.WriteLine("C" + Area.C_time + "s+" + Area.C_tag);
            Console.WriteLine("D" + Area.D_time + "s+" + Area.D_tag);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
             *设置区域的报警条件
             *step1:
             *检查所选定的是哪个区域
             *
             * step2:
             * 检查所选定的是什么报警条件
             * 
             */
            if(checkBox1.CheckState==CheckState.Checked){
                
                //区域A
                
                if (radioButton10.Checked==true) {
                    Area.A_tag = 1;
                }
                else if (radioButton9.Checked == true) {

                    Area.A_time = 60*int.Parse(textBox2.Text); 
                }
            }
            /*
             * 区域B
             * */
            else if (checkBox2.CheckState == CheckState.Checked)
            {
                
                if (radioButton10.Checked == true)
                {
                    Area.B_tag = 1;
                }
                else if (radioButton9.Checked == true)
                {

                    Area.B_time = 60 * int.Parse(textBox2.Text);
                }
            }

            /*
             * 区域C
             * 
             */
            else if (checkBox3.CheckState == CheckState.Checked)
            {
          
                if (radioButton10.Checked == true)
                {
                    Area.C_tag = 1;
                }
                else if (radioButton9.Checked == true)
                {

                    Area.C_time = 60 * int.Parse(textBox2.Text);
                }
            }

                /*
                 * 
                 * //区域D
                 */
            else if (checkBox4.CheckState == CheckState.Checked)
            {
                
                if (radioButton10.Checked == true)
                {
                    Area.D_tag = 1;
                }
                else if (radioButton9.Checked == true)
                {

                    Area.D_time = 60 * int.Parse(textBox2.Text);
                }
            }
            else {
                MessageBox.Show("未正确设置条件");
            }
        }
    }
}
