using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryNEW
{
    class Line : Shape
    { 
        double x1, y1, x2, y2;
        string name;
        public void Load(string[] type)
        {
            this.x1 = double.Parse(type[1]);
            this.y1 = double.Parse(type[2]);
            this.x2 = double.Parse(type[3]);
            this.y2 = double.Parse(type[4]);
            this.name = type[5];
        }
    }
}
