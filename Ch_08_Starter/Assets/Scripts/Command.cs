using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CoupledCommand 
{
    protected UnitController receiver;

    public CoupledCommand(UnitController receiver)
    {
        this.receiver = receiver;
    }

    public abstract void Execute();
    public abstract void Undo();
}

public class MoveCommand : CoupledCommand
{
    private Vector3 _startingPos;
    private Vector3 _endingPos;

    public MoveCommand(UnitController receiver, Vector3 endPos) : base(receiver)
    {
        this._endingPos = endPos;
    }

    public override void Execute()
    {
        _startingPos = receiver.transform.position;
        receiver.Move(_endingPos);
    }

    public override void Undo()
    {
        receiver.Move(_startingPos);
    }
}

public abstract class DecoupledCommand
{
    public abstract void Execute(UnitController receiver);
}

public class ShootCommand : DecoupledCommand
{
    public override void Execute(UnitController receiver)
    {
        Debug.Log("Receiver notified...");
        receiver.Shoot();
    }
}

public class MeleeCommand : DecoupledCommand
{
    public override void Execute(UnitController receiver)
    {
        Debug.Log("Receiver notified...");
        receiver.Melee();
    }
}

public class BlockCommand : DecoupledCommand
{
    public override void Execute(UnitController receiver)
    {
        Debug.Log("Receiver notified...");
        receiver.Block();
    }
}