using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zmianabroni : MonoBehaviour
{
    public GameObject weapon;
    public GameObject rece;
    private GameObject player;
    public GameObject maczeta;
    private bool haveweapon = false;
    private GameObject currentweapon;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        currentweapon = Instantiate(rece, transform.position, Quaternion.identity);
        currentweapon.gameObject.transform.parent = player.transform;

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) )
        {
            Destroy(currentweapon);
            currentweapon = Instantiate(weapon, transform.position, Quaternion.identity);
            currentweapon.transform.parent = player.transform;
            haveweapon = true;
            
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Destroy(currentweapon);
            currentweapon = Instantiate(rece, transform.position, Quaternion.identity);
            currentweapon.transform.parent = player.transform;
            //Instantiate(weapon, transform.position, Quaternion.identity);
            
            haveweapon = false;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(currentweapon);
            currentweapon = Instantiate(maczeta, transform.position, Quaternion.identity);
            currentweapon.transform.parent = player.transform;
        }
    }
}
