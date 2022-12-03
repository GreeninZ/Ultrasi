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
        firepoint = transform.Find("firepoint");
        bulletrb = gameObject.GetComponent<Rigidbody2D>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 aimdirection = (mousepos - transform.position).normalized;
        float angle = Mathf.Atan2(aimdirection.y, aimdirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
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

   
