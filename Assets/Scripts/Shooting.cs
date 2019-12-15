﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	void Start () {
		
	}
	
	void Update () {
		
	}
	
	Transform GetClosestEnemy (List<Transform> enemies) {
		Transform bestTarget = null;
		float closestDistanceSqr = Mathf.Infinity;
		Vector3 currentPosition = transform.position;
		foreach(Transform potentialTarget in enemies) {
			Vector3 directionToTarget = potentialTarget.position - currentPosition;
			float dSqrToTarget = directionToTarget.sqrMagnitude;
			if(dSqrToTarget < closestDistanceSqr) {
					closestDistanceSqr = dSqrToTarget;
					bestTarget = potentialTarget;
			}
		}
 
		return bestTarget;
     }

}
