using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float jumpForceScale;

    private Vector2 mousePos;
    

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.zero);
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GetComponent<Rigidbody2D>().AddForce(mousePos, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForceScale, ForceMode2D.Impulse);
    }
}
