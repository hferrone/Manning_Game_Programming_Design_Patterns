using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CoupledCommand 
{
    protected Receiver receiver;

    public CoupledCommand(Receiver receiver)
    {
        this.receiver = receiver;
    }

    public abstract void Execute();
    public abstract void Undo();
}

public class MoveCommand : CoupledCommand
{
    private Direction direction;

    public MoveCommand(Receiver receiver, Direction direction) : base(receiver)
    {
        this.direction = direction;
    }

    public override void Execute()
    {
        receiver.Move(direction);
    }

    public override void Undo()
    {
        receiver.Move(Utilities.ReversedDirection(direction));
    }
}

public abstract class DecoupledCommand
{
    public abstract void Execute(Receiver receiver);
}

public class ShootCommand : DecoupledCommand
{
    public override void Execute(Receiver receiver)
    {
        Debug.Log("Receiver notified...");
        receiver.Shoot();
    }
}

public class MeleeCommand : DecoupledCommand
{
    public override void Execute(Receiver receiver)
    {
        Debug.Log("Receiver notified...");
        receiver.Melee();
    }
}

public class BlockCommand : DecoupledCommand
{
    public override void Execute(Receiver receiver)
    {
        Debug.Log("Receiver notified...");
        receiver.Block();
    }
}