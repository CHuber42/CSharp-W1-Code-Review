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
        int costOfSets = (Count / 3) * 10;
        int costOfExtras = (Count % 3) * 5;

        return costOfSets + costOfExtras;   
      }
    }

    
    public class Pastry : Item
    {
      public int Cost()
      {
        int costOfSets = (Count / 3) * 5;
        int costOfExtras = (Count % 3) * 2;

        return costOfSets + costOfExtras;
      }
    }
  }
}