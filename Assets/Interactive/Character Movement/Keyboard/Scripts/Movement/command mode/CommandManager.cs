using System.Collections;
using System.Collections.Generic;
using Interactive.Character_Movement.Keyboard.Scripts.Movement.command_mode;
using Scripts.Utilities;
using UnityEngine;

public class CommandManager : Singleton<CommandManager>
{
    private readonly List<Command> mCommands = new List<Command>();

    public void AddCommands(Command command)
    {
        mCommands.Add(command);
    }

    public IEnumerator UndoStart()
    {
        mCommands.Reverse();

        foreach (var command in mCommands)
        {
            yield return new WaitForSeconds(0.2f);
            command.Undo();
        }

        mCommands.Clear();
    }
}