using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayo : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1")) 
       {
        RaycastTest();
       }
    }

    void RaycastTest()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if(hit.transform.gameObject.layer == 6)
            {
                Debug.Log(hit.transform.name);
            }
            else if(hit.transform.gameObject.layer == 7)
            {
                Debug.Log(hit.transform.name);
            }
            else if(hit.transform.gameObject.layer == 8)
            {
                Debug.Log(hit.transform.name);
            }
        }
    }
}
