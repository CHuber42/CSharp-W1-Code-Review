using System;


namespace Bakery.Models
{

  public class Item
  {
    public static int Count {get; set;}
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
        Console.WriteLine(breadSets);
        Console.WriteLine(breadExtras);

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
        int pastrySets = (Count / 3);
        int pastryExtras = (Count % 3);
        Console.WriteLine(pastrySets);
        Console.WriteLine(pastryExtras);

        return pastrySets + pastryExtras;
      }
    }
  }
}