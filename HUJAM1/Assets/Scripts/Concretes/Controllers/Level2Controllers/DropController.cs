using System.Collections.Generic;
using HUJAM1.Concretes.Audios;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class DropController : MonoBehaviour
    {
        [SerializeField] private float _decalHeightFromGround = -0.36f;
        [SerializeField] private List<GameObject> _decals;

        [SerializeField] private Level2Audio _audio;

        private void Awake()
        {
            _audio = FindObjectOfType<Level2Audio>();
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                Destroy(this.gameObject);
                _audio.PlayFluidTouchGroundSound();
                int ranDecalIndex = Random.Range(0, _decals.Count);
                Instantiate(_decals[ranDecalIndex].gameObject, transform.position + new Vector3(0, _decalHeightFromGround, 0), Quaternion.Euler(-90, 0, 0));
            }
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.LoadSelfScene();
            }
            if (other.gameObject.CompareTag("Drop"))
            {
                Destroy(this.gameObject);
            }
            Destroy(this.gameObject);
        }
    }
}