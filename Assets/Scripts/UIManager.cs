// UIManager.cs
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager I;

    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject gameplayPanel;
    public GameObject gameOverPanel;
    public GameObject leaderboardPanel;

    [Header("Gameplay HUD")]
    public UnityEngine.UI.Text scoreText;
    public UnityEngine.UI.Text bottlesText;
    public UnityEngine.UI.Image[] missedIcons;

    void Awake()
    {
        if (I == null) I = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        gameplayPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        leaderboardPanel.SetActive(false);
    }

    public void ShowGameplay()
    {
        mainMenuPanel.SetActive(false);
        gameplayPanel.SetActive(true);
        gameOverPanel.SetActive(false);
        leaderboardPanel.SetActive(false);
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        gameplayPanel.SetActive(false);
    }

    public void ShowLeaderboard()
    {
        leaderboardPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }

    public void UpdateHUD(int score, int bottles, int missed, int maxMisses)
    {
        if (scoreText) scoreText.text = score.ToString();
        if (bottlesText) bottlesText.text = "x " + bottles;
        for (int i = 0; i < missedIcons.Length; i++)
        {
            missedIcons[i].enabled = i < missed;
        }
    }
}
