namespace PetController.Models
{
    public class Dog : Animal
    {
        public Dog(string name, byte age, string owner, string sound) : base(name, age, owner) 
        {
            Sound = sound;
        }

        public override string ToString()
        {
            return $"The Dog named {this.Name} is {this.Age} year-old, The owner is {Owner} and it makes sound: {Sound}";
        }
    }
}
