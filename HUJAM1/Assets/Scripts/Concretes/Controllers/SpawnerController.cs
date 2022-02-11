using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Spawners;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class SpawnerController : MonoBehaviour, ISpawner2D
    {
        [Header("BLOBS")]
        [SerializeField] private List<GameObject> _blobSpawnPoints;
        [SerializeField] private GameObject _blobGameObject;
        [SerializeField] private float _blobSpawnRate;
        [SerializeField] private float _blobStartSpawnTime;

        [Header("ENEMIES")]
        [SerializeField] private List<GameObject> _enemySpawnPoints;
        [SerializeField] private GameObject _enemyGameObject;
        [SerializeField] private float _enemySpawnRate;
        [SerializeField] private float _enemyStartSpawnTime;

        public List<GameObject> EnemySpawnPoints { get => _enemySpawnPoints; set => _enemySpawnPoints = value; }
        public List<GameObject> BlobSpawnPoints { get => _blobSpawnPoints; set => _blobSpawnPoints = value; }

        private void Start()
        {
            InvokeRepeating("SpawnBLob", _blobStartSpawnTime, _blobSpawnRate);
            InvokeRepeating("SpawnEnemy", _enemyStartSpawnTime, _enemySpawnRate);
        }
        public void SpawnBlob()
        {
            Spawn(_blobGameObject, _blobSpawnPoints);
        }

        public void SpawnEnemy()
        {
            Spawn(_enemyGameObject, _enemySpawnPoints);
        }
        private void Spawn(GameObject whichGameObject, List<GameObject> spawnList)
        {
            if (spawnList == null) return;
            int randomIndex = Random.Range(0, spawnList.Count);

            Instantiate(whichGameObject, spawnList[randomIndex].transform.position, Quaternion.identity);
        }
    }
}