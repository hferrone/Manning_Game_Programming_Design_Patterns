using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    private Invoker _invoker;
    private Receiver _receiver;
    private Command _moveUp, _moveDown, _moveLeft, _moveRight, _shoot;

    void Start()
    {
        _invoker = new Invoker();
        _receiver = new Receiver();

        _moveUp = new MoveCommand(_receiver);
        _moveDown = new MoveCommand(_receiver);
        _moveLeft = new MoveCommand(_receiver);
        _moveRight = new MoveCommand(_receiver);
        _shoot = new ShootCommand(_receiver);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            _invoker.Run(_moveUp);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            _invoker.Run(_moveDown);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _invoker.Run(_moveLeft);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _invoker.Run(_moveRight);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _invoker.Run(_shoot);
        }
    }
}