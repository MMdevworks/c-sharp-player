// ---- CHALLENGE ---- Clock (if)

// Console.WriteLine("What is the hour?");
// int hour = Convert.ToInt32(Console.ReadLine());

// if (hour % 2 == 0)
//     Console.WriteLine("TICK!");
// else
//     Console.WriteLine("TOCK!");


// ---- CHALLENGE ---- Watchtower (Conditional)

// Console.WriteLine("Give me an X");
// int xVal = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Give me a Y");
// int yVal = Convert.ToInt32(Console.ReadLine());


// if (xVal < 0 && yVal > 0) 
//     Console.WriteLine("They are in the northwest");
// else if (xVal < 0 && yVal == 0)
//     Console.WriteLine("They are in the west");
// else if (xVal < 0 && yVal < 0)
//     Console.WriteLine("They are in the southwest");
// else if (xVal == 0 && yVal > 0)
//     Console.WriteLine("They are in the north");
// else if (xVal == 0 && yVal < 0)
//     Console.WriteLine("They are in the south");
// else if (xVal > 0 && yVal > 0)
//     Console.WriteLine("They are in the northeast");
// else if (xVal > 0 && yVal == 0)
//     Console.WriteLine("They are in the east");
// else if (xVal > 0 && yVal < 0)
//     Console.WriteLine("They are in the southeast");
// else
//     Console.WriteLine("They are here!");

// ---- CHALLENGE ----- Price List (Traditional Switch)

// bool running = true;
// string discount;

// while (running) {
//     string title = "--- Available Inventory ---";
//     string item1 = "1: Camera";
//     string item2 = "2: Journal";
//     string item3 = "3: EMF";
//     string item4 = "4: Parabolic Microphone";
//     string item5 = "5: Recorder";
//     string item6 = "6: Smudge Sticks";
//     string item7 = "7: Spirit Box";
//     string item8 = "8: Thermometer";
//     string item9 = "9: Torch";

//     Console.WriteLine($"{title} \n{item1} \n{item2} \n{item3} \n{item4} \n{item5} \n{item6} \n{item7} \n{item8} \n{item9}");
//     Console.Write("Which item's price would you like to see? Choose it's number: ");
//     int selection = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Do you have the golden ticket? y or n > ");
//     discount = Console.ReadLine();

//     if (discount != "y")
//     {
//         switch (selection)
//             {
//             case 1:
//                 Console.WriteLine($"Item {item1} cost 5 orbs");
//                 running = false;
//                 break;
//             case 2:
//                 Console.WriteLine($"Item {item2} cost 2 orbs");
//                 running = false;
//                 break;
//             case 3:
//                 Console.WriteLine($"Item {item3} cost 25 orbs");
//                 running = false;
//                 break;
//             case 4:
//                 Console.WriteLine($"Item {item4} cost 50 orbs");
//                 running = false;
//                 break;
//             case 5:
//                 Console.WriteLine($"Item {item5} cost 15 orbs");
//                 running = false;
//                 break;
//             case 6:
//                 Console.WriteLine($"Item {item6} cost 3 orbs");
//                 running = false;
//                 break;
//             case 7:
//                 Console.WriteLine($"Item {item7} cost 30 orbs");
//                 running = false;
//                 break;
//             case 8:
//                 Console.WriteLine($"Item {item8} cost 10 orbs");
//                 running = false;
//                 break;
//             case 9:
//                 Console.WriteLine($"Item {item9} cost 10 orbs");
//                 running = false;
//                 break;
//             default:
//                 Console.WriteLine("Invalid selection, try again. Reprinting inventory...");
//                 Thread.Sleep(3000);
//                 break;
//             }
//     }

//     if (discount == "y") 
//     {
//         Console.Write("Wow special discount - 50% off! ");
//         switch (selection)
//             {
//             case 1:
//                 Console.WriteLine($"Item {item1} cost 2.5 orbs");
//                 running = false;
//                 break;
//             case 2:
//                 Console.WriteLine($"Item {item2} cost 1 orbs");
//                 running = false;
//                 break;
//             case 3:
//                 Console.WriteLine($"Item {item3} cost 12.5 orbs");
//                 running = false;
//                 break;
//             case 4:
//                 Console.WriteLine($"Item {item4} cost 25 orbs");
//                 running = false;
//                 break;
//             case 5:
//                 Console.WriteLine($"Item {item5} cost 7.5 orbs");
//                 running = false;
//                 break;
//             case 6:
//                 Console.WriteLine($"Item {item6} cost 1.5 orbs");
//                 running = false;
//                 break;
//             case 7:
//                 Console.WriteLine($"Item {item7} cost 15 orbs");
//                 running = false;
//                 break;
//             case 8:
//                 Console.WriteLine($"Item {item8} cost 5 orbs");
//                 running = false;
//                 break;
//             case 9:
//                 Console.WriteLine($"Item {item9} cost 5 orbs");
//                 running = false;
//                 break;
//             default:
//                 Console.WriteLine("Buuut... Invalid selection, try again. Reprinting inventory...");
//                 Thread.Sleep(3000);
//                 break;
//             }
//     }
// }

