using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Inputs;
using HUJAM1.Concretes.Inputs;
using UnityEngine;

namespace HUJAM1.Concretes.Movements
{
    public class MonkeyLook : MonoBehaviour
    {

        [SerializeField] private float _lookSpeed;
        [SerializeField] private GameObject _player;
        [SerializeField] private Vector3 _cameraPosition;
        [SerializeField] private Vector3 _cameraRotation;
        private Vector3 _offset;
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
            _offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * _lookSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * -_lookSpeed, Vector3.right) * _offset;
            transform.position = _player.transform.position + _offset;
        }
    }
}