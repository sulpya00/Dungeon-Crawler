using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text Text;
    // Start is called before the first frame update
    public void Setup()
    {
        gameObject.SetActive(true);
        Text.text = "GameOver";
        
    }
}
