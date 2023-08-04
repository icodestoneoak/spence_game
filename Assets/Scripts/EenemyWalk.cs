using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EenemyWalk : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;

    [SerializeField] float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
            Vector3 targetLocation = new Vector3(waypoints[currentWaypointIndex].transform.position.x, transform.position.y, waypoints[currentWaypointIndex].transform.position.z);
            Quaternion lookRotation = Quaternion.LookRotation(targetLocation - transform.position);
            float time = 0;
            while (time < 1)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, time);
                time += Time.deltaTime * speed;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }

}
