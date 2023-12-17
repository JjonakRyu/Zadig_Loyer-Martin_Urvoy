using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public Vector3 positionBase;

    void Start()
    {
        positionBase = transform.position;
    }

    void OnTriggerEnter(Collider truc)
    {
        if (truc.tag == "Death")
        {
            respawn();
        }
        if (truc.tag == "CheckPoint")
        {
            positionBase = transform.position;
        }
    }

    public void respawn()
    {
        transform.position = positionBase;
    }
}

