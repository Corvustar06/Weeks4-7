using UnityEngine;
using UnityEngine.InputSystem;

public class Bulletshoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
