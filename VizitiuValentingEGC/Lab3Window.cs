/*
 * Vizitiu Valentin Iulian
 * Grupa 3133A - Calculatoare
 */

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

using System;
using System.Drawing;

namespace VizitiuValentingEGC
{
    public class Lab3Window : GameWindow
    {
        // lab 3, ex 8
        private Vector3 color = Vector3.Zero;
        private float cameraXOffset = 0f;
        private float cameraYOffset = 0f;

        // lab 2, ex 2
        private float xOffset = 0f;
        private float yOffset = 0f;

        public Lab3Window() : base(800, 600)
        {
            VSync = VSyncMode.On;
            KeyDown += OnKeyboardPressed;
            MouseMove += OnMouseMove;
        }

        private void OnKeyboardPressed(object sender, KeyboardKeyEventArgs e)
        {
            switch (e.Key)
            {
                // lab 3, ex 8
                case Key.Space:
                    color.X += 0.01f;
                    color.Y += 0.01f;
                    color.Z += 0.01f;
                    Console.WriteLine(color);
                    break;

                // lab 2, ex 2 
                case Key.D:
                    xOffset += 0.05f;
                    break;
                case Key.A:
                    xOffset -= 0.05f;
                    break;
                case Key.W:
                    yOffset -= 0.05f;
                    break;
                case Key.S:
                    yOffset += 0.05f;
                    break;
            }
        }

        private void OnMouseMove(object sender, MouseMoveEventArgs e)
        {
            cameraXOffset = e.X - Width / 2;
            cameraYOffset = e.Y - Height / 2;

            cameraXOffset /= 10;
            cameraYOffset /= 10;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Console.WriteLine(@"
WASD - Move object around
Space - Hold to change color of the object
Move mouse - Rotate camera
");
            GL.ClearColor(Color.Gray);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            double aspect_ratio = Width / (double)Height;

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {

        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 lookat = Matrix4.LookAt(15 + cameraXOffset, 50, 15 + cameraYOffset, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            GL.Begin(PrimitiveType.Triangles);

            // lab 3, ex 8
            GL.Color3(color);
            GL.Vertex3(-10.0f + xOffset, -10.0f + yOffset, -10.0f);
            GL.Vertex3(-10.0f + xOffset, -10.0f + yOffset, 10.0f);
            GL.Vertex3(-10.0f + xOffset, 10.0f + yOffset, 10.0f);

            GL.End();

            SwapBuffers();
        }
    }
}
