using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbetaController : MonoBehaviour
{
    [SerializeField]
    float healthProbeta;

    [SerializeField]
    bool ProbetaSelected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {            
            if (ProbetaSelected)
            {
                Destroy(gameObject);
            }
        }
    }
}
