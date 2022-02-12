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
        public void Move(float horizontalDir, float verticalDir)
        {
            if (horizontalDir == 0 && verticalDir == 0) return;
            _entity.transform.Translate(new Vector3(horizontalDir, 0, verticalDir) * Time.deltaTime * _entity.MoveSpeed, Space.World);
        }
    }
}