using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    private Text scoreLabel;

    void Start()
    {
        scoreLabel = GameObject.Find("ScoreLabel").GetComponent<Text>();
        scoreLabel.text = "SCORE�F" + score;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreLabel.text = "SCORE�F" + score;
    }
}