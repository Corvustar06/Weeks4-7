using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Slider countDown;	//The visual component of the timer
    public GameObject explosions; //the explosion that gets set off when the timer is done
    public bool countingDown = false; //makes the beginning of the countdown something triggerable
    public float timerMax = 10f; //the length of the timer
	public float sliderValue; //Where the timer is at
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		//makes the slider's visual max the same value
		countDown.maxValue = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
		//if the countdown has been triggered
		if (countingDown)
		{
			//start the timer
			sliderValue += Time.deltaTime;

			//if the slider reaches its end
			if (sliderValue > timerMax)
			{
				//enable the explosion
				explosions.SetActive(true);
				//reset the timer
				sliderValue = 0;
				//end the countdown
				countingDown = false;
			}
			//Show the changes
			countDown.value = sliderValue;
		}
	}

	//Triggers the start of the countdown
	public void startCount()
	{
		countingDown = true;
	}

	//cancels the countdown partway through
	public void cancelCount()
	{
		countingDown = false;
		countDown.gameObject.SetActive(false);
		sliderValue = 0;
	}
}
