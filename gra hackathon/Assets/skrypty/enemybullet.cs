using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{
    public Rigidbody2D bulletrb;
    public Transform Player;
    
    private bool zrob = true;
    public PlayerHealthbarbehaviour graczhb;
    // Start is called before the first frame update
    void Start()
    {
        graczhb = GameObject.FindWithTag("Player").GetComponent<PlayerHealthbarbehaviour>();
        Player = GameObject.FindWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        //graczhb = GameObject.Find("Player");
        if (graczhb != null)
        {
            if (zrob)
            {
                // Debug.Log(Player.position);
                bulletrb.AddForce(Player.position * 3, ForceMode2D.Impulse);
                zrob = false;
            }
        }
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (graczhb != null)
        {
            if (collision.gameObject.name == "Player")
            {
                //Debug.Log("Dziala");
                graczhb.GetComponent<PlayerHealthbarbehaviour>().TakeHit(5);
            }
            Destroy(gameObject);
        }
        

    }
}
