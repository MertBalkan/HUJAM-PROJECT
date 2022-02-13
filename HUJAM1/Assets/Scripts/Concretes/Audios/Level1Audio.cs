using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Concretes.Audios
{
    public class Level1Audio : MonoBehaviour
    {
        //[SerializeField] private AudioClip _backgroundMusic; Background will be keep playing so i dont need to assign this right now.

        /// <summary>
        /// You must assign audio clips orderly to the child objects.
        /// </summary>
        private AudioSource[] _audios;

        private void Awake()
        {
            _audios = GetComponentsInChildren<AudioSource>();
        }

        public void PlayPickupAudio()
        {
            _audios[0].Play();
        }
    }
}