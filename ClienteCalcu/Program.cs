using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ClienteCalcu.ServiceReference1;

namespace ClienteCalcu
{
    class Program
    {
      
       public static void Main(string[] args)
       {
           double[] o = {3, 6, 9, 5, 4};

           var cl = new CalculadoraClient();

           var r = cl.Sumar(2, 2);

           Console.WriteLine(r);

           var rr = cl.SumaCompleja(o);

           Console.WriteLine(rr.Resultado + "->" + rr.Operandos);

           var d = 0d;

           try
           {
               d= cl.Dividir(2, 0);
           }
           catch (FaultException<ErrorDivision> e)
           {
               Console.WriteLine(e.Detail.Descripcion);
               Console.WriteLine(e.Message);
           }

           Console.WriteLine(d);


           Console.ReadLine();


       }
    }
}
