using UnityEngine;
using UnityEngine.EventSystems;

namespace Interactive.Character_Movement.Mobile.Scripts
{
    public class JoyStick : MonoBehaviour, IDragHandler, IEndDragHandler
    {
        [SerializeField] private float moveRadius;
        [SerializeField] private float moveSpeed = 10f;
        private Vector3 initalPos;
        private PlayerController playerController;

        private void Awake()
        {
            initalPos = transform.position;
            // moveRadius = gameObject.GetComponentInParent<RectTransform>().rect.width * 0.5f;
            playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        public void OnDrag(PointerEventData eventData)
        {
            OnDrapType();
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            transform.position = initalPos;
            playerController.playerMoveDir = Vector3.zero; // ֹͣ�ƶ�
        }

        private void OnDrapType()
        {
            // ������ָ��Բ�ĵľ���
            float distance = Vector3.Distance(initalPos, Input.mousePosition);
            // ������꣨��ָ���Բ�ģ�
            Vector3 dir = Input.mousePosition - initalPos;
            // ��Ŀ��λ�ô���player
            playerController.playerMoveDir = new Vector3(dir.x, 0, dir.y);

            // UI��Ҫ����
            if (distance < moveRadius)
            {
                transform.position = Input.mousePosition;
            }
            else
            {
                transform.position = dir.normalized * moveRadius + initalPos;
            }
        }
    }
}