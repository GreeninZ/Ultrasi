using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D bulletrb;
    public Camera cam;
    private Vector3 mousepos;
    private float bulletpower = 15f;
    private bool zrobione = false;
   // public enemyhealtbar enemyhb;
    void Start()
    {
        bulletrb = gameObject.GetComponent<Rigidbody2D>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (zrobione ==false)
        {
            mousepos = cam.ScreenToWorldPoint(Input.mousePosition);

            bulletrb.AddForce(mousepos * 4, ForceMode2D.Impulse);
            zrobione = true;
        }
        
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            //Debug.Log("Dziala");
           collision.gameObject.GetComponent<enemyhealtbar>().TakeHit(20);
        }
        Destroy(gameObject);
    }
}
