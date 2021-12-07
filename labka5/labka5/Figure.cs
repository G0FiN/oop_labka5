namespace labka5
{
    abstract public class  Figure
    {
        internal int xCenter;
        internal int yCenter;
        internal int speed;
        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight()
        {
            for (int i = 0; i < 50; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(100);
                HideDrawingBackGround();
                xCenter += speed;
            }
        }
    }
}
