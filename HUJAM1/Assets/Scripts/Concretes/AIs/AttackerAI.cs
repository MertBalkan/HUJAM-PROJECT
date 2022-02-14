using System.Collections;
using System.Collections.Generic;
using HUJAM1.Concretes.Animations;
using HUJAM1.Concretes.Audios;
using HUJAM1.Concretes.Controllers;
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
                this.gameObject.GetComponent<Level3Animation>().PlayAttackAnimation(false);
                _navMeshAgent.destination = _player.transform.position;
            }

            if (Vector3.Distance(_player.transform.position, transform.position) <= _navMeshAgent.stoppingDistance)
            {
                this.gameObject.GetComponent<Level3Animation>().PlayAttackAnimation(true);
                this.transform.LookAt(_player.transform);
            }
        }
    }
}