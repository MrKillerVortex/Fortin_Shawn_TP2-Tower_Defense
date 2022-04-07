using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;



    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one builmanager in scene");
            return;
        }
        instance = this;
    }

    public GameObject cannonTurretPrefab;
    public GameObject gunTurretPrefab;
    public GameObject freezeTurretPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
