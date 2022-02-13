using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Animations;
using HUJAM1.Abstracts.Controllers;
using HUJAM1.Abstracts.Inputs;
using HUJAM1.Abstracts.Movements;
using HUJAM1.Concretes.Animations;
using HUJAM1.Concretes.Inputs;
using HUJAM1.Concretes.Movements;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class CharacterController3D : MonoBehaviour, IEntityController
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _rotateSpeed;
        public float MoveSpeed => _moveSpeed;

        private IInput2D _input;
        private IMove3D _move;
        private IAnimation _animation;

        private void Awake()
        {
            _input = new PCInput2D();
            _move = new CharacterMove3D(this);
            _animation = new Lvl2CharAnim(this);
        }
        private void Update()
        {
            _move.Move(_input.HorizontalMove, _input.VerticalMove);
            _animation.WalkAnimation(_input.HorizontalMove, _input.VerticalMove);
            Turn();

        }
        private void Turn()
        {
            Vector3 rotateVector = _input.VerticalMove > 0 ?
                Vector3.up * Time.deltaTime * -_rotateSpeed :
                Vector3.up * Time.deltaTime * _rotateSpeed;
            transform.Rotate(rotateVector);
        }
    }
}