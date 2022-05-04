using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallbackCommand
{
    public delegate void Callback(UnitController receiver);

    public Callback Execute { get; private set; }
    public Callback Undo { get; private set; }

    private Vector3 _startingPos;
    private Vector3 _endingPos;

    public CallbackCommand(Callback execute, Callback undo)    
    {
        Execute = execute;
        Undo = undo;
    }
}