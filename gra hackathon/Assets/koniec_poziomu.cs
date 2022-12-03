using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koniec_poziomu : MonoBehaviour
{
    public GameObject[] blokady;
    //public GameObject[] przeciwnicy;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       SprawdzCzyZyjaPrzeciwnicy();
    }


    void SprawdzCzyZyjaPrzeciwnicy()
    {
        var counter = false;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            counter = true;
        }
        //foreach (var przeciwnik in przeciwnicy)
        //{
        //    //if(przeciwnik.zycie==0)
        //    //{
        //    //    counter++;
        //    //}
        //}
        if (counter == true)
        {
            foreach (var blokada in blokady)
            {
                Destroy(blokada);
            }
        }
    }
}
