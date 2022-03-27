using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public UnitController playerReceiver;
    public UnitController ally1;
    public UnitController ally2;

    private Invoker _invoker;

    private DecoupledCommand _spacebar, _mKey, _bKey;
    private CoupledCommand _wKey, _sKey, _aKey, _dKey;

    private bool _isShooting;
    private bool _isJumping;

    void Start()
    {
        _invoker = new Invoker();

        _spacebar = new ShootCommand();
        _mKey = new MeleeCommand();
        _bKey = new BlockCommand();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            _wKey = new MoveCommand(playerReceiver, Direction.Up);
            _invoker.Execute(_wKey);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            _sKey = new MoveCommand(playerReceiver, Direction.Down);
            _invoker.Execute(_sKey);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _aKey = new MoveCommand(playerReceiver, Direction.Left);
            _invoker.Execute(_aKey);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _dKey = new MoveCommand(playerReceiver, Direction.Right);
            _invoker.Execute(_dKey);
        }

        if(Input.GetKeyDown(KeyCode.U))
        {
            _invoker.Undo();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            _invoker.Redo();
        }

        if(Input.GetKeyUp(KeyCode.M))
        {
            //_mKey.Execute(playerReceiver);
            _mKey.Execute(playerReceiver);
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            _bKey.Execute(ally1);
        }

        _isShooting |= Input.GetKeyDown(KeyCode.Space);
    }

    void FixedUpdate()
    {
        if (_isShooting)
        {
            _spacebar.Execute(ally2);
            //_spacebar.Execute(allyReceiver);
        }

        _isShooting = false;
    }
}