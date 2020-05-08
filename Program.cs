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
     
      Console.WriteLine("Awesome. Now tell me how many Bagels you would like.");
      Item.Pastry pastry = new Item.Pastry(int.Parse(Console.ReadLine()));
      
      PresentTotal:
      Console.WriteLine($"Your grand total is: ${bread.Cost() + pastry.Cost()}. Would you like to modify your cart?\n[N]o, pay and exit\nModify [B]read\nModify [P]astries");

      switch (Console.ReadLine().ToLower())
      {
        case "n":
          Console.WriteLine("Thanks, neighbor! Come back again soon!");
          Environment.Exit(0);
          break;
        case "b":
          bread.AddItems(addOrRemove() * modificationQuantity());
          goto default;
        case "p":  
          pastry.AddItems(addOrRemove() * modificationQuantity());
          goto default;
        default :
          goto PresentTotal;
      }      
    }

    public static int addOrRemove()
    {
      int sign = 1;
      InvalidInput:
      Console.WriteLine("[A]dd items, or [R]emove?");
      switch(Console.ReadLine().ToLower())
      {
        case "r":
          sign = -1;
          break;
        case "a":
          sign = 1;
          break;
        default:
          goto InvalidInput;
      }
      return sign;
    }
    public static int modificationQuantity()
    {
      Console.WriteLine("Ok, how many?");
      return int.Parse(Console.ReadLine());
    }

  }
}