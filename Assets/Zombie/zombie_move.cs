﻿using UnityEngine;
using System.Collections;

public class zombie_move : MonoBehaviour {
	
	public float speed;

	void Update() {
		Transform target = GameObject.Find("Main Camera").GetComponent<Transform>();
		// emulates player moving past zombie
		Vector3 direction = (new Vector3(target.forward.x, 0, target.forward.z))*speed;
		transform.position = transform.position - direction;

		// face player
		Vector3 targetPostition = new Vector3( target.position.x, 
                                        this.transform.position.y, 
                                        target.position.z ) ;
 		this.transform.LookAt( targetPostition ) ;

	}
}
