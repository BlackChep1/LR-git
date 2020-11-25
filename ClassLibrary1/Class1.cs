using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private string value1;
        public Class1(string value1)
        {
            this.value1 = value1;
        }
        public string getCos()
        {
          //  double angle = Math.PI * degrees / 180.0;
            return ""+ Math.Cos(Double.Parse(value1));
        }
        public string Clear()
        {
            return "";
        }
        public bool isEmpty()
        {
            bool flag = true;
            if (value1.Length == 0 || Double.Parse(value1) < 0 || Double.Parse(value1) > 360)
                flag = false; 
            return flag;
        }
    }
}
