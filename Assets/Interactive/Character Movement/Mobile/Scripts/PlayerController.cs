using UnityEngine;

namespace Interactive.Character_Movement.Mobile.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [HideInInspector] public Vector3 playerMoveDir;
        [SerializeField] private float moveSpeed;

        // Update is called once per frame
        void Update()
        {
            if (playerMoveDir == Vector3.zero) return;

            transform.position += playerMoveDir.normalized * moveSpeed * Time.deltaTime;
            // ����Ŀ�귽��
            transform.LookAt(playerMoveDir);
        }
    }
}