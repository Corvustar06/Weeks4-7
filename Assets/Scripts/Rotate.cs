using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public Slider rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void rotBird()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z = rotation.value;
        transform.eulerAngles = rot;
    }
}
