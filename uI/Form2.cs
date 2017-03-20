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
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY +":"+ s;
       

          
            
          
           //将当前活动填入历史轨迹中
            Status.p001_track.number = "p001";
            Status.p001_track.name = "张桦";
            Status.p001_track.time = tem;
            Status.p001_track.area = "进入D区域";
            Status.p001_track.alarmingInfo = "";
            //判断D区域是否允许进入
            if (Area.Area_D.tag == 1) {
                Status.p001_track.alarmingInfo = "非法闯入D区域";
                form1.richTextBox1.AppendText(Status.p001_track.name+" "+Status.p001_track.alarmingInfo+" "+tem+"\r\n");
                form1.Update();
            }
          
            //记录该人员的历史轨迹
            Status.p001_st.Push(Status.p001_track);




            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;
            
         

            Status.p001_track.area = "离开D区域";
            Status.p001_track.number = "p001";
            Status.p001_track.name = "张桦";
            Status.p001_track.alarmingInfo = "";
            Status.p001_track.time = tem;
            //判断D区域是否允许离开
            if (Area.Area_D.tag2 == 1)
            {
                Status.p001_track.alarmingInfo = "非法离开D区域";
                form1.richTextBox1.AppendText(Status.p001_track.name + " " + Status.p001_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录改人员的历史轨迹
            Status.p001_st.Push(Status.p001_track);


            button3.Enabled = false;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;
           


            Status.p002_track.number = "p002";
            Status.p002_track.name = "李君蜂";
            Status.p002_track.time = tem;
            Status.p002_track.area = "进入D区域";
            Status.p002_track.alarmingInfo = "";
            //判断D区域是否允许进入
            if (Area.Area_D.tag == 1)
            {
                Status.p002_track.alarmingInfo = "非法闯入D区域";
                form1.richTextBox1.AppendText(Status.p002_track.name + " " + Status.p002_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            Status.p002_st.Push(Status.p002_track);
            
            button1.Enabled = false;
            button7.Enabled = true;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;
           


            Status.p002_track.number = "p002";
            Status.p002_track.name = "李君蜂";
            Status.p002_track.time = tem;
            Status.p002_track.area = "离开D区域";
            Status.p002_track.alarmingInfo = "";
            //判断D区域是否允许离开
            if (Area.Area_D.tag2 == 1)
            {
                Status.p002_track.alarmingInfo = "非法离开D区域";
                form1.richTextBox1.AppendText(Status.p002_track.name + " " + Status.p002_track.alarmingInfo + " " + tem+"\r\n");
                form1.Update();
            }

            Status.p002_st.Push(Status.p002_track);
            

            button7.Enabled = false;
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
            button4.Enabled = false;
            button8.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
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
