using System;
using System.Drawing;

namespace labka5
{
    public class Circle : Figure
    {
        private float radius;

        private Random random;
        private Form1 form1;

        public Circle(Form1 form)
        {
            random = new Random();
            this.radius = this.random.Next(100, 200);
            this.yCenter = 100;
            this.xCenter = Convert.ToInt32(this.radius) + 50;
            this.speed = this.random.Next(5, 15);
            this.form1 = form;
        }

        public override void DrawBlack()
        {
            Graphics graph = form1.CreateGraphics();
            graph.DrawEllipse(Pens.Black, xCenter, yCenter, 2 * this.radius, 2 * this.radius);
        }

        public override void HideDrawingBackGround(  )
        {
            Graphics graph = form1.CreateGraphics();
            graph.DrawEllipse(new Pen(form1.BackColor), xCenter, yCenter, 2 * this.radius, 2 * this.radius);
        }
    }
}
