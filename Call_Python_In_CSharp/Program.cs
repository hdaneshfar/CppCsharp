using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace Call_Python_In_CSharp
{
    class Program
    {
        // https://ironpython.net/download/
        // Install Nugets :
        // Install-Package IronPython
        // Install-Package IronPython.StdLib
        // https://www.red-gate.com/simple-talk/dotnet/net-framework/dynamic-language-integration-in-a-c-world/



        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            dynamic py = engine.ExecuteFile(@"..\..\calc.py");
            
            dynamic calc = py.Calculator();


            Console.WriteLine(calc.__class__.__name__);
            //write 'Calculator'

            double a = 7.5;
            double b = 2.5;
            double res;
            res = calc.add(a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, res);
            res = calc.sub(a, b);
            Console.WriteLine("{0} - {1} = {2}", a, b, res);
            Console.WriteLine("Press any key to finish...");
            Console.ReadLine();


        }
    }
}
