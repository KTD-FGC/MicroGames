using System.Collections;
using UnityEngine;

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
    IEnumerator DestroyBall()
    {
        yield return new WaitForSeconds(3.5f);
        Destroy(this.gameObject);
        //gameObject.SetActive(false);
        yield return null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BallDestroyer")
        {
            Destroy(this.gameObject);
        }
    }
}
