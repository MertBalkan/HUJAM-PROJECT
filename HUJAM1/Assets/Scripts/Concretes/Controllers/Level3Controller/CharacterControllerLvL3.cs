using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Animations;
using HUJAM1.Abstracts.Combats;
using HUJAM1.Abstracts.Controllers;
using HUJAM1.Abstracts.Inputs;
using HUJAM1.Concretes.Animations;
using HUJAM1.Concretes.Combats;
using HUJAM1.Concretes.Inputs;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class CharacterControllerLvL3 : MonoBehaviour, IEntityController
    {
        [SerializeField] private float _currentHealth;
        private IInput2D _input;
        private IAnimation _anim;
        private MoveBehaviour _move;
        private bool _canRun = true;
        private IHealth _health;

        public float MoveSpeed => throw new System.NotImplementedException();

        public MoveBehaviour Move { get => _move; set => _move = value; }
        public bool CanRun { get => _canRun; set => _canRun = value; }
        public IHealth Health { get => _health; set => _health = value; }
        public float CurrentHealth { get => _currentHealth; set => _currentHealth = value; }

        private void Awake()
        {
            _anim = new Lvl2CharAnim(this);
            _input = new PCInput2D();
            Health = new HealthSystem(CurrentHealth);
            Move = GetComponentInParent<MoveBehaviour>();
        }

        private void Update()
        {
            if (_health.IsDead)
            {
                GameManager.Instance.LoadSelfScene();
            }
            _anim.WalkAnimation(_input.HorizontalMove, _input.VerticalMove);

            if (_input.PressRunButton && _canRun)
            {
                _anim.IsRunning(true);
                Move.walkSpeed = 1.0f;
            }
            if (_input.ReleaseRunButton)
            {
                _anim.IsRunning(false);
                Move.walkSpeed = 0.11f;
            }
        }

    }
}