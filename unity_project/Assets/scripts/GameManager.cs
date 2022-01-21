using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float score;

    void Update()
    {
        score = GameObject.Find("Player").transform.position.z;
    }

    public void EndGame()
    {

        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
