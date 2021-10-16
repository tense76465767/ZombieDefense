using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieBehavior1 : MonoBehaviour
{
    public Transform transformDest;
    public NavMeshAgent agent;
    float interval;

    // Start is called before the first frame update
    void Start()
    {
        transformDest = GameObject.FindGameObjectWithTag("House").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = transformDest.position;
        interval = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Police")
        {
            agent.destination = other.transform.position;
        }
        else
        {
            agent.destination = transformDest.position;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        interval += Time.deltaTime;
        if (interval >= 1f)
        {
            interval = 0;
            collision.gameObject.GetComponent<HealthBehavior>().currentHp -= 25;
        }
    }
}
