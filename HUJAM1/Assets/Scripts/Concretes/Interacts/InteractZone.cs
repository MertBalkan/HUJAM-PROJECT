using System.Collections;
using System.Collections.Generic;
using HUJAM1.Abstracts.Inputs;
using HUJAM1.Abstracts.Interacts;
using HUJAM1.Concretes.Inputs;
using UnityEngine;

namespace HUJAM1.Concretes.Interacts
{
    public class InteractZone : MonoBehaviour, IInteract
    {
        private bool _canInteract = false;
        public bool CanInteract => _canInteract;

        private IInput2D _input;
        private void Awake()
        {
            _input = new PCInput2D();
        }

        public void InteractWithObject()
        {

        }
    }
}