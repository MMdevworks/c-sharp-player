Robot robot = new Robot();
robot.Commands[0] = new OnCommand();
robot.Commands[1] = new NorthCommand();
robot.Commands[2] = new WestCommand();
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
