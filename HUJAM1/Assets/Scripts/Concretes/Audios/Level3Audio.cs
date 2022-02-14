using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Concretes.Audios
{
    public class Level3Audio : MonoBehaviour
    {
        private AudioSource[] _audios;

        private void Awake()
        {
            _audios = GetComponentsInChildren<AudioSource>();
        }

        public void PlayScientistHitSound()
        {
            _audios[0].Play();
        }
        public void PlayDoorOpenSound()
        {
            _audios[1].Play();
        }

    }
}