using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuchillo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Boss"))
        {
            coll.GetComponent<Boss>().HP_Min -=50;
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
