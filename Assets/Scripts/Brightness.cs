using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    public Slider opacity;

    public void changeBrightness()
    {
        SpriteRenderer sR=GetComponent<SpriteRenderer>();

        Color bColour = sR.color;

        bColour.a = opacity.value;
        sR.color = bColour;
    }
}
