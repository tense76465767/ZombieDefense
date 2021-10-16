using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZmbieCollBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform transformDest;

    // Start is called before the first frame update
    void Start()
    {
        agent = transform.parent.gameObject.GetComponent<ZombieBehavior1>().agent;
        transformDest = transform.parent.gameObject.GetComponent<ZombieBehavior1>().transformDest;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Terrain")
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
    }
}
