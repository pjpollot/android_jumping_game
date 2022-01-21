using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public Rigidbody rb;
    public PlayerMove mvmt;
    Vector3 velocity;

    public void PauseGame()
    {
        FindObjectOfType<PlayerMove>().Pause();
        mvmt.enabled = false;
    }

    public void Back()
    {
        
        mvmt.enabled = true;
        FindObjectOfType<PlayerMove>().ReStart();
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}


