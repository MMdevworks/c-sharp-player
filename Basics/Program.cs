// -----
// Console.WriteLine("how many?");
// float eggnum = Convert.ToSingle(Console.ReadLine());
// Console.WriteLine("that's: " + eggnum + " chocy eggs");
// float remainder = eggnum % 4;
 
// Console.WriteLine(remainder + " will go to the pet");


// -----

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