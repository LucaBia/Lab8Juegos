using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "LightRoom")
        {
            other.GetComponent<Light>().color = Color.blue;
            other.GetComponent<Light>().intensity = Mathf.Sin(Time.time) * 2;

        }

    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Light>().intensity = 0;
    }
}
