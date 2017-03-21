﻿using System;
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
             * 初始化人员信息
             */
            //p001:人员信息， p001_track:人员轨迹
            Status.p001_track.number = "p001";
            Status.p001.number = "p001";
            Status.p001_track.name = "张桦";
            Status.p001.name = "张桦";
            Status.p001.location = "A";
           //p002
            Status.p002_track.number = "p002";
            Status.p002.number = "p002";
            Status.p002_track.name = "李君蜂";
            Status.p002.name = "李君蜂";
            Status.p002.location = "A";
            //p003
            Status.p003_track.number = "p003";
            Status.p003.number = "p003";
            Status.p003_track.name = "王兵";
            Status.p003.name = "王兵";
            Status.p003.location = "A";
            //p004
            Status.p004_track.number = "p004";
            Status.p004.number = "p004";
            Status.p004_track.name = "张建";
            Status.p004.name = "张建";
            Status.p004.location = "B";
            //p005
            Status.p005_track.number = "p005";
            Status.p005.number = "p005";
            Status.p005_track.name = "周涛";
            Status.p005.name = "周涛";
            Status.p005.location = "B";
            //p006
            Status.p006_track.number = "p006";
            Status.p006.number = "p006";
            Status.p006_track.name = "张三丰";
            Status.p006.name = "张三丰";
            Status.p006.location = "B";
            //p007
            Status.p007_track.number = "p006";
            Status.p007.number = "p006";
            Status.p007_track.name = "李洪涛";
            Status.p007.name = "李洪涛";
            Status.p007.location = "C";
            //p008
            Status.p008_track.number = "p008";
            Status.p008.number = "p008";
            Status.p008_track.name = "赵建";
            Status.p008.name = "赵建";
            Status.p008.location = "C";
            //p009
            Status.p009_track.number = "p009";
            Status.p009.number = "p009";
            Status.p009_track.name = "李云龙";
            Status.p009.name = "李云龙";
            Status.p009.location = "D";
            //p010
            Status.p010_track.number = "p010";
            Status.p010.number = "p010";
            Status.p010_track.name = "楚云飞";
            Status.p010.name = "楚云飞";
            Status.p010.location = "D";
            /*
             * 初始化按钮
             * 禁用离开按钮
             */
            button67.Enabled = false;
            button68.Enabled = false;
            button70.Enabled = false;
            button46.Enabled = false;
            button45.Enabled = false;
            button60.Enabled = false;
            button38.Enabled = false;
            button37.Enabled = false;
            button16.Enabled = false;
            button15.Enabled = false;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            form1.numericUpDown1.Value = form1.numericUpDown1.Value;
            form1.Update();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            form1.numericUpDown2.Value = form1.numericUpDown2.Value;
           // form1.Update();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            form1.numericUpDown3.Value = form1.numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            form1.numericUpDown4.Value = form1.numericUpDown4.Value;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        //p001进入D
        private void button2_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY +":"+ s;
       

          
            
          
           //将当前活动填入历史轨迹中
            Status.p001_track.time = tem;
            Status.p001_track.area = "进入D区域";
            Status.p001_track.alarmingInfo = "";
            Status.p001.location = "D";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_D.tag == 1) {
                Status.p001_track.alarmingInfo = "非法闯入D区域";
                form1.richTextBox1.AppendText(Status.p001_track.name+" "+Status.p001_track.alarmingInfo+" "+tem+"\r\n");
                form1.Update();
            }
          
            //记录该人员的历史轨迹
            Status.p001_st.Push(Status.p001_track);


            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value + 1;
            form1.Update();

            button2.Enabled = false;
            button3.Enabled = true;
        }

        //p001离开D
        private void button3_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;
            
         

            Status.p001_track.area = "离开D区域";
            Status.p001_track.alarmingInfo = "";
            Status.p001_track.time = tem;
            Status.p001.location = "";//该人员的当前位置
            //判断D区域是否允许离开
            if (Area.Area_D.tag2 == 1)
            {
                Status.p001_track.alarmingInfo = "非法离开D区域";
                form1.richTextBox1.AppendText(Status.p001_track.name + " " + Status.p001_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录改人员的历史轨迹
            Status.p001_st.Push(Status.p001_track);

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value - 1;
            form1.Update();

            button3.Enabled = false;
            button2.Enabled = true;
        }

        //p002进入D
        private void button1_Click(object sender, EventArgs e)
        {
           

            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;
           


            Status.p002_track.time = tem;
            Status.p002_track.area = "进入D区域";
            Status.p002_track.alarmingInfo = "";
            Status.p002.location = "D";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_D.tag == 1)
            {
                Status.p002_track.alarmingInfo = "非法闯入D区域";
                form1.richTextBox1.AppendText(Status.p002_track.name + " " + Status.p002_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            Status.p002_st.Push(Status.p002_track);

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value + 1;
            form1.Update();

            button1.Enabled = false;
            button7.Enabled = true;
            
        }

        //p002离开D
        private void button7_Click(object sender, EventArgs e)
        {


            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;
           



            Status.p002_track.time = tem;
            Status.p002_track.area = "离开D区域";
            Status.p002_track.alarmingInfo = "";
            Status.p002.location = "";//该人员的当前位置
            //判断D区域是否允许离开
            if (Area.Area_D.tag2 == 1)
            {
                Status.p002_track.alarmingInfo = "非法离开D区域";
                form1.richTextBox1.AppendText(Status.p002_track.name + " " + Status.p002_track.alarmingInfo + " " + tem+"\r\n");
                form1.Update();
            }

            Status.p002_st.Push(Status.p002_track);

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value - 1;
            form1.Update();


            button7.Enabled = false;
            button1.Enabled = true;
        }

        //p003
        private void button4_Click(object sender, EventArgs e)
        {

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value + 1;
            form1.Update();

            button4.Enabled = false;
            button8.Enabled = true;
        }

        //p003离开D
        private void button8_Click(object sender, EventArgs e)
        {

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value - 1;
            form1.Update();


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

        //p001进入A
        private void button70_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;

           
            //将当前活动填入历史轨迹中
            Status.p001_track.time = tem;
            Status.p001_track.area = "进入A区域";
            Status.p001_track.alarmingInfo = "";
            Status.p001.location = "A";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_A.tag == 1)
            {
                Status.p001_track.alarmingInfo = "非法闯入A区域";
                form1.richTextBox1.AppendText(Status.p001_track.name + " " + Status.p001_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p001_st.Push(Status.p001_track);

            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value + 1;
            form1.Update();


            button70.Enabled = false;
            button69.Enabled = true;

        }

        //001离开A区域
        private void button69_Click(object sender, EventArgs e)
        {

            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p001_track.time = tem;
            Status.p001_track.area = "离开A区域";
            Status.p001_track.alarmingInfo = "";
            Status.p001.location = "无";//该人员的当前位置
            //判断D区域是否允许离开
            if (Area.Area_A.tag2 == 1)
            {
                Status.p001_track.alarmingInfo = "非法离开A区域";
                form1.richTextBox1.AppendText(Status.p001_track.name + " " + Status.p001_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p001_st.Push(Status.p001_track);
            
            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();

            button70.Enabled = true;
            button69.Enabled = false;

          
        }

        //p003 A区域进入
        private void button67_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p003_track.time = tem;
            Status.p003_track.area = "进入A区域";
            Status.p003_track.alarmingInfo = "";
            Status.p003.location = "A";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_A.tag == 1)
            {
                Status.p003_track.alarmingInfo = "非法闯入A区域";
                form1.richTextBox1.AppendText(Status.p003_track.name + " " + Status.p003_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p003_st.Push(Status.p003_track);

            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value + 1;
            form1.Update();

            button67.Enabled = false;
            button63.Enabled = true;
        }

        //p002进入A
        private void button68_Click(object sender, EventArgs e)
        {
            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value + 1;
            form1.Update();
            
            button68.Enabled = false;
            button64.Enabled = true;
        }

        private void button63_Click(object sender, EventArgs e)
        {

            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();
            
            button63.Enabled = false;
            button67.Enabled = true;
        }

        //p002进入C
        private void button28_Click(object sender, EventArgs e)
        {
            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value + 1;
            form1.Update();
            
            button28.Enabled = false;
            button24.Enabled = true;
        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        //p001进入B区域
        private void button50_Click(object sender, EventArgs e)
        {

            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p001_track.time = tem;
            Status.p001_track.area = "进入B区域";
            Status.p001_track.alarmingInfo = "";
            Status.p001.location = "B";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_B.tag == 1)
            {
                Status.p001_track.alarmingInfo = "非法闯入B区域";
                form1.richTextBox1.AppendText(Status.p001_track.name + " " + Status.p001_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p001_st.Push(Status.p001_track);

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value + 1;
            form1.Update();

            button50.Enabled = false;
            button49.Enabled = true;
        }

        //p001离开B区域
        private void button49_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p001_track.time = tem;
            Status.p001_track.area = "离开B区域";
            Status.p001_track.alarmingInfo = "";
            Status.p001.location = "无";//该人员的当前位置
            //判断B区域是否允许离开
            if (Area.Area_B.tag2 == 1)
            {
                Status.p001_track.alarmingInfo = "非法离开B区域";
                form1.richTextBox1.AppendText(Status.p001_track.name + " " + Status.p001_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p001_st.Push(Status.p001_track);

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value - 1;
            form1.Update();

            button49.Enabled = false;
            button50.Enabled = true;
        }

        //p001进入C区域
        private void button30_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p001_track.time = tem;
            Status.p001_track.area = "进入C区域";
            Status.p001_track.alarmingInfo = "";
            Status.p001.location = "C";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_C.tag == 1)
            {
                Status.p001_track.alarmingInfo = "非法闯入C区域";
                form1.richTextBox1.AppendText(Status.p001_track.name + " " + Status.p001_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p001_st.Push(Status.p001_track);

            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value + 1;
            form1.Update();

            button30.Enabled = false;
            button29.Enabled = true;
        }

        //p001离开C区域
        private void button29_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p001_track.time = tem;
            Status.p001_track.area = "离开C区域";
            Status.p001_track.alarmingInfo = "";
            Status.p001.location = "空";//该人员的当前位置
            //判断C区域是否允许离开
            if (Area.Area_C.tag2 == 1)
            {
                Status.p001_track.alarmingInfo = "非法离开C区域";
                form1.richTextBox1.AppendText(Status.p001_track.name + " " + Status.p001_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p001_st.Push(Status.p001_track);

            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value - 1;
            form1.Update();

            button29.Enabled = false;
            button30.Enabled = true;
        }

        private void button64_Click(object sender, EventArgs e)
        {


            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();
            
            button64.Enabled = false;
            button68.Enabled = true;
        }

        //p002进入B
        private void button48_Click(object sender, EventArgs e)
        {
            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value + 1;
            form1.Update();
            
            button48.Enabled = false;
            button44.Enabled = true;
        }


        private void button44_Click(object sender, EventArgs e)
        {

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value - 1;
            form1.Update();

            button48.Enabled = false;
            button44.Enabled = true;
        }

        //p002离开C区域
        private void button24_Click(object sender, EventArgs e)
        {
            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value - 1;
            form1.Update();
            
            button24.Enabled = false;
            button28.Enabled = true;
        }

        //p003进入B
        private void button47_Click(object sender, EventArgs e)
        {
            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value + 1;
            form1.Update();
            
            button47.Enabled = false;
            button43.Enabled = true;
        }

        //p003离开B区域
        private void button43_Click(object sender, EventArgs e)
        {
            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();
            
            button43.Enabled = false;
            button47.Enabled = true;
        }

        //p003进入C
        private void button27_Click(object sender, EventArgs e)
        {
            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value + 1;
            form1.Update();
            
            button27.Enabled = false;
            button23.Enabled = true;
        }

        //p003离开C区域
        private void button23_Click(object sender, EventArgs e)
        {
            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value - 1;
            form1.Update();
            
            button23.Enabled = false;
            button27.Enabled = true;
        }

      
    }
}
