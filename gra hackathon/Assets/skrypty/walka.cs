using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walka : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("uderzenie: " + collision.gameObject.name);
        if (collision.gameObject.tag =="enemy" && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("uderzenie: " + collision.gameObject.name);
        }
    }
    
}
