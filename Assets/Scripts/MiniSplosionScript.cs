using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MiniSplosionScript : MonoBehaviour
{
	
	public GameObject miniSplode;
	public bool sploding = false;
	public float timer = 0.05f;
	public float splosionNum = 0.0f;
	public float splosionsAtOnce;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		if (sploding)
		{
			timer -= Time.deltaTime;
			if (timer < 0)
			{
				timer = 0.05f;
				if (splosionNum > 0)
				{
					makeSplosion();
					splosionNum-=1;
				}
				else{
					sploding = false;
				}
			}
		}

	}

	public void makeSplosion()
	{
		Vector3 randoSplode;
		randoSplode.x = Random.Range(-10, 10);
		randoSplode.y = Random.Range(-5, 5);
		randoSplode.z = 0;
		Instantiate(miniSplode, randoSplode, transform.rotation);
	}

	public void startSplosion()
	{
		sploding = true;
		splosionNum = splosionsAtOnce;
	}
}
