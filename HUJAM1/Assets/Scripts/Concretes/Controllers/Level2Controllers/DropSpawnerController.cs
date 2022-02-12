using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Spawners;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class DropSpawnerController : MonoBehaviour, ISpawner3D
    {
        [SerializeField] private GameObject _dropGameObject;
        [SerializeField] private float _dropSpawnRate;
        [SerializeField] private float _dropStartSpawnTime;

        private void Start()
        {
            InvokeRepeating("SpawnDrop", _dropStartSpawnTime, _dropSpawnRate);
        }

        public void SpawnDrop()
        {
            Spawn(_dropGameObject);
        }
        private void Spawn(GameObject whichGameObject)
        {

            Instantiate(whichGameObject, transform.position, Quaternion.identity);
        }
    }
}