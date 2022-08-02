using UnityEngine;

namespace Interactive.Character_Movement.Keyboard.Scripts.Movement.command_mode
{
    public class InputHandler : MonoBehaviour
    {
        private readonly MoveForward mMoveForward = new MoveForward();
        private readonly MoveBack mMoveBack = new MoveBack();
        private readonly MoveLeft mMoveLeft = new MoveLeft();
        private readonly MoveRight mMoveRight = new MoveRight();

        private GameObject mPlayer;
        private KeyCode[] mKeyCodes;

        // Start is called before the first frame update
        void Start()
        {
            mPlayer = GameObject.Find("Player");
            mKeyCodes = new[]
            {
                KeyCode.W,
                KeyCode.A,
                KeyCode.S,
                KeyCode.D
            }; // 键位自定义时修改该数组即可
        }

        // Update is called once per frame
        void Update()
        {
            PlayerInputHandler();

            if (Input.GetKeyDown(KeyCode.B))
            {
                StartCoroutine(CommandManager.Instance.UndoStart());
            }
        }

        private void PlayerInputHandler()
        {
            if (Input.GetKeyDown(mKeyCodes[0]))
            {
                mMoveForward.Execute(mPlayer);
                CommandManager.Instance.AddCommands(mMoveForward);
            }

            if (Input.GetKeyDown(mKeyCodes[1]))
            {
                mMoveLeft.Execute(mPlayer);
                CommandManager.Instance.AddCommands(mMoveLeft);
            }

            if (Input.GetKeyDown(mKeyCodes[2]))
            {
                mMoveBack.Execute(mPlayer);
                CommandManager.Instance.AddCommands(mMoveBack);
            }

            if (Input.GetKeyDown(mKeyCodes[3]))
            {
                mMoveRight.Execute(mPlayer);
                CommandManager.Instance.AddCommands(mMoveRight);
            }
        }
    }

}
