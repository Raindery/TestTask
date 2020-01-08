using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    public float g;
    public new Camera camera;
    public Color backgroundColor;

    GameObject panel;
    Rigidbody2D ball;
    
    
    private void Start()
    {

        panel = GameObject.Find("Panel");
        ball = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
    }

    public void StartPlanet()
    {
        Physics2D.gravity = new Vector2(0f, g);
        panel.SetActive(false);
        Stop(false);
        camera.backgroundColor = backgroundColor;
        
        
    }

    void Stop(bool state)
    {
        if (state == true)
        {
            ball.bodyType = RigidbodyType2D.Static;
        }
        else
        {
            ball.bodyType = RigidbodyType2D.Dynamic;

        }
    }

    

    





}
