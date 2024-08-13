// --- CHALLENGE --- Sisters
Console.WriteLine("How many have you?");
float eggnum = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("That's: " + eggnum + " chocy eggs");
float remainder = eggnum % 4;

Console.WriteLine(remainder + " will go to the pet");


// --- CHALLENGE --- Kings
float estate_points = 1;
float duchy_points = 3;
float province_points = 6;
float points = 0;

Console.WriteLine("how many estates?");
float estates = Convert.ToSingle(Console.ReadLine());
points += estates * estate_points;
Console.WriteLine("how many duchies?");
float duchies = Convert.ToSingle(Console.ReadLine());
points += duchies * duchy_points;
Console.WriteLine("how many provinces?");
float provinces = Convert.ToSingle(Console.ReadLine());
points += provinces * province_points;
Console.WriteLine("This kings total is: " + points);


// --- CHALLENGE --- Defense
int target_row;
int target_column;

Console.Write("What is the target row? -> ");
target_row = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the target column? -> ");
target_column = Convert.ToInt32(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine($"North defense set up at: \n ({target_row + 1},{target_column})");
Console.WriteLine($"South defense set up at: \n ({target_row - 1},{target_column})");
Console.WriteLine($"East defense set up at: \n ({target_row},{target_column + 1})");
Console.WriteLine($"West defense set up at: \n ({target_row},{target_column - 1})");
Console.Beep(400, 300);
