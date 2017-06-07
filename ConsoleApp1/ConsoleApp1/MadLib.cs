using System;

namespace Game

{
   static class MadLib
   {
     public static void Run()
      {
         // Declare variables
         string Creature;
         string Luminous;
         string Ghastly;
         string Spectral;
         string Countryman;
         string Farrier;
         string Farmer;
         string Dreadful;
         string Apparition;
         string Hound;
         string Story;

         // Get input for variables
         Console.WriteLine("__________________");
         Console.Write("Please provide a creature type: ");
         Creature = Console.ReadLine();
         Console.WriteLine("");
         Console.Write("Please provide an adjective: ");
         Luminous = Console.ReadLine();
         Console.WriteLine("");
         Console.Write("Please provide an adjective: ");
         Ghastly = Console.ReadLine();
         Console.WriteLine("");
         Console.Write("Please provide an adjective: ");
         Spectral = Console.ReadLine();
         Console.WriteLine("");
         Console.Write("Please provide a person: ");
         Countryman = Console.ReadLine();
         Console.WriteLine("");
         Console.Write("Please provide a profession: ");
         Farrier = Console.ReadLine();
         Console.WriteLine("");
         Console.Write("Please provide a profession: ");
         Farmer = Console.ReadLine();
         Console.WriteLine("");
         Console.Write("Please provide an adjective: ");
         Dreadful = Console.ReadLine();
         Console.WriteLine("");
         Console.Write("Please provide a creature type: ");
         Apparition = Console.ReadLine();
         Console.WriteLine("");
         Console.Write("Please provide a creature type: ");
         Hound = Console.ReadLine();
         Console.WriteLine("");
         Console.Write("Please provide a type of story: ");
         Story = Console.ReadLine();
         Console.WriteLine("");

         // Outlut the Madlib

         Console.WriteLine($"They all agreed that it was a huge {Creature}, {Luminous}, {Ghastly}, and {Spectral}. " +
            $"I have cross-examined these men, one of them a hard-headed {Countryman}, one a {Farrier}, and one a " +
            $"moorland {Farmer}, who all tell the same {Story} of this {Dreadful} {Apparition}, exactly corresponding to " +
            $"the hell-{Hound} of the legend.");
         Console.ReadKey();

      }
   }
      class WordGame
   {
      static void Main()
      {
         MadLib.Run();              
      }
   }
   
}
