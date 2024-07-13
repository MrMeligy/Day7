namespace ConsoleApp1
{
    class Student (int id, int age, string name)
    {
        static Student()
        {
            Console.WriteLine($"Hello first instance");
        }
        public void Getdata()
        {
            Console.WriteLine($"Id:{id} - Age:{age} - Name:{name}");
        }
        public string isretired()
        {
            if ( age >= 24 ) {
                return "Graduated";
            }
            return "UnGraduated";
        }
    }
    public class Book
    {
        // Properties
        int id;
        string name;
        string type;
        DateTime createdOn;
        bool isDeleted;
        string price;
        static int count = 0;

        public Book() { }

        public Book(int id, string name, string type, string price,DateTime CreatedOn, bool isDeleted)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.price = price;
            this.createdOn = CreatedOn;
            this.isDeleted = isDeleted;
            count++;
        }
        static Book()
        {
            Console.WriteLine("Welcome");
        }
        
        // Method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Created On: {createdOn}");
            Console.WriteLine($"Is Deleted: {isDeleted}");
            Console.WriteLine($"Price: {price}");
        }
        public void howmanybook()
        {
            Console.WriteLine($"{count} Books");
        }
        public bool isdeleted()
        {
            return isDeleted;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1,24,"Meligy");
            Student s2 = new Student(2,21,"Youssef");
   
            s1.Getdata();
            s2.Getdata();

            Console.WriteLine($"s1:{s1.isretired()}");
            Console.WriteLine($"s2:{s2.isretired()}");

            Book b1= new Book(1,"Twisted Love","dark","1500",DateTime.Now,false);
            b1.DisplayInfo();
            Book b2 = new Book(1, "Twisted Lie", "dark", "1500", DateTime.Now, true);
            b2.DisplayInfo();
            b2.howmanybook();

        }
    }
}
