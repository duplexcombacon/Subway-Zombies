using UnityEngine;
using TMPro; // ← IMPORTANTE para TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referência ao TMP Text
    public float score = 0f;
    public float scoreRate = 1f; // Pontos por segundo

    private bool isScoring = true;

    void Update()
    {
        if (isScoring)
        {
            score += scoreRate * Time.deltaTime;
            scoreText.text = "Pontos: " + Mathf.FloorToInt(score).ToString();
        }
    }

    public void StopScoring()
    {
        isScoring = false;
    }

    public void ResetScore()
    {
        score = 0f;
        scoreText.text = "Pontos: 0";
        isScoring = true;
    }
}
