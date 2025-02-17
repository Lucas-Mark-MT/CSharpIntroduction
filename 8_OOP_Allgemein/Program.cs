namespace _8_OOP_Allgemein
{
    // 1. Base class
    class Animal
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a noise.");
        }

        // Overriding the ToString method
        public override string ToString()
        {
            return $"[Name: {Name}, Age: {Age}]";
        }
    }

    // 2. Derived class (Inheritance)
    class Dog : Animal
    {
        // Additional property
        public string Breed { get; set; }

        // Constructor
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        // Overriding the Speak method
        public override void Speak()
        {
            Console.WriteLine($"{Name} barks: Woof Woof!");
        }

        // Method for additional functionality
        public void Fetch()
        {
            Console.WriteLine($"{Name} brings the ball back!");
        }
    }

    // 3. Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an Animal object
            Animal genericAnimal = new Animal("Animal", 3);
            Console.WriteLine("1. A generic animal:");
            Console.WriteLine(genericAnimal);
            genericAnimal.Speak();

            // Creating a Dog object
            Dog buddy = new Dog("Buddy", 5, "Golden Retriever");
            Console.WriteLine("\n2. A specific dog:");
            Console.WriteLine(buddy);
            buddy.Speak();

            // Additional functionality of the derived class
            Console.WriteLine("\n3. Buddy performs a trick:");
            buddy.Fetch();

            // Polymorphism (Animal reference to a Dog object)
            Animal polymorphicDog = new Dog("Max", 2, "Beagle");
            Console.WriteLine("\n4. Polymorphism in action:");
            polymorphicDog.Speak(); // Calls the overridden method in the Dog class
        }
    }
}
