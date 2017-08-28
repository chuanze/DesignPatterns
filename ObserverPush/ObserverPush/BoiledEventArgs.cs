using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPush
{
    public class BoiledEventArgs
    {
        private int temperature;//温度
        private string type;//类型
        private string area;//产地
        public BoiledEventArgs(int temperature,string type,string area)
        {
            this.temperature = temperature;
            this.type = type;
            this.area = area;
        }

        public int Temperature { get { return temperature; } }
        public string Type { get { return type; } }
        public string Area { get { return area; } }
    }
}
