using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FactoryNEW
{
    abstract class Filer
    {
        abstract public int rdInt(int count);
        abstract public double rdDouble(int count);
        abstract public string rdString(int count);
        abstract public bool eof();
        // GIT SDELAI UPDATE POJALSTA
    }
}
