using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nesneozellikler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Bu örneğimizde componentlerin özelliklerini script ile değiştireceğiz");
       GetComponent<Rigidbody>().useGravity=false;
       Debug.Log("Yerçekimi"+GetComponent<Rigidbody>().useGravity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
