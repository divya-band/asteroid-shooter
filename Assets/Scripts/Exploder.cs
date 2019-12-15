using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
   
    public float radius;
    private float timer = 13;
    void Start()
    {
        //Invoke("Explosion", 13); 
    }

    void Update()
    {
        //timer -= Time.deltaTime;
        
        //if timer is less than or equal call explosion()
        //if(timer <= 0)
        //{
            Explosion();
        //}
    }
    void Explosion()
    {
       
        Vector3 bombLocation = transform.position;
        Collider[] hitColliders = Physics.OverlapSphere(bombLocation, radius);
        int i = 0;
        while (i < hitColliders.Length)
        {
            Vars.enemies.Remove(hitColliders[i].transform);
            if(hitColliders[i].gameObject.tag != "node")
            {
                Destroy(hitColliders[i].gameObject);
            }
               

            Debug.Log("Bomb!");
            i++;
        }
    }
}
