using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klavye : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        {
            Debug.Log("klavyede a tuşunda basıldı");
        }
         if(Input.GetKeyDown("space"))
        {
            Debug.Log("klavyede boşluk tuşunda basıldı");
        }
          if(Input.GetKeyUp("w"))
        {
            Debug.Log("klavyede w tuşunda basıldı");
        }
        if(Input.GetKey("up"))
        {
            Debug.Log("klavyede yukarı tuşunda basıldı");
        }
        if(Input.GetKey("down"))
        {
            Debug.Log("klavyede aşağı tuşunda basıldı");
        }
        if(Input.GetKey("left"))
        {
            Debug.Log("klavyede sol tuşunda basıldı");
        }
        if(Input.GetKey("right"))
        {
            Debug.Log("klavyede sağ tuşunda basıldı");
        }
        if(Input.GetMouseButton(0))
        {
            Debug.Log("Mouse sol tuşa basıldı");
        }
         if(Input.GetMouseButton(1))
        {
            Debug.Log("Mouse sağ tuşa basıldı");
        }
         if(Input.GetMouseButton(2))
        {
            Debug.Log("Mouse scroll tuşuna basıldı");
        }
    }
}
