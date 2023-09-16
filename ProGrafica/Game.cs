using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using OpenTK.Input;
using System.Threading;

namespace ProgramGrafica
{
    class Game:GameWindow
    {
        private double theta=0;

        Coche auto = new Coche(1.5, 1.2, 0.0); //Se introduce el punto centro del objeto
        Estante estante = new Estante(1.5, 1.2, 0.0);
        Muro muro = new Muro(1.5, 1.2, 0.0);
        Ejes ejes = new Ejes();


        public Game(int widht, int height, string title):base(widht, height, GraphicsMode.Default, title)
        {
            KeyDown += (sender, e) =>
            {
                if (e.Key == Key.Left)
                {
                    theta++;
                } else if (e.Key == Key.Right)
                {
                    theta--;
                }
            };
        }
        
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            GL.Enable(EnableCap.DepthTest);

            muro.crear();
            estante.crear();
            auto.crear();

            base.OnLoad(e);

        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {

            base.OnUpdateFrame(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Rotate(10.0, 10.0, 0.0, 0.0);
            GL.Rotate(theta, 0.0, 1.0, 0.0);
            //-----------------------------ESCENARIO-------------------------------
            muro.dibujar();
            estante.dibujar();
            auto.dibujar();

            //-----------------------------ESCENARIO-------------------------------  
            ejes.dibujar();
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        protected override void OnResize(EventArgs e)
        {
            double escala = 5.0;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-escala, escala, -escala, escala, -escala, escala);
            GL.MatrixMode(MatrixMode.Modelview);

            base.OnResize(e);
        }
    }
}
