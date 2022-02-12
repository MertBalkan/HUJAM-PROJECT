using HUJAM1.Abstracts.Inputs;
using HUJAM1.Concretes.Inputs;
using Cinemachine;
using UnityEngine;

namespace HUJAM1.Concretes.Cameras
{
    public class Level2Camera : MonoBehaviour
    {
        [SerializeField] private float _cameraSensitivity;
        private CinemachineVirtualCamera _camera;
        // private CinemachineTransposer _transposer;
        private CinemachineComposer _composer;

        private IInput2D _input;

        private void Awake()
        {
            _camera = GetComponent<CinemachineVirtualCamera>();
            _composer = _camera.GetCinemachineComponent<CinemachineComposer>();
            _input = new PCInput2D();
        }

        private void Update()
        {
            if (_input.MouseAxisX == 0)
                return;

             if(_composer.m_ScreenX < 1.2f || _composer.m_ScreenX > 0)
                _composer.m_ScreenX = Mathf.Lerp(_composer.m_ScreenX, Mathf.Sign(_input.MouseAxisX * -1.0f), Time.deltaTime * _cameraSensitivity);
        }
    }
}