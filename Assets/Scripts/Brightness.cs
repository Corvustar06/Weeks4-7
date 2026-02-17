using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    //Connects to the slider in the scene
    public Slider opacity;

    public void changeBrightness()
    {
        //connects to the sprite Renderer for the sprite the script is attatched too
        SpriteRenderer sR=GetComponent<SpriteRenderer>();

        //takes the colour of the darkened screen
        Color bColour = sR.color;

        //Changes the alpha variable of the sprite's colour to increase or decrease transparency based on slider value
        bColour.a = opacity.value;

        //Set the sprite's colour
        sR.color = bColour;
    }
}
