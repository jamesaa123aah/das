using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uI
{
    class Status
    {
        /*
         * 记录人员的状态：
         * 002进入A:"p002In"
         * 002离开A："p002Out"
         */

        
        public static string p001_num = "";
        public static string p001_name = "";
        //权限 0 允许  1禁止
        public static string[] p001_A_permit = {"0","0","0","0"};
       
       /* public static string p001_A_permit = "";
        public static string p001_B_permit = "";
        public static string p001_C_permit = "";
        public static string p001_D_permit = "";*/

        //0表示没有滞留时间限制，大于0则表示有滞留时间限制
        public static int[] p001_A_time = { 0, 0, 0, 0 };

        public static Stack<String> p001_st = new Stack<String>();



        public static string p001 = "";
        public static string p002 = "";
        public static string p003 = "";
        public static string p004 = "";
        public static string p005 = "";
        public static string p006 = "";
        public static string p007 = "";
        public static string p008 = "";
        public static string p009 = "";
        public static string p010 = "";
    }
}
