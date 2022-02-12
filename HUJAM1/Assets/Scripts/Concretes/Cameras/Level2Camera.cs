using HUJAM1.Abstracts.Inputs;
using HUJAM1.Concretes.Inputs;
using Cinemachine;
using UnityEngine;

namespace HUJAM1.Concretes.Cameras
{
    public class Level2Camera : MonoBehaviour
    {
        private CinemachineVirtualCamera _camera;
        private CinemachineTransposer _transposer;

        private IInput2D _input;

        private void Awake()
        {
            _camera = GetComponent<CinemachineVirtualCamera>();
            _input = new PCInput2D();
        }

        private void Update()
        {

        }

    }
}