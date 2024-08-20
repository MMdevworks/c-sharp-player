﻿// Classes

// Object-Oriented Principle #1: Encapsulation — Combining data (fields) and the operations on that data (methods) into a well-defined unit (like a class).


// Arrow make = new Arrow();
// Console.WriteLine(make._arrowhead);
// Console.WriteLine(make._fletching);
// Console.WriteLine(make._length);


// Arrow.GetArrowHead(make._arrowhead);

// Console.WriteLine(make._arrowhead);

// Arrow MakeArrow(){

// }

GetArrowHead();
GetFletching();
GetLength();

ArrowHead GetArrowHead(){
    Console.Write("What type of arrowhead? ");
    string userInput = Console.ReadLine().ToLower();
    return userInput switch{
        "steel" => ArrowHead.Steel,
        "wood" => ArrowHead.Wood,
        "obsidian" => ArrowHead.Obsidian,
    };
    Console.Write(userInput);
}

Fletching GetFletching(){
    Console.Write("What type of fletching? ");
    string userInput = Console.ReadLine().ToLower();
    return userInput switch{
        "plastic" => Fletching.Plastic,
        "turkey" => Fletching.Turkey,
        "goose" => Fletching.Goose,
    };
    Console.Write(userInput);
}

float GetLength(){
    Console.Write("Length 60 - 100 ");
    float userInput = Convert.ToSingle(Console.ReadLine());
    float cost = userInput * 0.05f;
    Console.WriteLine($"${cost}");
    return cost;
}

class Arrow {
    public ArrowHead _arrowhead;
    public Fletching _fletching;
    public float _length;

    public Arrow(ArrowHead arrowhead, Fletching fletching, float length) {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

}
    enum ArrowHead { Steel, Wood, Obsidian};
    enum Fletching { Plastic, Turkey, Goose};




// Score best = new Score();
// best.name = "M";
// best.points = 100;
// best.level = 15;

// Console.WriteLine($"{best.name}, {best.points}, {best.level}");
// class Score
// {
//     public string name;
//     public int points;
//     public int level;
// public bool EarnedStar() => (points / level) > 1000; 
// }