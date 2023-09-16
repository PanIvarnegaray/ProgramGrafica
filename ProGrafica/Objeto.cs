using Newtonsoft.Json;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramGrafica
{
    internal class Objeto
    {
        [JsonProperty("poligonos")]
        private Dictionary<string, Poligono> poligonos { get; set; } //Poligonos de un objeto
        [JsonProperty("centro")]
        private Vector3d centro;  //Centro de masa del objeto
        [JsonProperty("width")]
        private double width { get; set; }//x 
        [JsonProperty("height")]
        private double height { get; set; }  //y
        [JsonProperty("length")]
        private double length { get; set; }//z

        public Objeto()
        {
            this.poligonos = new Dictionary<string, Poligono>();
            this.centro = new Vector3d();
            this.height = 100;
            this.length = 100;
            this.width = 100;
        } //Constructor vacio

        public Objeto(double centroX, double centroY, double centroZ)
        {
            this.poligonos= new Dictionary<string, Poligono>();
            this.centro = new Vector3d(centroX, centroY, centroZ);
            this.height = 100;
            this.length = 100;
            this.width = 100;
        } //Constructor con solo el centro de masa

        public Objeto(Dictionary<string, Poligono> poligonos, Vector3d centro, double width, double height, double length)
        {
            this.poligonos = poligonos;
            this.centro = centro;
            this.width = width;
            this.height = height;
            this.length = length;
        } //Constructor con todos los parametros

        public Objeto(Objeto Objeto) //Constructor Clonado
        {
            this.poligonos= Objeto.poligonos;
            this.centro = Objeto.centro;
            this.height = Objeto.height;
            this.length = Objeto.length;
            this.width = Objeto.width;
        }

        [JsonProperty("CentroX")]
        public double CentroX //Getter/Setter of the the center in X axis
        {
            get { return this.centro.X; } //Retorna el valor de X del centro

            set { this.centro.X = value; } //Setea el valor de X del centro
        }

        [JsonProperty("CentroY")]
        public double CentroY //Getter/Setter of the the center in Y axis
        {
            get { return this.centro.Y; } //Retorna el valor de Y del centro

            set { this.centro.Y = value; } //Setea el valor de Y del centro
        }

        [JsonProperty("CentroZ")]
        public double CenterZ //Getter/Setter of the the center in Z axis
        {
            get { return this.centro.Z; } //Retorna el valor de Z del centro

            set { this.centro.Z = value; } //Setea el valor de Z del centro
        }
        public void addPoligono(string descripcion, Poligono poligono)
        {
            this.poligonos.Add(descripcion, poligono); //añadir poligono a la lista de poligonos
        }
        public void dibujar()  //Dibujar objeto
        {
            if (this.poligonos.Count != 0) //Verifica si la lista caras NO está vacía
            {
                foreach (var poligono in this.poligonos) //para cada poligono en la lista de poligonos
                {
                    poligono.Value.dibujar(centro);  //Dibujarla
                }
            }
        }
        public void rotar(Vector3d eje, double theta)
        {
            foreach (var poligono in poligonos)
            {
                poligono.Value.rotar(eje, theta);
            }
        }
        public void mover(Vector3d eje)
        {
            centro = centro + eje;
        }
        public void scalar(double scala)
        {
            foreach (var poligono in poligonos)
            {
                poligono.Value.scalar(scala);
            }
        }
    }
}

