using UnityEngine;

public class ThrowPhone : MonoBehaviour
{
    public bool throwing = false;
    public float speed = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (throwing)
        {
            Vector3 rot = transform.eulerAngles;
            rot.z += speed;
            transform.eulerAngles = rot;

            Vector2 scale = transform.localScale;
            if (scale.x>0&&scale.y>0)
            {
                scale.x -= 0.001f;
                scale.y -= 0.001f;
            }
            else if (scale.x<0.00001&&scale.y<0.00001)
            {
                throwing = false;
            }
            transform.localScale = scale;
        }
    }

    public void beginThrow()
    {
        Vector3 rot2 =  transform.eulerAngles;
        if (rot2.z == 0)
		{
			throwing = true;
		}
        else
        {
            rot2.z = 0;
            transform.eulerAngles= rot2;
            Vector2 scale = transform.localScale;
            scale.x = 0.3433737f;
            scale.y = 0.3433737f;
            transform.localScale= scale;
		}
    }
}
