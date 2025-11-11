namespace Program
{
    public class Petrov : Tudent
    {
        public int Age
        {
            get { return this.age;}
            set { this.age = value; }
        }

        public override void draw(IDrawer drawer)
        {
            Console.WriteLine(drawer.draw());
        }

        public override walk()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Walking...");
            }
        }
    }
}

