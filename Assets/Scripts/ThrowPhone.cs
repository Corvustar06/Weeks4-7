using UnityEngine;

public class ThrowPhone : MonoBehaviour
{
    //Bool to ensure the phone doesn't start the throwing animation unless triggered
    public bool throwing = false;

    //Speed of throw
    public float speed = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        //So long as the throw has been triggered
        if (throwing)
        {
            //rotate the sprite according to the speed
            Vector3 rot = transform.eulerAngles;
            rot.z += speed;
            transform.eulerAngles = rot;

            //Make the phone smaller as it's thrown
            Vector2 scale = transform.localScale;
            //so long as the phone hasn't completely shrunk
            if (scale.x>0&&scale.y>0)
            {
                //get smaller
                scale.x -= 0.001f;
                scale.y -= 0.001f;
            }
            //if the phone is small enough
            else if (scale.x<0.00001&&scale.y<0.00001)
            {
                //stop the throwing animation
                throwing = false;
            }
            //apply the changes to the sprite
            transform.localScale = scale;
        }
    }

    //a function to be reference by a button
    public void beginThrow()
    {
        //checks if the phone has rotated or not
        Vector3 rot2 =  transform.eulerAngles;
        //if it hasn't
        if (rot2.z == 0)
		{
            //start the rotation
			throwing = true;
		}
        //if it has
        else
        {
            //reset it to its starting size and angle
            rot2.z = 0;
            transform.eulerAngles= rot2;
            Vector2 scale = transform.localScale;
            scale.x = 0.3433737f;
            scale.y = 0.3433737f;
            transform.localScale= scale;
		}
    }
}
