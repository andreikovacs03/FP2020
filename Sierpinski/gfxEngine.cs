using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sierpinski
{
    #region Initialization
    static partial class gfxEngine
    {
        internal static PictureBox canvas;
        internal static Bitmap bmp;
        internal static Graphics gfx;

        internal static Pen pen = new Pen(Color.Black, 5);

        static Random rnd = new Random();

        internal static Color BG_COLOR = Color.FloralWhite;
        internal static void Initialize(PictureBox cvs)
        {
            canvas = cvs;
            bmp = new Bitmap(canvas.Size.Width, canvas.Size.Height);
            gfx = Graphics.FromImage(bmp);

            clearCanvas();
            drawCanvas();
        }

        internal static void drawCanvas()
        {
            canvas.Image = bmp;
        }
        internal static void clearCanvas()
        {
            gfx.Clear(BG_COLOR);
        }
    }
    #endregion

    #region Utility functions
    static partial class gfxEngine
    {
        #region Point Manipulation

        static Color rndColor()
        {
            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }
        static PointF midPoint(PointF A, PointF B)
        {
            return new PointF((A.X + B.X) / 2f, (A.Y + B.Y) / 2f);
        }

        static PointF weightPoint(PointF A, int wA, PointF B, int wB)
        {
            return new PointF((A.X * wA + B.X * wB) / (wA + wB), (A.Y * wA + B.Y * wB) / (wA + wB));
        }
        static PointF randomPointF()
        {
            return new PointF(rnd.Next(canvas.Width), rnd.Next(canvas.Height));
        }
        #endregion

        #region Draw Functions
        internal static void drawTriangle(PointF A, PointF B, PointF C)
        {
            gfx.DrawPolygon(pen, new PointF[] { A, B, C });
        }
        internal static void drawTriangle_RandomColor(PointF A, PointF B, PointF C)
        {
            Pen oldPen = pen;
            pen.Color = rndColor();

            drawTriangle(A, B, C);

            pen = oldPen;
        }

        internal static void drawCarpet(PointF A, PointF B, PointF C, PointF D, Color currentColor)
        {
            gfx.FillPolygon(new SolidBrush(currentColor), new PointF[] { weightPoint(A, 2, C, 1), weightPoint(B, 2, D, 1), weightPoint(A, 1, C, 2), weightPoint(B, 1, D, 2) });
            gfx.DrawPolygon(new Pen(Color.Black), new PointF[] { A, B, C, D });
        }
        internal static void drawCarpet_Random(PointF A, PointF B, PointF C, PointF D)
        {
            gfx.FillPolygon(new SolidBrush(rndColor()), new PointF[] { weightPoint(A, 2, C, 1), weightPoint(B, 2, D, 1), weightPoint(A, 1, C, 2), weightPoint(B, 1, D, 2) });
            gfx.DrawPolygon(new Pen(Color.Black), new PointF[] { A, B, C, D });
        }
        #endregion
    }
    #endregion

    #region Sierpinski
    static partial class gfxEngine
    {
        #region Sierpinski Triangle
        static void SierpinskiTriangle(int limit, PointF A, PointF B, PointF C)
        {
            if (limit > 0)
            {
                //SierpinskiTriangle(limit - 1, midPoint(A, B), midPoint(B,C), midPoint(C, A));
                SierpinskiTriangle(limit - 1, A, midPoint(A, B), midPoint(A, C));
                SierpinskiTriangle(limit - 1, B, midPoint(B, A), midPoint(B, C));
                SierpinskiTriangle(limit - 1, C, midPoint(C, A), midPoint(C, B));
            }
            else
                drawTriangle_RandomColor(A, B, C);
        }

        internal static void drawSierpinskiTriangle(int limit)
        {
            PointF A = new Point(canvas.Width / 2, 0);
            PointF B = new Point(0, canvas.Height);
            PointF C = new Point(canvas.Width, canvas.Height);

            SierpinskiTriangle(limit, A, B, C);
        }

        internal static void drawSierpinskiTriangle_Random(int limit)
        {
            PointF A = randomPointF();
            PointF B = randomPointF();
            PointF C = randomPointF();

            SierpinskiTriangle(limit, A, B, C);
        }
        #endregion

        #region Sierpinski Carpet
        static void SierpinskiCarpet_RandomColor(int limit, PointF A, PointF B, PointF C, PointF D, Color currentColor)
        {
            drawCarpet(A, B, C, D, currentColor);
            currentColor = rndColor();

            if (limit != 0)
            {
                SierpinskiCarpet_RandomColor(limit - 1, A, weightPoint(A, 2, B, 1), weightPoint(A, 2, C, 1), weightPoint(A, 2, D, 1), currentColor);
                SierpinskiCarpet_RandomColor(limit - 1, weightPoint(A, 1, B, 2), B, weightPoint(B, 2, C, 1), weightPoint(B, 2, D, 1), currentColor);
                SierpinskiCarpet_RandomColor(limit - 1, weightPoint(A, 1, C, 2), weightPoint(B, 1, C, 2), C, weightPoint(C, 2, D, 1), currentColor);
                SierpinskiCarpet_RandomColor(limit - 1, weightPoint(A, 1, D, 2), weightPoint(B, 1, D, 2), weightPoint(C, 1, D, 2), D, currentColor);

                SierpinskiCarpet_RandomColor(limit - 1, weightPoint(A, 2, B, 1), weightPoint(A, 1, B, 2), weightPoint(B, 2, D, 1), weightPoint(A, 2, C, 1), currentColor);
                SierpinskiCarpet_RandomColor(limit - 1, weightPoint(B, 2, D, 1), weightPoint(B, 2, C, 1), weightPoint(B, 1, C, 2), weightPoint(A, 1, C, 2), currentColor);
                SierpinskiCarpet_RandomColor(limit - 1, weightPoint(B, 1, D, 2), weightPoint(A, 1, C, 2), weightPoint(C, 2, D, 1), weightPoint(C, 1, D, 2), currentColor);
                SierpinskiCarpet_RandomColor(limit - 1, weightPoint(A, 2, D, 1), weightPoint(A, 2, C, 1), weightPoint(B, 1, D, 2), weightPoint(A, 1, D, 2), currentColor);
            }
        }
        static void SierpinskiCarpet(int limit, PointF A, PointF B, PointF C, PointF D)
        {
            drawCarpet(A, B, C, D, Color.White);

            if (limit != 0)
            {
                SierpinskiCarpet(limit - 1, A, weightPoint(A, 2, B, 1), weightPoint(A, 2, C, 1), weightPoint(A, 2, D, 1));
                SierpinskiCarpet(limit - 1, weightPoint(A, 1, B, 2), B, weightPoint(B, 2, C, 1), weightPoint(B, 2, D, 1));
                SierpinskiCarpet(limit - 1, weightPoint(A, 1, C, 2), weightPoint(B, 1, C, 2), C, weightPoint(C, 2, D, 1));
                SierpinskiCarpet(limit - 1, weightPoint(A, 1, D, 2), weightPoint(B, 1, D, 2), weightPoint(C, 1, D, 2), D);

                SierpinskiCarpet(limit - 1, weightPoint(A, 2, B, 1), weightPoint(A, 1, B, 2), weightPoint(B, 2, D, 1), weightPoint(A, 2, C, 1));
                SierpinskiCarpet(limit - 1, weightPoint(B, 2, D, 1), weightPoint(B, 2, C, 1), weightPoint(B, 1, C, 2), weightPoint(A, 1, C, 2));
                SierpinskiCarpet(limit - 1, weightPoint(B, 1, D, 2), weightPoint(A, 1, C, 2), weightPoint(C, 2, D, 1), weightPoint(C, 1, D, 2));
                SierpinskiCarpet(limit - 1, weightPoint(A, 2, D, 1), weightPoint(A, 2, C, 1), weightPoint(B, 1, D, 2), weightPoint(A, 1, D, 2));
            }
        }
        internal static void drawSierpinskiCarpet(int limit)
        {
            PointF A = new Point(0, 0);
            PointF B = new Point(canvas.Width, 0);
            PointF C = new Point(canvas.Width, canvas.Height);
            PointF D = new Point(0, canvas.Height);

            BG_COLOR = Color.White;
            drawCanvas();
            clearCanvas();

            SierpinskiCarpet(limit, A, B, C, D);
        }
        internal static void drawSierpinskiCarpet_RandomPolygon(int limit)
        {
            PointF A = randomPointF();
            PointF B = randomPointF();
            PointF C = randomPointF();
            PointF D = randomPointF();

            BG_COLOR = Color.White;
            drawCanvas();
            clearCanvas();

            SierpinskiCarpet(limit, A, B, C, D);
        }
        internal static void drawSierpinskiCarpet_Random3d(int limit)
        {
            PointF A = randomPointF();
            PointF B = randomPointF();
            PointF C = randomPointF();
            PointF D = new PointF(A.X + C.X - B.X, A.Y + C.Y - B.Y);

            BG_COLOR = Color.White;
            drawCanvas();
            clearCanvas();

            SierpinskiCarpet(limit, A, B, C, D);
        }
    }
    #endregion

    #endregion

    #region Polygon Fractals
    static partial class gfxEngine
    {
        static void PolyFractal_RandomColor(int limit, PointF[] points)
        {
            gfx.FillPolygon(new SolidBrush(rndColor()), points);

            if (limit > 0)
            {
                PointF[] newPoints = new PointF[points.Length];

                for (int i = 0; i < newPoints.Length - 1; i++)
                    newPoints[i] = weightPoint(points[i], 2, points[i + 1], 1);
                newPoints[newPoints.Length - 1] = weightPoint(points[0], 2, points[points.Length - 1], 1);

                PolyFractal_RandomColor(limit - 1, newPoints);
            }
        }
        static void PolyFractal(int limit, PointF[] points, Color currentColor, Color colorAdder)
        {
            gfx.FillPolygon(new SolidBrush(currentColor), points);
            gfx.DrawPolygon(new Pen(Color.Black), points);

            if (limit > 0)
            {
                PointF[] newPoints = new PointF[points.Length];

                for (int i = 0; i < newPoints.Length - 1; i++)
                    newPoints[i] = weightPoint(points[i], 2, points[i + 1], 1);
                newPoints[newPoints.Length - 1] = weightPoint(points[points.Length - 1], 2, points[0], 1);

                PolyFractal(limit - 1, newPoints, Color.FromArgb(currentColor.R + colorAdder.R, currentColor.G + colorAdder.G, currentColor.B + colorAdder.B), colorAdder);
            }
            else
            {
                gfx.FillPolygon(new SolidBrush(Color.IndianRed), points);
                gfx.DrawPolygon(new Pen(Color.Black), points);
            }
        }
        internal static void drawPolyFractal(int limit, int sides = 6)
        {
            PointF[] points = new PointF[sides];

            for (int i = 0; i < points.Length; i++)
                points[i] = randomPointF();

            Color currentColor = Color.FromArgb(80, 80, 80);
            Color colorAdder = Color.FromArgb((255 - currentColor.R) / limit, (255 - currentColor.G) / limit, (255 - currentColor.B) / limit);

            PolyFractal(limit, points, currentColor, colorAdder);
        }

        internal static void drawPolyFractal_Fixed(int limit, int sides = 6)
        {
            PointF[] points = new PointF[sides];

            PointF center = new PointF(canvas.Width / 2, canvas.Height / 2);
            float radius = canvas.Width < canvas.Height ? canvas.Width / 2 : canvas.Height / 2;
            double theta = 0;

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new PointF(center.X + radius * (float)Math.Cos(theta), center.Y + radius * (float)Math.Sin(theta));
                theta += 2 * Math.PI / sides;
            }

            Color currentColor = Color.FromArgb(80, 80, 80);
            Color colorAdder = Color.FromArgb((255 - currentColor.R) / limit, (255 - currentColor.G) / limit, (255 - currentColor.B) / limit);

            PolyFractal(limit, points, currentColor, colorAdder);
        }

    }
    #endregion
}
