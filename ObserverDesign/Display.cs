using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/7 11:06:33
    /// Mail : tanz01@haid.com.cn
    /// Description : 显示器
    /// </summary>
    public class Display
    {
        public static void ShowMsg(int param) {
            Console.WriteLine("Display：水快烧开了，当前温度：{0}度。", param);
        }
    }
}
