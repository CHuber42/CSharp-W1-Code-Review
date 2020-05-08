using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Bob's Bodacious Bagel Bakery and Breadery\nWe bake 'em, you buy 'em!\nHow many loaves of bread do you want today?");
      Item.Bread bread = new Item.Bread(int.Parse(Console.ReadLine()));
      Console.WriteLine(bread.Cost());
     
      // Console.WriteLine("Awesome. Now tell me how many Bagels you would like.");
      // Item.Pastry pastry = new Item.Pastry(int.Parse(Console.ReadLine()));

      // Console.WriteLine($"Ok, that'll be {bread.Cost() + pastry.Cost()} please.");

   
    }
  }
}