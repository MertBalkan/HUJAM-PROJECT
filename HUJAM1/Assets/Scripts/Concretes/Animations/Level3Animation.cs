using HUJAM1.Concretes.AIs;
using HUJAM1.Concretes.Audios;
using UnityEngine;

namespace HUJAM1.Concretes.Animations
{
    public class Level3Animation : MonoBehaviour
    {
        private AttackerAI _attacker;
        private PaniclyWalkingScientistAI _panic;
        private Level3Audio _audio;
        private void Awake()
        {
            _audio = FindObjectOfType<Level3Audio>();
            _attacker = FindObjectOfType<AttackerAI>();
            _panic = GetComponent<PaniclyWalkingScientistAI>();
            if (_attacker == null) return;
        }
        //---------------------------LEVEL 3---------------------------
        public void PlayAttackAnimation(bool onAttack)
        {
            if (_attacker == null) return;
            _audio.PlayScientistHitSound();
            _attacker.GetComponent<Animator>().SetBool("onAttack", onAttack);
        }

        public void PlayTerrifiedAnimation(bool isTerrified)
        {
            _panic.GetComponent<Animator>().SetBool("isTerrified", isTerrified);
        }
    }
}