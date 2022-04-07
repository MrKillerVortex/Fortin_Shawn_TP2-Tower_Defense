using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseCannonTurret()
    {
        Debug.Log("Purchase Cannon Turret");
        buildManager.SetTurretToBuild(buildManager.cannonTurretPrefab);
    }

    public void PurchaseGunTurret()
    {
        Debug.Log("Purchase Gun Turret");
        buildManager.SetTurretToBuild(buildManager.gunTurretPrefab);
    }

    public void PurchaseFreezeTurret()
    {
        Debug.Log("Purchase Freeze Turret");
        buildManager.SetTurretToBuild(buildManager.freezeTurretPrefab);
    }
}
