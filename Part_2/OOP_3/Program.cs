// CH24 Challenge

// ----- Point Class ------

// Point c1 = new Point(2, 3);
// Console.WriteLine($"({c1._pointX},{c1._pointY})");
// Point c2 = new Point(-4,0);
// Console.WriteLine($"({c2._pointX},{c2._pointY})");
// Point c3 = new Point();
// Console.WriteLine($"({c3._pointX},{c3._pointY})");

// class Point {
//     public int _pointX;
//     public int _pointY;

//     public Point(int pointX, int pointY) {
//         _pointX = pointX;
//         _pointY = pointY;
//     }
    
//     public Point() {
//         _pointX = 0;
//         _pointY = 0;
//     }
// }


// ----- Color Class ------

// Color myColor = new Color(50, 255,128);
// Color predefinedColor = Color.Orange();
// Console.WriteLine($"My color rgb: {myColor.R}, {myColor.G}, {myColor.B}");
// Console.WriteLine($"Predefined color rgb: {predefinedColor.R}, {predefinedColor.G}, {predefinedColor.B}");

// public class Color {
//     public int R;
//     public int G;
//     public int B;

//     public Color(int r, int g, int b){
//         R = r;
//         G = g;
//         B = b;
//     }

//     public static Color Black() => new Color(0,0,0);
//     public static Color White() => new Color(255,255,255);
//     public static Color Red() => new Color(255,0,0);
//     public static Color Orange() => new Color(255,165,0);
//     public static Color Yellow() => new Color(255,255,0);
//     public static Color Green() => new Color(0,128,0);
//     public static Color Blue() => new Color(0,0,255);
//     public static Color Purple() => new Color(128,0,128);
// }

// ----- Card Class ------

CardColor[] colors = new CardColor[] {CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow};
CardRank[] ranks = new CardRank[] {CardRank.One, CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, CardRank.Dollar, CardRank.Percent, CardRank.Caret, CardRank.Ampersand};

foreach (CardColor color in colors){
    foreach (CardRank rank in ranks){
        Card card = new Card(color, rank);
        Console.WriteLine($"The {card.Color} {card.Rank}");
        // bool issymbol = card.IsSymbol;
        // Console.WriteLine($"=> IsSymbol: {issymbol}");
    }
};

public class Card {
    public CardColor Color {get;}
    public CardRank Rank {get;}

    public Card (CardColor color, CardRank rank){
        Color = color;
        Rank = rank;
    }

    public bool IsSymbol => Rank == CardRank.Ampersand || Rank == CardRank.Caret || Rank == CardRank.Dollar || Rank == CardRank.Percent;
    public bool IsNumber => !IsSymbol;
}

public enum CardColor {Red, Green, Blue, Yellow};
public enum CardRank {One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand};