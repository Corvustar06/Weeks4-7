using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterHazard;
    public UnityEvent OnExitHazard;

    public UnityEvent<float> OnRandomNumber;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hazard.bounds.Contains(transform.position))
        {
            if (isInHazard)
            {

            }
            else
            {
                isInHazard = true;
                Debug.Log("Entered the hazard!");
                OnEnterHazard.Invoke();
            }
        }
        else
        {
            if (isInHazard)
            {
                isInHazard = false;
                Debug.Log("Exited the hazard!");
                OnExitHazard.Invoke();
                OnRandomNumber.Invoke(Random.Range(0,10));
            }
            else
            {

            }
        }
    }

    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
