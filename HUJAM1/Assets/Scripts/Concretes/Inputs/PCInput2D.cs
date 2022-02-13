using HUJAM1.Abstracts.Inputs;
using UnityEngine;

namespace HUJAM1.Concretes.Inputs
{
    public class PCInput2D : IInput2D
    {
        public float HorizontalMove => Input.GetAxis("Horizontal");
        public float VerticalMove => Input.GetAxis("Vertical");
        public float MouseAxisX => Input.GetAxis("Mouse X");
        public float MouseAxisY => Input.GetAxis("Mouse Y");
        public bool InteractButton => Input.GetKey(KeyCode.E);
        public bool ThrowTube => Input.GetMouseButtonDown(0);
    }
}