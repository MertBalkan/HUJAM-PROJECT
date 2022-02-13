using HUJAM1.Abstracts.Components;
using HUJAM1.Concretes.Audios;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class BlobController : RotateComponent
    {
        private Level1Audio _level1Audio;
        private void Awake()
        {
            _level1Audio = FindObjectOfType<Level1Audio>();
        }
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.IncreaseBlobScore();
                GameManager.Instance.IncreasePlayerSize();
                _level1Audio.PlayPickupAudio();

                Destroy(this.gameObject);
            }
        }
    }
}