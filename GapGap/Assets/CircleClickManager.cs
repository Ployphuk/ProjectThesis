using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleClickManager : MonoBehaviour
{
    public int points = 0;
    public int pointsToWin = 10;
    public Text pointsText;
    public SpawnCircle spawnCircle;

    public GameObject startButton;
    public GameObject gameUI;
    public GameObject gameOverPanel;

    private GameObject currentCircle;
    private bool gameStarted = false;

    void Start()
    {
        startButton.SetActive(true);
        gameUI.SetActive(false);
        gameOverPanel.SetActive(false);
    }

    public void StartGame()
    {
        startButton.SetActive(false);
        gameUI.SetActive(true);
        gameOverPanel.SetActive(false);
        gameStarted = true;
        points = 0;
        pointsText.text = "Points: " + points;
        SpawnNewCircle();
    }

    public void CircleClicked()
    {
        if (!gameStarted) return;

        points++;
        pointsText.text = "Points: " + points;

        if (currentCircle != null)
        {
            Destroy(currentCircle);
        }

        if (points >= pointsToWin)
        {
            WinGame();
        }
        else
        {
            SpawnNewCircle(); // Spawn a new circle
        }
    }

    void SpawnNewCircle()
    {
        currentCircle = spawnCircle.CircleSpawner();

        // Add the click event to the new circle
        Button circleButton = currentCircle.GetComponent<Button>();
        circleButton.onClick.AddListener(CircleClicked);
    }

    void WinGame()
    {
        Debug.Log("You Win!");
        // Add win logic here (e.g., show a win screen)
        gameOverPanel.SetActive(true);
        gameUI.SetActive(false);
        gameStarted = false;
    }
}
