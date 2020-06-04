### Project: **Week 8 Code Review - Bob's Bodacious Bakery**
#### Author: **Christopher Huber**

### Github page: https://github.com/CHuber42/Fri-5-15-Code-Review
#### Github repo: You're standing on it.
##### Copyright Christopher Huber, 2020

&nbsp;
     
&nbsp;
         
##### Build instructions/Installation: 

This project is built in C# 8.0 using .netcoreapp2.2 on a system running Ubuntu 18.04.
Dependencies are declared in the wordcounter.csproj and wordcounter.Tests.csproj files in their respective folders;
to install, simply clone (or download) this folder into a new directory, git bash to ./wordcounter.Tests/ folder,
and run dotnet restore.

To run: either build the project using dotnet build and run the .exe, or navigate to the
./wordcounter/ folder in a terminal and enter "dotnet run"


##### Development specs:

** Spec 1: Use namespaces to allow for the passing of classes between folders (encapsulate code) **  
** Spec 2: Create a user order for a number of loaves of bread and pastries (bagels) they would like to buy **  
** Spec 3: Store these values in objects using a constructor and Attributes**  
** Spec 4: inform the user how much their order will cost, while applying some kind of buy-2-get-1-free logic for bread, 
and buy-3-get-a-discount logic for bagels **  
** EXTRA SPECS **  
** Spec 5: Inform the user they're on the verge of a deal, and offer it to them. Update costs accordingly **  
** Spec 6: Allow modification of order before confirming checkout (add or remove items) **  
** Spec 7: Add an initial prompt to offer to let user gamble;  
Get a random number of loaves of bread betwee 0 - 20 (average: 10, average value: $33.33)  
Same for Bagels: 0-20, average 10, average value $16.66.  
Charge $50 so cost == EV. **  
** Spec 8: Add random chance to get a discount if they don't modify their order any further and just check out.
This function must decrease in likelihood each time they go to check out, else they're incentivized to just
repeatedly go to checkout then change their mind, until they win the bonus **   

##### _Contact_:

CHuber42.Gmail.com

##### _Copyright Christopher Huber 2020, all rights reserved._
