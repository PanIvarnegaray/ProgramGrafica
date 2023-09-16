using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramGrafica
{
    internal class Coche: Objeto
    {
        private Color colorCoche { get; set; }
        private Color colorVentana { get; set; }
        private Color colorRuedas { get; set; } 

        public Coche(double centroX, double centroY, double centroZ): base(centroX, centroY, centroZ) {
            colorCoche = Color.DarkBlue;
            colorRuedas = Color.Black;
            colorVentana = Color.Cyan;
        }

        public Coche(double centroX, double centroY, double centroZ, Color colorCoche, Color colorRuedas, Color colorVentana) : base(centroX, centroY, centroZ)
        {
            this.colorCoche = colorCoche;
            this.colorRuedas = colorRuedas;
            this.colorVentana = colorVentana;
        }

        private Poligono creacionCarrosa()
        {
            Poligono carrosa = new Poligono(colorCoche, PrimitiveType.Quads);

            // lado
            carrosa.addVertex("carrosa1", new Vector3d(-0.60, -0.75, 0.0)); //A
            carrosa.addVertex("carrosa2", new Vector3d(-0.60, -1.05, 0.0)); //B
            carrosa.addVertex("carrosa3", new Vector3d(-0.60, -1.05, -1.0));//C
            carrosa.addVertex("carrosa4", new Vector3d(-0.60, -0.75, -1.0));//D
            // atras
            carrosa.addVertex("carrosa5", new Vector3d(-0.60, -0.75, 0.0)); //A
            carrosa.addVertex("carrosa6", new Vector3d(-0.60, -1.05, 0.0)); //B
            carrosa.addVertex("carrosa7", new Vector3d(-0.20, -1.05, 0.0));//C
            carrosa.addVertex("carrosa8", new Vector3d(-0.20, -0.75, 0.0));//D
            // lado
            carrosa.addVertex("carrosa9", new Vector3d(-0.20, -0.75, 0.0)); //A
            carrosa.addVertex("carrosa10", new Vector3d(-0.20, -1.05, 0.0)); //B
            carrosa.addVertex("carrosa11", new Vector3d(-0.20, -1.05, -1.0)); //C
            carrosa.addVertex("carrosa12", new Vector3d(-0.20, -0.75, -1.0)); //D
            // frente
            carrosa.addVertex("carrosa13", new Vector3d(-0.60, -0.75, -1.0)); //A
            carrosa.addVertex("carrosa14", new Vector3d(-0.60, -1.05, -1.0)); //B
            carrosa.addVertex("carrosa15", new Vector3d(-0.20, -1.05, -1.0));//C
            carrosa.addVertex("carrosa16", new Vector3d(-0.20, -0.75, -1.0));//D

            // arriba lado
            carrosa.addVertex("carrosaa1", new Vector3d(-0.60, -0.55, -0.25)); //A
            carrosa.addVertex("carrosaa2", new Vector3d(-0.60, -0.75, -0.25)); //B
            carrosa.addVertex("carrosaa3", new Vector3d(-0.60, -0.75, -0.75));//C
            carrosa.addVertex("carrosaa4", new Vector3d(-0.60, -0.55, -0.75));//D
            // arriba atras
            carrosa.addVertex("carrosaa5", new Vector3d(-0.60, -0.55, -0.25)); //A
            carrosa.addVertex("carrosaa6", new Vector3d(-0.60, -0.75, -0.25)); //B
            carrosa.addVertex("carrosaa7", new Vector3d(-0.20, -0.75, -0.25));//C
            carrosa.addVertex("carrosaa8", new Vector3d(-0.20, -0.55, -0.25));//D
            // arriba lado
            carrosa.addVertex("carrosaa9", new Vector3d(-0.20, -0.55, -0.25)); //A
            carrosa.addVertex("carrosaa10", new Vector3d(-0.20, -0.75, -0.25)); //B
            carrosa.addVertex("carrosaa11", new Vector3d(-0.20, -0.75, -0.75)); //C
            carrosa.addVertex("carrosaa12", new Vector3d(-0.20, -0.55, -0.75)); //D
            // arriba frente
            carrosa.addVertex("carrosaa13", new Vector3d(-0.60, -0.55, -0.75)); //A
            carrosa.addVertex("carrosaa14", new Vector3d(-0.60, -0.75, -0.75)); //B
            carrosa.addVertex("carrosaa15", new Vector3d(-0.20, -0.75, -0.75));//C
            carrosa.addVertex("carrosaa16", new Vector3d(-0.20, -0.55, -0.75));//D

            return carrosa;
        }

        private Poligono creacionVentanas()
        {
            Poligono ventana = new Poligono(colorVentana, PrimitiveType.Quads);

            // arriba lado
            ventana.addVertex("ventana1", new Vector3d(-0.58, -0.57, -0.24)); //A
            ventana.addVertex("ventana2", new Vector3d(-0.58, -0.73, -0.24)); //B
            ventana.addVertex("ventana3", new Vector3d(-0.42, -0.73, -0.24));//C
            ventana.addVertex("ventana4", new Vector3d(-0.42, -0.57, -0.24));//D

            // arriba lado
            ventana.addVertex("ventana5", new Vector3d(-0.38, -0.57, -0.24)); //A
            ventana.addVertex("ventana6", new Vector3d(-0.38, -0.73, -0.24)); //B
            ventana.addVertex("ventana7", new Vector3d(-0.22, -0.73, -0.24));//C
            ventana.addVertex("ventana8", new Vector3d(-0.22, -0.57, -0.24));//D

            return ventana;
        }

        private void creacionRuedas()
        {

            Circulo ruedaIzq1 = new Circulo("rueda1", 0.15, "yz", new Vector3d(-0.61, -1.0, -0.20), colorRuedas);
            addPoligono("ruedaIzq1", ruedaIzq1);
            Circulo ruedaDer1 = new Circulo("rueda2", 0.15, "yz", new Vector3d(-0.19, -1.0, -0.20), colorRuedas);
            addPoligono("ruedaDer1", ruedaDer1);
            Circulo ruedaIzq2 = new Circulo("rueda3", 0.15, "yz", new Vector3d(-0.61, -1.0, -0.75), colorRuedas);
            addPoligono("ruedaIzq2", ruedaIzq2);
            Circulo ruedaDer2 = new Circulo("rueda4", 0.15, "yz", new Vector3d(-0.19, -1.0, -0.75), colorRuedas);
            addPoligono("ruedaDer2", ruedaDer2);
        }

        public void crear()
        {
            addPoligono("carrosa", creacionCarrosa());
            addPoligono("ventana", creacionVentanas());
            creacionRuedas();
        }
    }
}
