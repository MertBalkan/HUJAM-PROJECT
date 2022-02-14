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
        private bool _doorSoundPlayed = false;

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
                _doorSoundPlayed = false;
                _countDownLimit = 0;
            }
            
            _audio.PlayDoorOpenSound();
            _doorSoundPlayed = true;
        }

    }
}