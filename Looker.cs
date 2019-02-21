using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour {

	public GameObject enamy;
	private float reset = 5;

	void Update () {

	}
	private void OnCollisionEnter(Collision collision)
{
        if (collision.gameObject.tag == "mainPlayer")
        {
            enamy.GetComponent<EnamyControler>().enabled = true;
            reset = 5;
            GetComponent<SphereCollider>().enabled = false;
        }
}
}
