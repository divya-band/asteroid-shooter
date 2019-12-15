using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour {
	public GameObject scripts;

	public GameObject goal;
	public GameObject enemy;
	public Transform nodes;
	public Transform spawner;
	public float variance;
    public GameObject earth;

    private float timer = 0;
    void Start () {
		
	}
	
	void Update () {
        timer -= Time.deltaTime;

        //if timer is less than or equal call explosion()
        if(timer <= 0)
        { 
        //earth.GetComponent<Renderer>().material.SetColor{}
            for(int i=0; i<10; i++ )
            {
                GameObject inst = Instantiate(enemy, spawner.position + new Vector3(UnityEngine.Random.Range(0, variance), UnityEngine.Random.Range(0, variance), UnityEngine.Random.Range(0, variance)), Quaternion.identity);
                inst.GetComponent<PathfindingPhysics>().nodes = nodes;
                inst.GetComponent<PathfindingPhysics>().goal = goal;
                Vars.enemies.Add(inst.transform);
            }
            

            timer = 5;
            
		}
	}
}