// ---- CHALLENGE ----- Price List (Expression Based)

// bool valid = true;
// string user_input;

// string title = "--- Available Inventory ---";
// string item1 = "1: Camera";
// string item2 = "2: Journal";
// string item3 = "3: EMF";
// string item4 = "4: Parabolic Microphone";
// string item5 = "5: Recorder";
// string item6 = "6: Smudge Sticks";
// string item7 = "7: Spirit Box";
// string item8 = "8: Thermometer";
// string item9 = "9: Torch";

// Console.WriteLine($"{title} \n{item1} \n{item2} \n{item3} \n{item4} \n{item5} \n{item6} \n{item7} \n{item8} \n{item9}");
// Console.Write("Which item's price would you like to see? Choose it's number: ");
// int selection = Convert.ToInt32(Console.ReadLine());

// user_input = selection switch
// {
//     1 => $"Item {item1} cost 5 orbs",
//     2 => $"Item {item2} cost 2 orbs",
//     3 => $"Item {item3} cost 25 orbs",
//     4 => $"Item {item4} cost 50 orbs",
//     5 => $"Item {item5} cost 15 orbs",
//     6 => $"Item {item6} cost 3 orbs",
//     7 => $"Item {item7} cost 30 orbs",
//     8 => $"Item {item8} cost 10 orbs",
//     9 => $"Item {item9} cost 10 orbs",
//     _ => "Invalid selection, try again. Reprinting inventory...",
// };

// Console.WriteLine(user_input);
// break;

// ---- CHALLENGE ---- The Prototype (loops)

// int target_number;
// int guess_number;
// bool looping = true;

// Console.Write("Hider, enter a number between 0 and 100: ");
// target_number = Convert.ToInt32(Console.ReadLine());
// while (looping) {
//     Thread.Sleep(1000);
//     Console.Write("Seeker, guess the number. ");
//     guess_number = Convert.ToInt32(Console.ReadLine());
//     if (guess_number > target_number) {
//         Console.WriteLine($"{guess_number} is too high. Guess again."); 
//         continue;
//     } else if (guess_number < target_number){
//         Console.WriteLine($"{guess_number} is too low. Guess again");
//         continue;
//     } else {
//         Console.WriteLine($"You got it! The number was {target_number}.");
//         break;
//     }
// }

// ---- CHALLENGE ---- Cannon(loops) 

// for (int turn = 1; turn <= 100; turn++){
//     if (turn % 3 == 0 && turn % 5 == 0){
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.WriteLine($"{turn}: Electric Fire!");
//     }else if (turn % 3 == 0) {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.WriteLine($"{turn}: Fire!");
//     }else if (turn % 5 == 0) {
//         Console.ForegroundColor = ConsoleColor.Yellow;
//         Console.WriteLine($"{turn}: Electric!");
//     } else {
//         Console.ForegroundColor = ConsoleColor.White;
//         Console.WriteLine($"{turn}: Normal");
//     }
// }

// ---- CHALLENGE ---- 

// -- ARRAYS
// int[] array = new int[10];
// for(int index = 0; index < array.Length; index++) array[index] = 1;
// foreach (int i in array){
//     Console.WriteLine(i);
// }

// int[] scores = new [] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };
// Console.WriteLine(scores[^1]);

// foreach (int i in scores){Console.WriteLine(scores[0..3]);

// ---- ---- REPLICATOR (Arrays)

// gi
    
// Write out all items in firstArray and secondArray
// for(int index = 0; index < firstArray.Length; index++)
// {
//     int val = firstArray[index];
//     int val2 = secondArray[index];
//     Console.WriteLine($"First array {val}");
//     Console.WriteLine($"Second array {val}");
// }

// returns the index value: 
// ($"Enter a number for spot {first_array[i]}");
// returns the index
// ($"Enter a number for spot {i}");


// ---- CHALLENGE ---- For Each
// int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
// int currentSmallest = int.MaxValue;
// foreach(int num in array){
//     if (num < currentSmallest){
//         currentSmallest = num;
//     }
// }

// Console.WriteLine(currentSmallest);


// int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
// int total = 0;
// foreach (int val in array)
//     total += val;
// float average = (float)total / array.Length;
// Console.WriteLine(average);

