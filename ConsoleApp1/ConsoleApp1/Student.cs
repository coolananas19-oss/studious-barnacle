namespace Program
{
    public abstract class Student
    {
        private static string firstName;
        private string lastName;
        private int age;
        public Introduce();
        {
            Console.WriteLine($"привет меня зовут {firstName} {firstName}, мне {age} лет");
        }

        public void setage(int age);
        {
            this.age = age;
        }
        static string name;
        public abstract void setfirstname(string name);
        {
            
            this.firstName = name;
        }

        public void age(int age)
        {
            this.age = age;
        }

        public string lastname(string name)
        {
            this.lastName = name;
        }
    }
}
