using UnityEngine;
using UnityEngine.EventSystems;

public class LoadPlanet : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    PlanetSettings planetSettings;

    [SerializeField]
    GameObject ball;

    [SerializeField]
    GameObject panel;

    [SerializeField]
    new Camera camera;

 
 

    public void OnPointerDown(PointerEventData eventData)
    {
        StartPlanet(planetSettings.Gravity, planetSettings.SkyColor);
        StartGame();
    }





    private void StartPlanet(float gravity, Color32 skyColor)
    {
        Physics2D.gravity = new Vector2(0f, gravity);
        camera.backgroundColor = skyColor;
        panel.SetActive(false);
    }


    public void StartGame()
    {
        ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
