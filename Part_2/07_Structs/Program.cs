// A struct is a custom value type, short for structure or data structure.  Structs are not focused on behavior but can have properties and methods.
// Structs are nearly the same as using class except structs are value types instead of reference types.

Coordinate coord1 = new Coordinate(1,1);
Coordinate coord2 = new Coordinate(2,1);
Coordinate coord3 = new Coordinate(4,4);
Coordinate coord4 = new Coordinate(-3, -2);
Coordinate coord5 = new Coordinate(-2, -2);


Console.WriteLine(Coordinate.AreAdjacent(coord1, coord2));
Console.WriteLine(Coordinate.AreAdjacent(coord1, coord3));
Console.WriteLine(Coordinate.AreAdjacent(coord2, coord3));
Console.WriteLine(Coordinate.AreAdjacent(coord4, coord5));

public struct Coordinate
{
    public int Row {get;}
    public int Col {get;}

    public Coordinate(int row, int col)
    {
        Row = row;
        Col = col;
    }

public static bool AreAdjacent(Coordinate coord1, Coordinate coord2)
    {
        int rowDiff = coord1.Row - coord2.Row;
        int colDiff = coord1.Col - coord2.Col;
        
        if (rowDiff <= 1 && colDiff == 0) return true;
        if (colDiff <= 1 && rowDiff == 0) return true;

        return false;
    }
}

