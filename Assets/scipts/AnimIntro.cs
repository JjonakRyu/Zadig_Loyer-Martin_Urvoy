using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimIntro : MonoBehaviour
{
    public KeyCode key1;

    public GameObject Intro_Porte_Gauche;
    public GameObject Intro_Porte_Droite;
    public GameObject Levier_Intro;

    void Update()
    {
        if (Input.GetKeyDown(key1))
        {
            Intro_Porte_Gauche.GetComponent<Animator>().Play("Intro_Porte_Gauche");
            Intro_Porte_Droite.GetComponent<Animator>().Play("Intro_Porte_Droite");
            Levier_Intro.GetComponent<Animator>().Play("Levier_Intro2");
        }
    }
}
