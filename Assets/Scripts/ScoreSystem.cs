using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;

    private float score;
    private bool shouldCount = true;

    public float Score { get => Mathf.FloorToInt(score); }

    void Update()
    {
        if (!shouldCount) return;
        score += Time.deltaTime * scoreMultiplier;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    public void StopScore()
    {
        shouldCount = false;
        scoreText.text = string.Empty;
    }

    internal void StartTimer()
    {
        shouldCount = true;
    }
}
