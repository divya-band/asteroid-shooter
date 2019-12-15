using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vars : MonoBehaviour {
	
	public static List<Transform> enemies;
	public static GameObject frontRunner;
	public static int playerHealth = 20;
	
	void Start () {
		enemies = new List<Transform>();
	}
	
	void Update () {
		if (playerHealth <= 0) {
			print("GAME OVER");
		}
	}
}
