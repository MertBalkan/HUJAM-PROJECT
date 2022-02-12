using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class DecalController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.LoadSelfScene();
            }
        }
    }
}