using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class EasyDoorPuzzle2 : MonoBehaviour
{
    public GameObject Door;
    public GameObject Door2;
    public int doorIsOpening = 0;
    Vector3 oldPosition;

    //Audio
    public AudioSource source;
    public AudioClip clip;

    //Text For Objective
    public string textValue;
    public Text textElement;

    //0 is non-moving state
    //1 moving to right state
    //2 moving to left state

    //Text For Objective

    void Update()
    {
        //BOTH DOORS OPENING
        if (doorIsOpening == 1)
        {
            Door.transform.position = new Vector3(86, -3, 103);
            Door2.transform.position = new Vector3(86, -3, 99);
            //if the bool is true open the door

        }

        //BOTH DOORS CLOSING
        if (doorIsOpening == 2)
        {
            Door.transform.position = new Vector3(89, -3, 103);
            Door2.transform.position = new Vector3(89, -3, 99);
            //if the bool is true open the door

        }
        //BACK DOOR CLOSE/FRONT DOOR OPEN
        if (doorIsOpening == 3)
        {
            Door.transform.position = new Vector3(86, -3, 103);
            Door2.transform.position = new Vector3(89, -3, 99);
            //if the bool is true open the door

        }
        //FRONT DOOR OPEN/BACK DOOR CLOSE
        if (doorIsOpening == 4)
        {
            Door.transform.position = new Vector3(89, -3, 103);
            Door2.transform.position = new Vector3(86, -3, 99);
            //if the bool is true open the door

        }


    }
    void OnMouseDown()
    { //THIS FUNCTION WILL DETECT THE MOUSE CLICK ON A COLLIDER,IN OUR CASE WILL DETECT THE CLICK ON THE BUTTON
        if (Door.transform.position == new Vector3(86, Door.transform.position.y, Door.transform.position.z) && (Door2.transform.position == new Vector3(86, Door2.transform.position.y, Door2.transform.position.z)))
        {
            doorIsOpening = 2;
            //If door in -4 x position, we make x position to 8
        }
        if (Door.transform.position == new Vector3(89, Door.transform.position.y, Door.transform.position.z) && (Door2.transform.position == new Vector3(89, Door2.transform.position.y, Door2.transform.position.z)))
        {
            doorIsOpening = 1;
            //If door in -8 x position, we make x position to 4
        }
        if (Door.transform.position == new Vector3(89, Door.transform.position.y, Door.transform.position.z) && (Door2.transform.position == new Vector3(86, Door2.transform.position.y, Door2.transform.position.z)))
        {
            doorIsOpening = 3;
            //If door in -8 x position, we make x position to 4
        }
        if (Door.transform.position == new Vector3(86, Door.transform.position.y, Door.transform.position.z) && (Door2.transform.position == new Vector3(89, Door2.transform.position.y, Door2.transform.position.z)))
        {
            doorIsOpening = 4;
            //If door in -8 x position, we make x position to 4
        }

        if (Door.transform.position == new Vector3(86, Door.transform.position.y, Door.transform.position.z) && (Door2.transform.position == new Vector3(86, Door2.transform.position.y, Door2.transform.position.z)))
        {
            textValue = "";
        }
        source.PlayOneShot(clip);
    }

}