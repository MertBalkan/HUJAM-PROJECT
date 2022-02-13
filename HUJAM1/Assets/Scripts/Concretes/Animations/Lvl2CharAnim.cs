using HUJAM1.Abstracts.Animations;
using HUJAM1.Abstracts.Controllers;
using UnityEngine;

namespace HUJAM1.Concretes.Animations
{
    public class Lvl2CharAnim : IAnimation
    {
        private IEntityController _entity;
        public Lvl2CharAnim(IEntityController entity)
        {
            _entity = entity;
        }

        public void IsRunning(bool run)
        {
            _entity.transform.GetComponent<Animator>().SetBool("isRunning", run);
        }

        public void WalkAnimation(float horDirection, float verDirection)
        {
            horDirection = Mathf.Abs(horDirection);
            verDirection = Mathf.Abs(verDirection);
            _entity.transform.GetComponent<Animator>().SetFloat("direction", horDirection != 0 || verDirection == 0 ? horDirection : verDirection);
        }
    }
}