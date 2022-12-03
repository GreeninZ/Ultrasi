using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celowaniebroni : MonoBehaviour
{
    public Camera cam;
    public GameObject bullet;
    public Transform firepoint;
    private Rigidbody2D bulletrb;
    private Vector3 mousepos;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        strzelanie();
        

    }
    void strzelanie()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, firepoint.position, Quaternion.identity);
            
        }
        
    }
}

   
