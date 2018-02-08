using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/7 10:47:41
    /// Mail : tanz01@haid.com.cn
    /// Description : 热水器
    /// </summary>
    public class Heater
    {
        private int temperature;//被监听的对象
        public delegate void BoilHandler(int param);//声明委托
        public event BoilHandler BoilEvent;//声明事件
        //烧水
        public void BoilWater()
        {
            for (int i = 0; i < 100; i++)
            {
                temperature = i;
                if (temperature > 95)
                {
                    BoilEvent(temperature);//触发事件
                }
            }
        }
    }
}
