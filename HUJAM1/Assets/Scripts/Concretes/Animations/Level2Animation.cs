using HUJAM1.Concretes.AIs;
using UnityEngine;

namespace HUJAM1.Concretes.Animations
{
    public class Level2Animation : MonoBehaviour
    {
        private AttackerAI _attacker;
        private void Awake()
        {
            _attacker = FindObjectOfType<AttackerAI>();
            if (_attacker == null) return;
        }
        //---------------------------LEVEL 3---------------------------
        public void PlayAttackAnimation(bool onAttack)
        {
            if (_attacker == null) return;
            _attacker.GetComponent<Animator>().SetBool("onAttack", onAttack);
        }
    }
}