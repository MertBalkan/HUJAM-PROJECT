using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Combats;
using UnityEngine;

namespace HUJAM1.Concretes.Combats
{
    public class HealthSystem : MonoBehaviour, IHealth
    {

        private float _currentHealth;
        public bool IsDead => _currentHealth <= 0;
        public float CurrentHealth => _currentHealth;

        public HealthSystem(float currentHealth)
        {
            _currentHealth = currentHealth;
        }

        public void TakeDamage(float damageCount)
        {
            if (IsDead) return;
            if (!IsDead) _currentHealth -= damageCount;
        }
    }
}