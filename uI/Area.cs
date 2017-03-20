using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uI
{


 

    class Area
    {    
        /*
 *按照各个区域设置结构体的属性 
         */

        public struct Place
        {
            public int tag;//标记是否允许进入，针对所有人。可以进入：“0”，不可以进入：“1”
            public int tag2;//标记是否允许离开。针对所有人。可以为：0，不可以为1
            public int time;//规定可停留的最长时间：若无限制：则为0. 大于0则按秒计算

            public string name;//条件名
            public string number; //条件编号

        };

        public static Place Area_A;
        public static Place Area_B;
        public static Place Area_C;
        public static Place Area_D;




    }
}
