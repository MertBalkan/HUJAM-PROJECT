using HUJAM1.Abstracts.Components;
using HUJAM1.Abstracts.Movements;
using UnityEngine;

namespace HUJAM1.Concretes.Movements
{
    public class PropMovement : IMove2D
    {
        private PropController _prop;
        public PropMovement(PropController prop)
        {
            _prop = prop;
        }
        public void Move(float horizontalDir, float verticalDir)
        {
            _prop.transform.Translate(new Vector3(horizontalDir, verticalDir, 0) * Time.deltaTime, Space.World);
        }
    }
}