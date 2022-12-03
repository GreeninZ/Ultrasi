using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeenemydamage : MonoBehaviour
{
    public bool allowhit = false;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("dodamage", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void dodamage()
    {
        if (allowhit)
        {
            Debug.Log("melee enemy damage");
        }
        float randomtime = Random.Range(0.5f, 2f);
        Invoke("dodamage", randomtime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            allowhit = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            allowhit = false;
        }
    }
}
