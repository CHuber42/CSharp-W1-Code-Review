using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    private static int Bonus = 3;
    public static void Main()
    {
      
        
      Console.WriteLine("Welcome to Bob's Bodacious Bagel Bakery and Breadery\nWe bake 'em, you buy 'em!");
      Prompt1:
      Console.WriteLine("Today we have 'Grab Bags'; for $50 get a random (between 0-20) number of loaves of bread and pastries. Want one of those, or shop normally? ([R]andom or [N]ormal) ");
      switch (Console.ReadLine().ToLower())
      {
        case "n":
          break;
        case "r":
          randomGoodies();
          Environment.Exit(0);
          break;
        default:
          goto Prompt1;

      }

      
      Console.WriteLine("How many loaves of bread do you want today?");
      Item.Bread bread = new Item.Bread(validateIntInput());
     
      Console.WriteLine("Awesome. Now tell me how many Bagels you would like.");
      Item.Pastry pastry = new Item.Pastry(validateIntInput());
      
      PresentTotal:
      if(checkBonus())
      {
        Console.WriteLine("Congratulations! You're a lucky customer! Your order is half off, but only if you check out now!");
        Console.WriteLine($"Your grand total is: ${(bread.Cost() + pastry.Cost())/2}. Would you like to modify your cart?\n[N]o, pay and exit\nModify [B]read\nModify [P]astries");
      }
      else
      {
      Console.WriteLine($"Your grand total is: ${bread.Cost() + pastry.Cost()}. Would you like to modify your cart?\n[N]o, pay and exit\nModify [B]read\nModify [P]astries");
      }
      

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

    public static bool checkBonus()
    {
      Bonus += 1;
      int check = new Random().Next(1, Bonus);
      if (check == 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static void randomGoodies()
    {
      string luckLevel = "";
      double loaves = new Random().Next(0, 20);
      double pastries = new Random().Next(0, 20);
      double totalValue = Math.Round((loaves * 3.33) + (pastries * 1.66), 2);
      Console.WriteLine($"You got {loaves} loaves of bread and {pastries} pastries. Their average value is ${totalValue}.");
      switch(totalValue)
      {
        case double n when n > 90 :
          luckLevel = "WOW! SO LUCKY!";
          break;
        case double n when n > 75 :
          luckLevel = "Hey, that's pretty lucky!";
          break;
        case double n when n > 55 :
          luckLevel = "That's a little lucky.";
          break;
        case double n when n >= 45 :
          luckLevel = "That's average luck.";
          break;
        case double n when n < 15 :
          luckLevel = "HOLY! THAT'S SO UNLUCKY!";
          break;
        case double n when n < 30 :
          luckLevel = "Oof, that's pretty unlucky!";
          break;
        case double n when n < 45 :
          luckLevel = "Dang, that's a little unlucky.";
          break;
      }
 
      Console.WriteLine(luckLevel + ".. but thanks for stopping in! Come again soon!");
      Environment.Exit(0);
    }
  }
}