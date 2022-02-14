using HUJAM1.Concretes.Controllers;
using UnityEngine;
using UnityEngine.UI;
namespace HUJAM1.Concretes.UIs
{
    public class HealthSlider : MonoBehaviour
    {
        private Slider _slider;
        private CharacterControllerLvL3 _character;

        private void Awake()
        {
            _character = FindObjectOfType<CharacterControllerLvL3>();
            _slider = GetComponent<Slider>();
        }

        private void Start()
        {
            _slider.value = _character.Health.CurrentHealth;
        }

        private void Update()
        {
            _slider.value = Mathf.Clamp(_slider.value, 0, _character.Health.CurrentHealth);
        }

    }
}