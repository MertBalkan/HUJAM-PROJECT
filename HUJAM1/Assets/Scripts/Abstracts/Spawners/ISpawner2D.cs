using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Abstracts.Spawners
{
    public interface ISpawner2D
    {
        List<GameObject> EnemySpawnPoints { get; set; }
        List<GameObject> BlobSpawnPoints { get; set; }
    }
}