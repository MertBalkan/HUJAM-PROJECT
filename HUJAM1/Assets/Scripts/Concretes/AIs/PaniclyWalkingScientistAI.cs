using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace HUJAM1.Concretes.AIs
{
    public class PaniclyWalkingScientistAI : MonoBehaviour
    {
        [SerializeField] private List<Transform> _transformPositions;
        private NavMeshAgent _navMeshAgent;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }
        private void Update()
        {
            _navMeshAgent.destination = _transformPositions[0].position;
        }
    }
}