using HUJAM1.Abstracts.Controllers;
using HUJAM1.Abstracts.Inputs;
using HUJAM1.Abstracts.Interacts;
using HUJAM1.Abstracts.Movements;
using HUJAM1.Concretes.Combats;
using HUJAM1.Concretes.Inputs;
using HUJAM1.Concretes.Interacts;
using HUJAM1.Concretes.Movements;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{

    public class MonkeyController : MonoBehaviour
    {
        [SerializeField] private GameObject _tube;
        [SerializeField] private GameObject _tubeSpawnPoint;
        private IInput2D _input;
        private ThrowObject _canThrowable;
        private GameObject _tubeObj;

        public ThrowObject CanThrowable { get => _canThrowable; set => _canThrowable = value; }
        public IInput2D Input { get => _input; set => _input = value; }
        public GameObject TubeObj { get => _tubeObj; set => _tubeObj = value; }

        private void Awake()
        {
            Input = new PCInput2D();
            CanThrowable = new ThrowObject();
        }
        private void Start()
        {
            CanThrowable.CanTubeThrowable = false;
        }
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Tube") && Input.InteractButton)
            {
                CanThrowable.CanTubeThrowable = true;

                _tubeObj = Instantiate(_tube, _tubeSpawnPoint.transform.position, Quaternion.identity) as GameObject;
                _tubeObj.transform.rotation = Quaternion.Euler(-90, 0, 0);

                if (_tubeObj != null)
                {
                    _tubeObj.GetComponent<Rigidbody>().isKinematic = true;
                    _tubeObj.transform.parent = transform;
                    Destroy(other.gameObject.transform.parent.gameObject);
                }
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Tube"))
            {
                CanThrowable.CanTubeThrowable = false;
            }
        }
    }
}