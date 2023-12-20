using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOLTEST : MonoBehaviour
{
    public GameObject Levier_03;

    private void OnTriggerEnter(Collider other)
    {
        Levier_03.GetComponent<animTrigger>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Levier_03.GetComponent <animTrigger>().enabled = false;
    }

}
