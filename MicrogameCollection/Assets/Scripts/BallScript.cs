using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D ballRB;
    
    // Start is called before the first frame update
    void Start()
    {
        
        ballRB.AddForce(new Vector2(BasketBallPlayer.powerLevel * 300, BasketBallPlayer.powerLevel * 600));

        StartCoroutine(DestroyBall());
    }

    private void FixedUpdate()
    {
        if (this.gameObject.transform.position.y <= -10)
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator DestroyBall()
    {
        yield return new WaitForSeconds(3.5f);
        Destroy(this.gameObject);
        yield return null;
    }
}
