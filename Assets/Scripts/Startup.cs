using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour {
	
	public Transform nodes;
	public GameObject enemyPath;

	void Start () {
		// enemy path
		LineRenderer path = enemyPath.GetComponent<LineRenderer>();
		var points = new Vector3[nodes.childCount];
		for (int i=0; i<nodes.childCount; i++) {
			points[i] = nodes.GetChild(i).position;
		}
		path.positionCount = nodes.childCount;
		path.SetPositions(points);
	}
	
	void Update () {
		//if (Input.GetButtonDown("path")) {
			//enemyPath.SetActive(!enemyPath.activeSelf);
		//}
	}
}
