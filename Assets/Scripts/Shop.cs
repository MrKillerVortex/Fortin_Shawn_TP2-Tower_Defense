using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint cannonTurret;
    public TurretBlueprint gunTurret;
    public TurretBlueprint freezeTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectCannonTurret()
    {
        Debug.Log("Purchase Cannon Turret");
        buildManager.SelectTurretToBuild(cannonTurret);
    }

    public void SelectGunTurret()
    {
        Debug.Log("Purchase Gun Turret");
        buildManager.SelectTurretToBuild(gunTurret);
    }

    public void SelectFreezeTurret()
    {
        Debug.Log("Purchase Freeze Turret");
        buildManager.SelectTurretToBuild(freezeTurret);
    }
}
