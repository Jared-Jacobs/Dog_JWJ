using System;

namespace Dog_JWJ
{
    class DogRun
    {

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.setName("Rex");
            dog.setAge(7);

            Console.WriteLine("The dogs name is " + dog.getName());
            Console.WriteLine(dog.getName() + " is " + dog.getAge() + " human years old.");
            Console.WriteLine(dog.getName() + " is " + dog.getDogYears() + " dog years old.");
            Console.WriteLine("The Dogs information: " + dog.ToString());

        }
    }
}


