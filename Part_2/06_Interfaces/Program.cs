// A class can have only one base class but can implement many interfaces.
// The interface type defines an object’s interface or boundary by listing the methods, properties, etc., that an object must have without supplying any behavior for them. 
// You could also think of an interface as defining a specific role or responsibility in the system without providing the code to make it happen.

Robot robot = new Robot();

Console.WriteLine("Enter 3 Commands: (on, off, north, south, east, west)");
for (int i = 0; i < robot.Commands.Length; i++)
{
    string commands = Console.ReadLine().ToLower();
    IRobotCommand newCommand = commands switch 
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "east" => new EastCommand(),
        "south" => new SouthCommand(),
        "west" => new WestCommand(),
    };
    robot.Commands[i] = newCommand;
}

robot.Run();

public class OnCommand : IRobotCommand
{
    public void Run(Robot robot) => robot.IsPowered = true;
}

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot) => robot.IsPowered = false;
}

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) robot.Y += 1; }
}

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) robot.Y -= 1; }
}

public class EastCommand : IRobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) robot.X += 1; }
}

public class WestCommand : IRobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) robot.X -= 1; }
}

    public interface IRobotCommand
{
       void Run(Robot robot);
}

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3]; public void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
        command?.Run(this);
        Console.WriteLine($"[{X} {Y} {IsPowered}]"); }
    }
}