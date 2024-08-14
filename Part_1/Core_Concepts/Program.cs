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

// bool valid = true;

// while (valid) {
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

//     switch (selection)
//         {
//         case 1:
//             Console.WriteLine($"Item {item1} cost 5 orbs");
//             valid = false;
//             break;
//         case 2:
//             Console.WriteLine($"Item {item2} cost 2 orbs");
//             valid = false;
//             break;
//         case 3:
//             Console.WriteLine($"Item {item3} cost 25 orbs");
//             valid = false;
//             break;
//         case 4:
//             Console.WriteLine($"Item {item4} cost 50 orbs");
//             valid = false;
//             break;
//         case 5:
//             Console.WriteLine($"Item {item5} cost 15 orbs");
//             valid = false;
//             break;
//         case 6:
//             Console.WriteLine($"Item {item6} cost 3 orbs");
//             valid = false;
//             break;
//         case 7:
//             Console.WriteLine($"Item {item7} cost 30 orbs");
//             valid = false;
//             break;
//         case 8:
//             Console.WriteLine($"Item {item8} cost 10 orbs");
//             valid = false;
//             break;
//         case 9:
//             Console.WriteLine($"Item {item9} cost 10 orbs");
//             valid = false;
//             break;
//         default:
//             Console.WriteLine("Invalid selection, try again. Reprinting inventory...");
//             Thread.Sleep(3000);
//             break;
//         }
// }

// ---- CHALLENGE ----- Price List (Expression Based)

bool valid = true;
string user_input;

string title = "--- Available Inventory ---";
string item1 = "1: Camera";
string item2 = "2: Journal";
string item3 = "3: EMF";
string item4 = "4: Parabolic Microphone";
string item5 = "5: Recorder";
string item6 = "6: Smudge Sticks";
string item7 = "7: Spirit Box";
string item8 = "8: Thermometer";
string item9 = "9: Torch";

Console.WriteLine($"{title} \n{item1} \n{item2} \n{item3} \n{item4} \n{item5} \n{item6} \n{item7} \n{item8} \n{item9}");
Console.Write("Which item's price would you like to see? Choose it's number: ");
int selection = Convert.ToInt32(Console.ReadLine());

user_input = selection switch
{
    1 => $"Item {item1} cost 5 orbs",
    2 => $"Item {item2} cost 2 orbs",
    3 => $"Item {item3} cost 25 orbs",
    4 => $"Item {item4} cost 50 orbs",
    5 => $"Item {item5} cost 15 orbs",
    6 => $"Item {item6} cost 3 orbs",
    7 => $"Item {item7} cost 30 orbs",
    8 => $"Item {item8} cost 10 orbs",
    9 => $"Item {item9} cost 10 orbs",
    _ => "Invalid selection, try again. Reprinting inventory...",
};

Console.WriteLine(selection);

