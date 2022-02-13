using HUJAM1.Concretes.AIs;
using UnityEngine;

namespace HUJAM1.Concretes.Animations
{
    public class Level3Animation : MonoBehaviour
    {
        private AttackerAI _attacker;
        private PaniclyWalkingScientistAI _panic;
        private void Awake()
        {
            _attacker = FindObjectOfType<AttackerAI>();
            _panic = GetComponent<PaniclyWalkingScientistAI>();
            if (_attacker == null) return;
        }
        //---------------------------LEVEL 3---------------------------
        public void PlayAttackAnimation(bool onAttack)
        {
            if (_attacker == null) return;
            _attacker.GetComponent<Animator>().SetBool("onAttack", onAttack);
        }

        public void PlayTerrifiedAnimation(bool isTerrified)
        {
            _panic.GetComponent<Animator>().SetBool("isTerrified", isTerrified);
        }
    }
}