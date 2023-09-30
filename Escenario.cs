using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace ProgramGrafica
{
    internal class Escenario
    {
        private Dictionary<string, Objeto> objetos;

        private Vector3d centro;

        public Escenario()
        {
            objetos = new Dictionary<string, Objeto>();
            centro = new Vector3d();
        }

        public Escenario(double x, double y, double z)
        {
            objetos = new Dictionary<string, Objeto>();
            centro = new Vector3d(x, y, z);
        }

        public Escenario(Escenario escenario, Vector3d centro)
        {

            objetos = escenario.objetos;
            this.centro = centro;
        }

        public static Escenario clone(Escenario escenario, Vector3d centro)
        {
            Escenario cloneEscenario = new Escenario( escenario, centro);
            return cloneEscenario;
        }

        public void addObjeto( string nombre, Objeto objeto, Vector3d centroObjeto)
        {
            Objeto newObjeto = new Objeto( objeto );
            newObjeto.CentroX = centroObjeto.X;
            newObjeto.CentroY = centroObjeto.Y;
            newObjeto.CenterZ = centroObjeto.Z;
            this.objetos.Add(nombre, newObjeto);
        }

        public void dibujar()  //Dibujar objeto
        {
            if (this.objetos.Count != 0) //Verifica si la lista caras NO está vacía
            {
                foreach (var objeto in this.objetos) //para cada poligono en la lista de poligonos
                {
                    objeto.Value.dibujar(centro);  //Dibujarla
                }
            }
        }
    }
}
