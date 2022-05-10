using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
    public GameObject ObjectToClone;
    //public GameObject clon;
    public int clones;
    public int grados;


    public void InstantiateObject()
    {
        /* int i = 0;
         while(i < 3)
         {
             Instantiate(ObjectToClone);
             i++;
         }
         */

        GameObject clon;
        for(int i = 0; i <clones; i++)
        {
            clon = Instantiate(ObjectToClone);
            clon.transform.Rotate(0, grados * i, 0);
            clon.transform.Translate(i, i, 0);
            //Destroy(clon, 1); 
        }
    }
}
