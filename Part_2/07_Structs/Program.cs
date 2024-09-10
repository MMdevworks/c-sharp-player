// A struct is a custom value type, short for structure or data structure.  Structs are not focused on behavior but can have properties and methods.
// Structs are nearly the same as using class except structs are value types instead of reference types.



// Create a Coordinate struct that can represent a room coordinate with a row and column. Sold to
// • Ensure Coordinate is immutable.
// • Make a method to determine if one coordinate is adjacent to another (differing only by a single row or column).
// • Write a main method that creates a few coordinates and determines if they are adjacent to each other to prove that it is working correctly.

CoordinateStruct coord1 = new CoordinateStruct(1,1);
CoordinateStruct coord2 = new CoordinateStruct(2,1);
CoordinateStruct coord3 = new CoordinateStruct(4,4);

public struct CoordinateStruct
{
    public int row {get;}
    public int col {get;}

}


// {

// if(coord)
//     row -= 1 || row += 1;
//     col -= 1 || col += 1;
    
// }