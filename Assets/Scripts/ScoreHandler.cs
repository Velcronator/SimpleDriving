using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultipler = 7f;

    public const string HIGH_SCORE = "HighScore"; 

    private float score;

    private void Update()
    {
        score += Time.deltaTime * scoreMultipler;

        string scoreDisplay = Mathf.FloorToInt(score).ToString();

        scoreText.text = scoreDisplay;
    }

    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(HIGH_SCORE, 0);

        if(score > currentHighScore)
        {
            PlayerPrefs.SetInt(HIGH_SCORE, Mathf.FloorToInt(score));
        }

    }
}
