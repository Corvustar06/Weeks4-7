using UnityEngine;

public class RandomColour : MonoBehaviour
{
    
    public void randomCol()
    {
        SpriteRenderer sR = GetComponent<SpriteRenderer>();
        sR.color = Random.ColorHSV();
    }
}
