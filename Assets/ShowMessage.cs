using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMessage : MonoBehaviour
{
    public GameObject micubitoo;

    public void CloneObject()
    {
        int i=0;
        while (i < 3)
        {
            i++;
            Instantiate(micubitoo);
        }
        
    }
    
}
