using UnityEngine;

namespace HUJAM1.Concretes.Movements
{
    public class ScientistArmMovement : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private float _armMoveSpeed;

        private void Update()
        {
            MoveToThePlayer();
        }
        private void MoveToThePlayer()
        {
            Vector3 offset = Vector3.zero;
            Vector3 movePosition = Vector3.Lerp(transform.position, _player.transform.position + new Vector3(10, 5, 0), Time.deltaTime * _armMoveSpeed);
            this.transform.position = movePosition;
        }
    }
}