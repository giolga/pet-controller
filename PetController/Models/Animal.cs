namespace PetController.Models
{
    public class Animal
    {
        public string Name { get; set; } = "No Name";
        public byte Age { get; set; } = 0;
        public string Owner { get; set; } = "No Owner";
        public string Sound { get; set; } = "No Sound";

        public Animal(string name, byte age, string owner)
        {
            Name = name;
            Owner = owner;
            Age = age;
        }
    }
}
