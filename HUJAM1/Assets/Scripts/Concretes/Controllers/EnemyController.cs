using HUJAM1.Abstracts.Components;
using UnityEngine;

namespace HUJAM1.Concretes.Controllers
{
    public class EnemyController : RotateComponent
    {
        private float _moveSpeed;
        private CharacterController2D _character;

        private void Awake()
        {
            _character = FindObjectOfType<CharacterController2D>();
        }
        private void OnEnable()
        {
            _moveSpeed = Random.Range(2.0f, 6.0f);

            GameManager.Instance.OnPlayerDie += HandleOnPlayerDie;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnPlayerDie -= HandleOnPlayerDie;
        }

        private void HandleOnPlayerDie()
        {
            Die();
        }

        protected override void Update()
        {
            base.Update();
            MoveToPlayer();
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.KillPlayer();
            }
        }

        private void MoveToPlayer()
        {
            this.transform.position = Vector3.Lerp(transform.position, _character.transform.position, (Time.deltaTime / _moveSpeed));
        }

        private void Die()
        {
            GameManager.Instance.LoadSceneByIndex(0);
        }
    }
}