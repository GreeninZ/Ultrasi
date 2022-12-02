using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class przejscie_poziomu : MonoBehaviour
{
    
    // Start is called before the first frame update
    string []sceny= {"level2", "level3" };
    Scene NazwaSceny = SceneManager.GetActiveScene();
    string nazwa;
    void Start()
    {
      nazwa = NazwaSceny.name;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "drzwi")
        {
         
            int random_scena = Random.Range(0, sceny.Length);
            SceneManager.LoadScene(sceny[random_scena]);



        }
    }
}
