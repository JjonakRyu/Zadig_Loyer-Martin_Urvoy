using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerIntro : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Levier_Intro;

    private void OnTriggerEnter(Collider other)
    {
        Canvas.SetActive(true);
        Levier_Intro.GetComponent<AnimIntro>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Canvas.SetActive(false);
        Levier_Intro.GetComponent<AnimIntro>().enabled = false;
    }

}
