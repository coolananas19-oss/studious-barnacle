namespace Program
{
    public class Drawer
    {
        protected string color;
        protected int length;

        public void draw()
        {
            Console.WriteLine("Drawing drawer");
        }

        public void draw(string color)
        {
            Console.WriteLine("Drawing drawer" + color);
        }
    }
}

