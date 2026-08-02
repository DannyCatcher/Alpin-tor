// GameManager.cs
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I;
    public int caughtCount = 0;
    public int missedCount = 0;
    public int maxMisses = 10;

    public Text caughtText;
    public Text missedText;
    public GameObject gameOverPanel;
    public AudioSource sirenSource;
    public AudioClip catchSfx;
    public AudioClip missSfx;
    public AudioClip gameOverSfx;

    void Awake()
    {
        if (I == null) I = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        UpdateUI();
        if (gameOverPanel) gameOverPanel.SetActive(false);
    }

    public void OnCaught()
    {
        caughtCount++;
        if (catchSfx) AudioSource.PlayClipAtPoint(catchSfx, Camera.main.transform.position);
        UpdateUI();
    }

    public void OnMissed()
    {
        missedCount++;
        if (missSfx) AudioSource.PlayClipAtPoint(missSfx, Camera.main.transform.position);
        UpdateUI();

        if (missedCount >= maxMisses)
        {
            StartGameOver();
        }
        else if (missedCount >= maxMisses - 2)
        {
            if (sirenSource && !sirenSource.isPlaying) sirenSource.Play();
        }
    }

    void UpdateUI()
    {
        if (caughtText) caughtText.text = "Caught: " + caughtCount;
        if (missedText) missedText.text = "Missed: " + missedCount + "/" + maxMisses;
    }

    void StartGameOver()
    {
        if (sirenSource) sirenSource.Play();
        if (gameOverSfx) AudioSource.PlayClipAtPoint(gameOverSfx, Camera.main.transform.position);
        if (gameOverPanel) gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // pause for dramatic effect
    }

    public float GetIntoxicationLevel()
    {
        return Mathf.Clamp01(caughtCount / 10f);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
