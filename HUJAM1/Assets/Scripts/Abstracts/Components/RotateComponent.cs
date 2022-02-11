using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Abstracts.Components
{
    public abstract class RotateComponent
    {
        private float _rotateSpeedX;
        private float _rotateSpeedY;
        private float _rotateSpeedZ;

        private void OnEnable()
        {
            _rotateSpeedX = Random.Range(0, 25.0f);
            _rotateSpeedY = Random.Range(0, 25.0f);
            _rotateSpeedZ = Random.Range(0, 25.0f);
        }
        private void Update()
        {
            MakeRotation();
        }
        void MakeRotation()
        {
            transform.Rotate(new Vector3(_rotateSpeedX, _rotateSpeedY, _rotateSpeedZ), Space.World);
        }
    }
}