using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUJAM1.Concretes.Levels
{
    public class ToTheNextLevel : MonoBehaviour
    {
        [SerializeField] private int _nextLevelTime;
        private float _countdown;
        private void Update()
        {
            _countdown += Time.deltaTime;
            if (_countdown >= _nextLevelTime)
            {
                GameManager.Instance.LoadSceneByBuildIndex();
            }
        }
    }
}