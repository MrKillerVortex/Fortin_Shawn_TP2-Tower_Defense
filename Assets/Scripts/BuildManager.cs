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
    private Node nodeInstance;


    private TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn ()
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enough money");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;


        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, nodeInstance.transform.position, nodeInstance.transform.rotation);
        nodeInstance.turret = turret;

        Debug.Log("Turret build ! Money left : " + PlayerStats.Money);
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
    public void SelectNodeToBuild(Node p_nodeInstance)
    {
        nodeInstance = p_nodeInstance;
    }
}
