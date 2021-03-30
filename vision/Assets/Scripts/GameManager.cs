using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private UnityEvent<string> addScore;
    private Vector3 startPos;
    private int score;

    private void Start()
    {
        startPos = player.transform.position;
        score = 0;
        UpdateUI();
    }

    public void RespawnPlayer()
    {
        player.transform.position = startPos;
        score = 0;
        UpdateUI();
    }

    public void AddScore(int scoreAmt)
    {
        score += scoreAmt;
        UpdateUI();
    }

    private void UpdateUI()
    {
        addScore.Invoke(score.ToString());
    }

    public void Replay()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
