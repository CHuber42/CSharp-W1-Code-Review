using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    public static void Main()
    {
        
      Console.WriteLine("Welcome to Bob's Bodacious Bagel Bakery and Breadery\nWe bake 'em, you buy 'em!\nHow many loaves of bread do you want today?");
      Item.Bread bread = new Item.Bread(validateIntInput());
     
      Console.WriteLine("Awesome. Now tell me how many Bagels you would like.");
      Item.Pastry pastry = new Item.Pastry(validateIntInput());
      
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
          goto case "return";
        case "p":  
          pastry.AddItems(addOrRemove() * modificationQuantity());
          goto case "return";
        default :
          Console.WriteLine("Sorry, I didn't understand that.");
          goto case "return";
        case "return" :
          goto PresentTotal;
      }      
    }

    public static int addOrRemove()
    {
      int sign = 1;
      Console.WriteLine("[A]dd items, or [R]emove?");
      InvalidInput:
      switch(Console.ReadLine().ToLower())
      {
        case "r":
          sign = -1;
          break;
        case "a":
          sign = 1;
          break;
        default:
        Console.WriteLine("You need to tell me whether to Add ('a') or Remove ('r') items.");
          goto InvalidInput;
      }
      return sign;
    }
    public static int modificationQuantity()
    {
      Console.WriteLine("Ok, how many?");
      return validateIntInput();
    }

    public static int validateIntInput()
    {
      int input;
      TryAgain:
      try{
        input = int.Parse(Console.ReadLine());
      }
      catch 
      {
        Console.WriteLine("Sorry, it appears your input was not an integer. Try again.");
        goto TryAgain;
      }
      return input;
    }

 

  }
}