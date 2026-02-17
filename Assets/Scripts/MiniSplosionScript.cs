using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MiniSplosionScript : MonoBehaviour
{
	
	public GameObject miniSplode; //the prefab be instantiated
	public bool sploding = false; //triggerable explosions
	public float timer = 0.05f; //timer between instantialization of prefabs
	public float splosionNum = 0.0f; //which explosion is being initialized
	public float splosionsAtOnce; //max number of explosions triggered at once

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		//if the explosion has been triggered
		if (sploding)
		{
			//start the timer between spawning prefabs
			timer -= Time.deltaTime;
			//when the timer reaches its end
			if (timer < 0)
			{
				//reset the timer
				timer = 0.05f;
				//if the explosions haven't finished
				if (splosionNum > 0)
				{
					//trigger the prefab spawning and mark that another one has been made
					makeSplosion();
					splosionNum-=1;
				}
				//otherwise stop the explosions
				else{
					sploding = false;
				}
			}
		}

	}

	//triggerable instantializtion
	public void makeSplosion()
	{
		//random placement vector
		Vector3 randoSplode;
		randoSplode.x = Random.Range(-10, 10);
		randoSplode.y = Random.Range(-5, 5);
		randoSplode.z = 0;
		//spawn the splosion
		Instantiate(miniSplode, randoSplode, transform.rotation);
	}

	//trigger button to start the spawning of splosions
	public void startSplosion()
	{
		//starting the spawn condition
		sploding = true;
		//reseting the number explosions that can be spawned from one press at a time
		splosionNum = splosionsAtOnce;
	}
}
