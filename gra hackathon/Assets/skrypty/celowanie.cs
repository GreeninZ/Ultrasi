using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celowanie : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 aimdirection = (mousepos - transform.position).normalized;
        float angle = Mathf.Atan2(aimdirection.y, aimdirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);

    }
}

   
