using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;

    public GameObject turret;
    

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }


    void OnMouseDown()
    {
        if (!buildManager.CanBuild)
        {
            return;
        }

        if (turret != null)
        {
            Debug.Log("Can't build there! - TODO: Display on screen.");
            return;
        }

        buildManager.SelectNodeToBuild(this);
        buildManager.BuildTurretOn();
    }

    void OnMouseEnter()
    {
        if (!buildManager.CanBuild)
        {
            return;
        }

        if (buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        }
        else
        {
            rend.material.color = notEnoughMoneyColor;
        }
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
