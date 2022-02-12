using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Concretes.Levels
{
    public class Level1Script : MonoBehaviour
    {
        private void Update()
        {
            PassLevel();
        }
        private void PassLevel()
        {
            if (GameManager.Instance.BlobScore >= 18)
            {
                GameManager.Instance.LoadSceneByIndex(1);
            }
        }
    }
}