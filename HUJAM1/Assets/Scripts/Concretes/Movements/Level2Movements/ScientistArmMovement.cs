using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Concretes.Movements
{
    public class ScientistArmMovement : MonoBehaviour
    {
        [Header("PLAYER")]
        [SerializeField] private GameObject _player;
        [Header("ARMATURE")]
        [SerializeField] private GameObject _armature;
        [Header("MOVEMENT")]
        [SerializeField] private float _armMoveSpeed;
        [Space(20)]
        [Header("Kankam asagidaki kisimda offseti degistirebilirsin ya da ek carpim katsayisi vererek de degistirebilirsin")]
        [Header("OFFSET OPTIONS FOR ARM")]
        [SerializeField] private Vector3 _addiotinalOffset;
        [SerializeField] private Vector3 _addiotinalMultiply;

        private Quaternion _currentRotation;
        private Quaternion _nextRotation;

        private bool _isOnAttackMode = true;
        private bool _canDropsVisible = true;

        public bool CanDropsVisible { get => _canDropsVisible; set => _canDropsVisible = value; }
        private void Start()
        {
            _currentRotation = Quaternion.Euler(-180, 90, 0); //attack
            // _currentRotation = Quaternion.Euler(-90, 90, 0); //breath
            _armature.transform.rotation = _currentRotation;
        }
        private void Update()
        {

            Vector3 totalOffset = new Vector3
            (
                _addiotinalOffset.x + Mathf.Sin(Time.time) * _addiotinalMultiply.x,
                _addiotinalOffset.y * _addiotinalMultiply.y,
                (Mathf.Cos(Time.time) * _addiotinalMultiply.z) - _addiotinalOffset.z
             );

            Vector3 movePosition = Vector3.Lerp(transform.position, _player.transform.position + totalOffset, Time.deltaTime * _armMoveSpeed);
            this.transform.position = movePosition;


            if (_isOnAttackMode)
                AttackPlayer();
            else
                DontAttackToPlayer();

        }
        private void AttackPlayer()
        {
            _nextRotation = Quaternion.Euler(-180, 90, 0);
            _isOnAttackMode = true; 
            Vector3 totalOffset = new Vector3
           (
               _addiotinalOffset.x + Mathf.Sin(Time.time) * _addiotinalMultiply.x,
               _addiotinalOffset.y * _addiotinalMultiply.y,
               (Mathf.Cos(Time.time) * _addiotinalMultiply.z) - _addiotinalOffset.z
            );

            Vector3 movePosition = Vector3.Lerp(transform.position, _player.transform.position + totalOffset, Time.deltaTime * _armMoveSpeed);
            this.transform.position = movePosition;

            _currentRotation = Quaternion.Lerp(_currentRotation, _nextRotation, Time.deltaTime);
            _armature.transform.rotation = _currentRotation;

            StartCoroutine(BreathTime());
        }
        private void DontAttackToPlayer()
        {
            _nextRotation = Quaternion.Euler(-90, 90, 0);
            _isOnAttackMode = false;

            _currentRotation = Quaternion.Lerp(_currentRotation, _nextRotation, Time.deltaTime);
            _armature.transform.rotation = _currentRotation;

            StartCoroutine(ExitBreathTime());
        }

        private IEnumerator BreathTime()
        {
            _canDropsVisible = true;
            yield return new WaitForSeconds(2.0f);
            _isOnAttackMode = false;
        }
        private IEnumerator ExitBreathTime()
        {
            _canDropsVisible = false;
            yield return new WaitForSeconds(2.0f);
            _isOnAttackMode = true;
        }
    }
}