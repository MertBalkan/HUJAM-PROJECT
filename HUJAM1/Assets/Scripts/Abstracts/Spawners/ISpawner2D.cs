using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Abstracts.Spawners
{
    public interface ISpawner2D
    {
        void SpawnBlob();
        void SpawnEnemy();
        void Spawn(GameObject whichGameObject, List<GameObject> spawnList, float spawnRate, float spawnStartTime);
        void DestroyObject();
        List<GameObject> EnemySpawnPoints { get; set; }
        List<GameObject> BlobSpawnPoints { get; set; }
    }
}