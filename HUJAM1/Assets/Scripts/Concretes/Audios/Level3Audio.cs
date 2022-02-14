using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Concretes.Audios
{
    public class Level3Audio : MonoBehaviour
    {
        [SerializeField] private AudioSource _scientistHitSoundAS;

        public void PlayScientistHitSound()
        {
            if (!_scientistHitSoundAS.isPlaying) return;
            _scientistHitSoundAS.Play();
        }

    }
}