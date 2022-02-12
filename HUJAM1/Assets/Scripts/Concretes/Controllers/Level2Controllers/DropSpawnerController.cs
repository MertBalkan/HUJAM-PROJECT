using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Spawners;
using HUJAM1.Concretes.Movements;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class DropSpawnerController : MonoBehaviour, ISpawner3D
    {
        [SerializeField] private GameObject _dropGameObject;
        [SerializeField] private float _dropSpawnRate;
        [SerializeField] private float _dropStartSpawnTime;
        private ScientistArmMovement _arm;
        private void Awake()
        {
            _arm = FindObjectOfType<ScientistArmMovement>();
        }
        private void Start()
        {
            InvokeRepeating("SpawnDrop", _dropStartSpawnTime, _dropSpawnRate);
        }
        public void SpawnDrop()
        {
            if (_arm.CanDropsVisible)
                Spawn(_dropGameObject);
        }
        private void Spawn(GameObject whichGameObject)
        {
            GameObject obj = Instantiate(whichGameObject, transform.position, Quaternion.identity);
            if(obj == null) return;
            obj.transform.rotation = Quaternion.Euler(-90.0f, 0, 0);
        }
    }
}