using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void ToggleShape()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);

        ////if the game object is inactive (turned off): call SetActive passing true
        //if (!gameObject.activeInHierarchy)
        //{
        //    gameObject.SetActive(true);
        //}
        //else if (gameObject.activeInHierarchy)
        //{
        //    //otherwise(the gma eobject is active, turned on): call SetActive and pass false
        //    gameObject.SetActive(false);
    //}

    }
}
