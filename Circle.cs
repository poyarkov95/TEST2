using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryNEW
{
    class Circle : Shape
    {
        double x, y;
        int r;
        string name;
        public void Load(string[] type)
        {
            this.x = double.Parse(type[1]);
            this.y = double.Parse(type[2]);
            this.r = int.Parse(type[3]);
            this.name = type[4];
            Console.WriteLine("Создан " + name + "с центром х : " + x + "y : " + y + "и радиусом " + r);
        }
    }
}
