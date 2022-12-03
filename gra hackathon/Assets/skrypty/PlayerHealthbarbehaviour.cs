using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthbarbehaviour : MonoBehaviour
{
    public float hitpoints;
    public float Maxhitpoints = 20;
    public healthbarbehaviour healthbar;
    // Start is called before the first frame update
    void Start()
    {
        hitpoints = Maxhitpoints;
        healthbar.sethealth(hitpoints, Maxhitpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeHit(float damage)
    {
        hitpoints -= damage;
        healthbar.sethealth(hitpoints, Maxhitpoints);
        if (hitpoints <=0)
        {
            Destroy(gameObject);
        }
    }
}
