using UnityEngine.UI;
using TMPro;
using UnityEngine;
using HUJAM1.Concretes.Audios;

namespace HUJAM1.Concretes.UIs
{
    public class CountdownUI : MonoBehaviour
    {
        private TextMeshProUGUI _countdownText;
        private Level3Audio _audio;
        private float _countDownLimit = 60.0f;

        private void Awake()
        {
            _audio = FindObjectOfType<Level3Audio>();
            _countdownText = GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            _countDownLimit -= Time.deltaTime;
            _countdownText.text = "Countdown: " + (int)_countDownLimit;

            if (_countDownLimit <= 0)
            {
                _countDownLimit = 0;
            }
        }

    }
}