// ---- CHALLENGE ---- Take a Number (Method)

// ----- Method 1
// int result = AskForNumber("Give me a number and I'll give it back... ");
// Console.Write(result);

// int AskForNumber(string text)
// {
//     Console.Write(text);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// ----- Method 2

// AskForNumberInRange("Give me a number within the magic range... ", 35, 45);

// int AskForNumberInRange(string text, int min, int max)
// {   
//     while (true)
//     {
//         Console.Write(text);
//         int guess = Convert.ToInt32(Console.ReadLine());
//         if (guess >= 35 && guess <= 45){
//             Console.WriteLine("Wow, like a magic.");
//             return guess;
//         }
//         Console.WriteLine("No magic. Guess again.");
//     }
// }

// ---- CHALLENGE ---- Countdown (Recursion)

// FinalCoundown(11);

// int FinalCoundown(int num)
// {
//     while(true){
//         if (num > 1){
//             num--;
//             Console.WriteLine($"{num}");
//             FinalCoundown(num);
//         }
//         return num;
//     }
// }

// ---- CHALLENGE ---- Manticore

int mantiHealthStatic = 10;
int mantiHealthCurrent = 10;
int cityHealthStatic = 15;
int cityHealthCurrent = 15;
int round = 0;
int roundDamage = 1;
int manticoreStation;
int damage = 1;
bool endGame = false;

StationManticore();

void StationManticore()
{
    Console.Write("Player 1, how far away from the city do you want to station the Manticore? (Range 0 - 100) ");
    manticoreStation = Convert.ToInt32(Console.ReadLine());
    if (manticoreStation < 0 || manticoreStation > 100)
    {
        Console.WriteLine("Out of range! Pick a number within limits.");
        StationManticore();
    }
    Console.WriteLine("Manticore has been stationed. Clearing the plan. One moment...");
    Thread.Sleep(2000);
    Console.Clear();
    DisplayStatus();
}

void DisplayStatus() 
{
    // check end game condition
    if (mantiHealthCurrent <= 0) {
        endGame = true;
        Console.WriteLine("You destroyed the Manticore and saved the city!");
    } else if (cityHealthCurrent <= 0) {
        endGame = true;
        Console.WriteLine("The Manticore destroyed the city!");
    }

    while(endGame != true)
    {
        round++;
        CalcRoundDamage(round);
        Console.WriteLine("Here is the current report: ");
        Thread.Sleep(2000);
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine($"STATUS: Round: {round} | City: {cityHealthCurrent}/{cityHealthStatic} | Manticore: {mantiHealthCurrent}/{mantiHealthStatic}");
        Console.WriteLine($"The cannon is expected to deal {roundDamage} damage this round.");
        Console.Write("Enter desired cannon range: ");
        int cannonRange = Convert.ToInt32(Console.ReadLine());
        CannonRange(cannonRange);
    }
}

// check if within hit range
void CannonRange(int range)
{
    if (range < manticoreStation) {
        Console.WriteLine("That round FELL SHORT of the target.");
        cityHealthCurrent--;
        CannonDamagePerRoundMiss(round);
        DisplayStatus();
    } else if (range > manticoreStation) {
        Console.WriteLine("That round OVERSHOT the target.");
        cityHealthCurrent--;
        CannonDamagePerRoundMiss(round);
        DisplayStatus();
    } else {
        Console.WriteLine("That round was a DIRECT HIT!");
        cityHealthCurrent--;
        CannonDamagePerRound(round);
    }
}

// if its a hit call this to determine damage by round
void CannonDamagePerRound(int currentRound)
{
    if (currentRound % 3 == 0 && currentRound % 5 == 0){
        damage = 5;
        mantiHealthCurrent -= damage;
    }else if (currentRound % 3 == 0 || currentRound % 5 == 0) {
        damage = 3;
        mantiHealthCurrent -= damage;
    } else {
        damage = 1;
        mantiHealthCurrent -= damage;
    }
    DisplayStatus();
}

void CannonDamagePerRoundMiss(int currentRound)
{
    if (currentRound % 3 == 0 && currentRound % 5 == 0){
        damage = 5;
    }else if (currentRound % 3 == 0 || currentRound % 5 == 0) {
        damage = 3;
    } else {
        damage = 1;
    }
    DisplayStatus();
}

//for displaying damage that will occur if there is a hit on current round
void CalcRoundDamage(int currentRound)
{
    if (currentRound % 3 == 0 && currentRound % 5 == 0){
        roundDamage = 5;
    }else if (currentRound % 3 == 0 || currentRound % 5 == 0) {
        roundDamage = 3;
    } else {
        roundDamage = 1;
    }
}