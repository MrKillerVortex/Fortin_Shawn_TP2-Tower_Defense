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
            Debug.LogError("Il y a plus d'une scène dans le Main");
            return;
        }
        instance = this;
    }

    public GameObject cannonTurretPrefab;
    public GameObject gunTurretPrefab;
    public GameObject freezeTurretPrefab;
    private Node nodeInstance;


    private TurretBlueprint turretToBuild;
    private Node selectorNode;
    public NodeUI nodeUI;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn ()
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Pas assez d'argent");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;


        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, nodeInstance.transform.position, nodeInstance.transform.rotation);
        nodeInstance.turret = turret;

        Debug.Log("Tourelle construite ! Argent restant : " + PlayerStats.Money);
    }
    public void SelectNodeToSell(Node node)
    {
        if (selectorNode == node)
        {
            DeselectionnerNode();
            return;
        }
        selectorNode = node;
        turretToBuild = null;
        nodeUI.SetTarget(node);
    }

    public void DeselectionnerNode()
    {
        selectorNode = null;
        nodeUI.Disparaitre();
    }
    public void SelectTurretToBuild(TurretBlueprint turret)
    {

        turretToBuild = turret;
        DeselectionnerNode();
    }
    public void SelectNodeToBuild(Node p_nodeInstance)
    {
        nodeInstance = p_nodeInstance;
    }
}
