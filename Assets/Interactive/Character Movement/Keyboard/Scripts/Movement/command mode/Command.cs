using UnityEngine;

namespace Interactive.Character_Movement.Keyboard.Scripts.Movement.command_mode
{
    public abstract class Command
    {
        public abstract void Execute(GameObject player);
        public abstract void Undo();
    }
}