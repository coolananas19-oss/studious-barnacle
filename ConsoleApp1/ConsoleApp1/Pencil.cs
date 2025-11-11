namespace Program
{
    public class Pencil : Drawer
    {
        private Pen pen42 = new Pen("blue", 6);

        public Pencil(string color, int length)
        {
            base.color = color;
            base.length = length;
        }

        public void draw()
        {
            base.draw();
        }

        public void draw(string color)
        {
            base.draw(color);
        }

        public void draw(string color)
        {
            base.draw(color);
        }
    }
}