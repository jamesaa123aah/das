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
        /*

        //新建定时器。要用System.Timers.Timer。
        //不要用forms.Timer的定时器。这个不精准
        System.Timers.Timer myTimer;
        void Form1_Load(object sender, EventArgs e)
        {
            myTimer = new System.Timers.Timer(1000);//定时周期2秒
            myTimer.Elapsed += myTimer_Elapsed;//到2秒了做的事件
            myTimer.AutoReset = true; //是否不断重复定时器操作
        }


        //定时器的定时操作
        void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

           // numericUpDown1.Value = numericUpDown4.Value = 0;
            //判断人员所出的位置
            //A区域
                if (Status.p001.location == "A")
                {
                    numericUpDown1.Value = numericUpDown1.Value + 1;
                    Status.p001.location = "Q";
                }
                if (Status.p002.location == "A")
                {
                    numericUpDown1.Value = numericUpDown1.Value + 1;
                    Status.p002.location = "Q";
                }
                 if (Status.p003.location == "A")
                {
                    numericUpDown1.Value = numericUpDown1.Value + 1;
                    Status.p003.location = "Q";
                }
                
            
                //D区域
                if (Status.p001.location == "D")
                {
                    numericUpDown4.Value = numericUpDown4.Value + 1;
                    Status.p001.location = "Q";
                }
                 if (Status.p002.location == "D")
                {
                    numericUpDown4.Value = numericUpDown4.Value + 1;
                    Status.p002.location = "Q";
                }
                if (Status.p003.location == "D")
                {
                    numericUpDown4.Value = numericUpDown4.Value + 1;
                    Status.p003.location = "Q";
                }

           
        }
        */



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

            if(checkBox1.CheckState==CheckState.Checked){
                
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
            else if (checkBox2.CheckState == CheckState.Checked)
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
            else if (checkBox3.CheckState == CheckState.Checked)
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
            else if (checkBox4.CheckState == CheckState.Checked)
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
    }
}
