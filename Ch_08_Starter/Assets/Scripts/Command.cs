using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command 
{
    protected Receiver receiver;

    public Command(Receiver receiver)
    {
        this.receiver = receiver;
    }

    public abstract void Run();
}

public class MoveCommand : Command
{
    public MoveCommand(Receiver receiver) : base(receiver) { }

    public override void Run()
    {
        Debug.Log("Receiver notified...");
        receiver.Move();
    }
}

public class ShootCommand : Command
{
    public ShootCommand(Receiver receiver) : base(receiver) { }

    public override void Run()
    {
        Debug.Log("Receiver notified...");
        receiver.Shoot();
    }
}