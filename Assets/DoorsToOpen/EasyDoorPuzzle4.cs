using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class EasyDoorPuzzle4 : MonoBehaviour
{
    public GameObject Door;
    public int doorIsOpening = 0;
    public AudioSource source;
    public AudioClip clip;
    //0 is non-moving state
    //1 moving to right state
    //2 moving to left state

    //Text For Objective

    void Update()
    {

        //OPENING THE DOOR
        if (doorIsOpening == 1)
        {
            Door.transform.position = new Vector3(86, -3, 101);
            doorIsOpening = 3;
            //if the bool is true open the door

        }

        //CLOSING BACK THE DOOR
        if (doorIsOpening == 2)
        {
            Door.transform.position = new Vector3(89, -3, 101);
            doorIsOpening = 0;
            //if the bool is true open the door

        }


    }
    void OnMouseDown()
    { //THIS FUNCTION WILL DETECT THE MOUSE CLICK ON A COLLIDER,IN OUR CASE WILL DETECT THE CLICK ON THE BUTTON
        if (Door.transform.position == new Vector3(86, Door.transform.position.y, Door.transform.position.z))
        {
            doorIsOpening = 2;
            //if we click on the button door we must start to open
        }
        if (Door.transform.position == new Vector3(89, Door.transform.position.y, Door.transform.position.z))
        {
            doorIsOpening = 1;
            //if we click on the button door we must start to open
        }

        source.PlayOneShot(clip);
    }

}