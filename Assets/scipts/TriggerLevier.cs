using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLevier : MonoBehaviour
{
    public GameObject Levier_Intro;

    private void OnTriggerEnter(Collider other)
    {
        Levier_Intro.GetComponent<animTrigger>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Levier_Intro.GetComponent<animTrigger>().enabled = false;
    }

}
