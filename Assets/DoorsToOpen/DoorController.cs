using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;
    public AudioSource source;
    public AudioClip clip;

    //Text For Objective
    public string textValue;
    public Text textElement;

    void Update()
    {
        textElement.text = textValue;
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 1);
            //if the bool is true open the door

        }
        if (Door.transform.position.z < 120f)
        {
            doorIsOpening = false;
            //if the y of the door is > than 7 we want to stop the door
        }
    }
    void OnMouseDown()
    { //THIS FUNCTION WILL DETECT THE MOUSE CLICK ON A COLLIDER,IN OUR CASE WILL DETECT THE CLICK ON THE BUTTON
        doorIsOpening = true;
        textValue = "Figure out the order in which to press the 4 buttons";
        source.PlayOneShot(clip);
        //if we click on the button door we must start to open
    }

}