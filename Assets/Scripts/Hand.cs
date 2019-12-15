using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {
	private int targetLayer = 1 << 8; // Layer 8 (targets)
	public GameObject goodGuy;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKeyDown("space")) {
			RaycastHit hit;
			if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, targetLayer)) {
				if (hit.collider.gameObject.tag == "planet") {
					print(hit.collider.gameObject);
					goodGuy.transform.position = hit.point;
					goodGuy.transform.LookAt(hit.collider.gameObject.transform);
					// point = hit.point;
					// tpArea.transform.position = hit.point;
				}
			}
		}
	}
}
