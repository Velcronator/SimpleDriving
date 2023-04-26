using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultipler = 7f;

    private float score;

    private void Update()
    {
        score += Time.deltaTime * scoreMultipler;

        string scoreDisplay = Mathf.FloorToInt(score).ToString();

        scoreText.text = scoreDisplay;
    }
}
