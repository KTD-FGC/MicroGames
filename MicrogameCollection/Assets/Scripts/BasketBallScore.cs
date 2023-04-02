using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketBallScore : MonoBehaviour
{
    public int score;

    [SerializeField]
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void FixedUpdate()
    {
        scoreText.text = $"{score}";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
    }
}
