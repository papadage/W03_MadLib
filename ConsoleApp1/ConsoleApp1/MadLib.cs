using System;

namespace Game

{
   static class MadLib
   {
      // Declare variables
      static string Creature;
      static string Luminous;
      static string Ghastly;
      static string Spectral;
      static string Countryman;
      static string Farrier;
      static string Farmer;
      static string Dreadful;
      static string Apparition;
      static string Hound;
      static string Story;
      public static void Run()
      {
         Intro();
         GetWords();
         Output();
         End();
      }
      static void Intro()
      {
         Console.WriteLine("_____________");
         Console.WriteLine("MadLib!!!");
         Console.WriteLine("_____________");
      }
      public static void GetWords()
      {
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
      }
      static void Output()
      {  
       // Outlut the Madlib
              Console.WriteLine($"They all agreed that it was a huge {Creature}, {Luminous}, {Ghastly}, and {Spectral}. " +
            $"I have cross-examined these men, one of them a hard-headed {Countryman}, one a {Farrier}, and one a " +
            $"moorland {Farmer}, who all tell the same {Story} of this {Dreadful} {Apparition}, exactly corresponding to " +
            $"the hell-{Hound} of the legend.");
      }

      static void End()
      {
         // Kepp Window open and prompt for exit
         Console.ReadLine("Press [Enter] to exit.");
         Console.ReadKey();
      }
         
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
