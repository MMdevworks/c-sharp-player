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

// CardColor[] colors = new CardColor[] {CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow};
// CardRank[] ranks = new CardRank[] {CardRank.One, CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, CardRank.Dollar, CardRank.Percent, CardRank.Caret, CardRank.Ampersand};

// foreach (CardColor color in colors){
//     foreach (CardRank rank in ranks){
//         Card card = new Card(color, rank);
//         Console.WriteLine($"The {card.Color} {card.Rank}");
//         // bool issymbol = card.IsSymbol;
//         // Console.WriteLine($"=> IsSymbol: {issymbol}");
//     }
// };

// public class Card {
//     public CardColor Color {get;}
//     public CardRank Rank {get;}

//     public Card (CardColor color, CardRank rank){
//         Color = color;
//         Rank = rank;
//     }

//     public bool IsSymbol => Rank == CardRank.Ampersand || Rank == CardRank.Caret || Rank == CardRank.Dollar || Rank == CardRank.Percent;
//     public bool IsNumber => !IsSymbol;
// }

// public enum CardColor {Red, Green, Blue, Yellow};
// public enum CardRank {One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand};


// ----- Door Class ------




CreateDoor();

void CreateDoor(){
    Door newDoor = new Door();
    Console.Write("Generating door, provide a passcode...: ");
    int userCode = Convert.ToInt32(Console.ReadLine());
    newDoor._passcode = userCode;
    newDoor.UserSelection(newDoor);
}

public class Door{
    public DoorStatus _doorState; 
    public int _passcode;

    public Door(){
        _doorState = DoorStatus.Locked;
        _passcode = 0;
    }
    public Door(DoorStatus doorState, int passcode){
        _doorState = doorState;
        _passcode = passcode;
    }

    public DoorStatus Lock(Door door){
        if(door._doorState == DoorStatus.Closed) {
            door._doorState = DoorStatus.Locked;
            Thread.Sleep(1000);
            UserSelection(door);
            return _doorState;
        }
        Thread.Sleep(1000);
        UserSelection(door);
        return _doorState;
    }
    public DoorStatus Open(Door door){
        if(door._doorState == DoorStatus.Closed || door._doorState == DoorStatus.Unlocked) {
            door._doorState = DoorStatus.Open;
            Thread.Sleep(1000);
            UserSelection(door);
            return _doorState;
        }
        Thread.Sleep(1000);
        UserSelection(door);
        return _doorState;
    }
    public DoorStatus Unlock(Door door){
        while(door._doorState == DoorStatus.Locked) {
            Console.WriteLine("To unlock the door, please enter the passcode.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (door._doorState == DoorStatus.Locked && userInput == _passcode) 
            {
                door._doorState = DoorStatus.Unlocked;
                Thread.Sleep(1000);
                UserSelection(door);
                return _doorState;
            }
        }
            Thread.Sleep(1000);
            UserSelection(door);
            return _doorState;
    }

    public DoorStatus Close(Door door){
        if (door._doorState == DoorStatus.Open){
            door._doorState = DoorStatus.Closed;
            UserSelection(door);
            return _doorState;
        }
        Thread.Sleep(1000);
        UserSelection(door);
        return _doorState;
    }

    public void ChangeCode(Door door) {
        Console.Write("To change the code, enter the current code: ");
        int userCode = Convert.ToInt32(Console.ReadLine());
        if (userCode == door._passcode){
            Console.Write("Access granted, you may enter the new code:  ");
            int newCode = Convert.ToInt32(Console.ReadLine());
            door._passcode = newCode;
            Console.Write($"New passcode set. {door._passcode}");
            Thread.Sleep(1000);
            UserSelection(door);
        }
        Thread.Sleep(1000);
        Console.Write("Incorrect passcode. ");
        UserSelection(door);
    }

    public void UserSelection(Door door){
        Console.WriteLine($"The door is {door._doorState}");
        Console.Write("What do you want to do? (open, close, lock, unlock, change code) ");
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "open" ) {
            door.Open(door);
        }
        else if (userInput == "close") {
            door.Close(door);
        } 
        else if (userInput == "lock") {
            door.Lock(door);
        } 
        else if (userInput == "unlock"){
            door.Unlock(door);
        }
        else if (userInput == "change code"){
            door.ChangeCode(door);
        }
        else {
            Console.WriteLine("Invalid Selection");
        }
    }
}
public enum DoorStatus {Locked, Unlocked, Open, Closed};
