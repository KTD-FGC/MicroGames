using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    [SerializeField]
    Text goText;

    [SerializeField]
    BasketBallScore score;
    // Update is called once per frame
    void Update()
    {
        goText.text = $"Game Over\nYou scored {score.score} points!";
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
