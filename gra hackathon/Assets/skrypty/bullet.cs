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
}
