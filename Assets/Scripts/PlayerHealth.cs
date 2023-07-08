using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameOverHandler gameOver;
    public void Crash()
    {
        gameObject.SetActive(false);
        gameOver.EndGame();

    }
}
