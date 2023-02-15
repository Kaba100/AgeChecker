

using System;
namespace World
{
    class Program
    {
        static void Main(string[]arg)
        {
            Person P = new Person();
            P.CheckAge(60);

        }
    }
    class Person
    {
        public void CheckAge(int age)
        {
            if (age >=0 && age <12)
            {
                Console.WriteLine("You are a child");
            }
            else if(age>=12 && age<20)
            {
                Console.WriteLine("You are a Teenager");
            }
            else if (age>=20 && age <30)
            {
                Console.WriteLine("You are a Young Person");
            }
            else if(age>=30 && age<50)
            {
                Console.WriteLine("You are an Adult");
            }
            else if (age >=50)
            {
                Console.WriteLine("You are an Old Person");
            }
        }
    
    }

}
