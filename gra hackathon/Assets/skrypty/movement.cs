using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public Vector2 ruch;
    public float speed;
    public Transform rece;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
       
        playerRb = gameObject.GetComponent<Rigidbody2D>();
    }
   

    // Update is called once per frame
    void Update()
    {
        
        ruszanie();
    }
    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + ruch * Time.fixedDeltaTime);
    }
    void ruszanie()
    {
        ruch.x = Input.GetAxisRaw("Horizontal") * speed;
        ruch.y = Input.GetAxisRaw("Vertical") * speed;
    }
    
    
}
