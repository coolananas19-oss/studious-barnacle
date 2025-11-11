namespace Program
{
    public class Program
    {
        private Pen pen32 = new Pen("red", 6);
        public static void Main(string[] args)
        {
            Pencil penc1 = new Pencil("red",7);
            penc1.draw();
            penc1.draw("red");
            Pen pen = new Pencil("red", 8);
            pen.draw();
            Student std = new Student();
            std.setlastname("Last Name");
            std.setfirstname("First Name");
            std.setage(18);
            std.Introduce();
        }
    }
}
