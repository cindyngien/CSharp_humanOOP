using System;

namespace ConsoleApplication
{
    public class Human
    {
        public int Strength = 3;
        public int Intelligence = 3;
        public int Dexterity = 3;
        public int Health = 100;
        public string Name;
        public Human(string val)
        {
            Name = val;

        }
        public Human(int Str, int Dex, int Int, int HP, string Alias)
        {
            Strength = Str;
            Intelligence = Int;
            Dexterity = Dex;
            Health = HP;
            Name = Alias;
        }
       public void Attack(Human user)
       {
           Console.WriteLine(Name + " Is Attacking " + user.Name + "!");
           user.Health -= Strength * 5;
           Console.WriteLine(user.Name + " receives " + Strength * 5 + " pts of damage and has " + user.Health + "hp left");
           
       }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Human Cindy = new Human("Cindy");
            Human Wendy = new Human("Wendy");
            Console.WriteLine($"My new human is {Cindy.Name}");
            Cindy.Attack(Wendy);
        
        }
    }
}

