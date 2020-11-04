using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            OvernightPackage overnightPackage = new OvernightPackage("Benue", "Lagos", 3500M);
            TwoDaysPackage twoDaysPackage = new TwoDaysPackage("Ibadan", "Akure", 4560M);
            

            Console.WriteLine("\n Packages processed polymorphically...\n");
            Package[] packages = new Package[2] { overnightPackage, twoDaysPackage};
            // Package[] packages = new Package[2] { overnightPackage, twoDaysPackage }

            foreach (Package package in packages)
            {
                Console.WriteLine($"{package}");
            }
        }
        
    } 
} 

            
        
            





