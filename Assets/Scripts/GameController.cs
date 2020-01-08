using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    GameObject ball;

    [SerializeField]
    GameObject panel;

    [SerializeField]
    PlanetSettings planetSettings;


    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panel.activeSelf == false)
            {
                panel.SetActive(true);
                StopGame();
            }
            else
            {
                panel.SetActive(false);
                StartGame();
            }
        }
    }

    public void StartGame()
    {
        ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }

    private void StopGame()
    {
        ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }

    


}
