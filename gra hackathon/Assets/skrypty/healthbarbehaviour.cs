using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class healthbarbehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider healthbar; 
    
    public float hitpoints;
    public float maxhitpoints = 100;
    void Start()
    {
        hitpoints = maxhitpoints;
    }

   
    public void sethealth(float health, float maxhealth)
    {
        healthbar.value = hitpoints/maxhitpoints;
       
        hitpoints = health; 
        maxhitpoints = maxhealth;
    }
    
}
