using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/7 11:04:16
    /// Mail : tanz01@haid.com.cn
    /// Description : 警报器
    /// </summary>
    public class Alarm
    {
        public void MakeAleat(int param)
        {
            Console.WriteLine("Alarm：嘀嘀嘀，水已经 {0} 度了：", param);
        }
    }
}
