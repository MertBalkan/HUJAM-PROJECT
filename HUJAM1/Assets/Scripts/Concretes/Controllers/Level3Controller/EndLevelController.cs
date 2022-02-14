using HUJAM1.Concretes.UIs;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class EndLevelController : MonoBehaviour
    {
        private CountdownUI _countdownUI;

        private void Awake()
        {
            _countdownUI = FindObjectOfType<CountdownUI>();
        }
        private void Start()
        {
            this.gameObject.SetActive(false);
        }
        private void Update()
        {
            FinishLevel();
        }
        private void FinishLevel()
        {
            Debug.Log(_countdownUI.countDownLimit);
            if (_countdownUI.countDownLimit <= 0)
            {
                this.gameObject.SetActive(true);
            }
        }
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.LoadSceneByBuildIndex();
            }
        }
    }
}