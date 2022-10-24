
// double - 4.12, 32, 1,234

/* 
decimal - 4.12, 32, 1,234 - deciaml is more precise than double,
BUT! there are additional cost to the additional storage space in memory
decimal reserves much larger spot in a memory
*/

decimal bankAccountBalance;
bankAccountBalance = 2.35M;
Console.WriteLine(bankAccountBalance);



// whenever you can - use double!
double balance;
Console.Write("What is your beginning balance: ");
var beginningBalance = Console.ReadLine();
double userBeginningbalance = Convert.ToDouble(beginningBalance);
Console.Write("How much do you want to deposit today? ");
var deposit = Console.ReadLine();
double usersDeposit = Convert.ToDouble(deposit);
// balance = userBeginningbalance + usersDeposit;
Console.WriteLine(@$"You ending balance is ${userBeginningbalance + usersDeposit}");
Console.ReadLine();