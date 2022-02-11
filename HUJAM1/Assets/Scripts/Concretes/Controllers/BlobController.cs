using HUJAM1.Abstracts.Components;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class BlobController : RotateComponent
    {
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.IncreaseBlobScore();
                GameManager.Instance.IncreasePlayerSize();
                
                Destroy(this.gameObject);
            }
        }
    }
}