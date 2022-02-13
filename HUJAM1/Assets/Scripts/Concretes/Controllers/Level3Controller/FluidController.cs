using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class FluidController : MonoBehaviour
    {
        private CharacterControllerLvL3 _character;

        private void Awake()
        {
            _character = FindObjectOfType<CharacterControllerLvL3>();
        }
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                if (_character != null)
                {
                    _character.Move.speedDampTime = 8f;
                }
            }
        }
        private void OnCollisionStay(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                if (_character != null)
                {
                    _character.Move.speedDampTime = 8f;
                }
            }
        }
        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                if (_character != null)
                {
                    _character.Move.speedDampTime = 0.1f;
                }
            }
        }
    }
}