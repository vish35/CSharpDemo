using System;


namespace HeyWorld
{
    interface IPerson
    {
        void displayinfo();
        void acceptinfo(string name, int id, string city);
    }
   public  abstract class Person
    {
        public string name;
        public int id;
        public string city;
        abstract public void displayinfo();

        public void acceptinfo(string name, int id, string city)
        {
            this.name = name;
            this.id = id;
            this.city = city;
        }
    }
    public class Buyer : Person
    {
        public Buyer()
        {
            Console.WriteLine("Buyer constructor");
        }
        public override void displayinfo()
        {
            Console.WriteLine("Inside Buyer class " + name + " " + id + " " + city);
        }

    }
    public class Customer : Buyer
    {
        public Customer()
        {
            Console.WriteLine("customer constructor");
        }
        public new void displayinfo()
        {
            Console.WriteLine("using new keyword");
            Console.WriteLine("Inside customer class " + name + " " + id + " " + city);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Customer customer = new Customer();
            customer.acceptinfo("vishakha", 1, "satara");
            customer.displayinfo();

            Buyer buyer = new Buyer();
            buyer.acceptinfo("Buyer1", 2, "pune");
            buyer.displayinfo();*/
            IteratorDemo iter = new IteratorDemo();
           foreach(string s in iter)
            {
                Console.WriteLine(s);
            }

        }
    }
}
