using UnityEngine;

namespace HUJAM1.Concretes.Levels
{
    public class Level2Script : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.LoadSceneByBuildIndex();
            }
        }
    }
}