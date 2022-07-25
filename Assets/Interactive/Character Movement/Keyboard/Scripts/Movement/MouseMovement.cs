using UnityEngine;
using UnityEngine.AI;

namespace Interactive.Character_Movement.Keyboard.Scripts.Movement
{
    /// <summary>
    /// 鼠标控制角色移动
    /// </summary>
    public class MouseMovement : MonoBehaviour
    {
        [SerializeField] private Transform mTransform;

        [SerializeField] private NavMeshAgent mAgent;

        // Start is called before the first frame update
        void Start()
        {
            mTransform = transform;
            mAgent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                RaycastHit hit;

                GetComponent<CharacterController>().enabled = false;

                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
                {
                    Debug.DrawRay(Camera.main.transform.position, hit.point);
                    mAgent.destination = hit.point;
                }
            }
            else
            {
                GetComponent<CharacterController>().enabled = true;
            }
        }
    }
}