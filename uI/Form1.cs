using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Timers;
namespace uI
{
    public partial class Form1 : Form
    {
        



        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Insert(0, "p001");
            comboBox1.Items.Insert(1, "p002");
            comboBox1.Items.Insert(2, "p003");
            comboBox1.Items.Insert(3, "p004");
            comboBox1.Items.Insert(4, "p005");
            comboBox1.Items.Insert(5, "p006");
            comboBox1.Items.Insert(6, "p007");
            comboBox1.Items.Insert(7, "p008");
            comboBox1.Items.Insert(8, "p009");
            comboBox1.Items.Insert(9, "p010");

           
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
            
            
            
            /*
             * 按个人查询历史轨迹
             * */
            //step0:将每一列数据放进一个LIst中
            List<string> lsInfo1 = new List<string>();
            List<string> lsInfo2 = new List<string>();
            List<string> lsInfo3 = new List<string>();
            List<string> lsInfo4 = new List<string>();
            List<string> lsInfo5 = new List<string>();

            //step1.获取查询人员的编号
            string number = textBox1.Text;

            //step2.将获取的信息放入表中

            switch(number){

                case "p001":
                   
                   // DataGridView dgv = new DataGridView();
                 //   dgv.Columns.Add("A", "B");


                  //  DataGridViewCellStyle style = new DataGridViewCellStyle();
                   // style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //清空表中数据
                    dataGridView1.Rows.Clear();  
                

                    foreach (Status.Person_track c in Status.p001_st)
                    {
                        lsInfo1.Add(c.number);
                        lsInfo2.Add(c.name);
                        lsInfo3.Add(c.time);
                        lsInfo4.Add(c.area);
                        lsInfo5.Add(c.alarmingInfo);
                    }

                    if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
                    {
                        dataGridView1.Rows.Add(lsInfo1.Count);
                        //data.Rows.Add(lsInfo.Count);
                    }

                    for (int i = 0; i < lsInfo1.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                        dataGridView1.Rows[i].Cells[1].Value = lsInfo2[i];
                        dataGridView1.Rows[i].Cells[2].Value = lsInfo3[i];
                        dataGridView1.Rows[i].Cells[3].Value = lsInfo4[i];
                        dataGridView1.Rows[i].Cells[4].Value = lsInfo5[i];
                    }
                    break;

                case "p002":

                    //清空表中数据
                    dataGridView1.Rows.Clear();  

               

                  foreach (Status.Person_track c in Status.p002_st)
                    {
                        lsInfo1.Add(c.number);
                        lsInfo2.Add(c.name);
                        lsInfo3.Add(c.time);
                        lsInfo4.Add(c.area);
                        lsInfo5.Add(c.alarmingInfo);
                    }

                    if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
                    {
                        dataGridView1.Rows.Add(lsInfo1.Count);
                        //data.Rows.Add(lsInfo.Count);
                    }

                    for (int i = 0; i < lsInfo1.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                        dataGridView1.Rows[i].Cells[1].Value = lsInfo2[i];
                        dataGridView1.Rows[i].Cells[2].Value = lsInfo3[i];
                        dataGridView1.Rows[i].Cells[3].Value = lsInfo4[i];
                        dataGridView1.Rows[i].Cells[4].Value = lsInfo5[i];
                    }
                    break;

                case "p003":

                    //清空表中数据
                    dataGridView1.Rows.Clear();



                    foreach (Status.Person_track c in Status.p003_st)
                    {
                        lsInfo1.Add(c.number);
                        lsInfo2.Add(c.name);
                        lsInfo3.Add(c.time);
                        lsInfo4.Add(c.area);
                        lsInfo5.Add(c.alarmingInfo);
                    }

                    if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
                    {
                        dataGridView1.Rows.Add(lsInfo1.Count);
                        //data.Rows.Add(lsInfo.Count);
                    }

                    for (int i = 0; i < lsInfo1.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                        dataGridView1.Rows[i].Cells[1].Value = lsInfo2[i];
                        dataGridView1.Rows[i].Cells[2].Value = lsInfo3[i];
                        dataGridView1.Rows[i].Cells[3].Value = lsInfo4[i];
                        dataGridView1.Rows[i].Cells[4].Value = lsInfo5[i];
                    }
                    break;

                case "p004":

                    //清空表中数据
                    dataGridView1.Rows.Clear();



                    foreach (Status.Person_track c in Status.p004_st)
                    {
                        lsInfo1.Add(c.number);
                        lsInfo2.Add(c.name);
                        lsInfo3.Add(c.time);
                        lsInfo4.Add(c.area);
                        lsInfo5.Add(c.alarmingInfo);
                    }

                    if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
                    {
                        dataGridView1.Rows.Add(lsInfo1.Count);
                        //data.Rows.Add(lsInfo.Count);
                    }

                    for (int i = 0; i < lsInfo1.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                        dataGridView1.Rows[i].Cells[1].Value = lsInfo2[i];
                        dataGridView1.Rows[i].Cells[2].Value = lsInfo3[i];
                        dataGridView1.Rows[i].Cells[3].Value = lsInfo4[i];
                        dataGridView1.Rows[i].Cells[4].Value = lsInfo5[i];
                    }
                    break;

                case "p005":

                    //清空表中数据
                    dataGridView1.Rows.Clear();



                    foreach (Status.Person_track c in Status.p005_st)
                    {
                        lsInfo1.Add(c.number);
                        lsInfo2.Add(c.name);
                        lsInfo3.Add(c.time);
                        lsInfo4.Add(c.area);
                        lsInfo5.Add(c.alarmingInfo);
                    }

                    if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
                    {
                        dataGridView1.Rows.Add(lsInfo1.Count);
                        //data.Rows.Add(lsInfo.Count);
                    }

                    for (int i = 0; i < lsInfo1.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                        dataGridView1.Rows[i].Cells[1].Value = lsInfo2[i];
                        dataGridView1.Rows[i].Cells[2].Value = lsInfo3[i];
                        dataGridView1.Rows[i].Cells[3].Value = lsInfo4[i];
                        dataGridView1.Rows[i].Cells[4].Value = lsInfo5[i];
                    }
                    break;
                case "p006":

                    //清空表中数据
                    dataGridView1.Rows.Clear();



                    foreach (Status.Person_track c in Status.p006_st)
                    {
                        lsInfo1.Add(c.number);
                        lsInfo2.Add(c.name);
                        lsInfo3.Add(c.time);
                        lsInfo4.Add(c.area);
                        lsInfo5.Add(c.alarmingInfo);
                    }

                    if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
                    {
                        dataGridView1.Rows.Add(lsInfo1.Count);
                        //data.Rows.Add(lsInfo.Count);
                    }

                    for (int i = 0; i < lsInfo1.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                        dataGridView1.Rows[i].Cells[1].Value = lsInfo2[i];
                        dataGridView1.Rows[i].Cells[2].Value = lsInfo3[i];
                        dataGridView1.Rows[i].Cells[3].Value = lsInfo4[i];
                        dataGridView1.Rows[i].Cells[4].Value = lsInfo5[i];
                    }
                    break;

                case "p007":

                    //清空表中数据
                    dataGridView1.Rows.Clear();



                    foreach (Status.Person_track c in Status.p007_st)
                    {
                        lsInfo1.Add(c.number);
                        lsInfo2.Add(c.name);
                        lsInfo3.Add(c.time);
                        lsInfo4.Add(c.area);
                        lsInfo5.Add(c.alarmingInfo);
                    }

                    if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
                    {
                        dataGridView1.Rows.Add(lsInfo1.Count);
                        //data.Rows.Add(lsInfo.Count);
                    }

                    for (int i = 0; i < lsInfo1.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                        dataGridView1.Rows[i].Cells[1].Value = lsInfo2[i];
                        dataGridView1.Rows[i].Cells[2].Value = lsInfo3[i];
                        dataGridView1.Rows[i].Cells[3].Value = lsInfo4[i];
                        dataGridView1.Rows[i].Cells[4].Value = lsInfo5[i];
                    }
                    break;
                case "p008":

                    //清空表中数据
                    dataGridView1.Rows.Clear();



                    foreach (Status.Person_track c in Status.p008_st)
                    {
                        lsInfo1.Add(c.number);
                        lsInfo2.Add(c.name);
                        lsInfo3.Add(c.time);
                        lsInfo4.Add(c.area);
                        lsInfo5.Add(c.alarmingInfo);
                    }

                    if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
                    {
                        dataGridView1.Rows.Add(lsInfo1.Count);
                        //data.Rows.Add(lsInfo.Count);
                    }

                    for (int i = 0; i < lsInfo1.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                        dataGridView1.Rows[i].Cells[1].Value = lsInfo2[i];
                        dataGridView1.Rows[i].Cells[2].Value = lsInfo3[i];
                        dataGridView1.Rows[i].Cells[3].Value = lsInfo4[i];
                        dataGridView1.Rows[i].Cells[4].Value = lsInfo5[i];
                    }
                    break;
                case "p009":

                    //清空表中数据
                    dataGridView1.Rows.Clear();



                    foreach (Status.Person_track c in Status.p009_st)
                    {
                        lsInfo1.Add(c.number);
                        lsInfo2.Add(c.name);
                        lsInfo3.Add(c.time);
                        lsInfo4.Add(c.area);
                        lsInfo5.Add(c.alarmingInfo);
                    }

                    if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
                    {
                        dataGridView1.Rows.Add(lsInfo1.Count);
                        //data.Rows.Add(lsInfo.Count);
                    }

                    for (int i = 0; i < lsInfo1.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                        dataGridView1.Rows[i].Cells[1].Value = lsInfo2[i];
                        dataGridView1.Rows[i].Cells[2].Value = lsInfo3[i];
                        dataGridView1.Rows[i].Cells[3].Value = lsInfo4[i];
                        dataGridView1.Rows[i].Cells[4].Value = lsInfo5[i];
                    }
                    break;

                case "p010":

                    //清空表中数据
                    dataGridView1.Rows.Clear();



                    foreach (Status.Person_track c in Status.p010_st)
                    {
                        lsInfo1.Add(c.number);
                        lsInfo2.Add(c.name);
                        lsInfo3.Add(c.time);
                        lsInfo4.Add(c.area);
                        lsInfo5.Add(c.alarmingInfo);
                    }

                    if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
                    {
                        dataGridView1.Rows.Add(lsInfo1.Count);
                        //data.Rows.Add(lsInfo.Count);
                    }

                    for (int i = 0; i < lsInfo1.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                        dataGridView1.Rows[i].Cells[1].Value = lsInfo2[i];
                        dataGridView1.Rows[i].Cells[2].Value = lsInfo3[i];
                        dataGridView1.Rows[i].Cells[3].Value = lsInfo4[i];
                        dataGridView1.Rows[i].Cells[4].Value = lsInfo5[i];
                    }
                    break;
                default:

                    MessageBox.Show("不存在此人");
                    break;

                

            }

               

            


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
           /* textBox23.Text = (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value).ToString();
            decimal tem = 293;
            textBox24.Text =(tem-(numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value)).ToString();
            Random random = new Random();
            if(random.Next(10,13)==10)
            richTextBox1.AppendText(DateTime.Now.ToString()+" A区域非法离开\r\n");
            else
                richTextBox1.AppendText(DateTime.Now.ToString() + " A区域非法进入\r\n");*/
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
           /* textBox23.Text = (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value).ToString();
            decimal tem = 293;
            textBox24.Text = (tem - (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value)).ToString();
            richTextBox1.AppendText(DateTime.Now.ToString() + " B区域\r\n");*/
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {


            
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            /*textBox23.Text = (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value).ToString();
            decimal tem = 293;
            textBox24.Text = (tem - (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value)).ToString();
            richTextBox1.AppendText(DateTime.Now.ToString() + " C区域\r\n");*/
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
           /* textBox23.Text = (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value).ToString();
            decimal tem = 293;
            textBox24.Text = (tem - (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value)).ToString();
           
            //
            richTextBox1.AppendText(DateTime.Now.ToString() + " D区域\r\n");*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
        

            Form2 form2 = new Form2(this);
            form2.Show();

            button5.Enabled = false;
           
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
        

        //启动按钮
        private void button6_Click(object sender, EventArgs e)
        {
           //模拟器启动按钮
            button5.PerformClick();



            //初始化各个区域的人员数量

            /*
             * step1.将所有的人员放进栈
             */

            Stack<Status.Person> s = new Stack<Status.Person>();
            Status.Person tem;//接收某个人
            s.Push(Status.p001);
            s.Push(Status.p002);
            s.Push(Status.p003);
            s.Push(Status.p004);
            s.Push(Status.p005);
            s.Push(Status.p006);
            s.Push(Status.p007);
            s.Push(Status.p008);
            s.Push(Status.p009);
            s.Push(Status.p010);
        
            for (int i = 0; i < 10; i++) {

                tem = s.Pop();
                switch (tem.location)
                {

                    case "A":
                        numericUpDown1.Value = numericUpDown1.Value + 1;
                        break;
                    case "B":
                        numericUpDown2.Value = numericUpDown2.Value + 1;
                        break;
                    case "C":
                        numericUpDown3.Value = numericUpDown3.Value + 1;
                        break;
                    case "D":
                        numericUpDown4.Value = numericUpDown4.Value + 1;
                        break;
                   
                    default:
                        break;
                }

            }

            
            button6.Enabled = false;


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

            if(radioButton14.Checked==true){
                
                //区域A
                
                if (radioButton10.Checked==true) {
                   
                    
                    Area.Area_A.tag = 1;//禁止进入

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "A区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止进入";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
                else if (radioButton9.Checked == true) {

                    Area.Area_A.time = 60*int.Parse(textBox2.Text);

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "A区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止滞留超时";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
                else if (radioButton6.Checked == true) {
                    Area.Area_A.tag2 = 1;

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "A区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止离开";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
            }
            /*
             * 区域B
             * */
            else if (radioButton12.Checked == true)
            {
                
                if (radioButton10.Checked == true)
                {
                    Area.Area_B.tag = 1;


                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "B区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止进入";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
                else if (radioButton9.Checked == true)
                {

                    Area.Area_B.time = 60 * int.Parse(textBox2.Text);

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "B区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止滞留超时";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
                else if (radioButton6.Checked == true)
                {
                    Area.Area_B.tag2 = 1;

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "B区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止离开";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
            }

            /*
             * 区域C
             * 
             */
            else if (radioButton13.Checked == true)
            {
          
                if (radioButton10.Checked == true)
                {
                    Area.Area_C.tag = 1;

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "C区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止进入";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
                else if (radioButton9.Checked == true)
                {

                    Area.Area_C.time = 60 * int.Parse(textBox2.Text);

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "C区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止滞留超时";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
                else if (radioButton6.Checked == true)
                {
                    Area.Area_C.tag2 = 1;

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "C区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止离开";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
            }

                /*
                 * 
                 * //区域D
                 */
            else if (radioButton11.Checked == true)
            {
                
                if (radioButton10.Checked == true)
                {
                    Area.Area_D.tag = 1;

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "D区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止进入";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
                else if (radioButton9.Checked == true)
                {

                    Area.Area_D.time = 60 * int.Parse(textBox2.Text);

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "D区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止滞留超时";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
                else if (radioButton6.Checked == true)
                {
                    Area.Area_D.tag2 = 1;

                    //将报警信息放入栈中，用于历史查询
                    AlarmingInfo.tem.area = "D区域";
                    AlarmingInfo.tem.name = textBox5.Text;
                    AlarmingInfo.tem.type = "禁止离开";

                    AlarmingInfo.alarmInfo_area.Push(AlarmingInfo.tem);
                    MessageBox.Show("报警条件设置成功");
                }
            }
            else {
                MessageBox.Show("未正确设置条件");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //报警信息查询（按照区域查询）

            //清空表中数据
            dataGridView3.Rows.Clear(); 

            List<string> lsInfo1 = new List<string>();
            List<string> lsInfo2 = new List<string>();
            List<string> lsInfo3 = new List<string>();
            
            foreach (AlarmingInfo.AlarmInfoArea c in AlarmingInfo.alarmInfo_area)
            {
                lsInfo1.Add(c.name);
                lsInfo2.Add(c.area);
                lsInfo3.Add(c.type);
                
            }

            if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
            {
                dataGridView3.Rows.Add(lsInfo1.Count);
                //data.Rows.Add(lsInfo.Count);
            }

            for (int i = 0; i < lsInfo1.Count; i++)
            {
                dataGridView3.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                dataGridView3.Rows[i].Cells[1].Value = lsInfo2[i];
                dataGridView3.Rows[i].Cells[2].Value = lsInfo3[i];
            
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
         * 个人报警信息设置按钮
         * */
        private void button2_Click(object sender, EventArgs e)
        {

            //区域A的选定
            if (radioButton7.Checked == true) {

                if (radioButton4.Checked == true) {
                    //进入
                    int i = comboBox1.SelectedIndex;

                    //判断是第几个人
                    switch (i){
                        case 0:
                            Status.p001.alarming_A_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p001.number;
                            AlarmingInfo.tem2.name = Status.p001.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 1:
                              Status.p002.alarming_A_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p002.number;
                            AlarmingInfo.tem2.name = Status.p002.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                           
                            break;
                        case 2:
                            Status.p003.alarming_A_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p003.number;
                            AlarmingInfo.tem2.name = Status.p003.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            
                            break;
                        case 3:
                            Status.p004.alarming_A_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p004.number;
                            AlarmingInfo.tem2.name = Status.p004.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 4:
                            Status.p005.alarming_A_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p005.number;
                            AlarmingInfo.tem2.name = Status.p005.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 5:
                            Status.p006.alarming_A_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p006.number;
                            AlarmingInfo.tem2.name = Status.p006.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 6:
                            Status.p007.alarming_A_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p007.number;
                            AlarmingInfo.tem2.name = Status.p007.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 7:
                            Status.p008.alarming_A_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p008.number;
                            AlarmingInfo.tem2.name = Status.p008.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 8:
                            Status.p009.alarming_A_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p009.number;
                            AlarmingInfo.tem2.name = Status.p009.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 9:
                            Status.p010.alarming_A_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p010.number;
                            AlarmingInfo.tem2.name = Status.p010.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        default:
                            break;





                    }
                   
                }
                else if (radioButton2.Checked == true) {
                    //离开
                      
                    int i = comboBox1.SelectedIndex;

                    //判断是第几个人
                    switch (i)
                    {
                        case 0:
                            Status.p001.alarming_A_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p001.number;
                            AlarmingInfo.tem2.name = Status.p001.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 1:
                            Status.p002.alarming_A_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p002.number;
                            AlarmingInfo.tem2.name = Status.p002.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 2:
                            Status.p003.alarming_A_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p003.number;
                            AlarmingInfo.tem2.name = Status.p003.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 3:
                            Status.p004.alarming_A_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p004.number;
                            AlarmingInfo.tem2.name = Status.p004.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 4:
                            Status.p005.alarming_A_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p005.number;
                            AlarmingInfo.tem2.name = Status.p005.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 5:
                            Status.p006.alarming_A_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p006.number;
                            AlarmingInfo.tem2.name = Status.p006.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 6:
                            Status.p007.alarming_A_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p007.number;
                            AlarmingInfo.tem2.name = Status.p007.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 7:
                            Status.p008.alarming_A_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p008.number;
                            AlarmingInfo.tem2.name = Status.p008.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 8:
                            Status.p009.alarming_A_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p009.number;
                            AlarmingInfo.tem2.name = Status.p009.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 9:
                            Status.p010.alarming_A_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p010.number;
                            AlarmingInfo.tem2.name = Status.p010.name;
                            AlarmingInfo.tem2.area = "区域A";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        default:
                            break;

                    }
                }
                else if (radioButton3.Checked == true)
                {
                    //滞留
                }
            }  
            else if (radioButton1.Checked == true) //区域B的选定
            {
                if (radioButton4.Checked == true)
                {
                    //进入
                    int i = comboBox1.SelectedIndex;
                   

                    //判断是第几个人
                    switch (i)
                    {
                        case 0:
                            Status.p001.alarming_B_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p001.number;
                            AlarmingInfo.tem2.name = Status.p001.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 1:
                            Status.p002.alarming_B_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p002.number;
                            AlarmingInfo.tem2.name = Status.p002.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                        
                            break;
                        case 2:
                            Status.p003.alarming_B_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p003.number;
                            AlarmingInfo.tem2.name = Status.p003.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 3:
                            Status.p004.alarming_B_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p004.number;
                            AlarmingInfo.tem2.name = Status.p004.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 4:
                            Status.p005.alarming_B_In = 1;
                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p005.number;
                            AlarmingInfo.tem2.name = Status.p005.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 5:
                            Status.p006.alarming_B_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p006.number;
                            AlarmingInfo.tem2.name = Status.p006.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 6:
                            Status.p007.alarming_B_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p007.number;
                            AlarmingInfo.tem2.name = Status.p007.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 7:
                            Status.p008.alarming_B_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p008.number;
                            AlarmingInfo.tem2.name = Status.p008.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 8:
                            Status.p009.alarming_B_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p009.number;
                            AlarmingInfo.tem2.name = Status.p009.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 9:
                            Status.p010.alarming_B_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p010.number;
                            AlarmingInfo.tem2.name = Status.p010.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        default:
                            break;





                    }
                }
                else if (radioButton2.Checked == true)
                {
                    //离开
                    int i = comboBox1.SelectedIndex;


                    //判断是第几个人
                    switch (i)
                    {
                        case 0:
                            Status.p001.alarming_B_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p001.number;
                            AlarmingInfo.tem2.name = Status.p001.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 1:
                            Status.p002.alarming_B_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p002.number;
                            AlarmingInfo.tem2.name = Status.p002.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 2:
                            Status.p003.alarming_B_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p003.number;
                            AlarmingInfo.tem2.name = Status.p003.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 3:
                            Status.p004.alarming_B_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p004.number;
                            AlarmingInfo.tem2.name = Status.p004.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 4:
                            Status.p005.alarming_B_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p005.number;
                            AlarmingInfo.tem2.name = Status.p005.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 5:
                            Status.p006.alarming_B_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p006.number;
                            AlarmingInfo.tem2.name = Status.p006.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 6:
                            Status.p007.alarming_B_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p007.number;
                            AlarmingInfo.tem2.name = Status.p007.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 7:
                            Status.p008.alarming_B_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p008.number;
                            AlarmingInfo.tem2.name = Status.p008.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 8:
                            Status.p009.alarming_B_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p009.number;
                            AlarmingInfo.tem2.name = Status.p009.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 9:
                            Status.p010.alarming_B_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p010.number;
                            AlarmingInfo.tem2.name = Status.p010.name;
                            AlarmingInfo.tem2.area = "区域B";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        default:
                            break;





                    }
                }
                else if (radioButton3.Checked == true)
                {
                    //滞留
                }
            }
            else if (radioButton5.Checked == true)//区域C的选定
            {
                if (radioButton4.Checked == true)
                {
                    //进入
                    int i = comboBox1.SelectedIndex;

                    //判断是第几个人
                    switch (i)
                    {
                        case 0:
                            Status.p001.alarming_C_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p001.number;
                            AlarmingInfo.tem2.name = Status.p001.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 1:
                            Status.p002.alarming_C_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p002.number;
                            AlarmingInfo.tem2.name = Status.p002.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 2:
                            Status.p003.alarming_C_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p003.number;
                            AlarmingInfo.tem2.name = Status.p003.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 3:
                            Status.p004.alarming_C_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p004.number;
                            AlarmingInfo.tem2.name = Status.p004.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 4:
                            Status.p005.alarming_C_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p005.number;
                            AlarmingInfo.tem2.name = Status.p005.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 5:
                            Status.p006.alarming_C_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p006.number;
                            AlarmingInfo.tem2.name = Status.p006.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 6:
                            Status.p007.alarming_C_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p007.number;
                            AlarmingInfo.tem2.name = Status.p007.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 7:
                            Status.p008.alarming_C_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p008.number;
                            AlarmingInfo.tem2.name = Status.p008.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 8:
                            Status.p009.alarming_C_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p009.number;
                            AlarmingInfo.tem2.name = Status.p009.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 9:
                            Status.p010.alarming_C_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p010.number;
                            AlarmingInfo.tem2.name = Status.p010.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        default:
                            break;
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    //离开
                    int i = comboBox1.SelectedIndex;

                    //判断是第几个人
                    switch (i)
                    {
                        case 0:
                            Status.p001.alarming_C_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p001.number;
                            AlarmingInfo.tem2.name = Status.p001.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 1:
                            Status.p002.alarming_C_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p002.number;
                            AlarmingInfo.tem2.name = Status.p002.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 2:
                            Status.p003.alarming_C_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p003.number;
                            AlarmingInfo.tem2.name = Status.p003.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 3:
                            Status.p004.alarming_C_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p004.number;
                            AlarmingInfo.tem2.name = Status.p004.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 4:
                            Status.p005.alarming_C_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p005.number;
                            AlarmingInfo.tem2.name = Status.p005.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 5:
                            Status.p006.alarming_C_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p006.number;
                            AlarmingInfo.tem2.name = Status.p006.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 6:
                            Status.p007.alarming_C_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p007.number;
                            AlarmingInfo.tem2.name = Status.p007.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 7:
                            Status.p008.alarming_C_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p008.number;
                            AlarmingInfo.tem2.name = Status.p008.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 8:
                            Status.p009.alarming_C_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p009.number;
                            AlarmingInfo.tem2.name = Status.p009.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 9:
                            Status.p010.alarming_C_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p010.number;
                            AlarmingInfo.tem2.name = Status.p010.name;
                            AlarmingInfo.tem2.area = "区域C";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        default:
                            break;
                    }
                }
                else if (radioButton3.Checked == true)
                {
                    //滞留
                }
            }
            else if (radioButton8.Checked == true) //区域D的选定
            {
                if (radioButton4.Checked == true)
                {
                    //进入
                    int i = comboBox1.SelectedIndex;

                    //判断是第几个人
                    switch (i)
                    {
                        case 0:
                            Status.p001.alarming_D_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p001.number;
                            AlarmingInfo.tem2.name = Status.p001.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 1:
                            Status.p002.alarming_D_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p002.number;
                            AlarmingInfo.tem2.name = Status.p002.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 2:
                            Status.p003.alarming_D_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p003.number;
                            AlarmingInfo.tem2.name = Status.p003.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 3:
                            Status.p004.alarming_D_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p004.number;
                            AlarmingInfo.tem2.name = Status.p004.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 4:
                            Status.p005.alarming_D_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p005.number;
                            AlarmingInfo.tem2.name = Status.p005.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 5:
                            Status.p006.alarming_D_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p006.number;
                            AlarmingInfo.tem2.name = Status.p006.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 6:
                            Status.p007.alarming_D_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p007.number;
                            AlarmingInfo.tem2.name = Status.p007.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 7:
                            Status.p008.alarming_D_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p008.number;
                            AlarmingInfo.tem2.name = Status.p008.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 8:
                            Status.p009.alarming_D_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p009.number;
                            AlarmingInfo.tem2.name = Status.p009.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 9:
                            Status.p010.alarming_D_In = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p010.number;
                            AlarmingInfo.tem2.name = Status.p010.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止进入";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        default:
                            break;
                    }

                }
                else if (radioButton2.Checked == true)
                {
                    //离开
                    int i = comboBox1.SelectedIndex;

                    //判断是第几个人
                    switch (i)
                    {
                        case 0:
                            Status.p001.alarming_D_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p001.number;
                            AlarmingInfo.tem2.name = Status.p001.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 1:
                            Status.p002.alarming_D_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p002.number;
                            AlarmingInfo.tem2.name = Status.p002.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 2:
                            Status.p003.alarming_D_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p003.number;
                            AlarmingInfo.tem2.name = Status.p003.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");


                            break;
                        case 3:
                            Status.p004.alarming_D_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p004.number;
                            AlarmingInfo.tem2.name = Status.p004.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 4:
                            Status.p005.alarming_D_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p005.number;
                            AlarmingInfo.tem2.name = Status.p005.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");
                            break;
                        case 5:
                            Status.p006.alarming_D_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p006.number;
                            AlarmingInfo.tem2.name = Status.p006.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 6:
                            Status.p007.alarming_D_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p007.number;
                            AlarmingInfo.tem2.name = Status.p007.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 7:
                            Status.p008.alarming_D_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p008.number;
                            AlarmingInfo.tem2.name = Status.p008.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 8:
                            Status.p009.alarming_D_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p009.number;
                            AlarmingInfo.tem2.name = Status.p009.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        case 9:
                            Status.p010.alarming_D_Out = 1;

                            //将报警信息放入栈中，用于查询报警信息
                            AlarmingInfo.tem2.number = Status.p010.number;
                            AlarmingInfo.tem2.name = Status.p010.name;
                            AlarmingInfo.tem2.area = "区域D";
                            AlarmingInfo.tem2.type = "禁止离开";

                            AlarmingInfo.alarmInfo_person.Push(AlarmingInfo.tem2);
                            MessageBox.Show("报警条件设置成功");

                            break;
                        default:
                            break;
                    }

                }
                else if (radioButton3.Checked == true)
                {
                    //滞留
                }
            }
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //报警信息查询（按照个人查询）

            //清空表中数据
            dataGridView5.Rows.Clear();

            List<string> lsInfo1 = new List<string>();
            List<string> lsInfo2 = new List<string>();
            List<string> lsInfo3 = new List<string>();
            List<string> lsInfo4 = new List<string>();

            foreach (AlarmingInfo.AlarmInfoPerson c in AlarmingInfo.alarmInfo_person)
            {
                lsInfo1.Add(c.number);
                lsInfo2.Add(c.name);
                lsInfo3.Add(c.area);
                lsInfo4.Add(c.type);

            }

            if (lsInfo1 != null && lsInfo1.Count > 0)    //lsInfo就是List<数据> 
            {
                dataGridView5.Rows.Add(lsInfo1.Count);
                //data.Rows.Add(lsInfo.Count);
            }

            for (int i = 0; i < lsInfo1.Count; i++)
            {
                dataGridView5.Rows[i].Cells[0].Value = lsInfo1[i];   //填充第一列的数据 
                dataGridView5.Rows[i].Cells[1].Value = lsInfo2[i];
                dataGridView5.Rows[i].Cells[2].Value = lsInfo3[i];
                dataGridView5.Rows[i].Cells[3].Value = lsInfo4[i];

            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
