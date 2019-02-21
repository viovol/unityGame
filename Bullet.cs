using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
    {	GameObject hit = collision.gameObject;
		Health health=hit.GetComponent<Health>();
		if (health!=null)//tikrina ar susikure health objektas
		{
			health.TakeDamage(10);
			
		}
		Destroy (gameObject);//naikina kulka
	}
}