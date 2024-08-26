// Classes

// Arrow newArrow = MakeArrow();
// Console.WriteLine($"A {newArrow.GetArrowHeadType()} and {newArrow.GetFletchingType()} arrow at {newArrow.GetShaftLength()}cm long.");
// Console.WriteLine($"The cost of this arrow is: ${newArrow.GetCost()}");

// Arrow MakeArrow(){
//     ArrowHead arrowhead = GetArrowHead();
//     Fletching fletching = GetFletching();
//     float length = GetLength();
//     return new Arrow(arrowhead, fletching, length);
// }

// ArrowHead GetArrowHead(){
//     Console.Write("What type of arrowhead? (Steel, Wood, Obsidian) ");
//     string userInput = Console.ReadLine().ToLower();
//     return userInput switch{
//         "steel" => ArrowHead.Steel,
//         "wood" => ArrowHead.Wood,
//         "obsidian" => ArrowHead.Obsidian,
//     };
//     Console.Write(userInput);
// }

// Fletching GetFletching(){
//     Console.Write("What type of fletching? (Plastic, Turkey, Goose) ");
//     string userInput = Console.ReadLine().ToLower();
//     return userInput switch{
//         "plastic" => Fletching.Plastic,
//         "turkey" => Fletching.Turkey,
//         "goose" => Fletching.Goose,
//     };
//     Console.Write(userInput);
// }

// float GetLength(){
//     float userInput = 0;
//     while (userInput < 60 || userInput > 100 ){
//         Console.Write("How long in centimeters? (60 - 100) ");
//         userInput = Convert.ToSingle(Console.ReadLine());
//     }
//     return userInput;
// }

// class Arrow {
//     private ArrowHead _arrowhead;
//     private Fletching _fletching;
//     private float _length;

//     // Constructor
//     public Arrow(ArrowHead arrowhead, Fletching fletching, float length) {
//         _arrowhead = arrowhead;
//         _fletching = fletching;
//         _length = length;
//     }

//     public ArrowHead GetArrowHeadType() => _arrowhead;
//     public Fletching GetFletchingType() => _fletching;
//     public float GetShaftLength() => _length;

//     public float GetCost() {
        
//         float arrowHeadCost = _arrowhead switch 
//         {
//             ArrowHead.Steel => 10,
//             ArrowHead.Wood => 3,
//             ArrowHead.Obsidian => 5,
//         };
        
//         float fletchingCost = _fletching switch
//         {
//             Fletching.Plastic => 10,
//             Fletching.Turkey => 5,
//             Fletching.Goose => 3,
//         };

//         return (_length * 0.05f) + arrowHeadCost + fletchingCost;
//     }

// }
//     enum ArrowHead { Steel, Wood, Obsidian};
//     enum Fletching { Plastic, Turkey, Goose};



// The above program, utilizing properties within the Arrow class as opposed to get methods

// Arrow newArrow = MakeArrow();
// Console.WriteLine($"A {newArrow.HeadType} and {newArrow.FletchingType} arrow at {newArrow.ShaftLength}cm long.");
// Console.WriteLine($"The cost of this arrow is: ${newArrow.GetCost()}");

// Arrow MakeArrow(){
//     ArrowHead arrowhead = GetArrowHead();
//     Fletching fletching = GetFletching();
//     float length = GetLength();
//     return new Arrow(arrowhead, fletching, length);
// }

// ArrowHead GetArrowHead(){
//     Console.Write("What type of arrowhead? (Steel, Wood, Obsidian) ");
//     string userInput = Console.ReadLine().ToLower();
//     return userInput switch{
//         "steel" => ArrowHead.Steel,
//         "wood" => ArrowHead.Wood,
//         "obsidian" => ArrowHead.Obsidian,
//     };
//     Console.Write(userInput);
// }

// Fletching GetFletching(){
//     Console.Write("What type of fletching? (Plastic, Turkey, Goose) ");
//     string userInput = Console.ReadLine().ToLower();
//     return userInput switch{
//         "plastic" => Fletching.Plastic,
//         "turkey" => Fletching.Turkey,
//         "goose" => Fletching.Goose,
//     };
//     Console.Write(userInput);
// }

// float GetLength(){
//     float userInput = 0;
//     while (userInput < 60 || userInput > 100 ){
//         Console.Write("How long in centimeters? (60 - 100) ");
//         userInput = Convert.ToSingle(Console.ReadLine());
//     }
//     return userInput;
// }

// class Arrow {
//     private ArrowHead _arrowhead;
//     private Fletching _fletching;
//     private float _length;

//     // constructor
//     public Arrow(ArrowHead arrowhead, Fletching fletching, float length) {
//         _arrowhead = arrowhead;
//         _fletching = fletching;
//         _length = length;
//     }

