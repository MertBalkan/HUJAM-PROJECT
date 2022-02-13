using System.Collections;
using System.Collections.Generic;
using HUJAM1.Concretes.Controllers;
using HUJAM1.Concretes.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int _blobScore;
    public static GameManager Instance { get; private set; }
    public int BlobScore { get => _blobScore; set => _blobScore = value; }

    public System.Action OnPlayerDie;

    private void Awake()
    {
        SingletonObject();
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

    public void IncreaseBlobScore()
    {
        _blobScore++;
    }

    public void KillPlayer()
    {
        _blobScore = 0;
        OnPlayerDie?.Invoke();
    }

    public void IncreasePlayerSize()
    {
        CharacterController2D player = FindObjectOfType<CharacterController2D>();
        if (player == null) return;

        player.transform.localScale = new Vector3(
            player.transform.localScale.x + 0.1f,
            player.transform.localScale.y + 0.1f,
            player.transform.localScale.z + 0.1f
        );
    }

    public void LoadSelfScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadSceneByBuildIndex()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void PlayButtonPressed(int sceneIndex)
    {
        AnimationManager.Instance.MicroscopeAnimation();
        StartCoroutine(PlayButtonEnumerator(sceneIndex));
    }
    public void CreditsButtonPressed()
    {
        AnimationManager.Instance.StartCreditAnim();
        StartCoroutine(PlayCreditAnimation());
    }
    private IEnumerator PlayCreditAnimation()
    {
        AnimationManager.Instance.PlayCreditsAnim(false);
        yield return new WaitForSeconds(4.0f);
        AnimationManager.Instance.PlayCreditsAnim(true);
    }
    private IEnumerator PlayButtonEnumerator(int sceneIndex)
    {
        yield return new WaitForSeconds(5.4f); //delay time
        SceneManager.LoadScene(sceneIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}