using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bul : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("başka bir objeden "+GameObject.Find("Oyuncu").GetComponent<Ozellikler>().saglik);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
