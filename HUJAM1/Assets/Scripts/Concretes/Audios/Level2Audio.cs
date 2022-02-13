using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Concretes.Audios
{
    public class Level2Audio : MonoBehaviour
    {

        // [SerializeField] private AudioClip _scientistGrumbleSound;

        private AudioSource[] _audios;

        private void Awake()
        {
            _audios = GetComponentsInChildren<AudioSource>();
        }

        public void PlayFluidTouchGroundSound()
        {
            _audios[0].Play();
        }
        public void PlayCharacterMoveSound()
        {
            _audios[1].Play();
        }

    }
}