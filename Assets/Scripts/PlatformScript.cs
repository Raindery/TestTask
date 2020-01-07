using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformScript : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ChangeColor();
    }


    private void ChangeColor()
    {
        int r = Random.Range(0, 255);
        int g = Random.Range(0, 255);
        int b = Random.Range(0, 255);
        GetComponent<SpriteRenderer>().color = new Color32((byte)r, (byte)g, (byte)b, 255);
        
    }
}
