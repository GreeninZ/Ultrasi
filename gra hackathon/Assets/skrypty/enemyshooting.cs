using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshooting : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;
    private float timer;
    public GameObject kartofel;
    public Transform shootpoint;
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindWithTag("Player").transform;
        Debug.Log(target);
        if (target != null)
        {
            //Debug.Log(shootpoint.position);
            Vector3 aimdirection = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(aimdirection.y, aimdirection.x) * Mathf.Rad2Deg;

            transform.eulerAngles = new Vector3(0, 0, angle);
            //transform.LookAt(target.position);
            timer += Time.deltaTime;
            float freq = Random.Range(0.5f, 2f);

            if (timer > freq)
            {
                timer = 0;
                Instantiate(kartofel, shootpoint.position, Quaternion.identity);

            }

        }


    }
}
