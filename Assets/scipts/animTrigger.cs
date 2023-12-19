using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animTrigger : MonoBehaviour
{
    public KeyCode key1;
    public GameObject Poteau_Light;
    public GameObject Sol_Left_Corner;
    public GameObject Sol_Left_Suite;
    public GameObject Sol_Left_03;
    public GameObject Sol_Left_04;
    public GameObject Sol_Var_01;
    public GameObject Sol_Var_02;
    public GameObject Sol_Var_03;
    public GameObject Sol_Var_Rotation;
    public GameObject Sol_1;
    public GameObject Levier_03;
    public GameObject Grille;
    public GameObject Light_Big;
    public GameObject Tube_Falling;
    public GameObject Carpet_Fall;


    void Update()
    {
        if (Input.GetKeyDown(key1))
        {
            Sol_1.GetComponent<Animator>().Play("Sol_1");
            Poteau_Light.GetComponent<Animator>().Play("Pteau_Light");
            Sol_Left_Corner.GetComponent<Animator>().Play("Sol_Left_Corner");
            Sol_Left_Suite.GetComponent<Animator>().Play("Sol_Left_Suite");
            Sol_Left_03.GetComponent<Animator>().Play("Sol_Left_03");
            Sol_Left_04.GetComponent<Animator>().Play("Sol_Left_04");
            Sol_Var_01.GetComponent<Animator>().Play("Sol_Var_01");
            Sol_Var_02.GetComponent<Animator>().Play("Sol_Var_02");
            Sol_Var_03.GetComponent<Animator>().Play("Sol_Var_03");
            Sol_Var_Rotation.GetComponent<Animator>().Play("Sol_Var_Rotation");
            Levier_03.GetComponent<Animator>().Play("Levier_Main");
            Grille.GetComponent<Animator>().Play("Grille"); 
            Light_Big.GetComponent<Animator>().Play("Light_Big");
            Tube_Falling.GetComponent<Animator>().Play("Tube");
            Carpet_Fall.GetComponent<Animator>().Play("Carpet_Fall");

        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (Input.GetKeyDown(key1))
    //    {
    //        Sol_1.GetComponent<Animator>().Play("Sol_1");
    //    }
    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Sol_1.GetComponent<Animator>().Play("Sol_1");
    //    }
    //}
}
