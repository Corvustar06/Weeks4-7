using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ExplosionAnim : MonoBehaviour
{
    
    public List <Sprite> explosions; //all of the different frames for the explosion's animation
    public List <Button> buttons; //the buttons that need to be hidden when it explodes
    public Slider brightness; //the slider that needs to be hidden
    public Slider ExploCounter; //the other slider that needs to be hidden
    public bool exploding = true; //makes the explosion a one-time triggerable thing
    public int frameNum = 0; //which frame of the animation we are currently on
    public float timer=0.1f; //the length of time between frames
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
            // if the explosion has been triggered
            if (exploding)
            {
            //start the timer between frames
                timer -= Time.deltaTime;
            //hide the buttons
                for (int i = 0; i<buttons.Count; i++)
            {
                    buttons[i].gameObject.SetActive(false);
            }
                //hide the sliders
                if (brightness != null && ExploCounter != null)
            {
                    brightness.gameObject.SetActive(false);
                    ExploCounter.gameObject.SetActive(false);
            }
            }

            //if all frames have been shown
            if (frameNum >= explosions.Count)
            {
            //stop the explosion
                exploding = false;
            //pull the sprite renderer for this object and reset the object's initial values
                SpriteRenderer sR = GetComponent<SpriteRenderer>();
                frameNum = 0;
                timer = 0.1f;
                sR.gameObject.SetActive(false);
                for(int i = 0; i < buttons.Count; i++)
            {
                buttons[i].gameObject.SetActive(true);
			}

			if(brightness != null)
			{
				brightness.gameObject.SetActive(true);
			}    

		}
            //if the timer reaches 0 while exploding, switch to the next frame
            if (exploding && timer <= 0)
            {

                nextFrame();
            }

            //reset the timer when it reaches the end
            if (timer <= 0)
            {
                timer = 0.1f;
            }
        
    }

    //trigger the next frame of the animation
    public void nextFrame()
    {
        SpriteRenderer sR = GetComponent<SpriteRenderer>();
        //swap the object's sprite to the next frame on the list and increase the current frame number
        sR.sprite = explosions[frameNum];
        frameNum++;
    }

    //trigger the explosion and set the current frame to the first one
    public void explode()
    {
        exploding = true;
        frameNum = 0;
    }
}
