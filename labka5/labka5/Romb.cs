using System;
using System.Drawing;

namespace labka5
{
    class Romb : Figure
    {
        private float shorthipotenuse;
        private float longhipotenuse;

        private Random random;
        private Form1 form1;

        public Romb(Form1 form)
        {
            random = new Random();
            this.shorthipotenuse = random.Next(30, 40);
            this.longhipotenuse = shorthipotenuse + 10;
            this.yCenter = 100;
            this.xCenter = Convert.ToInt32(this.longhipotenuse) / 2 + 50;
            this.speed = this.random.Next(5, 15);
            this.form1 = form;
        }

        private Point[] GetCurppints()
        {
            return new Point[] {
                new Point(xCenter - Convert.ToInt32(this.longhipotenuse) / 2,  yCenter),
                new Point(xCenter,  yCenter + Convert.ToInt32(this.shorthipotenuse) / 2),
                new Point(xCenter + Convert.ToInt32(this.longhipotenuse) / 2,  yCenter),
                new Point(xCenter,  yCenter - Convert.ToInt32(this.longhipotenuse) / 2),
            };
        }

        public override void DrawBlack()
        {
            Graphics graph = form1.CreateGraphics();
            graph.DrawPolygon(new Pen(Color.Black), GetCurppints());
        }

        public override void HideDrawingBackGround()
        {
            Graphics graph = form1.CreateGraphics();
            graph.DrawPolygon(new Pen(form1.BackColor), GetCurppints());
        }
    }
}
