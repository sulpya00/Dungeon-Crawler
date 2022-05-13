using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float restartDelay = 5f;
    public GameOverScreen GameOverScreen;
    public AudioClip clip;



    private void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = clip;

    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
      
        if (other.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            Camera.main.transform.parent = null;
            //Destroy(other.gameObject.GetComponent<cha>());
            //Destroy(other.gameObject.GetComponent<CharacterController>());
            //Destroy(other.gameObject);
            Invoke("Over", restartDelay);
            Invoke("Restart", restartDelay+5f);
           
           
        }
    }

    void Over()
    {
        GameOverScreen.Setup();
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
