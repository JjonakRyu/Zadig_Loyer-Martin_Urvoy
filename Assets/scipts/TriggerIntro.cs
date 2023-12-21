using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerIntro : MonoBehaviour
{
    public GameObject Canvas;

    private void OnTriggerEnter(Collider other)
    {
        Canvas.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Canvas.SetActive(false);
    }

}
