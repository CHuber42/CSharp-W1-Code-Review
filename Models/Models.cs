using System;
using System.Collections.Generic;

namespace Bakery0
{

  public class Item
  {
    public static int Count {get; set;}
    public class Bread
    {
      public int Cost()
      {
        int costOfSets = (Count / 3) * 10;
        int costOfExtras = (Count % 3) * 5;

        return costOfSets + costOfExtras;   
      }
    }

    
    public class Pastry
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