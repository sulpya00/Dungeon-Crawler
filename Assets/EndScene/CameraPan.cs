using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPan : MonoBehaviour
{
    //Text For Objective
    public string textValue;
    public Text textElement;

    public Vector3 moveDirection;

    // Update is called once per frame   
    void Update()
    {
        textValue = "You've escaped Puzzle Castle!";
        transform.Translate(moveDirection, Space.World);
    }
}
