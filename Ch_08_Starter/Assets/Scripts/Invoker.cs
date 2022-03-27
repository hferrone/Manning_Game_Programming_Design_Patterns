using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker
{
    private Stack<CoupledCommand> _commandStack = new Stack<CoupledCommand>();
    private Stack<CoupledCommand> _redoStack = new Stack<CoupledCommand>();
        
    public void Execute(CoupledCommand newCommand)
    {
        Debug.Log($"{newCommand.ToString()} invoked...");

        _commandStack.Push(newCommand);
        _redoStack.Clear();
        newCommand.Execute();
    }

    public void Undo()
    {
        if(_commandStack.Count > 0)
        {
            var lastCommand = _commandStack.Pop();
            lastCommand.Undo();
            _redoStack.Push(lastCommand);

            Debug.Log("Command undone...");
        }
    }

    public void Redo()
    {
        if (_redoStack.Count > 0)
        {
            var lastCommand = _redoStack.Pop();
            lastCommand.Execute();
            _commandStack.Push(lastCommand);

            Debug.Log("Command redone...");
        }
    }
}