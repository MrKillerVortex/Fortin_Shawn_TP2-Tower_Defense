using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TurretBlueprint
{
    public GameObject prefab;
    public int cost;

    public int GetSellAmount()
    {
        Debug.Log((cost).ToString());
        return cost / 2;
    }

}
