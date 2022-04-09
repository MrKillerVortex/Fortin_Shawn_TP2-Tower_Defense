using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MortUI : MonoBehaviour
{
    public Text MortText;

    // Update is called once per frame
    void Update()
    {
        MortText.text = PlayerStats.Mort.ToString();
    }
}

