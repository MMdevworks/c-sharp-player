// Classes

// Object-Oriented Principle #1: Encapsulation — Combining data (fields) and the operations on that data (methods) into a well-defined unit (like a class).


Arrow make = new Arrow("aer", "agr", 1);
Console.WriteLine(make._arrowhead);
Console.WriteLine(make._fletching);
Console.WriteLine(make._length);


class Arrow {
    public string _arrowhead;
    public string _fletching;
    public int _length;

    public Arrow(string arrowhead, string fletching, int length) {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    // public ArrowHead GetArrowHead(){
    //     Console.Write("What type of arrowhead? ");
    //     string userInput = Console.ReadLine().ToLower();
    //     ArrowHead selected = userInput switch{
    //         "steel" => ArrowHead.Steel,
    //         "wood" => ArrowHead.Wood,
    //         "obsidian" => ArrowHead.Obsidian,
    //     };
    // }

    enum ArrowHead { Steel, Wood, Obsidian};
    // enum fletching { Plastic, Turkey, Goose};
}

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