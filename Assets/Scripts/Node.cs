using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;

    public GameObject turret;
    public TurretBlueprint turretBlueprint;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            buildManager.SelectNodeToSell(this);
            return;
        }

        if (!buildManager.CanBuild)
        {
            return;
        }

        buildManager.SelectNodeToBuild(this);
        buildManager.BuildTurretOn();
    }

    public void SellTurret()
    {
        Debug.Log((PlayerStats.Money).ToString());
        PlayerStats.Money += turretBlueprint.GetSellAmount();
        Debug.Log((PlayerStats.Money).ToString());
        Destroy(turret);
        turretBlueprint = null;
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
