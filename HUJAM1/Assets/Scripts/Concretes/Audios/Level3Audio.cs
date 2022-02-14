using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Concretes.Audios
{
    public class Level3Audio : MonoBehaviour
    {
        [SerializeField] private AudioClip _doorClip;
        [SerializeField] private AudioSource _doorOpenSoundAS;
        [SerializeField] private AudioSource _scientistHitSoundAS;
        private void Start()
        {
            _doorOpenSoundAS.playOnAwake = false;
        }

        public void PlayScientistHitSound()
        {
            if (!_scientistHitSoundAS.isPlaying) return;
            _scientistHitSoundAS.Play();
        }
        public void PlayDoorOpenSound()
        {
            if (_doorOpenSoundAS.isPlaying) return;
            _doorOpenSoundAS.Play();
        }

    }
}