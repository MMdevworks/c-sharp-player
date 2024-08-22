// CH24 Challenge

Point c1 = new Point(2, 3);
Console.WriteLine($"({c1._pointX},{c1._pointY})");
Point c2 = new Point(-4,0);
Console.WriteLine($"({c2._pointX},{c2._pointY})");
Point c3 = new Point();
Console.WriteLine($"({c3._pointX},{c3._pointY})");

class Point {
    public int _pointX;
    public int _pointY;

    public Point(int pointX, int pointY) {
        _pointX = pointX;
        _pointY = pointY;
    }
    
    public Point() {
        _pointX = 0;
        _pointY = 0;
    }
}


// ----------

