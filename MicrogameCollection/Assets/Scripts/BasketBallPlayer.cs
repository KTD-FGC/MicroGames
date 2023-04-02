using UnityEngine;
using UnityEngine.UI;

public class BasketBallPlayer : MonoBehaviour
{
    public Slider power;

    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    Transform groundCheck;

    [SerializeField]
    LayerMask groundLayer;
    
    public int jumpPower;
    public GameObject ball;
    public GameObject ballSpawn;
    private bool canShoot;
    [SerializeField]
    SpriteRenderer fakeBall;

    [SerializeField]
    TimerScript timer;

    static public float powerLevel;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && canShoot == true)
        {
            canShoot = false;
            fakeBall.enabled = false;
            powerLevel = power.value;
            Instantiate(ball, ballSpawn.transform.position, ballSpawn.transform.rotation);
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            canShoot = true;
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

        if (IsGrounded())
        {
            power.value = 0;
            fakeBall.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && canShoot == true)
        {
            power.value += .03f;
        }

        if (timer.timerOn == false)
        {
            Destroy(this.gameObject);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
