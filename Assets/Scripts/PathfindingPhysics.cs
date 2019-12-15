using UnityEngine;
using System.Collections;

public class PathfindingPhysics : MonoBehaviour {
			
	public Transform nodes;
	private int currentNode = 0;
	private int totalNodes;
	private GameObject currentNodeObj;
	
	public GameObject goal;
	
	private Rigidbody rb;
	[Range(0, 5)]
	public float factor = 1;
	public ForceMode mode;

	void Start() {
		totalNodes = nodes.childCount;
		currentNodeObj = nodes.GetChild(currentNode).gameObject;
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
        //if(currentNodeObj)
        Debug.Log(currentNodeObj);
            Vector3 g = (currentNodeObj.transform.position - transform.position) * factor;
			rb.AddForce(g, mode);
	}
	
	void OnTriggerEnter(Collider col) {
  	if (col.gameObject == currentNodeObj) {
			if (currentNode < totalNodes-1) {
				currentNode += 1;
				currentNodeObj = nodes.GetChild(currentNode).gameObject;
			} else {
				Destroy(gameObject);
			}
		} else if (col.gameObject == goal) {
			Destroy(gameObject);
			Vars.playerHealth -= 1;
		}
  }
}