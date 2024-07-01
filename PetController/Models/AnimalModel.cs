namespace PetController.Models
{
    public class AnimalModel : Animal
    {
        public AnimalModel(string name = "No Name", byte age = 0, string owner = "No Name") : base(name, age, owner)
        {
        }

        public string ImageTitle { get; set; }

        List<Animal> animal = new List<Animal>() { 
            new Dog("Max", 1, "John", "wuf"),
            new Dog("Rick", 3, "Linda", "wooooooooof"),
            new Dog("Kelly", 3, "Marty", "wuwuwuuwuwuf"),
            new Dog("Ledy", 4, "Tony", "huf huf"),
            new Dog("Charlie", 1, "Charles", "wuf"),
            new Dog("Buch", 5, "Michael", "wawwawawawawwafff"),
            new Dog("Richie", 7, "Nathanel", "wof wooooofwoof"),
            new Dog("Lucy", 3, "Dana", "wofwofowof"),
            new Dog("Dwight", 9, "Cody", "wowowowof"),

            new Cat("Luna", 2, "Michael", "meow"),
            new Cat("Milo", 3, "Michael", "meow"),
            new Cat("Oliver", 5, "Michael", "meow"),
            new Cat("Leo", 6, "Michael", "meow"),
            new Cat("Bella", 2, "Michael", "meow"),
            new Cat("Lilly", 6, "Michael", "meow"),
            new Cat("Kitty", 9, "Michael", "meow"),
        };

    }
}
