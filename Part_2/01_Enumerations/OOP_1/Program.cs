// Enumerations 

// ChestState current = ChestState.Locked;
// bool constantLoop = true; 
// string chestCurrentState = "locked";

// while (constantLoop)
// {
//     Console.Write($"The chest is {chestCurrentState}. What do you want to do? ");
//     string command = Console.ReadLine();

//     if (command == "unlock" && current == ChestState.Locked) {
//         chestCurrentState = "unlocked";
//         current = ChestState.Unlocked;
//     } else if (command == "open" && current == ChestState.Unlocked) {
//         chestCurrentState = "opened";
//         current = ChestState.Open;
//     } else if (command == "close" && current == ChestState.Open) {
//         chestCurrentState = "closed";
//         current = ChestState.Closed;
//     } else if (command == "lock" && current == ChestState.Closed) {
//         chestCurrentState = "locked";
//         current = ChestState.Locked;
//     } else {
//         Console.WriteLine("Can't do that.");
//     }
// }

// enum ChestState {Locked, Unlocked, Open, Closed};



// Tuples

Console.WriteLine("Spicy, Salty, or Sweet?");
string res1 = Console.ReadLine().ToLower();

Console.WriteLine("Mushroom, Chicken, Carrot, or Potato?");
string res2 = Console.ReadLine().ToLower();

Console.WriteLine("Soup, Stew, or Gumbo?");
string res3 = Console.ReadLine().ToLower();

Seasoning currentSeasoning = res1 switch
{
    "spicy" => Seasoning.Spicy,
    "salty" => Seasoning.Salty,
    "sweet" => Seasoning.Sweet,
};

MainIngredient currentIngredient = res2 switch
{
    "mushroom" => MainIngredient.Mushroom,
    "chicken" => MainIngredient.Chicken,
    "carrot" => MainIngredient.Carrot,
    "potato" => MainIngredient.Potato,
};

FoodType currentType = res3 switch
{
    "soup" => FoodType.Soup,
    "stew" => FoodType.Stew,
    "gumbo" => FoodType.Gumbo,
};

(FoodType type, MainIngredient ingredient, Seasoning seasoning) dish = (currentType, currentIngredient, currentSeasoning);
Console.WriteLine($"Coming right up: {dish.seasoning} {dish.ingredient} {dish.type}");

enum FoodType {Soup, Stew, Gumbo};
enum MainIngredient {Mushroom, Chicken, Carrot, Potato};
enum Seasoning {Spicy, Salty, Sweet};

