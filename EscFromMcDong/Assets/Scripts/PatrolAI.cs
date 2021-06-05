using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolAI : MonoBehaviour
{   
    public Transform[] waypoints;
    public int speed;
    public GameManager gameManager;
    public GameObject youDied;
    private int waypointIndex;
    private float distance;

    void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            StartCoroutine(EnemyDeath());
        }
    }

    void FixedUpdate()
    {
        distance = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if(distance < 1f)
        {
            IncrementIndex();
        }
        Patrol();
    }

    private IEnumerator EnemyDeath()
    {
        youDied.SetActive(true);
        yield return new WaitForSeconds(4f);
        gameManager.EndGame();
    }

    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void IncrementIndex()
    {
        waypointIndex++;
        if(waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }
}
