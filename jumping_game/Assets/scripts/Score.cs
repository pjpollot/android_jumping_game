using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform Player;
    public TextMeshProUGUI ScoreText;
    static public int score;

    // Update is called once per frame
    void Update()
    {
        score = (int) Player.position.z;
        ScoreText.text = "Score = " + Player.position.z.ToString("0");
    }
}
