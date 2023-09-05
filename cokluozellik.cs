using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cokluozellik : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //string[] ad={"ali","veli","ayşe"};
        BoxCollider[] kutu=GetComponents<BoxCollider>();
        for(int i=0;i<2;i++)
        {
            kutu[i].isTrigger=true;
        }
        //GetComponent<BoxCollider>().isTrigger=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
