using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace HUJAM1.Concretes.UIs
{
    public class GrowLimitText : MonoBehaviour
    {
        private TextMeshProUGUI _growText;

        private void Awake()
        {
            _growText = GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            _growText.text = "Grow Limit: " + GameManager.Instance.BlobScore;
        }

    }
}