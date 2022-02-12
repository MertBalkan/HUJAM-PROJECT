using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip _backgroundMusic;
    [SerializeField] private AudioClip _pickupAudio;

    /// <summary>
    /// You must assign audio clips orderly to the child objects.
    /// </summary>
    private AudioSource[] _audios;

    private void Awake()
    {
        _audios = GetComponentsInChildren<AudioSource>();
    }

    private void Update()
    {
    }
}
