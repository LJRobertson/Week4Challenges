using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFourChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //In your Main method, new up an instance of each class that inherits from the parent class you set up. Make sure to set all appropriate properties.

            var hikingBoots = new Boots("hiking", 10, "brown", false);
            var dressHeels = new Heels("stilletto", 5, 7, "red", true);
        }
    }


    //Create an Abstract Class. Theme can be of your choosing, just make sure it's something we haven't seen. //Give this class at least three properties and 1 virtual or abstract method.
    abstract class Shoe
    {
        public int Size { get; set; }
        public string Color { get; set; }
        public bool HasHeel { get; set; }

        public Shoe(int size, string color, bool hasHeel)
        {
            Size = size;
            Color = color;
            HasHeel = hasHeel;
        }
    }
        //Declare at least two classes that inherit from your abstract class. Make sure you implement all the required members that need to be implemented.
        class Boots : Shoe
        {
            public string BootType { get; set; }

            public Boots (string bootType, int size, string color, bool hasHeel)
                : base(size, color, hasHeel)
            {
                BootType = bootType;
            }
        }

        class Heels : Shoe
        {
            public string HeelType { get; set; }
            public int HeelHeight { get; set; }

            public Heels (string heelType, int heelHeight, int size, string color, bool hasHeel)
                : base (size, color, hasHeel)
            {
                HeelType = heelType;
                HeelHeight = heelHeight;
            }

        }
    }

   

   

    
