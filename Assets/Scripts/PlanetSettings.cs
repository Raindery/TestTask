using UnityEngine;


[CreateAssetMenu(fileName = "New Planet Settings", menuName = "Planet Settings", order = 51)]
public class PlanetSettings : ScriptableObject
{
    [SerializeField]
    float gravity;

    [SerializeField]
    Color32 skyColor;



    public float Gravity
    {
        get { return gravity; }
    }

    public Color32 SkyColor
    {
        get { return skyColor; }
    }

}
