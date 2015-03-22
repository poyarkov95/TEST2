using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace FactoryNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("InputDataFile.txt");
            Program pr = new Program();
            ArrayList arr = new ArrayList();
            foreach (string line in lines)
            {
                string[] type = line.Split(' ');
                arr.Add(pr.ChoiseType(type[0]));
            }

            Console.ReadKey();
        }

        public Shape ChoiseType(string type)
        {
            int N = int.Parse(type);

            switch (N)
            {
                case 1:
                    return new Circle();
                case 2:
                    return new Square();
                case 3:
                    return new Line();
                default: return null;
            }
        }
    }
}

