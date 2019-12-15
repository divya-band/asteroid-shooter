using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour {
	
	public Transform nodes;
	public float speed;
	private int currentNode = 0;	
	
	void Start () {

	}
	
	void Update () {
		if (transform.position != nodes.GetChild(currentNode).position) {
			transform.position = Vector3.MoveTowards(transform.position, nodes.GetChild(currentNode).position, speed);
			// GetComponent<Rigidbody>().MovePosition(pos);
		} else if (currentNode < nodes.childCount-1) {
			currentNode = currentNode + 1;
		} else {
			Destroy(gameObject);
		}
	}
}
