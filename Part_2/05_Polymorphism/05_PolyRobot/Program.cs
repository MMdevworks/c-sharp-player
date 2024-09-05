Robot robot = new Robot();

Console.WriteLine("Enter 3 Commands: (on, off, north, south, east, west)");
for (int i = 0; i < robot.Commands.Length; i++)
{
    string commands = Console.ReadLine().ToLower();
    RobotCommand newCommand = commands switch 
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

public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (!robot.IsPowered)
            robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y += 1;
        }
    }
}
public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y -= 1;
        }
    }
}
public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X += 1;
        }
    }
}
public class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X -= 1;
        }
    }
}

public abstract class RobotCommand
{
       public abstract void Run(Robot robot);
}

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3]; public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
        command?.Run(this);
        Console.WriteLine($"[{X} {Y} {IsPowered}]"); }
    }
}
