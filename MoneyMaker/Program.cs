// See https://aka.ms/new-console-template for more information

// Let the user know that the program is starting:
Console.WriteLine("Welcome to Money Maker!");

// Let the user give you a value and then convert it to double
Console.WriteLine("Enter an amount to convert to coins:");
string totalMoney = Console.ReadLine();
double myTotalMoney = Convert.ToDouble(totalMoney);
Console.WriteLine($"{myTotalMoney} cents is equal to...");

//Convert to coins
int goldCoin = 10;
int silverCoin = 5;

double goldCoins = Math.Floor(myTotalMoney / goldCoin);
double leftOverGold = myTotalMoney % goldCoin;

double silverCoins = Math.Floor(leftOverGold / silverCoin);
double leftOverSilver = leftOverGold % silverCoin;

//print the results
Console.WriteLine($"Gold coins: {goldCoins}\nSilver coins: {silverCoins}\nBronze coins: {leftOverSilver}");