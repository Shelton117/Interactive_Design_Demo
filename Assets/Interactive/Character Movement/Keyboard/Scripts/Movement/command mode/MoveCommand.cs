using UnityEngine;

namespace Interactive.Character_Movement.Keyboard.Scripts.Movement.command_mode
{
    public class MoveForward : Command
    {
        private GameObject mPlayer;

        public override void Execute(GameObject player)
        {
            mPlayer = player;
            mPlayer.transform.Translate(Vector3.forward);
        }

        public override void Undo()
        {
            mPlayer.transform.Translate(Vector3.back);
        }
    }

    public class MoveBack : Command
    {
        private GameObject mPlayer;

        public override void Execute(GameObject player)
        {
            mPlayer = player;
            mPlayer.transform.Translate(Vector3.back);
        }

        public override void Undo()
        {
            mPlayer.transform.Translate(Vector3.forward);
        }
    }

    public class MoveLeft : Command
    {
        private GameObject mPlayer;

        public override void Execute(GameObject player)
        {
            mPlayer = player;
            mPlayer.transform.Translate(Vector3.left);
        }

        public override void Undo()
        {
            mPlayer.transform.Translate(Vector3.right);
        }
    }

    public class MoveRight : Command
    {
        private GameObject mPlayer;

        public override void Execute(GameObject player)
        {
            mPlayer = player;
            mPlayer.transform.Translate(Vector3.right);
        }

        public override void Undo()
        {
            mPlayer.transform.Translate(Vector3.left);
        }
    }
}
