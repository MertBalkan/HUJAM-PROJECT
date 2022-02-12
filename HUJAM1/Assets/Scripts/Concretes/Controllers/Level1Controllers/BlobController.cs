using HUJAM1.Abstracts.Components;
using HUJAM1.Concretes.Managers;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class BlobController : RotateComponent
    {
        private AudioManager _audioManager;
        private void Awake()
        {
            _audioManager = FindObjectOfType<AudioManager>();
        }
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.IncreaseBlobScore();
                GameManager.Instance.IncreasePlayerSize();
                _audioManager.PlayPickupAudio();

                Destroy(this.gameObject);
            }
        }
    }
}