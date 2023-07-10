using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text gameOverText;
    [SerializeField] private GameObject gameOverDisplay;
    [SerializeField] private ScoreSystem scoreSystem;
    [SerializeField] private AsteroidSpawner asteroidSpawner;
    [SerializeField] private GameObject player;
    [SerializeField] private Button continueButton; 

    public void EndGame()
    {
        scoreSystem.StopScore();
        gameOverText.text = $"Your Score: {scoreSystem.Score.ToString()}";
        asteroidSpawner.enabled = false;
        gameOverDisplay.gameObject.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void ContinueButon()
    {
        AdManager.Instance.ShowAd(this);
        continueButton.interactable = false;
    }

    public void ContinueGame()
    {
        scoreSystem.StartTimer();
        player.transform.position = Vector3.zero;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.SetActive(true);
        asteroidSpawner.enabled = true;
        gameOverDisplay.gameObject.SetActive(false);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
