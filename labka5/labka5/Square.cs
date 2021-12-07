using System;
using System.Drawing;

namespace labka5
{
    class Square : Figure
    {
        private float side;

        private Random random;
        private Form1 form1;

        public Square(Form1 form)
        {
            random = new Random();
            this.side = this.random.Next(100, 200);
            this.yCenter = 100;
            this.xCenter = Convert.ToInt32(this.side) / 2 + 50;
            this.speed = this.random.Next(5, 15);
            this.form1 = form;
        }

        private Point[] GetCurppints()
        {
            return new Point[] {
                new Point(xCenter - Convert.ToInt32(this.side),  yCenter - Convert.ToInt32(this.side)),
                new Point(xCenter - Convert.ToInt32(this.side),  yCenter + Convert.ToInt32(this.side)),
                new Point(xCenter + Convert.ToInt32(this.side),  yCenter + Convert.ToInt32(this.side)),
                new Point(xCenter + Convert.ToInt32(this.side),  yCenter - Convert.ToInt32(this.side)),
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
