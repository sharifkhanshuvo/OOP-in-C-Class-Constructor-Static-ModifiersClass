using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Csharp2
{
    class Animal
    {
        public string name;
        public int age;
        public string colur;
        public static int animalcount = 0;
      public  void Details()

        {
            Console.WriteLine("Name" +" " +name +"Age" + " " +age + "colur" + " " + colur);
        }
        public Animal(string _name, int _age, string _colur)// Consrtouctor
        {
            name = _name;
            age = _age;
            colur = _colur;
            animalcount++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Animal dog = new Animal("Audi",3,"red");
            Animal cow = new Animal("Mohish", 4, "Black");
            Animal cat = new Animal("Mohish", 4, "white");
            cat.Details();
            cow.Details();
            dog.Details();
            Console.WriteLine("number of animal :" +Animal.animalcount);
          
            //** array**//
          //  int[] numbers = new int[] { 20, 23, 56, 75 };
            //int myAge = age(2021,1995);
            //if(myAge>18)
            // Console.WriteLine("Adult");
           // Console.WriteLine(numbers[3]);
            //list
           // List<string> names = new List<string>();
           // names.Add("Mr");
           // names.Add("Sharif");
           // names.Add("khan");
           // for(int i=0; i<names.Count; i++)
            //{
              //  Console.WriteLine(names[i]);
            //}
           // else
              //  Console.WriteLine("NOt Adult");
        }
        /*public static int age (int Currentyear,int Dateofyear)
        {
            return Currentyear - Dateofyear;
        }*/
    }
}
