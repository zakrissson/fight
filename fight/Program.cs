using System;

Console.WriteLine("What do you want to do? [Case Sensitive]"); //Fight screen
Console.WriteLine("Attack"); //Attack
Console.WriteLine("Block"); // Block all damage, men din tur förbrukas
Console.WriteLine("Party"); //Switch partymembers

string fight = Console.ReadLine(); //Det som väljs lagras i "fight" variabeln

int[] enemyHealth = {100, 100, 100}; //rad 12-15: variabler
int charHealth = 200;
int[] enemyAtkDmg = {20, 20, 20};
int AtkDmg = 50;

if (enemyHealth [0] == 0) //ifall enemy dör
{
    Console.WriteLine("You killed the Goblin.");
    Console.WriteLine("It dropped 10 Gold.");
}

if (fight == "Attack") //ifall man väljer "attack"
{
    enemyHealth[0] = enemyHealth[0] - AtkDmg; //Tar atk.dmg från HP, ger HP nytt värde
    Console.WriteLine("You lunge your sword at the Goblin"); //Attack msg
    Console.WriteLine("Goblin HP: " + enemyHealth[0]);
    charHealth = charHealth - enemyAtkDmg[0];
    Console.WriteLine("The Goblin charges towards you, knocking you back.");
    Console.WriteLine("Your Health: " + charHealth);
    Console.ReadLine();  
}

if (fight == "Party") //ifall man väljer "party"
{
    Console.WriteLine("Select Party Member.");
    Console.WriteLine("Current: X, Switch to Y? [Yes/No | Case Sensitive]");
    string answer = Console.ReadLine();

    if (answer == "Yes") //om man säger ja
    {
        Console.WriteLine("Succesfully switched to Y.");
        Console.ReadLine(); 
    }

    if (answer == "No") //om man säger nej
    {
        Console.WriteLine("You didn't switch.");
        Console.ReadLine();
    }
}

if (fight == "Block") //om man väljer "block"
{
    Console.WriteLine("You blocked the incoming attack");
    Console.WriteLine("No damage was dealt this round");
    Console.ReadLine();
}

Console.WriteLine("What do you want to do? [Case Sensitive]"); //Fight screen
Console.WriteLine("Attack"); //Attack
Console.WriteLine("Block"); // Block all damage, men din tur förbrukas
Console.WriteLine("Party"); //Switch partymembers
string fight2 = Console.ReadLine(); 

if (enemyHealth [0] == 0) //ifall enemy dör
{
    Console.WriteLine("You killed the Goblin.");
    Console.WriteLine("It dropped 10 Gold.");
}

if (fight2 == "Attack") //ifall man väljer "attack"
{
    enemyHealth[0] = enemyHealth[0] - AtkDmg; //Tar atk.dmg från HP, ger HP nytt värde
    Console.WriteLine("You lunge your sword at the Goblin"); //Attack msg
    Console.WriteLine("Goblin HP: " + enemyHealth[0]);
    charHealth = charHealth - enemyAtkDmg[0];
    Console.WriteLine("The Goblin charges towards you, knocking you back.");
    Console.WriteLine("Your Health: " + charHealth);
}

if (fight2 == "Party") //ifall man väljer "party"
{
    Console.WriteLine("Select Party Member.");
    Console.WriteLine("Current: X, Switch to Y? [Yes/No | Case Sensitive]");
    string answer2 = Console.ReadLine();

    if (answer2 == "Yes") //om man säger ja
    {
        Console.WriteLine("Succesfully switched to Y.");
        Console.ReadLine(); 
    }

    if (answer2 == "No") //om man säger nej
    {
        Console.WriteLine("You didn't switch.");
        Console.ReadLine();
    }
}

if (fight2 == "Block") //om man väljer "block"
{
    Console.WriteLine("You blocked the incoming attack");
    Console.WriteLine("No damage was dealt this round");
    Console.ReadLine();
}