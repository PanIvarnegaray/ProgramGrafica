using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramGrafica
{
    internal class Ejes
    {
        public Ejes()
        {
        }

        public virtual void dibujar()
        {
            GL.Begin(PrimitiveType.Lines);

            GL.Color3(Color.Black); //Eje X
            GL.Vertex3(-500, 0, 0);
            GL.Vertex3(500, 0, 0);

            GL.Color3(Color.Black); //Eje Y
            GL.Vertex3(0, -500, 0);
            GL.Vertex3(0, 500, 0);

            GL.Color3(Color.Black); //Eje Z
            GL.Vertex3(0, 0, -500);
            GL.Vertex3(0, 0, 500);

            GL.End();
        }
    }
}
