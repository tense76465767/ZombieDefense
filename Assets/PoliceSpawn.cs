using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceSpawn : MonoBehaviour
{
    public Camera camera;
    public GameObject Police;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //agent.destination = hit.point;
                Instantiate(Police, new Vector3(hit.point.x, 1, hit.point.z), transform.rotation);
            }
        }
    }
}
