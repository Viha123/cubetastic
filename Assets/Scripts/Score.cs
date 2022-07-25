using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    public TextMeshProUGUI score;

    // Update is called once per frame
    void Start(){
        score.SetText("0");
    }
    void Update()
    {
        score.SetText(Math.Round(player.position.z).ToString());
    }
}
