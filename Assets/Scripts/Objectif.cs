using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectif : MonoBehaviour
{
    public static Vector3 targetPos;


    void Start()
    {
        //Donne la position du chateau pour que les ennemis se dirige en direction de celui-ci
        targetPos = GetComponent<Transform>().position;
    }


    void Update()
    {
        
    }

}
