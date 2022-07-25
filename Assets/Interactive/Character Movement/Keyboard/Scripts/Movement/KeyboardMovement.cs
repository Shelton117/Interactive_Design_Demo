using UnityEngine;

namespace Interactive.Character_Movement.Keyboard.Scripts.Movement
{
    /// <summary>
    /// ¼üÅÌ¿ØÖÆ½ÇÉ«ÒÆ¶¯
    /// </summary>
    public class KeyboardMovement : MonoBehaviour
    {
        [SerializeField] private float mMoveSpeed = 5.0f;
        [SerializeField] private float jumpSpeed = 5.0f;
        [SerializeField] private float gravity = 10.0F;
        private Vector3 moveDirection = Vector3.zero;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //if (Input.GetKeyDown(KeyCode.W))
            //{

            //}

            //if (Input.GetKeyDown(KeyCode.S))
            //{

            //}

            //if (Input.GetKeyDown(KeyCode.A))
            //{

            //}

            //if (Input.GetKeyDown(KeyCode.D))
            //{

            //}

            CharacterController controller = GetComponent<CharacterController>();
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= mMoveSpeed;
                if (Input.GetButton("Jump"))
                {
                    moveDirection.y = jumpSpeed;
                }
            }

            moveDirection.y -= gravity * Time.deltaTime;

            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}