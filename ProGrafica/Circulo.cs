using Newtonsoft.Json;
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
    internal class Circulo : Poligono
    {
        [JsonProperty("radio")]
        private double radio { get; set; }
        [JsonProperty("plano")]
        private string plano { get; set; }
        [JsonProperty("centro")]
        private Vector3d centro { get; set; }

        public Circulo() : base()
        {
            this.radio = 0.0f;
            this.plano = "";
            this.centro = new Vector3d();
        }

        [JsonConstructor]
        public Circulo(string descripcion, double radio, string plano, Vector3d centro, Color color) :
             base(color, PrimitiveType.TriangleFan)
        {
            this.radio = radio;
            this.plano = plano;
            this.centro = centro;

            for (int i = 0; i < 360; i++)
            {
                descripcion += i;
                if (plano.Equals("yz"))
                {
                    this.vertices.Add(descripcion, new Vector3d(centro.X,
                                                    centro.Y + Math.Cos(i) * this.radio,
                                                    centro.Z + Math.Sin(i) * this.radio));
                }
                else if (plano.Equals("xz"))
                {
                    this.vertices.Add(descripcion, new Vector3d(centro.X + Math.Cos(i) * this.radio,
                                                     centro.Y,
                                                     centro.Z + Math.Sin(i) * this.radio));
                }
                else if (plano.Equals("xy"))
                {
                    this.vertices.Add(descripcion, new Vector3d(centro[0] + Math.Cos(i) * this.radio,
                                                    centro[1] + Math.Sin(i) * this.radio,
                                                    centro[2]));
                }
            }
        }

        override
        public void dibujar(Vector3d centro)
        {
            GL.Begin(this.forma);
            GL.Color3(this.color);
            double cX = centro.X;
            double cY = centro.Y;
            double cZ = centro.Z;
            //GL.Vertex3(cX + center[0], cY + center[1], cZ + center[2]);
            foreach (var punto in vertices)
            {
                GL.Vertex3(cX + punto.Value.X,
                                cY + punto.Value.Y,
                                cZ + punto.Value.Z);
            }
            GL.End();

        }
    }
}
