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

        private void Awake()
        {
            _anim = new Lvl2CharAnim(this);
            _input = new PCInput2D();
            _move = GetComponentInParent<MoveBehaviour>();
        }

        private void Update()
        {
            _anim.WalkAnimation(_input.HorizontalMove, _input.VerticalMove);

            if (_input.PressRunButton)
            {
                _anim.IsRunning(true);
                _move.walkSpeed = 2.0f;
            }
            if (_input.ReleaseRunButton)
            {
                _anim.IsRunning(false);
                _move.walkSpeed = 0.11f;
            }
        }

    }
}