using System.Collections;
using System.Collections.Generic;
using HUJAM1.Concretes.Controllers;
using UnityEngine;

namespace HUJAM1.Concretes.Combats
{
    public class ClampStand : MonoBehaviour
    {
        [SerializeField] private GameObject _player;

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _player.GetComponent<CharacterControllerLvL3>().Health.TakeDamage(20);
                _player.GetComponent<CharacterControllerLvL3>().CurrentHealth = _player.GetComponent<CharacterControllerLvL3>().Health.CurrentHealth; 
            }
        }
    }
}