using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isActive = true;
    public TextMeshProUGUI ScoreText;
    public MenuManager MenuManager;
    private int score = 0;

    public void UpdateScoreText()
    {
        ScoreText.text = "Score:" + score.ToString();
    }
    public void AddScore()
    {
        score += 1;
        UpdateScoreText();
        //Debug.Log(score);
    }
    
    public void Start()
    {
        UpdateScoreText();
    }
    
    public void StartGame()
    {
        Time.timeScale = 1f;
        isActive = true;
        Debug.Log("Игра возобновлена");
        SceneManager.LoadScene("SampleScene");
    }

    public void StopGame()
    {
        Time.timeScale = 0f;
        isActive = false;
        Debug.Log("Игра на паузе");
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        isActive = false;
        Debug.Log("Произошло столкновение с объектом");
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isActive == false)
        {
            StartGame();
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            MenuManager.OpenMenu();
            StopGame();
        }
    }
}
