using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharekterControler : MonoBehaviour {
	public float moveSpeed = 10f;
    public float rotationSpeed = 5f;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
    private Rigidbody rb;
	
	void Fire(){
		GameObject bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		bullet.GetComponent<Rigidbody>().velocity=bullet.transform.forward * 20.0f;
		Destroy(bullet,2);
	}
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {	//float moveHorizontal = Input.GetAxis ("Horizontal");
        //float moveVertical = Input.GetAxis ("Vertical");

		if (Input.GetKey("up"))
        {
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime*moveSpeed);
        }
		 if(Input.GetKey("down"))
		{
            rb.MovePosition(transform.position - transform.forward * Time.deltaTime*moveSpeed);
		}
		rb.rotation = Quaternion.Euler(rb.rotation.eulerAngles + new Vector3(0f, rotationSpeed*Input.GetAxis("Mouse X"), 0f));
        if (Input.GetMouseButtonUp(0))
		{
			Fire();
		}
    
        

		
		      
    }
}
