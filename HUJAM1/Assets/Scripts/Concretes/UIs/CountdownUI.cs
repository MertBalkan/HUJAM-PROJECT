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
        public float countDownLimit = 10.0f;

        private void Awake()
        {
            _audio = FindObjectOfType<Level3Audio>();
            _countdownText = GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            countDownLimit -= Time.deltaTime;
          
            _countdownText.text = "Countdown: " + (int)countDownLimit;

            if (countDownLimit <= 0)
            {
                countDownLimit = 0;
            }
        }

    }
}