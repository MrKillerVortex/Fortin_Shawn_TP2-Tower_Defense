using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VagueUI : MonoBehaviour
{
    public Text VagueText;

    // Update is called once per frame
    void Update()
    {
        VagueText.text = PlayerStats.Vague.ToString();
    }
}
