using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walka : MonoBehaviour
{
    // Start is called before the first frame update
    public enemyhealtbar enemyhb;
    private float timer;
    void Start()
    {
        //enemyhb = GameObject.FindWithTag("enemy").GetComponent<enemyhealtbar>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("uderzenie: " + collision.gameObject.name);
        if (collision.gameObject.tag =="enemy" )
        {
            if (timer > 2)
            {
                timer = 0;
                collision.gameObject.GetComponent<enemyhealtbar>().TakeHit(20);
                Debug.Log("wiadro");

            }
           
            
        }
    }
    //&& Input.GetKeyDown(KeyCode.Mouse0)   
}
