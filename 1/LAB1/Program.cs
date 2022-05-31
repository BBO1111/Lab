using System;
using Newtonsoft.Json;
using System.Text.Json;


namespace OOP_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Перша множина: ");
            Console.ResetColor();
            Random r = new Random();
            Variety A = new Variety(6, 8, 2, 3);
            A.AddElement(5);
            A.RemoveElement(6);
           
            A.PrintVariety();
      
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Друга множина: ");
            Console.ResetColor();
            Variety B = new Variety(3, 6, 2, 1);
            B.PrintVariety();
            Console.WriteLine();
            B.EqualsVariety(A);
            
            Console.Write("Перетин множин: ");
           
            B.ElementsIntersection(A);
           
            Console.Write("\nОб'єднання множин: ");
            
            B.ElementsUnion(A);
           
            Console.Write("\nНалежнicть множинi B: ");
            
            B.isElementOfVariety(r.Next(1, 9));
           
            Console.Write("\nРiзниця мнижин: ");
           
            B.VarietyDifference(A);
         
            Console.Write("\nСiметрична рiзниця мнижин: ");
            
            B.VarietySimDifference(A);

            B.FileToJson();
          
            B.FileFromJson(); 
            Console.WriteLine();

            
           
           
        }
        
    }
}
