using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{ 
    [SerializeField]
    float jumpForceScale;

    [SerializeField]
    Text jumpCountText;

    private Rigidbody2D ball;
    private Vector2 mousePos;
    private int jumpCount = 0;



    private void Start()
    {
        jumpCountText.GetComponent<Text>();
        
        ball = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            ball.AddForce(mousePos, ForceMode2D.Impulse);
            
        }
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCount++;
        ball.AddForce(Vector2.zero);
        ball.AddForce(Vector2.up * jumpForceScale, ForceMode2D.Impulse);
        jumpCountText.text = "Jump Count: "+jumpCount.ToString();


    }


}
