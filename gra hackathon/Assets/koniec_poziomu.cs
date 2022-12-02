using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koniec_poziomu : MonoBehaviour
{
    public GameObject[] blokady;
    public GameObject[] przeciwnicy;
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
        var counter = 0;
        foreach(var przeciwnik in przeciwnicy)
        {
            //if(przeciwnik.zycie==0)
            //{
            //    counter++;
            //}
        }
        if(counter == przeciwnicy.Length - 1)
        {
            foreach (var blokada in blokady)
            {
                Destroy(blokada);
            }
        }
    }
}
