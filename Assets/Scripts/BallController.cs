using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{ 
    public float jumpForceScale;

    internal GameObject panel;
    internal Rigidbody2D ball;

    private GameObject text;
    private Vector2 mousePos;
    private int jumpCount = 0;


    private void Start()
    {
        panel = GameObject.Find("Panel");
        text = GameObject.Find("CountJumpText");
        panel.SetActive(false);
        ball = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {

        if (Input.GetMouseButtonDown(0))
        {

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            ball.AddForce(mousePos, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(panel.activeSelf == false)
            {
                panel.SetActive(true);
                Stop(true);
            }
            else
            {
                panel.SetActive(false);
                Stop(false);
            }

        }
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCount++;
        ball.AddForce(Vector2.zero);
        ball.AddForce(Vector2.up * jumpForceScale, ForceMode2D.Impulse);

        text.GetComponent<Text>().text = "Jump Count: "+jumpCount.ToString();


    }

    virtual internal void Stop(bool state)
    {
        if(state == true)
        {
            ball.bodyType = RigidbodyType2D.Static;
        }
        else
        {
            ball.bodyType = RigidbodyType2D.Dynamic;
            
        }

    }
}
