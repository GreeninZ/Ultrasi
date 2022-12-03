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
        DontDestroyOnLoad(gameObject);
    }
   

    // Update is called once per frame
    void Update()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();

        Vector3 mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 aimdirection = (mousepos - transform.position).normalized;
        float angle = Mathf.Atan2(aimdirection.y, aimdirection.x) * Mathf.Rad2Deg;
        ruszanie();
        //if (angle > 90 && angle < 180 || angle < -90 && angle > -180)
        //{
        //    Flip();
        //}
        //Debug.Log(angle);
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

    //void Flip()
    //{
    //    Vector3 currentscale = gameObject.transform.localScale;
    //    currentscale.x = -1;
    //    gameObject.transform.localScale = currentscale;
    //}
    
}
