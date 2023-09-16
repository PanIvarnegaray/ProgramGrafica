using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;


namespace ProgramGrafica
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game nw = new Game(800, 600, "Programa"))
            {
                nw.Run(30.0);
            }
        }
    }
}
