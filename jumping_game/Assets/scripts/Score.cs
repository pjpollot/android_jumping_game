using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score = " + Player.position.z.ToString("0");
    }
}
