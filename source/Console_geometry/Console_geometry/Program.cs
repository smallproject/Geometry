using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_geometry
{
    class Program
    {
        static void Main(string[] args)
        {

            int sizeofdecimal = sizeof (decimal);
            int sizeofdouble = sizeof (double);
            int sizeoffloat = sizeof (float);
            int sizeofint = sizeof (int);
            int sizeofint16 = sizeof(Int16);
            int sizeofint32 = sizeof(Int32);

            Console.WriteLine("decimal: {0}", sizeofdecimal.ToString());
            Console.WriteLine("double: {0}", sizeofdouble.ToString());
            Console.WriteLine("float: {0}", sizeoffloat.ToString());
            Console.WriteLine("int: {0}", sizeofint.ToString());
            Console.WriteLine("int16: {0}", sizeofint16.ToString());
            Console.WriteLine("int32: {0}", sizeofint32.ToString());
        }
    }
}
