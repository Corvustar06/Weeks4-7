using UnityEngine;
using UnityEngine.InputSystem;

public class TankMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Vector2 pos = transform.position;
            pos.x -= speed * Time.deltaTime;
            transform.position = pos;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Vector2 pos = transform.position;
            pos.x += speed * Time.deltaTime;
            transform.position = pos;
        }
    }

    public void increaseSpeed()
    {
        speed += 1;
    }

    public void decreaseSpeed()
    {
        speed -= 1;
    }
}
