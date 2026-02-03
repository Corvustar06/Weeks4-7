using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Ducky : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        //Was the mouse pressed this frame && the mouse isn't over the ui
        if (Mouse.current.leftButton.wasPressedThisFrame && !EventSystem.current.IsPointerOverGameObject())
        {
            //Y: move to that position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            transform.position = mousePos;
        }

    }
}
