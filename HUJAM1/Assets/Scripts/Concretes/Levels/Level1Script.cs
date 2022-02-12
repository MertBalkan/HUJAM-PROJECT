using System.Collections;
using System.Collections.Generic;
using HUJAM1.Concretes.Controllers;
using UnityEngine;

namespace HUJAM1.Concretes.Levels
{
    public class Level1Script : MonoBehaviour
    {
        private CharacterController2D _character;
        private Vector3 _characterPosition;
        private void Awake()
        {
            _character = FindObjectOfType<CharacterController2D>();
        }
        private void Start()
        {
        }
        private void Update()
        {
            PassLevel();
            ForceBorder();
        }
        private void ForceBorder()
        {
            _characterPosition = _character.transform.position;

            _character.transform.position = new Vector3(
                Mathf.Clamp(_characterPosition.x, -40.0f, 40.0f),
                Mathf.Clamp(_characterPosition.y, -40.0f, 40.0f),
                Mathf.Clamp(_characterPosition.z, -40.0f, 40.0f)
            );
        }
        private void PassLevel()
        {
            if (GameManager.Instance.BlobScore >= 18)
            {
                GameManager.Instance.LoadSceneByBuildIndex();
            }
        }
    }
}