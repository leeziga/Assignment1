using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text pointsText;
    [SerializeField] private Text winText;
    [SerializeField] private Text timeText;

    public bool hasWon = false;
    public bool hasLost = false;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void ResetLevel()
    {
        winText.text = "";
    }
    public void UpdateScoreDisplay(int currentScore)
    {
        if (!hasWon)
            pointsText.text = "Points: " + currentScore.ToString();
    }

    public void UpdateLevelTimer(float time)
    {
        if (!hasWon)
            timeText.text = "Time left: " + time.ToString("0.#");
    }

    public void DisplayWinText()
    {
        if (!hasWon)
        {
            winText.text = "You win!";
            hasWon = true;
        }
    }

    public void DisplayLoseText()
    {
        if (!hasWon)
        {
            winText.text = "You Lose!";
            hasLost = true;
        }
    }
}