//     // properties
//     public ArrowHead HeadType
//     {
//         get => _arrowhead;
//     }
//     public Fletching FletchingType
//     {
//         get => _fletching;
//     }
//     public float ShaftLength
//     {
//         get => _length;
//     }
    
//     public float GetCost() {
        
//         float arrowHeadCost = _arrowhead switch 
//         {
//             ArrowHead.Steel => 10,
//             ArrowHead.Wood => 3,
//             ArrowHead.Obsidian => 5,
//         };
        
//         float fletchingCost = _fletching switch
//         {
//             Fletching.Plastic => 10,
//             Fletching.Turkey => 5,
//             Fletching.Goose => 3,
//         };

//         return (_length * 0.05f) + arrowHeadCost + fletchingCost;
//     }

// }
//     enum ArrowHead { Steel, Wood, Obsidian};
//     enum Fletching { Plastic, Turkey, Goose};


// --------- Utilize static methods within the arrow class, user may choose a premade or custom arrow.


Arrow newArrow = MakeArrow();
OrderAndPrice();

void OrderAndPrice(){
    Console.WriteLine($"A {newArrow.HeadType} and {newArrow.FletchingType} arrow at {newArrow.ShaftLength}cm long.");
    Console.WriteLine($"The cost of this arrow is: ${newArrow.GetCost()}");
}

Arrow MakeArrow(){
    Console.WriteLine("Welcome to the Arrow Shop, please make a selection:");
    Console.WriteLine("1 - Novice");
    Console.WriteLine("2 - Marksman");
    Console.WriteLine("3 - Elite");
    Console.WriteLine("4 - Custom");
    string userInput = Console.ReadLine();
    
    Arrow newArrow = userInput switch
    {
        "1" => Arrow.CreateNoviceArrow(),
        "2" => Arrow.CreateMarksmanArrow(),
        "3" => Arrow.CreateEliteArrow(),
        _ => CreateCustomArrow(),
    };
    return newArrow;
}

Arrow CreateCustomArrow(){
    ArrowHead arrowhead = GetArrowHead();
    Fletching fletching = GetFletching();
    float length = GetLength();
    return new Arrow(arrowhead, fletching, length);
}

ArrowHead GetArrowHead(){
    Console.Write("What type of arrowhead? (Steel, Wood, Obsidian) ");
    string userInput = Console.ReadLine().ToLower();
    return userInput switch{
        "steel" => ArrowHead.Steel,
        "wood" => ArrowHead.Wood,
        "obsidian" => ArrowHead.Obsidian,
    };
    Console.Write(userInput);
}

Fletching GetFletching(){
    Console.Write("What type of fletching? (Plastic, Turkey, Goose) ");
    string userInput = Console.ReadLine().ToLower();
    return userInput switch{
        "plastic" => Fletching.Plastic,
        "turkey" => Fletching.Turkey,
        "goose" => Fletching.Goose,
    };
    Console.Write(userInput);
}

float GetLength(){
    float userInput = 0;
    while (userInput < 60 || userInput > 100 ){
        Console.Write("How long in centimeters? (60 - 100) ");
        userInput = Convert.ToSingle(Console.ReadLine());
    }
    return userInput;
}

class Arrow {
    private ArrowHead _arrowhead;
    private Fletching _fletching;
    private float _length;

    public Arrow(ArrowHead arrowhead, Fletching fletching, float length) {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    public ArrowHead HeadType
    {
        get => _arrowhead;
    }
    public Fletching FletchingType
    {
        get => _fletching;
    }
    public float ShaftLength
    {
        get => _length;
    }

    public static Arrow CreateNoviceArrow() => new Arrow(ArrowHead.Wood, Fletching.Goose, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowHead.Steel, Fletching.Goose, 65);
    public static Arrow CreateEliteArrow() => new Arrow(ArrowHead.Steel, Fletching.Plastic, 95);

    public float GetCost() {
        
        float arrowHeadCost = _arrowhead switch 
        {
            ArrowHead.Steel => 10,
            ArrowHead.Wood => 3,
            ArrowHead.Obsidian => 5,
        };
        
        float fletchingCost = _fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.Turkey => 5,
            Fletching.Goose => 3,
        };

        return (_length * 0.05f) + arrowHeadCost + fletchingCost;
    }

}
    enum ArrowHead { Steel, Wood, Obsidian};
    enum Fletching { Plastic, Turkey, Goose};

// NOTES: ref to ch20 
// If fields were public the properties could be as such
// public ArrowHead _arrowhead {get;}
// public Fletching _fletching {get;}
// public float _length {get;}

