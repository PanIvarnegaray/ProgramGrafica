using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramGrafica
{
    internal class Muro: Objeto
    {
        private Color colorMuro { get; set; }
        private Color colorCemento { get; set; }

        public Muro(double centroX, double centroY, double centroZ) : base(centroX, centroY, centroZ)
        {
            colorMuro = Color.OrangeRed;
            colorCemento = Color.LightGray;
        }

        public Muro(double centroX, double centroY, double centroZ, Color colorMuro, Color colorCemento) : base(centroX, centroY, centroZ)
        {
            this.colorCemento = colorCemento;
            this.colorMuro = colorMuro;
        }

        private Poligono creacionMuro()
        {
            Poligono muro = new Poligono(colorMuro, PrimitiveType.Quads);

            muro.addVertex("muro1", new Vector3d(-2.0, 3.45, -1.6)); //A
            muro.addVertex("muro2", new Vector3d(2.0, 3.45, -1.6)); //B
            muro.addVertex("muro3", new Vector3d(2.0, -3.45, -1.6));//C
            muro.addVertex("muro4", new Vector3d(-2.00, -3.45, -1.6));//D

            muro.addVertex("muro5", new Vector3d(-2.0, 3.45, -2.0)); //A
            muro.addVertex("muro6", new Vector3d(2.0, 3.45, -2.0)); //B
            muro.addVertex("muro7", new Vector3d(2.0, -3.45, -2.0));//C
            muro.addVertex("muro8", new Vector3d(-2.0, -3.45, -2.0));//D

            muro.addVertex("muro9", new Vector3d(2.0, 3.45, -1.6)); //A
            muro.addVertex("muro10", new Vector3d(2.0, 3.45, -2.0)); //B
            muro.addVertex("muro11", new Vector3d(2.0, -3.45, -2.0));//C
            muro.addVertex("muro12", new Vector3d(2.0, -3.45, -1.6));//D

            muro.addVertex("muro13", new Vector3d(-2.0, 3.45, -1.6)); //A
            muro.addVertex("muro14", new Vector3d(-2.0, 3.45, -2.0)); //B
            muro.addVertex("muro15", new Vector3d(-2.0, -3.45, -2.0));//C
            muro.addVertex("muro16", new Vector3d(-2.0, -3.45, -1.6));//D

            return muro;
        }

        private Poligono creacionCemento()
        {
            Poligono cemento = new Poligono(colorCemento, PrimitiveType.Quads);

            for (int i = 3; i >= -3 ; i--)
            {
                cemento.addVertex("cemento1L" + i, new Vector3d(-2.0, i, -1.58)); //A
                cemento.addVertex("cemento2L" + i, new Vector3d(2.0, i, -1.58)); //B
                cemento.addVertex("cemento3L" + i, new Vector3d(2.0, i + 0.20, -1.58));//C
                cemento.addVertex("cemento4L" + i, new Vector3d(-2.00, i + 0.2,-1.58));//D
            }

            return cemento;
        }

        public void crear()
        {
            addPoligono("muro", creacionMuro());
            addPoligono("cemento", creacionCemento());
        }
    }
}
