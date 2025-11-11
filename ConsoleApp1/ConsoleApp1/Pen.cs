namespace Program
{
    public class Pen : Drawer
    {
        public Pen(string color, int length)
        {
            base.color = color;
            base.length = length;
        }

        public void draw()
        {
            base.draw();
        }
    }
}