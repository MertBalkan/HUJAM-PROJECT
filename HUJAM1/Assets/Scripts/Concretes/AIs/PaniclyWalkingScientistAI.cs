using System.Collections;
using System.Collections.Generic;
using HUJAM1.Concretes.Animations;
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

            if (_navMeshAgent.velocity == Vector3.zero)
            {
                GetComponent<Level3Animation>().PlayTerrifiedAnimation(true);
            }
            else
                GetComponent<Level3Animation>().PlayTerrifiedAnimation(false);

        }
    }
}