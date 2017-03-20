﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uI
{
    class Status
    {
        //记录人员历史轨迹的结构体类型
       public struct Person_track
        {
            public string number;
            public string name;
            public string time;
            public string area;
            public string alarmingInfo;
        };


        public static Person_track p001_track;
        public static Person_track p002_track;
        public static Person_track p003_track;
        public static Person_track p004_track;
        public static Person_track p005_track;
        public static Person_track p006_track;
        public static Person_track p007_track;
        public static Person_track p008_track;
        public static Person_track p009_track;
        public static Person_track p010_track;

        public struct Person
        {
           public string location;
        };
       

        //0表示没有滞留时间限制，大于0则表示有滞留时间限制
        public static int[] p001_A_time = { 0, 0, 0, 0 };

        public static Stack<Person_track> p001_st = new Stack<Person_track>();
        public static Stack<Person_track> p002_st = new Stack<Person_track>();
        public static Stack<Person_track> p003_st = new Stack<Person_track>();
        public static Stack<Person_track> p004_st = new Stack<Person_track>();
        public static Stack<Person_track> p005_st = new Stack<Person_track>();
        public static Stack<Person_track> p006_st = new Stack<Person_track>();
        public static Stack<Person_track> p007_st = new Stack<Person_track>();
        public static Stack<Person_track> p008_st = new Stack<Person_track>();
        public static Stack<Person_track> p009_st = new Stack<Person_track>(); 
        public static Stack<Person_track> p010_st = new Stack<Person_track>();





     
    }
}
