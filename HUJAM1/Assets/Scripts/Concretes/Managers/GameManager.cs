using System.Collections;
using System.Collections.Generic;
using HUJAM1.Concretes.Controllers;
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

    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
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
