using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreManger scoreManger;      // Make sure class name matches your manager script
    public TextMeshProUGUI scoreText;    // Fixed name from 'soreText'

    void Start()
    {
    }

    void Update()
    {
        if (scoreText == null || scoreManger == null) return;
        scoreText.text = "Score: " + scoreManger.currentScore;
    }
}
