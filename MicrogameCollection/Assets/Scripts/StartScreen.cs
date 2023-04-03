using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    [SerializeField]
    GameObject audioComp;

    [SerializeField]
    GameObject powerUI;

    [SerializeField]
    GameObject timerUI;

    [SerializeField]
    GameObject baller;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }
    
    public void StartGame()
    {
        Time.timeScale = 1;
        audioComp.SetActive(true);
        powerUI.SetActive(true);
        timerUI.SetActive(true);
        baller.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
