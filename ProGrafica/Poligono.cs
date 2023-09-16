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
    internal class Poligono
    {

        [JsonProperty("vertices")]
        protected Dictionary<string, Vector3d> vertices { get; set; } //Lista de vertices para hacer un poligono
        [JsonProperty("color")]
        protected Color color { get; set; } //Color del poligono
        [JsonProperty("forma")]
        protected PrimitiveType forma { get; set; } //Forma del poligono

        public Poligono() //Empty constructor, initializes properties
        {
            vertices = new Dictionary<string, Vector3d>();
            color = Color.Transparent;
            forma = new PrimitiveType();
        }
        public Poligono(Dictionary<string, Vector3d> vertices, Color color, PrimitiveType forma) //All-parameters Constructor
        {
            this.vertices = vertices;
            this.color = color;
            this.forma = forma;
        }

        public Poligono(Color color, PrimitiveType forma) //Only color and shape constructor, most commonly used one
        {
            vertices = new Dictionary<string, Vector3d>();
            this.color = color;
            this.forma = forma;
        }
        public virtual void dibujar(Vector3d centro) //Dibuja con el centro especificado
        {
            GL.Begin(this.forma);
            GL.Color3(this.color);
            foreach (var vertex in this.vertices)
            {
                GL.Vertex3(centro.X + vertex.Value.X, centro.Y + vertex.Value.Y, centro.Z + vertex.Value.Z);
            }
            GL.End();
        }

        public virtual void dibujar() // Dibuja con el centro en el sistema de ejes
        {
            GL.Begin(this.forma);
            GL.Color3(this.color);
            foreach (var vertex in this.vertices)
            {
                GL.Vertex3(vertex.Value.X, vertex.Value.Y, vertex.Value.Z);
            }
            GL.End();
        }

        public void addVertex(string descripcion, Vector3d vertex) //Adds a vertex to the list of vertix
        {
            this.vertices.Add(descripcion, vertex);
        }

        public virtual void rotar(Vector3d eje, double theta)
        {
            foreach (var vector in vertices.ToList())
            {
                string key = vector.Key;
                Vector3d vi = new Vector3d(vector.Value.X, vector.Value.Y, vector.Value.Z);
                //(k x v) sin0
                Vector3d kxv = Vector3d.Multiply(Vector3d.Cross(eje, vi), Math.Sin(theta));
                //vcos0+(k x v)sin 0
                Vector3d pt1 = Vector3d.Add(Vector3d.Multiply(vi, Math.Cos(theta)), kxv);
                //k(k.v)
                Vector3d kkdotv = Vector3d.Multiply(eje, Vector3d.Dot(eje, vi));
                //k(k.v)(1-cos0)
                Vector3d pt2 = Vector3d.Multiply(kkdotv, (1.0 - Math.Cos(theta)));
                vertices[key] = Vector3d.Add(pt1, pt2);
            }
        }

        public virtual void mover(Vector3d eje) //Trasladar sin necesidad del centro
        {
            foreach (var vector in vertices.ToList())
            {
                vertices[vector.Key] = vector.Value + eje;
            }
        }


        public void scalar(double times)
        {
            foreach (var vector in vertices.ToList())
            {
                vertices[vector.Key] = vector.Value * times;
            }
        }
    }
}
