using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class healthbarbehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text tekst;
    public float hitpoints;
    public float maxhitpoints = 20;
    void Start()
    {
        hitpoints = maxhitpoints;
    }

    // Update is called once per frame
    void Update()
    {
        tekst.text = hitpoints+ "/" + maxhitpoints;    
    }
    public void sethealth(float health, float maxhealth)
    {
        hitpoints = health;
        maxhitpoints = maxhealth;
    }
    
}
