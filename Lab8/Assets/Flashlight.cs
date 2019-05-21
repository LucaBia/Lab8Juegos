using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public AudioClip soundOn;
    public AudioClip soundOff;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (GetComponent<Light>().enabled == false)
            {
                GetComponent<Light>().enabled = true;
                GetComponent<AudioSource>().clip = soundOn;
                GetComponent<AudioSource>().Play();
            }
            else
            {
                GetComponent<Light>().enabled = false;
                GetComponent<AudioSource>().clip = soundOff;
                GetComponent<AudioSource>().Play();

            }
        }
    }
}
