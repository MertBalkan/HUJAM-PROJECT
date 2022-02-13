using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Animations;
using HUJAM1.Abstracts.Controllers;
using HUJAM1.Abstracts.Inputs;
using HUJAM1.Concretes.Animations;
using HUJAM1.Concretes.Inputs;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class CharacterControllerLvL3 : MonoBehaviour, IEntityController
    {
        private IInput2D _input;
        private IAnimation _anim;
        private MoveBehaviour _move;

        public float MoveSpeed => throw new System.NotImplementedException();

        public MoveBehaviour Move { get => _move; set => _move = value; }

        private void Awake()
        {
            _anim = new Lvl2CharAnim(this);
            _input = new PCInput2D();
            Move = GetComponentInParent<MoveBehaviour>();
        }

        private void Update()
        {
            _anim.WalkAnimation(_input.HorizontalMove, _input.VerticalMove);
            Debug.Log(Move);
            if (_input.PressRunButton)
            {
                _anim.IsRunning(true);
                Move.walkSpeed = 10.0f;
            }
            if (_input.ReleaseRunButton)
            {
                _anim.IsRunning(false);
                Move.walkSpeed = 0.11f;
            }
        }

    }
}