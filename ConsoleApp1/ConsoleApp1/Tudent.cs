namespace Program
{
    public abstract class Tudent : IStudent, IHuman
    {
        protected int age;
        abstract public void draw(IDrawer drawer);
        abstract public void walk();
    }
}

