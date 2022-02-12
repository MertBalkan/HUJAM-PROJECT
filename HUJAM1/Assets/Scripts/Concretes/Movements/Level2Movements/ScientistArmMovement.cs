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
        private bool _isOnAttackMode = true;
        private bool _canDropsVisible = true;
        public bool CanDropsVisible { get => _canDropsVisible; set => _canDropsVisible = value; }

        private void Update()
        {
            AttackPlayer();
            // if (_isOnAttackMode)
            // else
            //     DontAttackToPlayer();

        }
        private void AttackPlayer()
        {
            Vector3 offset = new Vector3(10 + Mathf.Sin(Time.time) * 2, 5, (Mathf.Cos(Time.time) * 2) - 3);

            Vector3 movePosition = Vector3.Lerp(transform.position, _player.transform.position + offset, Time.deltaTime * _armMoveSpeed);
            this.transform.position = movePosition;

            StartCoroutine(BreathTime());
        }
        private void DontAttackToPlayer()
        {
            // Quaternion currentRotation = _armature.transform.rotation;
            // Quaternion whichRotation = Quaternion.Euler(0, 0, -90);

            _isOnAttackMode = false;

            // currentRotation = Quaternion.Lerp(currentRotation, whichRotation, Time.deltaTime);
            // _armature.transform.rotation = currentRotation;

            StartCoroutine(ExitBreathTime());
        }

        private IEnumerator BreathTime()
        {
            _canDropsVisible = true;
            yield return new WaitForSeconds(3.0f);
            _isOnAttackMode = false;
        }
        private IEnumerator ExitBreathTime()
        {
            _canDropsVisible = false;
            yield return new WaitForSeconds(3.0f);
            _isOnAttackMode = true;
        }
    }
}