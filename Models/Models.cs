using System;

namespace Bakery.Models
{

  public class Item
  {
    private int Count {get; set;}

    public void AddItems(int additionals)
    {
      if((Count + additionals) >= 0)
      {
      Count += additionals;
      }
      else
      {
        Console.WriteLine("What shenanigans are you up to? You can't have negative items in your cart!");
      }
    }
    
    public class Bread : Item
    {
      public Bread(int count)
      {
      Count = count;
      }
      public int Cost()
      {
        int breadSets = (Count / 3) * 10;
        int breadExtras = (Count % 3) * 5;
        Console.WriteLine($"That's {Count/3} buy-2-get-1-free deals on the bread at $10 per, subtotaling ${breadSets}, and {Count%3} unmatched loaves at $5 each subtotaling ${breadExtras}.");
        if (Count%3 == 2)
        {
          Console.WriteLine("You know if you grab another loaf of bread it's free, right? Since you have 2 individual loaves here. Want to go grab one? Y/N");
          if (Console.ReadLine().ToLower() == "y")
          {
            Count += 1;
            Cost();
          }
          else {
            Console.WriteLine("Well that didn't make sense to me, but I'm not gonna force you to take free/cheap items, so...");
          }
        }
        return breadSets + breadExtras;   
      }
    }
    

    
    public class Pastry : Item
    {
      public Pastry(int count)
      {
        Count = count;
      }
      public int Cost()
      {
        int pastrySets = (Count / 3) * 5;
        int pastryExtras = (Count % 3) * 2;
        Console.WriteLine($"That's {Count/3} sets-of-3 pastries at $5 per set subtotaling ${pastrySets}, and {Count%3} pastries at $2 each subtotaling ${pastryExtras}.");
         if (Count%3 == 2)
        {
          Console.WriteLine("Oh, also: if you grab another pastry it's only another $1. Want to round up? Y/N");
          if (Console.ReadLine().ToLower() == "y")
          {
            Count += 1;
            Cost();
          }
          else {
            Console.WriteLine("Well that didn't make sense to me, but I'm not gonna force you to take free/cheap items, so...");
          }
        }
        return pastrySets + pastryExtras;
      }
    }
  }
}