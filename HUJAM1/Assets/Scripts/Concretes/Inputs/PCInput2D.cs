using HUJAM1.Abstracts.Inputs;
using UnityEngine;

namespace HUJAM1.Concretes.Inputs
{
    public class PCInput2D : IInput2D
    {
        public float HorizontalMove => Input.GetAxis("Horizontal");
        public float VerticalMove => Input.GetAxis("Vertical");
    }
}