using HUJAM1.Abstracts.Controllers;
using HUJAM1.Abstracts.Movements;
using UnityEngine;

namespace HUJAM1.Concretes.Movements
{
    public class CharacterMove3D : IMove3D
    {
        private IEntityController _entity;
        public CharacterMove3D(IEntityController entity)
        {
            _entity = entity;
        }
        public void Move(float direction)
        {
            if (direction == 0) return;
            _entity.transform.Translate(Vector3.forward * _entity.MoveSpeed * direction * Time.deltaTime);
        }
    }
}