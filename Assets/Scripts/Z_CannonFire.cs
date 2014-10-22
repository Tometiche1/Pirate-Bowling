using UnityEngine;
using System.Collections;

public class Z_CannonFire : MonoBehaviour {

	//global variables

	public GameObject cannonBall;
	public float zforce;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider thing){

		print (thing.gameObject.name + " hit this trigger");
		if (thing.gameObject.tag == "Player"){

			//cannonball fires at player
			cannonBall.rigidbody.constraints = RigidbodyConstraints.None;
			cannonBall.rigidbody.AddRelativeForce(0,0,zforce*1000);
			audio.Play();

		}
						;

	}
}
