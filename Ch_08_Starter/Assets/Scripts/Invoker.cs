using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker
{
    public void Run(Command command)
    {
        Debug.Log($"{command.ToString()} invoked...");
        command.Run();
    }
}