using HUJAM1.Abstracts.Components;
using HUJAM1.Abstracts.Controllers;
using HUJAM1.Abstracts.Inputs;
using HUJAM1.Abstracts.Movements;
using HUJAM1.Concretes.Inputs;
using HUJAM1.Concretes.Movements;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class CharacterController2D : RotateComponent, IEntityController
    {
        [SerializeField] private float _moveSpeed;
        public float MoveSpeed => _moveSpeed;

        private IMove2D _move2D;
        private IInput2D _input2D;

        private void Awake()
        {
            _move2D = new CharacterMove2D(this);
            _input2D = new PCInput2D();
        }
        protected override void Update()
        {
            base.Update();
            _move2D.Move(_input2D.HorizontalMove, _input2D.VerticalMove);
        }
    }
}