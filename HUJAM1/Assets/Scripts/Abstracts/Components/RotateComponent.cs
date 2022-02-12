using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Abstracts.Components
{
    public abstract class RotateComponent : MonoBehaviour
    {
        private float _rotateSpeedX;
        private float _rotateSpeedZ;
        
        private void Start()
        {
            _rotateSpeedX = Random.Range(0, 25.0f);
            _rotateSpeedZ = Random.Range(0, 25.0f);
        }
        protected virtual void Update()
        {
            MakeRotation();
        }
        private void MakeRotation()
        {
            transform.Rotate(new Vector3(_rotateSpeedX, transform.rotation.y, _rotateSpeedZ) * Time.deltaTime, Space.Self);
        }
    }
}