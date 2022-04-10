using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    public GameObject UI;
    private Node target;
    public Text montantVendre;

    public void SetTarget(Node p_target)
    {
        target = p_target;


        transform.position = target.GetBuildPosition();
        montantVendre.text = target.turretBlueprint.GetSellAmount().ToString();
        UI.SetActive(true);

    }

    public void Disparaitre()
    {
        UI.SetActive(false);
    }

    public void Sell()
    {

        target.SellTurret();
        BuildManager.instance.DeselectionnerNode();

    }
}
