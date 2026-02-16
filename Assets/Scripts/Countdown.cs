using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Slider countDown;
    public GameObject explosions;
    public bool countingDown = false;
    public float timerMax = 10f;
	public float sliderValue;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		countDown.maxValue = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
		if (countingDown)
		{
			sliderValue += Time.deltaTime;

			if (sliderValue > timerMax)
			{
				explosions.SetActive(true);
				sliderValue = 0;
				countingDown = false;
			}
			countDown.value = sliderValue;
		}
	}

	public void startCount()
	{
		countingDown = true;
	}

	public void cancelCount()
	{
		countingDown = false;
		countDown.gameObject.SetActive(false);
		sliderValue = 0;
	}
}
