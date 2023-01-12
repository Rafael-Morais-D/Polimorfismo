using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class FormaGeometrica
    {
        public virtual void Desenhar()
        {
            Console.WriteLine("Desenhando uma forma");
        }
    }

    public class Circulo : FormaGeometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um circulo");
        }
    }

    public class Quadrado : FormaGeometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um quadrado");
        }
    }
}
