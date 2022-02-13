using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace HUJAM1.Concretes.AIs
{
    public class AttackerAI : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        private NavMeshAgent _navMeshAgent;
        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }
        private void FixedUpdate()
        {
            if (Vector3.Distance(_player.transform.position, transform.position) >= _navMeshAgent.stoppingDistance)
            {
                _navMeshAgent.destination = _player.transform.position;
            }

            if (_navMeshAgent.velocity == Vector3.zero)
            {
                // Attack Animation
            }
            else
            {
                // Walk Animation
            }

        }
    }
}