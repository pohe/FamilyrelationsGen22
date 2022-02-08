using System;
using System.Collections.Generic;

namespace FamilyrelationsGen
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog d1 = new Dog("Fido 22");

            //Console.WriteLine("Der sker en masse");

            Cat c1 = new Cat("Mio 22", "Red");

            
            Dog d2 = new Dog("Fido 22");



            //if ( d1.Equals(d2))
            //    Console.WriteLine($"D1 og D2 er ens");
            //else
            //{
            //    Console.WriteLine("De er forskellige");
            //}


            List<int> listOfInts = new List<int>();
            listOfInts.Add(12);
            //listOfInts.Add(d1);

            List<Object> listOfObjects = new List<object>();
            listOfObjects.Add(d1);
            listOfObjects.Add(c1);
            //listOfObjects.Add(123);

            //foreach (IHasName item in listOfObjects)
            //{
            //    //Console.WriteLine(item.ToString());
            //    Console.WriteLine( item.Name);
            //}

            //List<Dog> dogs = new List<Dog>();


            Dog myDog = new Dog("Fido");
            Dog fatherDog = new Dog("FatherFido");
            Dog motherDog = new Dog("motherFido");

            //FamilyRelation myFamily = new FamilyRelation(myDog, fatherDog, motherDog);

            Dog childDog1 = new Dog("Fido junior 1");
            Dog childDog2 = new Dog("Fido junior 2");

            //myFamily.AddChild(childDog1);
            //myFamily.AddChild(childDog2);

            //Console.WriteLine(myFamily.ToString());

            FamilyRelationGen<Dog> myGenFamily = new FamilyRelationGen<Dog>(myDog, fatherDog, motherDog);
            myGenFamily.AddChild(childDog1);
            myGenFamily.AddChild(childDog2);
            Console.WriteLine(myGenFamily.ToString());


            FamilyRelationGen<Cat> myGenCatFamily = new FamilyRelationGen<Cat>(new Cat("Mio", "Red"),new Cat("MioFather", "Blue"), new Cat("MioMother", "Yellow"));
            myGenCatFamily.AddChild(new Cat("MioJunior", "Black"));
            Console.WriteLine(myGenCatFamily.ToString());
            Console.Read();
        }
    }
}
