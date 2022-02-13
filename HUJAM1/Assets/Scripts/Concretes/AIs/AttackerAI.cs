using System.Collections;
using System.Collections.Generic;
using HUJAM1.Concretes.Managers;
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
        private void Update()
        {
            if (Vector3.Distance(_player.transform.position, transform.position) >= _navMeshAgent.stoppingDistance)
            {
                AnimationManager.Instance.PlayAttackAnimation(false);
                _navMeshAgent.destination = _player.transform.position;
                this.transform.LookAt(_player.transform);
            }

            if (Vector3.Distance(_player.transform.position, transform.position) <= _navMeshAgent.stoppingDistance)
            {
                AnimationManager.Instance.PlayAttackAnimation(true);
                this.transform.LookAt(_player.transform);
            }
        }
    }
}