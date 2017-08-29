using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPull
{
    public class Heater : SubjectBase
    {
        private string type;//添加型号作为演示
        private string area;//添加产地作为演示
        private int temperature;//水温
        public Heater(string type, string area)
        {
            this.type = type;
            this.area = area;
            this.temperature = 0;
        }

        public string Type { get { return type; } }
        public string Area { get { return area; } }
        public int Temperature { get { return temperature; } }
        public Heater() : this("RealFire 001", "China Xi'an") { }
        //供子类覆盖，以便子类拒绝被通知，或添加额外行为
        protected virtual void OnBoiled()
        {
            base.Notify(this);//调用父类Notify方法，进而调用所有祖册了Observer的Update方法
        }
        public void BoilWater()//烧水
        {
            for (int i = 0; i <= 99; i++)
            {
                temperature = i + 1;
                if (temperature > 97)//当水快烧开时(温度>97度)，通知Observer
                {
                    OnBoiled();
                }
            }
        }
    }
}
