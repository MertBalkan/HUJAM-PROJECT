using System.Collections;
using System.Collections.Generic;
using HUJAM1.Concretes.Controllers;
using UnityEngine;

namespace HUJAM1.Concretes.Combats
{
    public class MonkeCombat : MonoBehaviour
    {
        private MonkeyController _monke;
        private bool _attack;

        private void Awake()
        {
            _monke = GetComponent<MonkeyController>();
        }
        private void Update()
        {
            if (_monke.Input.ThrowTube && _monke.CanThrowable.CanTubeThrowable)
            {
                _attack = true;
            }
        }
        private void FixedUpdate()
        {
            if (_attack)
            {
                Attack();
            }
        }
        private void Attack()// MONKE KAWGA DOWUSMEWKK
        {
            _monke.TubeObj.GetComponent<Rigidbody>().isKinematic = false;
            _monke.TubeObj.GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * 1000.0f);
        }
    }
}