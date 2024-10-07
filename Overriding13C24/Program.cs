namespace Overriding13C24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal thing = new Animal();
            thing.MakeSound();
            Console.WriteLine();
            Dog woofy = new Dog();
            woofy.MakeSound();
            Cat tom = new Cat();
            tom.MakeSound();
        }
    }
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.Write("This animal says: ");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();//calls the method from the base class before any changes are applied
            Console.WriteLine("Woof!");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow.");
        }
    }
}
