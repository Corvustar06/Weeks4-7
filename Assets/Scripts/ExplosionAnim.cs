using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ExplosionAnim : MonoBehaviour
{
    
    public List <Sprite> explosions;
    public List <Button> buttons;
    public Slider brightness;
    public Slider ExploCounter;
    public bool exploding = true;
    public int frameNum = 0;
    public float timer=0.1f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        

            if (exploding)
            {
                timer -= Time.deltaTime;
                for (int i = 0; i<buttons.Count; i++)
            {
                buttons[i].gameObject.SetActive(false);
            }
                brightness.gameObject.SetActive(false);
                ExploCounter.gameObject.SetActive(false);
            }

            if (frameNum >= explosions.Count)
            {
                exploding = false;
                SpriteRenderer sR = GetComponent<SpriteRenderer>();
                frameNum = 0;
                timer = 0.1f;
                sR.gameObject.SetActive(false);
                for(int i = 0; i < buttons.Count; i++)
            {
                buttons[i].gameObject.SetActive(true);
			}

			    brightness.gameObject.SetActive(true);

		}

            if (exploding && timer <= 0)
            {

                nextFrame();
            }

            if (timer <= 0)
            {
                timer = 0.1f;
            }
        
    }

    public void nextFrame()
    {
        SpriteRenderer sR = GetComponent<SpriteRenderer>();
        sR.sprite = explosions[frameNum];
        frameNum++;
    }

    public void explode()
    {
        exploding = true;
        frameNum = 0;
    }
}
