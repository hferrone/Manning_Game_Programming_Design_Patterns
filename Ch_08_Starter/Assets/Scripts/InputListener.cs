using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Up, Down, Left, Right, Null
}

public class InputListener : MonoBehaviour
{
    public UnitController player;
    public UnitController ally1;
    public UnitController ally2;
    public int turn = 1;

    private DecoupledCommand _spacebar, _mKey, _bKey;
    private bool _isShooting;
    private UnitController _currentUnit
    {
        get { return GetUnit(); }
    }

    void Start()
    {
        _spacebar = new ShootCommand();
        _mKey = new MeleeCommand();
        _bKey = new BlockCommand();
    }

    public CoupledCommand GetCoupledCommand()
    { 
        if (Input.GetKeyDown(KeyCode.W))
        {
            var targetPosition = ToPosition(Direction.Up);
            return new MoveCommand(_currentUnit, targetPosition);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            var targetPosition = ToPosition(Direction.Down);
            return new MoveCommand(_currentUnit, targetPosition);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            var targetPosition = ToPosition(Direction.Left);
            return new MoveCommand(_currentUnit, targetPosition);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            var targetPosition = ToPosition(Direction.Right);
            return new MoveCommand(_currentUnit, targetPosition);
        }

        return null;
    }

    public DecoupledCommand GetDecoupledCommand()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            return _mKey;
            //_mKey.Execute(playerReceiver);
            //_mKey.Execute(player);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            return _bKey;
            //_bKey.Execute(ally1);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            return _spacebar;
        }

        return null;
    }

    private UnitController GetUnit()
    {
        switch(turn)
        {
            case 1:
                return player;
            case 2:
                return ally1;
            case 3:
                return ally2;
            default:
                return player;
        }
    }

    private Vector3 ToPosition(Direction direction)
    {
        Vector3 position = _currentUnit.transform.position;

        switch (direction)
        {
            case Direction.Up:
                position.z += 1;
                break;
            case Direction.Down:
                position.z -= 1;
                break;
            case Direction.Left:
                position.x -= 1;
                break;
            case Direction.Right:
                position.x += 1;
                break;
        }

        return position;
    }
}