namespace _8_OOP_Allgemein
{
   // 1. Basisklasse
    class Animal
    {
        // Eigenschaften (Properties)
        public string Name { get; set; }
        public int Age { get; set; }

        // Konstruktor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Methode
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} macht ein Geräusch.");
        }

        // Überschreiben der ToString-Methode
        public override string ToString()
        {
            return $"[Name: {Name}, Alter: {Age}]";
        }
    }

    // 2. Abgeleitete Klasse (Vererbung)
    class Dog : Animal
    {
        // Zusätzliche Eigenschaft
        public string Breed { get; set; }

        // Konstruktor
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        // Überschreiben der Speak-Methode
        public override void Speak()
        {
            Console.WriteLine($"{Name} bellt: Wuff Wuff!");
        }

        // Methode für zusätzliche Funktionalität
        public void Fetch()
        {
            Console.WriteLine($"{Name} bringt den Ball zurück!");
        }
    }

    // 3. Hauptprogramm
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen eines Animal-Objekts
            Animal genericAnimal = new Animal("Tier", 3);
            Console.WriteLine("1. Ein generisches Tier:");
            Console.WriteLine(genericAnimal);
            genericAnimal.Speak();

            // Erstellen eines Dog-Objekts
            Dog buddy = new Dog("Buddy", 5, "Golden Retriever");
            Console.WriteLine("\n2. Ein spezieller Hund:");
            Console.WriteLine(buddy);
            buddy.Speak();

            // Zusätzliche Funktionalität der abgeleiteten Klasse
            Console.WriteLine("\n3. Buddy führt einen Trick aus:");
            buddy.Fetch();

            // Polymorphismus (Animal-Referenz auf Dog-Objekt)
            Animal polymorphicDog = new Dog("Max", 2, "Beagle");
            Console.WriteLine("\n4. Polymorphismus in Aktion:");
            polymorphicDog.Speak(); // Ruft die Überschreibung in der Dog-Klasse auf
        }
    }
}


