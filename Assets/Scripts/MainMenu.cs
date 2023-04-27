using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TMP_Text highScoreText;

    private void Start()
    {
        LoadHighScoreText();
    }

    private void LoadHighScoreText()
    {
        string highScoreToDisplay = PlayerPrefs.GetInt(ScoreHandler.HIGH_SCORE).ToString();
        //highScoreText.text = "Highscore: " + highScoreToDisplay;
        highScoreText.text = $"Highscore: {highScoreToDisplay}";
    }

    public void LoadGameLevel()
    {
        SceneManager.LoadScene(1);
    }

}
