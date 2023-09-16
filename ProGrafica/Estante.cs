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
    internal class Estante: Objeto
    {
        private Color colorEstante { get; set; }

        public Estante(double centroX, double centroY, double centroZ) : base(centroX, centroY, centroZ)
        {
            colorEstante = Color.DarkSlateGray;
        }

        public Estante(double centroX, double centroY, double centroZ, Color colorEstante) : base(centroX, centroY, centroZ)
        {
            this.colorEstante = colorEstante;
        }

        private Poligono creacionTablas()
        {
            Poligono tablas = new Poligono(colorEstante, PrimitiveType.Quads);

            for (int i = 1; i <= 3 ;  i++)
            {
                int inc = 4 * (i - 1);
                tablas.addVertex("tablas" + i + inc, new Vector3d(-1.00, -.15 - i, 0.5)); //A
                tablas.addVertex("tablas" + (i + 1) + inc, new Vector3d(0.50, -.15 - i, 0.5)); //B
                tablas.addVertex("tablas" + (i + 2) + inc, new Vector3d(0.50, -.15 - i, -1.5));//C
                tablas.addVertex("tablas" + (i + 3) + inc, new Vector3d(-1.00, -.15 - i, -1.5));//D
            }

            return tablas;
        }

        private Poligono creacionPatas()
        {
            Poligono patas = new Poligono(colorEstante, PrimitiveType.Quads);

            patas.addVertex("patasL11", new Vector3d(-1.0, -1.15, 0.5)); //A
            patas.addVertex("patasL12", new Vector3d(-.80, -1.15, 0.5)); //B
            patas.addVertex("patasL13", new Vector3d(-.80, -3.45, 0.5));//C
            patas.addVertex("patasL14", new Vector3d(-1.00, -3.45, 0.5));//D

            patas.addVertex("patasL15", new Vector3d(-1.0, -1.15, 0.3)); //A
            patas.addVertex("patasL16", new Vector3d(-.80, -1.15, 0.3)); //B
            patas.addVertex("patasL17", new Vector3d(-.80, -3.45, 0.3));//C
            patas.addVertex("patasL18", new Vector3d(-1.00, -3.45, 0.3));//D

            patas.addVertex("patasL19", new Vector3d(-1.0, -1.15, 0.5)); //A
            patas.addVertex("patasL110", new Vector3d(-.80, -1.15, 0.3)); //B
            patas.addVertex("patasL111", new Vector3d(-.80, -3.45, 0.3));//C
            patas.addVertex("patasL112", new Vector3d(-1.00, -3.45, 0.5));//D

            patas.addVertex("patasL113", new Vector3d(-1.0, -1.15, 0.3)); //A
            patas.addVertex("patasL114", new Vector3d(-.80, -1.15, 0.5)); //B
            patas.addVertex("patasL115", new Vector3d(-.80, -3.45, 0.5));//C
            patas.addVertex("patasL116", new Vector3d(-1.00, -3.45, 0.3));//D

            patas.addVertex("patasL21", new Vector3d(-1.0, -1.15, -1.5)); //A
            patas.addVertex("patasL22", new Vector3d(-.80, -1.15, -1.5)); //B
            patas.addVertex("patasL23", new Vector3d(-.80, -3.45, -1.5));//C
            patas.addVertex("patasL24", new Vector3d(-1.00, -3.45, -1.5));//D

            patas.addVertex("patasL25", new Vector3d(-1.0, -1.15, -1.3)); //A
            patas.addVertex("patasL26", new Vector3d(-.80, -1.15, -1.3)); //B
            patas.addVertex("patasL27", new Vector3d(-.80, -3.45, -1.3));//C
            patas.addVertex("patasL28", new Vector3d(-1.00, -3.45, -1.3));//D

            patas.addVertex("patasL29", new Vector3d(-1.0, -1.15, -1.5)); //A
            patas.addVertex("patasL210", new Vector3d(-.80, -1.15, -1.3)); //B
            patas.addVertex("patasL211", new Vector3d(-.80, -3.45, -1.3));//C
            patas.addVertex("patasL212", new Vector3d(-1.00, -3.45, -1.5));//D

            patas.addVertex("patasL213", new Vector3d(-1.0, -1.15, -1.3)); //A
            patas.addVertex("patasL214", new Vector3d(-.80, -1.15, -1.5)); //B
            patas.addVertex("patasL215", new Vector3d(-.80, -3.45, -1.5));//C
            patas.addVertex("patasL216", new Vector3d(-1.00, -3.45, -1.3));//D

            patas.addVertex("patasL31", new Vector3d(.50, -1.15, -1.5)); //A
            patas.addVertex("patasL32", new Vector3d(.20, -1.15, -1.5)); //B
            patas.addVertex("patasL33", new Vector3d(.20, -3.45, -1.5));//C
            patas.addVertex("patasL34", new Vector3d(.50, -3.45, -1.5));//D

            patas.addVertex("patasL35", new Vector3d(.50, -1.15, -1.3)); //A
            patas.addVertex("patasL36", new Vector3d(.20, -1.15, -1.3)); //B
            patas.addVertex("patasL37", new Vector3d(.20, -3.45, -1.3));//C
            patas.addVertex("patasL38", new Vector3d(.50, -3.45, -1.3));//D

            patas.addVertex("patasL39", new Vector3d(.50, -1.15, -1.5)); //A
            patas.addVertex("patasL310", new Vector3d(.20, -1.15, -1.3)); //B
            patas.addVertex("patasL311", new Vector3d(.20, -3.45, -1.3));//C
            patas.addVertex("patasL312", new Vector3d(.50, -3.45, -1.5));//D

            patas.addVertex("patasL313", new Vector3d(.50, -1.15, -1.3)); //A
            patas.addVertex("patasL314", new Vector3d(.20, -1.15, -1.5)); //B
            patas.addVertex("patasL315", new Vector3d(.20, -3.45, -1.5));//C
            patas.addVertex("patasL316", new Vector3d(.50, -3.45, -1.3));//D

            patas.addVertex("patasL41", new Vector3d(.50, -1.15, 0.5)); //A
            patas.addVertex("patasL42", new Vector3d(.20, -1.15, 0.5)); //B
            patas.addVertex("patasL43", new Vector3d(.20, -3.45, 0.5));//C
            patas.addVertex("patasL44", new Vector3d(.50, -3.45, 0.5));//D
            
            patas.addVertex("patasL45", new Vector3d(.50, -1.15, .3)); //A
            patas.addVertex("patasL46", new Vector3d(.20, -1.15, .3)); //B
            patas.addVertex("patasL47", new Vector3d(.20, -3.45, .3));//C
            patas.addVertex("patasL48", new Vector3d(.50, -3.45, .3));//D

            patas.addVertex("patasL49", new Vector3d(.50, -1.15, .5)); //A
            patas.addVertex("patasL410", new Vector3d(.20, -1.15, .3)); //B
            patas.addVertex("patasL411", new Vector3d(.20, -3.45, .3));//C
            patas.addVertex("patasL412", new Vector3d(.50, -3.45, .5));//D

            patas.addVertex("patasL413", new Vector3d(.50, -1.15, .3)); //A
            patas.addVertex("patasL414", new Vector3d(.20, -1.15, .5)); //B
            patas.addVertex("patasL415", new Vector3d(.20, -3.45, .5));//C
            patas.addVertex("patasL416", new Vector3d(.50, -3.45, .3));//D
            return patas;
        }

        public void crear()
        {
            addPoligono("tablas", creacionTablas());
            addPoligono("patas", creacionPatas());
        }
    }
}
