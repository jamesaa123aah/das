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
            if (Area.Area_D.tag == 1 || Status.p001.alarming_D_In==1) {
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
            if (Area.Area_D.tag2 == 1 || Status.p001.alarming_D_Out==1)
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
            if (Area.Area_D.tag == 1 || Status.p002.alarming_D_In==1)
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
            if (Area.Area_D.tag2 == 1 || Status.p002.alarming_D_Out==1)
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

            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;





            //将当前活动填入历史轨迹中
            Status.p003_track.time = tem;
            Status.p003_track.area = "进入D区域";
            Status.p003_track.alarmingInfo = "";
            Status.p003.location = "D";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_D.tag == 1 || Status.p003.alarming_D_In == 1)
            {
                Status.p003_track.alarmingInfo = "非法闯入D区域";
                form1.richTextBox1.AppendText(Status.p003_track.name + " " + Status.p003_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p003_st.Push(Status.p003_track);

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value + 1;
            form1.Update();

            button4.Enabled = false;
            button8.Enabled = true;
        }

        //p003离开D
        private void button8_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;



            Status.p003_track.area = "离开D区域";
            Status.p003_track.alarmingInfo = "";
            Status.p003_track.time = tem;
            Status.p003.location = "";//该人员的当前位置
            //判断D区域是否允许离开
            if (Area.Area_D.tag2 == 1 || Status.p003.alarming_D_Out == 1)
            {
                Status.p003_track.alarmingInfo = "非法离开D区域";
                form1.richTextBox1.AppendText(Status.p003_track.name + " " + Status.p003_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录改人员的历史轨迹
            Status.p003_st.Push(Status.p003_track);

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value - 1;
            form1.Update();


            button8.Enabled = false;
            button4.Enabled = true;
        }

        //p004进入D
        private void button5_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;





            //将当前活动填入历史轨迹中
            Status.p004_track.time = tem;
            Status.p004_track.area = "进入D区域";
            Status.p004_track.alarmingInfo = "";
            Status.p004.location = "D";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_D.tag == 1 || Status.p004.alarming_D_In == 1)
            {
                Status.p004_track.alarmingInfo = "非法闯入D区域";
                form1.richTextBox1.AppendText(Status.p004_track.name + " " + Status.p004_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p004_st.Push(Status.p004_track);


            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value + 1;
            form1.Update();

            button5.Enabled = false;
            button9.Enabled = true;
        }

        //P004离开D
        private void button9_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;



            Status.p004_track.area = "离开D区域";
            Status.p004_track.alarmingInfo = "";
            Status.p004_track.time = tem;
            Status.p004.location = "";//该人员的当前位置
            //判断D区域是否允许离开
            if (Area.Area_D.tag2 == 1 || Status.p004.alarming_D_Out == 1)
            {
                Status.p004_track.alarmingInfo = "非法离开D区域";
                form1.richTextBox1.AppendText(Status.p004_track.name + " " + Status.p004_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录改人员的历史轨迹
            Status.p004_st.Push(Status.p004_track);

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value - 1;
            form1.Update();
            
            button9.Enabled = false;
            button5.Enabled = true;
        }

        //006jinru D
        private void button20_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;





            //将当前活动填入历史轨迹中
            Status.p006_track.time = tem;
            Status.p006_track.area = "进入D区域";
            Status.p006_track.alarmingInfo = "";
            Status.p006.location = "D";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_D.tag == 1 || Status.p006.alarming_D_In == 1)
            {
                Status.p006_track.alarmingInfo = "非法闯入D区域";
                form1.richTextBox1.AppendText(Status.p006_track.name + " " + Status.p006_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p006_st.Push(Status.p006_track);


            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value + 1;
            form1.Update();

            button20.Enabled = false;
            button19.Enabled = true;
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
            //判断A区域是否允许进入
            if (Area.Area_A.tag == 1 || Status.p001.alarming_A_In==1)
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
            //判断A区域是否允许离开
            if (Area.Area_A.tag2 == 1 || Status.p001.alarming_A_Out==1)
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
            //判断A区域是否允许进入
            if (Area.Area_A.tag == 1 || Status.p001.alarming_A_In==1)
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
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p002_track.time = tem;
            Status.p002_track.area = "进入A区域";
            Status.p002_track.alarmingInfo = "";
            Status.p002.location = "A";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_A.tag == 1 || Status.p002.alarming_A_In == 1)
            {
                Status.p002_track.alarmingInfo = "非法闯入A区域";
                form1.richTextBox1.AppendText(Status.p002_track.name + " " + Status.p002_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p002_st.Push(Status.p002_track);
            
            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value + 1;
            form1.Update();
            
            button68.Enabled = false;
            button64.Enabled = true;
        }

        //p003离开A
        private void button63_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p003_track.time = tem;
            Status.p003_track.area = "离开A区域";
            Status.p003_track.alarmingInfo = "";
            Status.p003.location = "无";//该人员的当前位置
            //判断A区域是否允许离开
            if (Area.Area_A.tag2 == 1 || Status.p003.alarming_A_Out == 1)
            {
                Status.p003_track.alarmingInfo = "非法离开A区域";
                form1.richTextBox1.AppendText(Status.p003_track.name + " " + Status.p003_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p003_st.Push(Status.p003_track);

            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();
            
            button63.Enabled = false;
            button67.Enabled = true;
        }

        //p002进入C
        private void button28_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p002_track.time = tem;
            Status.p002_track.area = "进入C区域";
            Status.p002_track.alarmingInfo = "";
            Status.p002.location = "C";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_C.tag == 1 || Status.p002.alarming_C_In == 1)
            {
                Status.p002_track.alarmingInfo = "非法闯入C区域";
                form1.richTextBox1.AppendText(Status.p002_track.name + " " + Status.p002_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p002_st.Push(Status.p002_track);
            
            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value + 1;
            form1.Update();
            
            button28.Enabled = false;
            button24.Enabled = true;
        }

        //p004进入B
        private void button46_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p004_track.time = tem;
            Status.p004_track.area = "进入B区域";
            Status.p004_track.alarmingInfo = "";
            Status.p004.location = "B";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_B.tag == 1 || Status.p004.alarming_B_In == 1)
            {
                Status.p004_track.alarmingInfo = "非法闯入B区域";
                form1.richTextBox1.AppendText(Status.p004_track.name + " " + Status.p004_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p004_st.Push(Status.p004_track);

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value + 1;
            form1.Update();

            button46.Enabled = false;
            button42.Enabled = true;
        }

        //p005进入B
        private void button45_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p005_track.time = tem;
            Status.p005_track.area = "进入B区域";
            Status.p005_track.alarmingInfo = "";
            Status.p005.location = "B";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_B.tag == 1 || Status.p005.alarming_B_In == 1)
            {
                Status.p005_track.alarmingInfo = "非法闯入B区域";
                form1.richTextBox1.AppendText(Status.p005_track.name + " " + Status.p005_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p005_st.Push(Status.p005_track);

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value + 1;
            form1.Update();

            button45.Enabled = false;
            button41.Enabled = true;
        }

        //P006进入B
        private void button60_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p006_track.time = tem;
            Status.p006_track.area = "进入B区域";
            Status.p006_track.alarmingInfo = "";
            Status.p006.location = "B";//该人员的当前位置
            //判断A区域是否允许进入
            if (Area.Area_B.tag == 1 || Status.p006.alarming_B_In == 1)
            {
                Status.p006_track.alarmingInfo = "非法闯入B区域";
                form1.richTextBox1.AppendText(Status.p006_track.name + " " + Status.p006_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p006_st.Push(Status.p006_track);

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value + 1;
            form1.Update();

            button60.Enabled = false;
            button59.Enabled = true;
        }

        //007进入C
        private void button38_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p007_track.time = tem;
            Status.p007_track.area = "进入C区域";
            Status.p007_track.alarmingInfo = "";
            Status.p007.location = "C";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_C.tag == 1 || Status.p007.alarming_C_In == 1)
            {
                Status.p007_track.alarmingInfo = "非法闯入C区域";
                form1.richTextBox1.AppendText(Status.p007_track.name + " " + Status.p007_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p007_st.Push(Status.p007_track);

            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value + 1;
            form1.Update();

            button38.Enabled = false;
            button34.Enabled = true;
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
            //判断A区域是否允许进入
            if (Area.Area_B.tag == 1 || Status.p001.alarming_B_In==1)
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
            if (Area.Area_B.tag2 == 1 || Status.p001.alarming_B_Out==1)
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
            if (Area.Area_C.tag == 1 || Status.p001.alarming_C_In==1)
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
            if (Area.Area_C.tag2 == 1 || Status.p001.alarming_C_Out==1)
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
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p002_track.time = tem;
            Status.p002_track.area = "离开A区域";
            Status.p002_track.alarmingInfo = "";
            Status.p002.location = "无";//该人员的当前位置
            //判断A区域是否允许离开
            if (Area.Area_A.tag2 == 1 || Status.p002.alarming_A_Out == 1)
            {
                Status.p002_track.alarmingInfo = "非法离开A区域";
                form1.richTextBox1.AppendText(Status.p002_track.name + " " + Status.p002_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p002_st.Push(Status.p002_track);

            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();
            
            button64.Enabled = false;
            button68.Enabled = true;
        }

        //p002进入B
        private void button48_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p002_track.time = tem;
            Status.p002_track.area = "进入B区域";
            Status.p002_track.alarmingInfo = "";
            Status.p002.location = "B";//该人员的当前位置
            //判断B区域是否允许进入
            if (Area.Area_B.tag == 1 || Status.p002.alarming_B_In == 1)
            {
                Status.p002_track.alarmingInfo = "非法闯入B区域";
                form1.richTextBox1.AppendText(Status.p002_track.name + " " + Status.p002_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p002_st.Push(Status.p002_track);
            
            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value + 1;
            form1.Update();
            
            button48.Enabled = false;
            button44.Enabled = true;
        }


        //p002离开B
        private void button44_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p002_track.time = tem;
            Status.p002_track.area = "离开B区域";
            Status.p002_track.alarmingInfo = "";
            Status.p002.location = "无";//该人员的当前位置
            //判断B区域是否允许离开
            if (Area.Area_B.tag2 == 1 || Status.p002.alarming_B_Out == 1)
            {
                Status.p002_track.alarmingInfo = "非法离开B区域";
                form1.richTextBox1.AppendText(Status.p002_track.name + " " + Status.p002_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p002_st.Push(Status.p002_track);

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value - 1;
            form1.Update();

            button44.Enabled = false;
            button48.Enabled = true;
        }

        //p002离开C区域
        private void button24_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p002_track.time = tem;
            Status.p002_track.area = "离开C区域";
            Status.p002_track.alarmingInfo = "";
            Status.p002.location = "空";//该人员的当前位置
            //判断C区域是否允许离开
            if (Area.Area_C.tag2 == 1 || Status.p002.alarming_C_Out == 1)
            {
                Status.p002_track.alarmingInfo = "非法离开C区域";
                form1.richTextBox1.AppendText(Status.p002_track.name + " " + Status.p002_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p002_st.Push(Status.p002_track);
            
            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value - 1;
            form1.Update();
            
            button24.Enabled = false;
            button28.Enabled = true;
        }

        //p003进入B
        private void button47_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p003_track.time = tem;
            Status.p003_track.area = "进入B区域";
            Status.p003_track.alarmingInfo = "";
            Status.p003.location = "B";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_B.tag == 1 || Status.p003.alarming_B_In == 1)
            {
                Status.p003_track.alarmingInfo = "非法闯入B区域";
                form1.richTextBox1.AppendText(Status.p003_track.name + " " + Status.p003_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p003_st.Push(Status.p003_track);
            
            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value + 1;
            form1.Update();
            
            button47.Enabled = false;
            button43.Enabled = true;
        }

        //p003离开B区域
        private void button43_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p003_track.time = tem;
            Status.p003_track.area = "离开B区域";
            Status.p003_track.alarmingInfo = "";
            Status.p003.location = "无";//该人员的当前位置
            //判断B区域是否允许离开
            if (Area.Area_B.tag2 == 1 || Status.p003.alarming_B_Out == 1)
            {
                Status.p003_track.alarmingInfo = "非法离开B区域";
                form1.richTextBox1.AppendText(Status.p003_track.name + " " + Status.p003_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p003_st.Push(Status.p003_track);
            
            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();
            
            button43.Enabled = false;
            button47.Enabled = true;
        }

        //p003进入C
        private void button27_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p003_track.time = tem;
            Status.p003_track.area = "进入C区域";
            Status.p003_track.alarmingInfo = "";
            Status.p003.location = "C";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_C.tag == 1 || Status.p003.alarming_C_In == 1)
            {
                Status.p003_track.alarmingInfo = "非法闯入C区域";
                form1.richTextBox1.AppendText(Status.p003_track.name + " " + Status.p003_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p003_st.Push(Status.p003_track);
            
            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value + 1;
            form1.Update();
            
            button27.Enabled = false;
            button23.Enabled = true;
        }

        //p003离开C区域
        private void button23_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p003_track.time = tem;
            Status.p003_track.area = "离开C区域";
            Status.p003_track.alarmingInfo = "";
            Status.p003.location = "空";//该人员的当前位置
            //判断C区域是否允许离开
            if (Area.Area_C.tag2 == 1 || Status.p003.alarming_C_Out == 1)
            {
                Status.p003_track.alarmingInfo = "非法离开C区域";
                form1.richTextBox1.AppendText(Status.p003_track.name + " " + Status.p003_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p003_st.Push(Status.p003_track);
            
            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value - 1;
            form1.Update();
            
            button23.Enabled = false;
            button27.Enabled = true;
        }

        //P004进入A
        private void button66_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p004_track.time = tem;
            Status.p004_track.area = "进入A区域";
            Status.p004_track.alarmingInfo = "";
            Status.p004.location = "A";//该人员的当前位置
            //判断A区域是否允许进入
            if (Area.Area_A.tag == 1 || Status.p001.alarming_A_In == 1)
            {
                Status.p004_track.alarmingInfo = "非法闯入A区域";
                form1.richTextBox1.AppendText(Status.p004_track.name + " " + Status.p004_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p004_st.Push(Status.p004_track);

            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value + 1;
            form1.Update();

            button66.Enabled = false;
            button62.Enabled = true;
        }

        //P004离开A
        private void button62_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p004_track.time = tem;
            Status.p004_track.area = "离开A区域";
            Status.p004_track.alarmingInfo = "";
            Status.p004.location = "无";//该人员的当前位置
            //判断A区域是否允许离开
            if (Area.Area_A.tag2 == 1 || Status.p004.alarming_A_Out == 1)
            {
                Status.p004_track.alarmingInfo = "非法离开A区域";
                form1.richTextBox1.AppendText(Status.p004_track.name + " " + Status.p004_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p004_st.Push(Status.p004_track);
            
            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();

            button62.Enabled = false;
            button66.Enabled = true;
        }

        //p005进入A
        private void button65_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p005_track.time = tem;
            Status.p005_track.area = "进入A区域";
            Status.p005_track.alarmingInfo = "";
            Status.p005.location = "A";//该人员的当前位置
            //判断A区域是否允许进入
            if (Area.Area_A.tag == 1 || Status.p005.alarming_A_In == 1)
            {
                Status.p005_track.alarmingInfo = "非法闯入A区域";
                form1.richTextBox1.AppendText(Status.p005_track.name + " " + Status.p005_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p005_st.Push(Status.p005_track);


            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value + 1;
            form1.Update();

            button65.Enabled = false;
            button61.Enabled = true;
        }
        //p005离开A
        private void button61_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p005_track.time = tem;
            Status.p005_track.area = "离开A区域";
            Status.p005_track.alarmingInfo = "";
            Status.p005.location = "无";//该人员的当前位置
            //判断A区域是否允许离开
            if (Area.Area_A.tag == 1 || Status.p005.alarming_A_Out == 1)
            {
                Status.p005_track.alarmingInfo = "非法闯入A区域";
                form1.richTextBox1.AppendText(Status.p005_track.name + " " + Status.p005_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p005_st.Push(Status.p005_track);
            
            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();

            button65.Enabled = false;
            button61.Enabled = true;
        }

        //p004离开B
        private void button42_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p004_track.time = tem;
            Status.p004_track.area = "离开B区域";
            Status.p004_track.alarmingInfo = "";
            Status.p004.location = "无";//该人员的当前位置
            //判断B区域是否允许离开
            if (Area.Area_B.tag2 == 1 || Status.p003.alarming_B_Out == 1)
            {
                Status.p004_track.alarmingInfo = "非法离开B区域";
                form1.richTextBox1.AppendText(Status.p004_track.name + " " + Status.p004_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p004_st.Push(Status.p004_track);
            
            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value - 1;
            form1.Update();

            button42.Enabled = false;
            button46.Enabled = true;
        }

        //P005离开B
        private void button41_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p005_track.time = tem;
            Status.p005_track.area = "离开B区域";
            Status.p005_track.alarmingInfo = "";
            Status.p005.location = "无";//该人员的当前位置
            //判断B区域是否允许离开
            if (Area.Area_B.tag2 == 1 || Status.p003.alarming_B_Out == 1)
            {
                Status.p005_track.alarmingInfo = "非法离开B区域";
                form1.richTextBox1.AppendText(Status.p005_track.name + " " + Status.p005_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p005_st.Push(Status.p005_track);

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value - 1;
            form1.Update();

            button41.Enabled = false;
            button45.Enabled = true;
        }

        //p004进入C区域
        private void button26_Click(object sender, EventArgs e)
        {

            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p004_track.time = tem;
            Status.p004_track.area = "进入C区域";
            Status.p004_track.alarmingInfo = "";
            Status.p004.location = "C";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_C.tag == 1 || Status.p004.alarming_C_In == 1)
            {
                Status.p004_track.alarmingInfo = "非法闯入C区域";
                form1.richTextBox1.AppendText(Status.p004_track.name + " " + Status.p004_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p004_st.Push(Status.p004_track);

            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value + 1;
            form1.Update();

            button26.Enabled = false;
            button22.Enabled = true;
        }

        //p004离开C区域
        private void button22_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p004_track.time = tem;
            Status.p004_track.area = "离开C区域";
            Status.p004_track.alarmingInfo = "";
            Status.p004.location = "空";//该人员的当前位置
            //判断C区域是否允许离开
            if (Area.Area_C.tag2 == 1 || Status.p003.alarming_C_Out == 1)
            {
                Status.p004_track.alarmingInfo = "非法离开C区域";
                form1.richTextBox1.AppendText(Status.p004_track.name + " " + Status.p004_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p004_st.Push(Status.p004_track);

            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value - 1;
            form1.Update();

            button22.Enabled = false;
            button26.Enabled = true;
        }

        //p005进入C
        private void button25_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p005_track.time = tem;
            Status.p005_track.area = "进入C区域";
            Status.p005_track.alarmingInfo = "";
            Status.p005.location = "C";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_C.tag == 1 || Status.p005.alarming_C_In == 1)
            {
                Status.p005_track.alarmingInfo = "非法闯入C区域";
                form1.richTextBox1.AppendText(Status.p005_track.name + " " + Status.p005_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p005_st.Push(Status.p005_track);

            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value + 1;
            form1.Update();

            button25.Enabled = false;
            button21.Enabled = true;
        }

        //p005离开C
        private void button21_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p005_track.time = tem;
            Status.p005_track.area = "离开C区域";
            Status.p005_track.alarmingInfo = "";
            Status.p005.location = "空";//该人员的当前位置
            //判断C区域是否允许离开
            if (Area.Area_C.tag2 == 1 || Status.p005.alarming_C_Out == 1)
            {
                Status.p005_track.alarmingInfo = "非法离开C区域";
                form1.richTextBox1.AppendText(Status.p005_track.name + " " + Status.p005_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p005_st.Push(Status.p005_track);

            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value - 1;
            form1.Update();

            button21.Enabled = false;
            button25.Enabled = true;

        }

        //p005进入D
        private void button6_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;





            //将当前活动填入历史轨迹中
            Status.p005_track.time = tem;
            Status.p005_track.area = "进入D区域";
            Status.p005_track.alarmingInfo = "";
            Status.p005.location = "D";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_D.tag == 1 || Status.p001.alarming_D_In == 1)
            {
                Status.p005_track.alarmingInfo = "非法闯入D区域";
                form1.richTextBox1.AppendText(Status.p005_track.name + " " + Status.p005_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p005_st.Push(Status.p005_track);

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value + 1;
            form1.Update();

            button6.Enabled = false;
            button10.Enabled = true;
        }

        //p005离开D
        private void button10_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;



            Status.p005_track.area = "离开D区域";
            Status.p005_track.alarmingInfo = "";
            Status.p005_track.time = tem;
            Status.p005.location = "";//该人员的当前位置
            //判断D区域是否允许离开
            if (Area.Area_D.tag2 == 1 || Status.p005.alarming_D_Out == 1)
            {
                Status.p005_track.alarmingInfo = "非法离开D区域";
                form1.richTextBox1.AppendText(Status.p005_track.name + " " + Status.p005_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录改人员的历史轨迹
            Status.p005_st.Push(Status.p005_track);
            
            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value - 1;
            form1.Update();

            button10.Enabled = false;
            button6.Enabled = true;
        }

        //p006进入A
        private void button80_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p006_track.time = tem;
            Status.p006_track.area = "进入A区域";
            Status.p006_track.alarmingInfo = "";
            Status.p006.location = "A";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_A.tag == 1 || Status.p006.alarming_A_In == 1)
            {
                Status.p006_track.alarmingInfo = "非法闯入A区域";
                form1.richTextBox1.AppendText(Status.p006_track.name + " " + Status.p006_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p006_st.Push(Status.p006_track);

            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value + 1;
            form1.Update();


            button80.Enabled = false;
            button79.Enabled = true;
        }

        //p006离开A
        private void button79_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p006_track.time = tem;
            Status.p006_track.area = "离开A区域";
            Status.p006_track.alarmingInfo = "";
            Status.p006.location = "无";//该人员的当前位置
            //判断  A区域是否允许离开
            if (Area.Area_A.tag2 == 1 || Status.p006.alarming_A_Out == 1)
            {
                Status.p006_track.alarmingInfo = "非法离开A区域";
                form1.richTextBox1.AppendText(Status.p006_track.name + " " + Status.p006_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p006_st.Push(Status.p006_track);

            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();

            button79.Enabled = true;
            button80.Enabled = false;

        }

        //P007进入A
        private void button78_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p007_track.time = tem;
            Status.p007_track.area = "进入A区域";
            Status.p007_track.alarmingInfo = "";
            Status.p007.location = "A";//该人员的当前位置
            //判断A区域是否允许进入
            if (Area.Area_A.tag == 1 || Status.p007.alarming_A_In == 1)
            {
                Status.p007_track.alarmingInfo = "非法闯入A区域";
                form1.richTextBox1.AppendText(Status.p007_track.name + " " + Status.p007_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p007_st.Push(Status.p007_track);

            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value + 1;
            form1.Update();


            button78.Enabled = false;
            button74.Enabled = true;
        }

        //p007离开A
        private void button74_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p007_track.time = tem;
            Status.p007_track.area = "离开A区域";
            Status.p007_track.alarmingInfo = "";
            Status.p007.location = "无";//该人员的当前位置
            //判断A区域是否允许离开
            if (Area.Area_A.tag2 == 1 || Status.p007.alarming_A_Out == 1)
            {
                Status.p007_track.alarmingInfo = "非法离开A区域";
                form1.richTextBox1.AppendText(Status.p007_track.name + " " + Status.p007_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p007_st.Push(Status.p007_track);

            //记录区域人员的变化
            form1.numericUpDown1.Value = form1.numericUpDown1.Value - 1;
            form1.Update();

            button74.Enabled = true;
            button78.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //p006离开B
        private void button59_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p006_track.time = tem;
            Status.p006_track.area = "离开B区域";
            Status.p006_track.alarmingInfo = "";
            Status.p006.location = "无";//该人员的当前位置
            //判断B区域是否允许离开
            if (Area.Area_B.tag2 == 1 || Status.p006.alarming_B_Out == 1)
            {
                Status.p006_track.alarmingInfo = "非法离开B区域";
                form1.richTextBox1.AppendText(Status.p006_track.name + " " + Status.p006_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p006_st.Push(Status.p006_track);

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value - 1;
            form1.Update();

            button59.Enabled = false;
            button60.Enabled = true;
        }

        //007jinB
        private void button58_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p007_track.time = tem;
            Status.p007_track.area = "进入B区域";
            Status.p007_track.alarmingInfo = "";
            Status.p007.location = "B";//该人员的当前位置
            //判断A区域是否允许进入
            if (Area.Area_B.tag == 1 || Status.p007.alarming_B_In == 1)
            {
                Status.p007_track.alarmingInfo = "非法闯入B区域";
                form1.richTextBox1.AppendText(Status.p007_track.name + " " + Status.p007_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p007_st.Push(Status.p007_track);

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value + 1;
            form1.Update();

            button58.Enabled = false;
            button54.Enabled = true;
        }

        //007离开B
        private void button54_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p007_track.time = tem;
            Status.p007_track.area = "离开B区域";
            Status.p007_track.alarmingInfo = "";
            Status.p007.location = "无";//该人员的当前位置
            //判断B区域是否允许离开
            if (Area.Area_B.tag2 == 1 || Status.p001.alarming_B_Out == 1)
            {
                Status.p007_track.alarmingInfo = "非法离开B区域";
                form1.richTextBox1.AppendText(Status.p007_track.name + " " + Status.p007_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p007_st.Push(Status.p007_track);

            //记录区域人员的变化
            form1.numericUpDown2.Value = form1.numericUpDown2.Value - 1;
            form1.Update();

            button54.Enabled = false;
            button58.Enabled = true;
        }

        //006进入C
        private void button40_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p006_track.time = tem;
            Status.p006_track.area = "进入C区域";
            Status.p006_track.alarmingInfo = "";
            Status.p006.location = "C";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_C.tag == 1 || Status.p001.alarming_C_In == 1)
            {
                Status.p006_track.alarmingInfo = "非法闯入C区域";
                form1.richTextBox1.AppendText(Status.p006_track.name + " " + Status.p006_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p006_st.Push(Status.p006_track);

            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value + 1;
            form1.Update();

            button40.Enabled = false;
            button39.Enabled = true;
        }

        //006离开C
        private void button39_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p006_track.time = tem;
            Status.p006_track.area = "离开C区域";
            Status.p006_track.alarmingInfo = "";
            Status.p006.location = "空";//该人员的当前位置
            //判断C区域是否允许离开
            if (Area.Area_C.tag2 == 1 || Status.p006.alarming_C_Out == 1)
            {
                Status.p006_track.alarmingInfo = "非法离开C区域";
                form1.richTextBox1.AppendText(Status.p006_track.name + " " + Status.p006_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p006_st.Push(Status.p006_track);

            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value - 1;
            form1.Update();

            button39.Enabled = false;
            button40.Enabled = true;
        }

        //007离开C
        private void button34_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;


            //将当前活动填入历史轨迹中
            Status.p007_track.time = tem;
            Status.p007_track.area = "离开C区域";
            Status.p007_track.alarmingInfo = "";
            Status.p007.location = "空";//该人员的当前位置
            //判断C区域是否允许离开
            if (Area.Area_C.tag2 == 1 || Status.p007.alarming_C_Out == 1)
            {
                Status.p007_track.alarmingInfo = "非法离开C区域";
                form1.richTextBox1.AppendText(Status.p007_track.name + " " + Status.p007_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p007_st.Push(Status.p007_track);

            //记录区域人员的变化
            form1.numericUpDown3.Value = form1.numericUpDown3.Value - 1;
            form1.Update();

            button34.Enabled = false;
            button38.Enabled = true;
        }

        //006离开D
        private void button19_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;



            Status.p006_track.area = "离开D区域";
            Status.p006_track.alarmingInfo = "";
            Status.p006_track.time = tem;
            Status.p006.location = "";//该人员的当前位置
            //判断D区域是否允许离开
            if (Area.Area_D.tag2 == 1 || Status.p006.alarming_D_Out == 1)
            {
                Status.p006_track.alarmingInfo = "非法离开D区域";
                form1.richTextBox1.AppendText(Status.p006_track.name + " " + Status.p006_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录改人员的历史轨迹
            Status.p006_st.Push(Status.p006_track);

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value - 1;
            form1.Update();

            button19.Enabled = false;
            button20.Enabled = true;
        }

        //007进入D
        private void button18_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;





            //将当前活动填入历史轨迹中
            Status.p007_track.time = tem;
            Status.p007_track.area = "进入D区域";
            Status.p007_track.alarmingInfo = "";
            Status.p007.location = "D";//该人员的当前位置
            //判断D区域是否允许进入
            if (Area.Area_D.tag == 1 || Status.p001.alarming_D_In == 1)
            {
                Status.p007_track.alarmingInfo = "非法闯入D区域";
                form1.richTextBox1.AppendText(Status.p007_track.name + " " + Status.p007_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录该人员的历史轨迹
            Status.p007_st.Push(Status.p007_track);


            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value + 1;
            form1.Update();

            button18.Enabled = false;
            button14.Enabled = true;
        }

        //007离开D
        private void button14_Click(object sender, EventArgs e)
        {
            //获取当前时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strY = currentTime.ToString("f"); //不显示秒
            int s = currentTime.Second;
            String tem = strY + ":" + s;



            Status.p007_track.area = "离开D区域";
            Status.p007_track.alarmingInfo = "";
            Status.p007_track.time = tem;
            Status.p007.location = "";//该人员的当前位置
            //判断D区域是否允许离开
            if (Area.Area_D.tag2 == 1 || Status.p001.alarming_D_Out == 1)
            {
                Status.p007_track.alarmingInfo = "非法离开D区域";
                form1.richTextBox1.AppendText(Status.p007_track.name + " " + Status.p007_track.alarmingInfo + " " + tem + "\r\n");
                form1.Update();
            }

            //记录改人员的历史轨迹
            Status.p007_st.Push(Status.p007_track);

            //记录区域人员的变化
            form1.numericUpDown4.Value = form1.numericUpDown4.Value - 1;
            form1.Update();

            button14.Enabled = false;
            button18.Enabled = true;
        }

      
    }
}
