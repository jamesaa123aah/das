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

        /*
         *区域A
         */
        public static int A_tag=0; //标记是否允许进入，针对所有人。可以进入：“0”，不可以进入：“1”
        public static int A_time=0;//规定可停留的最长时间：若无限制：则为0. 大于0则按秒计算
        public static int A_person_number = 0;

     /*
     *区域B
     */
        public static int B_tag; //标记是否允许进入，针对所有人。可以进入：“0”，不可以进入：“1”
        public static int B_time;//规定可停留的最长时间：若无限制：则为0. 大于0则按秒计算
        public static int B_person_number = 1;


        /*
         *区域C
         */
        public static int C_tag; //标记是否允许进入，针对所有人。可以进入：“0”，不可以进入：“1”
        public static int C_time;//规定可停留的最长时间：若无限制：则为0. 大于0则按秒计算
    


        /*
         *区域D
         */
        public static int D_tag; //标记是否允许进入，针对所有人。可以进入：“0”，不可以进入：“1”
        public static int D_time;//规定可停留的最长时间：若无限制：则为0. 大于0则按秒计算


    }
}
