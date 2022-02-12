using HUJAM1.Abstracts.Controllers;
using HUJAM1.Abstracts.Inputs;
using HUJAM1.Abstracts.Movements;
using HUJAM1.Concretes.Inputs;
using HUJAM1.Concretes.Movements;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class MonkeyController : MonoBehaviour, IEntityController
    {
        [SerializeField] private float _lookSpeed;
        [SerializeField] private GameObject _player;
        [SerializeField] private Vector3 _cameraPosition;
        [SerializeField] private Vector3 _cameraRotation;
        private Vector3 _offset;
        [SerializeField] private float _moveSpeed;
        private IMove3D _move;
        private IInput2D _input;

        public float MoveSpeed => _moveSpeed;

        private void Awake()
        {
            _move = new CharacterMove3D(this);
            _input = new PCInput2D();
        }
        private void Start()
        {
            _offset = new Vector3
            (
                _player.transform.position.x + _cameraPosition.x,
                _player.transform.position.y + _cameraPosition.y,
                _player.transform.position.z + _cameraPosition.z
            );
            transform.rotation = Quaternion.Euler(_cameraRotation.x, _cameraRotation.y, _cameraRotation.z);
        }
        private void Update()
        {
            _move.Move(_input.HorizontalMove, _input.VerticalMove);
            _offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * _lookSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * -_lookSpeed, Vector3.right) * _offset;
            transform.position = _player.transform.position + _offset;
        }
    }
}