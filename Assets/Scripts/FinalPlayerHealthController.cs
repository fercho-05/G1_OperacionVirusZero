using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPlayerHealthController : MonoBehaviour
{
    [SerializeField]
    float healthMedKit;

    [SerializeField]
    bool MedkitSelected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<ThirdPersonController>().HP_Min += healthMedKit;
            if (MedkitSelected)
            {
                Destroy(gameObject);
            }
        }
    }


}
