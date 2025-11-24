using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreManger scoreManger;
    public TextMeshProUGUI soreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soreText.text = "Score: " + scoreManger.currentScore;
    }
}
