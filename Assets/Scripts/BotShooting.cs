using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotShooting : MonoBehaviour
{
    public Transform closest;
    public Transform tipOfGun;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0, tipOfGun.position);
        if (null == closest && Vars.enemies.Count > 0)
        {
            closest = GetClosestEnemy(Vars.enemies);
        } 
        int layerMask = 1 << 8;
        // if input
        transform.LookAt(closest);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // do raycast
            RaycastHit hit;


            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, layerMask))
            {
                print("===");
                if (hit.collider.gameObject.tag == "Asteroid")
                {
                 
                    print(hit.collider.gameObject.name);
                    
                    GetComponent<LineRenderer>().SetPosition(1, hit.point);
                    
                    Vars.enemies.Remove(hit.collider.transform);
                    Destroy(closest.gameObject);
                    closest = null;
                }
            }




            // set length of linerenderer by doing Vector3.Distance()

            // GetComponent<LineRenderer>().


        }



        // end if
    }

    Transform GetClosestEnemy(List<Transform> enemies)
    {
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (Transform potentialTarget in enemies)
        {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
            }
        }

        return bestTarget;
    }

    IEnumerator waiter()
    {
       

        //Wait for 4 seconds
        yield return new WaitForSecondsRealtime(2);

        
    }
}
