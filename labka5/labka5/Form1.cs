using System;
using System.Windows.Forms;

namespace labka5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            button1.Text = "Circle";
            button2.Text = "Square";
            button3.Text = "Romb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(this);
            circle.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Square square = new Square(this);
            square.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb(this);
            romb.MoveRight();
        }
    }
}
