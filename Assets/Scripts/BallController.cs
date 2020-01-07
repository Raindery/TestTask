using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    

    public float jumpForceScale;

    private Vector2 mousePos;
    internal int jumpCount;
    
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GetComponent<Rigidbody2D>().AddForce(mousePos, ForceMode2D.Impulse);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.zero);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForceScale, ForceMode2D.Impulse);
        jumpCount++;
        
    }
}
