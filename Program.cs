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
      Console.WriteLine("Awesome.")

    }
  }
}