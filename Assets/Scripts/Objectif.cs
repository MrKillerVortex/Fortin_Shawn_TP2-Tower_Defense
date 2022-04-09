using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectif : MonoBehaviour
{
    public static Vector3 targetPos;


    void Start()
    {
        targetPos = GetComponent<Transform>().position;
    }


    void Update()
    {
        
    }

}
