using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    int finalScore = Score.score;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Final Score = " + finalScore.ToString();
    }
}
