﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uI
{
    class AlarmingInfo
    {

        /*
         * 报警信息（按区域查询）
         */
        public struct AlarmInfoArea {

            public string number;
            public string name;
            public string area;
            public string type;
        }


        public static AlarmInfoArea tem;
        public static Stack<AlarmInfoArea> alarmInfo_area= new Stack<AlarmInfoArea>();


        /*
         * 报警信息（按个人查询）
         */
        public struct AlarmInfoPerson
        {

            public string number;
            public string name;
            public string area;
            public string type;
        }


        public static AlarmInfoPerson tem2;
        public static Stack<AlarmInfoPerson> alarmInfo_person = new Stack<AlarmInfoPerson>();


    }
}
