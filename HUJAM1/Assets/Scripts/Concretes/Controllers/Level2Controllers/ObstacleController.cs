using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class ObstacleController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.LoadSceneByIndex(2);
            }
        }
    }
}