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
        //Sélectionner la tourelle à construire
        Debug.Log("Achat Cannon Turret");
        buildManager.SelectTurretToBuild(cannonTurret);
    }

    public void SelectGunTurret()
    {
        //Sélectionner la tourelle à construire
        Debug.Log("Achat Gun Turret");
        buildManager.SelectTurretToBuild(gunTurret);
    }

    public void SelectFreezeTurret()
    {
        //Sélectionner la tourelle à construire
        Debug.Log("Achat Freeze Turret");
        buildManager.SelectTurretToBuild(freezeTurret);
    }
}
