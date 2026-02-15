using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class ExplosionAnim : MonoBehaviour
{
    
    public List <Sprite> explosions;
    public bool exploding = false;
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
		}
		
		if (frameNum >= explosions.Count)
        {
            exploding = false;
            SpriteRenderer sR = GetComponent<SpriteRenderer>(); 
            frameNum = 0;
			timer = 0.1f;
			sR.gameObject.SetActive(false);
            
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

    public void startExplosion()
    {
        exploding = true;
    }
}
