using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
    public GameObject ObjectToClone;
    

    public void InstantiateObject()
    {
        int i = 0;
        while(i < 3)
        {
            Instantiate(ObjectToClone);
            i++;
        }
        
    }
}
