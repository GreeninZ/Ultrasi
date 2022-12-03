using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealtbar : MonoBehaviour
{
    public float hitpoints;
    public float Maxhitpoints = 100;
    public healthbarbehaviour healthbar;
    // Start is called before the first frame update
    void Start()
    {
        hitpoints = Maxhitpoints;
        healthbar.sethealth(hitpoints, Maxhitpoints);
        //healthbar= FindObjectOfType
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeHit(float damage)
    {
        Debug.Log(damage);
        hitpoints -= damage;
        healthbar.sethealth(hitpoints, Maxhitpoints);
        if (hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
