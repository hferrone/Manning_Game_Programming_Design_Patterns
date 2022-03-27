using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Invoker))]
[RequireComponent(typeof(InputListener))]
public class Client : MonoBehaviour
{
    public UnitController receiver;

    private Invoker _invoker;
    private InputListener _inputListener;

    void Awake()
    {
        _invoker = this.GetComponent<Invoker>();
        _inputListener = this.GetComponent<InputListener>();
    }

    void Update()
    {
        var command = _inputListener.GetCoupledCommand();
        if(command != null)
        {
            _invoker.Execute(command);
        }

        var reusableCommand = _inputListener.GetDecoupledCommand();
        if(reusableCommand != null)
        {
            reusableCommand.Execute(receiver);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            _invoker.Undo();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _invoker.Redo();
        }
    }

    void FixedUpdate()
    {
        var reusableCommand = _inputListener.GetDecoupledCommand();
        if (reusableCommand != null)
        {
            reusableCommand.Execute(receiver);
        }
    }
}