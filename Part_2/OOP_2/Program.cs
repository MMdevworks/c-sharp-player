// Classes

// Object-Oriented Principle #1: Encapsulation — Combining data (fields) and the operations on that data (methods) into a well-defined unit (like a class).


Arrow make = new Arrow();
// Console.WriteLine(make._arrowhead);
// Console.WriteLine(make._fletching);
// Console.WriteLine(make._length);

Console.Write("What type of arrowhead? ");
make._arrowhead = Console.ReadLine().ToLower();
// Arrow.GetArrowHead(make._arrowhead);

Console.WriteLine(make._arrowhead);


class Arrow {
    public ArrowHead _arrowhead;
    public Fletching _fletching;
    public float _length;

    public Arrow(ArrowHead, Fletching, float length) {
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