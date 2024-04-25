using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDamageController : MonoBehaviour
{
	[SerializeField]
	int swordDamage; //Maneja el daño de la espada.

	[SerializeField]
	int rocketDamage;

	[SerializeField]
	int health; //Maneja la vida de los enemigos -
				//(normales y jefe).

	private void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.tag == "Player")
		{
            health -= swordDamage;
		}
		
		
		if (other.gameObject.tag == "Player")
		{
			health -= rocketDamage;
		}


		if (health <= 0)
		{
			Destroy(gameObject);
		}
	}	
}

