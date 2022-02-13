using HUJAM1.Concretes.AIs;
using UnityEngine;

namespace HUJAM1.Concretes.Managers
{
    public class AnimationManager : MonoBehaviour
    {
        [SerializeField] private GameObject _camera;
        private AttackerAI _attacker;
        public static AnimationManager Instance { get; private set; }
        private void Awake()
        {
            _attacker = FindObjectOfType<AttackerAI>();
            if(_attacker == null) return;
            SingletonObject();
        }
        //---------------------------MAIN MENU---------------------------
        public void StartCreditAnim()
        {
            _camera.GetComponent<Animator>().SetTrigger("pass");
        }
        public void PlayCreditsAnim(bool goBack)
        {
            _camera.GetComponent<Animator>().SetBool("isGoBack", goBack);
        }
        //---------------------------LEVEL 1---------------------------
        public void MicroscopeAnimation()
        {
            _camera.GetComponent<Animator>().SetTrigger("start");
        }
        //---------------------------LEVEL 3---------------------------
        public void PlayAttackAnimation(bool onAttack)
        {
            if(_attacker == null) return;
            _attacker.GetComponent<Animator>().SetBool("onAttack", onAttack);
        }
        private void SingletonObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}