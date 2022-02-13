using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Concretes.Movements
{
    public class ScientistArmMovement : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private GameObject _armature;
        [SerializeField] private float _armMoveSpeed;

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
            if (_isOnAttackMode)
                AttackPlayer();
            else
                DontAttackToPlayer();

        }
        private void AttackPlayer()
        {
            _nextRotation = Quaternion.Euler(-180, 90, 0);
            _isOnAttackMode = true;

            _currentRotation = Quaternion.Lerp(_currentRotation, _nextRotation, Time.deltaTime);
            _armature.transform.rotation = _currentRotation;

            Vector3 offset = new Vector3(15 + Mathf.Sin(Time.time) * 2, 5, (Mathf.Cos(Time.time) * 2) - 3);

            Vector3 movePosition = Vector3.Lerp(transform.position, _player.transform.position + offset, Time.deltaTime * _armMoveSpeed);
            this.transform.position = movePosition;

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