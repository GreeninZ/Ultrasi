using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celowanie : MonoBehaviour
{
    public Vector2 lookDirectionVec;
    public Camera cam;
    public Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        ruszaniemyszkiem();
        lookDirectionVec = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }

    void ruszaniemyszkiem()
    {
        float angleToRotate = Mathf.Atan2(lookDirectionVec.y, lookDirectionVec.x) * Mathf.Rad2Deg - 90f;
        Quaternion qRotation = Quaternion.AngleAxis(angleToRotate, Vector3.forward);
        transform.rotation = qRotation;
    }
}
