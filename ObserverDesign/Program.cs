using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater obj = new Heater();
            Alarm alert = new Alarm();
            obj.BoilEvent += alert.MakeAleat;//注册方法
            obj.BoilEvent += Display.ShowMsg;//注册静态方法
            obj.BoilWater();//烧水，会自动调用注册过对象的方法
            Console.ReadLine();
        }
    }
}
