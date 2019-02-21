using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnamyControler : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public GameObject player;
	public GameObject enamy;
	private NavMeshAgent agent;
	public bool canShoot=true;
	IEnumerator Fire()
    {	GameObject bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		bullet.GetComponent<Rigidbody>().velocity=bullet.transform.forward * 20.0f;
		Destroy(bullet,2);
		canShoot=false;
        yield return new WaitForSeconds(2);
		canShoot=true;
    }
	void Update (){
		agent.SetDestination(player.transform.position);

	}
	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	void FixedUpdate () {
			if(canShoot){
				StartCoroutine(Fire());
			}
	
	}
	void OnCollisionEnter(Collision collision) {
		Score score = player.GetComponent<Score>();
      if( collision.gameObject.tag.Equals("Bullet") == true ){
            enamy.SetActive(false);
			score.AddScore(10);

      }
 	}
	
}
